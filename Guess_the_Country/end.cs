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
    public partial class end : Form
    {
        public end(int points)
        {
            InitializeComponent();

            lblPoints.Text = "" + points;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            startMenu start = new startMenu();

            Hide();
            start.Show();
        }

        private void btnRetry_Click(object sender, EventArgs e)
        {
            loadingScreen load = new loadingScreen();

            Hide();
            load.Show();
        }
    }
}
