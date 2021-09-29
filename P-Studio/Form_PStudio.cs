using DarkUI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P_Studio;
using System.IO;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;
using Microsoft.WindowsAPICodePack.Dialogs;
using DarkUI.Controls;
using System.Resources;
using System.Diagnostics;
using System.Threading;

namespace P_Studio
{
    public partial class Form_PStudio : DarkForm
    {
        public Form_PStudio()
        {
            InitializeComponent();
            Program.status = new Status(darkTextBox_Status);
            UpdateTips("Create a new project or open an existing one to get started.");
        }

        private void NewProject_Click(object sender, EventArgs e)
        {
            this.Text = $"P-Studio v0.1";
            Form_Project.settings = new Form_Project.Settings();
            OpenSettingsForm();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            OpenSettingsForm();
        }

        private void OpenSettingsForm(string projectPath = "")
        {
            // Load settings from form
            using (var dialog = new Form_Project())
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
                Form_Project.settings = deserializer.Deserialize<Form_Project.Settings>(File.ReadAllText(dialog.FileName));
                LoadProject();
            }
        }

        private void LoadProject()
        {
            if (Form_Project.IsValid())
            {
                this.Text = $"P-Studio v0.1 - {Form_Project.settings.ProjectName}";
                // Enable, select and load Project file view
                Treeview_Project();
                Treeview_Game();
                ExpandAll();
            }
        }

        private void Treeview_Project()
        {
            darkTreeView_Project.Nodes.Clear();
            if (Directory.Exists(Path.GetDirectoryName(Form_Project.settings.ProjectPath)))
                darkTreeView_Project.Nodes.Add(LoadDirectory(Path.GetDirectoryName(Form_Project.settings.ProjectPath)));

        }

        private void Treeview_Game()
        {
            darkTreeView_Game.Nodes.Clear();
            if (Directory.Exists(Form_Project.settings.ExtractedPath))
                darkTreeView_Game.Nodes.Add(LoadDirectory(Form_Project.settings.ExtractedPath));
        }

        public DarkTreeNode LoadDirectory(string dir)
        {
            DirectoryInfo di = new DirectoryInfo(dir);
            DarkTreeNode tds = new DarkTreeNode(di.Name);
            tds.Tag = di.FullName;
            tds.Icon = Properties.Resources.folder;
            tds.ExpandedIcon = Properties.Resources.folder;

            tds.Nodes.Add(LoadSubDirectories(dir));
            foreach (var node in LoadFiles(dir).Nodes)
                tds.Nodes.Add(node);

            return tds;
        }

        private static DarkTreeNode LoadSubDirectories(string dir)
        {
            // Get all subdirectories  
            string[] subdirectoryEntries = Directory.GetDirectories(dir);
            DarkTreeNode tds = new DarkTreeNode(Path.GetFileName(dir));
            tds.Icon = Properties.Resources.folder;
            tds.ExpandedIcon = Properties.Resources.folder;
            // Loop through them to see if they have any other subdirectories  
            foreach (string subdirectory in subdirectoryEntries)
            {
                DirectoryInfo di = new DirectoryInfo(subdirectory);
                DarkTreeNode td = new DarkTreeNode(Path.GetFileName(di.Name));

                td.Icon = Properties.Resources.folder;
                td.ExpandedIcon = Properties.Resources.folder;
                td.Tag = di.FullName;
                foreach (var node in LoadSubDirectories(subdirectory).Nodes)
                    td.Nodes.Add(node);
                foreach (var node in LoadFiles(subdirectory).Nodes)
                    td.Nodes.Add(node);
                tds.Nodes.Add(td);
            }
            return tds;
        }

        public static DarkTreeNode LoadFiles(string dir)
        {
            var excludedFileTypes = new List<string> { "bf", "bmd", "pac", "pak", "bin", "amd", "yml" };
            List<string> files = Directory.GetFiles(dir, "*.*").Where(x => !excludedFileTypes.Any(y => x.ToLower().EndsWith(y))).ToList();
            DarkTreeNode td = new DarkTreeNode();
            // Loop through them to see files  
            foreach (string file in files)
            {
                FileInfo fi = new FileInfo(file);
                DarkTreeNode tds = new DarkTreeNode(fi.Name);

                switch (Path.GetExtension(file).ToLower())
                {
                    case ".adx":
                    case ".acb":
                    case ".awb":
                    case ".wav":
                        tds.Icon = Properties.Resources.music;
                        break;
                    case ".bf":
                        tds.Icon = Properties.Resources.script_code_red;
                        break;
                    case ".bmd":
                        tds.Icon = Properties.Resources.script_code;
                        break;
                    case ".flow":
                        tds.Icon = Properties.Resources.script_edit;
                        break;
                    case ".msg":
                    case ".txt":
                        tds.Icon = Properties.Resources.page_white_text;
                        break;
                    case ".bat":
                    case ".yml":
                        tds.Icon = Properties.Resources.script_gear;
                        break;
                    case ".exe":
                        tds.Icon = Properties.Resources.application_xp_terminal;
                        break;
                    case ".dll":
                        tds.Icon = Properties.Resources.database;
                        break;
                    case ".tbl":
                        tds.Icon = Properties.Resources.table;
                        break;
                    case ".bin":
                    case ".arc":
                    case ".amd":
                    case ".pac":
                    case ".pak":
                    case ".cpk":
                    case ".cvm":
                        tds.Icon = Properties.Resources.package_green;
                        break;
                    case ".gmd":
                    case ".gfs":
                    case ".gap":
                    case ".rmd":
                    case ".rws":
                        tds.Icon = Properties.Resources.world;
                        break;
                    case ".tmx":
                    case ".tm2":
                    case ".dds":
                    case ".png":
                    case ".bmp":
                    case ".tga":
                    case ".gnf":
                        tds.Icon = Properties.Resources.image;
                        break;
                    case ".spr":
                        tds.Icon = Properties.Resources.picture;
                        break;
                    case ".fnt":
                        tds.Icon = Properties.Resources.font;
                        break;
                    case ".sfd":
                    case ".umd":
                    case ".mp4":
                    case ".avi":
                        tds.Icon = Properties.Resources.film;
                        break;
                    case ".plg":
                        tds.Icon = Properties.Resources.vector;
                        break;
                    case ".iso":
                    case ".img":
                        tds.Icon = Properties.Resources.cd;
                        break;
                    case ".epl":
                        tds.Icon = Properties.Resources.chart_organisation;
                        break;
                    default:
                        tds.Icon = Properties.Resources.page_white;
                        break;
                }
                tds.Tag = fi.FullName;
                td.Nodes.Add(tds);
            }

            return td;
        }

        public void UpdateTips(string tip)
        {
            darkTextBox_Tips.Text = tip;
        }

        public void ExpandAll()
        {
            if (darkTreeView_Project.Nodes != null)
            {
                foreach (var node in darkTreeView_Project.Nodes)
                {
                    node.Expanded = true;
                    foreach (var node2 in node.Nodes)
                    {
                        node2.Expanded = true;
                        foreach (var node3 in node2.Nodes)
                            node3.Expanded = true;
                    }
                }
            }
            if (darkTreeView_Game.Nodes != null)
            {
                foreach (var node in darkTreeView_Game.Nodes)
                {
                    node.Expanded = true;
                    foreach (var node2 in node.Nodes)
                        node2.Expanded = true;
                }
            }
        }

        public void ExpandToNode(string path)
        {
            if (darkTreeView_Project.Nodes.Any(x => x.Tag.ToString().Contains(path)))
            {
                var node = darkTreeView_Project.Nodes.First(x => x.Tag.ToString().Contains(path.Replace(Form_Project.settings.ExtractedPath, "")));
                foreach (var parentNode in node.ParentTree.Nodes)
                {
                    darkTreeView_Project.Nodes.First(x => x.Equals(parentNode)).Expanded = true;
                }
            }
        }

        private void tabControl_GameProject_IndexChanged(object sender, EventArgs e)
        {
            if (Form_Project.IsValid())
            {
                if (tabControl_GameProject.SelectedIndex == 0)
                    UpdateTips("Right click a file or directory to add a copy to your project.");
                else
                    UpdateTips("Double-click a file to view it in the editor.\n" +
                        "Right click to delete, copy, or quick replace a file.");
            }
        }

        private void darkTreeView_Game_MouseClick(object sender, MouseEventArgs e)
        {
            if (darkTreeView_Game.SelectedNodes.Count > 0)
            {
                var selectedNode = darkTreeView_Game.SelectedNodes[0];
                //Show context menu if right clicked
                if (e.Button.Equals(MouseButtons.Right))
                    darkContextMenuGame_RightClick.Show(this, new Point(e.X + ((Control)sender).Left + 4, e.Y + ((Control)sender).Top + 4));
            }
        }

        private void AddToProject_Click(object sender, EventArgs e)
        {
            if (darkTreeView_Game.SelectedNodes.Count > 0)
            {
                string file = darkTreeView_Game.SelectedNodes[0].Tag.ToString();
                if (Directory.Exists(file))
                    binMerge.CopyEntireDirectory(new DirectoryInfo(file), new DirectoryInfo(file.Replace(Form_Project.settings.ExtractedPath, Path.GetDirectoryName(Path.GetFullPath(Form_Project.settings.ProjectPath)))));
                else if (File.Exists(file))
                {
                    string copiedFile = file.Replace(Form_Project.settings.ExtractedPath, Path.GetDirectoryName(Path.GetFullPath(Form_Project.settings.ProjectPath)));
                    Directory.CreateDirectory(Path.GetDirectoryName(copiedFile));
                    File.Copy(file, copiedFile);
                }
                else
                {
                    Program.status.Update($"[ERROR] Failed to copy {Path.GetFileName(file)} to project.");
                    return;
                }
                Program.status.Update($"Copied {Path.GetFileName(file)} to project.");
                Treeview_Project();
                ExpandToNode(file);
            }
        }

        private void OpenLocationGame_Click(object sender, EventArgs e)
        {
            if (darkTreeView_Game.SelectedNodes.Count > 0)
            {
                string file = darkTreeView_Game.SelectedNodes[0].Tag.ToString();
                OpenLocation(file);
            }
        }

        private void DarkTreeView_Project_MouseClick(object sender, MouseEventArgs e)
        {
            if (darkTreeView_Project.SelectedNodes.Count > 0)
            {
                var selectedNode = darkTreeView_Project.SelectedNodes[0];
                //Show context menu if right clicked
                if (e.Button.Equals(MouseButtons.Right))
                    darkContextMenuProject_RightClick.Show(this, new Point(e.X + ((Control)sender).Left + 4, e.Y + ((Control)sender).Top + 4));
            }
        }

        private void OpenLocationProject_Click(object sender, EventArgs e)
        {
            if (darkTreeView_Project.SelectedNodes.Count > 0)
            {
                string file = darkTreeView_Project.SelectedNodes[0].Tag.ToString();
                OpenLocation(file);
            }
        }

        private void OpenLocation(string file)
        {
            if (Directory.Exists(file))
                System.Diagnostics.Process.Start("explorer.exe", file);
            else if (File.Exists(file))
            {
                ProcessStartInfo info = new ProcessStartInfo();
                info.FileName = "explorer";
                info.Arguments = string.Format($"/e, /select, \"{file}\"");
                Process.Start(info);
            }
            else
                Program.status.Update($"[ERROR] Couldn't open path to {Path.GetFileName(file)}.");
        }

        private void RemoveFromProject_Click(object sender, EventArgs e)
        {
            if (darkTreeView_Project.SelectedNodes.Count > 0)
            {
                string file = darkTreeView_Project.SelectedNodes[0].Tag.ToString();
                if (Directory.Exists(file))
                    Directory.Delete(file, true);
                else if (File.Exists(file))
                    File.Delete(file);
                else
                {
                    Program.status.Update($"[ERROR] Couldn't find file to delete: {Path.GetFileName(file)}.");
                    return;
                }
                Treeview_Project();
                ExpandToNode(Path.GetDirectoryName(file));
            }
        }

        private void MakeBackupCopy_Click(object sender, EventArgs e)
        {
            if (darkTreeView_Project.SelectedNodes.Count > 0)
            {
                string file = darkTreeView_Project.SelectedNodes[0].Tag.ToString();
                if (File.Exists(file))
                {
                    for (int i = 0; i < 99; i++)
                    {
                        string newFile = file + $".bak.{i.ToString().PadLeft(3, '0')}";
                        if (!File.Exists(newFile))
                        {
                            File.Copy(file, newFile);
                            Program.status.Update($"Created backup copy: {Path.GetFileName(newFile)}.");
                            Treeview_Project();
                            ExpandToNode(file);
                            break;
                        }
                    }
                }
                else
                    Program.status.Update($"[ERROR] Couldn't find file to copy: {Path.GetFileName(file)}.");
            }
        }
    }

    public class Status
    {
        DarkTextBox dtb;
        public Status(DarkTextBox dtb)
        {
            this.dtb = dtb;
        }

        public void Update(string msg)
        {
            dtb.Text = msg;
        }
    }
}
