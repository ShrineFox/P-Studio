
namespace P_Studio
{
    partial class SettingsForm : MetroSet_UI.Forms.MetroSetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.lbl_ProjectName = new MetroSet_UI.Controls.MetroSetLabel();
            this.txt_ProjectName = new MetroSet_UI.Controls.MetroSetTextBox();
            this.tableLayoutPanel_Settings = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_ProjectSettings = new MetroSet_UI.Controls.MetroSetLabel();
            this.tlp_Output = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Output = new MetroSet_UI.Controls.MetroSetButton();
            this.txt_Output = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lbl_Output = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetTextBox1 = new MetroSet_UI.Controls.MetroSetTextBox();
            this.tlp_ProjectName = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_GameSettings = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_GameSettings = new MetroSet_UI.Controls.MetroSetLabel();
            this.tlp_GameSettingsInner = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox_Platform = new MetroSet_UI.Controls.MetroSetComboBox();
            this.lbl_Platform = new MetroSet_UI.Controls.MetroSetLabel();
            this.btn_Extracted = new MetroSet_UI.Controls.MetroSetButton();
            this.lbl_Game = new MetroSet_UI.Controls.MetroSetLabel();
            this.comboBox_Game = new MetroSet_UI.Controls.MetroSetComboBox();
            this.radio_Extracted = new MetroSet_UI.Controls.MetroSetRadioButton();
            this.txt_Extracted = new MetroSet_UI.Controls.MetroSetTextBox();
            this.btn_Archive = new MetroSet_UI.Controls.MetroSetButton();
            this.txt_Archive = new MetroSet_UI.Controls.MetroSetTextBox();
            this.radio_Archive = new MetroSet_UI.Controls.MetroSetRadioButton();
            this.tlp_Buttons = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Cancel = new MetroSet_UI.Controls.MetroSetButton();
            this.btn_Save = new MetroSet_UI.Controls.MetroSetButton();
            this.lbl_Region = new MetroSet_UI.Controls.MetroSetLabel();
            this.comboBox_Region = new MetroSet_UI.Controls.MetroSetComboBox();
            this.tableLayoutPanel_Settings.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlp_Output.SuspendLayout();
            this.tlp_ProjectName.SuspendLayout();
            this.tlp_GameSettings.SuspendLayout();
            this.tlp_GameSettingsInner.SuspendLayout();
            this.tlp_Buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_ProjectName
            // 
            this.lbl_ProjectName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_ProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_ProjectName.IsDerivedStyle = true;
            this.lbl_ProjectName.Location = new System.Drawing.Point(81, 17);
            this.lbl_ProjectName.Name = "lbl_ProjectName";
            this.lbl_ProjectName.Size = new System.Drawing.Size(119, 23);
            this.lbl_ProjectName.Style = MetroSet_UI.Enums.Style.Dark;
            this.lbl_ProjectName.StyleManager = null;
            this.lbl_ProjectName.TabIndex = 25;
            this.lbl_ProjectName.Text = "Project Name: ";
            this.lbl_ProjectName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_ProjectName.ThemeAuthor = "Narwin";
            this.lbl_ProjectName.ThemeName = "MetroDark";
            // 
            // txt_ProjectName
            // 
            this.txt_ProjectName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ProjectName.AutoCompleteCustomSource = null;
            this.txt_ProjectName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_ProjectName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_ProjectName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.txt_ProjectName.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txt_ProjectName.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_ProjectName.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_ProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_ProjectName.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.txt_ProjectName.Image = null;
            this.txt_ProjectName.IsDerivedStyle = true;
            this.txt_ProjectName.Lines = null;
            this.txt_ProjectName.Location = new System.Drawing.Point(206, 14);
            this.txt_ProjectName.MaxLength = 32767;
            this.txt_ProjectName.Multiline = false;
            this.txt_ProjectName.Name = "txt_ProjectName";
            this.txt_ProjectName.ReadOnly = false;
            this.txt_ProjectName.Size = new System.Drawing.Size(313, 30);
            this.txt_ProjectName.Style = MetroSet_UI.Enums.Style.Dark;
            this.txt_ProjectName.StyleManager = null;
            this.txt_ProjectName.TabIndex = 26;
            this.txt_ProjectName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_ProjectName.ThemeAuthor = "Narwin";
            this.txt_ProjectName.ThemeName = "MetroDark";
            this.txt_ProjectName.UseSystemPasswordChar = false;
            this.txt_ProjectName.WatermarkText = "";
            // 
            // tableLayoutPanel_Settings
            // 
            this.tableLayoutPanel_Settings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tableLayoutPanel_Settings.ColumnCount = 1;
            this.tableLayoutPanel_Settings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Settings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Settings.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tableLayoutPanel_Settings.Controls.Add(this.tlp_ProjectName, 0, 0);
            this.tableLayoutPanel_Settings.Controls.Add(this.tlp_GameSettings, 0, 1);
            this.tableLayoutPanel_Settings.Controls.Add(this.tlp_Buttons, 0, 3);
            this.tableLayoutPanel_Settings.Location = new System.Drawing.Point(13, 14);
            this.tableLayoutPanel_Settings.Name = "tableLayoutPanel_Settings";
            this.tableLayoutPanel_Settings.RowCount = 4;
            this.tableLayoutPanel_Settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.34831F));
            this.tableLayoutPanel_Settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.65169F));
            this.tableLayoutPanel_Settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanel_Settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel_Settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_Settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_Settings.Size = new System.Drawing.Size(586, 447);
            this.tableLayoutPanel_Settings.TabIndex = 28;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_ProjectSettings, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tlp_Output, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 305);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(580, 99);
            this.tableLayoutPanel1.TabIndex = 33;
            // 
            // lbl_ProjectSettings
            // 
            this.lbl_ProjectSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ProjectSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbl_ProjectSettings.IsDerivedStyle = true;
            this.lbl_ProjectSettings.Location = new System.Drawing.Point(3, 5);
            this.lbl_ProjectSettings.Name = "lbl_ProjectSettings";
            this.lbl_ProjectSettings.Size = new System.Drawing.Size(574, 39);
            this.lbl_ProjectSettings.Style = MetroSet_UI.Enums.Style.Dark;
            this.lbl_ProjectSettings.StyleManager = null;
            this.lbl_ProjectSettings.TabIndex = 32;
            this.lbl_ProjectSettings.Text = "Project Settings";
            this.lbl_ProjectSettings.ThemeAuthor = "Narwin";
            this.lbl_ProjectSettings.ThemeName = "MetroDark";
            // 
            // tlp_Output
            // 
            this.tlp_Output.ColumnCount = 3;
            this.tlp_Output.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlp_Output.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tlp_Output.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_Output.Controls.Add(this.btn_Output, 2, 2);
            this.tlp_Output.Controls.Add(this.txt_Output, 1, 2);
            this.tlp_Output.Controls.Add(this.lbl_Output, 0, 2);
            this.tlp_Output.Controls.Add(this.metroSetLabel2, 0, 0);
            this.tlp_Output.Controls.Add(this.metroSetTextBox1, 1, 1);
            this.tlp_Output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Output.Location = new System.Drawing.Point(3, 52);
            this.tlp_Output.Name = "tlp_Output";
            this.tlp_Output.RowCount = 3;
            this.tlp_Output.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Output.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Output.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tlp_Output.Size = new System.Drawing.Size(574, 44);
            this.tlp_Output.TabIndex = 27;
            // 
            // btn_Output
            // 
            this.btn_Output.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_Output.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_Output.DisabledForeColor = System.Drawing.Color.Gray;
            this.btn_Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Output.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btn_Output.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btn_Output.HoverTextColor = System.Drawing.Color.White;
            this.btn_Output.IsDerivedStyle = true;
            this.btn_Output.Location = new System.Drawing.Point(518, 5);
            this.btn_Output.Name = "btn_Output";
            this.btn_Output.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_Output.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_Output.NormalTextColor = System.Drawing.Color.White;
            this.btn_Output.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btn_Output.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btn_Output.PressTextColor = System.Drawing.Color.White;
            this.btn_Output.Size = new System.Drawing.Size(53, 32);
            this.btn_Output.Style = MetroSet_UI.Enums.Style.Dark;
            this.btn_Output.StyleManager = null;
            this.btn_Output.TabIndex = 34;
            this.btn_Output.Text = "...";
            this.btn_Output.ThemeAuthor = "Narwin";
            this.btn_Output.ThemeName = "MetroDark";
            this.btn_Output.Click += new System.EventHandler(this.OutputPath_Click);
            // 
            // txt_Output
            // 
            this.txt_Output.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Output.AutoCompleteCustomSource = null;
            this.txt_Output.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_Output.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_Output.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.txt_Output.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txt_Output.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Output.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_Output.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.txt_Output.Image = null;
            this.txt_Output.IsDerivedStyle = true;
            this.txt_Output.Lines = null;
            this.txt_Output.Location = new System.Drawing.Point(203, 8);
            this.txt_Output.MaxLength = 32767;
            this.txt_Output.Multiline = false;
            this.txt_Output.Name = "txt_Output";
            this.txt_Output.ReadOnly = true;
            this.txt_Output.Size = new System.Drawing.Size(309, 30);
            this.txt_Output.Style = MetroSet_UI.Enums.Style.Dark;
            this.txt_Output.StyleManager = null;
            this.txt_Output.TabIndex = 27;
            this.txt_Output.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Output.ThemeAuthor = "Narwin";
            this.txt_Output.ThemeName = "MetroDark";
            this.txt_Output.UseSystemPasswordChar = false;
            this.txt_Output.WatermarkText = "";
            this.txt_Output.Click += new System.EventHandler(this.OutputPath_Click);
            // 
            // lbl_Output
            // 
            this.lbl_Output.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_Output.IsDerivedStyle = true;
            this.lbl_Output.Location = new System.Drawing.Point(95, 11);
            this.lbl_Output.Name = "lbl_Output";
            this.lbl_Output.Size = new System.Drawing.Size(102, 23);
            this.lbl_Output.Style = MetroSet_UI.Enums.Style.Dark;
            this.lbl_Output.StyleManager = null;
            this.lbl_Output.TabIndex = 28;
            this.lbl_Output.Text = "Mod Output: ";
            this.lbl_Output.ThemeAuthor = "Narwin";
            this.lbl_Output.ThemeName = "MetroDark";
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel2.IsDerivedStyle = false;
            this.metroSetLabel2.Location = new System.Drawing.Point(3, 0);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(117, 1);
            this.metroSetLabel2.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel2.StyleManager = null;
            this.metroSetLabel2.TabIndex = 26;
            this.metroSetLabel2.Text = "Game:";
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroDark";
            // 
            // metroSetTextBox1
            // 
            this.metroSetTextBox1.AutoCompleteCustomSource = null;
            this.metroSetTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.metroSetTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.metroSetTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetTextBox1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.metroSetTextBox1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetTextBox1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetTextBox1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTextBox1.Image = null;
            this.metroSetTextBox1.IsDerivedStyle = true;
            this.metroSetTextBox1.Lines = null;
            this.metroSetTextBox1.Location = new System.Drawing.Point(203, 4);
            this.metroSetTextBox1.MaxLength = 32767;
            this.metroSetTextBox1.Multiline = false;
            this.metroSetTextBox1.Name = "metroSetTextBox1";
            this.metroSetTextBox1.ReadOnly = false;
            this.metroSetTextBox1.Size = new System.Drawing.Size(80, 1);
            this.metroSetTextBox1.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetTextBox1.StyleManager = null;
            this.metroSetTextBox1.TabIndex = 27;
            this.metroSetTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.metroSetTextBox1.ThemeAuthor = "Narwin";
            this.metroSetTextBox1.ThemeName = "MetroDark";
            this.metroSetTextBox1.UseSystemPasswordChar = false;
            this.metroSetTextBox1.WatermarkText = "";
            // 
            // tlp_ProjectName
            // 
            this.tlp_ProjectName.ColumnCount = 3;
            this.tlp_ProjectName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlp_ProjectName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tlp_ProjectName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_ProjectName.Controls.Add(this.txt_ProjectName, 1, 0);
            this.tlp_ProjectName.Controls.Add(this.lbl_ProjectName, 0, 0);
            this.tlp_ProjectName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_ProjectName.Location = new System.Drawing.Point(3, 3);
            this.tlp_ProjectName.Name = "tlp_ProjectName";
            this.tlp_ProjectName.RowCount = 1;
            this.tlp_ProjectName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_ProjectName.Size = new System.Drawing.Size(580, 58);
            this.tlp_ProjectName.TabIndex = 0;
            // 
            // tlp_GameSettings
            // 
            this.tlp_GameSettings.ColumnCount = 1;
            this.tlp_GameSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47F));
            this.tlp_GameSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53F));
            this.tlp_GameSettings.Controls.Add(this.lbl_GameSettings, 0, 0);
            this.tlp_GameSettings.Controls.Add(this.tlp_GameSettingsInner, 1, 1);
            this.tlp_GameSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_GameSettings.Location = new System.Drawing.Point(3, 67);
            this.tlp_GameSettings.Name = "tlp_GameSettings";
            this.tlp_GameSettings.RowCount = 3;
            this.tlp_GameSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.58974F));
            this.tlp_GameSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.41026F));
            this.tlp_GameSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlp_GameSettings.Size = new System.Drawing.Size(580, 232);
            this.tlp_GameSettings.TabIndex = 28;
            // 
            // lbl_GameSettings
            // 
            this.lbl_GameSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_GameSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbl_GameSettings.IsDerivedStyle = true;
            this.lbl_GameSettings.Location = new System.Drawing.Point(3, 8);
            this.lbl_GameSettings.Name = "lbl_GameSettings";
            this.lbl_GameSettings.Size = new System.Drawing.Size(574, 36);
            this.lbl_GameSettings.Style = MetroSet_UI.Enums.Style.Dark;
            this.lbl_GameSettings.StyleManager = null;
            this.lbl_GameSettings.TabIndex = 32;
            this.lbl_GameSettings.Text = "Game Settings";
            this.lbl_GameSettings.ThemeAuthor = "Narwin";
            this.lbl_GameSettings.ThemeName = "MetroDark";
            // 
            // tlp_GameSettingsInner
            // 
            this.tlp_GameSettingsInner.ColumnCount = 3;
            this.tlp_GameSettingsInner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlp_GameSettingsInner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tlp_GameSettingsInner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_GameSettingsInner.Controls.Add(this.comboBox_Region, 1, 1);
            this.tlp_GameSettingsInner.Controls.Add(this.lbl_Region, 0, 1);
            this.tlp_GameSettingsInner.Controls.Add(this.comboBox_Platform, 1, 0);
            this.tlp_GameSettingsInner.Controls.Add(this.lbl_Platform, 0, 0);
            this.tlp_GameSettingsInner.Controls.Add(this.radio_Extracted, 0, 4);
            this.tlp_GameSettingsInner.Controls.Add(this.txt_Extracted, 1, 4);
            this.tlp_GameSettingsInner.Controls.Add(this.btn_Extracted, 2, 4);
            this.tlp_GameSettingsInner.Controls.Add(this.btn_Archive, 2, 3);
            this.tlp_GameSettingsInner.Controls.Add(this.txt_Archive, 1, 3);
            this.tlp_GameSettingsInner.Controls.Add(this.radio_Archive, 0, 3);
            this.tlp_GameSettingsInner.Controls.Add(this.lbl_Game, 0, 2);
            this.tlp_GameSettingsInner.Controls.Add(this.comboBox_Game, 1, 2);
            this.tlp_GameSettingsInner.Location = new System.Drawing.Point(3, 55);
            this.tlp_GameSettingsInner.Name = "tlp_GameSettingsInner";
            this.tlp_GameSettingsInner.RowCount = 5;
            this.tlp_GameSettingsInner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_GameSettingsInner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_GameSettingsInner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_GameSettingsInner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_GameSettingsInner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_GameSettingsInner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_GameSettingsInner.Size = new System.Drawing.Size(574, 143);
            this.tlp_GameSettingsInner.TabIndex = 27;
            // 
            // comboBox_Platform
            // 
            this.comboBox_Platform.AllowDrop = true;
            this.comboBox_Platform.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Platform.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.comboBox_Platform.BackColor = System.Drawing.Color.Transparent;
            this.comboBox_Platform.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.comboBox_Platform.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.comboBox_Platform.CausesValidation = false;
            this.comboBox_Platform.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.comboBox_Platform.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.comboBox_Platform.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.comboBox_Platform.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_Platform.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Platform.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBox_Platform.FormattingEnabled = true;
            this.comboBox_Platform.IsDerivedStyle = true;
            this.comboBox_Platform.ItemHeight = 20;
            this.comboBox_Platform.Location = new System.Drawing.Point(203, 3);
            this.comboBox_Platform.Name = "comboBox_Platform";
            this.comboBox_Platform.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.comboBox_Platform.SelectedItemForeColor = System.Drawing.Color.White;
            this.comboBox_Platform.Size = new System.Drawing.Size(309, 26);
            this.comboBox_Platform.Style = MetroSet_UI.Enums.Style.Dark;
            this.comboBox_Platform.StyleManager = null;
            this.comboBox_Platform.TabIndex = 36;
            this.comboBox_Platform.ThemeAuthor = "Narwin";
            this.comboBox_Platform.ThemeName = "MetroDark";
            this.comboBox_Platform.SelectedIndexChanged += new System.EventHandler(this.Platform_Changed);
            // 
            // lbl_Platform
            // 
            this.lbl_Platform.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Platform.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_Platform.IsDerivedStyle = true;
            this.lbl_Platform.Location = new System.Drawing.Point(118, 2);
            this.lbl_Platform.Name = "lbl_Platform";
            this.lbl_Platform.Size = new System.Drawing.Size(79, 23);
            this.lbl_Platform.Style = MetroSet_UI.Enums.Style.Dark;
            this.lbl_Platform.StyleManager = null;
            this.lbl_Platform.TabIndex = 35;
            this.lbl_Platform.Text = "Platform: ";
            this.lbl_Platform.ThemeAuthor = "Narwin";
            this.lbl_Platform.ThemeName = "MetroDark";
            // 
            // btn_Extracted
            // 
            this.btn_Extracted.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_Extracted.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_Extracted.DisabledForeColor = System.Drawing.Color.Gray;
            this.btn_Extracted.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Extracted.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btn_Extracted.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btn_Extracted.HoverTextColor = System.Drawing.Color.White;
            this.btn_Extracted.IsDerivedStyle = true;
            this.btn_Extracted.Location = new System.Drawing.Point(518, 115);
            this.btn_Extracted.Name = "btn_Extracted";
            this.btn_Extracted.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_Extracted.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_Extracted.NormalTextColor = System.Drawing.Color.White;
            this.btn_Extracted.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btn_Extracted.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btn_Extracted.PressTextColor = System.Drawing.Color.White;
            this.btn_Extracted.Size = new System.Drawing.Size(53, 25);
            this.btn_Extracted.Style = MetroSet_UI.Enums.Style.Dark;
            this.btn_Extracted.StyleManager = null;
            this.btn_Extracted.TabIndex = 33;
            this.btn_Extracted.Text = "...";
            this.btn_Extracted.ThemeAuthor = "Narwin";
            this.btn_Extracted.ThemeName = "MetroDark";
            this.btn_Extracted.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ExtractedPath_Click);
            // 
            // lbl_Game
            // 
            this.lbl_Game.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Game.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_Game.IsDerivedStyle = true;
            this.lbl_Game.Location = new System.Drawing.Point(136, 58);
            this.lbl_Game.Name = "lbl_Game";
            this.lbl_Game.Size = new System.Drawing.Size(61, 23);
            this.lbl_Game.Style = MetroSet_UI.Enums.Style.Dark;
            this.lbl_Game.StyleManager = null;
            this.lbl_Game.TabIndex = 26;
            this.lbl_Game.Text = "Game: ";
            this.lbl_Game.ThemeAuthor = "Narwin";
            this.lbl_Game.ThemeName = "MetroDark";
            // 
            // comboBox_Game
            // 
            this.comboBox_Game.AllowDrop = true;
            this.comboBox_Game.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Game.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.comboBox_Game.BackColor = System.Drawing.Color.Transparent;
            this.comboBox_Game.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.comboBox_Game.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.comboBox_Game.CausesValidation = false;
            this.comboBox_Game.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.comboBox_Game.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.comboBox_Game.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.comboBox_Game.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_Game.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Game.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBox_Game.FormattingEnabled = true;
            this.comboBox_Game.IsDerivedStyle = true;
            this.comboBox_Game.ItemHeight = 20;
            this.comboBox_Game.Location = new System.Drawing.Point(203, 59);
            this.comboBox_Game.Name = "comboBox_Game";
            this.comboBox_Game.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.comboBox_Game.SelectedItemForeColor = System.Drawing.Color.White;
            this.comboBox_Game.Size = new System.Drawing.Size(309, 26);
            this.comboBox_Game.Style = MetroSet_UI.Enums.Style.Dark;
            this.comboBox_Game.StyleManager = null;
            this.comboBox_Game.TabIndex = 27;
            this.comboBox_Game.ThemeAuthor = "Narwin";
            this.comboBox_Game.ThemeName = "MetroDark";
            // 
            // radio_Extracted
            // 
            this.radio_Extracted.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radio_Extracted.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.radio_Extracted.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.radio_Extracted.Checked = false;
            this.radio_Extracted.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.radio_Extracted.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.radio_Extracted.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.radio_Extracted.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radio_Extracted.Group = 0;
            this.radio_Extracted.IsDerivedStyle = true;
            this.radio_Extracted.Location = new System.Drawing.Point(18, 119);
            this.radio_Extracted.Name = "radio_Extracted";
            this.radio_Extracted.Size = new System.Drawing.Size(179, 17);
            this.radio_Extracted.Style = MetroSet_UI.Enums.Style.Dark;
            this.radio_Extracted.StyleManager = null;
            this.radio_Extracted.TabIndex = 31;
            this.radio_Extracted.Text = "Use Extracted Files:";
            this.radio_Extracted.ThemeAuthor = "Narwin";
            this.radio_Extracted.ThemeName = "MetroDark";
            this.radio_Extracted.CheckedChanged += new MetroSet_UI.Controls.MetroSetRadioButton.CheckedChangedEventHandler(this.InputType_Changed);
            // 
            // txt_Extracted
            // 
            this.txt_Extracted.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Extracted.AutoCompleteCustomSource = null;
            this.txt_Extracted.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_Extracted.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_Extracted.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.txt_Extracted.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txt_Extracted.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Extracted.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Extracted.Enabled = false;
            this.txt_Extracted.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_Extracted.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.txt_Extracted.Image = null;
            this.txt_Extracted.IsDerivedStyle = true;
            this.txt_Extracted.Lines = null;
            this.txt_Extracted.Location = new System.Drawing.Point(203, 115);
            this.txt_Extracted.MaxLength = 32767;
            this.txt_Extracted.Multiline = false;
            this.txt_Extracted.Name = "txt_Extracted";
            this.txt_Extracted.ReadOnly = true;
            this.txt_Extracted.Size = new System.Drawing.Size(309, 25);
            this.txt_Extracted.Style = MetroSet_UI.Enums.Style.Dark;
            this.txt_Extracted.StyleManager = null;
            this.txt_Extracted.TabIndex = 30;
            this.txt_Extracted.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Extracted.ThemeAuthor = "Narwin";
            this.txt_Extracted.ThemeName = "MetroDark";
            this.txt_Extracted.UseSystemPasswordChar = false;
            this.txt_Extracted.WatermarkText = "";
            this.txt_Extracted.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ExtractedPath_Click);
            // 
            // btn_Archive
            // 
            this.btn_Archive.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_Archive.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_Archive.DisabledForeColor = System.Drawing.Color.Gray;
            this.btn_Archive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Archive.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btn_Archive.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btn_Archive.HoverTextColor = System.Drawing.Color.White;
            this.btn_Archive.IsDerivedStyle = true;
            this.btn_Archive.Location = new System.Drawing.Point(518, 87);
            this.btn_Archive.Name = "btn_Archive";
            this.btn_Archive.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_Archive.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_Archive.NormalTextColor = System.Drawing.Color.White;
            this.btn_Archive.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btn_Archive.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btn_Archive.PressTextColor = System.Drawing.Color.White;
            this.btn_Archive.Size = new System.Drawing.Size(53, 22);
            this.btn_Archive.Style = MetroSet_UI.Enums.Style.Dark;
            this.btn_Archive.StyleManager = null;
            this.btn_Archive.TabIndex = 32;
            this.btn_Archive.Text = "...";
            this.btn_Archive.ThemeAuthor = "Narwin";
            this.btn_Archive.ThemeName = "MetroDark";
            this.btn_Archive.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ArchivePath_Click);
            // 
            // txt_Archive
            // 
            this.txt_Archive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Archive.AutoCompleteCustomSource = null;
            this.txt_Archive.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_Archive.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_Archive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.txt_Archive.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txt_Archive.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Archive.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Archive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_Archive.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.txt_Archive.Image = null;
            this.txt_Archive.IsDerivedStyle = true;
            this.txt_Archive.Lines = null;
            this.txt_Archive.Location = new System.Drawing.Point(203, 87);
            this.txt_Archive.MaxLength = 32767;
            this.txt_Archive.Multiline = false;
            this.txt_Archive.Name = "txt_Archive";
            this.txt_Archive.ReadOnly = true;
            this.txt_Archive.Size = new System.Drawing.Size(309, 22);
            this.txt_Archive.Style = MetroSet_UI.Enums.Style.Dark;
            this.txt_Archive.StyleManager = null;
            this.txt_Archive.TabIndex = 27;
            this.txt_Archive.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Archive.ThemeAuthor = "Narwin";
            this.txt_Archive.ThemeName = "MetroDark";
            this.txt_Archive.UseSystemPasswordChar = false;
            this.txt_Archive.WatermarkText = "";
            this.txt_Archive.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ArchivePath_Click);
            // 
            // radio_Archive
            // 
            this.radio_Archive.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radio_Archive.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.radio_Archive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.radio_Archive.Checked = true;
            this.radio_Archive.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.radio_Archive.CheckState = MetroSet_UI.Enums.CheckState.Checked;
            this.radio_Archive.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.radio_Archive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radio_Archive.Group = 0;
            this.radio_Archive.IsDerivedStyle = true;
            this.radio_Archive.Location = new System.Drawing.Point(38, 89);
            this.radio_Archive.Name = "radio_Archive";
            this.radio_Archive.Size = new System.Drawing.Size(159, 17);
            this.radio_Archive.Style = MetroSet_UI.Enums.Style.Dark;
            this.radio_Archive.StyleManager = null;
            this.radio_Archive.TabIndex = 29;
            this.radio_Archive.Text = "Extract ISO/PKG: ";
            this.radio_Archive.ThemeAuthor = "Narwin";
            this.radio_Archive.ThemeName = "MetroDark";
            this.radio_Archive.CheckedChanged += new MetroSet_UI.Controls.MetroSetRadioButton.CheckedChangedEventHandler(this.InputType_Changed);
            // 
            // tlp_Buttons
            // 
            this.tlp_Buttons.ColumnCount = 3;
            this.tlp_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlp_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_Buttons.Controls.Add(this.btn_Cancel, 1, 0);
            this.tlp_Buttons.Controls.Add(this.btn_Save, 2, 0);
            this.tlp_Buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Buttons.Location = new System.Drawing.Point(3, 410);
            this.tlp_Buttons.Name = "tlp_Buttons";
            this.tlp_Buttons.RowCount = 1;
            this.tlp_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Buttons.Size = new System.Drawing.Size(580, 34);
            this.tlp_Buttons.TabIndex = 34;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_Cancel.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_Cancel.DisabledForeColor = System.Drawing.Color.Gray;
            this.btn_Cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Cancel.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btn_Cancel.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btn_Cancel.HoverTextColor = System.Drawing.Color.White;
            this.btn_Cancel.IsDerivedStyle = true;
            this.btn_Cancel.Location = new System.Drawing.Point(351, 3);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_Cancel.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_Cancel.NormalTextColor = System.Drawing.Color.White;
            this.btn_Cancel.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btn_Cancel.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btn_Cancel.PressTextColor = System.Drawing.Color.White;
            this.btn_Cancel.Size = new System.Drawing.Size(110, 28);
            this.btn_Cancel.Style = MetroSet_UI.Enums.Style.Dark;
            this.btn_Cancel.StyleManager = null;
            this.btn_Cancel.TabIndex = 0;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.ThemeAuthor = "Narwin";
            this.btn_Cancel.ThemeName = "MetroDark";
            this.btn_Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_Save.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_Save.DisabledForeColor = System.Drawing.Color.Gray;
            this.btn_Save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Save.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btn_Save.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btn_Save.HoverTextColor = System.Drawing.Color.White;
            this.btn_Save.IsDerivedStyle = true;
            this.btn_Save.Location = new System.Drawing.Point(467, 3);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_Save.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_Save.NormalTextColor = System.Drawing.Color.White;
            this.btn_Save.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btn_Save.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btn_Save.PressTextColor = System.Drawing.Color.White;
            this.btn_Save.Size = new System.Drawing.Size(110, 28);
            this.btn_Save.Style = MetroSet_UI.Enums.Style.Dark;
            this.btn_Save.StyleManager = null;
            this.btn_Save.TabIndex = 1;
            this.btn_Save.Text = "Save";
            this.btn_Save.ThemeAuthor = "Narwin";
            this.btn_Save.ThemeName = "MetroDark";
            this.btn_Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // lbl_Region
            // 
            this.lbl_Region.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Region.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_Region.IsDerivedStyle = true;
            this.lbl_Region.Location = new System.Drawing.Point(126, 30);
            this.lbl_Region.Name = "lbl_Region";
            this.lbl_Region.Size = new System.Drawing.Size(71, 23);
            this.lbl_Region.Style = MetroSet_UI.Enums.Style.Dark;
            this.lbl_Region.StyleManager = null;
            this.lbl_Region.TabIndex = 37;
            this.lbl_Region.Text = "Region: ";
            this.lbl_Region.ThemeAuthor = "Narwin";
            this.lbl_Region.ThemeName = "MetroDark";
            // 
            // comboBox_Region
            // 
            this.comboBox_Region.AllowDrop = true;
            this.comboBox_Region.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Region.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.comboBox_Region.BackColor = System.Drawing.Color.Transparent;
            this.comboBox_Region.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.comboBox_Region.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.comboBox_Region.CausesValidation = false;
            this.comboBox_Region.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.comboBox_Region.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.comboBox_Region.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.comboBox_Region.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_Region.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Region.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBox_Region.FormattingEnabled = true;
            this.comboBox_Region.IsDerivedStyle = true;
            this.comboBox_Region.ItemHeight = 20;
            this.comboBox_Region.Location = new System.Drawing.Point(203, 31);
            this.comboBox_Region.Name = "comboBox_Region";
            this.comboBox_Region.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.comboBox_Region.SelectedItemForeColor = System.Drawing.Color.White;
            this.comboBox_Region.Size = new System.Drawing.Size(309, 26);
            this.comboBox_Region.Style = MetroSet_UI.Enums.Style.Dark;
            this.comboBox_Region.StyleManager = null;
            this.comboBox_Region.TabIndex = 38;
            this.comboBox_Region.ThemeAuthor = "Narwin";
            this.comboBox_Region.ThemeName = "MetroDark";
            this.comboBox_Region.SelectedIndexChanged += new System.EventHandler(this.Region_Changed);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BorderThickness = 0F;
            this.ClientSize = new System.Drawing.Size(612, 478);
            this.Controls.Add(this.tableLayoutPanel_Settings);
            this.DropShadowEffect = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.HeaderHeight = -40;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(630, 525);
            this.Name = "SettingsForm";
            this.Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.ShowHeader = true;
            this.ShowLeftRect = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Style = MetroSet_UI.Enums.Style.Dark;
            this.Text = "P-Studio v0.1 - Settings";
            this.ThemeName = "MetroDark";
            this.tableLayoutPanel_Settings.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tlp_Output.ResumeLayout(false);
            this.tlp_ProjectName.ResumeLayout(false);
            this.tlp_GameSettings.ResumeLayout(false);
            this.tlp_GameSettingsInner.ResumeLayout(false);
            this.tlp_Buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroSet_UI.Controls.MetroSetLabel lbl_ProjectName;
        private MetroSet_UI.Controls.MetroSetTextBox txt_ProjectName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Settings;
        private System.Windows.Forms.TableLayoutPanel tlp_GameSettingsInner;
        private MetroSet_UI.Controls.MetroSetLabel lbl_Game;
        private System.Windows.Forms.TableLayoutPanel tlp_ProjectName;
        private MetroSet_UI.Controls.MetroSetComboBox comboBox_Game;
        private MetroSet_UI.Controls.MetroSetTextBox txt_Archive;
        private MetroSet_UI.Controls.MetroSetRadioButton radio_Archive;
        private MetroSet_UI.Controls.MetroSetTextBox txt_Extracted;
        private MetroSet_UI.Controls.MetroSetRadioButton radio_Extracted;
        private System.Windows.Forms.TableLayoutPanel tlp_GameSettings;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroSet_UI.Controls.MetroSetLabel lbl_ProjectSettings;
        private System.Windows.Forms.TableLayoutPanel tlp_Output;
        private MetroSet_UI.Controls.MetroSetLabel lbl_Output;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetTextBox metroSetTextBox1;
        private MetroSet_UI.Controls.MetroSetLabel lbl_GameSettings;
        private MetroSet_UI.Controls.MetroSetTextBox txt_Output;
        private System.Windows.Forms.TableLayoutPanel tlp_Buttons;
        private MetroSet_UI.Controls.MetroSetButton btn_Cancel;
        private MetroSet_UI.Controls.MetroSetButton btn_Save;
        private MetroSet_UI.Controls.MetroSetButton btn_Archive;
        private MetroSet_UI.Controls.MetroSetButton btn_Extracted;
        private MetroSet_UI.Controls.MetroSetButton btn_Output;
        private MetroSet_UI.Controls.MetroSetComboBox comboBox_Platform;
        private MetroSet_UI.Controls.MetroSetLabel lbl_Platform;
        private MetroSet_UI.Controls.MetroSetComboBox comboBox_Region;
        private MetroSet_UI.Controls.MetroSetLabel lbl_Region;
    }
}