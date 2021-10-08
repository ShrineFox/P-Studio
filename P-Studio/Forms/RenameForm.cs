using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace P_Studio
{
    public partial class RenameForm : MetroSet_UI.Forms.MetroSetForm
    {
        private static string OriginalName;
        public string RenameText
        {
            get;
            private set;
        }

        public RenameForm(string text)
        {
            InitializeComponent();
            OriginalName = text;
            this.metroSetTextBox_NewName.Text = text + "_Copy";
        }

        private void Save_Click(object sender, EventArgs e)
        {
            // Make sure name is valid and can be created
            if (metroSetTextBox_NewName.Text != "" && Regex.IsMatch(metroSetTextBox_NewName.Text, "^[a-zA-Z0-9-_ .]*$"))
            {
                if (!File.Exists(metroSetTextBox_NewName.Text) && !Directory.Exists(metroSetTextBox_NewName.Text))
                {
                    RenameText = metroSetTextBox_NewName.Text;
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show(this, "Entered name is already in use\n" +
                    "by another file or directory!",
                    "Warning: Name in Use",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show(this, "New Name can't be empty,\n" +
                    "and must only include alphanumeric characters!",
                    "Warning: Invalid Name",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
