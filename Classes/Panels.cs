using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_Studio
{
    public partial class PStudio : MetroSet_UI.Forms.MetroSetForm
    {
        public class MountPanel
        {
            static IntPtr Panel { get; set; } = IntPtr.Zero;
            static IntPtr Process { get; set; } = IntPtr.Zero;
        }

        // Keep track of handles for opened processes for workspace tabs
        public static List<MountPanel> MountPanels = new List<MountPanel>();

        // Resize windows within panel
        private void MainForm_Resize(object sender, EventArgs e)
        {
            int formWidth = panel_Asset.Width;
            int formHeight = panel_Asset.Height;
            /*if (assetEditor != null)
                Tools.MoveWindow(assetEditor, 0, 0, formWidth, formHeight, true);
            if (scriptEditor != null)
                Tools.MoveWindow(scriptEditor, 0, 0, formWidth, formHeight, true);*/
        }
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
