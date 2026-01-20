using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spanzuratoarea
{
    public static class Error
    {
        public static bool AtLeastOneSubject(GroupBox grp)
        {
            bool ok = false;

            foreach(CheckBox chk in grp.Controls)
            {
                if (chk.Checked)
                {
                    ok = true;
                }
            }

            return ok;
        }
    }
}
