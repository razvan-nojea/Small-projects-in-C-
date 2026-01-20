using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Library : Form
    {
        public Library()
        {
            InitializeComponent();

            bool ok;

            ok = db.isDBEmpty();

            if(ok)
            {
                initNoDraw();
            }
            else
            {
                initDraw();
                db.initCmb(cmbDrawings);
            }
        }

        private void initNoDraw()
        {
            lblDraw.Visible = false;
            cmbDrawings.Visible = false;    
            picCanvas.Visible = false;

            lblNoDraw.Visible = true;
        }

        private void initDraw()
        {
            lblDraw.Visible = true;
            cmbDrawings.Visible = true;
            picCanvas.Visible = true;

            lblNoDraw.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();

            Hide();
            f.Show();
        }

        private void cmbDrawings_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataReader reader = db.openReader(String.Format("SELECT desen FROM Desene WHERE nume = '{0}';", cmbDrawings.Text.ToString()));

            reader.Read();

            byte[] b = (byte[])reader[0];

            db.closeReader(reader);

            Image img = converter.fromByteToImg(b);
        }
    }
}
