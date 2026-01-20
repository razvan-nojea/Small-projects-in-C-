using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Clicker_game
{
    public partial class Joc : Form
    {
        int time = 0;
        int interval = 10;

        int score = 0;
        int highscore;

        int lastSpawned = 0;

        int greenSquares = 0;

        public Joc()
        {
            InitializeComponent();

            timer1.Start();

            highscore = DB.getHighscore();

            lblHighScore.Text = "" + highscore;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Start st = new Start();

            Hide();
            st.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if(greenSquares == 10)
            {
                timer1.Stop();

                btnReset.Visible = false;

                greenSquares = 0;

                for (int i = this.Controls.Count - 1; i >= 0; i--)
                {
                    if (this.Controls[i] is PictureBox) this.Controls[i].Dispose();
                }

                MessageBox.Show("Game Over! \n Your score was " + score + ".");

                highscore = DB.getHighscore();

                if(score>highscore)
                {
                    MessageBox.Show("This is a new high score!");

                    highscore = score;

                    DB.updateHighscore(score);

                    lblHighScore.Text = "" + highscore;
                }

                btnAgain.Visible = true;

                score = 0;

                lblScore.Text = "0";
            }

            time += (score / 5) * 2 + 1;

            Random rand = new Random();

            int x;
            int y;

            if(time/10 > lastSpawned/10)
            {
                lastSpawned = time;

                PictureBox pic = new PictureBox();

                do
                {

                    x = rand.Next(0, this.ClientSize.Width - 70);
                    y = rand.Next(0, this.ClientSize.Height - 70);

                } while (x <= 280 && y <= 170);

                pic.Location = new Point(x, y);

                int color = rand.Next(1, 100);

                if(color >50)
                {
                    pic.BackColor = Color.Green;

                    greenSquares++;
                }
                else
                {
                    pic.BackColor = Color.Red;
                }

                pic.Size = new Size(50, 50);

                pic.Click += new EventHandler(pic_Click);

                this.Controls.Add(pic);
            }
        }

        private void pic_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;

            if (pic.BackColor == Color.Green)
            {
                score++;

                greenSquares--;
            }
            else
            {
                score--;
            }

            lblScore.Text = "" + score;

            this.Controls.Remove(pic);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            for (int i = this.Controls.Count - 1; i >= 0; i--)
            {
                if (this.Controls[i] is PictureBox) this.Controls[i].Dispose();
            }

            lblScore.Text = "0";

            score = 0;
        }

        private void btnAgain_Click(object sender, EventArgs e)
        {
            btnAgain.Visible = false;

            btnReset.Visible = true;

            timer1.Start();
        }
    }
}
