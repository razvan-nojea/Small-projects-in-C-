using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trex
{
    public partial class Form1 : Form
    {
        bool jumping = false, falling = false, gameover = true;

        int jump = 22, fall = 10, score = 0, obs_speed = 7;

        Timer game = new Timer();
        Timer spawner = new Timer();

        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();

            InitGame();
        }

        private void InitGame()
        {
            game.Interval = 1;
            spawner.Interval = 1500;
            spawner.Tick += spawning;
            game.Tick += ticking;
        }

        private void spawning(object sender, EventArgs e)
        {
            int n = rand.Next(1, 3);

            for(int i = 1; i <= n; i++)
            {
                int ind = rand.Next(1, 3);

                int q = 400 / n;

                int l = rand.Next(q * (i - 1), q * i);

                PictureBox obs = new PictureBox();
                obs.SizeMode = PictureBoxSizeMode.AutoSize;
                obs.Location = new Point(ClientRectangle.Width + l, 30);
                obs.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"resources\obstacle-" + ind + ".gif");

                int height = obs.Height, width = obs.Width;
                obs.SizeMode = PictureBoxSizeMode.StretchImage;
                obs.Size = new Size(width * 2 - width / 2, height * 2 - height / 2);

                obs.Top = pictureBox1.Top - obs.Height;
                obs.Tag = "obstacle";

                this.Controls.Add(obs);
            }
        }

        private void ticking(object sender, EventArgs e)
        {
            if(jumping && jump > 0)
            {
                trex.Top -= jump;
                jump--;
            }
            else
            {
                if(jump == 0)
                {
                    jumping = false;
                }

                falling = true;
            }

            if(trex.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                falling = false;
                trex.Top = pictureBox1.Top - trex.Height + 1;
            }

            foreach(PictureBox obs in this.Controls.OfType<PictureBox>())
            {
                if(obs.Tag == "obstacle")
                {
                    obs.Left -= obs_speed;

                    if(obs.Bounds.IntersectsWith(trex.Bounds))
                    {
                        obs.Tag = "passed";
                        game.Stop();
                        spawner.Stop();
                        falling = false;
                        jumping = false;
                        obs_speed = 7;
                        spawner.Interval = 2500;
                        trex.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"resources\dead.png");
                        MessageBox.Show("You dead.");

                        foreach (PictureBox picture in this.Controls.OfType<PictureBox>())
                        {
                            if (picture.Tag == "obstacle" || picture.Tag == "passed")
                            {
                                this.Controls.Remove(picture);
                            }
                        }

                        lblSpc.Visible = true;
                        gameover = true;
                        break;
                    }
                    else
                    {
                        if(obs.Right < trex.Left)
                        {
                            obs.Tag = "passed";
                            score++;
                            lblScore.Text = "Score: " + score;

                            obs_speed = 7 + (score / 15);
                            if(spawner.Interval > 2000)
                            {
                                spawner.Interval = 2500 - 100 * (score / 15);
                            }
                        }
                    }
                }

                if(obs.Tag == "passed")
                {
                    obs.Left -= obs_speed;

                    if(obs.Right < 0)
                        this.Controls.Remove(obs);
                }
            }

            if (falling)
            {
                trex.Top += fall;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space && !jumping && !falling)
            {
                if(gameover)
                {
                    foreach(PictureBox picture in this.Controls.OfType<PictureBox>())
                    {
                        if(picture.Tag == "obstacle" || picture.Tag == "passed")
                        {
                            this.Controls.Remove(picture);
                        }
                    }

                    trex.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"resources\running.gif");
                    score = 0;
                    lblScore.Text = "Score: 0";

                    trex.Top = pictureBox1.Top - trex.Height + 1;

                    game.Start();
                    spawner.Start();

                    pictureBox1.Visible = true;

                    gameover = false;
                    lblSpc.Visible = false;
                }
                
                jump = 22;
                jumping = true;

            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                jumping = false;
            }
        }
    }
}
