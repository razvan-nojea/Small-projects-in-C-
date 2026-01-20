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
    public partial class startMenu : Form
    {
        public startMenu()
        {
            InitializeComponent();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            loadingScreen urm = new loadingScreen();

            Hide();
            urm.Show();
        }
    }
}
