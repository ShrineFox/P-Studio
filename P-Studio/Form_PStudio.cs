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

namespace P_Studio
{
    public partial class Form_PStudio : DarkForm
    {
        public static Form_Project.Settings settings = new Form_Project.Settings();
        public Form_PStudio()
        {
            InitializeComponent();
            #if DEBUG
                settings.ProjectName = "FEMC";
                settings.Game = "Persona 3 FES";
                settings.ArchivePath = @"C:\Users\ryans\Documents\GitHub\P-Studio\P-Studio\bin\Debug\ISO\P3FES-partymod.iso";
                settings.OutputPath = @"D:\Games\Persona\AemulusPackageManager\Packages\Persona 3 FES";
            #endif
        }

        private void NewProject_Click(object sender, EventArgs e)
        {
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
                settings = dialog.settings;
            }

            LoadProject();
        }

        private void LoadProject()
        {
            if (settings.ProjectName != "")
            {
                this.Text = $"P-Studio v0.1 - {settings.ProjectName}";
                saveProjectToolStripMenuItem.Enabled = true;
                projectSettingsToolStripMenuItem.Enabled = true;
            }
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
                settings = deserializer.Deserialize<Form_Project.Settings>(File.ReadAllText(dialog.FileName));

            LoadProject();
        }

        private void Treeview_Change(object sender, EventArgs e)
        {
            if (darkRadioButton_Game.Checked)
                Treeview_Game();
            else
                Treeview_Project();
        }

        private void Treeview_Project()
        {
            if (Directory.Exists(settings.ProjectPath))
            {
                darkTreeView_FileExplorer.Nodes.Clear();
                LoadDirectory(settings.ProjectPath);
            }
        }

        private void Treeview_Game()
        {
            if (Directory.Exists(settings.ExtractedPath))
            {
                darkTreeView_FileExplorer.Nodes.Clear();
                LoadDirectory(settings.ExtractedPath);
            }
        }

        public void LoadDirectory(string dir)
        {
            DirectoryInfo di = new DirectoryInfo(dir);
            DarkTreeNode tds = new DarkTreeNode(di.Name);
            tds.Tag = di.FullName;
            //tds.Icon = 
            LoadFiles(dir, tds);
            LoadSubDirectories(dir, tds);
        }

        private void LoadSubDirectories(string dir, DarkTreeNode td)
        {
            // Get all subdirectories  
            string[] subdirectoryEntries = Directory.GetDirectories(dir);
            // Loop through them to see if they have any other subdirectories  
            foreach (string subdirectory in subdirectoryEntries)
            {

                DirectoryInfo di = new DirectoryInfo(subdirectory);
                DarkTreeNode tds = new DarkTreeNode(di.Name);

                //tds.Icon = 
                tds.Tag = di.FullName;
                LoadFiles(subdirectory, tds);
                LoadSubDirectories(subdirectory, tds);
                td.Nodes.Add(tds);
            }
        }

        private void LoadFiles(string dir, DarkTreeNode td)
        {
            string[] Files = Directory.GetFiles(dir, "*.*");

            // Loop through them to see files  
            foreach (string file in Files)
            {
                FileInfo fi = new FileInfo(file);
                DarkTreeNode tds = new DarkTreeNode(fi.Name);
                
                //tds.Icon = 
                tds.Tag = fi.FullName;
                td.Nodes.Add(tds);
            }
        }
    }
}
