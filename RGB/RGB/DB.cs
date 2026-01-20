using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;
using System.Drawing;

namespace RGB
{
    public static class DB
    {
        private static string path = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\crocozaur.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";

        private static SqlConnection conn = new SqlConnection(path);
        private static SqlCommand cmd;
        private static SqlDataReader reader;

        public static void newCmd(string command)
        {
            conn.Open();

            cmd = new SqlCommand(command, conn);
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

        public static SqlDataReader openReader(string command)
        {
            DB.newCmd(command);

            reader = cmd.ExecuteReader();

            return reader;
        }

        public static void closeReader(SqlDataReader readeru)
        {
            readeru.Close();
            reader.Close();

            conn.Close();
        }

        public static void insertUser(string nume, string prenume, string email, string parola)
        {
            DB.newCmd(String.Format("INSERT INTO Utilizatori(nume, prenume, email, parola) VALUES(@nume, @prenume, @email, @parola);"));

            cmd.Parameters.Add("@nume", SqlDbType.NVarChar, 50);
            cmd.Parameters.Add("@prenume", SqlDbType.NVarChar, 50);
            cmd.Parameters.Add("@email", SqlDbType.NVarChar, 50);
            cmd.Parameters.Add("@parola", SqlDbType.NVarChar, 50);

            cmd.Parameters["@nume"].Value = nume;
            cmd.Parameters["@prenume"].Value = prenume;
            cmd.Parameters["@email"].Value = email;
            cmd.Parameters["@parola"].Value = parola;

            DB.executeCmd();
        }

        public static void insertColor(int alpha, int red, int green, int blue, int id_utilizator, string nume)
        {
            DB.newCmd(String.Format("INSERT INTO Culori(alpha, red, green, blue, id_utilizator, nume) VALUES(@alpha, @red, @green, @blue, @id_utilizator, @nume);"));

            cmd.Parameters.Add("@alpha", SqlDbType.Int);
            cmd.Parameters.Add("@red", SqlDbType.Int);
            cmd.Parameters.Add("@green", SqlDbType.Int);
            cmd.Parameters.Add("@blue", SqlDbType.Int);
            cmd.Parameters.Add("@id_utilizator", SqlDbType.Int);
            cmd.Parameters.Add("@nume", SqlDbType.NVarChar, 50);

            cmd.Parameters["@alpha"].Value = alpha;
            cmd.Parameters["@red"].Value = red;
            cmd.Parameters["@green"].Value = green;
            cmd.Parameters["@blue"].Value = blue;
            cmd.Parameters["@id_utilizator"].Value = id_utilizator;
            cmd.Parameters["@nume"].Value = nume;

            DB.executeCmd();
        }

        public static bool existColors(int id_utilizator)
        {
            bool ok = false;

            DB.openReader(String.Format("SELECT * FROM Culori WHERE id_utilizator = '{0}';", id_utilizator));

            while(reader.Read())
            {
                ok = true;
            }

            DB.closeReader(reader);

            return ok;
        }

        public static void insertColorsIntoCmb(ComboBox cmb, int id_utilizator)
        {
            DB.openReader(String.Format("SELECT nume FROM Culori WHERE id_utilizator = '{0}';", id_utilizator));

            while(reader.Read()) 
            {
                cmb.Items.Add(reader[0].ToString());
            }

            DB.closeReader(reader);
        }

        public static bool existUser(string email)
        {
            bool ok = false;

            DB.openReader(String.Format("SELECT * FROM Utilizatori WHERE email = '{0}';", email));

            while (reader.Read())
            {
                ok = true;
            }

            DB.closeReader(reader);

            return ok;
        }

        public static bool correctPass(string email, string parola)
        {
            bool ok = false;

            DB.openReader(String.Format("SELECT parola FROM Utilizatori WHERE email = '{0}';", email));

            reader.Read();

            if (reader[0].ToString() == parola)
            {
                ok = true;
            }

            DB.closeReader(reader);

            return ok;
        }

        public static string getPrenume(string email)
        {
            DB.openReader(String.Format("SELECT prenume FROM Utilizatori WHERE email = '{0}';", email));

            reader.Read();

            string prenume = reader[0].ToString();

            DB.closeReader(reader);

            return prenume;
        }

        public static bool existColorName(int id_utilizator, string nume)
        {
            bool ok = false;

            DB.openReader(String.Format("SELECT * FROM Culori WHERE nume = '{0}' AND id_utilizator = '{1}';", nume, id_utilizator));

            while(reader.Read())
            {
                ok = true;
            }

            DB.closeReader(reader);

            return ok;
        }

        public static int getId(string email)
        {
            DB.openReader(String.Format("SELECT Id FROM Utilizatori WHERE email = '{0}';", email));

            reader.Read();

            int id = Convert.ToInt32(reader[0].ToString());

            DB.closeReader(reader);

            return id;
        }

        public static Color getColor(int id_utilizator, string nume)
        {
            int alpha;
            int red;
            int green;
            int blue;

            Color clr;

            DB.openReader(String.Format("SELECT * FROM Culori WHERE id_utilizator = '{0}' AND nume = '{1}';", id_utilizator, nume));

            reader.Read();

            alpha = Convert.ToInt32(reader[1].ToString());
            red = Convert.ToInt32(reader[2].ToString());
            green = Convert.ToInt32(reader[3].ToString());
            blue = Convert.ToInt32(reader[4].ToString());

            DB.closeReader(reader);

            clr = Color.FromArgb(alpha, red, green, blue);

            return clr;
        }
    }
}
