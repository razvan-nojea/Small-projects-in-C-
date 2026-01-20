using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spanzuratoarea.classes
{
    public static class DR
    {
        private static Graphics g;

        private static Pen pen = new Pen(Color.Black, 5);
        private static SolidBrush solbrush = new SolidBrush(Color.Black);

        private static Font font = new Font("Arial", 28);

        public static void Line(PictureBox pic, Point A, Point B, int width)
        {
            g = pic.CreateGraphics();

            pen.Width = width;

            g.DrawLine(pen, A, B);
        }

        public static void Rectangle(PictureBox pic, Point A, Size S)
        {
            g = pic.CreateGraphics();

            Rectangle rec = new Rectangle(A, S);

            g.DrawRectangle(pen, rec);
            g.FillRectangle(solbrush, rec);
        }

        public static void String(PictureBox pic, Point A, string str)
        {
            g = pic.CreateGraphics();

            g.DrawString(str, font, solbrush, A);
        }

        public static void Circle(PictureBox pic, Point A, Size S)
        {
            g = pic.CreateGraphics();

            Rectangle rec = new Rectangle(A, S);

            g.DrawEllipse(pen, rec);
        }
    }
}
