using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spanzuratoarea
{
    public static class CUV
    {
        private static SqlDataReader reader;

        public static List<int> GetIdDom(GroupBox grp)
        {
            List<int> ids = new List<int>();

            foreach(CheckBox chk in grp.Controls)
            {
                if (chk.Checked)
                {
                    if(chk.Text == "Informatics")
                    {
                        ids.Add(1);
                    }

                    if(chk.Text == "Mathematics")
                    {
                        ids.Add(2);
                    }

                    if(chk.Text == "Biology")
                    {
                        ids.Add(3);
                    }

                    if(chk.Text == "Romanian literature")
                    {
                        ids.Add(4);
                    }

                    if(chk.Text == "Cars")
                    {
                        ids.Add(5);
                    }
                }
            }

            return ids;
        }

        public static List<string> GetCuvinte(List<int> idDom)
        {
            List<string> cuv = new List<string>();

            foreach(int n in idDom)
            {
                reader = DB.OpenReader(String.Format("SELECT cuvant FROM Cuvinte WHERE id_domeniu = '{0}';", n));
                
                while(reader.Read())
                {
                    cuv.Add(reader[0].ToString());
                }

                DB.CloseReader(reader);
            }

            return cuv;
        }

        public static string GetGameCuv(GroupBox grp)
        {
            List<int> idDom = GetIdDom(grp);

            List<string> cuv = GetCuvinte(idDom);

            Random r = new Random();

            int n = r.Next(0, cuv.Count - 1);

            return cuv[n];
        }
    }
}
