using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
        private int incubation;
        private int chance;
        private int contact;
        private int symptoms;
        private int deadliness;
        private bool play = false;

        public Form()
        {
            InitializeComponent();
        }

        private void Form_Activated(object sender, EventArgs e)
        {
            bPause.Enabled = false;
            gameStart();
            print();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            Text = $"Day{++step}";

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
                            newMap[x, y] = map[x, y];
                            for (int z = 0; z < contact; z++)
                            {
                                do
                                {
                                    i = random.Next(-range, range + 1);
                                    j = random.Next(-range, range + 1);
                                } while (i == 0 && j == 0);

                                if (map[(x + i + cols) % cols, (y + j + rows) % rows].getStatus() <= 1)
                                    if (random.Next(0, 10) < chance)
                                        newMap[(x + i + cols) % cols, (y + j + rows) % rows].setStatus(2);
                            }

                            newMap[x, y].setDay();
                            if (newMap[x, y].getDay() >= incubation)
                                newMap[x, y].setStatus(3);
                            break;
                        case 3:
                            newMap[x, y] = map[x, y];
                            newMap[x, y].setDay();
                            if (newMap[x, y].getDay()>= symptoms)
                            {
                                if (random.Next(0, 10) < deadliness)
                                    newMap[x, y].setStatus(5);
                                else
                                    newMap[x, y].setStatus(4);
                            }
                            break;
                        default:
                            break;
                    }

                }

            for (int x = 0; x < cols; x++)
                for (int y = 0; y < rows; y++)
                    if (newMap[x, y].getStatus() == 0)
                        newMap[x, y] = map[x, y];

            map = newMap;
            print();

            int[] statistics = new int[] { 0, 0, 0, 0, 0, 0, 0 };

            for (int x = 0; x < cols; x++)
                for (int y = 0; y < rows; y++)
                    statistics[map[x, y].getStatus()]++;


            chart.Series["Series"].Points.Clear();
            chart.Series["Series"].Points.AddXY("не болели", statistics[1]);
            chart.Series["Series"].Points[0].Color = Color.White;
            chart.Series["Series"].Points.AddXY("носители", statistics[2]);
            chart.Series["Series"].Points[1].Color = Color.Pink;
            chart.Series["Series"].Points.AddXY("заражены", statistics[3]);
            chart.Series["Series"].Points[2].Color = Color.Red;
            chart.Series["Series"].Points.AddXY("выздоровели", statistics[4]);
            chart.Series["Series"].Points[3].Color = Color.LightGray;
            chart.Series["Series"].Points.AddXY("умерли", statistics[5]);
            chart.Series["Series"].Points[4].Color = Color.Black;
            chart.Series["Series"].Points.AddXY("иммунитет", statistics[6]);
            chart.Series["Series"].Points[5].Color = Color.Blue;

            if (statistics[2] == 0 && statistics[3] == 0)
                timer.Stop();
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
                        case 6:
                            brushes = Brushes.Blue;
                            break;
                        default: break;
                    }
                    graphics.FillRectangle(brushes, i * resol, j * resol, resol, resol);
                }
        }

        //Кнопка старт
        private void bStart_Click(object sender, EventArgs e)
        {
            bPause.Enabled = true;
            bPause.Text = "Pause";
            gameStart();
            print();
            timer.Start();

        }
        //Кнопка пауза
        private void bPause_Click(object sender, EventArgs e)
        {
            if (!timer.Enabled)
            {
                bPause.Text = "Pause";
                timer.Start();
            }
            else
            {
                bPause.Text = "Play";
                timer.Stop();
            }
        }
        private void gameStart()
        {
            contact = (int)numericContact.Value;
            timer.Interval = (int)numericTime.Value;
            chance = trackChance.Value;
            range = trackRange.Value;
            incubation = trackIncubation.Value;
            symptoms = trackSymptoms.Value + incubation;
            deadliness = trackDeadliness.Value;

            step = 0;
            resol = (int)numericResol.Value;
            rows = pictureBox.Height / resol;
            cols = pictureBox.Width / resol;
            map = new Bot[cols, rows];
            Random random = new Random();

            for (int i = 0; i < cols; i++)
                for (int j = 0; j < rows; j++)
                {
                    map[i, j] = new Bot();
                    map[i, j].setStatus(1);
                    if (checkImmunity.Checked)
                        if(random.Next(0, 100)== 0)
                            map[i, j].setStatus(6);
                }
            map[cols / 2, rows / 2].setStatus(2);
        }
    }
}
