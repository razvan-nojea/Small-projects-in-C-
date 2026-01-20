using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public static class db
    {
        private static string path = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\painter.mdf;Integrated Security=True;Connect Timeout=30";

        private static SqlConnection conn = new SqlConnection(path);
        private static SqlCommand cmd;
        private static SqlDataReader reader;

        public static void newCmd(string comm)
        {
            conn.Open();

            cmd = new SqlCommand(comm, conn);
        }

        public static void executeCmd()
        {
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static void cancelCmd()
        {
            conn.Close();
        }

        public static SqlDataReader openReader(string comm)
        {
            newCmd(comm);

            reader = cmd.ExecuteReader();

            return reader;
        }

        public static void closeReader(SqlDataReader readeru)
        {
            readeru.Close();
            reader.Close();

            conn.Close();
        }

        public static void insertNewDrawing(string nume, byte[] b)
        {
            newCmd(String.Format("INSERT INTO Desene(nume, desen) VALUES(@nume, @img);"));

            cmd.Parameters.Add("@nume", System.Data.SqlDbType.NVarChar, 50);
            cmd.Parameters.Add("@img", System.Data.SqlDbType.Image);

            cmd.Parameters["@nume"].Value = nume;
            cmd.Parameters["@img"].Value = b;

            executeCmd();
        }

        public static bool isNameVacant(string nume)
        {
            reader = openReader(String.Format("SELECT * FROM Desene WHERE nume = '{0}';", nume));

            bool ok = true;

            while(reader.Read())
            {
                ok = false;
            }

            closeReader(reader);

            return ok;
        }

        public static bool isDBEmpty()
        {
            bool ok = true;

            reader = openReader("SELECT * FROM Desene;");

            while(reader.Read())
            {
                ok = false;
            }

            closeReader(reader);

            return ok;
        }

        public static void initCmb(ComboBox cmb)
        {
            cmb.Items.Clear();

            reader = openReader("SELECT nume FROM Desene;");

            while(reader.Read())
            {
                cmb.Items.Add(reader[0].ToString());
            }

            closeReader(reader);
        }
    }
}
