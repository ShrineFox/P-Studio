using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_Studio
{
    public class Treeview
    {
        public static ImageList treeViewImageList = new ImageList();
        public static List<string> excludedTreeViewTypes = new List<string>() { ".bf", ".bmd", ".pac", ".pak", ".bin", ".amd" };
        
        public static void SetupImageList()
        {
            Color transparentColor = Color.FromArgb(60, 63, 65);
            treeViewImageList.Images.Add(Properties.Resources.music, transparentColor);
            treeViewImageList.Images.Add(Properties.Resources.script_code_red, transparentColor);
            treeViewImageList.Images.Add(Properties.Resources.script_code, transparentColor);
            treeViewImageList.Images.Add(Properties.Resources.script_edit, transparentColor);
            treeViewImageList.Images.Add(Properties.Resources.page_white_text, transparentColor);
            treeViewImageList.Images.Add(Properties.Resources.script_gear, transparentColor);
            treeViewImageList.Images.Add(Properties.Resources.application_xp_terminal, transparentColor);
            treeViewImageList.Images.Add(Properties.Resources.database, transparentColor);
            treeViewImageList.Images.Add(Properties.Resources.table, transparentColor);
            treeViewImageList.Images.Add(Properties.Resources.package_green, transparentColor);
            treeViewImageList.Images.Add(Properties.Resources.world, transparentColor);
            treeViewImageList.Images.Add(Properties.Resources.image, transparentColor);
            treeViewImageList.Images.Add(Properties.Resources.picture, transparentColor);
            treeViewImageList.Images.Add(Properties.Resources.font, transparentColor);
            treeViewImageList.Images.Add(Properties.Resources.film, transparentColor);
            treeViewImageList.Images.Add(Properties.Resources.vector, transparentColor);
            treeViewImageList.Images.Add(Properties.Resources.cd, transparentColor);
            treeViewImageList.Images.Add(Properties.Resources.chart_organisation, transparentColor);
            treeViewImageList.Images.Add(Properties.Resources.folder, transparentColor);
            treeViewImageList.Images.Add(Properties.Resources.page_white, transparentColor);
        }

        public static int GetIconIndex(string file)
        {
            switch (Path.GetExtension(file).ToLower())
            {
                case ".adx":
                case ".acx":
                case ".acb":
                case ".awb":
                case ".wav":
                case ".afs":
                    return 0;
                case ".bf":
                    return 1;
                case ".bmd":
                    return 2;
                case ".flow":
                    return 3;
                case ".msg":
                case ".txt":
                    return 4;
                case ".bat":
                case ".yml":
                    return 5;
                case ".exe":
                    return 6;
                case ".dll":
                    return 7;
                case ".tbl":
                    return 8;
                case ".bin":
                case ".arc":
                case ".amd":
                case ".pac":
                case ".pak":
                case ".cpk":
                case ".cvm":
                    return 9;
                case ".gmd":
                case ".gfs":
                case ".gap":
                case ".rmd":
                case ".rws":
                    return 10;
                case ".tmx":
                case ".tm2":
                case ".dds":
                case ".png":
                case ".bmp":
                case ".tga":
                case ".gnf":
                    return 11;
                case ".spr":
                    return 12;
                case ".fnt":
                    return 13;
                case ".sfd":
                case ".umd":
                case ".mp4":
                case ".avi":
                    return 14;
                case ".plg":
                    return 15;
                case ".iso":
                case ".img":
                    return 16;
                case ".epl":
                    return 17;
                case ".folder":
                    return 18;
                default:
                    return 19;
            }
        }

        public static void BuildTree(DirectoryInfo directoryInfo, TreeNodeCollection addInMe)
        {
            string ext = directoryInfo.FullName;
            if (Directory.Exists(ext))
                ext += ".folder";
            // Set icon
            TreeNode curNode = addInMe.Add(directoryInfo.FullName, directoryInfo.Name, GetIconIndex(ext), GetIconIndex(ext));
            // Add subdirectories
            foreach (DirectoryInfo subdir in directoryInfo.GetDirectories())
                BuildTree(subdir, curNode.Nodes);
            // Add files
            foreach (FileInfo file in directoryInfo.GetFiles() // Get all files in directory except those with excluded extensions
                .Where(x => !excludedTreeViewTypes.Any(y => x.FullName.ToLower().EndsWith(y))))
                    curNode.Nodes.Add(file.FullName, file.Name, GetIconIndex(file.FullName), GetIconIndex(file.FullName));
        }

        public static void OpenLocation(string file)
        {
            if (Directory.Exists(file))
                System.Diagnostics.Process.Start("explorer.exe", file);
            else if (File.Exists(file))
            {
                ProcessStartInfo info = new ProcessStartInfo();
                info.FileName = "explorer";
                info.Arguments = string.Format($"/e, /select, \"{file}\"");
                Process.Start(info);
            }
            else
                Program.status.Update($"[ERROR] Couldn't open path to \"{Path.GetFileName(file)}\".");
        }
    }

    public static class TreeViewExtensions
    {
        public static List<string> GetExpansionState(this TreeNodeCollection nodes)
        {
            return nodes.Descendants()
                        .Where(n => n.IsExpanded)
                        .Select(n => n.FullPath)
                        .ToList();
        }

        public static void SetExpansionState(this TreeNodeCollection nodes, List<string> savedExpansionState)
        {
            foreach (var node in nodes.Descendants()
                                      .Where(n => savedExpansionState.Contains(n.FullPath)))
            {
                node.Expand();
            }
        }

        public static IEnumerable<TreeNode> Descendants(this TreeNodeCollection c)
        {
            foreach (var node in c.OfType<TreeNode>())
            {
                yield return node;

                foreach (var child in node.Nodes.Descendants())
                {
                    yield return child;
                }
            }
        }
    }
}
