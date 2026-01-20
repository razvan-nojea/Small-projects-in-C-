using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zombie
{
    public partial class Form1 : Form
    {
        Timer gameTime = new Timer();
        Timer spawner = new Timer();
        Timer spawnerZombie = new Timer();

        int up = 0, down = 0, left = 0, right = 0;

        int ammo = 5;

        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();

            InitTimer();
        }

        private void InitTimer()
        {
            gameTime.Interval = 1;
            spawner.Interval = 7000;
            spawnerZombie.Interval = 2000;
            gameTime.Tick += gaming;
            spawner.Tick += spawn;
            spawnerZombie.Tick += spawnZ;
            gameTime.Start();
            spawner.Start();
            spawnerZombie.Start();
        }

        private void spawnZ(object sender, EventArgs e)
        {
            PictureBox zombie = new PictureBox();
            zombie.SizeMode = PictureBoxSizeMode.AutoSize;

            int x = rand.Next(0, ClientRectangle.Width - zombie.Width);
            int y = rand.Next(30, ClientRectangle.Height - zombie.Height);

            zombie.Tag = "zombie";
            zombie.Location = new Point(x, y);
            if(y < player.Top)
                zombie.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"resources\zdown.png");
            if(y >= player.Top)
                zombie.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"resources\zup.png");

            this.Controls.Add(zombie);
            zombie.BringToFront();
        }

        private void spawn(object sender, EventArgs e)
        {
            PictureBox ammoBox = new PictureBox();
            ammoBox.SizeMode = PictureBoxSizeMode.AutoSize;
            ammoBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"resources\ammo-Image.png");


            int x = rand.Next(0, ClientRectangle.Width - ammoBox.Width);
            int y = rand.Next(30, ClientRectangle.Height - ammoBox.Height);

            ammoBox.Tag = "ammoBox";
            ammoBox.Location = new Point(x, y);

            this.Controls.Add(ammoBox);
        }

        private void gaming(object sender, EventArgs e)
        {
            foreach(PictureBox bullet in this.Controls.OfType<PictureBox>())
            {
                if (bullet.Tag == "bup" || bullet.Tag == "bdown" || bullet.Tag == "bleft" || bullet.Tag == "bright")
                {
                    if (bullet.Tag == "bup")
                    {
                        bullet.Top -= 3;
                        bullet.Invalidate();
                    }
                    if (bullet.Tag == "bdown")
                    {
                        bullet.Top += 3;
                        bullet.Invalidate();
                    }
                    if (bullet.Tag == "bleft")
                    {
                        bullet.Left -= 3;
                        bullet.Invalidate();
                    }
                    if (bullet.Tag == "bright")
                    {
                        bullet.Left += 3;
                        bullet.Invalidate();
                    }

                    if (bullet.Top < 30 || bullet.Top > ClientRectangle.Height || bullet.Right < 0 || bullet.Left > ClientRectangle.Width)
                    {
                        this.Controls.Remove(bullet);
                    }
                }

                if(bullet.Tag == "ammoBox" && bullet.Bounds.IntersectsWith(player.Bounds))
                {
                    ammo += 5;
                    lblAmmo.Text = "Ammo: " + ammo;
                    this.Controls.Remove(bullet);
                }
            }

            foreach(PictureBox bullet in this.Controls.OfType<PictureBox>())
            {
                if (bullet.Tag == "bup" || bullet.Tag == "bdown" || bullet.Tag == "bleft" || bullet.Tag == "bright")
                {
                    foreach(PictureBox zombie in this.Controls.OfType<PictureBox>())
                    {
                        if(zombie.Tag == "zombie" && bullet.Bounds.IntersectsWith(zombie.Bounds))
                        {
                            this.Controls.Remove(zombie);
                            this.Controls.Remove(bullet);
                        }
                    }
                }
            }

            foreach(PictureBox zombie in this.Controls.OfType<PictureBox>())
            {
                if(zombie.Tag=="zombie")
                {
                    moveToPlayer(zombie);
                }

                if(zombie.Tag == "zombie" && zombie.Bounds.IntersectsWith(player.Bounds))
                {
                    if(health.Value == 0)
                    {
                        spawner.Stop();
                        spawnerZombie.Stop();
                        gameTime.Stop();
                        player.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"resources\dead.png");
                        MessageBox.Show("Game Over!");
                        Environment.Exit(0);
                    }
                    else
                    {
                        health.Value--;
                    }
                }
            }

            if(player.Top + up + down + player.Height <= ClientRectangle.Height && player.Top + up + down >= 30 && 
                player.Left + right + left + player.Width <= ClientRectangle.Width && player.Left + right + left >= 0)
            {
                player.Location = new Point(player.Left + right + left, player.Top + up + down);
            }
        }

        private void moveToPlayer(PictureBox zombie)
        {
            if(Math.Abs(player.Top - zombie.Top) > Math.Abs(player.Left - zombie.Left))
            {
                if(zombie.Top < player.Top)
                {
                    zombie.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"resources\zdown.png");
                }
                if(zombie.Bottom > player.Bottom)
                {
                    zombie.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"resources\zup.png");

                }
            }
            else
            {
                if(zombie.Left < player.Left)
                {
                    zombie.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"resources\zright.png");
                }
                if(zombie.Right > player.Right)
                {
                    zombie.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"resources\zleft.png");
                }
            }

            if(zombie.Bottom < player.Top + player.Height / 2)
            {
                zombie.Top++;
            }

            if(zombie.Top > player.Bottom - player.Height / 2)
            {
                zombie.Top--;
            }

            if(zombie.Right < player.Left + player.Width / 2)
            {
                zombie.Left++;
            }

            if(zombie.Left > player.Right - player.Width / 2)
            {
                zombie.Left--;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.W)
            {
                up = -3;
                player.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"resources\up.png");
                player.Tag = "up";
            }
            if (e.KeyCode == Keys.S)
            {
                down = 3;
                player.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"resources\down.png");
                player.Tag = "down";
            }
            if (e.KeyCode == Keys.A)
            {
                left = -3;
                player.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"resources\left.png");
                player.Tag = "left";
            }
            if (e.KeyCode == Keys.D)
            {
                right = 3;
                player.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"resources\right.png");
                player.Tag = "right";
            }
            if (ammo > 0 && e.KeyCode == Keys.Space)
            {
                ammo--;
                lblAmmo.Text = "Ammo: " + ammo;
                Shoot();
            }
        }

        private void Shoot()
        {
            PictureBox bullet = new PictureBox();
            bullet.Size = new Size(5, 5);

            int x = 0, y = 0;

            if(player.Tag == "up")
            {
                x = (player.Left + player.Right) / 2;
                y = player.Top;
                bullet.Tag = "bup";
            }
            if (player.Tag == "down")
            {
                x = (player.Left + player.Right) / 2;
                y = player.Top + player.Height + 20;
                bullet.Tag = "bdown";
            }
            if (player.Tag == "left")
            {
                x = player.Left;
                y = (player.Top + player.Bottom) / 2;
                bullet.Tag = "bleft";
            }
            if (player.Tag == "right")
            {
                x = player.Left + player.Width;
                y = (player.Top + player.Bottom) / 2;
                bullet.Tag = "bright";
            }

            bullet.Location = new Point(x, y);
            bullet.BackColor = Color.Gold;

            this.Controls.Add(bullet);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                up = 0;
            }
            if (e.KeyCode == Keys.S)
            {
                down = 0;
            }
            if (e.KeyCode == Keys.A)
            {
                left = 0;
            }
            if (e.KeyCode == Keys.D)
            {
                right = 0;
            }
        }
    }
}
