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
        private int step;

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
                {
                    map[i, j] = new Bot();
                    map[i, j].setStatus(1);
                }

            map[cols / 2, rows / 2].setStatus(2);
            print();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            Text = $"Step{++step}";

            var newMap = new Bot[cols, rows];
            for (int x = 0; x < cols; x++)
                for (int y = 0; y < rows; y++)
                    newMap[x, y] = new Bot();

            for (int x = 0; x < cols; x++)
                for (int y = 0; y < rows; y++)
                {
                    if (map[x, y].getStatus() == 2)
                    {
                       
                    }
                }

            map = newMap;
            print();
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
            step = 0;
            for (int i = 0; i < cols; i++)
                for (int j = 0; j < rows; j++)
                    map[i, j].setStatus(1);

            map[cols / 2, rows / 2].setStatus(2);
            print();
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
