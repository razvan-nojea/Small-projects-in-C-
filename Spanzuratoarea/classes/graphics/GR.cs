using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spanzuratoarea.classes
{
    public static class GR
    {
        private static int width = 5;

        public static void Head(PictureBox pic)
        {
            Point A = new Point(124, 107);
            Size S = new Size(44, 39);

            DR.Circle(pic, A, S);
        }

        public static void Torso(PictureBox pic) 
        {
            Point A = new Point(144, 146);
            Point B = new Point(144, 201);

            DR.Line(pic, A, B, width);
        }

        public static void RightHand(PictureBox pic)
        {
            Point A = new Point(144, 165);
            Point B = new Point(170, 190);

            DR.Line(pic, A, B, width);
        }

        public static void LeftHand(PictureBox pic)
        {
            Point A = new Point(144, 165);
            Point B = new Point(122, 188);

            DR.Line(pic, A, B, width);
        }

        public static void RightLeg(PictureBox pic)
        {
            Point A = new Point(144, 200);
            Point B = new Point(177, 233);

            DR.Line(pic, A, B, width);
        }

        public static void LeftLeg(PictureBox pic)
        {
            Point A = new Point(144, 200);
            Point B = new Point(119, 235);

            DR.Line(pic, A, B, width);
        }

        public static void Letter(PictureBox pic, int index, string str)
        {
            Point A = new Point(25 + (index) * 40, 0);

            DR.String(pic, A, str);
        }

        public static void Underline(PictureBox pic, int n)
        {
            int x = 27;

            for(int i = 0; i < n; i++)
            {
                Point A = new Point(x, 45);
                Point B = new Point(x + 35, 45);

                DR.Line(pic, A, B, 5);

                x += 40;
            }
        }
    }
}
