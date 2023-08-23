using DarkUI.Forms;
using PersonaGameLib;
using ShrineFox.IO;

namespace PStudio
{
    public partial class SettingsForm : DarkForm
    {
        public SettingsForm()
        {
            InitializeComponent();
            LoadFieldValues();
        }

        private void LoadFieldValues()
        {
            txt_ProjectName.Text = PStudioForm.project.Name;

            List<Game> games = new List<Game>();
            foreach (var platform in PersonaGames.Platforms)
                foreach (var game in platform.Games.Where(x => x.SFName != ""
                && !games.Any(y => (y.Name.Equals(x.Name) && (y.Platform == x.Platform)))))
                    games.Add(game);
            foreach (var game in games)
                comboBox_Game.Items.Add(game);

            comboBox_Game.DisplayMember = "Name";
            comboBox_Game.Format += ComboBoxFormat;

            if (PStudioForm.project.Game == "")
                PStudioForm.project.Game = "P5R-PC";

            comboBox_Game.SelectedIndex = comboBox_Game.Items.IndexOf(
                games.First(x => x.SFName == PStudioForm.project.Game));

            txt_GameDir.Text = PStudioForm.project.GamePath;
            txt_ModDir.Text = PStudioForm.project.ModPath;
        }

        private void ComboBoxFormat(object sender, ListControlConvertEventArgs e)
        {
            string gameName = ((Game)e.ListItem).Name;
            string platform = ((Game)e.ListItem).Platform;

            e.Value = $"{gameName} ({platform})";
        }

        private void SaveFieldValues()
        {
            PStudioForm.project.Name = txt_ProjectName.Text;
            Game game = (Game)comboBox_Game.SelectedItem;
            PStudioForm.project.Game = game.SFName;
            PStudioForm.project.GamePath = txt_GameDir.Text;
            PStudioForm.project.ModPath = txt_ModDir.Text;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveFieldValues();
        }

        private void GameDir_Click(object sender, EventArgs e)
        {
            string gameDir = WinFormsDialogs.SelectFolder("Select Game Files Directory");
            if (gameDir != "")
                txt_GameDir.Text = gameDir;
        }

        private void ModDir_Click(object sender, EventArgs e)
        {
            string modDir = WinFormsDialogs.SelectFolder("Select Mod Files Directory");
            if (modDir != "")
                txt_ModDir.Text = modDir;
        }
    }
}
