using PersonaGameLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization.NamingConventions;
using YamlDotNet.Serialization;
using System.IO;
using P_Studio.Properties;
using ShrineFox.IO;
using System.Runtime;
using System.Text.RegularExpressions;

namespace P_Studio
{
    public class PSettings
    {
        public string ProjectName { get; set; } = "";
        public string ProjectPath { get; set; } = "";
        public string Game { get; set; } = "";
        public string Region { get; set; } = "";
        public string Platform { get; set; } = "";
        // Input (Pre-Dump)
        public string ArchivePath { get; set; } = "";
        // Input (Dumped)
        public bool UseExtractedPath { get; set; } = false;
        public string ExtractedPath { get; set; } = "";
        // Output
        public string OutputPath { get; set; } = "";
        public void Save()
        {
            var serializer = new SerializerBuilder().WithNamingConvention(PascalCaseNamingConvention.Instance).Build();
            var yaml = serializer.Serialize(this);
            Directory.CreateDirectory(Path.GetDirectoryName(this.ProjectPath));
            using (ShrineFox.IO.FileSys.WaitForFile(this.ProjectPath)) { };
            File.WriteAllText(this.ProjectPath, yaml);
            Output.Log($"Saved project: \"{this.ProjectPath}\"", ConsoleColor.Green);
        }
        public void Load(string path = "")
        {
            var deserializer = new DeserializerBuilder().WithNamingConvention(PascalCaseNamingConvention.Instance).Build();
            PSettings newSettings = new PSettings();

            if (!string.IsNullOrEmpty(path) && File.Exists(path))
            {
                try
                {
                    newSettings = deserializer.Deserialize<PSettings>(File.ReadAllText(path));
                }
                catch { Output.Log($"[ERROR] Failed to deserialize project settings from file: \"{path}\""); }
            }
            else
            {
                newSettings = deserializer.Deserialize<PSettings>(File.ReadAllText(this.ProjectPath));
            }

            newSettings.IsValid();

            this.ProjectName = newSettings.ProjectName;
            this.ProjectPath = newSettings.ProjectPath;
            this.Game = newSettings.Game;
            this.Platform = newSettings.Platform;

            this.ArchivePath = newSettings.ArchivePath;
            this.UseExtractedPath = newSettings.UseExtractedPath;
            this.ExtractedPath = newSettings.ExtractedPath;

            this.OutputPath = newSettings.OutputPath;

            Output.Log($"Loaded project: \"{newSettings.ProjectPath}\"", ConsoleColor.Green);
        }
        public bool IsValid()
        {
            if (!this.UseExtractedPath && !File.Exists(this.ArchivePath))
            {
                Output.Log($"[WARNING] Invalid Archive Path: {this.ArchivePath}", ConsoleColor.Yellow);
                return false;
            }
            if (this.UseExtractedPath && !Directory.Exists(this.ExtractedPath))
            {
                Output.Log($"[WARNING] Invalid Extracted Path: {this.ExtractedPath}", ConsoleColor.Yellow);
                return false;
            }
            if (!Directory.Exists(this.OutputPath))
            {
                Output.Log($"[WARNING] Invalid Output Path: {this.OutputPath}", ConsoleColor.Yellow);
                return false;
            }

            return true;
        }
    }
}
