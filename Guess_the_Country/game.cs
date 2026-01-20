using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guess_the_Country
{
    public partial class game : Form
    {
        private Dictionary<int, string> pozeToate = new Dictionary<int, string>();
        private Dictionary<int,string> poze5 = new Dictionary<int,string>();
        private Dictionary<string,string> tari = new Dictionary<string,string>();
        private Dictionary<string,string> capitale = new Dictionary<string,string>();

        private int points;
        private int intrb;
        private int p = 2;

        public game(Dictionary<int, string> pozeToate, Dictionary<int, string> poze5, Dictionary<string, string> tari, Dictionary<string, string> capitale, int intrb, int points)
        {
            InitializeComponent();

            picBoxCorrect.BackColor = Color.Transparent;

            this.pozeToate = pozeToate;
            this.poze5 = poze5;
            this.tari = tari;
            this.capitale = capitale;

            this.points = points;
            this.intrb = intrb;

            lblTara.Text = "Tara " + intrb + " / 5";
            lblPoints.Text += points;

            init();
            
        }

        private void init()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"\images\" + poze5[intrb];

            picBoxTara.Image = Image.FromFile(path);

            for(int i = 1; i <= 13; i++)
            {
                cmbBoxTara.Items.Add(tari[pozeToate[i]]);
            }
        }

        private void btnHint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Capitala tarii este " + capitale[poze5[intrb]] + ".");

            lblHint.Text = capitale[poze5[intrb]];

            p = 1;
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (cmbBoxTara.Text != "- Alege -")
            {
                string path = AppDomain.CurrentDomain.BaseDirectory + @"\images\";

                if (cmbBoxTara.Text + ".jpg" == poze5[intrb])
                {
                    points += p;
                    lblPoints.Text = "X " + points;

                    path += "correct.png";
                    picBoxCorrect.Image = Image.FromFile(path);
                    picBoxCorrect.Show();
                }
                else
                {
                    path += "wrong.png";
                    picBoxCorrect.Image = Image.FromFile(path);
                    picBoxCorrect.Show();
                }

                label1.Hide();
                cmbBoxTara.Hide();
                btnVerify.Hide();
                btnNext.Show();

                lblRasp.Text = tari[poze5[intrb]];
            }
            else
            {
                MessageBox.Show("Alege o tara!");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (intrb < 5)
            {
                game joc = new game(pozeToate, poze5, tari, capitale, intrb + 1, points);

                Hide();
                joc.Show();
            }
            else
            {
                end gata = new end(points);

                Hide();
                gata.Show();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            startMenu menu = new startMenu();

            Hide();
            menu.Show();
        }
    }
}
