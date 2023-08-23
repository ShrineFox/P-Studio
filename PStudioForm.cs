using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarkUI.Forms;
using MetroSet_UI.Controls;
using ShrineFox.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PStudio
{
    public partial class PStudioForm : DarkForm
    {
        public PStudioForm()
        {
            InitializeComponent();
            WinForms.SetDefaultIcon();
            MenuStripHelper.SetMenuStripIcons(MenuStripHelper.GetMenuStripIconPairs("Icons.txt"), this);
            SetupLogging();

            SetupTreeviews();
        }

        private void SetupLogging()
        {
            Output.Logging = true;
#if DEBUG
            Output.VerboseLogging = true;
#endif
            Output.LogToFile = true;
            Output.LogControl = rtb_Log;
        }

        private void LoadProject_Click(object sender, EventArgs e)
        {
            LoadProject();
        }

        private void SaveProject_Click(object sender, EventArgs e)
        {
            SaveProject();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            ProjectSettings();
        }
    }
}
