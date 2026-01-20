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
    public partial class Browser : Form
    {
        private string email;
        private int id_utilizator;
        private string prenume;

        public Browser(string emailu, int id_utilizatoru)
        {
            InitializeComponent();

            email = emailu;
            id_utilizator = id_utilizatoru;

            prenume = DB.getPrenume(email);

            lblWelcome.Text += prenume + "!";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void backToMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Start mm = new Start();

            Hide();
            mm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool ok = false;

            string s;
            int alpha = ((int)tbarOpac.Value * 255) / 100;
            int red = (int)upRed.Value;
            int green = (int)upGreen.Value;
            int blue = (int)upBlue.Value;

            while(!ok)
            {
                ok = true;
                s = Microsoft.VisualBasic.Interaction.InputBox("Insert color name!", "Save color", "New Color");

                if (s.Length > 0)
                {
                    if (!DB.existColorName(id_utilizator, s))
                    {
                        DB.insertColor(alpha, red, green, blue, id_utilizator, s);

                        MessageBox.Show("New color saved!");
                    }
                    else
                    {
                        MessageBox.Show("Color name already exists!");

                        ok = false;
                    }
                }
            }
        }

        private void savedColorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SavedColors svc = new SavedColors(email, id_utilizator);

            Hide();
            svc.Show();
        }

        private void updatePicColor()
        {
            int alpha = ((int)tbarOpac.Value * 255) / 100;
            int red = (int)upRed.Value;
            int green = (int)upGreen.Value;
            int blue = (int)upBlue.Value;

            Color clr = Color.FromArgb(alpha, red, green, blue);

            picColor.BackColor = clr;
        }

        private void upRed_ValueChanged(object sender, EventArgs e)
        {
            updatePicColor();
        }

        private void upGreen_ValueChanged(object sender, EventArgs e)
        {
            updatePicColor();
        }

        private void upBlue_ValueChanged(object sender, EventArgs e)
        {
            updatePicColor();
        }

        private void tbarOpac_Scroll(object sender, EventArgs e)
        {
            updatePicColor();
        }
    }
}
