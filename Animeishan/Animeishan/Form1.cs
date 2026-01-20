using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animeishan
{
    public partial class Form1 : Form
    {
        private Graphics g;
        private Graphics g2;

        private Color color = Color.Black;

        private int size = 1;

        List<Point> points = new List<Point>();
        List<Color> colors = new List<Color>();
        List<int> sizes = new List<int>();

        bool over = true;

        int ind = 0;

        Bitmap bmp;

        public Form1()
        {
            InitializeComponent();

            g = canvas.CreateGraphics();

            bmp = new Bitmap(canvas.Width, canvas.Height);

            g2 = Graphics.FromImage(bmp);

            g2.Clear(Color.White);
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            if(over)
            {
                int X = e.X;
                int Y = e.Y;

                Pen pen = new Pen(color, 5);
                SolidBrush brush = new SolidBrush(color);

                X -= 5 * size;
                Y -= 5 * size;

                Point A = new Point(X, Y);
                Size sizer = new Size(10 * size, 10 * size);

                Rectangle rec = new Rectangle(A, sizer);

                g.DrawEllipse(pen, rec);
                g.FillEllipse(brush, rec);

                g2.DrawEllipse(pen, rec);
                g2.FillEllipse(brush, rec);

                points.Add(A);
                colors.Add(color);
                sizes.Add(size);
            }
        }

        private void tbarsize_Scroll(object sender, EventArgs e)
        {
            size = tbarsize.Value;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog1.Color;

                btnColor.BackColor = color;
            }
        }

        private void animateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);

            timer1.Start();
            ind = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(points.Count != 0)
            {
                over = false;
            }

            if(!over)
            {
                Size sizer = new Size(10 * sizes[ind], 10 * sizes[ind]);

                Rectangle rec = new Rectangle(points[ind], sizer);

                Pen pen = new Pen(colors[ind], 5);
                SolidBrush brush = new SolidBrush(colors[ind]);

                g.DrawEllipse(pen, rec);
                g.FillEllipse(brush, rec);

                ind++;

                if(ind == points.Count)
                {
                    over = true;
                }
            }

            if(over)
            {
                timer1.Stop();
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            g2.Clear(Color.White);

            points.Clear();
            colors.Clear();
            sizes.Clear();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bmp.Save(saveFileDialog1.FileName + ".jpg", ImageFormat.Jpeg);

                MessageBox.Show("Saved succesfully!");
            }
        }
    }
}
