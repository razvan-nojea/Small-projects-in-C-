using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cerere
{
    public partial class Form1 : Form
    {
        Graphics gPic;
        Graphics gSign;
        Graphics gCerere;

        Pen pen = new Pen(Color.Black, 5);

        Bitmap bmpSign;
        Bitmap bmpCerere;

        bool isLMBPressed = false;

        int lastMouseX = -1;
        int lastMouseY = -1;

        public Form1()
        {
            InitializeComponent();

            bmpSign = new Bitmap(picSignature.Width, picSignature.Height);
            bmpCerere = new Bitmap(2480, 3508);

            gPic = picSignature.CreateGraphics();
            gSign = Graphics.FromImage(bmpSign);
            gCerere = Graphics.FromImage(bmpCerere);

            gSign.Clear(Color.White);
            gCerere.Clear(Color.White);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string title = txtTitlu.Text.ToString().Trim();
            string message = txtContinut.Text.ToString().Trim();
            DateTime date = datetime.Value.Date;

            if (Error.AllOk(title, message, date, bmpSign))
            {
                Font font = new Font("Arial", 90);
                Brush brush = new SolidBrush(Color.Black);

                gCerere.DrawString(title, font, brush, 800, 300);

                font = new Font("Arial", 60);

                gCerere.DrawString(message, font, brush, 250, 700);

                gCerere.DrawString(date.ToString("dd/MM/yyyy"), font, brush, 250, 2500);
                gCerere.DrawImage(bmpSign, 1500, 2500, bmpSign.Width * 2, bmpSign.Height * 2);

                if(saveFile.ShowDialog() == DialogResult.OK)
                {
                    bmpCerere.Save(saveFile.FileName + ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
                }

                MessageBox.Show("Succes");
            }

            Reset();
        }

        private void Reset()
        {
            txtContinut.Text = "";
            txtTitlu.Text = "";

            datetime.Value = DateTime.Now;

            gPic.Clear(Color.White);
            gSign.Clear(Color.White);
        }


        private void picSignature_MouseDown(object sender, MouseEventArgs e)
        {
            isLMBPressed = true;
        }

        private void picSignature_MouseUp(object sender, MouseEventArgs e)
        {
            isLMBPressed = false;
        }

        private void picSignature_MouseMove(object sender, MouseEventArgs e)
        {
            if(isLMBPressed)
            {
                gPic.DrawLine(pen, lastMouseX, lastMouseY, e.X, e.Y);
                gSign.DrawLine(pen, lastMouseX, lastMouseY, e.X, e.Y);
            }

            lastMouseX = e.X;
            lastMouseY = e.Y;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}