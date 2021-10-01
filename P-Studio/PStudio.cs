using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_Studio
{
    public partial class PStudio : MetroSet_UI.Forms.MetroSetForm
    {
        public PStudio()
        {
            InitializeComponent();
            ToolStripManager.Renderer = r;
            menuStrip_Main.Renderer = r;
        }

        ToolStripProfessionalRenderer r =
            new ToolStripProfessionalRenderer(new MyColorTable(Color.FromArgb(255, 20, 20, 20)));

        public class MyColorTable : ProfessionalColorTable
        {
            private Color menuItemSelectedColor;
            public MyColorTable(Color color) : base()
            {
                menuItemSelectedColor = color;
            }
            public override Color MenuItemSelected
            {
                get { return menuItemSelectedColor; }
            }
        }
    }
}
