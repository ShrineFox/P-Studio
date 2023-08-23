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
            tlp_Main = new TableLayoutPanel();
            tlp_Workspace = new TableLayoutPanel();
            rtb_Log = new RichTextBox();
            darkMenuStrip_Main.SuspendLayout();
            tlp_Main.SuspendLayout();
            tlp_Workspace.SuspendLayout();
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
            loadProjectToolStripMenuItem.Size = new Size(224, 26);
            loadProjectToolStripMenuItem.Text = "Load Project";
            loadProjectToolStripMenuItem.Click += LoadProject_Click;
            // 
            // saveProjectToolStripMenuItem
            // 
            saveProjectToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            saveProjectToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            saveProjectToolStripMenuItem.Name = "saveProjectToolStripMenuItem";
            saveProjectToolStripMenuItem.Size = new Size(224, 26);
            saveProjectToolStripMenuItem.Text = "Save Project";
            saveProjectToolStripMenuItem.Click += SaveProject_Click;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            settingsToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(224, 26);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.Click += Settings_Click;
            // 
            // tlp_Main
            // 
            tlp_Main.BackColor = Color.FromArgb(30, 30, 30);
            tlp_Main.ColumnCount = 2;
            tlp_Main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlp_Main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tlp_Main.Controls.Add(tlp_Workspace, 1, 0);
            tlp_Main.Dock = DockStyle.Fill;
            tlp_Main.Location = new Point(0, 28);
            tlp_Main.Name = "tlp_Main";
            tlp_Main.RowCount = 1;
            tlp_Main.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp_Main.Size = new Size(882, 625);
            tlp_Main.TabIndex = 1;
            // 
            // tlp_Workspace
            // 
            tlp_Workspace.BackColor = Color.FromArgb(30, 30, 30);
            tlp_Workspace.ColumnCount = 1;
            tlp_Workspace.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp_Workspace.Controls.Add(rtb_Log, 0, 1);
            tlp_Workspace.Dock = DockStyle.Fill;
            tlp_Workspace.Location = new Point(223, 3);
            tlp_Workspace.Name = "tlp_Workspace";
            tlp_Workspace.RowCount = 2;
            tlp_Workspace.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tlp_Workspace.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlp_Workspace.Size = new Size(656, 619);
            tlp_Workspace.TabIndex = 0;
            // 
            // rtb_Log
            // 
            rtb_Log.BackColor = Color.FromArgb(25, 25, 25);
            rtb_Log.BorderStyle = BorderStyle.None;
            rtb_Log.Dock = DockStyle.Fill;
            rtb_Log.ForeColor = Color.Silver;
            rtb_Log.Location = new Point(3, 467);
            rtb_Log.Name = "rtb_Log";
            rtb_Log.ReadOnly = true;
            rtb_Log.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtb_Log.Size = new Size(650, 149);
            rtb_Log.TabIndex = 0;
            rtb_Log.Text = "";
            // 
            // PStudioForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(882, 653);
            Controls.Add(tlp_Main);
            Controls.Add(darkMenuStrip_Main);
            ForeColor = Color.Silver;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = darkMenuStrip_Main;
            MinimumSize = new Size(900, 700);
            Name = "PStudioForm";
            Text = "P-Studio";
            darkMenuStrip_Main.ResumeLayout(false);
            darkMenuStrip_Main.PerformLayout();
            tlp_Main.ResumeLayout(false);
            tlp_Workspace.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DarkUI.Controls.DarkMenuStrip darkMenuStrip_Main;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem loadProjectToolStripMenuItem;
        private ToolStripMenuItem saveProjectToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private TableLayoutPanel tlp_Main;
        private TableLayoutPanel tlp_Workspace;
        private RichTextBox rtb_Log;
    }
}