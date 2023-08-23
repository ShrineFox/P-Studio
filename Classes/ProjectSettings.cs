using DarkUI.Forms;
using MetroSet_UI.Controls;
using Newtonsoft.Json;
using PersonaGameLib;
using ShrineFox.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PStudio
{
    public partial class PStudioForm : DarkForm
    {
        public static Project project = new Project();

        public class Project
        {
            public string Name = "New Project";
            public string Game = "";
            public string GamePath = "";
            public string ModPath = "";
        }

        public void ProjectSettings()
        {
            var oldProject = project.Copy();

            using (var dialog = new SettingsForm())
            {
                if (dialog.ShowDialog() != DialogResult.OK)
                    return;
            }

            if (oldProject.Name != project.Name)
                this.Text = $"PStudio - {project.Name}";
            if (oldProject.ModPath != project.ModPath)
                LoadTreeview(treeView_Project);
            if (oldProject.GamePath != project.GamePath)
                LoadTreeview(treeView_Game);
        }

        public void LoadProject()
        {
            var selection = WinFormsDialogs.SelectFile("Load project file...", true, new string[] { "json (.json)" });
            if (selection.Count == 0 || string.IsNullOrEmpty(selection[0]))
                return;

            project = JsonConvert.DeserializeObject<Project>(File.ReadAllText(selection.First()));

            this.Text = $"PStudio - {project.Name}";
            LoadTreeview(treeView_Project);
            LoadTreeview(treeView_Game);
        }

        public void SaveProject()
        {
            var selection = WinFormsDialogs.SelectFile("Save project file...", true, new string[] { "json (.json)" }, true);
            if (selection.Count == 0 || string.IsNullOrEmpty(selection[0]))
                return;

            string outPath = selection.First();
            if (!outPath.ToLower().EndsWith(".json"))
                outPath += ".json";

            File.WriteAllText(outPath, JsonConvert.SerializeObject(project, Formatting.Indented));
            MessageBox.Show($"Saved project file to:\n{outPath}", "Project Saved Successfully");
        }
    }
}
