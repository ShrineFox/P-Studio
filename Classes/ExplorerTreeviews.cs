﻿using DarkUI.Forms;
using MetroSet_UI.Controls;
using ShrineFox.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PStudio
{
    public partial class PStudioForm : DarkForm
    {
        public TreeView treeView_Project;
        public TreeView treeView_Game;

        private void SetupTreeviews()
        {
            MetroSetTabControl tabControl_Explorer = SFControls.SFTabControl();

            var tabPage_Game = SFControls.SFTabPage("tabPage_Game", "Game");
            treeView_Game = SFControls.SFTreeView("treeView_Game");
            tabPage_Game.Controls.Add(treeView_Game);

            var tabPage_Project = SFControls.SFTabPage("tabPage_Project", "Project");
            treeView_Project = SFControls.SFTreeView("treeView_Project");
            tabPage_Project.Controls.Add(treeView_Project);

            tabControl_Explorer.TabPages.Add(tabPage_Game);
            tabControl_Explorer.TabPages.Add(tabPage_Project);

            tlp_Main.Controls.Add(tabControl_Explorer, 0, 0);

            LoadTreeview(treeView_Game);
            LoadTreeview(treeView_Project);

            Output.VerboseLog("Done loading treeviews.");
        }

        public void LoadTreeview(TreeView treeView)
        {
            FolderFileNode root = null;
            if (treeView.Name == "treeView_Game")
                root = new FolderFileNode(project.GamePath);
            else if (treeView.Name == "treeView_Project")
                root = new FolderFileNode(project.ModPath);

            treeView.Nodes.Clear();
            treeView.Nodes.Add(root);
            root.LoadNodes();
            treeView.ImageList = TreeViewBuilder.ImageList;

            treeView.BeforeSelect += (sender, args) =>
            {
                (args.Node as FolderFileNode)?.LoadNodes();
            };

            treeView.AfterExpand += (sender, args) =>
            {
                (args.Node as FolderFileNode)?.SetIcon();
            };

            treeView.AfterCollapse += (sender, args) =>
            {
                (args.Node as FolderFileNode)?.SetIcon();
            };
        }
    }
}