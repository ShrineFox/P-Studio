using DarkUI.Forms;

namespace PStudio
{
    partial class SettingsForm : DarkForm
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
            tlp_Main = new TableLayoutPanel();
            panel_Settings = new Panel();
            tlp_Settings = new TableLayoutPanel();
            lbl_ProjectName = new DarkUI.Controls.DarkLabel();
            txt_ProjectName = new DarkUI.Controls.DarkTextBox();
            lbl_Game = new DarkUI.Controls.DarkLabel();
            lbl_GameDir = new DarkUI.Controls.DarkLabel();
            lbl_ModDir = new DarkUI.Controls.DarkLabel();
            txt_GameDir = new DarkUI.Controls.DarkTextBox();
            txt_ModDir = new DarkUI.Controls.DarkTextBox();
            btn_GameDir = new DarkUI.Controls.DarkButton();
            btn_ModDir = new DarkUI.Controls.DarkButton();
            comboBox_Game = new ComboBox();
            tlp_Buttons = new TableLayoutPanel();
            btn_Cancel = new DarkUI.Controls.DarkButton();
            btn_Save = new DarkUI.Controls.DarkButton();
            tlp_Main.SuspendLayout();
            panel_Settings.SuspendLayout();
            tlp_Settings.SuspendLayout();
            tlp_Buttons.SuspendLayout();
            SuspendLayout();
            // 
            // tlp_Main
            // 
            tlp_Main.ColumnCount = 1;
            tlp_Main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp_Main.Controls.Add(panel_Settings, 0, 0);
            tlp_Main.Controls.Add(tlp_Buttons, 0, 1);
            tlp_Main.Dock = DockStyle.Fill;
            tlp_Main.Location = new Point(0, 0);
            tlp_Main.Name = "tlp_Main";
            tlp_Main.RowCount = 2;
            tlp_Main.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tlp_Main.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlp_Main.Size = new Size(582, 328);
            tlp_Main.TabIndex = 0;
            // 
            // panel_Settings
            // 
            panel_Settings.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_Settings.AutoScroll = true;
            panel_Settings.Controls.Add(tlp_Settings);
            panel_Settings.Location = new Point(3, 3);
            panel_Settings.Name = "panel_Settings";
            panel_Settings.Size = new Size(576, 256);
            panel_Settings.TabIndex = 0;
            // 
            // tlp_Settings
            // 
            tlp_Settings.ColumnCount = 4;
            tlp_Settings.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlp_Settings.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tlp_Settings.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlp_Settings.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlp_Settings.Controls.Add(lbl_ProjectName, 0, 0);
            tlp_Settings.Controls.Add(txt_ProjectName, 1, 0);
            tlp_Settings.Controls.Add(lbl_Game, 0, 1);
            tlp_Settings.Controls.Add(lbl_GameDir, 0, 2);
            tlp_Settings.Controls.Add(lbl_ModDir, 0, 3);
            tlp_Settings.Controls.Add(txt_GameDir, 1, 2);
            tlp_Settings.Controls.Add(txt_ModDir, 1, 3);
            tlp_Settings.Controls.Add(btn_GameDir, 2, 2);
            tlp_Settings.Controls.Add(btn_ModDir, 2, 3);
            tlp_Settings.Controls.Add(comboBox_Game, 1, 1);
            tlp_Settings.Dock = DockStyle.Top;
            tlp_Settings.Location = new Point(0, 0);
            tlp_Settings.Name = "tlp_Settings";
            tlp_Settings.RowCount = 5;
            tlp_Settings.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlp_Settings.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlp_Settings.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlp_Settings.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlp_Settings.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlp_Settings.Size = new Size(576, 254);
            tlp_Settings.TabIndex = 0;
            // 
            // lbl_ProjectName
            // 
            lbl_ProjectName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lbl_ProjectName.AutoSize = true;
            lbl_ProjectName.ForeColor = Color.FromArgb(220, 220, 220);
            lbl_ProjectName.Location = new Point(39, 0);
            lbl_ProjectName.Name = "lbl_ProjectName";
            lbl_ProjectName.Size = new Size(102, 40);
            lbl_ProjectName.TabIndex = 0;
            lbl_ProjectName.Text = "Project Name:";
            lbl_ProjectName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_ProjectName
            // 
            txt_ProjectName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_ProjectName.BackColor = Color.FromArgb(69, 73, 74);
            txt_ProjectName.BorderStyle = BorderStyle.FixedSingle;
            txt_ProjectName.ForeColor = Color.FromArgb(220, 220, 220);
            txt_ProjectName.Location = new Point(147, 6);
            txt_ProjectName.Name = "txt_ProjectName";
            txt_ProjectName.Size = new Size(310, 27);
            txt_ProjectName.TabIndex = 1;
            // 
            // lbl_Game
            // 
            lbl_Game.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lbl_Game.AutoSize = true;
            lbl_Game.ForeColor = Color.FromArgb(220, 220, 220);
            lbl_Game.Location = new Point(90, 40);
            lbl_Game.Name = "lbl_Game";
            lbl_Game.Size = new Size(51, 40);
            lbl_Game.TabIndex = 2;
            lbl_Game.Text = "Game:";
            lbl_Game.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_GameDir
            // 
            lbl_GameDir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lbl_GameDir.AutoSize = true;
            lbl_GameDir.ForeColor = Color.FromArgb(220, 220, 220);
            lbl_GameDir.Location = new Point(11, 80);
            lbl_GameDir.Name = "lbl_GameDir";
            lbl_GameDir.Size = new Size(130, 40);
            lbl_GameDir.TabIndex = 3;
            lbl_GameDir.Text = "Game Files Folder:";
            lbl_GameDir.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_ModDir
            // 
            lbl_ModDir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lbl_ModDir.AutoSize = true;
            lbl_ModDir.ForeColor = Color.FromArgb(220, 220, 220);
            lbl_ModDir.Location = new Point(52, 120);
            lbl_ModDir.Name = "lbl_ModDir";
            lbl_ModDir.Size = new Size(89, 40);
            lbl_ModDir.TabIndex = 4;
            lbl_ModDir.Text = "Mod Folder:";
            lbl_ModDir.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_GameDir
            // 
            txt_GameDir.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_GameDir.BackColor = Color.FromArgb(69, 73, 74);
            txt_GameDir.BorderStyle = BorderStyle.FixedSingle;
            txt_GameDir.ForeColor = Color.FromArgb(220, 220, 220);
            txt_GameDir.Location = new Point(147, 86);
            txt_GameDir.Name = "txt_GameDir";
            txt_GameDir.Size = new Size(310, 27);
            txt_GameDir.TabIndex = 5;
            // 
            // txt_ModDir
            // 
            txt_ModDir.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_ModDir.BackColor = Color.FromArgb(69, 73, 74);
            txt_ModDir.BorderStyle = BorderStyle.FixedSingle;
            txt_ModDir.ForeColor = Color.FromArgb(220, 220, 220);
            txt_ModDir.Location = new Point(147, 126);
            txt_ModDir.Name = "txt_ModDir";
            txt_ModDir.Size = new Size(310, 27);
            txt_ModDir.TabIndex = 6;
            // 
            // btn_GameDir
            // 
            btn_GameDir.Anchor = AnchorStyles.Left;
            btn_GameDir.Location = new Point(463, 87);
            btn_GameDir.Name = "btn_GameDir";
            btn_GameDir.Padding = new Padding(5);
            btn_GameDir.Size = new Size(44, 26);
            btn_GameDir.TabIndex = 7;
            btn_GameDir.Text = ". . .";
            btn_GameDir.Click += GameDir_Click;
            // 
            // btn_ModDir
            // 
            btn_ModDir.Anchor = AnchorStyles.Left;
            btn_ModDir.Location = new Point(463, 127);
            btn_ModDir.Name = "btn_ModDir";
            btn_ModDir.Padding = new Padding(5);
            btn_ModDir.Size = new Size(44, 26);
            btn_ModDir.TabIndex = 8;
            btn_ModDir.Text = ". . .";
            btn_ModDir.Click += ModDir_Click;
            // 
            // comboBox_Game
            // 
            comboBox_Game.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBox_Game.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Game.FormattingEnabled = true;
            comboBox_Game.Location = new Point(147, 46);
            comboBox_Game.Name = "comboBox_Game";
            comboBox_Game.Size = new Size(310, 28);
            comboBox_Game.TabIndex = 9;
            // 
            // tlp_Buttons
            // 
            tlp_Buttons.ColumnCount = 3;
            tlp_Buttons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tlp_Buttons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlp_Buttons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlp_Buttons.Controls.Add(btn_Cancel, 1, 0);
            tlp_Buttons.Controls.Add(btn_Save, 2, 0);
            tlp_Buttons.Dock = DockStyle.Fill;
            tlp_Buttons.Location = new Point(3, 265);
            tlp_Buttons.Name = "tlp_Buttons";
            tlp_Buttons.RowCount = 1;
            tlp_Buttons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp_Buttons.Size = new Size(576, 60);
            tlp_Buttons.TabIndex = 1;
            // 
            // btn_Cancel
            // 
            btn_Cancel.DialogResult = DialogResult.Cancel;
            btn_Cancel.Dock = DockStyle.Fill;
            btn_Cancel.Location = new Point(348, 3);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Padding = new Padding(5);
            btn_Cancel.Size = new Size(109, 54);
            btn_Cancel.TabIndex = 0;
            btn_Cancel.Text = "Cancel";
            // 
            // btn_Save
            // 
            btn_Save.DialogResult = DialogResult.OK;
            btn_Save.Dock = DockStyle.Fill;
            btn_Save.Location = new Point(463, 3);
            btn_Save.Name = "btn_Save";
            btn_Save.Padding = new Padding(5);
            btn_Save.Size = new Size(110, 54);
            btn_Save.TabIndex = 1;
            btn_Save.Text = "Save";
            btn_Save.Click += Save_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 328);
            Controls.Add(tlp_Main);
            MinimumSize = new Size(600, 375);
            Name = "SettingsForm";
            Text = "PStudio - Project Settings";
            tlp_Main.ResumeLayout(false);
            panel_Settings.ResumeLayout(false);
            tlp_Settings.ResumeLayout(false);
            tlp_Settings.PerformLayout();
            tlp_Buttons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlp_Main;
        private Panel panel_Settings;
        private TableLayoutPanel tlp_Buttons;
        private DarkUI.Controls.DarkButton btn_Cancel;
        private DarkUI.Controls.DarkButton btn_Save;
        private TableLayoutPanel tlp_Settings;
        private DarkUI.Controls.DarkLabel lbl_ProjectName;
        private DarkUI.Controls.DarkTextBox txt_ProjectName;
        private DarkUI.Controls.DarkLabel lbl_Game;
        private DarkUI.Controls.DarkLabel lbl_GameDir;
        private DarkUI.Controls.DarkLabel lbl_ModDir;
        private DarkUI.Controls.DarkTextBox txt_GameDir;
        private DarkUI.Controls.DarkTextBox txt_ModDir;
        private DarkUI.Controls.DarkButton btn_GameDir;
        private DarkUI.Controls.DarkButton btn_ModDir;
        private ComboBox comboBox_Game;
    }
}