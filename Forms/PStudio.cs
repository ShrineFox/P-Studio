using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;
using ShrineFox.IO;
using System.Collections.Generic;

namespace P_Studio
{
    public partial class PStudio : MetroSet_UI.Forms.MetroSetForm
    {
        public static PSettings settings;

        public PStudio()
        {
            InitializeComponent();
            SetupLogging();
            SetDefaultTab();
            SetMenuStripRenderer();
            SetTreeViewIcons();
            SetMenuStripIcons();
        }

        private void SetupLogging()
        {
            Output.LogPath = "log.txt";
            Output.LogControl = richTextBox_Status;
            #if DEBUG
                Output.VerboseLogging = true;
            #endif
        }

        private void SetDefaultTab()
        {
            // Select Game tab by default
            metroSetTabControl_Workspace.SelectedIndex = 0;
        }
    }
}
