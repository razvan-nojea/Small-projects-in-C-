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
    public partial class Form2 : Form
    {
        public Form1 formaInitiala;
        public int maxim;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            formaInitiala = form1;
        }

        private void tbValMax_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            if (tbValMax.Text.Length > 0)
            {
                if (int.TryParse(tbValMax.Text, out maxim))
                {
                    if (maxim >= 1)
                    {
                        MessageBox.Show("Succes!");

                        tbValMax.Text = null;

                        this.Hide();

                        Random n = new Random();

                        int p = n.Next(1, maxim);

                        Form3 form3 = new Form3(p, formaInitiala, this);

                        form3.Show();
                    }
                    else
                    {
                        MessageBox.Show("Introdu un numar care sa fie mai mare sau egal cu 1!");

                        tbValMax.Text = null;
                    }
                }
                else
                {
                    
                    string s = tbValMax.Text;
                    bool ok = true;

                    for(int i=0; i< s.Length; i++)
                    {
                        if (char.IsLetter(s[i]))
                        {
                            MessageBox.Show("Input-ul nu este valid!");
                            tbValMax.Text = null;
                            ok = false;
                            break;
                        }
                    }

                    if(ok)
                    {
                        MessageBox.Show("Un numar mai mic daca se poate! Serverele noastre doar atata pot!");

                        tbValMax.Text = null;
                    }
                }
            }
            else
            {
                MessageBox.Show("Introdu un numar care sa fie mai mare sau egal cu 1!");

                tbValMax.Text = null;
            }
        }
    }
}
