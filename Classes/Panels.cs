using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_Studio
{
    public partial class PStudio : MetroSet_UI.Forms.MetroSetForm
    {
        public class MountPanel
        {
            public Panel Panel { get; set; } = null;
            public IntPtr Process { get; set; } = IntPtr.Zero;
        }

        // Keep track of handles for opened processes for workspace tabs
        public static List<MountPanel> MountPanels = new List<MountPanel>();

        // Resize windows within panel to fit
        private void MainForm_Resize(object sender, EventArgs e)
        {
            foreach (MountPanel mountPanel in MountPanels)
            {
                if (mountPanel.Panel != null)
                    MoveWindow(mountPanel.Process, 0, 0, mountPanel.Panel.Width, mountPanel.Panel.Height, true);
            }
        }

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);
    }

    /* Toggle TableLayoutPanel rows/columns that are set to autosize */
    public static class TableLayoutPanelExtensions
    {
        public static void HideRows(this TableLayoutPanel panel, params int[] rowNumbers)
        {
            foreach (Control c in panel.Controls)
                if (rowNumbers.Contains(panel.GetRow(c)))
                    c.Visible = false;
        }
        public static void ShowRows(this TableLayoutPanel panel, params int[] rowNumbers)
        {
            foreach (Control c in panel.Controls)
                if (rowNumbers.Contains(panel.GetRow(c)))
                    c.Visible = true;
        }
        public static void HideColumns(this TableLayoutPanel panel, params int[] colNumbers)
        {
            foreach (Control c in panel.Controls)
                if (colNumbers.Contains(panel.GetColumn(c)))
                    c.Visible = false;
        }
        public static void ShowColumns(this TableLayoutPanel panel, params int[] colNumbers)
        {
            foreach (Control c in panel.Controls)
                if (colNumbers.Contains(panel.GetColumn(c)))
                    c.Visible = true;
        }
    }
}
