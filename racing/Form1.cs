using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace racing
{
    public partial class Form1 : Form
    {
        Timer drawer = new Timer();
        Timer road = new Timer();
        Timer cars = new Timer();
        Timer move = new Timer();

        int spawnLines = 2;
        int spawnCars = 29;
        int speed = 1;
        int score = 0;
        int x = 241;

        int pass_score = 500;

        int road_speed = 30;
        int car_speed = 15;
        int limitcars = 20;

        int stanga = 0, dreapta = 0;

        bool movement = false;

        Random rand = new Random();


        public Form1()
        {
            InitializeComponent();

            InitRoad();
            InitCars();
            InitMove();
            InitDrawer();

        }

        private void InitMove()
        {
            move.Interval = 1;
            move.Tick += moving;
        }

        private void moving(object sender, EventArgs e)
        {
            x = caruta.Location.X + dreapta - stanga;

            if(x > 0 && x<panel1.Width - caruta.Width)
                caruta.Location = new Point(x, caruta.Location.Y);
            
            foreach(PictureBox pic in panel1.Controls.OfType<PictureBox>())
            {
                if(pic.Tag == "car" && caruta.Bounds.IntersectsWith(pic.Bounds))
                {
                    move.Stop();
                    road.Stop();
                    cars.Stop();


                    System.Media.SoundPlayer crash = new System.Media.SoundPlayer(AppDomain.CurrentDomain.BaseDirectory + @"resources\hit.wav");
                    crash.Play();

                    MessageBox.Show("Game Over!");
                }
            }
        }

        private void InitCars()
        {
            cars.Interval = 100;
            cars.Tick += caring;
        }

        private void caring(object sender, EventArgs e)
        {
            spawnCars++;

            if(spawnCars >= limitcars)
            {
                spawnCars = 0;
                AddCar();
            }

            foreach(PictureBox pic in panel1.Controls.OfType<PictureBox>())
            {
                if(pic.Tag == "car")
                {
                    pic.Location = new Point(pic.Location.X, pic.Location.Y + car_speed);

                    if (pic.Location.Y > 511)
                    {
                        panel1.Controls.Remove(pic);
                    }
                }
            }
        }

        private void AddCar()
        {
            int n = rand.Next(1, 3);
            int prev_lane = -1;
            for(int i=1;i<=n;i++)
            {
                int lane = rand.Next(1, 5);

                while(prev_lane == lane)
                {
                    lane = rand.Next(1, 5);
                }

                prev_lane = lane;

                int a = 0, b = 0;

                if (lane == 1)
                {
                    a = 15;
                    b = 70;
                }
                if (lane == 2)
                {
                    a = 110;
                    b = 155;
                }
                if (lane == 3)
                {
                    a = 207;
                    b = 245;
                }
                if (lane == 4)
                {
                    a = 310;
                    b = 360;
                }

                int pos = rand.Next(a, b + 1);
                int car = rand.Next(1, 10);

                PictureBox pic = new PictureBox();
                pic.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"resources\" + car + ".png");
                pic.SizeMode = PictureBoxSizeMode.AutoSize;
                pic.Tag = "car";

                int k = rand.Next(0, 60);

                pic.Location = new Point(pos, -60 - k);

                panel1.Controls.Add(pic);
                pic.BringToFront();
                caruta.BringToFront();
            }
        }

        private void InitRoad()
        {
            road.Interval = 100;
            road.Tick += roading;
        }

        private void roading(object sender, EventArgs e)
        {
            spawnLines++;

            score += 10;

            lblScore.Text = "Score: " + score;

            if(score >= pass_score && speed <= 4)
            {
                road.Interval = 100 - speed * 20;
                score += 50;
                car_speed += 10;
                limitcars -= 2;
                pass_score = pass_score * (speed + 1);
                speed++;
            }

            if(spawnLines >= 3)
            {
                spawnLines = 0;
                AddLine(-80);
            }

            foreach(PictureBox pic in panel1.Controls.OfType<PictureBox>())
            {
                if(pic.Tag == "line")
                {
                    pic.Location = new Point(pic.Location.X, pic.Location.Y + road_speed);

                   if(pic.Location.Y > 511)
                   {
                      panel1.Controls.Remove(pic);
                   }
                }
            }
        }

        private void InitDrawer()
        {
            drawer.Interval = 10;
            drawer.Tick += draw;
            drawer.Start();
        }

        private void draw(object sender, EventArgs e)
        {
            if(panel1.Visible)
            {
                drawer.Stop();

                for(int i=10;i<=panel1.Height;i+=90)
                {
                    AddLine(i);
                }
            }
        }

        private void AddLine(int y)
        {
            PictureBox pic1 = new PictureBox();
            pic1.Size = new Size(5, 70);
            pic1.BackColor = Color.Transparent;
            pic1.Tag = "line";

            PictureBox pic2 = new PictureBox();
            pic2.Size = new Size(5, 70);
            pic2.BackColor = Color.White;
            pic2.Tag = "line";

            PictureBox pic4 = new PictureBox();
            pic4.Size = new Size(5, 70);
            pic4.BackColor = Color.White;
            pic4.Tag = "line";

            pic1.Location = new Point(0, 0);
            pic4.Location = new Point(305, y);
            pic2.Location = new Point(105, y);
            panel1.Controls.Add(pic1);
            panel1.Controls.Add(pic2);panel1.Controls.Add(pic4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            movement = true;
            road.Start();
            cars.Start();
            move.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(movement)
            {
                if(0 < x - 6 && e.KeyCode == Keys.A)
                {
                    stanga = 4;
                }
                if (350 > x + 6 && e.KeyCode == Keys.D)
                {
                    dreapta = 4;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(""+caruta.Left);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (movement)
            {
                if (e.KeyCode == Keys.A)
                {
                    stanga = 0;
                }
                if (e.KeyCode == Keys.D)
                {
                    dreapta = 0;
                }
            }
        }
    }
}
