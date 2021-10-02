using MetroSet_UI.Controls;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
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
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace P_Studio
{
    public partial class PStudio : MetroSet_UI.Forms.MetroSetForm
    {
        public static IntPtr panelHandle;
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
            panelHandle = panel_Asset.Handle;
        }

        /* Toolstrip Options */

        private void NewProject_Click(object sender, EventArgs e)
        {
            this.Text = $"P-Studio v0.1";
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
                // Enable, select and load Project file view
                Treeview_Project();
                Treeview_Game();
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
                        Tools.Mount(".\\Dependencies\\Amicitia\\Amicitia.exe", treeView_Project.SelectedNode.Name);
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
                    metroSetToolStripMenuItem_Remove.Visible = false;
                else
                    metroSetToolStripMenuItem_Remove.Visible = true;
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
            int formWidth = Width;
            int formHeight = Height;
            if (Tools.sessions.Count > 0)
            {
                var pHandle = (Process)Tools.sessions[0];
                if (pHandle != null)
                    Tools.MoveWindow(pHandle.MainWindowHandle, 0, 0, Width, Height, true);
            }
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
