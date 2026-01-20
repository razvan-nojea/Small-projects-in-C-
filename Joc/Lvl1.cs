using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joc
{
    public partial class Lvl1 : Form
    {
        int sus = 0;
        int jos = 0;
        int stanga = 0;
        int dreapta = 0;

        int marioLastX = -1;
        int marioLastY = -1;

        int moveSpeed = 3;

        string lastKey;

        public Lvl1()
        {
            InitializeComponent();

            timer.Start();
        }

        private void Lvl1_KeyDown(object sender, KeyEventArgs e)
        {
            lastKey = e.KeyCode.ToString();

            if(e.KeyCode == Keys.W)
            {
                sus = moveSpeed;
            }

            if(e.KeyCode == Keys.D)
            {
                dreapta = moveSpeed;

                Mario.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"resources\sprites\Mario_right.png");
            }

            if (e.KeyCode == Keys.S)
            {
                jos = moveSpeed;
            }

            if (e.KeyCode == Keys.A)
            {
                stanga = moveSpeed;

                Mario.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"resources\sprites\Mario_left.png");
            }
        }

        private void Sus_Tick(object sender, EventArgs e)
        {
            bool movement = true;

            foreach(PictureBox pic in this.Controls)
            {
                if(cloneMario.Bounds.IntersectsWith(pic.Bounds) && pic.Tag == "border")
                {
                    movement = false;
                    break;
                }

                if(cloneMario.Bounds.IntersectsWith(pic.Bounds) && pic.Tag == "finish")
                {
                    timer.Stop();

                    MessageBox.Show("Ai castigat");

                    Start st = new Start();

                    Hide();
                    st.Show();

                    break;
                }
            }

            if (movement)
            {
                marioLastX = cloneMario.Location.X;
                marioLastY = cloneMario.Location.Y;

                cloneMario.Location = new Point(cloneMario.Location.X + dreapta - stanga, cloneMario.Location.Y + jos - sus);
                Mario.Location = cloneMario.Location;

            }
            else
            {
                cloneMario.Location = new Point(marioLastX, marioLastY);
            }
        }

        private void Lvl1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                sus = 0;
            }

            if (e.KeyCode == Keys.D)
            {
                dreapta = 0;
            }

            if (e.KeyCode == Keys.S)
            {
                jos = 0;
            }

            if (e.KeyCode == Keys.A)
            {
                stanga = 0;
            }
        }
    }
}
