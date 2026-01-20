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
    public partial class SignUp : Form
    {
        int seePass = -1;

        public SignUp()
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

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string nume = txtNume.Text.ToString();
            string prenume = txtPrenume.Text.ToString();
            string email = txtEmail.Text.ToString();
            string parola = txtPass.Text.ToString();
            string rparola = txtRPass.Text.ToString();

            if(Error.okUser(nume, prenume, email, parola, rparola))
            {
                DB.insertUser(nume, prenume, email, parola);

                MessageBox.Show("Signed up successfully!");

                Start mm = new Start();

                Hide();
                mm.Show();
            }
            else
            {
                lblError.Visible = true;
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        private void txtRPass_TextChanged(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        private void txtPrenume_TextChanged(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        private void txtNume_TextChanged(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }
    }
}
