using Spanzuratoarea.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spanzuratoarea
{
    public partial class Joc : Form
    {
        private string cuvant;

        int mistakes = 0;
        int correct = 0;

        public Joc(string cuvantu)
        {
            InitializeComponent();

            cuvant = cuvantu;
        }

        private void DrawMistake()
        {
            if(mistakes == 1)
            {
                GR.Head(picHang);
            }

            if(mistakes == 2)
            {
                GR.Torso(picHang);
            }

            if(mistakes == 3)
            {
                GR.RightHand(picHang);
            }

            if(mistakes == 4)
            {
                GR.LeftHand(picHang);
            }

            if(mistakes == 5)
            {
                GR.RightLeg(picHang);
            }

            if(mistakes == 6)
            {
                GR.LeftLeg(picHang);

                MessageBox.Show("You lost!");

                Start st = new Start();

                Hide();
                st.Show();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Start st = new Start();

            Hide();
            st.Show();
        }

        private void picCuv_VisibleChanged(object sender, EventArgs e)
        {
            if (picCuv.Visible)
            {
                GR.Underline(picCuv, cuvant.Length);
            }
        }

        private void Joc_Paint(object sender, PaintEventArgs e)
        {
            GR.Underline(picCuv, cuvant.Length);
        }

        private bool WordOk(string str, string c)
        {
            bool ok = false;

            for(int i = 0; i< str.Length; i++)
            {
                if (str[i] == c[0])
                {
                    correct++;

                    GR.Letter(picCuv, i, c);

                    ok = true;
                }
            }

            return ok;
        }

        private void btnClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (!WordOk(cuvant, btn.Text.ToString()))
            {
                mistakes++;
                DrawMistake();
            }

            btn.Visible = false;

            if(correct == cuvant.Length)
            {
                MessageBox.Show("Ai castigat!");

                Start st = new Start();

                Hide();
                st.Show();
            }
        }
    }
}
