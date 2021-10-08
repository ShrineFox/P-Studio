using AmicitiaLibrary.Graphics.RenderWare;
using AmicitiaLibrary.Graphics.SPD;
using AmicitiaLibrary.Graphics.SPR;
using AmicitiaLibrary.Graphics.TMX;
using GFDLibrary;
using GFDLibrary.Textures;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;

namespace P_Studio
{
    public static class Unpacker
    {
        // P3F, P4
        public static void UnzipISO(string iso, string game)
        {
            if (!File.Exists(iso))
            {
                Program.status.Update($"[ERROR] Couldn't find {Path.GetFileName(iso)}. Please correct the file path in config.");
                return;
            }

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = true;
            startInfo.FileName = $@"{Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)}\Dependencies\7z\7z.exe";
            if (!FileIOWrapper.Exists(startInfo.FileName))
            {
                Program.status.Update($"[ERROR] Couldn't find {startInfo.FileName}. Please check if it was blocked by your anti-virus.");
                return;
            }

            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.UseShellExecute = false;
            startInfo.Arguments = $"x -y \"{iso}\" -o\"" + $"{Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)}\\Extracted\\{game}\" *.CVM";
            Program.status.Update($"[INFO] Extracting all CVM archives from {Path.GetFileName(iso)}");
            using (Process process = new Process())
            {
                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();
            }
        }

        public static void UnzipCVM(string cvm, string game)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = true;
            startInfo.FileName = $@"{Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)}\Dependencies\7z\7z.exe";
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.UseShellExecute = false;
            startInfo.Arguments = "x -y \"" + cvm + "\" -o\"" + Path.Combine(Path.GetDirectoryName(cvm), Path.GetFileNameWithoutExtension(cvm)) + "\" *.* -r";
            Program.status.Update($"[INFO] Extracting base files from {Path.GetFileName(cvm)}");
            using (Process process = new Process())
            {
                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();
            }
            FileIOWrapper.Delete(cvm);
        }

        // P4G
        public static void Unpack(string directory, string cpk)
        {
            string game = "Persona 4 Golden";
            Directory.CreateDirectory($@"{Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)}\Extracted\{game}");
            if (!Directory.Exists(directory))
            {
                Program.status.Update($"[ERROR] Couldn't find {directory}. Please correct the file path in config.");
                return;
            }
            List<string> pacs = new List<string>();
            List<string> globs = new List<string> { "*[!0-9].bin", "*2[0-1][0-9].bin", "*.arc", "*.pac", "*.pack", "*.bf", "*.bmd", "*.pm1" };
            switch (cpk)
            {
                case "data_e.cpk":
                    pacs.Add("data00004.pac");
                    pacs.Add("data_e.cpk");
                    break;
                case "data.cpk":
                    pacs.Add("data00000.pac");
                    pacs.Add("data00001.pac");
                    pacs.Add("data00003.pac");
                    pacs.Add("data.cpk");
                    break;
                case "data_k.cpk":
                    pacs.Add("data00005.pac");
                    pacs.Add("data_k.cpk");
                    break;
                case "data_c.cpk":
                    pacs.Add("data00006.pac");
                    pacs.Add("data_c.cpk");
                    break;
            }
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = true;
            startInfo.FileName = $@"{Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)}\Dependencies\Preappfile\preappfile.exe";
            if (!FileIOWrapper.Exists(startInfo.FileName))
            {
                Program.status.Update($"[ERROR] Couldn't find {startInfo.FileName}. Please check if it was blocked by your anti-virus.");
                return;
            }

            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.RedirectStandardOutput = true;
            startInfo.UseShellExecute = false;
            foreach (var pac in pacs)
            {
                Program.status.Update($"[INFO] Unpacking files for {pac}...");
                foreach (var glob in globs)
                {
                    startInfo.Arguments = $@"-i ""{directory}\{pac}"" -o ""{Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)}\Extracted\{game}\{Path.GetFileNameWithoutExtension(pac)}"" --unpack-filter {glob}";
                    using (Process process = new Process())
                    {
                        process.StartInfo = startInfo;
                        process.Start();
                        while (!process.HasExited)
                        {
                            string text = process.StandardOutput.ReadLine();
                            if (text != "" && text != null)
                                Program.status.Update($"{text}");
                        }
                    }
                }
                ExtractWantedFiles($@"{Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)}\Extracted\{game}\{Path.GetFileNameWithoutExtension(pac)}", game);
            }
            if (FileIOWrapper.Exists($@"{directory}\{cpk}") && !FileIOWrapper.Exists($@"{Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)}\Extracted\{game}\{cpk}"))
            {
                Program.status.Update($@"[INFO] Backing up {cpk}");
                FileIOWrapper.Copy($@"{directory}\{cpk}", $@"{Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)}\Extracted\{game}\{cpk}", true);
            }
            if (FileIOWrapper.Exists($@"{directory}\movie.cpk") && !FileIOWrapper.Exists($@"{Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)}\Extracted\{game}\movie.cpk"))
            {
                Program.status.Update($@"[INFO] Backing up movie.cpk");
                FileIOWrapper.Copy($@"{directory}\movie.cpk", $@"{Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)}\Extracted\{game}\movie.cpk", true);
            }

            Program.status.Update("[INFO] Finished unpacking base files!");
        }


        public static void UnpackCPK(string directory, string game)
        {
            if (!Directory.Exists(directory))
            {
                Program.status.Update($"[ERROR] Couldn't find {directory}. Please correct the file path in config.");
                return;
            }

            if (FileIOWrapper.Exists($@"{directory}\ps3.cpk.66600") && FileIOWrapper.Exists($@"{directory}\ps3.cpk.66601") && FileIOWrapper.Exists($@"{directory}\ps3.cpk.66602")
                   && !FileIOWrapper.Exists($@"{directory}\ps3.cpk"))
            {
                Program.status.Update("Combining ps3.cpk parts");
                ProcessStartInfo cmdInfo = new ProcessStartInfo();
                cmdInfo.CreateNoWindow = true;
                cmdInfo.FileName = @"CMD.exe";
                cmdInfo.WindowStyle = ProcessWindowStyle.Hidden;
                cmdInfo.Arguments = $@"/C copy /b ""{directory}\ps3.cpk.66600"" + ""{directory}\ps3.cpk.66601"" + ""{directory}\ps3.cpk.66602"" ""{directory}\ps3.cpk""";

                using (Process process = new Process())
                {
                    process.StartInfo = cmdInfo;
                    process.Start();
                    process.WaitForExit();
                }
            }

            Directory.CreateDirectory($@"{Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)}\Extracted\Persona 5");

            if (!FileIOWrapper.Exists($@"{Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)}\Dependencies\MakeCpk\filtered_data.csv")
                || !FileIOWrapper.Exists($@"{Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)}\Dependencies\MakeCpk\filtered_ps3.csv"))
            {
                Program.status.Update($@"[ERROR] Couldn't find CSV files used for unpacking in Dependencies\MakeCpk");
                return;
            }

            string[] dataFiles = FileIOWrapper.ReadAllLines($@"{Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)}\Dependencies\MakeCpk\filtered_data.csv");
            string[] ps3Files = FileIOWrapper.ReadAllLines($@"{Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)}\Dependencies\MakeCpk\filtered_ps3.csv");

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = true;
            startInfo.FileName = $@"{Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)}\Dependencies\MakeCpk\YACpkTool.exe";
            if (!FileIOWrapper.Exists(startInfo.FileName))
            {
                Program.status.Update($"[ERROR] Couldn't find {startInfo.FileName}. Please check if it was blocked by your anti-virus.");
                return;
            }
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.RedirectStandardOutput = true;
            startInfo.UseShellExecute = false;


            if (FileIOWrapper.Exists($@"{directory}\data.cpk"))
            {
                Program.status.Update($"[INFO] Extracting data.cpk");
                foreach (var file in dataFiles)
                {
                    startInfo.Arguments = $@"-X {file} -i ""{directory}\data.cpk"" -o ""{Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)}\Extracted\Persona 5""";

                    using (Process process = new Process())
                    {
                        process.StartInfo = startInfo;
                        process.Start();
                        while (!process.HasExited)
                        {
                            string text = process.StandardOutput.ReadLine();
                            if (text != "" && text != null)
                                Program.status.Update($"{text}");
                        }
                    }
                }
            }
            else
                Program.status.Update($"[ERROR] Couldn't find data.cpk in {directory}.");

            if (FileIOWrapper.Exists($@"{directory}\data.cpk"))
            {
                Program.status.Update($"[INFO] Extracting ps3.cpk");
                foreach (var file in ps3Files)
                {
                    startInfo.Arguments = $@"-X {file} -i ""{directory}\ps3.cpk"" -o ""{Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)}\Extracted\Persona 5""";

                    using (Process process = new Process())
                    {
                        process.StartInfo = startInfo;
                        process.Start();
                        while (!process.HasExited)
                        {
                            string text = process.StandardOutput.ReadLine();
                            if (text != "" && text != null)
                                Program.status.Update($"{text}");
                        }
                    }
                }
            }
            else
                Program.status.Update($"[ERROR] Couldn't find ps3.cpk in {directory}.");
            ExtractWantedFiles($@"{Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)}\Extracted\{game}", game);
            Program.status.Update($"[INFO] Finished unpacking base files!");
        }

        public static void ExtractWantedFiles(string directory, string game)
        {
            if (!Directory.Exists(directory))
                return;

            // Extract BIN/PAC contents
            if (SettingsForm.settings.ExtractPACs)
                ExtractPACs(directory, game);
            else
                Program.status.Update("[INFO] Skipping PAC extraction");

            // Decompile .BF/.BMD
            if (SettingsForm.settings.DecompileScripts)
                DecompileScripts(directory, game);
            else
                Program.status.Update("[INFO] Skipping BF/BMD decompilation");

            Program.status.Update($"[INFO] Finished unpacking {game} files!");
        }

        public static void ExtractPACs(string directory, string game)
        {
            var archives = Directory.EnumerateFiles(directory, "*.*", SearchOption.AllDirectories)
                .Where(s => s.ToLower().EndsWith(".arc") || s.ToLower().EndsWith(".bin") || s.ToLower().EndsWith(".pac") || s.ToLower().EndsWith(".pak"));
            foreach (string archive in archives)
            {
                Program.status.Update($"[INFO] Unpacking archive: {archive.Substring(directory.Length)}");
                binMerge.PAKPackCMD($"unpack \"{archive}\"");

                // Search the location of the unpacked container for wanted files
                string outputDir = Path.Combine(Path.GetDirectoryName(archive), Path.GetFileNameWithoutExtension(archive));
                foreach (string outputFile in Directory.EnumerateFiles(outputDir, "*.*", SearchOption.AllDirectories)
                    .Where(s => s.ToLower().EndsWith(".arc") || s.ToLower().EndsWith(".bin") || s.ToLower().EndsWith(".pac") || s.ToLower().EndsWith(".pak")))
                    ExtractWantedFiles(outputFile, game);
            }
        }

        public static void DecompileScripts(string directory, string game)
        {
            var scripts = Directory.EnumerateFiles(directory, "*.*", SearchOption.AllDirectories)
                .Where(s => s.ToLower().EndsWith(".bf") || s.ToLower().EndsWith(".bmd"));
            {
                foreach (string script in scripts)
                {
                    string encodingArg = "";
                    string libraryArg = "";

                    if (game == "Persona 3 FES")
                        encodingArg = "-Encoding P3";
                    else if (game == "Persona 4")
                        encodingArg = "-Encoding P4";

                    if (script.ToLower().EndsWith(".bf"))
                    {
                        if (game == "Persona 3 FES")
                            libraryArg = "-Library P3F";
                        else if (game == "Persona 4")
                            libraryArg = "-Library P4";
                    }

                    Program.status.Update($"[INFO] Decompiling script: {script.Substring(directory.Length)}");
                    binMerge.CompilerCMD($"\"{script}\" -Decompile {encodingArg} {libraryArg}");
                }
            }
        }

        public static void DumpTextures(string directory)
        {
            string outputDir = $@"{Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)}\Extracted\{SettingsForm.settings.Game}\Textures";
            Directory.CreateDirectory(outputDir);
            foreach(var file in Directory.GetFiles(directory))
            {
                string outputDest = Path.Combine(outputDir, Path.Combine(Path.GetDirectoryName(file).Replace(directory, ""), Path.GetFileNameWithoutExtension(file)));
                switch (Path.GetExtension(file).ToLower())
                {
                    case ".rmd":
                    case ".rws":
                        ExtractRMD(file, outputDest);
                        break;
                    case ".gmd":
                    case ".gfs":
                        ExtractGMD(file, outputDest);
                        break;
                    case (".gmo"):
                        //ExtractGMO(file, outputDest);
                        break;
                    case (".epl"):
                        ExtractEPL(file, outputDest);
                        break;
                    case (".cpk"):
                        //ExtractCPK(file, outputDest);
                        break;
                    case (".spr"):
                        ExtractSPR(file, outputDest);
                        break;
                    case (".spd"):
                        ExtractSPD(file, outputDest);
                        break;
                    case (".tmx"):
                        ExtractTMX(file, outputDest);
                        break;
                    default:
                        break;
                }
            }
        }

        private static void ExtractGMD(string file, string outputDest)
        {
            var gmd = Resource.Load<ModelPack>(file);
            if (gmd.Textures != null)
                foreach (var texture in gmd.Textures.Textures)
                {
                    Directory.CreateDirectory(outputDest);

                    var bitmap = TextureDecoder.Decode(texture);
                    bitmap.Save(Path.Combine(outputDest, Path.ChangeExtension(texture.Name, "png")));
                    Program.status.Update($"[INFO] Extracted texture: {texture.Name}.png");
                }
        }

        private static void ExtractEPL(string file, string outputDest)
        {
            Directory.CreateDirectory(outputDest);
            string copiedFile = Path.Combine(outputDest, Path.GetFileName(file));
            File.Copy(file, copiedFile);

            binMerge.EPLInjectorCMD(copiedFile);
            File.Delete(copiedFile);

            foreach (var gmd in Directory.GetFiles(outputDest, "*.gmd", SearchOption.AllDirectories))
                ExtractGMD(gmd, outputDest);
        }

        private static void ExtractSPD(string file, string outputDest)
        {
            SpdFile spd = new SpdFile(file);
            foreach (var texture in spd.Textures)
            {
                Directory.CreateDirectory(outputDest);
                
                var bitmap = texture.GetBitmap();
                bitmap.Save(Path.Combine(outputDest, texture.Description + ".png"));
                Program.status.Update($"[INFO] Extracted texture: {texture.Description}.png");
            }
        }

        private static void ExtractSPR(string file, string outputDest)
        {
            SprFile spr = SprFile.Load(file);
            int i = 0;
            foreach (TmxFile tmx in spr.Textures)
            {
                Directory.CreateDirectory(outputDest);

                var bitmap = tmx.GetBitmap();
                bitmap.Save(Path.Combine(outputDest, Path.ChangeExtension(file + "_" + i, "png")));
                Program.status.Update($"[INFO] Extracted texture {i} from: {Path.GetFileName(file)}");
                i++;
            }
        }

        private static void ExtractTMX(string file, string outputDest)
        {
            Directory.CreateDirectory(outputDest);

            TmxFile tmx = new TmxFile(file);

            var bitmap = tmx.GetBitmap();
            bitmap.Save(Path.Combine(outputDest, Path.ChangeExtension(Path.GetFileName(file), "png")));
            Program.status.Update($"[INFO] Converted texture: \"{Path.GetFileNameWithoutExtension(file)}.png\"");
        }

        private static void ExtractRMD(string file, string outputDest)
        {
            RmdScene rmd = new RmdScene(file);
            foreach (RwTextureNativeNode texture in rmd.TextureDictionary.Textures)
            {
                Directory.CreateDirectory(outputDest);

                var bitmap = texture.GetBitmap();
                bitmap.Save(Path.Combine(outputDest, Path.ChangeExtension(texture.Name, "png")));
                Program.status.Update($"[INFO] Extracted texture: \"{texture.Name}\"");
            }
        }
    }

    public static class FileIOWrapper
    {
        public static void Copy(string input, string output, bool overwrite = false)
        {
            File.Copy($@"\\?\{input}", $@"\\?\{output}", overwrite);
        }
        public static void Delete(string input)
        {
            File.Delete($@"\\?\{input}");
        }
        public static void Move(string input, string output)
        {
            File.Move($@"\\?\{input}", $@"\\?\{output}");
        }
        public static bool Exists(string input)
        {
            return File.Exists($@"\\?\{input}");
        }
        public static void WriteAllBytes(string output, byte[] bytes)
        {
            File.WriteAllBytes($@"\\?\{output}", bytes);
        }
        public static byte[] ReadAllBytes(string input)
        {
            return File.ReadAllBytes($@"\\?\{input}");
        }
        public static void WriteAllText(string output, string contents)
        {
            File.WriteAllText($@"\\?\{output}", contents);
        }
        public static string ReadAllText(string input)
        {
            return File.ReadAllText($@"\\?\{input}");
        }
        public static string[] ReadAllLines(string input)
        {
            return File.ReadAllLines($@"\\?\{input}");
        }
        public static FileStream Create(string input)
        {
            return File.Create($@"\\?\{input}");
        }
        public static FileStream Open(string input, FileMode mode)
        {
            return File.Open($@"\\?\{input}", mode);
        }
        public static FileStream OpenRead(string input)
        {
            return File.OpenRead($@"\\?\{input}");
        }
        public static DateTime GetLastWriteTime(string input)
        {
            return File.GetLastWriteTime($@"\\?\{input}");
        }
    }

    public static class binMerge
    {
        // Use PAKPack command
        public static void PAKPackCMD(string args)
        {
            string exePath = $@"{Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)}\Dependencies\PAKPack\PAKPack.exe";

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.FileName = $"\"{exePath}\"";
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.Arguments = args;
            using (Process process = new Process())
            {
                process.StartInfo = startInfo;
                process.Start();

                process.WaitForExit();
            }
        }

        // Use PAKPack command
        public static void CompilerCMD(string args)
        {
            string exePath = $@"{Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)}\Dependencies\AtlusScriptCompiler\AtlusScriptCompiler.exe";

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.FileName = $"\"{exePath}\"";
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.Arguments = args;
            using (Process process = new Process())
            {
                process.StartInfo = startInfo;
                process.Start();

                process.WaitForExit();
            }
        }

        // Use EPLInjector
        public static void EPLInjectorCMD(string args)
        {
            string exePath = $@"{Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)}\Dependencies\EPLInjector\p5eplinjector.exe";

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.FileName = $"\"{exePath}\"";
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.Arguments = args;
            using (Process process = new Process())
            {
                process.StartInfo = startInfo;
                process.Start();

                process.WaitForExit();
            }
        }

        public static List<string> getFileContents(string path)
        {
            string exePath = $@"{Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)}\Dependencies\PAKPack\PAKPack.exe";

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = $"\"{exePath}\"";
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.Arguments = $"list \"{path}\"";
            List<string> contents = new List<string>();
            using (Process process = new Process())
            {
                process.StartInfo = startInfo;
                process.Start();
                while (!process.StandardOutput.EndOfStream)
                {
                    string line = process.StandardOutput.ReadLine();
                    if (!line.Contains(" "))
                    {
                        contents.Add(line);
                    }
                }
                process.WaitForExit();
            }
            return contents;
        }

        private static int commonPrefixUtil(String str1, String str2)
        {
            String result = "";
            int n1 = str1.Length,
                n2 = str2.Length;

            // Compare str1 and str2  
            for (int i = 0, j = 0;
                     i <= n1 - 1 && j <= n2 - 1;
                     i++, j++)
            {
                if (!str1[i].ToString().Equals(str2[j].ToString(), StringComparison.InvariantCultureIgnoreCase))
                {
                    break;
                }
                result += str1[i];
            }

            return result.Length;
        }

        public static void DeleteDirectory(string path)
        {

            foreach (string directory in Directory.GetDirectories(path))
            {
                DeleteDirectory(directory);
            }
            try
            {
                Directory.Delete(path, true);
            }
            catch (IOException)
            {
                Directory.Delete(path, true);
            }
            catch (UnauthorizedAccessException)
            {
                Directory.Delete(path, true);
            }
        }

        public static bool HasUnpackedFiles(string unpackedDir, string game)
        {
            if (game == "Persona 3 FES" || game == "Persona 4")
                if (Directory.GetDirectories(unpackedDir).Any(x => x.ToUpper().Contains("DATA")) &&
                    Directory.GetDirectories(unpackedDir).Any(x => x.ToUpper().Contains("BTL")) &&
                    Directory.GetDirectories(unpackedDir).Any(x => x.ToUpper().Contains("BGM")))
                    return true;
            return false;
        }

        public static bool HasUnpackedPACs(string unpackedDir, string game)
        {
            switch (game)
            {
                case "Persona 3 FES":
                    if (Directory.GetDirectories(unpackedDir, "*", SearchOption.AllDirectories).Any(x => x.Contains("AGS_PER_EFC0_09_00")))
                        return true;
                    break;
                case "Persona 4":
                    if (Directory.GetDirectories(unpackedDir, "*", SearchOption.AllDirectories).Any(x => x.Contains("E20A")))
                        return true;
                    break;
                default:
                    return false;
            }
            
            return false;
        }

        public static bool HasDecompiledScripts(string unpackedDir, string game)
        {
            if (Directory.GetDirectories(unpackedDir, "*", SearchOption.AllDirectories).Any(x => Directory.GetFiles(x).Contains(".flow")))
                return true;
            return false;
        }

        public static void CopyEntireDirectory(DirectoryInfo source, DirectoryInfo target, bool overwiteFiles = true)
        {
            if (!source.Exists) return;
            if (!target.Exists) target.Create();

            Parallel.ForEach(source.GetDirectories(), (sourceChildDirectory) =>
                CopyEntireDirectory(sourceChildDirectory, new DirectoryInfo(Path.Combine(target.FullName, sourceChildDirectory.Name))));

            Parallel.ForEach(source.GetFiles(), sourceFile =>
                sourceFile.CopyTo(Path.Combine(target.FullName, sourceFile.Name), overwiteFiles));
        }
    }
}