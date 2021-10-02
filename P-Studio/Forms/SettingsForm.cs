using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace P_Studio
{
    public partial class SettingsForm : MetroSet_UI.Forms.MetroSetForm
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

        public SettingsForm()
        {
            InitializeComponent();
            // Load settings
            if (File.Exists(settings.ProjectPath))
            {
                LoadSettings();
                UpdateForm();
            }
            else
            {
                // Use defaults and allow project name/game entry if no settingsPath exists
                metroSetTextBox_ProjectName.Enabled = true;
                metroSetComboBox_Game.Enabled = true;
                metroSetComboBox_Game.SelectedIndex = 0;
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            // Commit form changes to settings object
            UpdateSettings();

            // Make sure project path is valid and can be created
            if (settings.ProjectName != "" && Regex.IsMatch(settings.ProjectName, "^[a-zA-Z0-9-_ .]*$"))
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
                        // Extract ISO/CVM or PKG/CPK contents if not already extracted
                        string defaultExtractPath = $@"{Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)}\Extracted\{settings.Game}";
                        if (!binMerge.HasUnpackedFiles(defaultExtractPath, settings.Game))
                        {
                            MessageBox.Show(this, "Extracting archive, please be patient as this may take awhile.\nThis only needs to happen once.", "Extracting...",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ExtractArchive();
                        }
                        else
                            Program.status.Update($"[INFO] Extracted {settings.Game} files already found, skipping...");
                        settings.ExtractedPath = defaultExtractPath;
                        // Update settings now that extraction is done
                        settings.UseExtractedPath = true;
                        // Reflect settings updates in form
                        UpdateForm();
                        // Inform user extraction is complete and settings have changed
                        MessageBox.Show(this, $"\nExtracted contents of {Path.GetFileName(settings.ArchivePath)} to:\n" +
                            $"\"{settings.ExtractedPath}\"\n\nThis path will be used instead from now on.", "Extraction Complete!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (binMerge.HasUnpackedFiles(settings.ExtractedPath, settings.Game) && settings.UseExtractedPath)
                    {
                        // Save project YML file
                        SaveSettings();
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(this, $"Extracted Path does not contain required extracted folders:\n" +
                            $"\"{settings.ExtractedPath}\"", "Extraction Required!");
                        settings.UseExtractedPath = false;
                    }
                }
                else
                {
                    string missingPath = "";
                    if (!settings.UseExtractedPath && !File.Exists(settings.ArchivePath))
                        missingPath = $"Archive Path: {settings.ArchivePath}";
                    else if (settings.UseExtractedPath && !Directory.Exists(settings.ExtractedPath))
                        missingPath = $"Extracted Path: {settings.ExtractedPath}";
                    MessageBox.Show(this, $"Specified path does not exist.\n{missingPath}",
                        "Warning: Invalid Path",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show(this, "Project Name can't be empty,\n" +
                    "and must only include alphanumeric characters!",
                    "Warning: Invalid Project Name",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                settings.ProjectName = "";
                metroSetTextBox_Archive.Text = "";
            }
        }
        private void UpdateSettings()
        {
            settings.ProjectName = metroSetTextBox_ProjectName.Text;
            settings.Game = metroSetComboBox_Game.SelectedItem.ToString();
            settings.ArchivePath = metroSetTextBox_Archive.Text;
            settings.UseExtractedPath = metroSetRadioButton_Extracted.Checked;
            settings.ExtractedPath = metroSetTextBox_Extracted.Text;
            settings.OutputPath = metroSetTextBox_Output.Text;
        }

        private void UpdateForm()
        {
            metroSetTextBox_ProjectName.Text = settings.ProjectName;
            metroSetComboBox_Game.SelectedIndex = metroSetComboBox_Game.Items.IndexOf(settings.Game);
            metroSetTextBox_Archive.Text = settings.ArchivePath;
            metroSetRadioButton_Extracted.Checked = settings.UseExtractedPath;
            metroSetRadioButton_Archive.Checked = !settings.UseExtractedPath;
            metroSetTextBox_Extracted.Text = settings.ExtractedPath;
            metroSetTextBox_Output.Text = settings.OutputPath;
        }

        public static void SaveSettings()
        {
            var serializer = new SerializerBuilder().WithNamingConvention(PascalCaseNamingConvention.Instance).Build();
            var yaml = serializer.Serialize(settings);
            using (Tools.WaitForFile(settings.ProjectPath, FileMode.Open, FileAccess.ReadWrite, FileShare.None)) { };
            File.WriteAllText(settings.ProjectPath, yaml);

            MessageBox.Show(new SettingsForm(), $"Saved project as \"{settings.ProjectName}\"!", "Project Saved",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string ExtractArchive()
        {
            string game = metroSetComboBox_Game.SelectedItem.ToString();
            string unpackedDir = "";
            if (settings.ArchivePath.ToUpper().EndsWith(".ISO"))
            {
                Unpacker.UnzipISO(settings.ArchivePath, game);
                unpackedDir = $@"{Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)}\Extracted\{game}";
                foreach (string cvm in Directory.GetFiles(unpackedDir, "*.CVM", SearchOption.AllDirectories))
                    Unpacker.UnzipCVM(cvm, game);
                Unpacker.ExtractWantedFiles(unpackedDir, game);
            }
            // else if pkg...
            return unpackedDir;
        }

        private void LoadSettings()
        {
            var deserializer = new DeserializerBuilder().WithNamingConvention(PascalCaseNamingConvention.Instance).Build();
            settings = deserializer.Deserialize<Settings>(File.ReadAllText(settings.ProjectPath));
        }

        private void OutputPath_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            dialog.Title = "Choose Output Folder...";
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                settings.OutputPath = dialog.FileName;
                metroSetTextBox_Output.Text = settings.OutputPath;
            }

        }

        public static bool IsValid()
        {
            if (!settings.UseExtractedPath && !File.Exists(settings.ArchivePath))
            {
                Program.status.Update("[ERROR] Failed to load project: invalid Archive Path");
                return false;
            }
            if (settings.UseExtractedPath && !Directory.Exists(settings.ExtractedPath))
            {
                Program.status.Update("[ERROR] Failed to load project: invalid Extracted Path");
                return false;
            }
            if (settings.UseExtractedPath && !Directory.Exists(settings.ExtractedPath))
            {
                Program.status.Update("[ERROR] Failed to load project: invalid Extracted Path");
                return false;
            }
            if (settings.ProjectName == "" || !Regex.IsMatch(settings.ProjectName, "^[a-zA-Z0-9-_ .]*$"))
            {
                Program.status.Update("[ERROR] Failed to load project: invalid Project Name");
                return false;
            }
            if (!Directory.Exists(settings.OutputPath))
            {
                Program.status.Update("[ERROR] Failed to load project: invalid Output Path");
                return false;
            }

            Program.status.Update($"[INFO] Successfully loaded project: \"{settings.ProjectName}\"");
            return true;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void InputType_Changed(object sender)
        {
            if (metroSetRadioButton_Archive.Checked)
            {
                metroSetTextBox_Archive.Enabled = true;
                metroSetTextBox_Extracted.Enabled = false;
                metroSetButton_Archive.Enabled = true;
                metroSetButton_Extracted.Enabled = false;
            }
            else if (metroSetRadioButton_Extracted.Checked)
            {
                metroSetTextBox_Archive.Enabled = false;
                metroSetTextBox_Extracted.Enabled = true;
                metroSetButton_Archive.Enabled = false;
                metroSetButton_Extracted.Enabled = true;
            }
            else
            {
                metroSetTextBox_Archive.Enabled = false;
                metroSetTextBox_Extracted.Enabled = false;
            }
        }

        private void ExtractedPath_Click(object sender, MouseEventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            dialog.Title = "Choose Extracted ISO/PKG Folder...";
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                settings.ExtractedPath = dialog.FileName;
                metroSetTextBox_Extracted.Text = settings.ExtractedPath;
            }
        }

        private void ArchivePath_Click(object sender, MouseEventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.Title = "Choose Game ISO/PKG to extract...";
            dialog.Filters.Add(new CommonFileDialogFilter("ISO", "*.iso"));
            dialog.Filters.Add(new CommonFileDialogFilter("PKG", "*.pkg"));
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                settings.ArchivePath = dialog.FileName;
                metroSetTextBox_Archive.Text = settings.ArchivePath;
            }
        }
    }
}
