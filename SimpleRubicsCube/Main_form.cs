using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleRubicsCube
{
    public partial class Main_form : Form
    {
        public Main_form()
        {
            InitializeComponent();
            Render.init(ref openGLcanvas);
        }

        private void renderTimer_Tick(object sender, EventArgs e)
        {
            Render.drawAll();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
