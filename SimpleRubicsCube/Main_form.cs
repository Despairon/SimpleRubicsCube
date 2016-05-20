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
            RubiksCube.buildCube();
            RubiksCube.form = this;
        }

        private void renderTimer_Tick(object sender, EventArgs e)
        {
            Render.drawAll();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bRotateCubeUp_Click(object sender, EventArgs e)
        {
            Enabled = false;
            RubiksCube.rotateCubeUp();
        }

        private void bRotateCubeDown_Click(object sender, EventArgs e)
        {
            Enabled = false;
            RubiksCube.rotateCubeDown();
        }

        private void bRotateCubeLeft_Click(object sender, EventArgs e)
        {
            Enabled = false;
            RubiksCube.rotateCubeLeft();
        }

        private void bRotateCubeRight_Click(object sender, EventArgs e)
        {
            Enabled = false;
            RubiksCube.rotateCubeRight();
        }
    }

    public class DoublePtr
    {
        public DoublePtr(double value)
        {
            this.value = value;
        }
        private double value;

        public static double operator+(DoublePtr left, DoublePtr right)
        {
            return left.value + right.value;
        }

        public static double operator-(DoublePtr left, DoublePtr right)
        {
            return left.value - right.value;
        }
    }
}
