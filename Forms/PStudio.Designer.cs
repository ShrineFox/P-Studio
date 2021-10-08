
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
            this.components = new System.ComponentModel.Container();
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
            this.panel_Asset = new System.Windows.Forms.Panel();
            this.tabPage_Scripting = new System.Windows.Forms.TabPage();
            this.panel_Scripting = new System.Windows.Forms.Panel();
            this.richTextBox_Status = new System.Windows.Forms.RichTextBox();
            this.metroSetButton_ShowHide = new MetroSet_UI.Controls.MetroSetButton();
            this.menuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dumpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dumpTexturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dumpSoundsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dumpScriptsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip_Game = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_OpenAt = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_ExpandGame = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_CollapseGame = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip_Project = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_New = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_NewFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_NewFlow = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_NewMsg = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_NewTxt = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Decompile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Compile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Unpack = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_RepackAs = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_RepackPAC = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_RepackAFS = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_RepackAWB = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Replace = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Remove = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_OpenAt2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Rename = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_ExpandProj = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_CollapseProj = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel_Container.SuspendLayout();
            this.tableLayoutPanel_Main.SuspendLayout();
            this.metroSetTabControl_GameProject.SuspendLayout();
            this.tabPage_Game.SuspendLayout();
            this.tabPage_Project.SuspendLayout();
            this.tableLayoutPanel_Workspace.SuspendLayout();
            this.metroSetTabControl_Workspace.SuspendLayout();
            this.tabPage_Asset.SuspendLayout();
            this.tabPage_Scripting.SuspendLayout();
            this.menuStrip_Main.SuspendLayout();
            this.contextMenuStrip_Game.SuspendLayout();
            this.contextMenuStrip_Project.SuspendLayout();
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
            this.tableLayoutPanel_Container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94F));
            this.tableLayoutPanel_Container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1F));
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
            this.metroSetProgressBar_Main.Location = new System.Drawing.Point(0, 485);
            this.metroSetProgressBar_Main.Margin = new System.Windows.Forms.Padding(0);
            this.metroSetProgressBar_Main.Maximum = 100;
            this.metroSetProgressBar_Main.Minimum = 0;
            this.metroSetProgressBar_Main.Name = "metroSetProgressBar_Main";
            this.metroSetProgressBar_Main.Orientation = MetroSet_UI.Enums.ProgressOrientation.Horizontal;
            this.metroSetProgressBar_Main.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetProgressBar_Main.Size = new System.Drawing.Size(953, 6);
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
            this.tableLayoutPanel_Main.ColumnCount = 3;
            this.tableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel_Main.Controls.Add(this.metroSetTabControl_GameProject, 0, 0);
            this.tableLayoutPanel_Main.Controls.Add(this.tableLayoutPanel_Workspace, 2, 0);
            this.tableLayoutPanel_Main.Controls.Add(this.metroSetButton_ShowHide, 1, 0);
            this.tableLayoutPanel_Main.Location = new System.Drawing.Point(3, 27);
            this.tableLayoutPanel_Main.Name = "tableLayoutPanel_Main";
            this.tableLayoutPanel_Main.RowCount = 1;
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Main.Size = new System.Drawing.Size(947, 455);
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
            this.metroSetTabControl_GameProject.Size = new System.Drawing.Size(259, 449);
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
            this.tabPage_Game.Size = new System.Drawing.Size(251, 403);
            this.tabPage_Game.TabIndex = 0;
            this.tabPage_Game.Text = "Game";
            // 
            // treeView_Game
            // 
            this.treeView_Game.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.treeView_Game.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView_Game.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_Game.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.treeView_Game.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.treeView_Game.Location = new System.Drawing.Point(0, 0);
            this.treeView_Game.Name = "treeView_Game";
            this.treeView_Game.Size = new System.Drawing.Size(251, 403);
            this.treeView_Game.TabIndex = 0;
            this.treeView_Game.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.GameNode_MouseClick);
            // 
            // tabPage_Project
            // 
            this.tabPage_Project.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.tabPage_Project.Controls.Add(this.treeView_Project);
            this.tabPage_Project.Location = new System.Drawing.Point(4, 42);
            this.tabPage_Project.Name = "tabPage_Project";
            this.tabPage_Project.Size = new System.Drawing.Size(251, 403);
            this.tabPage_Project.TabIndex = 1;
            this.tabPage_Project.Text = "Project";
            // 
            // treeView_Project
            // 
            this.treeView_Project.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.treeView_Project.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView_Project.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_Project.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.treeView_Project.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.treeView_Project.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.treeView_Project.Location = new System.Drawing.Point(0, 0);
            this.treeView_Project.Name = "treeView_Project";
            this.treeView_Project.Size = new System.Drawing.Size(251, 403);
            this.treeView_Project.TabIndex = 1;
            this.treeView_Project.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.ProjectNode_MouseClick);
            this.treeView_Project.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.ProjectNode_DoubleClick);
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
            this.tableLayoutPanel_Workspace.Location = new System.Drawing.Point(286, 3);
            this.tableLayoutPanel_Workspace.Name = "tableLayoutPanel_Workspace";
            this.tableLayoutPanel_Workspace.RowCount = 2;
            this.tableLayoutPanel_Workspace.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Workspace.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_Workspace.Size = new System.Drawing.Size(658, 449);
            this.tableLayoutPanel_Workspace.TabIndex = 0;
            // 
            // metroSetTabControl_Workspace
            // 
            this.metroSetTabControl_Workspace.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            this.metroSetTabControl_Workspace.AnimateTime = 100;
            this.metroSetTabControl_Workspace.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroSetTabControl_Workspace.Controls.Add(this.tabPage_Asset);
            this.metroSetTabControl_Workspace.Controls.Add(this.tabPage_Scripting);
            this.metroSetTabControl_Workspace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroSetTabControl_Workspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetTabControl_Workspace.HotTrack = true;
            this.metroSetTabControl_Workspace.IsDerivedStyle = true;
            this.metroSetTabControl_Workspace.ItemSize = new System.Drawing.Size(100, 38);
            this.metroSetTabControl_Workspace.Location = new System.Drawing.Point(3, 3);
            this.metroSetTabControl_Workspace.Name = "metroSetTabControl_Workspace";
            this.metroSetTabControl_Workspace.SelectedIndex = 1;
            this.metroSetTabControl_Workspace.SelectedTextColor = System.Drawing.Color.White;
            this.metroSetTabControl_Workspace.Size = new System.Drawing.Size(652, 378);
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
            this.tabPage_Asset.Controls.Add(this.panel_Asset);
            this.tabPage_Asset.Location = new System.Drawing.Point(4, 42);
            this.tabPage_Asset.Name = "tabPage_Asset";
            this.tabPage_Asset.Size = new System.Drawing.Size(644, 332);
            this.tabPage_Asset.TabIndex = 0;
            this.tabPage_Asset.Text = "Edit Asset";
            // 
            // panel_Asset
            // 
            this.panel_Asset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Asset.Location = new System.Drawing.Point(0, 0);
            this.panel_Asset.Name = "panel_Asset";
            this.panel_Asset.Size = new System.Drawing.Size(644, 332);
            this.panel_Asset.TabIndex = 2;
            // 
            // tabPage_Scripting
            // 
            this.tabPage_Scripting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tabPage_Scripting.Controls.Add(this.panel_Scripting);
            this.tabPage_Scripting.Location = new System.Drawing.Point(4, 42);
            this.tabPage_Scripting.Name = "tabPage_Scripting";
            this.tabPage_Scripting.Size = new System.Drawing.Size(644, 332);
            this.tabPage_Scripting.TabIndex = 1;
            this.tabPage_Scripting.Text = "Scripting";
            // 
            // panel_Scripting
            // 
            this.panel_Scripting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Scripting.Location = new System.Drawing.Point(0, 0);
            this.panel_Scripting.Name = "panel_Scripting";
            this.panel_Scripting.Size = new System.Drawing.Size(644, 332);
            this.panel_Scripting.TabIndex = 3;
            // 
            // richTextBox_Status
            // 
            this.richTextBox_Status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.richTextBox_Status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_Status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox_Status.ForeColor = System.Drawing.Color.DarkGray;
            this.richTextBox_Status.Location = new System.Drawing.Point(3, 387);
            this.richTextBox_Status.Name = "richTextBox_Status";
            this.richTextBox_Status.ReadOnly = true;
            this.richTextBox_Status.Size = new System.Drawing.Size(652, 59);
            this.richTextBox_Status.TabIndex = 2;
            this.richTextBox_Status.Text = "Welcome to P-Studio!";
            // 
            // metroSetButton_ShowHide
            // 
            this.metroSetButton_ShowHide.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.metroSetButton_ShowHide.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.metroSetButton_ShowHide.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButton_ShowHide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetButton_ShowHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroSetButton_ShowHide.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroSetButton_ShowHide.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroSetButton_ShowHide.HoverTextColor = System.Drawing.Color.Silver;
            this.metroSetButton_ShowHide.IsDerivedStyle = true;
            this.metroSetButton_ShowHide.Location = new System.Drawing.Point(268, 3);
            this.metroSetButton_ShowHide.Name = "metroSetButton_ShowHide";
            this.metroSetButton_ShowHide.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroSetButton_ShowHide.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroSetButton_ShowHide.NormalTextColor = System.Drawing.Color.Gray;
            this.metroSetButton_ShowHide.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroSetButton_ShowHide.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroSetButton_ShowHide.PressTextColor = System.Drawing.Color.Silver;
            this.metroSetButton_ShowHide.Size = new System.Drawing.Size(12, 449);
            this.metroSetButton_ShowHide.Style = MetroSet_UI.Enums.Style.Custom;
            this.metroSetButton_ShowHide.StyleManager = null;
            this.metroSetButton_ShowHide.TabIndex = 3;
            this.metroSetButton_ShowHide.Text = "«";
            this.metroSetButton_ShowHide.ThemeAuthor = "Narwin";
            this.metroSetButton_ShowHide.ThemeName = "MetroDark";
            this.metroSetButton_ShowHide.Click += new System.EventHandler(this.ShowHide_Click);
            // 
            // menuStrip_Main
            // 
            this.menuStrip_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.menuStrip_Main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dumpToolStripMenuItem});
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
            this.saveProjectToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.fileToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.newProjectToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.newProjectToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.newProjectToolStripMenuItem.Text = "New Project";
            this.newProjectToolStripMenuItem.Click += new System.EventHandler(this.NewProject_Click);
            // 
            // loadProjectToolStripMenuItem
            // 
            this.loadProjectToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.loadProjectToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.loadProjectToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.loadProjectToolStripMenuItem.Name = "loadProjectToolStripMenuItem";
            this.loadProjectToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.loadProjectToolStripMenuItem.Text = "Load Project";
            this.loadProjectToolStripMenuItem.Click += new System.EventHandler(this.LoadProject_Click);
            // 
            // saveProjectToolStripMenuItem
            // 
            this.saveProjectToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.saveProjectToolStripMenuItem.Enabled = false;
            this.saveProjectToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.saveProjectToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.saveProjectToolStripMenuItem.Name = "saveProjectToolStripMenuItem";
            this.saveProjectToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.saveProjectToolStripMenuItem.Text = "Save Project As...";
            this.saveProjectToolStripMenuItem.Click += new System.EventHandler(this.SaveProjectAs_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.settingsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.Settings_Click);
            // 
            // dumpToolStripMenuItem
            // 
            this.dumpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dumpTexturesToolStripMenuItem,
            this.dumpSoundsToolStripMenuItem,
            this.dumpScriptsToolStripMenuItem});
            this.dumpToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.dumpToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.dumpToolStripMenuItem.Name = "dumpToolStripMenuItem";
            this.dumpToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.dumpToolStripMenuItem.Text = "Dump";
            // 
            // dumpTexturesToolStripMenuItem
            // 
            this.dumpTexturesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dumpTexturesToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.dumpTexturesToolStripMenuItem.Name = "dumpTexturesToolStripMenuItem";
            this.dumpTexturesToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.dumpTexturesToolStripMenuItem.Text = "All Textures";
            this.dumpTexturesToolStripMenuItem.Click += new System.EventHandler(this.DumpTextures_Click);
            // 
            // dumpSoundsToolStripMenuItem
            // 
            this.dumpSoundsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dumpSoundsToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.dumpSoundsToolStripMenuItem.Name = "dumpSoundsToolStripMenuItem";
            this.dumpSoundsToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.dumpSoundsToolStripMenuItem.Text = "All Sounds";
            // 
            // dumpScriptsToolStripMenuItem
            // 
            this.dumpScriptsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dumpScriptsToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.dumpScriptsToolStripMenuItem.Name = "dumpScriptsToolStripMenuItem";
            this.dumpScriptsToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.dumpScriptsToolStripMenuItem.Text = "All Scripts";
            // 
            // contextMenuStrip_Game
            // 
            this.contextMenuStrip_Game.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.contextMenuStrip_Game.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip_Game.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Add,
            this.ToolStripMenuItem_OpenAt,
            this.ToolStripMenuItem_ExpandGame,
            this.ToolStripMenuItem_CollapseGame});
            this.contextMenuStrip_Game.Name = "contextMenuStrip_Game";
            this.contextMenuStrip_Game.Size = new System.Drawing.Size(175, 124);
            // 
            // ToolStripMenuItem_Add
            // 
            this.ToolStripMenuItem_Add.AutoSize = false;
            this.ToolStripMenuItem_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ToolStripMenuItem_Add.ForeColor = System.Drawing.Color.Silver;
            this.ToolStripMenuItem_Add.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem_Add.Name = "ToolStripMenuItem_Add";
            this.ToolStripMenuItem_Add.Size = new System.Drawing.Size(160, 30);
            this.ToolStripMenuItem_Add.Text = "Add to Project";
            this.ToolStripMenuItem_Add.Click += new System.EventHandler(this.AddToProject_Click);
            // 
            // ToolStripMenuItem_OpenAt
            // 
            this.ToolStripMenuItem_OpenAt.AutoSize = false;
            this.ToolStripMenuItem_OpenAt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ToolStripMenuItem_OpenAt.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ToolStripMenuItem_OpenAt.ForeColor = System.Drawing.Color.Silver;
            this.ToolStripMenuItem_OpenAt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem_OpenAt.Name = "ToolStripMenuItem_OpenAt";
            this.ToolStripMenuItem_OpenAt.Size = new System.Drawing.Size(160, 30);
            this.ToolStripMenuItem_OpenAt.Text = "Show Folder";
            this.ToolStripMenuItem_OpenAt.Click += new System.EventHandler(this.OpenLocationGame_Click);
            // 
            // ToolStripMenuItem_ExpandGame
            // 
            this.ToolStripMenuItem_ExpandGame.AutoSize = false;
            this.ToolStripMenuItem_ExpandGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ToolStripMenuItem_ExpandGame.ForeColor = System.Drawing.Color.Silver;
            this.ToolStripMenuItem_ExpandGame.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem_ExpandGame.Name = "ToolStripMenuItem_ExpandGame";
            this.ToolStripMenuItem_ExpandGame.Size = new System.Drawing.Size(160, 30);
            this.ToolStripMenuItem_ExpandGame.Text = "Expand All";
            // 
            // ToolStripMenuItem_CollapseGame
            // 
            this.ToolStripMenuItem_CollapseGame.AutoSize = false;
            this.ToolStripMenuItem_CollapseGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ToolStripMenuItem_CollapseGame.ForeColor = System.Drawing.Color.Silver;
            this.ToolStripMenuItem_CollapseGame.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem_CollapseGame.Name = "ToolStripMenuItem_CollapseGame";
            this.ToolStripMenuItem_CollapseGame.Size = new System.Drawing.Size(160, 30);
            this.ToolStripMenuItem_CollapseGame.Text = "Collapse All";
            // 
            // contextMenuStrip_Project
            // 
            this.contextMenuStrip_Project.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.contextMenuStrip_Project.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip_Project.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_New,
            this.ToolStripMenuItem_Decompile,
            this.ToolStripMenuItem_Compile,
            this.ToolStripMenuItem_Unpack,
            this.ToolStripMenuItem_RepackAs,
            this.ToolStripMenuItem_Replace,
            this.ToolStripMenuItem_Remove,
            this.ToolStripMenuItem_OpenAt2,
            this.ToolStripMenuItem_Copy,
            this.ToolStripMenuItem_Rename,
            this.ToolStripMenuItem_ExpandProj,
            this.ToolStripMenuItem_CollapseProj});
            this.contextMenuStrip_Project.Name = "contextMenuStrip_Game";
            this.contextMenuStrip_Project.Size = new System.Drawing.Size(161, 364);
            // 
            // ToolStripMenuItem_New
            // 
            this.ToolStripMenuItem_New.AutoSize = false;
            this.ToolStripMenuItem_New.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ToolStripMenuItem_New.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_NewFolder,
            this.ToolStripMenuItem_NewFlow,
            this.ToolStripMenuItem_NewMsg,
            this.ToolStripMenuItem_NewTxt});
            this.ToolStripMenuItem_New.ForeColor = System.Drawing.Color.Silver;
            this.ToolStripMenuItem_New.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem_New.Name = "ToolStripMenuItem_New";
            this.ToolStripMenuItem_New.Size = new System.Drawing.Size(160, 30);
            this.ToolStripMenuItem_New.Text = "New...";
            // 
            // ToolStripMenuItem_NewFolder
            // 
            this.ToolStripMenuItem_NewFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ToolStripMenuItem_NewFolder.ForeColor = System.Drawing.Color.Silver;
            this.ToolStripMenuItem_NewFolder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem_NewFolder.Name = "ToolStripMenuItem_NewFolder";
            this.ToolStripMenuItem_NewFolder.Size = new System.Drawing.Size(188, 26);
            this.ToolStripMenuItem_NewFolder.Text = "Folder";
            // 
            // ToolStripMenuItem_NewFlow
            // 
            this.ToolStripMenuItem_NewFlow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ToolStripMenuItem_NewFlow.ForeColor = System.Drawing.Color.Silver;
            this.ToolStripMenuItem_NewFlow.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem_NewFlow.Name = "ToolStripMenuItem_NewFlow";
            this.ToolStripMenuItem_NewFlow.Size = new System.Drawing.Size(188, 26);
            this.ToolStripMenuItem_NewFlow.Text = "FlowScript";
            // 
            // ToolStripMenuItem_NewMsg
            // 
            this.ToolStripMenuItem_NewMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ToolStripMenuItem_NewMsg.ForeColor = System.Drawing.Color.Silver;
            this.ToolStripMenuItem_NewMsg.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem_NewMsg.Name = "ToolStripMenuItem_NewMsg";
            this.ToolStripMenuItem_NewMsg.Size = new System.Drawing.Size(188, 26);
            this.ToolStripMenuItem_NewMsg.Text = "MessageScript";
            // 
            // ToolStripMenuItem_NewTxt
            // 
            this.ToolStripMenuItem_NewTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ToolStripMenuItem_NewTxt.ForeColor = System.Drawing.Color.Silver;
            this.ToolStripMenuItem_NewTxt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem_NewTxt.Name = "ToolStripMenuItem_NewTxt";
            this.ToolStripMenuItem_NewTxt.Size = new System.Drawing.Size(188, 26);
            this.ToolStripMenuItem_NewTxt.Text = "Text File";
            // 
            // ToolStripMenuItem_Decompile
            // 
            this.ToolStripMenuItem_Decompile.AutoSize = false;
            this.ToolStripMenuItem_Decompile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ToolStripMenuItem_Decompile.ForeColor = System.Drawing.Color.Silver;
            this.ToolStripMenuItem_Decompile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem_Decompile.Name = "ToolStripMenuItem_Decompile";
            this.ToolStripMenuItem_Decompile.Size = new System.Drawing.Size(160, 30);
            this.ToolStripMenuItem_Decompile.Text = "Decompile";
            // 
            // ToolStripMenuItem_Compile
            // 
            this.ToolStripMenuItem_Compile.AutoSize = false;
            this.ToolStripMenuItem_Compile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ToolStripMenuItem_Compile.ForeColor = System.Drawing.Color.Silver;
            this.ToolStripMenuItem_Compile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem_Compile.Name = "ToolStripMenuItem_Compile";
            this.ToolStripMenuItem_Compile.Size = new System.Drawing.Size(160, 30);
            this.ToolStripMenuItem_Compile.Text = "Compile";
            // 
            // ToolStripMenuItem_Unpack
            // 
            this.ToolStripMenuItem_Unpack.AutoSize = false;
            this.ToolStripMenuItem_Unpack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ToolStripMenuItem_Unpack.ForeColor = System.Drawing.Color.Silver;
            this.ToolStripMenuItem_Unpack.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem_Unpack.Name = "ToolStripMenuItem_Unpack";
            this.ToolStripMenuItem_Unpack.Size = new System.Drawing.Size(160, 30);
            this.ToolStripMenuItem_Unpack.Text = "Unpack";
            // 
            // ToolStripMenuItem_RepackAs
            // 
            this.ToolStripMenuItem_RepackAs.AutoSize = false;
            this.ToolStripMenuItem_RepackAs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ToolStripMenuItem_RepackAs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_RepackPAC,
            this.ToolStripMenuItem_RepackAFS,
            this.ToolStripMenuItem_RepackAWB});
            this.ToolStripMenuItem_RepackAs.ForeColor = System.Drawing.Color.Silver;
            this.ToolStripMenuItem_RepackAs.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem_RepackAs.Name = "ToolStripMenuItem_RepackAs";
            this.ToolStripMenuItem_RepackAs.Size = new System.Drawing.Size(160, 30);
            this.ToolStripMenuItem_RepackAs.Text = "Repack As...";
            // 
            // ToolStripMenuItem_RepackPAC
            // 
            this.ToolStripMenuItem_RepackPAC.AutoSize = false;
            this.ToolStripMenuItem_RepackPAC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ToolStripMenuItem_RepackPAC.ForeColor = System.Drawing.Color.Silver;
            this.ToolStripMenuItem_RepackPAC.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem_RepackPAC.Name = "ToolStripMenuItem_RepackPAC";
            this.ToolStripMenuItem_RepackPAC.Size = new System.Drawing.Size(160, 30);
            this.ToolStripMenuItem_RepackPAC.Text = "PAC";
            // 
            // ToolStripMenuItem_RepackAFS
            // 
            this.ToolStripMenuItem_RepackAFS.AutoSize = false;
            this.ToolStripMenuItem_RepackAFS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ToolStripMenuItem_RepackAFS.ForeColor = System.Drawing.Color.Silver;
            this.ToolStripMenuItem_RepackAFS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem_RepackAFS.Name = "ToolStripMenuItem_RepackAFS";
            this.ToolStripMenuItem_RepackAFS.Size = new System.Drawing.Size(160, 30);
            this.ToolStripMenuItem_RepackAFS.Text = "AFS";
            // 
            // ToolStripMenuItem_RepackAWB
            // 
            this.ToolStripMenuItem_RepackAWB.AutoSize = false;
            this.ToolStripMenuItem_RepackAWB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ToolStripMenuItem_RepackAWB.ForeColor = System.Drawing.Color.Silver;
            this.ToolStripMenuItem_RepackAWB.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem_RepackAWB.Name = "ToolStripMenuItem_RepackAWB";
            this.ToolStripMenuItem_RepackAWB.Size = new System.Drawing.Size(160, 30);
            this.ToolStripMenuItem_RepackAWB.Text = "AWB";
            // 
            // ToolStripMenuItem_Replace
            // 
            this.ToolStripMenuItem_Replace.AutoSize = false;
            this.ToolStripMenuItem_Replace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ToolStripMenuItem_Replace.ForeColor = System.Drawing.Color.Silver;
            this.ToolStripMenuItem_Replace.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem_Replace.Name = "ToolStripMenuItem_Replace";
            this.ToolStripMenuItem_Replace.Size = new System.Drawing.Size(160, 30);
            this.ToolStripMenuItem_Replace.Text = "Replace";
            // 
            // ToolStripMenuItem_Remove
            // 
            this.ToolStripMenuItem_Remove.AutoSize = false;
            this.ToolStripMenuItem_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ToolStripMenuItem_Remove.ForeColor = System.Drawing.Color.Silver;
            this.ToolStripMenuItem_Remove.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem_Remove.Name = "ToolStripMenuItem_Remove";
            this.ToolStripMenuItem_Remove.Size = new System.Drawing.Size(160, 30);
            this.ToolStripMenuItem_Remove.Text = "Remove";
            this.ToolStripMenuItem_Remove.Click += new System.EventHandler(this.RemoveFromProject_Click);
            // 
            // ToolStripMenuItem_OpenAt2
            // 
            this.ToolStripMenuItem_OpenAt2.AutoSize = false;
            this.ToolStripMenuItem_OpenAt2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ToolStripMenuItem_OpenAt2.ForeColor = System.Drawing.Color.Silver;
            this.ToolStripMenuItem_OpenAt2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem_OpenAt2.Name = "ToolStripMenuItem_OpenAt2";
            this.ToolStripMenuItem_OpenAt2.Size = new System.Drawing.Size(160, 30);
            this.ToolStripMenuItem_OpenAt2.Text = "Show Folder";
            this.ToolStripMenuItem_OpenAt2.Click += new System.EventHandler(this.OpenLocationProject_Click);
            // 
            // ToolStripMenuItem_Copy
            // 
            this.ToolStripMenuItem_Copy.AutoSize = false;
            this.ToolStripMenuItem_Copy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ToolStripMenuItem_Copy.ForeColor = System.Drawing.Color.Silver;
            this.ToolStripMenuItem_Copy.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem_Copy.Name = "ToolStripMenuItem_Copy";
            this.ToolStripMenuItem_Copy.Size = new System.Drawing.Size(160, 30);
            this.ToolStripMenuItem_Copy.Text = "Copy";
            this.ToolStripMenuItem_Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // ToolStripMenuItem_Rename
            // 
            this.ToolStripMenuItem_Rename.AutoSize = false;
            this.ToolStripMenuItem_Rename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ToolStripMenuItem_Rename.ForeColor = System.Drawing.Color.Silver;
            this.ToolStripMenuItem_Rename.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem_Rename.Name = "ToolStripMenuItem_Rename";
            this.ToolStripMenuItem_Rename.Size = new System.Drawing.Size(160, 30);
            this.ToolStripMenuItem_Rename.Text = "Rename";
            this.ToolStripMenuItem_Rename.Click += new System.EventHandler(this.Rename_Click);
            // 
            // ToolStripMenuItem_ExpandProj
            // 
            this.ToolStripMenuItem_ExpandProj.AutoSize = false;
            this.ToolStripMenuItem_ExpandProj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ToolStripMenuItem_ExpandProj.ForeColor = System.Drawing.Color.Silver;
            this.ToolStripMenuItem_ExpandProj.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem_ExpandProj.Name = "ToolStripMenuItem_ExpandProj";
            this.ToolStripMenuItem_ExpandProj.Size = new System.Drawing.Size(160, 30);
            this.ToolStripMenuItem_ExpandProj.Text = "Expand All";
            // 
            // ToolStripMenuItem_CollapseProj
            // 
            this.ToolStripMenuItem_CollapseProj.AutoSize = false;
            this.ToolStripMenuItem_CollapseProj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ToolStripMenuItem_CollapseProj.ForeColor = System.Drawing.Color.Silver;
            this.ToolStripMenuItem_CollapseProj.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem_CollapseProj.Name = "ToolStripMenuItem_CollapseProj";
            this.ToolStripMenuItem_CollapseProj.Size = new System.Drawing.Size(160, 30);
            this.ToolStripMenuItem_CollapseProj.Text = "Collapse All";
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
            this.Opacity = 0D;
            this.Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.ShowHeader = true;
            this.ShowLeftRect = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Style = MetroSet_UI.Enums.Style.Dark;
            this.StyleManager = this.styleManager;
            this.Text = "P-Studio v0.1";
            this.ThemeAuthor = "ShrineFox";
            this.ThemeName = "MetroDarkBlue";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.tableLayoutPanel_Container.ResumeLayout(false);
            this.tableLayoutPanel_Main.ResumeLayout(false);
            this.metroSetTabControl_GameProject.ResumeLayout(false);
            this.tabPage_Game.ResumeLayout(false);
            this.tabPage_Project.ResumeLayout(false);
            this.tableLayoutPanel_Workspace.ResumeLayout(false);
            this.metroSetTabControl_Workspace.ResumeLayout(false);
            this.tabPage_Asset.ResumeLayout(false);
            this.tabPage_Scripting.ResumeLayout(false);
            this.menuStrip_Main.ResumeLayout(false);
            this.menuStrip_Main.PerformLayout();
            this.contextMenuStrip_Game.ResumeLayout(false);
            this.contextMenuStrip_Project.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem saveProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private MetroSet_UI.Components.StyleManager styleManager;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Game;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Add;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_OpenAt;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Project;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Remove;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_OpenAt2;
        private System.Windows.Forms.RichTextBox richTextBox_Status;
        public System.Windows.Forms.Panel panel_Asset;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Rename;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Copy;
        private System.Windows.Forms.ToolStripMenuItem loadProjectToolStripMenuItem;
        public System.Windows.Forms.Panel panel_Scripting;
        private MetroSet_UI.Controls.MetroSetButton metroSetButton_ShowHide;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Decompile;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Compile;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Unpack;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_RepackAs;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_RepackPAC;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_RepackAFS;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_RepackAWB;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_ExpandGame;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_CollapseGame;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_CollapseProj;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_ExpandProj;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_New;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_NewFlow;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_NewMsg;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_NewTxt;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_NewFolder;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Replace;
        private System.Windows.Forms.ToolStripMenuItem dumpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dumpTexturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dumpSoundsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dumpScriptsToolStripMenuItem;
    }
}