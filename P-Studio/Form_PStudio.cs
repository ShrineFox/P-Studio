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

namespace P_Studio
{
    public partial class Form_PStudio : DarkForm
    {
        public Form_PStudio()
        {
            InitializeComponent();
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

        public static void UpdateStatus(string status)
        {
            darkTextBox_Status.Text = status;
        }
    }
}
