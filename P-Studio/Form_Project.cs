using DarkUI.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
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
        public static Settings settings { get; set; } = new Settings();

        public class Settings
        {
            public string ProjectName { get; set; } = "";
            public string ProjectPath { get; set; } = "";
            // Input
            public string Game { get; set; } = "";
            public string ArchivePath { get; set; } = "";
            public bool UseExtractedPath { get; set; } = false;
            public string ExtractedPath { get; set; } = "";
            public string OutputPath { get; set; } = "";
        }

        private void Save_Click(object sender, EventArgs e)
        {
            // Commit form changes to settings object
            UpdateSettings();

            // Make sure project path is valid and can be created
            if (settings.ProjectName != "" && Regex.IsMatch(settings.ProjectName, "^[a-zA-Z0-9]*$"))
            {
                // Set path and create project/output directory
                settings.ProjectPath = Path.Combine(Path.Combine("Projects", settings.ProjectName), settings.ProjectName + ".yml");
                Directory.CreateDirectory(Path.GetDirectoryName(settings.ProjectPath));
                Directory.CreateDirectory(Path.GetDirectoryName(settings.OutputPath));

                if ((!settings.UseExtractedPath && File.Exists(settings.ArchivePath))
                    || (settings.UseExtractedPath && Directory.Exists(settings.ExtractedPath)))
                {
                    // Extract files if using archive path
                    if (!settings.UseExtractedPath)
                    {
                        // Show message informing user extraction is about to take place
                        MessageBox.Show("Extracting archive, please be patient as this may take awhile.\nThis only needs to happen once.", "Extracting...", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Extract ISO/CVM or PKG/CPK contents
                        string extractedPath = Path.Combine(Path.Combine(Path.GetDirectoryName(settings.ArchivePath), "Extracted"), darkDropdownList_Game.SelectedItem.Text);
                        ExtractArchive();
                        // Update settings now that extraction is done
                        settings.ExtractedPath = extractedPath;
                        settings.UseExtractedPath = true;
                        // Reflect settings updates in form
                        UpdateForm();
                        // Inform user extraction is complete and settings have changed
                        MessageBox.Show($"\nExtracted contents of {Path.GetFileName(settings.ArchivePath)} to:\n" +
                            $"{extractedPath}\n\nThis path will be used instead from now on.", "Extraction Complete!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    // Save project YML file
                    SaveSettings();
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    string missingPath = "";
                    if (!settings.UseExtractedPath && !File.Exists(settings.ArchivePath))
                        missingPath = $"Archive Path: {settings.ArchivePath}";
                    else if (settings.UseExtractedPath && !Directory.Exists(settings.ExtractedPath))
                        missingPath = $"Extracted Path: {settings.ExtractedPath}";
                    MessageBox.Show($"Specified path does not exist.\n{missingPath}",
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
                darkTextBox_ArchivePath.Text = "";
            }
        }
        private void UpdateSettings()
        {
            settings.ProjectName = darkTextBox_ProjectName.Text;
            settings.Game = darkDropdownList_Game.SelectedItem.Text;
            settings.ArchivePath = darkTextBox_ArchivePath.Text;
            settings.UseExtractedPath = darkRadioButton_UseExtracted.Checked;
            settings.ExtractedPath = darkTextBox_ExtractPath.Text;
            settings.OutputPath = darkTextBox_OutputPath.Text;
        }

        private void UpdateForm()
        {
            darkTextBox_ProjectName.Text = settings.ProjectName;
            darkDropdownList_Game.SelectedItem = darkDropdownList_Game.Items.First(x => x.Text.Equals(settings.Game));
            darkTextBox_ArchivePath.Text = settings.ArchivePath;
            darkRadioButton_UseExtracted.Checked = settings.UseExtractedPath;
            darkRadioButton_UseArchive.Checked = !settings.UseExtractedPath;
            darkTextBox_ExtractPath.Text = settings.ExtractedPath;
            darkTextBox_OutputPath.Text = settings.OutputPath;
        }

        private void SaveSettings()
        {
            var serializer = new SerializerBuilder().WithNamingConvention(PascalCaseNamingConvention.Instance).Build();
            var yaml = serializer.Serialize(settings);
            File.WriteAllText(settings.ProjectPath, yaml);

            MessageBox.Show($"Saved project as \"{settings.ProjectName}\"!", "Project Saved", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ExtractArchive()
        {
            string game = darkDropdownList_Game.SelectedItem.Text;
            if (settings.ArchivePath.ToUpper().EndsWith(".ISO"))
            {
                Unpacker.UnzipISO(settings.ArchivePath, game);
                string unpackedDir = $@"{Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)}\Extracted\{game}";
                foreach (string cvm in Directory.GetFiles(unpackedDir, "*.CVM", SearchOption.AllDirectories))
                    Unpacker.UnzipCVM(cvm, game);
                Unpacker.ExtractWantedFiles(unpackedDir, game);
            }
            // else if pkg...
        }

        public Form_Project()
        {
            InitializeComponent();
            // Add Games to dropdown
            darkDropdownList_Game.Items.Add(new DarkUI.Controls.DarkDropdownItem("Persona 3 FES"));
            darkDropdownList_Game.Items.Add(new DarkUI.Controls.DarkDropdownItem("Persona 4"));
            // Load settings
            if (File.Exists(settings.ProjectPath))
            {
                LoadSettings();
                UpdateForm();
            }
            else
            {
                // Use defaults and allow project name/game entry if no settingsPath exists
                darkTextBox_ProjectName.Enabled = true;
                darkDropdownList_Game.Enabled = true;
            }
        }

        private void LoadSettings()
        {
            var deserializer = new DeserializerBuilder().WithNamingConvention(PascalCaseNamingConvention.Instance).Build();
            settings = deserializer.Deserialize<Settings>(File.ReadAllText(settings.ProjectPath));
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
            }
            else
            {
                darkTextBox_ArchivePath.Enabled = false;
                darkButton_BrowseArchive.Enabled = false;
                darkTextBox_ExtractPath.Enabled = true;
                darkButton_ExtractBrowse.Enabled = true;
            }
        }

        public static void UpdateStatus(string status)
        {
            Form_PStudio.darkLabel_Status.Text = status;
        }

        public static bool IsValid()
        {
            if (((!settings.UseExtractedPath && File.Exists(settings.ArchivePath))
                || (settings.UseExtractedPath && Directory.Exists(settings.ExtractedPath)))
                && (Form_Project.settings.ProjectName != "" && Regex.IsMatch(settings.ProjectName, "^[a-zA-Z0-9]*$") && Directory.Exists(settings.OutputPath))
                && (settings.Game.Equals("Persona 3 FES") || settings.Game.Equals("Persona 4")))
            {
                UpdateStatus($"Successfully loaded project: {settings.ProjectName}");
                return true;
            }  
            else
            {
                UpdateStatus("Error loading project: invalid settings.yml");
                return false;
            }
        }
    }
}
