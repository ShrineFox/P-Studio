using Microsoft.WindowsAPICodePack.Dialogs;
using ShrineFox.IO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YamlDotNet.Serialization.NamingConventions;
using YamlDotNet.Serialization;

namespace P_Studio
{
    public partial class PStudio : MetroSet_UI.Forms.MetroSetForm
    {
        private void SetMenuStripIcons()
        {
            List<Tuple<string, string>> menuStripIcons = new List<Tuple<string, string>>() {
                new Tuple<string, string>("fileToolStripMenuItem", "disk"),
                new Tuple<string, string>("newProjectToolStripMenuItem", "asterisk_yellow"),
                new Tuple<string, string>("loadProjectToolStripMenuItem", "folder_page"),
                new Tuple<string, string>("saveProjectToolStripMenuItem", "disk_multiple"),
                new Tuple<string, string>("settingsToolStripMenuItem", "table_gear"),
                new Tuple<string, string>("dumpToolStripMenuItem", "arrow_down"),
                new Tuple<string, string>("dumpTexturesToolStripMenuItem", "picture"),
                new Tuple<string, string>("dumpSoundsToolStripMenuItem", "music"),
                new Tuple<string, string>("dumpScriptsToolStripMenuItem", "page_code"),
                new Tuple<string, string>("ToolStripMenuItem_Add", "add"),
                new Tuple<string, string>("ToolStripMenuItem_OpenAt", "folder_explore"),
                new Tuple<string, string>("ToolStripMenuItem_ExpandGame", "chart_organisation"),
                new Tuple<string, string>("ToolStripMenuItem_CollapseGame", "arrow_join"),
                new Tuple<string, string>("ToolStripMenuItem_New", "asterisk_yellow"),
                new Tuple<string, string>("ToolStripMenuItem_NewFolder", "folder_add"),
                new Tuple<string, string>("ToolStripMenuItem_NewFlow", "script_add"),
                new Tuple<string, string>("ToolStripMenuItem_NewMsg", "page_add"),
                new Tuple<string, string>("ToolStripMenuItem_NewTxt", "page_white_add"),
                new Tuple<string, string>("ToolStripMenuItem_Decompile", "application_xp_terminal"),
                new Tuple<string, string>("ToolStripMenuItem_Compile", "application_go"),
                new Tuple<string, string>("ToolStripMenuItem_Unpack", "folder_go"),
                new Tuple<string, string>("ToolStripMenuItem_RepackAs", "package_go"),
                new Tuple<string, string>("ToolStripMenuItem_RepackPAC", "package"),
                new Tuple<string, string>("ToolStripMenuItem_RepackAFS", "music"),
                new Tuple<string, string>("ToolStripMenuItem_RepackAWB", "music"),
                new Tuple<string, string>("ToolStripMenuItem_Replace", "note_go"),
                new Tuple<string, string>("ToolStripMenuItem_Remove", "delete"),
                new Tuple<string, string>("ToolStripMenuItem_OpenAt2", "folder_explore"),
                new Tuple<string, string>("ToolStripMenuItem_Copy", "page_copy"),
                new Tuple<string, string>("ToolStripMenuItem_Rename", "textfield_rename"),
                new Tuple<string, string>("ToolStripMenuItem_ExpandProj", "chart_organisation"),
                new Tuple<string, string>("ToolStripMenuItem_CollapseProj", "arrow_join"),
            };

            foreach (MenuStrip menuItem in this.FlattenChildren<MenuStrip>())
            {
                foreach (ToolStripMenuItem tsmi in menuItem.Items)
                {
                    if (menuStripIcons.Any(x => x.Item1 == tsmi.Name))
                    {
                        tsmi.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), $"Icons\\{menuStripIcons.Single(x => x.Item1 == tsmi.Name).Item2}.png"));
                    }
                    foreach (ToolStripMenuItem tsmi2 in tsmi.DropDownItems)
                    {
                        tsmi2.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), $"Icons\\{menuStripIcons.Single(x => x.Item1 == tsmi2.Name).Item2}.png"));
                    }
                }
            }
        }

        #region ToolstripOptions
        /* Toolstrip Options*/
        private void NewProject_Click(object sender, EventArgs e)
        {
            this.Text = $"P-Studio v0.1";
            saveProjectToolStripMenuItem.Enabled = false;
            SettingsForm.settings = new SettingsForm.Settings();
            OpenSettingsForm();
            metroSetTabControl_GameProject.SelectedIndex = 0;
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
            metroSetTabControl_GameProject.SelectedIndex = 1;
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
                        Output.Log($"[INFO] Copying project files from \"{Path.GetFileNameWithoutExtension(originalProj)}\" to \"{Path.GetFileNameWithoutExtension(newProj)}\"");
                        // Copy all project files to new directory
                        Unpacker.CopyEntireDirectory(new DirectoryInfo(projDir), new DirectoryInfo(Path.GetDirectoryName(newProj)), true);
                        // Delete original project file copied with other project stuff
                        File.Delete(Path.Combine(Path.GetDirectoryName(newProj), Path.GetFileName(originalProj)));
                        // Save and reload new project
                        SettingsForm.SaveSettings();
                        LoadProject();
                    }
                    else
                        Output.Log($"[ERROR] Failed to save project as \"{newName}\", directory already exists");
                }
            }
        }
        #endregion

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

        private void SetMenuStripRenderer()
        {
            ToolStripManager.Renderer = r;
            menuStrip_Main.Renderer = r;
        }
    }

    public static class ControlExtensions
    {
        public static IEnumerable<Control> FlattenChildren<T>(this Control control)
        {
            return control.FlattenChildren().OfType<T>().Cast<Control>();
        }

        public static IEnumerable<Control> FlattenChildren(this Control control)
        {
            var children = control.Controls.Cast<Control>();
            return children.SelectMany(c => FlattenChildren(c)).Concat(children);
        }
    }

}
