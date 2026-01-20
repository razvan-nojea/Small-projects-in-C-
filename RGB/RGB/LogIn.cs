using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGB
{
    public partial class LogIn : Form
    {
        int seePass = -1;

        public LogIn()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Start mm = new Start();

            Hide();
            mm.Show();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.ToString();
            string parola = txtPass.Text.ToString();


            if (DB.existUser(email) && DB.correctPass(email, parola))
            {
                int id_utilizator = DB.getId(email);

                Browser b = new Browser(email, id_utilizator);

                Hide();
                b.Show();
            }
            else
            {
                if(DB.existUser(email))
                {
                    lblError.Text = "Incorrect password!";
                }
                else
                {
                    lblError.Text = "Email doesn't exist!";
                }
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            lblError.Text = null;
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            lblError.Text = null;
        }

        private void btnSeePass_Click(object sender, EventArgs e)
        {
            seePass *= -1;

            if(seePass == 1)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }
    }
}
