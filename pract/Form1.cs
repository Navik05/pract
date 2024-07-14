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
        private int range;

        public Form()
        {
            InitializeComponent();
        }

        private void Form_Activated(object sender, EventArgs e)
        {
            gameStart();
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

            int i, j;

            for (int x = 0; x < cols; x++)
                for (int y = 0; y < rows; y++)
                {
                    switch (map[x, y].getStatus())
                    {
                        case 2:
                            do
                            {
                                i = random.Next(-range, range + 1);
                                j = random.Next(-range, range + 1);
                            } while (i == 0 && j == 0);
                            newMap[(x + i + cols) % cols, (y + j + rows) % rows].setStatus(2);
                            break;
                        case 3:

                            break;
                        default:
                            break;
                    }
                    if(newMap[x, y].getStatus()==0)
                        newMap[x, y] = map[x, y];
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
                        case 1:
                            brushes = Brushes.White;
                            break;
                        case 2:
                            brushes = Brushes.Pink;
                            break;
                        case 3:
                            brushes = Brushes.Red;
                            break;
                        case 4:
                            brushes = Brushes.LightGray;
                            break;
                        case 5:
                            brushes = Brushes.Black;
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

            gameStart();
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

        private void gameStart()
        {
            resol = (int)numericResol.Value;
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

            range = trackRange.Value;
        }
    }
}
