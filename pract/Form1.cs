using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pract
{
    public partial class Form : System.Windows.Forms.Form
    {
        private Graphics graphics = null;
        private int[,] map = null;

        Bitmap BitMap;

        public Form()
        {
            InitializeComponent();
            BitMap = new Bitmap(pictureBox.Width, pictureBox.Height);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (timer.Enabled)
                return;


        }

        private void bStart_Click(object sender, EventArgs e)
        {

        }

        private void Form_Activated(object sender, EventArgs e)
        {
            for (int i = 0; i < pictureBox.Width; i += 20)
            {
                for (int j = 0; j < pictureBox.Height; j += 20)
                {
                    pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);
                    graphics = Graphics.FromImage(pictureBox.Image);
                    graphics.FillRectangle(Brushes.Crimson, 0, 0, i, j);
                }
            }
        }
    }
}
