
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
            this.darkMenuStrip1 = new DarkUI.Controls.DarkMenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildLaunchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowscriptReferenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkTreeView_FileExplorer = new DarkUI.Controls.DarkTreeView();
            this.tabPage_EditAsset = new System.Windows.Forms.TabPage();
            this.tabControl_Main = new System.Windows.Forms.TabControl();
            this.tabPage_ScriptCompiler = new System.Windows.Forms.TabPage();
            this.darkRadioButton_Game = new DarkUI.Controls.DarkRadioButton();
            this.darkRadioButton_Project = new DarkUI.Controls.DarkRadioButton();
            this.toolTip_PStudio = new System.Windows.Forms.ToolTip(this.components);
            this.darkLabel_Status = new DarkUI.Controls.DarkLabel();
            this.darkMenuStrip1.SuspendLayout();
            this.tabControl_Main.SuspendLayout();
            this.SuspendLayout();
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
            this.darkMenuStrip1.Size = new System.Drawing.Size(800, 30);
            this.darkMenuStrip1.TabIndex = 1;
            this.darkMenuStrip1.Text = "darkMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectToolStripMenuItem,
            this.saveProjectToolStripMenuItem,
            this.loadProjectToolStripMenuItem,
            this.projectSettingsToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.newProjectToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.newProjectToolStripMenuItem.Text = "New Project";
            this.newProjectToolStripMenuItem.Click += new System.EventHandler(this.NewProject_Click);
            // 
            // saveProjectToolStripMenuItem
            // 
            this.saveProjectToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.saveProjectToolStripMenuItem.Enabled = false;
            this.saveProjectToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.saveProjectToolStripMenuItem.Name = "saveProjectToolStripMenuItem";
            this.saveProjectToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.saveProjectToolStripMenuItem.Text = "Save Project";
            // 
            // loadProjectToolStripMenuItem
            // 
            this.loadProjectToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.loadProjectToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.loadProjectToolStripMenuItem.Name = "loadProjectToolStripMenuItem";
            this.loadProjectToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.loadProjectToolStripMenuItem.Text = "Load Project";
            this.loadProjectToolStripMenuItem.Click += new System.EventHandler(this.LoadProject_Click);
            // 
            // projectSettingsToolStripMenuItem
            // 
            this.projectSettingsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.projectSettingsToolStripMenuItem.Enabled = false;
            this.projectSettingsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.projectSettingsToolStripMenuItem.Name = "projectSettingsToolStripMenuItem";
            this.projectSettingsToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.projectSettingsToolStripMenuItem.Text = "Project Settings";
            this.projectSettingsToolStripMenuItem.Click += new System.EventHandler(this.Settings_Click);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.runToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buildLaunchToolStripMenuItem});
            this.runToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(48, 26);
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
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
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
            // darkTreeView_FileExplorer
            // 
            this.darkTreeView_FileExplorer.Location = new System.Drawing.Point(0, 31);
            this.darkTreeView_FileExplorer.MaxDragChange = 20;
            this.darkTreeView_FileExplorer.Name = "darkTreeView_FileExplorer";
            this.darkTreeView_FileExplorer.Size = new System.Drawing.Size(249, 386);
            this.darkTreeView_FileExplorer.TabIndex = 2;
            this.darkTreeView_FileExplorer.Text = "File Explorer";
            // 
            // tabPage_EditAsset
            // 
            this.tabPage_EditAsset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.tabPage_EditAsset.Location = new System.Drawing.Point(4, 29);
            this.tabPage_EditAsset.Name = "tabPage_EditAsset";
            this.tabPage_EditAsset.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_EditAsset.Size = new System.Drawing.Size(541, 385);
            this.tabPage_EditAsset.TabIndex = 1;
            this.tabPage_EditAsset.Text = "Editor";
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Controls.Add(this.tabPage_EditAsset);
            this.tabControl_Main.Controls.Add(this.tabPage_ScriptCompiler);
            this.tabControl_Main.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabControl_Main.Location = new System.Drawing.Point(251, 0);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.Size = new System.Drawing.Size(549, 418);
            this.tabControl_Main.TabIndex = 5;
            // 
            // tabPage_ScriptCompiler
            // 
            this.tabPage_ScriptCompiler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.tabPage_ScriptCompiler.Location = new System.Drawing.Point(4, 29);
            this.tabPage_ScriptCompiler.Name = "tabPage_ScriptCompiler";
            this.tabPage_ScriptCompiler.Size = new System.Drawing.Size(541, 385);
            this.tabPage_ScriptCompiler.TabIndex = 2;
            this.tabPage_ScriptCompiler.Text = "Compiler";
            // 
            // darkRadioButton_Game
            // 
            this.darkRadioButton_Game.AutoSize = true;
            this.darkRadioButton_Game.Location = new System.Drawing.Point(99, 424);
            this.darkRadioButton_Game.Name = "darkRadioButton_Game";
            this.darkRadioButton_Game.Size = new System.Drawing.Size(67, 21);
            this.darkRadioButton_Game.TabIndex = 3;
            this.darkRadioButton_Game.Text = "Game";
            this.toolTip_PStudio.SetToolTip(this.darkRadioButton_Game, "Browse extracted game files to add to your project.");
            this.darkRadioButton_Game.Click += new System.EventHandler(this.Treeview_Change);
            // 
            // darkRadioButton_Project
            // 
            this.darkRadioButton_Project.AutoSize = true;
            this.darkRadioButton_Project.Checked = true;
            this.darkRadioButton_Project.Location = new System.Drawing.Point(172, 424);
            this.darkRadioButton_Project.Name = "darkRadioButton_Project";
            this.darkRadioButton_Project.Size = new System.Drawing.Size(73, 21);
            this.darkRadioButton_Project.TabIndex = 4;
            this.darkRadioButton_Project.TabStop = true;
            this.darkRadioButton_Project.Text = "Project";
            this.toolTip_PStudio.SetToolTip(this.darkRadioButton_Project, "Browse editable files added to your project.");
            // 
            // toolTip_PStudio
            // 
            this.toolTip_PStudio.BackColor = System.Drawing.SystemColors.ControlText;
            this.toolTip_PStudio.ForeColor = System.Drawing.SystemColors.GrayText;
            // 
            // darkLabel_Status
            // 
            this.darkLabel_Status.AutoSize = true;
            this.darkLabel_Status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel_Status.Location = new System.Drawing.Point(248, 424);
            this.darkLabel_Status.Name = "darkLabel_Status";
            this.darkLabel_Status.Size = new System.Drawing.Size(0, 17);
            this.darkLabel_Status.TabIndex = 6;
            // 
            // Form_PStudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.darkLabel_Status);
            this.Controls.Add(this.darkRadioButton_Project);
            this.Controls.Add(this.darkRadioButton_Game);
            this.Controls.Add(this.darkTreeView_FileExplorer);
            this.Controls.Add(this.tabControl_Main);
            this.Controls.Add(this.darkMenuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.darkMenuStrip1;
            this.Name = "Form_PStudio";
            this.Text = "P-Studio v0.1";
            this.darkMenuStrip1.ResumeLayout(false);
            this.darkMenuStrip1.PerformLayout();
            this.tabControl_Main.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DarkUI.Controls.DarkMenuStrip darkMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildLaunchToolStripMenuItem;
        private DarkUI.Controls.DarkTreeView darkTreeView_FileExplorer;
        private System.Windows.Forms.TabPage tabPage_EditAsset;
        private System.Windows.Forms.TabControl tabControl_Main;
        private System.Windows.Forms.TabPage tabPage_ScriptCompiler;
        private System.Windows.Forms.ToolStripMenuItem projectSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flowscriptReferenceToolStripMenuItem;
        private DarkUI.Controls.DarkRadioButton darkRadioButton_Game;
        private DarkUI.Controls.DarkRadioButton darkRadioButton_Project;
        private System.Windows.Forms.ToolTip toolTip_PStudio;
        private System.Windows.Forms.ToolStripMenuItem loadProjectToolStripMenuItem;
        private DarkUI.Controls.DarkLabel darkLabel_Status;
    }
}

