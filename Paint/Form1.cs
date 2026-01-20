using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        Graphics gP;
        Graphics gB;

        Pen pen = new Pen(Color.Black, 5);

        Bitmap bmp = new Bitmap(574, 425);

        int lastMouseX;
        int lastMouseY;

        bool isLMBPressed = false;  


        public Form1()
        {
            InitializeComponent();

            gP = picCanvas.CreateGraphics();
            gB = Graphics.FromImage(bmp);

            gB.Clear(Color.White);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void colorChanged(object sender, EventArgs e)
        {
            PictureBox pic = new PictureBox();

            pic = (PictureBox)sender;

            pen.Color = pic.BackColor;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            gP.Clear(Color.White);
            gB.Clear(Color.White);
        }

        private void picCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if(isLMBPressed)
            {
                gP.DrawLine(pen, lastMouseX, lastMouseY, e.X, e.Y);
                gB.DrawLine(pen, lastMouseX, lastMouseY, e.X, e.Y);
            }

            lastMouseX = e.X;
            lastMouseY = e.Y;
        }

        private void picCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            isLMBPressed = true;
        }

        private void picCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            isLMBPressed = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(save.ShowDialog() == DialogResult.OK)
            {
                bmp.Save(save.FileName + ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);

                MessageBox.Show("SUCCES.");

                gP.Clear(Color.White);
                gB.Clear(Color.White);
            }
        }

        private void btnLibrary_Click(object sender, EventArgs e)
        {
            Library lib = new Library();

            Hide();
            lib.Show();
        }
    }







    /*
     * bool ok = false;

            while(!ok)
            {
                string name = Microsoft.VisualBasic.Interaction.InputBox("\"INSERT PICTURE NAME.\"", "\"TITLE NOT FOUND\"", "\"DRAWING\"");

                if (!db.isNameVacant(name))
                {
                    MessageBox.Show("INVALID.");
                }
                else
                {
                    if (name.Length > 0)
                    {
                        Bitmap bit = new Bitmap(picCanvas.Width, picCanvas.Height);

                        picCanvas.DrawToBitmap(bit, picCanvas.DisplayRectangle);

                        byte[] b = converter.fromImgToByte(bit);

                        db.insertNewDrawing(name, b);

                        MessageBox.Show("SUCCES.");

                        ok = true;
                    }
                    else
                    {
                        ok = true;
                    }
                }
            }
    */



}
