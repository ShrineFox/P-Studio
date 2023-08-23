using DarkUI.Forms;

namespace PStudio
{
    partial class PStudioForm : DarkForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PStudioForm));
            darkMenuStrip_Main = new DarkUI.Controls.DarkMenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            loadProjectToolStripMenuItem = new ToolStripMenuItem();
            saveProjectToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            rtb_Log = new RichTextBox();
            splitContainer_Main = new SplitContainer();
            splitContainer_Workspace = new SplitContainer();
            darkMenuStrip_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer_Main).BeginInit();
            splitContainer_Main.Panel2.SuspendLayout();
            splitContainer_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer_Workspace).BeginInit();
            splitContainer_Workspace.Panel2.SuspendLayout();
            splitContainer_Workspace.SuspendLayout();
            SuspendLayout();
            // 
            // darkMenuStrip_Main
            // 
            darkMenuStrip_Main.BackColor = Color.FromArgb(30, 30, 30);
            darkMenuStrip_Main.ForeColor = Color.FromArgb(220, 220, 220);
            darkMenuStrip_Main.ImageScalingSize = new Size(20, 20);
            darkMenuStrip_Main.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            darkMenuStrip_Main.Location = new Point(0, 0);
            darkMenuStrip_Main.Name = "darkMenuStrip_Main";
            darkMenuStrip_Main.Padding = new Padding(3, 2, 0, 2);
            darkMenuStrip_Main.Size = new Size(882, 28);
            darkMenuStrip_Main.TabIndex = 0;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadProjectToolStripMenuItem, saveProjectToolStripMenuItem, settingsToolStripMenuItem });
            fileToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // loadProjectToolStripMenuItem
            // 
            loadProjectToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            loadProjectToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            loadProjectToolStripMenuItem.Name = "loadProjectToolStripMenuItem";
            loadProjectToolStripMenuItem.Size = new Size(175, 26);
            loadProjectToolStripMenuItem.Text = "Load Project";
            loadProjectToolStripMenuItem.Click += LoadProject_Click;
            // 
            // saveProjectToolStripMenuItem
            // 
            saveProjectToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            saveProjectToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            saveProjectToolStripMenuItem.Name = "saveProjectToolStripMenuItem";
            saveProjectToolStripMenuItem.Size = new Size(175, 26);
            saveProjectToolStripMenuItem.Text = "Save Project";
            saveProjectToolStripMenuItem.Click += SaveProject_Click;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            settingsToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(175, 26);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.Click += Settings_Click;
            // 
            // rtb_Log
            // 
            rtb_Log.BackColor = Color.FromArgb(25, 25, 25);
            rtb_Log.BorderStyle = BorderStyle.None;
            rtb_Log.Dock = DockStyle.Fill;
            rtb_Log.ForeColor = Color.Silver;
            rtb_Log.Location = new Point(0, 0);
            rtb_Log.Name = "rtb_Log";
            rtb_Log.ReadOnly = true;
            rtb_Log.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtb_Log.Size = new Size(584, 120);
            rtb_Log.TabIndex = 0;
            rtb_Log.Text = "";
            // 
            // splitContainer_Main
            // 
            splitContainer_Main.Dock = DockStyle.Fill;
            splitContainer_Main.Location = new Point(0, 28);
            splitContainer_Main.Name = "splitContainer_Main";
            // 
            // splitContainer_Main.Panel2
            // 
            splitContainer_Main.Panel2.Controls.Add(splitContainer_Workspace);
            splitContainer_Main.Size = new Size(882, 625);
            splitContainer_Main.SplitterDistance = 294;
            splitContainer_Main.TabIndex = 2;
            // 
            // splitContainer_Workspace
            // 
            splitContainer_Workspace.Dock = DockStyle.Fill;
            splitContainer_Workspace.Location = new Point(0, 0);
            splitContainer_Workspace.Name = "splitContainer_Workspace";
            splitContainer_Workspace.Orientation = Orientation.Horizontal;
            // 
            // splitContainer_Workspace.Panel2
            // 
            splitContainer_Workspace.Panel2.Controls.Add(rtb_Log);
            splitContainer_Workspace.Size = new Size(584, 625);
            splitContainer_Workspace.SplitterDistance = 501;
            splitContainer_Workspace.TabIndex = 0;
            // 
            // PStudioForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(882, 653);
            Controls.Add(splitContainer_Main);
            Controls.Add(darkMenuStrip_Main);
            ForeColor = Color.Silver;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = darkMenuStrip_Main;
            MinimumSize = new Size(900, 700);
            Name = "PStudioForm";
            Text = "P-Studio";
            darkMenuStrip_Main.ResumeLayout(false);
            darkMenuStrip_Main.PerformLayout();
            splitContainer_Main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer_Main).EndInit();
            splitContainer_Main.ResumeLayout(false);
            splitContainer_Workspace.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer_Workspace).EndInit();
            splitContainer_Workspace.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DarkUI.Controls.DarkMenuStrip darkMenuStrip_Main;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem loadProjectToolStripMenuItem;
        private ToolStripMenuItem saveProjectToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private RichTextBox rtb_Log;
        private SplitContainer splitContainer_Main;
        private SplitContainer splitContainer_Workspace;
    }
}