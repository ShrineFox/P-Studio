
namespace P_Studio
{
    partial class Form_Project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Project));
            this.darkGroupBox_Game = new DarkUI.Controls.DarkGroupBox();
            this.darkRadioButton_UseExtracted = new DarkUI.Controls.DarkRadioButton();
            this.darkRadioButton_UseArchive = new DarkUI.Controls.DarkRadioButton();
            this.darkButton_ExtractBrowse = new DarkUI.Controls.DarkButton();
            this.darkLabel_ExtractPath = new DarkUI.Controls.DarkLabel();
            this.darkTextBox_ExtractPath = new DarkUI.Controls.DarkTextBox();
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.darkDropdownList_Game = new DarkUI.Controls.DarkDropdownList();
            this.darkButton_BrowseArchive = new DarkUI.Controls.DarkButton();
            this.darkLabel_ArchivePath = new DarkUI.Controls.DarkLabel();
            this.darkTextBox_ArchivePath = new DarkUI.Controls.DarkTextBox();
            this.darkGroupBox_Project = new DarkUI.Controls.DarkGroupBox();
            this.darkButton_OutputPath = new DarkUI.Controls.DarkButton();
            this.darkTextBox_OutputPath = new DarkUI.Controls.DarkTextBox();
            this.darkLabel_OutputPath = new DarkUI.Controls.DarkLabel();
            this.darkButton_Save = new DarkUI.Controls.DarkButton();
            this.darkTextBox_ProjectName = new DarkUI.Controls.DarkTextBox();
            this.darkLabel_ProjectName = new DarkUI.Controls.DarkLabel();
            this.darkButton_Cancel = new DarkUI.Controls.DarkButton();
            this.darkLabel_Status = new DarkUI.Controls.DarkLabel();
            this.darkGroupBox_Game.SuspendLayout();
            this.darkGroupBox_Project.SuspendLayout();
            this.SuspendLayout();
            // 
            // darkGroupBox_Game
            // 
            this.darkGroupBox_Game.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.darkGroupBox_Game.Controls.Add(this.darkRadioButton_UseExtracted);
            this.darkGroupBox_Game.Controls.Add(this.darkRadioButton_UseArchive);
            this.darkGroupBox_Game.Controls.Add(this.darkButton_ExtractBrowse);
            this.darkGroupBox_Game.Controls.Add(this.darkLabel_ExtractPath);
            this.darkGroupBox_Game.Controls.Add(this.darkTextBox_ExtractPath);
            this.darkGroupBox_Game.Controls.Add(this.darkLabel1);
            this.darkGroupBox_Game.Controls.Add(this.darkDropdownList_Game);
            this.darkGroupBox_Game.Controls.Add(this.darkButton_BrowseArchive);
            this.darkGroupBox_Game.Controls.Add(this.darkLabel_ArchivePath);
            this.darkGroupBox_Game.Controls.Add(this.darkTextBox_ArchivePath);
            this.darkGroupBox_Game.Location = new System.Drawing.Point(12, 63);
            this.darkGroupBox_Game.Name = "darkGroupBox_Game";
            this.darkGroupBox_Game.Size = new System.Drawing.Size(481, 167);
            this.darkGroupBox_Game.TabIndex = 2;
            this.darkGroupBox_Game.TabStop = false;
            this.darkGroupBox_Game.Text = "Game Settings";
            // 
            // darkRadioButton_UseExtracted
            // 
            this.darkRadioButton_UseExtracted.AutoSize = true;
            this.darkRadioButton_UseExtracted.Location = new System.Drawing.Point(6, 114);
            this.darkRadioButton_UseExtracted.Name = "darkRadioButton_UseExtracted";
            this.darkRadioButton_UseExtracted.Size = new System.Drawing.Size(150, 21);
            this.darkRadioButton_UseExtracted.TabIndex = 9;
            this.darkRadioButton_UseExtracted.Text = "Use Extracted Files";
            this.darkRadioButton_UseExtracted.Click += new System.EventHandler(this.InputType_Changed);
            // 
            // darkRadioButton_UseArchive
            // 
            this.darkRadioButton_UseArchive.AutoSize = true;
            this.darkRadioButton_UseArchive.Checked = true;
            this.darkRadioButton_UseArchive.Location = new System.Drawing.Point(6, 64);
            this.darkRadioButton_UseArchive.Name = "darkRadioButton_UseArchive";
            this.darkRadioButton_UseArchive.Size = new System.Drawing.Size(132, 21);
            this.darkRadioButton_UseArchive.TabIndex = 5;
            this.darkRadioButton_UseArchive.TabStop = true;
            this.darkRadioButton_UseArchive.Text = "Extract ISO/PKG";
            this.darkRadioButton_UseArchive.Click += new System.EventHandler(this.InputType_Changed);
            // 
            // darkButton_ExtractBrowse
            // 
            this.darkButton_ExtractBrowse.Enabled = false;
            this.darkButton_ExtractBrowse.Location = new System.Drawing.Point(406, 135);
            this.darkButton_ExtractBrowse.Name = "darkButton_ExtractBrowse";
            this.darkButton_ExtractBrowse.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton_ExtractBrowse.Size = new System.Drawing.Size(69, 23);
            this.darkButton_ExtractBrowse.TabIndex = 12;
            this.darkButton_ExtractBrowse.Text = "...";
            this.darkButton_ExtractBrowse.Click += new System.EventHandler(this.ExtractedPath_Click);
            // 
            // darkLabel_ExtractPath
            // 
            this.darkLabel_ExtractPath.AutoSize = true;
            this.darkLabel_ExtractPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel_ExtractPath.Location = new System.Drawing.Point(27, 138);
            this.darkLabel_ExtractPath.Name = "darkLabel_ExtractPath";
            this.darkLabel_ExtractPath.Size = new System.Drawing.Size(104, 17);
            this.darkLabel_ExtractPath.TabIndex = 10;
            this.darkLabel_ExtractPath.Text = "Extracted Path:";
            // 
            // darkTextBox_ExtractPath
            // 
            this.darkTextBox_ExtractPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.darkTextBox_ExtractPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.darkTextBox_ExtractPath.Enabled = false;
            this.darkTextBox_ExtractPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkTextBox_ExtractPath.Location = new System.Drawing.Point(137, 136);
            this.darkTextBox_ExtractPath.Name = "darkTextBox_ExtractPath";
            this.darkTextBox_ExtractPath.ReadOnly = true;
            this.darkTextBox_ExtractPath.Size = new System.Drawing.Size(263, 22);
            this.darkTextBox_ExtractPath.TabIndex = 11;
            this.darkTextBox_ExtractPath.Click += new System.EventHandler(this.ExtractedPath_Click);
            // 
            // darkLabel1
            // 
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel1.Location = new System.Drawing.Point(78, 30);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(50, 17);
            this.darkLabel1.TabIndex = 3;
            this.darkLabel1.Text = "Game:";
            // 
            // darkDropdownList_Game
            // 
            this.darkDropdownList_Game.Enabled = false;
            this.darkDropdownList_Game.Location = new System.Drawing.Point(137, 26);
            this.darkDropdownList_Game.Name = "darkDropdownList_Game";
            this.darkDropdownList_Game.Size = new System.Drawing.Size(263, 26);
            this.darkDropdownList_Game.TabIndex = 4;
            this.darkDropdownList_Game.Text = "Game";
            // 
            // darkButton_BrowseArchive
            // 
            this.darkButton_BrowseArchive.Location = new System.Drawing.Point(406, 85);
            this.darkButton_BrowseArchive.Name = "darkButton_BrowseArchive";
            this.darkButton_BrowseArchive.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton_BrowseArchive.Size = new System.Drawing.Size(69, 23);
            this.darkButton_BrowseArchive.TabIndex = 8;
            this.darkButton_BrowseArchive.Text = "...";
            this.darkButton_BrowseArchive.Click += new System.EventHandler(this.ArchivePath_Click);
            // 
            // darkLabel_ArchivePath
            // 
            this.darkLabel_ArchivePath.AutoSize = true;
            this.darkLabel_ArchivePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel_ArchivePath.Location = new System.Drawing.Point(30, 88);
            this.darkLabel_ArchivePath.Name = "darkLabel_ArchivePath";
            this.darkLabel_ArchivePath.Size = new System.Drawing.Size(101, 17);
            this.darkLabel_ArchivePath.TabIndex = 6;
            this.darkLabel_ArchivePath.Text = "ISO/PKG Path:";
            // 
            // darkTextBox_ArchivePath
            // 
            this.darkTextBox_ArchivePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.darkTextBox_ArchivePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.darkTextBox_ArchivePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkTextBox_ArchivePath.Location = new System.Drawing.Point(137, 86);
            this.darkTextBox_ArchivePath.Name = "darkTextBox_ArchivePath";
            this.darkTextBox_ArchivePath.ReadOnly = true;
            this.darkTextBox_ArchivePath.Size = new System.Drawing.Size(263, 22);
            this.darkTextBox_ArchivePath.TabIndex = 7;
            this.darkTextBox_ArchivePath.Click += new System.EventHandler(this.ArchivePath_Click);
            // 
            // darkGroupBox_Project
            // 
            this.darkGroupBox_Project.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.darkGroupBox_Project.Controls.Add(this.darkButton_OutputPath);
            this.darkGroupBox_Project.Controls.Add(this.darkTextBox_OutputPath);
            this.darkGroupBox_Project.Controls.Add(this.darkLabel_OutputPath);
            this.darkGroupBox_Project.Location = new System.Drawing.Point(12, 247);
            this.darkGroupBox_Project.Name = "darkGroupBox_Project";
            this.darkGroupBox_Project.Size = new System.Drawing.Size(481, 58);
            this.darkGroupBox_Project.TabIndex = 13;
            this.darkGroupBox_Project.TabStop = false;
            this.darkGroupBox_Project.Text = "Project Settings";
            // 
            // darkButton_OutputPath
            // 
            this.darkButton_OutputPath.Location = new System.Drawing.Point(406, 20);
            this.darkButton_OutputPath.Name = "darkButton_OutputPath";
            this.darkButton_OutputPath.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton_OutputPath.Size = new System.Drawing.Size(69, 23);
            this.darkButton_OutputPath.TabIndex = 16;
            this.darkButton_OutputPath.Text = "...";
            this.darkButton_OutputPath.Click += new System.EventHandler(this.OutputPath_Click);
            // 
            // darkTextBox_OutputPath
            // 
            this.darkTextBox_OutputPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.darkTextBox_OutputPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.darkTextBox_OutputPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkTextBox_OutputPath.Location = new System.Drawing.Point(137, 21);
            this.darkTextBox_OutputPath.Name = "darkTextBox_OutputPath";
            this.darkTextBox_OutputPath.ReadOnly = true;
            this.darkTextBox_OutputPath.Size = new System.Drawing.Size(263, 22);
            this.darkTextBox_OutputPath.TabIndex = 15;
            this.darkTextBox_OutputPath.Click += new System.EventHandler(this.OutputPath_Click);
            // 
            // darkLabel_OutputPath
            // 
            this.darkLabel_OutputPath.AutoSize = true;
            this.darkLabel_OutputPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel_OutputPath.Location = new System.Drawing.Point(12, 23);
            this.darkLabel_OutputPath.Name = "darkLabel_OutputPath";
            this.darkLabel_OutputPath.Size = new System.Drawing.Size(119, 17);
            this.darkLabel_OutputPath.TabIndex = 14;
            this.darkLabel_OutputPath.Text = "Mod Output Path:";
            // 
            // darkButton_Save
            // 
            this.darkButton_Save.Location = new System.Drawing.Point(393, 311);
            this.darkButton_Save.Name = "darkButton_Save";
            this.darkButton_Save.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton_Save.Size = new System.Drawing.Size(94, 34);
            this.darkButton_Save.TabIndex = 18;
            this.darkButton_Save.Text = "Save";
            this.darkButton_Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // darkTextBox_ProjectName
            // 
            this.darkTextBox_ProjectName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.darkTextBox_ProjectName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.darkTextBox_ProjectName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkTextBox_ProjectName.Location = new System.Drawing.Point(149, 23);
            this.darkTextBox_ProjectName.Name = "darkTextBox_ProjectName";
            this.darkTextBox_ProjectName.Size = new System.Drawing.Size(263, 22);
            this.darkTextBox_ProjectName.TabIndex = 1;
            // 
            // darkLabel_ProjectName
            // 
            this.darkLabel_ProjectName.AutoSize = true;
            this.darkLabel_ProjectName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel_ProjectName.Location = new System.Drawing.Point(43, 25);
            this.darkLabel_ProjectName.Name = "darkLabel_ProjectName";
            this.darkLabel_ProjectName.Size = new System.Drawing.Size(97, 17);
            this.darkLabel_ProjectName.TabIndex = 0;
            this.darkLabel_ProjectName.Text = "Project Name:";
            // 
            // darkButton_Cancel
            // 
            this.darkButton_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.darkButton_Cancel.Location = new System.Drawing.Point(293, 311);
            this.darkButton_Cancel.Name = "darkButton_Cancel";
            this.darkButton_Cancel.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton_Cancel.Size = new System.Drawing.Size(94, 34);
            this.darkButton_Cancel.TabIndex = 17;
            this.darkButton_Cancel.Text = "Cancel";
            // 
            // darkLabel_Status
            // 
            this.darkLabel_Status.AutoSize = true;
            this.darkLabel_Status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel_Status.Location = new System.Drawing.Point(24, 328);
            this.darkLabel_Status.Name = "darkLabel_Status";
            this.darkLabel_Status.Size = new System.Drawing.Size(0, 17);
            this.darkLabel_Status.TabIndex = 19;
            // 
            // Form_Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 363);
            this.Controls.Add(this.darkLabel_Status);
            this.Controls.Add(this.darkButton_Cancel);
            this.Controls.Add(this.darkTextBox_ProjectName);
            this.Controls.Add(this.darkButton_Save);
            this.Controls.Add(this.darkGroupBox_Project);
            this.Controls.Add(this.darkLabel_ProjectName);
            this.Controls.Add(this.darkGroupBox_Game);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(523, 410);
            this.MinimumSize = new System.Drawing.Size(523, 410);
            this.Name = "Form_Project";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "P-Studio Project Settings";
            this.darkGroupBox_Game.ResumeLayout(false);
            this.darkGroupBox_Game.PerformLayout();
            this.darkGroupBox_Project.ResumeLayout(false);
            this.darkGroupBox_Project.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DarkUI.Controls.DarkGroupBox darkGroupBox_Game;
        private DarkUI.Controls.DarkButton darkButton_BrowseArchive;
        private DarkUI.Controls.DarkLabel darkLabel_ArchivePath;
        private DarkUI.Controls.DarkTextBox darkTextBox_ArchivePath;
        private DarkUI.Controls.DarkLabel darkLabel1;
        private DarkUI.Controls.DarkDropdownList darkDropdownList_Game;
        private DarkUI.Controls.DarkButton darkButton_ExtractBrowse;
        private DarkUI.Controls.DarkLabel darkLabel_ExtractPath;
        private DarkUI.Controls.DarkTextBox darkTextBox_ExtractPath;
        private DarkUI.Controls.DarkGroupBox darkGroupBox_Project;
        private DarkUI.Controls.DarkButton darkButton_OutputPath;
        private DarkUI.Controls.DarkTextBox darkTextBox_OutputPath;
        private DarkUI.Controls.DarkLabel darkLabel_OutputPath;
        private DarkUI.Controls.DarkButton darkButton_Save;
        private DarkUI.Controls.DarkTextBox darkTextBox_ProjectName;
        private DarkUI.Controls.DarkLabel darkLabel_ProjectName;
        private DarkUI.Controls.DarkRadioButton darkRadioButton_UseArchive;
        private DarkUI.Controls.DarkRadioButton darkRadioButton_UseExtracted;
        private DarkUI.Controls.DarkButton darkButton_Cancel;
        public DarkUI.Controls.DarkLabel darkLabel_Status;
    }
}