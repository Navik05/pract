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
        private int rows;
        private int cols;
        private int resol;

        public Form()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (!timer.Enabled)
                return;

            print();
            //graphics.Clear(Color.White);
        }

        private void print()
        {
            pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);
            graphics = Graphics.FromImage(pictureBox.Image);
            Brush brushes = null;

            for (int i = 0; i < cols; i ++)
                for (int j = 0; j < rows; j ++)
                {
                    switch (map[i, j])
                    {
                        case 1:
                            brushes = Brushes.Gray;
                            break;

                        default: break;
                    }
                    graphics.FillRectangle(brushes, i * resol, j * resol, resol, resol);
                }
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            timer.Start();

        }

        private void Form_Activated(object sender, EventArgs e)
        {
            resol = 20;
            rows = pictureBox.Height / resol;
            cols = pictureBox.Width / resol;
            map = new int[cols, rows];

            for (int i = 0; i < cols; i++)
                for (int j = 0; j < rows; j++)
                    map[i, j] = 1;

            //print();
        }
    }
}
