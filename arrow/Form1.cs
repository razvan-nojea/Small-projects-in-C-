using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arrow
{
    public partial class Form1 : Form
    {
        int up = 0, down = 0;

        Timer game = new Timer();
        Timer shooting = new Timer();
        Timer spawner = new Timer();

        bool shot = false;

        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            this.IsInputKey(Keys.Up);
            this.IsInputKey(Keys.Down);

            InitGame();
        }

        private void InitGame()
        {
            game.Interval = 1;
            shooting.Interval = 500;
            spawner.Interval = 1500;
            game.Tick += gaming;
            shooting.Tick += sut;
            spawner.Tick += spawn;
            game.Start();
            spawner.Start();
        }

        private void spawn(object sender, EventArgs e)
        {
            NewBalloon();
        }

        private void NewBalloon()
        {
            int speed = rand.Next(1, 3);

            int x = rand.Next(ClientRectangle.Width / 2 + ClientRectangle.Width / 8, ClientRectangle.Width - 60);

            int index = rand.Next(1, 4);

            PictureBox balloon = new PictureBox();

            balloon.Tag = "balloon;" + speed;
            balloon.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"resources\balloon_" + index + ".gif");
            balloon.SizeMode = PictureBoxSizeMode.AutoSize;
            balloon.Location = new Point(x, ClientRectangle.Height);

            this.Controls.Add(balloon);
            balloon.SendToBack();
        }

        private void sut(object sender, EventArgs e)
        {
            shot = false;
            player.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"resources\idle.png");
            shooting.Stop();
        }

        private void gaming(object sender, EventArgs e)
        {
            if(player.Top + up + down >= pictureBox2.Bottom && player.Bottom + up + down <= pictureBox1.Top)
            {
                player.Location = new Point(player.Left, player.Top + up + down);
            }

            foreach(PictureBox arrow in this.Controls.OfType<PictureBox>())
            {
                if(arrow.Tag == "arrow")
                {
                    arrow.Location = new Point(arrow.Left + 10, arrow.Top);

                    if (arrow.Left > ClientRectangle.Width)
                    {
                        this.Controls.Remove(arrow);
                    }

                    foreach(PictureBox balloon in this.Controls.OfType<PictureBox>())
                    {
                        if (balloon.Tag != null)
                        {
                            string c = balloon.Tag.ToString();

                            string[] words = c.Split(';');

                            if (words[0] == "balloon" && balloon.Bounds.IntersectsWith(arrow.Bounds))
                            {
                                Point A = balloon.Location;

                                PictureBox pop = new PictureBox();
                                pop.Location = A;
                                pop.SizeMode = PictureBoxSizeMode.AutoSize;
                                pop.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"resources\Explosion.png");
                                pop.Tag = "pop;1000";

                                this.Controls.Add(pop);

                                this.Controls.Remove(balloon);
                                this.Controls.Remove(arrow);
                            }
                        }
                    }
                }
            }

            foreach(PictureBox pop in this.Controls.OfType<PictureBox>())
            {
                if(pop.Tag != null)
                {
                    string c = pop.Tag.ToString();
                    string[] words = c.Split(';');

                    if (words[0] == "pop")
                    {
                        int count = Convert.ToInt32(words[1]);

                        count--;
                        pop.Tag = "pop;" + count;

                        if(count < 0)
                        {
                            this.Controls.Remove(pop);
                        }
                    }
                }
            }

            foreach (PictureBox balloon in this.Controls.OfType<PictureBox>())
            {
                if (balloon.Tag != null)
                {
                    string c = balloon.Tag.ToString();

                    string[] words = c.Split(';');

                    if (words[0] == "balloon")
                    {
                        int balloon_speed = Convert.ToInt32(words[1]);

                        balloon.Location = new Point(balloon.Left, balloon.Top - balloon_speed);

                        if (balloon.Bottom < pictureBox2.Bottom)
                        {
                            this.Controls.Remove(balloon);
                        }
                    }
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                up = -3;
            }
            if (e.KeyCode == Keys.Down)
            {
                down = 3;
            }
            if(e.KeyCode == Keys.Space && !shot)
            {
                player.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"resources\shoot.png");

                Shoot();
                shot = true;
                shooting.Start();
            }
        }

        private void Shoot()
        {
            PictureBox arrow = new PictureBox();
            arrow.SizeMode = PictureBoxSizeMode.AutoSize;
            arrow.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"resources\arrow.png");
            arrow.Location = new Point(player.Right, player.Top + 30);
            arrow.Tag = "arrow";

            this.Controls.Add(arrow);
            arrow.BringToFront();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                up = 0;
            }
            if (e.KeyCode == Keys.Down)
            {
                down = 0;
            }
        }
    }
}
