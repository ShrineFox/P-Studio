using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_Studio
{
    static class Program
    {
        public static List<string> processList = new List<string>()
            {
                ".\\Dependencies\\Amicitia\\Amicitia.exe",
                ".\\Dependencies\\GFDStudio\\GFDStudio.exe",
                ".\\Dependencies\\notepad++\\notepad++.exe"
            };
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Treeview.SetupImageList();
            Application.Run(new PStudio());
        }
    }
}
