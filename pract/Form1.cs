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
        private Bot[,] map;
        private int rows;
        private int cols;
        private int resol;

        public Form()
        {
            InitializeComponent();
        }

        private void Form_Activated(object sender, EventArgs e)
        {
            resol = 10;
            rows = pictureBox.Height / resol;
            cols = pictureBox.Width / resol;
            map = new Bot[cols, rows];

            for (int i = 0; i < cols; i++)
                for (int j = 0; j < rows; j++)
                    map[i, j] = new Bot();

            map[cols / 2, rows / 2].setStatus(2);
            print();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //graphics.Clear(Color.Black);
            ////print();
            //pictureBox.Refresh();
            for (int i = 0; i < cols; i++)
                for (int j = 0; j < rows; j++)
                {
                    var newMap = new int[cols, rows];
                    switch (map[i, j])
                    {

                    }
                }
        }

        private int neighbors(int x, int y)
        {

            return 0;
        }

        private void print()
        {
            pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);
            graphics = Graphics.FromImage(pictureBox.Image);
            Brush brushes = null;

            for (int i = 0; i < cols; i ++)
                for (int j = 0; j < rows; j ++)
                {
                    switch (map[i, j].getStatus())
                    {
                        case 0:
                            brushes = Brushes.Black;
                            break;
                        case 1:
                            brushes = Brushes.White;
                            break;
                        case 2:
                            brushes = Brushes.Red;
                            break;
                        default: break;
                    }
                    graphics.FillRectangle(brushes, i * resol, j * resol, resol, resol);
                }
        }

        //Кнопка старт
        private void bStart_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
                return;
            timer.Start();
        }

        //Кнопка стоп
        private void bStop_Click(object sender, EventArgs e)
        {
            if (!timer.Enabled)
                return;
            timer.Stop();
        }
    }
}
