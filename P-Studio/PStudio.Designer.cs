
namespace P_Studio
{
    partial class PStudio : MetroSet_UI.Forms.MetroSetForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PStudio));
            this.tableLayoutPanel_Container = new System.Windows.Forms.TableLayoutPanel();
            this.metroSetProgressBar_Main = new MetroSet_UI.Controls.MetroSetProgressBar();
            this.styleManager = new MetroSet_UI.Components.StyleManager();
            this.tableLayoutPanel_Main = new System.Windows.Forms.TableLayoutPanel();
            this.metroSetTabControl_GameProject = new MetroSet_UI.Controls.MetroSetTabControl();
            this.tabPage_Game = new System.Windows.Forms.TabPage();
            this.treeView_Game = new System.Windows.Forms.TreeView();
            this.tabPage_Project = new System.Windows.Forms.TabPage();
            this.treeView_Project = new System.Windows.Forms.TreeView();
            this.tableLayoutPanel_Workspace = new System.Windows.Forms.TableLayoutPanel();
            this.metroSetTabControl_Workspace = new MetroSet_UI.Controls.MetroSetTabControl();
            this.tabPage_Asset = new System.Windows.Forms.TabPage();
            this.tabPage_Scripting = new System.Windows.Forms.TabPage();
            this.richTextBox_Status = new System.Windows.Forms.RichTextBox();
            this.menuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroSetContextMenuStrip_Game = new MetroSet_UI.Controls.MetroSetContextMenuStrip();
            this.metroSetToolStripMenuItem_Add = new MetroSet_UI.Child.MetroSetToolStripMenuItem();
            this.metroSetToolStripMenuItem_OpenAt = new MetroSet_UI.Child.MetroSetToolStripMenuItem();
            this.metroSetContextMenuStrip_Project = new MetroSet_UI.Controls.MetroSetContextMenuStrip();
            this.metroSetToolStripMenuItem_Remove = new MetroSet_UI.Child.MetroSetToolStripMenuItem();
            this.metroSetToolStripMenuItem_OpenAt2 = new MetroSet_UI.Child.MetroSetToolStripMenuItem();
            this.tableLayoutPanel_Container.SuspendLayout();
            this.tableLayoutPanel_Main.SuspendLayout();
            this.metroSetTabControl_GameProject.SuspendLayout();
            this.tabPage_Game.SuspendLayout();
            this.tabPage_Project.SuspendLayout();
            this.tableLayoutPanel_Workspace.SuspendLayout();
            this.metroSetTabControl_Workspace.SuspendLayout();
            this.menuStrip_Main.SuspendLayout();
            this.metroSetContextMenuStrip_Game.SuspendLayout();
            this.metroSetContextMenuStrip_Project.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_Container
            // 
            this.tableLayoutPanel_Container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_Container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tableLayoutPanel_Container.ColumnCount = 1;
            this.tableLayoutPanel_Container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Container.Controls.Add(this.metroSetProgressBar_Main, 0, 2);
            this.tableLayoutPanel_Container.Controls.Add(this.tableLayoutPanel_Main, 0, 1);
            this.tableLayoutPanel_Container.Location = new System.Drawing.Point(-5, 3);
            this.tableLayoutPanel_Container.Name = "tableLayoutPanel_Container";
            this.tableLayoutPanel_Container.RowCount = 3;
            this.tableLayoutPanel_Container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel_Container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel_Container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel_Container.Size = new System.Drawing.Size(953, 491);
            this.tableLayoutPanel_Container.TabIndex = 1;
            // 
            // metroSetProgressBar_Main
            // 
            this.metroSetProgressBar_Main.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.metroSetProgressBar_Main.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.metroSetProgressBar_Main.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.metroSetProgressBar_Main.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.metroSetProgressBar_Main.DisabledProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetProgressBar_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetProgressBar_Main.IsDerivedStyle = true;
            this.metroSetProgressBar_Main.Location = new System.Drawing.Point(0, 465);
            this.metroSetProgressBar_Main.Margin = new System.Windows.Forms.Padding(0);
            this.metroSetProgressBar_Main.Maximum = 100;
            this.metroSetProgressBar_Main.Minimum = 0;
            this.metroSetProgressBar_Main.Name = "metroSetProgressBar_Main";
            this.metroSetProgressBar_Main.Orientation = MetroSet_UI.Enums.ProgressOrientation.Horizontal;
            this.metroSetProgressBar_Main.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetProgressBar_Main.Size = new System.Drawing.Size(953, 26);
            this.metroSetProgressBar_Main.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetProgressBar_Main.StyleManager = this.styleManager;
            this.metroSetProgressBar_Main.TabIndex = 1;
            this.metroSetProgressBar_Main.ThemeAuthor = "ShrineFox";
            this.metroSetProgressBar_Main.ThemeName = "MetroDarkBlue";
            this.metroSetProgressBar_Main.Value = 0;
            // 
            // styleManager
            // 
            this.styleManager.CustomTheme = "C:\\Users\\ryans\\Documents\\GitHub\\P-Studio\\ThemeFile.xml";
            this.styleManager.MetroForm = this;
            this.styleManager.Style = MetroSet_UI.Enums.Style.Dark;
            this.styleManager.ThemeAuthor = "ShrineFox";
            this.styleManager.ThemeName = "MetroDarkBlue";
            // 
            // tableLayoutPanel_Main
            // 
            this.tableLayoutPanel_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tableLayoutPanel_Main.ColumnCount = 2;
            this.tableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel_Main.Controls.Add(this.metroSetTabControl_GameProject, 0, 0);
            this.tableLayoutPanel_Main.Controls.Add(this.tableLayoutPanel_Workspace, 1, 0);
            this.tableLayoutPanel_Main.Location = new System.Drawing.Point(3, 27);
            this.tableLayoutPanel_Main.Name = "tableLayoutPanel_Main";
            this.tableLayoutPanel_Main.RowCount = 1;
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_Main.Size = new System.Drawing.Size(947, 435);
            this.tableLayoutPanel_Main.TabIndex = 3;
            // 
            // metroSetTabControl_GameProject
            // 
            this.metroSetTabControl_GameProject.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            this.metroSetTabControl_GameProject.AnimateTime = 200;
            this.metroSetTabControl_GameProject.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroSetTabControl_GameProject.Controls.Add(this.tabPage_Game);
            this.metroSetTabControl_GameProject.Controls.Add(this.tabPage_Project);
            this.metroSetTabControl_GameProject.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroSetTabControl_GameProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetTabControl_GameProject.HotTrack = true;
            this.metroSetTabControl_GameProject.IsDerivedStyle = true;
            this.metroSetTabControl_GameProject.ItemSize = new System.Drawing.Size(100, 38);
            this.metroSetTabControl_GameProject.Location = new System.Drawing.Point(3, 3);
            this.metroSetTabControl_GameProject.Name = "metroSetTabControl_GameProject";
            this.metroSetTabControl_GameProject.SelectedIndex = 0;
            this.metroSetTabControl_GameProject.SelectedTextColor = System.Drawing.Color.White;
            this.metroSetTabControl_GameProject.Size = new System.Drawing.Size(278, 429);
            this.metroSetTabControl_GameProject.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.metroSetTabControl_GameProject.Speed = 50;
            this.metroSetTabControl_GameProject.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetTabControl_GameProject.StyleManager = null;
            this.metroSetTabControl_GameProject.TabIndex = 2;
            this.metroSetTabControl_GameProject.ThemeAuthor = "Narwin";
            this.metroSetTabControl_GameProject.ThemeName = "MetroDark";
            this.metroSetTabControl_GameProject.UnselectedTextColor = System.Drawing.Color.Gray;
            this.metroSetTabControl_GameProject.UseAnimation = false;
            // 
            // tabPage_Game
            // 
            this.tabPage_Game.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tabPage_Game.Controls.Add(this.treeView_Game);
            this.tabPage_Game.Location = new System.Drawing.Point(4, 42);
            this.tabPage_Game.Name = "tabPage_Game";
            this.tabPage_Game.Size = new System.Drawing.Size(270, 383);
            this.tabPage_Game.TabIndex = 0;
            this.tabPage_Game.Text = "Game";
            // 
            // treeView_Game
            // 
            this.treeView_Game.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.treeView_Game.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView_Game.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_Game.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.treeView_Game.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.treeView_Game.Location = new System.Drawing.Point(0, 0);
            this.treeView_Game.Name = "treeView_Game";
            this.treeView_Game.Size = new System.Drawing.Size(270, 383);
            this.treeView_Game.TabIndex = 0;
            this.treeView_Game.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.GameNode_MouseClick);
            // 
            // tabPage_Project
            // 
            this.tabPage_Project.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.tabPage_Project.Controls.Add(this.treeView_Project);
            this.tabPage_Project.Location = new System.Drawing.Point(4, 42);
            this.tabPage_Project.Name = "tabPage_Project";
            this.tabPage_Project.Size = new System.Drawing.Size(270, 383);
            this.tabPage_Project.TabIndex = 1;
            this.tabPage_Project.Text = "Project";
            // 
            // treeView_Project
            // 
            this.treeView_Project.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.treeView_Project.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView_Project.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_Project.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.treeView_Project.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.treeView_Project.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.treeView_Project.Location = new System.Drawing.Point(0, 0);
            this.treeView_Project.Name = "treeView_Project";
            this.treeView_Project.Size = new System.Drawing.Size(270, 383);
            this.treeView_Project.TabIndex = 1;
            this.treeView_Project.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.ProjectNode_MouseClick);
            // 
            // tableLayoutPanel_Workspace
            // 
            this.tableLayoutPanel_Workspace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_Workspace.ColumnCount = 1;
            this.tableLayoutPanel_Workspace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Workspace.Controls.Add(this.metroSetTabControl_Workspace, 0, 0);
            this.tableLayoutPanel_Workspace.Controls.Add(this.richTextBox_Status, 0, 1);
            this.tableLayoutPanel_Workspace.Location = new System.Drawing.Point(287, 3);
            this.tableLayoutPanel_Workspace.Name = "tableLayoutPanel_Workspace";
            this.tableLayoutPanel_Workspace.RowCount = 2;
            this.tableLayoutPanel_Workspace.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel_Workspace.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel_Workspace.Size = new System.Drawing.Size(657, 429);
            this.tableLayoutPanel_Workspace.TabIndex = 0;
            // 
            // metroSetTabControl_Workspace
            // 
            this.metroSetTabControl_Workspace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetTabControl_Workspace.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            this.metroSetTabControl_Workspace.AnimateTime = 100;
            this.metroSetTabControl_Workspace.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroSetTabControl_Workspace.Controls.Add(this.tabPage_Asset);
            this.metroSetTabControl_Workspace.Controls.Add(this.tabPage_Scripting);
            this.metroSetTabControl_Workspace.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroSetTabControl_Workspace.HotTrack = true;
            this.metroSetTabControl_Workspace.IsDerivedStyle = true;
            this.metroSetTabControl_Workspace.ItemSize = new System.Drawing.Size(100, 38);
            this.metroSetTabControl_Workspace.Location = new System.Drawing.Point(3, 3);
            this.metroSetTabControl_Workspace.Name = "metroSetTabControl_Workspace";
            this.metroSetTabControl_Workspace.SelectedIndex = 0;
            this.metroSetTabControl_Workspace.SelectedTextColor = System.Drawing.Color.White;
            this.metroSetTabControl_Workspace.Size = new System.Drawing.Size(651, 358);
            this.metroSetTabControl_Workspace.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.metroSetTabControl_Workspace.Speed = 200;
            this.metroSetTabControl_Workspace.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetTabControl_Workspace.StyleManager = null;
            this.metroSetTabControl_Workspace.TabIndex = 1;
            this.metroSetTabControl_Workspace.ThemeAuthor = "Narwin";
            this.metroSetTabControl_Workspace.ThemeName = "MetroDark";
            this.metroSetTabControl_Workspace.UnselectedTextColor = System.Drawing.Color.Gray;
            this.metroSetTabControl_Workspace.UseAnimation = false;
            // 
            // tabPage_Asset
            // 
            this.tabPage_Asset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tabPage_Asset.Location = new System.Drawing.Point(4, 42);
            this.tabPage_Asset.Name = "tabPage_Asset";
            this.tabPage_Asset.Size = new System.Drawing.Size(643, 312);
            this.tabPage_Asset.TabIndex = 0;
            this.tabPage_Asset.Text = "Edit Asset";
            // 
            // tabPage_Scripting
            // 
            this.tabPage_Scripting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tabPage_Scripting.Location = new System.Drawing.Point(4, 42);
            this.tabPage_Scripting.Name = "tabPage_Scripting";
            this.tabPage_Scripting.Size = new System.Drawing.Size(643, 312);
            this.tabPage_Scripting.TabIndex = 1;
            this.tabPage_Scripting.Text = "Scripting";
            // 
            // richTextBox_Status
            // 
            this.richTextBox_Status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.richTextBox_Status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_Status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.richTextBox_Status.ForeColor = System.Drawing.Color.DarkGray;
            this.richTextBox_Status.Location = new System.Drawing.Point(3, 367);
            this.richTextBox_Status.Name = "richTextBox_Status";
            this.richTextBox_Status.ReadOnly = true;
            this.richTextBox_Status.Size = new System.Drawing.Size(651, 59);
            this.richTextBox_Status.TabIndex = 2;
            this.richTextBox_Status.Text = "Welcome to P-Studio!";
            // 
            // menuStrip_Main
            // 
            this.menuStrip_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.menuStrip_Main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip_Main.Location = new System.Drawing.Point(2, 0);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.Size = new System.Drawing.Size(938, 28);
            this.menuStrip_Main.TabIndex = 2;
            this.menuStrip_Main.Text = "menuStrip_Main";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectToolStripMenuItem,
            this.loadProjectToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.newProjectToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.newProjectToolStripMenuItem.Text = "New Project";
            this.newProjectToolStripMenuItem.Click += new System.EventHandler(this.NewProject_Click);
            // 
            // loadProjectToolStripMenuItem
            // 
            this.loadProjectToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.loadProjectToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.loadProjectToolStripMenuItem.Name = "loadProjectToolStripMenuItem";
            this.loadProjectToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.loadProjectToolStripMenuItem.Text = "Load Project";
            this.loadProjectToolStripMenuItem.Click += new System.EventHandler(this.LoadProject_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.Settings_Click);
            // 
            // metroSetContextMenuStrip_Game
            // 
            this.metroSetContextMenuStrip_Game.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.metroSetContextMenuStrip_Game.IsDerivedStyle = true;
            this.metroSetContextMenuStrip_Game.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.metroSetToolStripMenuItem_Add,
            this.metroSetToolStripMenuItem_OpenAt});
            this.metroSetContextMenuStrip_Game.Name = "metroSetContextMenuStrip_Game";
            this.metroSetContextMenuStrip_Game.Size = new System.Drawing.Size(175, 64);
            this.metroSetContextMenuStrip_Game.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetContextMenuStrip_Game.StyleManager = null;
            this.metroSetContextMenuStrip_Game.ThemeAuthor = "Narwin";
            this.metroSetContextMenuStrip_Game.ThemeName = "MetroDark";
            // 
            // metroSetToolStripMenuItem_Add
            // 
            this.metroSetToolStripMenuItem_Add.AutoSize = false;
            this.metroSetToolStripMenuItem_Add.Name = "metroSetToolStripMenuItem_Add";
            this.metroSetToolStripMenuItem_Add.Size = new System.Drawing.Size(160, 30);
            this.metroSetToolStripMenuItem_Add.Text = "Add to Project";
            this.metroSetToolStripMenuItem_Add.Click += new System.EventHandler(this.AddToProject_Click);
            // 
            // metroSetToolStripMenuItem_OpenAt
            // 
            this.metroSetToolStripMenuItem_OpenAt.AutoSize = false;
            this.metroSetToolStripMenuItem_OpenAt.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.metroSetToolStripMenuItem_OpenAt.Name = "metroSetToolStripMenuItem_OpenAt";
            this.metroSetToolStripMenuItem_OpenAt.Size = new System.Drawing.Size(160, 30);
            this.metroSetToolStripMenuItem_OpenAt.Text = "Show Folder";
            this.metroSetToolStripMenuItem_OpenAt.Click += new System.EventHandler(this.OpenLocationGame_Click);
            // 
            // metroSetContextMenuStrip_Project
            // 
            this.metroSetContextMenuStrip_Project.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.metroSetContextMenuStrip_Project.IsDerivedStyle = true;
            this.metroSetContextMenuStrip_Project.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.metroSetToolStripMenuItem_Remove,
            this.metroSetToolStripMenuItem_OpenAt2});
            this.metroSetContextMenuStrip_Project.Name = "metroSetContextMenuStrip_Game";
            this.metroSetContextMenuStrip_Project.Size = new System.Drawing.Size(161, 64);
            this.metroSetContextMenuStrip_Project.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetContextMenuStrip_Project.StyleManager = null;
            this.metroSetContextMenuStrip_Project.ThemeAuthor = "Narwin";
            this.metroSetContextMenuStrip_Project.ThemeName = "MetroDark";
            // 
            // metroSetToolStripMenuItem_Remove
            // 
            this.metroSetToolStripMenuItem_Remove.AutoSize = false;
            this.metroSetToolStripMenuItem_Remove.Name = "metroSetToolStripMenuItem_Remove";
            this.metroSetToolStripMenuItem_Remove.Size = new System.Drawing.Size(160, 30);
            this.metroSetToolStripMenuItem_Remove.Text = "Remove";
            this.metroSetToolStripMenuItem_Remove.Click += new System.EventHandler(this.RemoveFromProject_Click);
            // 
            // metroSetToolStripMenuItem_OpenAt2
            // 
            this.metroSetToolStripMenuItem_OpenAt2.AutoSize = false;
            this.metroSetToolStripMenuItem_OpenAt2.Name = "metroSetToolStripMenuItem_OpenAt2";
            this.metroSetToolStripMenuItem_OpenAt2.Size = new System.Drawing.Size(160, 30);
            this.metroSetToolStripMenuItem_OpenAt2.Text = "Show Folder";
            this.metroSetToolStripMenuItem_OpenAt2.Click += new System.EventHandler(this.OpenLocationProject_Click);
            // 
            // PStudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(942, 493);
            this.Controls.Add(this.menuStrip_Main);
            this.Controls.Add(this.tableLayoutPanel_Container);
            this.DropShadowEffect = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.HeaderHeight = -40;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(640, 360);
            this.Name = "PStudio";
            this.Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.ShowHeader = true;
            this.ShowLeftRect = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Style = MetroSet_UI.Enums.Style.Dark;
            this.StyleManager = this.styleManager;
            this.Text = "P-Studio v0.1";
            this.ThemeAuthor = "ShrineFox";
            this.ThemeName = "MetroDarkBlue";
            this.tableLayoutPanel_Container.ResumeLayout(false);
            this.tableLayoutPanel_Main.ResumeLayout(false);
            this.metroSetTabControl_GameProject.ResumeLayout(false);
            this.tabPage_Game.ResumeLayout(false);
            this.tabPage_Project.ResumeLayout(false);
            this.tableLayoutPanel_Workspace.ResumeLayout(false);
            this.metroSetTabControl_Workspace.ResumeLayout(false);
            this.menuStrip_Main.ResumeLayout(false);
            this.menuStrip_Main.PerformLayout();
            this.metroSetContextMenuStrip_Game.ResumeLayout(false);
            this.metroSetContextMenuStrip_Project.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Container;
        private MetroSet_UI.Controls.MetroSetProgressBar metroSetProgressBar_Main;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Main;
        private MetroSet_UI.Controls.MetroSetTabControl metroSetTabControl_GameProject;
        private System.Windows.Forms.TabPage tabPage_Game;
        private System.Windows.Forms.TreeView treeView_Game;
        private System.Windows.Forms.TabPage tabPage_Project;
        private System.Windows.Forms.TreeView treeView_Project;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Workspace;
        private MetroSet_UI.Controls.MetroSetTabControl metroSetTabControl_Workspace;
        private System.Windows.Forms.TabPage tabPage_Asset;
        private System.Windows.Forms.TabPage tabPage_Scripting;
        private System.Windows.Forms.MenuStrip menuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private MetroSet_UI.Components.StyleManager styleManager;
        private MetroSet_UI.Controls.MetroSetContextMenuStrip metroSetContextMenuStrip_Game;
        private MetroSet_UI.Child.MetroSetToolStripMenuItem metroSetToolStripMenuItem_Add;
        private MetroSet_UI.Child.MetroSetToolStripMenuItem metroSetToolStripMenuItem_OpenAt;
        private MetroSet_UI.Controls.MetroSetContextMenuStrip metroSetContextMenuStrip_Project;
        private MetroSet_UI.Child.MetroSetToolStripMenuItem metroSetToolStripMenuItem_Remove;
        private MetroSet_UI.Child.MetroSetToolStripMenuItem metroSetToolStripMenuItem_OpenAt2;
        private System.Windows.Forms.RichTextBox richTextBox_Status;
    }
}