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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp sgn = new SignUp();

            Hide();
            sgn.Show();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            LogIn lgn = new LogIn();

            Hide();
            lgn.Show();
        }
    }
}
