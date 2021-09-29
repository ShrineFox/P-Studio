
namespace P_Studio
{
    partial class Form_PStudio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_PStudio));
            this.toolTip_PStudio = new System.Windows.Forms.ToolTip(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildLaunchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowscriptReferenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkMenuStrip1 = new DarkUI.Controls.DarkMenuStrip();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.tableLayoutPanel_Workspace = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl_GameProject = new System.Windows.Forms.TabControl();
            this.tabPage_Game = new System.Windows.Forms.TabPage();
            this.darkTreeView_Game = new DarkUI.Controls.DarkTreeView();
            this.tabPage_Project = new System.Windows.Forms.TabPage();
            this.darkTreeView_Project = new DarkUI.Controls.DarkTreeView();
            this.tabControl_Editor = new System.Windows.Forms.TabControl();
            this.tabPage_Edit = new System.Windows.Forms.TabPage();
            this.tabPage_Compiler = new System.Windows.Forms.TabPage();
            this.darkTextBox_Status = new DarkUI.Controls.DarkTextBox();
            this.darkTextBox_Tips = new DarkUI.Controls.DarkTextBox();
            this.darkMenuStrip1.SuspendLayout();
            this.panel_Main.SuspendLayout();
            this.tableLayoutPanel_Workspace.SuspendLayout();
            this.tabControl_GameProject.SuspendLayout();
            this.tabPage_Game.SuspendLayout();
            this.tabPage_Project.SuspendLayout();
            this.tabControl_Editor.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip_PStudio
            // 
            this.toolTip_PStudio.BackColor = System.Drawing.SystemColors.ControlText;
            this.toolTip_PStudio.ForeColor = System.Drawing.SystemColors.GrayText;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectToolStripMenuItem,
            this.loadProjectToolStripMenuItem,
            this.projectSettingsToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.newProjectToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.newProjectToolStripMenuItem.Text = "New Project";
            this.newProjectToolStripMenuItem.Click += new System.EventHandler(this.NewProject_Click);
            // 
            // loadProjectToolStripMenuItem
            // 
            this.loadProjectToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.loadProjectToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.loadProjectToolStripMenuItem.Name = "loadProjectToolStripMenuItem";
            this.loadProjectToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.loadProjectToolStripMenuItem.Text = "Load Project";
            this.loadProjectToolStripMenuItem.Click += new System.EventHandler(this.LoadProject_Click);
            // 
            // projectSettingsToolStripMenuItem
            // 
            this.projectSettingsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.projectSettingsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.projectSettingsToolStripMenuItem.Name = "projectSettingsToolStripMenuItem";
            this.projectSettingsToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.projectSettingsToolStripMenuItem.Text = "Settings";
            this.projectSettingsToolStripMenuItem.Click += new System.EventHandler(this.Settings_Click);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.runToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buildLaunchToolStripMenuItem});
            this.runToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.runToolStripMenuItem.Text = "Run";
            // 
            // buildLaunchToolStripMenuItem
            // 
            this.buildLaunchToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.buildLaunchToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.buildLaunchToolStripMenuItem.Name = "buildLaunchToolStripMenuItem";
            this.buildLaunchToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.buildLaunchToolStripMenuItem.Text = "Build and Launch";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.flowscriptReferenceToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // flowscriptReferenceToolStripMenuItem
            // 
            this.flowscriptReferenceToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.flowscriptReferenceToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.flowscriptReferenceToolStripMenuItem.Name = "flowscriptReferenceToolStripMenuItem";
            this.flowscriptReferenceToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.flowscriptReferenceToolStripMenuItem.Text = "Flowscript Reference";
            // 
            // darkMenuStrip1
            // 
            this.darkMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.darkMenuStrip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.darkMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.runToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.darkMenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.darkMenuStrip1.Name = "darkMenuStrip1";
            this.darkMenuStrip1.Padding = new System.Windows.Forms.Padding(3, 2, 0, 2);
            this.darkMenuStrip1.Size = new System.Drawing.Size(942, 28);
            this.darkMenuStrip1.TabIndex = 1;
            this.darkMenuStrip1.Text = "darkMenuStrip";
            // 
            // panel_Main
            // 
            this.panel_Main.Controls.Add(this.tableLayoutPanel_Workspace);
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(0, 28);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Padding = new System.Windows.Forms.Padding(10);
            this.panel_Main.Size = new System.Drawing.Size(942, 465);
            this.panel_Main.TabIndex = 2;
            // 
            // tableLayoutPanel_Workspace
            // 
            this.tableLayoutPanel_Workspace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_Workspace.ColumnCount = 2;
            this.tableLayoutPanel_Workspace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel_Workspace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel_Workspace.Controls.Add(this.darkTextBox_Tips, 0, 1);
            this.tableLayoutPanel_Workspace.Controls.Add(this.tabControl_GameProject, 0, 0);
            this.tableLayoutPanel_Workspace.Controls.Add(this.tabControl_Editor, 1, 0);
            this.tableLayoutPanel_Workspace.Controls.Add(this.darkTextBox_Status, 1, 1);
            this.tableLayoutPanel_Workspace.Location = new System.Drawing.Point(13, 14);
            this.tableLayoutPanel_Workspace.Name = "tableLayoutPanel_Workspace";
            this.tableLayoutPanel_Workspace.RowCount = 2;
            this.tableLayoutPanel_Workspace.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Workspace.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_Workspace.Size = new System.Drawing.Size(917, 438);
            this.tableLayoutPanel_Workspace.TabIndex = 3;
            // 
            // tabControl_GameProject
            // 
            this.tabControl_GameProject.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl_GameProject.Controls.Add(this.tabPage_Game);
            this.tabControl_GameProject.Controls.Add(this.tabPage_Project);
            this.tabControl_GameProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_GameProject.Location = new System.Drawing.Point(0, 0);
            this.tabControl_GameProject.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl_GameProject.Name = "tabControl_GameProject";
            this.tabControl_GameProject.Padding = new System.Drawing.Point(5, 5);
            this.tabControl_GameProject.SelectedIndex = 0;
            this.tabControl_GameProject.Size = new System.Drawing.Size(320, 382);
            this.tabControl_GameProject.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl_GameProject.TabIndex = 1;
            this.tabControl_GameProject.SelectedIndexChanged += new System.EventHandler(this.tabControl_GameProject_IndexChanged);
            // 
            // tabPage_Game
            // 
            this.tabPage_Game.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.tabPage_Game.Controls.Add(this.darkTreeView_Game);
            this.tabPage_Game.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tabPage_Game.Location = new System.Drawing.Point(4, 4);
            this.tabPage_Game.Name = "tabPage_Game";
            this.tabPage_Game.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Game.Size = new System.Drawing.Size(312, 349);
            this.tabPage_Game.TabIndex = 0;
            this.tabPage_Game.Text = "Game";
            // 
            // darkTreeView_Game
            // 
            this.darkTreeView_Game.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.darkTreeView_Game.Dock = System.Windows.Forms.DockStyle.Fill;
            this.darkTreeView_Game.Location = new System.Drawing.Point(3, 3);
            this.darkTreeView_Game.MaxDragChange = 20;
            this.darkTreeView_Game.Name = "darkTreeView_Game";
            this.darkTreeView_Game.ShowIcons = true;
            this.darkTreeView_Game.Size = new System.Drawing.Size(306, 343);
            this.darkTreeView_Game.TabIndex = 0;
            // 
            // tabPage_Project
            // 
            this.tabPage_Project.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.tabPage_Project.Controls.Add(this.darkTreeView_Project);
            this.tabPage_Project.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tabPage_Project.Location = new System.Drawing.Point(4, 4);
            this.tabPage_Project.Name = "tabPage_Project";
            this.tabPage_Project.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Project.Size = new System.Drawing.Size(312, 349);
            this.tabPage_Project.TabIndex = 1;
            this.tabPage_Project.Text = "Project";
            // 
            // darkTreeView_Project
            // 
            this.darkTreeView_Project.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.darkTreeView_Project.Dock = System.Windows.Forms.DockStyle.Fill;
            this.darkTreeView_Project.Location = new System.Drawing.Point(3, 3);
            this.darkTreeView_Project.MaxDragChange = 20;
            this.darkTreeView_Project.Name = "darkTreeView_Project";
            this.darkTreeView_Project.Padding = new System.Windows.Forms.Padding(3);
            this.darkTreeView_Project.ShowIcons = true;
            this.darkTreeView_Project.Size = new System.Drawing.Size(306, 343);
            this.darkTreeView_Project.TabIndex = 1;
            // 
            // tabControl_Editor
            // 
            this.tabControl_Editor.Controls.Add(this.tabPage_Edit);
            this.tabControl_Editor.Controls.Add(this.tabPage_Compiler);
            this.tabControl_Editor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Editor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tabControl_Editor.Location = new System.Drawing.Point(323, 3);
            this.tabControl_Editor.Name = "tabControl_Editor";
            this.tabControl_Editor.SelectedIndex = 0;
            this.tabControl_Editor.Size = new System.Drawing.Size(591, 376);
            this.tabControl_Editor.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl_Editor.TabIndex = 7;
            // 
            // tabPage_Edit
            // 
            this.tabPage_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.tabPage_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tabPage_Edit.Location = new System.Drawing.Point(4, 27);
            this.tabPage_Edit.Name = "tabPage_Edit";
            this.tabPage_Edit.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Edit.Size = new System.Drawing.Size(583, 345);
            this.tabPage_Edit.TabIndex = 0;
            this.tabPage_Edit.Text = "Edit Asset";
            // 
            // tabPage_Compiler
            // 
            this.tabPage_Compiler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.tabPage_Compiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tabPage_Compiler.Location = new System.Drawing.Point(4, 27);
            this.tabPage_Compiler.Name = "tabPage_Compiler";
            this.tabPage_Compiler.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Compiler.Size = new System.Drawing.Size(583, 345);
            this.tabPage_Compiler.TabIndex = 1;
            this.tabPage_Compiler.Text = "Scripting";
            // 
            // darkTextBox_Status
            // 
            this.darkTextBox_Status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.darkTextBox_Status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.darkTextBox_Status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.darkTextBox_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.darkTextBox_Status.ForeColor = System.Drawing.Color.DarkGray;
            this.darkTextBox_Status.Location = new System.Drawing.Point(323, 385);
            this.darkTextBox_Status.Multiline = true;
            this.darkTextBox_Status.Name = "darkTextBox_Status";
            this.darkTextBox_Status.ReadOnly = true;
            this.darkTextBox_Status.Size = new System.Drawing.Size(591, 50);
            this.darkTextBox_Status.TabIndex = 6;
            // 
            // darkTextBox_Tips
            // 
            this.darkTextBox_Tips.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.darkTextBox_Tips.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.darkTextBox_Tips.Dock = System.Windows.Forms.DockStyle.Fill;
            this.darkTextBox_Tips.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.darkTextBox_Tips.ForeColor = System.Drawing.Color.DarkGray;
            this.darkTextBox_Tips.Location = new System.Drawing.Point(3, 385);
            this.darkTextBox_Tips.Multiline = true;
            this.darkTextBox_Tips.Name = "darkTextBox_Tips";
            this.darkTextBox_Tips.ReadOnly = true;
            this.darkTextBox_Tips.Size = new System.Drawing.Size(314, 50);
            this.darkTextBox_Tips.TabIndex = 8;
            // 
            // Form_PStudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 493);
            this.Controls.Add(this.panel_Main);
            this.Controls.Add(this.darkMenuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.darkMenuStrip1;
            this.MinimumSize = new System.Drawing.Size(640, 360);
            this.Name = "Form_PStudio";
            this.Text = "P-Studio v0.1";
            this.darkMenuStrip1.ResumeLayout(false);
            this.darkMenuStrip1.PerformLayout();
            this.panel_Main.ResumeLayout(false);
            this.tableLayoutPanel_Workspace.ResumeLayout(false);
            this.tableLayoutPanel_Workspace.PerformLayout();
            this.tabControl_GameProject.ResumeLayout(false);
            this.tabPage_Game.ResumeLayout(false);
            this.tabPage_Project.ResumeLayout(false);
            this.tabControl_Editor.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip_PStudio;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildLaunchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flowscriptReferenceToolStripMenuItem;
        private DarkUI.Controls.DarkMenuStrip darkMenuStrip1;
        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Workspace;
        private System.Windows.Forms.TabControl tabControl_GameProject;
        private System.Windows.Forms.TabPage tabPage_Game;
        private DarkUI.Controls.DarkTreeView darkTreeView_Game;
        private System.Windows.Forms.TabPage tabPage_Project;
        private DarkUI.Controls.DarkTreeView darkTreeView_Project;
        private System.Windows.Forms.TabControl tabControl_Editor;
        private System.Windows.Forms.TabPage tabPage_Edit;
        private System.Windows.Forms.TabPage tabPage_Compiler;
        public DarkUI.Controls.DarkTextBox darkTextBox_Tips;
        public DarkUI.Controls.DarkTextBox darkTextBox_Status;
    }
}

