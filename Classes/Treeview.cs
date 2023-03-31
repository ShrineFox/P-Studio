using ShrineFox.IO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_Studio
{
    public class Treeview
    {
        #region Icons
        /* Set up Treeview icons */
        public static ImageList treeViewImageList = new ImageList();
        public static List<string> unpackTreeViewTypes = new List<string>() { ".pac", ".pak", ".bin", ".amd", ".afs", ".acb", ".awb" };
        public static List<string> compileTreeViewTypes = new List<string>() { ".flow", ".msg" };
        public static List<string> decompileTreeViewTypes = new List<string>() { ".bf", ".bmd" };

        public static void SetupImageList()
        {
            Color transparentColor = Color.FromArgb(60, 63, 65);
            foreach (var img in new string[] { "music", "script_code_red", "script_code", "script_edit", "page_white_text", "script_gear",
            "application_xp_terminal", "database", "table", "package_green", "world", "image", "picture", "font", "film", "vector",
            "cd", "chart_organisation", "folder", "page_white" })
            {
                treeViewImageList.Images.Add(Image.FromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), $"Icons\\{img}.png")));
            }
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
        #endregion

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
            foreach (FileInfo file in directoryInfo.GetFiles()) // Get all files in directory except those with excluded extensions
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
                Output.Log($"[ERROR] Couldn't open path to \"{Path.GetFileName(file)}\".");
        }
    }

    public partial class PStudio : MetroSet_UI.Forms.MetroSetForm
    {
        #region TreeViewEvents
        /* Treeview Setup */
        private void SetTreeViewIcons()
        {
            treeView_Game.ImageList = Treeview.treeViewImageList;
            treeView_Project.ImageList = Treeview.treeViewImageList;
        }

        private void Treeview_Project()
        {
            var projectExpansionState = treeView_Project.Nodes.GetExpansionState();

            treeView_Project.Nodes.Clear();
            if (Directory.Exists(Path.GetDirectoryName(SettingsForm.settings.ProjectPath)))
                Treeview.BuildTree(new DirectoryInfo(Path.GetDirectoryName(SettingsForm.settings.ProjectPath)), treeView_Project.Nodes);
            treeView_Project.Nodes.SetExpansionState(projectExpansionState);
        }

        private void Treeview_Game()
        {
            var gameExpansionState = treeView_Game.Nodes.GetExpansionState();
            treeView_Game.Nodes.Clear();
            if (Directory.Exists(SettingsForm.settings.ExtractedPath))
                Treeview.BuildTree(new DirectoryInfo(SettingsForm.settings.ExtractedPath), treeView_Game.Nodes);
            treeView_Game.Nodes.SetExpansionState(gameExpansionState);
        }

        /* Treeview Events */
        private void AddToProject_Click(object sender, EventArgs e)
        {
            if (treeView_Game.SelectedNode != null)
            {
                string file = treeView_Game.SelectedNode.Name;
                if (Directory.Exists(file))
                    Unpacker.CopyEntireDirectory(new DirectoryInfo(file), new DirectoryInfo(file.Replace(SettingsForm.settings.ExtractedPath, Path.GetDirectoryName(Path.GetFullPath(SettingsForm.settings.ProjectPath)))));
                else if (File.Exists(file))
                {
                    string copiedFile = file.Replace(SettingsForm.settings.ExtractedPath, Path.GetDirectoryName(Path.GetFullPath(SettingsForm.settings.ProjectPath)));
                    Directory.CreateDirectory(Path.GetDirectoryName(copiedFile));
                    File.Copy(file, copiedFile);
                }
                else
                {
                    Output.Log($"[ERROR] Failed to copy {Path.GetFileName(file)} to project.");
                    return;
                }
                Output.Log($"[INFO] Copied {Path.GetFileName(file)} to project.");
                Treeview_Project();
            }
            HideContextMenus();
        }

        private void OpenLocationGame_Click(object sender, EventArgs e)
        {
            if (treeView_Game.SelectedNode != null)
            {
                string file = treeView_Game.SelectedNode.Name;
                Treeview.OpenLocation(file);
            }
            HideContextMenus();
        }

        private void OpenLocationProject_Click(object sender, EventArgs e)
        {
            if (treeView_Project.SelectedNode != null)
            {
                string file = treeView_Project.SelectedNode.Name;
                Treeview.OpenLocation(file);
            }
            HideContextMenus();
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            if (treeView_Project.SelectedNode != null)
            {
                string originalName = treeView_Project.SelectedNode.Name;
                if (File.Exists(originalName) || Directory.Exists(originalName))
                {
                    string dir = Path.GetDirectoryName(originalName);
                    string newName = "";
                    RenameForm rename = new RenameForm(Path.GetFileNameWithoutExtension(originalName));
                    var result = rename.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        newName = Path.Combine(dir, rename.RenameText) + Path.GetExtension(originalName);
                        if (File.Exists(originalName) && !File.Exists(newName))
                        {
                            File.Copy(originalName, newName);
                            Output.Log($"[INFO] Copied \"{Path.GetFileName(originalName)}\" as \"{Path.GetFileName(newName)}\"");
                        }
                        else if (Directory.Exists(originalName) && !Directory.Exists(newName))
                        {
                            Unpacker.CopyEntireDirectory(new DirectoryInfo(originalName), new DirectoryInfo(newName));
                            Output.Log($"[INFO] Copied \"{Path.GetFileName(originalName)}\" as \"{Path.GetFileName(newName)}\"");
                        }
                        else
                            Output.Log($"[ERROR] Failed to copy \"{Path.GetFileName(originalName)}\" as \"{Path.GetFileName(newName)}\", file already exists");
                    }
                    Treeview_Project();
                }
                else
                    Output.Log($"[ERROR] Failed to copy \"{Path.GetFileName(originalName)}\", file or folder does not exist");
            }
        }

        private void Rename_Click(object sender, EventArgs e)
        {
            string originalName = treeView_Project.SelectedNode.Name;
            if (treeView_Project.SelectedNode != null)
            {
                string dir = Path.GetDirectoryName(originalName);
                string newName = "";
                RenameForm rename = new RenameForm(Path.GetFileNameWithoutExtension(originalName));
                var result = rename.ShowDialog();
                if (result == DialogResult.OK)
                {
                    newName = Path.Combine(dir, rename.RenameText) + Path.GetExtension(originalName);
                    if (File.Exists(originalName) && !File.Exists(newName))
                    {
                        File.Move(originalName, newName);
                        Output.Log($"[INFO] Renamed \"{Path.GetFileName(originalName)}\" to \"{Path.GetFileName(newName)}\"");
                    }
                    else if (Directory.Exists(originalName) && !Directory.Exists(newName))
                    {
                        Directory.Move(treeView_Project.SelectedNode.Name, newName);
                        Output.Log($"[INFO] Renamed \"{Path.GetFileName(originalName)}\" to \"{Path.GetFileName(newName)}\"");
                    }
                    else
                        Output.Log($"[ERROR] Failed to rename \"{Path.GetFileName(originalName)}\" to \"{Path.GetFileName(newName)}\", file already exists");
                    Treeview_Project();
                }
            }
        }

        private void RemoveFromProject_Click(object sender, EventArgs e)
        {
            if (treeView_Project.SelectedNode != null)
            {
                string file = treeView_Project.SelectedNode.Name;
                if (Directory.Exists(file))
                {
                    Directory.Delete(file, true);
                    Output.Log($"[INFO] Deleted directory and contents: {Path.GetFileName(file)}.");
                }
                else if (File.Exists(file))
                {
                    File.Delete(file);
                    Output.Log($"[INFO] Deleted file: {Path.GetFileName(file)}.");
                }
                else
                {
                    Output.Log($"[ERROR] Couldn't find file to delete: {Path.GetFileName(file)}.");
                    return;
                }
                Treeview_Project();
            }
            HideContextMenus();
        }

        /* Load program in asset viewer and load selected file */
        private void ProjectNode_DoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                treeView_Project.SelectedNode = e.Node;
                var ext = Path.GetExtension(treeView_Project.SelectedNode.Name).ToLower();
                switch (ext)
                {
                    case ".acx":
                    case ".rmd":
                    case ".rws":
                    case ".tmx":
                    case ".spr":
                    case ".bin":
                    case ".arc":
                    case ".amd":
                    case ".pac":
                    case ".pak":
                        //Tools.Mount(Program.processList[0], treeView_Project.SelectedNode.Name, assetPanel);
                        metroSetTabControl_Workspace.SelectedIndex = 0;
                        break;
                    case ".gmd":
                    case ".gfs":
                    case ".gap":
                    case ".gnf":
                    case ".gtxd":
                    case ".gmtd":
                    case ".gmt":
                    case ".ganm":
                    case ".gmod":
                    case ".dds":
                    case ".epl":
                        //Tools.Mount(Program.processList[1], treeView_Project.SelectedNode.Name, assetPanel);
                        metroSetTabControl_Workspace.SelectedIndex = 0;
                        break;
                    case ".flow":
                    case ".msg":
                    case ".json":
                    case ".txt":
                    case ".yml":
                    case ".bat":
                    case ".xml":
                        //Tools.Mount(Program.processList[2], treeView_Project.SelectedNode.Name, scriptPanel);
                        metroSetTabControl_Workspace.SelectedIndex = 1;
                        break;
                    default:
                        break;
                }
            }
        }

        /* Open/close right click treeview node context menus */
        private void GameNode_MouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ToolStripMenuItem_Add.Visible = true;
                ToolStripMenuItem_ExpandGame.Visible = true;
                ToolStripMenuItem_CollapseGame.Visible = true;

                treeView_Game.SelectedNode = e.Node;

                // Prevent deleting entire project or project settings file
                if (treeView_Game.SelectedNode.Parent == null || treeView_Game.SelectedNode.Parent.Parent == null)
                    ToolStripMenuItem_Add.Visible = false;
                // Hide expand/collapse if not folder
                if (treeView_Game.SelectedNode.ImageIndex != 18)
                {
                    ToolStripMenuItem_ExpandGame.Visible = false;
                    ToolStripMenuItem_CollapseGame.Visible = false;
                }

                contextMenuStrip_Game.Show(Cursor.Position);
            }

        }
        private void ProjectNode_MouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ToolStripMenuItem_Copy.Visible = true;
                ToolStripMenuItem_Rename.Visible = true;
                ToolStripMenuItem_Remove.Visible = true;
                ToolStripMenuItem_ExpandProj.Visible = true;
                ToolStripMenuItem_CollapseProj.Visible = true;
                ToolStripMenuItem_New.Visible = true;
                ToolStripMenuItem_RepackAs.Visible = true;
                ToolStripMenuItem_Replace.Visible = true;
                ToolStripMenuItem_Unpack.Visible = true;
                ToolStripMenuItem_Compile.Visible = true;
                ToolStripMenuItem_Decompile.Visible = true;

                treeView_Project.SelectedNode = e.Node;
                // Hide add to project option if topmost two levels (Game/Archive) 
                // to prevent copying entire game/archive's worth of data
                if (treeView_Project.SelectedNode.Parent == null || treeView_Project.SelectedNode.Name.ToLower().EndsWith(".yml"))
                {
                    ToolStripMenuItem_Copy.Visible = false;
                    ToolStripMenuItem_Rename.Visible = false;
                    ToolStripMenuItem_Remove.Visible = false;
                }
                // Hide (de)compile, new, repack, replace & expand/collapse, unpack
                if (!Treeview.decompileTreeViewTypes.Any(x => x.Equals(Path.GetExtension(treeView_Project.SelectedNode.Name).ToLower())))
                    ToolStripMenuItem_Decompile.Visible = false;
                if (!Treeview.compileTreeViewTypes.Any(x => x.Equals(Path.GetExtension(treeView_Project.SelectedNode.Name).ToLower())))
                    ToolStripMenuItem_Compile.Visible = false;
                if (treeView_Project.SelectedNode.ImageIndex != 18)
                {
                    ToolStripMenuItem_ExpandProj.Visible = false;
                    ToolStripMenuItem_CollapseProj.Visible = false;
                    ToolStripMenuItem_New.Visible = false;
                    ToolStripMenuItem_RepackAs.Visible = false;
                }
                else
                    ToolStripMenuItem_Replace.Visible = false;
                if (!Treeview.unpackTreeViewTypes.Any(x => x.Equals(Path.GetExtension(treeView_Project.SelectedNode.Name).ToLower())))
                    ToolStripMenuItem_Unpack.Visible = false;
                contextMenuStrip_Project.Show(Cursor.Position);
            }
        }

        private void ShowHide_Click(object sender, EventArgs e)
        {
            if (metroSetButton_ShowHide.Text != "»")
            {
                // Collapse file browser and log
                tableLayoutPanel_Main.ColumnStyles[0].SizeType = SizeType.AutoSize;
                tableLayoutPanel_Main.HideColumns(new int[] { 0 });
                tableLayoutPanel_Workspace.HideRows(new int[] { 1 });
                metroSetButton_ShowHide.Text = "»";
            }
            else
            {
                // Show file browser and log
                tableLayoutPanel_Main.ShowColumns(new int[] { 0 });
                tableLayoutPanel_Workspace.ShowRows(new int[] { 1 });
                tableLayoutPanel_Main.ColumnStyles[0].SizeType = SizeType.Percent;
                tableLayoutPanel_Main.ColumnStyles[0].Width = 28f;
                metroSetButton_ShowHide.Text = "«";
            }
        }

        private void HideContextMenus()
        {
            contextMenuStrip_Project.Hide();
            contextMenuStrip_Game.Hide();
        }

        /* Dump Menustrip Items */
        private void DumpTextures_Click(object sender, EventArgs e)
        {
            string unpackedDir = $@"{Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)}\Extracted\{SettingsForm.settings.Game}";
            if (Unpacker.IsDumpReady(true))
                Unpacker.DumpTextures(unpackedDir, SettingsForm.settings.Game);
        }
        #endregion
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
