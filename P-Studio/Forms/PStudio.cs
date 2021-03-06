using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;
using ShrineFox.IO;

namespace P_Studio
{
    public partial class PStudio : MetroSet_UI.Forms.MetroSetForm
    {
        public static IntPtr assetPanel;
        public static IntPtr assetEditor;
        public static IntPtr scriptPanel;
        public static IntPtr scriptEditor;

        public static int formWidth;
        public static int formHeight;
        public static string assetEditorName = "";
        public static bool collapsed;
        public PStudio()
        {
            InitializeComponent();
            // Set up logging
            Output.LogPath = "log.txt";
            Output.LogControl = richTextBox_Status;
            #if DEBUG
                Output.VerboseLogging = true;
            #endif
            // Open and close dependency processes so they can be mounted to the form more quickly
            Tools.OpenAll(); Tools.CloseAll();
            // Sample Logs
            Output.Log("Program started.", ConsoleColor.Gray, true);
            Output.Log("Create a new project or load an existing one to get started.", ConsoleColor.Green, false, true);
            Output.Log("Log test.");
            // Select Game tab by default
            metroSetTabControl_Workspace.SelectedIndex = 0;
            // Set up renderer for toolstrip/menustrip
            ToolStripManager.Renderer = r;
            menuStrip_Main.Renderer = r;
            // Set icons for treeviews
            treeView_Game.ImageList = Treeview.treeViewImageList;
            treeView_Project.ImageList = Treeview.treeViewImageList;
            // Save panel handles for mounting
            assetPanel = panel_Asset.Handle;
            scriptPanel = panel_Scripting.Handle;
            // Uncollapse sidebar by default
            collapsed = false;
        }

        #region ToolstripOptions
        /* Toolstrip Options*/
        private void NewProject_Click(object sender, EventArgs e)
        {
            this.Text = $"P-Studio v0.1";
            saveProjectToolStripMenuItem.Enabled = false;
            SettingsForm.settings = new SettingsForm.Settings();
            OpenSettingsForm();
            metroSetTabControl_GameProject.SelectedIndex = 0;
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            OpenSettingsForm();
        }

        private void OpenSettingsForm(string projectPath = "")
        {
            // Load settings from form
            using (var dialog = new SettingsForm())
            {
                if (dialog.ShowDialog() != DialogResult.OK)
                    return;
            }
            LoadProject();
        }

        private void LoadProject_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.Filters.Add(new CommonFileDialogFilter("P-Studio Project", "*.yml"));
            dialog.Title = "Open Project File...";
            // Start in Projects folder
            string initialDir = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Projects");
            Directory.CreateDirectory(initialDir);
            dialog.InitialDirectory = initialDir;
            // Load Settings if YML file chosen
            var deserializer = new DeserializerBuilder().WithNamingConvention(PascalCaseNamingConvention.Instance).Build();
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                SettingsForm.settings = deserializer.Deserialize<SettingsForm.Settings>(File.ReadAllText(dialog.FileName));
                LoadProject();
            }
            metroSetTabControl_GameProject.SelectedIndex = 1;
        }

        private void LoadProject()
        {
            if (SettingsForm.IsValid())
            {
                this.Text = $"P-Studio v0.1 - {SettingsForm.settings.ProjectName}";
                Treeview_Project();
                Treeview_Game();
                saveProjectToolStripMenuItem.Enabled = true;
            }
        }

        private void SaveProjectAs_Click(object sender, EventArgs e)
        {
            if (SettingsForm.IsValid())
            {
                string originalProj = SettingsForm.settings.ProjectPath;
                string projDir = Path.GetDirectoryName(originalProj);
                string newName = "";
                RenameForm rename = new RenameForm(Path.GetFileNameWithoutExtension(originalProj));
                var result = rename.ShowDialog();
                if (result == DialogResult.OK)
                {
                    newName = rename.RenameText;
                    string newProj = Path.Combine(Path.GetDirectoryName(projDir), Path.Combine(newName, newName + ".yml"));
                    if (!Directory.Exists(Path.GetDirectoryName(newProj)))
                    {
                        SettingsForm.settings.ProjectName = newName;
                        SettingsForm.settings.ProjectPath = newProj;
                        Output.Log($"[INFO] Copying project files from \"{Path.GetFileNameWithoutExtension(originalProj)}\" to \"{Path.GetFileNameWithoutExtension(newProj)}\"");
                        // Copy all project files to new directory
                        Unpacker.CopyEntireDirectory(new DirectoryInfo(projDir), new DirectoryInfo(Path.GetDirectoryName(newProj)), true);
                        // Delete original project file copied with other project stuff
                        File.Delete(Path.Combine(Path.GetDirectoryName(newProj), Path.GetFileName(originalProj)));
                        // Save and reload new project
                        SettingsForm.SaveSettings();
                        LoadProject();
                    }
                    else
                        Output.Log($"[ERROR] Failed to save project as \"{newName}\", directory already exists");
                }
            }
        }
        #endregion

        #region TreeViewEvents
        /* Treeview setup */
        private void Treeview_Project()
        {
            var projectExpansionState = treeView_Project.Nodes.GetExpansionState();

            treeView_Project.Nodes.Clear();
            if (Directory.Exists(Path.GetDirectoryName(SettingsForm.settings.ProjectPath)))
                Treeview.BuildTree(new DirectoryInfo(Path.GetDirectoryName(SettingsForm.settings.ProjectPath)), treeView_Project.Nodes);
            treeView_Project.Nodes.SetExpansionState(projectExpansionState);
        }

        private void Treeview_Game()
        {
            var gameExpansionState = treeView_Game.Nodes.GetExpansionState();
            treeView_Game.Nodes.Clear();
            if (Directory.Exists(SettingsForm.settings.ExtractedPath))
                Treeview.BuildTree(new DirectoryInfo(SettingsForm.settings.ExtractedPath), treeView_Game.Nodes);
            treeView_Game.Nodes.SetExpansionState(gameExpansionState);
        }

        /* Treeview Events */
        private void AddToProject_Click(object sender, EventArgs e)
        {
            if (treeView_Game.SelectedNode != null)
            {
                string file = treeView_Game.SelectedNode.Name;
                if (Directory.Exists(file))
                    Unpacker.CopyEntireDirectory(new DirectoryInfo(file), new DirectoryInfo(file.Replace(SettingsForm.settings.ExtractedPath, Path.GetDirectoryName(Path.GetFullPath(SettingsForm.settings.ProjectPath)))));
                else if (File.Exists(file))
                {
                    string copiedFile = file.Replace(SettingsForm.settings.ExtractedPath, Path.GetDirectoryName(Path.GetFullPath(SettingsForm.settings.ProjectPath)));
                    Directory.CreateDirectory(Path.GetDirectoryName(copiedFile));
                    File.Copy(file, copiedFile);
                }
                else
                {
                    Output.Log($"[ERROR] Failed to copy {Path.GetFileName(file)} to project.");
                    return;
                }
                Output.Log($"[INFO] Copied {Path.GetFileName(file)} to project.");
                Treeview_Project();
            }
            HideContextMenus();
        }

        private void OpenLocationGame_Click(object sender, EventArgs e)
        {
            if (treeView_Game.SelectedNode != null)
            {
                string file = treeView_Game.SelectedNode.Name;
                Treeview.OpenLocation(file);
            }
            HideContextMenus();
        }

        private void OpenLocationProject_Click(object sender, EventArgs e)
        {
            if (treeView_Project.SelectedNode != null)
            {
                string file = treeView_Project.SelectedNode.Name;
                Treeview.OpenLocation(file);
            }
            HideContextMenus();
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            if (treeView_Project.SelectedNode != null)
            {
                string originalName = treeView_Project.SelectedNode.Name;
                if (File.Exists(originalName) || Directory.Exists(originalName))
                {
                    string dir = Path.GetDirectoryName(originalName);
                    string newName = "";
                    RenameForm rename = new RenameForm(Path.GetFileNameWithoutExtension(originalName));
                    var result = rename.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        newName = Path.Combine(dir, rename.RenameText) + Path.GetExtension(originalName);
                        if (File.Exists(originalName) && !File.Exists(newName))
                        {
                            File.Copy(originalName, newName);
                            Output.Log($"[INFO] Copied \"{Path.GetFileName(originalName)}\" as \"{Path.GetFileName(newName)}\"");
                        }
                        else if (Directory.Exists(originalName) && !Directory.Exists(newName))
                        {
                            Unpacker.CopyEntireDirectory(new DirectoryInfo(originalName), new DirectoryInfo(newName));
                            Output.Log($"[INFO] Copied \"{Path.GetFileName(originalName)}\" as \"{Path.GetFileName(newName)}\"");
                        }
                        else
                            Output.Log($"[ERROR] Failed to copy \"{Path.GetFileName(originalName)}\" as \"{Path.GetFileName(newName)}\", file already exists");
                    }
                    Treeview_Project();
                }
                else
                    Output.Log($"[ERROR] Failed to copy \"{Path.GetFileName(originalName)}\", file or folder does not exist");
            }
        }

        private void Rename_Click(object sender, EventArgs e)
        {
            string originalName = treeView_Project.SelectedNode.Name;
            if (treeView_Project.SelectedNode != null)
            {
                string dir = Path.GetDirectoryName(originalName);
                string newName = "";
                RenameForm rename = new RenameForm(Path.GetFileNameWithoutExtension(originalName));
                var result = rename.ShowDialog();
                if (result == DialogResult.OK)
                {
                    newName = Path.Combine(dir, rename.RenameText) + Path.GetExtension(originalName);
                    if (File.Exists(originalName) && !File.Exists(newName))
                    {
                        File.Move(originalName, newName);
                        Output.Log($"[INFO] Renamed \"{Path.GetFileName(originalName)}\" to \"{Path.GetFileName(newName)}\"");
                    }
                    else if (Directory.Exists(originalName) && !Directory.Exists(newName))
                    {
                        Directory.Move(treeView_Project.SelectedNode.Name, newName);
                        Output.Log($"[INFO] Renamed \"{Path.GetFileName(originalName)}\" to \"{Path.GetFileName(newName)}\"");
                    }
                    else
                        Output.Log($"[ERROR] Failed to rename \"{Path.GetFileName(originalName)}\" to \"{Path.GetFileName(newName)}\", file already exists");
                    Treeview_Project();
                }
            }
        }

        private void RemoveFromProject_Click(object sender, EventArgs e)
        {
            if (treeView_Project.SelectedNode != null)
            {
                string file = treeView_Project.SelectedNode.Name;
                if (Directory.Exists(file))
                {
                    Directory.Delete(file, true);
                    Output.Log($"[INFO] Deleted directory and contents: {Path.GetFileName(file)}.");
                }
                else if (File.Exists(file))
                {
                    File.Delete(file);
                    Output.Log($"[INFO] Deleted file: {Path.GetFileName(file)}.");
                }
                else
                {
                    Output.Log($"[ERROR] Couldn't find file to delete: {Path.GetFileName(file)}.");
                    return;
                }
                Treeview_Project();
            }
            HideContextMenus();
        }

        /* Load program in asset viewer and load selected file */
        private void ProjectNode_DoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                treeView_Project.SelectedNode = e.Node;
                var ext = Path.GetExtension(treeView_Project.SelectedNode.Name).ToLower();
                switch (ext)
                {
                    case ".acx":
                    case ".rmd":
                    case ".rws":
                    case ".tmx":
                    case ".spr":
                    case ".bin":
                    case ".arc":
                    case ".amd":
                    case ".pac":
                    case ".pak":
                        Tools.Mount(Program.processList[0], treeView_Project.SelectedNode.Name, assetPanel);
                        metroSetTabControl_Workspace.SelectedIndex = 0;
                        break;
                    case ".gmd":
                    case ".gfs":
                    case ".gap":
                    case ".gnf":
                    case ".gtxd":
                    case ".gmtd":
                    case ".gmt":
                    case ".ganm":
                    case ".gmod":
                    case ".dds":
                    case ".epl":
                        Tools.Mount(Program.processList[1], treeView_Project.SelectedNode.Name, assetPanel);
                        metroSetTabControl_Workspace.SelectedIndex = 0;
                        break;
                    case ".flow":
                    case ".msg":
                    case ".json":
                    case ".txt":
                    case ".yml":
                    case ".bat":
                    case ".xml":
                        Tools.Mount(Program.processList[2], treeView_Project.SelectedNode.Name, scriptPanel);
                        metroSetTabControl_Workspace.SelectedIndex = 1;
                        break;
                    default:
                        break;
                }
            }
        }

        /* Open/close right click treeview node context menus */
        private void GameNode_MouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ToolStripMenuItem_Add.Visible = true;
                ToolStripMenuItem_ExpandGame.Visible = true;
                ToolStripMenuItem_CollapseGame.Visible = true;

                treeView_Game.SelectedNode = e.Node;

                // Prevent deleting entire project or project settings file
                if (treeView_Game.SelectedNode.Parent == null || treeView_Game.SelectedNode.Parent.Parent == null)
                    ToolStripMenuItem_Add.Visible = false;
                // Hide expand/collapse if not folder
                if (treeView_Game.SelectedNode.ImageIndex != 18)
                {
                    ToolStripMenuItem_ExpandGame.Visible = false;
                    ToolStripMenuItem_CollapseGame.Visible = false;
                }

                contextMenuStrip_Game.Show(Cursor.Position);
            }

        }
        private void ProjectNode_MouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ToolStripMenuItem_Copy.Visible = true;
                ToolStripMenuItem_Rename.Visible = true;
                ToolStripMenuItem_Remove.Visible = true;
                ToolStripMenuItem_ExpandProj.Visible = true;
                ToolStripMenuItem_CollapseProj.Visible = true;
                ToolStripMenuItem_New.Visible = true;
                ToolStripMenuItem_RepackAs.Visible = true;
                ToolStripMenuItem_Replace.Visible = true;
                ToolStripMenuItem_Unpack.Visible = true;
                ToolStripMenuItem_Compile.Visible = true;
                ToolStripMenuItem_Decompile.Visible = true;

                treeView_Project.SelectedNode = e.Node;
                // Hide add to project option if topmost two levels (Game/Archive) 
                // to prevent copying entire game/archive's worth of data
                if (treeView_Project.SelectedNode.Parent == null || treeView_Project.SelectedNode.Name.ToLower().EndsWith(".yml"))
                {
                    ToolStripMenuItem_Copy.Visible = false;
                    ToolStripMenuItem_Rename.Visible = false;
                    ToolStripMenuItem_Remove.Visible = false;
                }
                // Hide (de)compile, new, repack, replace & expand/collapse, unpack
                if (!Treeview.decompileTreeViewTypes.Any(x => x.Equals(Path.GetExtension(treeView_Project.SelectedNode.Name).ToLower())))
                    ToolStripMenuItem_Decompile.Visible = false;
                if (!Treeview.compileTreeViewTypes.Any(x => x.Equals(Path.GetExtension(treeView_Project.SelectedNode.Name).ToLower())))
                    ToolStripMenuItem_Compile.Visible = false;
                if (treeView_Project.SelectedNode.ImageIndex != 18)
                {
                    ToolStripMenuItem_ExpandProj.Visible = false;
                    ToolStripMenuItem_CollapseProj.Visible = false;
                    ToolStripMenuItem_New.Visible = false;
                    ToolStripMenuItem_RepackAs.Visible = false;
                }
                else
                    ToolStripMenuItem_Replace.Visible = false;
                if (!Treeview.unpackTreeViewTypes.Any(x => x.Equals(Path.GetExtension(treeView_Project.SelectedNode.Name).ToLower())))
                    ToolStripMenuItem_Unpack.Visible = false;
                contextMenuStrip_Project.Show(Cursor.Position);
            }
        }

        /* Toggle file browser and log */
        private void ShowHide_Click(object sender, EventArgs e)
        {
            if (!collapsed)
            {
                tableLayoutPanel_Main.ColumnStyles[0].SizeType = SizeType.AutoSize;
                tableLayoutPanel_Main.HideColumns(new int[] { 0 });
                tableLayoutPanel_Workspace.HideRows(new int[] { 1 });
                metroSetButton_ShowHide.Text = "»";
                collapsed = true;
            }
            else
            {
                tableLayoutPanel_Main.ShowColumns(new int[] { 0 });
                tableLayoutPanel_Workspace.ShowRows(new int[] { 1 });
                tableLayoutPanel_Main.ColumnStyles[0].SizeType = SizeType.Percent;
                tableLayoutPanel_Main.ColumnStyles[0].Width = 28f;
                metroSetButton_ShowHide.Text = "«";
                collapsed = false;
            }
        }
        private void HideContextMenus()
        {
            contextMenuStrip_Project.Hide();
            contextMenuStrip_Game.Hide();
        }

        /* Dump Menustrip Items */
        private void DumpTextures_Click(object sender, EventArgs e)
        {
            string unpackedDir = $@"{Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)}\Extracted\{SettingsForm.settings.Game}";
            if (Unpacker.IsDumpReady(true))
                Unpacker.DumpTextures(unpackedDir, SettingsForm.settings.Game);
        }
        #endregion

        #region Rendering
        /* Improve menustrip rendering for dark theme */
        ToolStripProfessionalRenderer r =
            new ToolStripProfessionalRenderer(new MyColorTable(Color.FromArgb(255, 20, 20, 20)));
        public class MyColorTable : ProfessionalColorTable
        {
            private Color menuItemSelectedColor;
            public MyColorTable(Color color) : base()
            {
                menuItemSelectedColor = color;
            }
            public override Color MenuItemSelected
            {
                get { return menuItemSelectedColor; }
            }
        }

        /* Resize windows within panel */
        private void MainForm_Resize(object sender, EventArgs e)
        {
            int formWidth = panel_Asset.Width;
            int formHeight = panel_Asset.Height;
            if (assetEditor != null)
                Tools.MoveWindow(assetEditor, 0, 0, formWidth, formHeight, true);
            if (scriptEditor != null)
                Tools.MoveWindow(scriptEditor, 0, 0, formWidth, formHeight, true);
        }
        #endregion

    }

    /* Toggle TableLayoutPanel rows/columns that are set to autosize */
    public static class TableLayoutPanelExtensions
    {
        public static void HideRows(this TableLayoutPanel panel, params int[] rowNumbers)
        {
            foreach (Control c in panel.Controls)
                if (rowNumbers.Contains(panel.GetRow(c)))
                    c.Visible = false;
        }
        public static void ShowRows(this TableLayoutPanel panel, params int[] rowNumbers)
        {
            foreach (Control c in panel.Controls)
                if (rowNumbers.Contains(panel.GetRow(c)))
                    c.Visible = true;
        }
        public static void HideColumns(this TableLayoutPanel panel, params int[] colNumbers)
        {
            foreach (Control c in panel.Controls)
                if (colNumbers.Contains(panel.GetColumn(c)))
                    c.Visible = false;
        }
        public static void ShowColumns(this TableLayoutPanel panel, params int[] colNumbers)
        {
            foreach (Control c in panel.Controls)
                if (colNumbers.Contains(panel.GetColumn(c)))
                    c.Visible = true;
        }
    }
}
