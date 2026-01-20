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
    public partial class SavedColors : Form
    {
        private string email;
        private int id_utilizator;

        public SavedColors(string emailu, int id_utilizatoru)
        {
            InitializeComponent();

            email = emailu;
            id_utilizator = id_utilizatoru;

            if(!DB.existColors(id_utilizator))
            {
                lblLibrary.Visible = false;
                cmbColors.Visible = false;
                groupBox1.Visible = false;
                picColor.Visible = false;

                lblNoColor.Visible = true;
            }
            else
            {
                DB.insertColorsIntoCmb(cmbColors, id_utilizator);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Browser b = new Browser(email, id_utilizator);

            Hide();
            b.Show();
        }

        private void cmbColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            Color clr;

            clr = DB.getColor(id_utilizator, cmbColors.Text.ToString());

            picColor.BackColor = clr;
        }
    }
}
