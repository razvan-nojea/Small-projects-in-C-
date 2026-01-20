using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    public static class converter
    {
        private static MemoryStream ms = new MemoryStream();

        public static byte[] fromImgToByte(Bitmap img)
        {
            byte[] b;

            img.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);

            b = ms.ToArray();

            return b;
        }

        public static Image fromByteToImg(byte[] b)
        {
            Image img;

            ms = new MemoryStream(b);

            img = Image.FromStream(ms);

            return img;
        }

    }
}
