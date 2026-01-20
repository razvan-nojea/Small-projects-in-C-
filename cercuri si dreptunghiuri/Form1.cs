using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace cercuri_si_dreptunghiuri
{
    public partial class Main : Form
    {

        ///                                         ///
        ///    ----    Global  Variables    ----    ///
        ///                                         ///

        Graphics g;

        Pen pen = new Pen(Color.Black);
        int penThickness = 2;

        Point auxA;
        Point auxB;
        Point A;
        Point B;

        bool circle = true;
        bool rectangle = false;

        ///                                         ///
        ///     ----      Comp. Init.      ----     ///
        ///                                         ///

        public Main()
        {
            InitializeComponent();

            g = this.CreateGraphics();
        }

        ///                                         ///
        ///     ----     Obj. Function.    ----     ///
        ///                                         ///

        private void btnColor_Click(object sender, EventArgs e)  // btnColor
        {
            if(colDia.ShowDialog() ==  DialogResult.OK)
            {
                btnColor.BackColor = colDia.Color;

                pen.Color = colDia.Color;
            }
        }

        private void rbtnCircle_CheckedChanged(object sender, EventArgs e)  // rbtnCircle
        {
            if(rbtnCircle.Checked)
            {
                circle = true;

                rectangle = false;
            }
        }

        private void rbtnRectangle_CheckedChanged(object sender, EventArgs e)  // rbtnRectangle
        {
            if(rbtnRectangle.Checked)
            {
                circle = false;

                rectangle = true;
            }
        }

        private void tBar_Scroll(object sender, EventArgs e)  // tBar
        {
            penThickness = tBar.Value + 1;

            pen.Width = penThickness;
        }

        private void btnClear_Click(object sender, EventArgs e)  // btnClear
        {
            g.Clear(this.BackColor);
        }

        ///                                         ///
        ///      ----      Mouse Ctrl     ----      ///
        ///                                         ///

        private void Main_MouseDown(object sender, MouseEventArgs e)  // mouse down
        {
            auxA.X = e.X;
            auxA.Y = e.Y;
        }

        private void Main_MouseUp(object sender, MouseEventArgs e)  // mouse up
        {
            auxB.X = e.X;
            auxB.Y = e.Y;

            A.X = Math.Min(auxA.X, auxB.X);
            A.Y = Math.Min(auxA.Y, auxB.Y);

            B.X = Math.Max(auxA.X, auxB.X);
            B.Y = Math.Max(auxA.Y, auxB.Y);

            draw(A, B);
        }

        ///                                         ///
        ///     ----     Drawing Func.     ----     ///
        ///                                         ///

        private void drawCircle(Point A, Point B)  // draw a circle
        {
            int width = Math.Abs(A.X - B.X);
            int height = Math.Abs(A.Y - B.Y);

            Size size = new Size(width, height);

            Rectangle rec = new Rectangle(A, size);

            g.DrawEllipse(pen, rec);
        }

        private void drawRectangle(Point A, Point B)  // draw a rectangle
        {
            int width = Math.Abs(A.X - B.X);
            int height = Math.Abs(A.Y - B.Y);

            Size size = new Size(width, height);

            Rectangle rec = new Rectangle(A, size);

            g.DrawRectangle(pen, rec);
        }
        private void draw(Point A, Point B)  // draw something
        {
            if (circle)
                drawCircle(A, B);
            if (rectangle)
                drawRectangle(A, B);
        }

        ///                                         ///
        ///      ----        Misc.       ----       ///
        ///                                         ///

        private void iesiToolStripMenuItem_Click(object sender, EventArgs e)  // exit
        {
            Environment.Exit(0);
        }
    }
}
