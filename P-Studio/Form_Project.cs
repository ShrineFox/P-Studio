using DarkUI.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace P_Studio
{
    public partial class Form_Project : DarkForm
    {
        public Settings settings { get; set; } = Form_PStudio.settings;

        public class Settings
        {
            public string ProjectName { get; set; } = "";
            public string ProjectPath { get; set; } = "";
            // Input
            public string Game { get; set; } = "";
            public string ArchivePath { get; set; } = "";
            public string ExtractedPath { get; set; } = "";
            public string OutputPath { get; set; } = "";
        }

        private void Save_Click(object sender, EventArgs e)
        {
            settings.ProjectName = darkTextBox_ProjectName.Text;
            settings.Game = darkDropdownList_Game.SelectedItem.Text;
            settings.ArchivePath = darkTextBox_ArchivePath.Text;
            settings.ExtractedPath = darkTextBox_ExtractPath.Text;
            settings.OutputPath = darkTextBox_OutputPath.Text;

            // Make sure project path is valid and can be created
            if (settings.ProjectName != "" && Regex.IsMatch(settings.ProjectName, "^[a-zA-Z0-9]*$"))
            {
                settings.ProjectPath = Path.Combine(Path.Combine("Projects", settings.ProjectName), settings.ProjectName + ".yml");

                // Create Project Directory if making a new project
                if (darkTextBox_ProjectName.Enabled)
                    Directory.CreateDirectory(Path.GetDirectoryName(settings.ProjectPath));
                
                if (darkButton_Save.DialogResult != DialogResult.OK 
                    && ((darkRadioButton_UseArchive.Checked && File.Exists(darkTextBox_ArchivePath.Text)) 
                        || (darkRadioButton_UseExtracted.Checked && Directory.Exists(darkTextBox_ExtractPath.Text)))
                    && Directory.Exists(darkTextBox_OutputPath.Text))
                {
                    // Save project YML file
                    var serializer = new SerializerBuilder().WithNamingConvention(PascalCaseNamingConvention.Instance).Build();
                    var yaml = serializer.Serialize(settings);
                    File.WriteAllText(settings.ProjectPath, yaml);

                    // Show dialog and extract files
                    string saveMsg = $"Project saved as \"{settings.ProjectName}\"!";
                    if (darkRadioButton_UseArchive.Checked)
                    {
                        ExtractArchive();
                        saveMsg += $"\nExtracted contents of {Path.GetFileName(settings.ExtractedPath)} to:\n" +
                            $"{Path.Combine(Path.GetDirectoryName(settings.ExtractedPath), "Extracted")}";
                    }
                    MessageBox.Show(saveMsg, "Project Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Change "Save" to "Close"
                    darkButton_Save.DialogResult = DialogResult.OK;
                    darkButton_Save.Text = "Close";
                }
                else
                {
                    MessageBox.Show("You must choose an existing input\n" +
                        "and output path.",
                        "Warning: Invalid Path",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Project Name can't be empty,\n" +
                    "and must only include alphanumeric characters!",
                    "Warning: Invalid Project Name",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                settings.ProjectName = "";
            }
        }

        private void ExtractArchive()
        {
            throw new NotImplementedException();
        }

        public Form_Project()
        {
            InitializeComponent();
            // Add Games to dropdown
            darkDropdownList_Game.Items.Add(new DarkUI.Controls.DarkDropdownItem("Persona 3 FES"));
            darkDropdownList_Game.Items.Add(new DarkUI.Controls.DarkDropdownItem("Persona 4"));
            // Load defaults
            #if DEBUG
                settings = Form_PStudio.settings;
                darkTextBox_ProjectName.Text = settings.ProjectName;
                darkDropdownList_Game.SelectedItem = darkDropdownList_Game.Items.First(x => x.Text.Equals(settings.Game));
                darkTextBox_ArchivePath.Text = settings.ArchivePath;
                darkTextBox_ExtractPath.Text = settings.ExtractedPath;
                darkTextBox_OutputPath.Text = settings.OutputPath;
            #endif
            // Load settings
            if (File.Exists(Form_PStudio.settings.ProjectPath))
            {
                var deserializer = new DeserializerBuilder().WithNamingConvention(PascalCaseNamingConvention.Instance).Build();
                settings = deserializer.Deserialize<Settings>(File.ReadAllText(Form_PStudio.settings.ProjectPath));
                darkTextBox_ProjectName.Text = settings.ProjectName;
                darkDropdownList_Game.SelectedItem = darkDropdownList_Game.Items.First(x => x.Text.Equals(settings.Game));
                darkTextBox_ArchivePath.Text = settings.ArchivePath;
                darkTextBox_ExtractPath.Text = settings.ExtractedPath;
                darkTextBox_OutputPath.Text = settings.OutputPath;
            }
            else
            {
                // Use defaults and allow project name/game entry if no settingsPath exists
#if !DEBUG
                    settings = new Settings();
#endif
                darkTextBox_ProjectName.Enabled = true;
                darkDropdownList_Game.Enabled = true;
            }
        }

        private void ArchivePath_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.Title = "Choose Game ISO/PKG to extract...";
            dialog.Filters.Add(new CommonFileDialogFilter("ISO", "*.iso"));
            dialog.Filters.Add(new CommonFileDialogFilter("PKG", "*.pkg"));
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                settings.ArchivePath = dialog.FileName;
                darkTextBox_ArchivePath.Text = settings.ArchivePath;
            }  
        }

        private void ExtractedPath_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            dialog.Title = "Choose Extracted ISO/PKG Folder...";
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                settings.ExtractedPath = dialog.FileName;
                darkTextBox_ExtractPath.Text = settings.ExtractedPath;
            }
        }

        private void OutputPath_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            dialog.Title = "Choose Output Folder...";
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                settings.OutputPath = dialog.FileName;
                darkTextBox_OutputPath.Text = settings.OutputPath;
            }
                
        }

        private void InputType_Changed(object sender, EventArgs e)
        {
            if (darkRadioButton_UseArchive.Checked)
            {
                darkTextBox_ArchivePath.Enabled = true;
                darkButton_BrowseArchive.Enabled = true;
                darkTextBox_ExtractPath.Enabled = false;
                darkButton_ExtractBrowse.Enabled = false;
                darkTextBox_ArchivePath.Text = "";
            }
            else
            {
                darkTextBox_ArchivePath.Enabled = false;
                darkButton_BrowseArchive.Enabled = false;
                darkTextBox_ExtractPath.Enabled = true;
                darkButton_ExtractBrowse.Enabled = true;
                darkTextBox_ExtractPath.Text = "";
            }
        }
    }
}
