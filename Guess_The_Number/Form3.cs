using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guess_The_Number
{
    public partial class Form3 : Form
    {
        public int raspuns;
        public int verif;
        public int c = 1;
        public Form1 formaInitiala;
        public Form2 formaInitialb;
        public Form3(int n, Form1 form1, Form2 form2)
        {
            InitializeComponent();
            verif = n;
            formaInitiala = form1;
            formaInitialb = form2;
        }

        private void tbRasp_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVerif_Click(object sender, EventArgs e)
        {
            
            if (tbRasp.Text.Length > 0)
            {
                if (int.TryParse(tbRasp.Text, out raspuns))
                {
                    if (raspuns == verif)
                    {
                        txtTry.Text = Convert.ToString(c);

                        if (c > 1)
                            MessageBox.Show("Bravo! Ai ghicit din " + c + " incercari! Ai castigat.... nimic!");
                        else
                            MessageBox.Show("Bravo! Ai ghicit din prima! Esti un maestru!");

                        btnVerif.SendToBack();
                        btnReturn.SendToBack();

                    }
                    else
                    {
                        if (raspuns > verif)
                        {
                            MessageBox.Show("Mai mic!");
                            c++;
                            tbRasp.Text = null;
                        }
                        else
                        {
                            MessageBox.Show("Mai mare!");
                            c++;
                            tbRasp.Text = null;
                        }
                        txtTry.Text = Convert.ToString(c-1);
                    }
                }
                else
                {

                    string s = tbRasp.Text;
                    bool ok = true;

                    for (int i = 0; i < s.Length; i++)
                    {
                        if (char.IsLetter(s[i]))
                        {
                            MessageBox.Show("Input-ul nu este valid!");
                            tbRasp.Text = null;
                            ok = false;
                            break;
                        }
                    }

                    if (ok)
                    {
                        MessageBox.Show("Ne-a cazut serverul de la cate cifre ti-ai pus in numar! Fii si tu mai finut!");

                        tbRasp.Text = null;
                    }
                }
            }
            else
            {
                MessageBox.Show("Haide, nu te rusina acum, incearca sa ghicesti!");

                tbRasp.Text = null;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            formaInitiala.Show();
            MessageBox.Show("Numarul era " + verif + ". :((");
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            formaInitiala.Show();
        }

        private void btnRetry_Click(object sender, EventArgs e)
        {
            this.Hide();
            formaInitialb.Show();
        }
    }
}
