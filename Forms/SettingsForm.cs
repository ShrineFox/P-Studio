using Microsoft.WindowsAPICodePack.Dialogs;
using P_Studio.Properties;
using PersonaGameLib;
using ShrineFox.IO;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace P_Studio
{
    public partial class SettingsForm : MetroSet_UI.Forms.MetroSetForm
    {
        public PSettings tempSettings;
        public SettingsForm(PSettings settings)
        {
            InitializeComponent();

            PopulatePlatformsDropDown();

            tempSettings = new PSettings();
            if (settings != null && File.Exists(settings.ProjectPath))
            {
                tempSettings = settings;
                tempSettings.Load();
                UpdateForm();
            }

            UpdateRegionsDropDown();
            UpdateGamesDropDown();
        }

        private void UpdateRegionsDropDown()
        {
            comboBox_Region.Items.Clear();
            foreach (var game in PersonaGames.Platforms[comboBox_Platform.SelectedIndex].Games)
                if (!comboBox_Region.Items.Contains(game.Region))
                    comboBox_Region.Items.Add(game.Region);
            comboBox_Region.SelectedIndex = 0;
        }

        private void PopulatePlatformsDropDown()
        {
            foreach (var platform in PersonaGames.Platforms)
                comboBox_Platform.Items.Add(platform.Name);
            comboBox_Platform.SelectedIndex = 0;
        }

        private void UpdateGamesDropDown()
        {
            comboBox_Game.Items.Clear();
            foreach (var game in PersonaGames.Platforms[comboBox_Platform.SelectedIndex].Games
                .Where(x => x.Region.Equals(comboBox_Region.SelectedItem.ToString())))
                    comboBox_Game.Items.Add(game.Name);
            comboBox_Game.SelectedIndex = 0;
        }

        #region FormEvents
        /* Form Interaction Events */
        private void Save_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_ProjectName.Text) && Regex.IsMatch(txt_ProjectName.Text, "^[a-zA-Z0-9-_ .]*$"))
            {
                UpdateSettings();
                tempSettings.Save();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void OutputPath_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            dialog.Title = "Choose Output Folder...";
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                tempSettings.OutputPath = dialog.FileName;
                txt_Output.Text = tempSettings.OutputPath;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ExtractedPath_Click(object sender, MouseEventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            dialog.Title = "Choose Extracted ISO/PKG Folder...";
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                tempSettings.ExtractedPath = dialog.FileName;
                txt_Extracted.Text = tempSettings.ExtractedPath;
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
                tempSettings.ArchivePath = dialog.FileName;
                txt_Archive.Text = tempSettings.ArchivePath;
            }
        }
        #endregion

        #region Utilities
        /* Settings Form Utilities */
        private void UpdateSettings()
        {
            tempSettings.ProjectName = txt_ProjectName.Text;
            tempSettings.ProjectPath = Path.Combine(Path.Combine("Projects", tempSettings.ProjectName), tempSettings.ProjectName + ".yml");
            tempSettings.Platform = PersonaGames.Platforms.First(x => x.Name.Equals(comboBox_Platform.SelectedItem.ToString())).Name;
            tempSettings.Region = comboBox_Region.SelectedItem.ToString();
            tempSettings.Game = PersonaGames.Platforms.First(x => x.Name.Equals(comboBox_Platform.SelectedItem.ToString()))
                .Games.First(y => y.Name.Equals(comboBox_Game.SelectedItem.ToString())).Name;
            tempSettings.ArchivePath = txt_Archive.Text;
            tempSettings.UseExtractedPath = radio_Extracted.Checked;
            tempSettings.ExtractedPath = txt_Extracted.Text;
            tempSettings.OutputPath = txt_Output.Text;
        }

        private void UpdateForm()
        {
            txt_ProjectName.Text = tempSettings.ProjectName;
            comboBox_Platform.SelectedIndex = comboBox_Platform.Items.IndexOf(tempSettings.Platform);
            comboBox_Region.SelectedIndex = comboBox_Region.Items.IndexOf(tempSettings.Region);
            comboBox_Game.SelectedIndex = comboBox_Game.Items.IndexOf(tempSettings.Game);
            txt_Archive.Text = tempSettings.ArchivePath;
            radio_Extracted.Checked = tempSettings.UseExtractedPath;
            radio_Archive.Checked = !tempSettings.UseExtractedPath;
            txt_Extracted.Text = tempSettings.ExtractedPath;
            txt_Output.Text = tempSettings.OutputPath;
        }

        public string ExtractArchive()
        {
            string game = comboBox_Game.SelectedItem.ToString();
            string unpackedDir = "";
            if (tempSettings.ArchivePath.ToUpper().EndsWith(".ISO"))
            {
                Unpacker.UnzipISO(tempSettings.ArchivePath, game);
                unpackedDir = $@"{Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)}\Extracted\{game}";
                foreach (string cvm in Directory.GetFiles(unpackedDir, "*.CVM", SearchOption.AllDirectories))
                    Unpacker.UnzipCVM(cvm, game);
                Unpacker.ExtractWantedFiles(unpackedDir, game);
            }
            // else if pkg...
            return unpackedDir;
        }

        private void InputType_Changed(object sender)
        {
            if (radio_Archive.Checked)
            {
                txt_Archive.Enabled = true;
                txt_Extracted.Enabled = false;
                btn_Archive.Enabled = true;
                btn_Extracted.Enabled = false;
            }
            else
            {
                txt_Archive.Enabled = false;
                txt_Extracted.Enabled = true;
                btn_Archive.Enabled = false;
                btn_Extracted.Enabled = true;
            }
        }
        #endregion

        private void Platform_Changed(object sender, EventArgs e)
        {
            UpdateRegionsDropDown();
            UpdateGamesDropDown();
        }

        private void Region_Changed(object sender, EventArgs e)
        {
            UpdateGamesDropDown();
        }
    }
}
