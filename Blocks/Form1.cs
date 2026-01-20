using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blocks
{
    public partial class Form1 : Form
    {
        Timer drawer = new Timer();
        Timer gameTime = new Timer();

        int x = 3, y = 3;
        int right = 0, left = 0;
        int count = 25;

        public Form1()
        {
            InitializeComponent();
            InitTimers();
            this.IsInputKey(Keys.Left);
            this.IsInputKey(Keys.Right);
        }

        private void InitTimers()
        {
            drawer.Interval = 1;
            gameTime.Interval = 1;
            drawer.Tick += draw;
            gameTime.Tick += gaming;
        }

        private void gaming(object sender, EventArgs e)
        {
            if(bar.Left + left + right >= 0 && bar.Left + bar.Width + left + right <= ClientRectangle.Width)
            {
                bar.Location = new Point(bar.Left + left + right, bar.Top);
            }

            foreach (PictureBox pic in this.Controls.OfType<PictureBox>())
            {
                if(pic.Bounds.IntersectsWith(ball.Bounds) && pic.Tag == "obs")
                {
                    y *= -1;
                    this.Controls.Remove(pic);
                    count--;
                }
            }

            if(count == 0)
            {
                gameTime.Stop();
                MessageBox.Show("You win!");
                Environment.Exit(0);
            }

            if(ball.Left + ball.Width > ClientRectangle.Width || ball.Left < 0)
            {
                x *= -1;
            }

            if(ball.Top < 0)
            {
                y *= -1;
            }

            if(bar.Bounds.IntersectsWith(ball.Bounds))
            {
                y =  -3;
            }

            ball.Location = new Point (ball.Left + x, ball.Top + y);

            if(ball.Top > ClientRectangle.Height)
            {
                gameTime.Stop();
                MessageBox.Show("Game Over!");
            }
        }

        private void draw(object sender, EventArgs e)
        {
            drawer.Stop();
            Graphics g;
            g = ball.CreateGraphics();
            Rectangle rect = new Rectangle(0, 0, 20, 20);
            g.DrawEllipse(new Pen(Color.Orange), rect);
            g.FillEllipse(new SolidBrush(Color.Orange), rect);

            gameTime.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Right)
            {
                right = 5;
            }
            if(e.KeyCode == Keys.Left)
            {
                left = -5;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = 0;
            }
            if (e.KeyCode == Keys.Left)
            {
                left = 0;
            }
        }

        private void ball_VisibleChanged(object sender, EventArgs e)
        {
            if(ball.Visible)
            {
                drawer.Start();
            }
        }
    }
}
