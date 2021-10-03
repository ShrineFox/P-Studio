using MetroSet_UI.Controls;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;
using WindowsInput.Native;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace P_Studio
{
    public partial class PStudio : MetroSet_UI.Forms.MetroSetForm
    {
        public static IntPtr assetPanelHandle;
        public static IntPtr assetEditorHandle;
        public static IntPtr scriptingPanelHandle;
        public static IntPtr scriptEditorHandle;
        public static int formWidth;
        public static int formHeight;
        public static string assetEditor = "";
        public PStudio()
        {
            InitializeComponent();
            Program.status = new Status(this.richTextBox_Status);
            Program.status.Update("Create a new project or load an existing one to get started.");
            ToolStripManager.Renderer = r;
            menuStrip_Main.Renderer = r;
            treeView_Game.ImageList = Treeview.treeViewImageList;
            treeView_Project.ImageList = Treeview.treeViewImageList;
            assetPanelHandle = panel_Asset.Handle;
            scriptingPanelHandle = panel_Scripting.Handle;
        }

        /* Toolstrip Options */

        private void NewProject_Click(object sender, EventArgs e)
        {
            this.Text = $"P-Studio v0.1";
            saveProjectToolStripMenuItem.Enabled = false;
            SettingsForm.settings = new SettingsForm.Settings();
            OpenSettingsForm();
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
                    binMerge.CopyEntireDirectory(new DirectoryInfo(file), new DirectoryInfo(file.Replace(SettingsForm.settings.ExtractedPath, Path.GetDirectoryName(Path.GetFullPath(SettingsForm.settings.ProjectPath)))));
                else if (File.Exists(file))
                {
                    string copiedFile = file.Replace(SettingsForm.settings.ExtractedPath, Path.GetDirectoryName(Path.GetFullPath(SettingsForm.settings.ProjectPath)));
                    Directory.CreateDirectory(Path.GetDirectoryName(copiedFile));
                    File.Copy(file, copiedFile);
                }
                else
                {
                    Program.status.Update($"[ERROR] Failed to copy {Path.GetFileName(file)} to project.");
                    return;
                }
                Program.status.Update($"[INFO] Copied {Path.GetFileName(file)} to project.");
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
                        Program.status.Update($"[INFO] Copying project files from \"{Path.GetFileNameWithoutExtension(originalProj)}\" to \"{Path.GetFileNameWithoutExtension(newProj)}\"");
                        // Copy all project files to new directory
                        binMerge.CopyEntireDirectory(new DirectoryInfo(projDir), new DirectoryInfo(Path.GetDirectoryName(newProj)), true);
                        // Delete original project file copied with other project stuff
                        File.Delete(Path.Combine(Path.GetDirectoryName(newProj), Path.GetFileName(originalProj)));
                        // Save and reload new project
                        SettingsForm.SaveSettings();
                        LoadProject();
                    }
                    else
                        Program.status.Update($"[ERROR] Failed to save project as \"{newName}\", directory already exists");
                }
            }
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
                            Program.status.Update($"[INFO] Copied \"{Path.GetFileName(originalName)}\" as \"{Path.GetFileName(newName)}\"");
                        }
                        else if (Directory.Exists(originalName) && !Directory.Exists(newName))
                        {
                            binMerge.CopyEntireDirectory(new DirectoryInfo(originalName), new DirectoryInfo(newName));
                            Program.status.Update($"[INFO] Copied \"{Path.GetFileName(originalName)}\" as \"{Path.GetFileName(newName)}\"");
                        }
                        else
                            Program.status.Update($"[ERROR] Failed to copy \"{Path.GetFileName(originalName)}\" as \"{Path.GetFileName(newName)}\", file already exists");
                    }
                    Treeview_Project();
                }
                else
                    Program.status.Update($"[ERROR] Failed to copy \"{Path.GetFileName(originalName)}\", file or folder does not exist");
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
                        Program.status.Update($"[INFO] Renamed \"{Path.GetFileName(originalName)}\" to \"{Path.GetFileName(newName)}\"");
                    }
                    else if (Directory.Exists(originalName) && !Directory.Exists(newName))
                    {
                        Directory.Move(treeView_Project.SelectedNode.Name, newName);
                        Program.status.Update($"[INFO] Renamed \"{Path.GetFileName(originalName)}\" to \"{Path.GetFileName(newName)}\"");
                    }
                    else
                        Program.status.Update($"[ERROR] Failed to rename \"{Path.GetFileName(originalName)}\" to \"{Path.GetFileName(newName)}\", file already exists");
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
                    Program.status.Update($"[INFO] Deleted directory and contents: {Path.GetFileName(file)}.");
                }
                else if (File.Exists(file))
                {
                    File.Delete(file);
                    Program.status.Update($"[INFO] Deleted file: {Path.GetFileName(file)}.");
                }
                else
                {
                    Program.status.Update($"[ERROR] Couldn't find file to delete: {Path.GetFileName(file)}.");
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
                switch(ext)
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
                        Tools.Mount(".\\Dependencies\\Amicitia\\Amicitia.exe", treeView_Project.SelectedNode.Name, assetPanelHandle);
                        break;
                    case ".flow":
                    case ".msg":
                    case ".json":
                    case ".txt":
                    case ".yml":
                    case ".bat":
                    case ".xml":
                        Tools.Mount(".\\Dependencies\\notepad++\\notepad++.exe", treeView_Project.SelectedNode.Name, scriptingPanelHandle);
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
                treeView_Game.SelectedNode = e.Node;
                // Prevent deleting entire project or project settings file
                if (treeView_Game.SelectedNode.Parent == null || treeView_Game.SelectedNode.Parent.Parent == null)
                    metroSetToolStripMenuItem_Add.Visible = false;
                else
                    metroSetToolStripMenuItem_Add.Visible = true;
                metroSetContextMenuStrip_Game.Show(Cursor.Position);
            }

        }
        private void ProjectNode_MouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                treeView_Project.SelectedNode = e.Node;
                // Hide add to project option if topmost two levels (Game/Archive) 
                // to prevent copying entire game/archive's worth of data
                if (treeView_Project.SelectedNode.Parent == null || treeView_Project.SelectedNode.Name.ToLower().EndsWith(".yml"))
                {
                    metroSetToolStripMenuItem_Copy.Visible = false;
                    metroSetToolStripMenuItem_Rename.Visible = false;
                    metroSetToolStripMenuItem_Remove.Visible = false;
                }
                else
                {
                    metroSetToolStripMenuItem_Copy.Visible = true;
                    metroSetToolStripMenuItem_Rename.Visible = true;
                    metroSetToolStripMenuItem_Remove.Visible = true;
                }
                metroSetContextMenuStrip_Project.Show(Cursor.Position);
            }
        }
        private void HideContextMenus()
        {
            metroSetContextMenuStrip_Project.Hide();
            metroSetContextMenuStrip_Game.Hide();
        }

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
            if (assetEditorHandle != null)
                Tools.MoveWindow(assetEditorHandle, 0, 0, formWidth, formHeight, true);
            if (scriptEditorHandle != null)
                Tools.MoveWindow(scriptEditorHandle, 0, 0, formWidth, formHeight, true);
        }
    }

    /* Append to Status Text from other classes and forms */
    public class Status
    {
        RichTextBox rtb;
        public Status(RichTextBox rtb)
        {
            this.rtb = rtb;
        }

        public void Update(string msg)
        {
            rtb.Text += "\n" + msg;
            rtb.SelectionStart = rtb.Text.Length;
            rtb.ScrollToCaret();
        }
    }
}
