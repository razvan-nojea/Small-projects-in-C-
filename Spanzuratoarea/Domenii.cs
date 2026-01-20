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
    public partial class Domenii : Form
    {
        public Domenii()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Start st = new Start();

            Hide();
            st.Show();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            if(Error.AtLeastOneSubject(grpSubject))
            {
                string cuvant = CUV.GetGameCuv(grpSubject);

                Joc j = new Joc(cuvant);

                Hide();
                j.Show();
            }
            else
            {
                MessageBox.Show("Select at least one subject!");
            }
        }
    }
}
