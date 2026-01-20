using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerere
{
    public static class Error
    {
        
        public static bool AllOk(string title, string message, DateTime date, Bitmap bmp)
        {
            if(title.Length == 0)
            {
                System.Windows.Forms.MessageBox.Show("Introdu titlu.");
                return false;
            }

            if(message.Length == 0)
            {
                System.Windows.Forms.MessageBox.Show("Introdu mesaj.");
                return false;
            }

            if(date > DateTime.Now)
            {
                System.Windows.Forms.MessageBox.Show("Introdu o data valida.");
                return false;
            }

            if(bmp == null) {
                System.Windows.Forms.MessageBox.Show("Semneaza-te");
                return false;
            }

            return true;
        }

    }
}
