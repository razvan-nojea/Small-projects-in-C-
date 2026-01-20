using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spanzuratoarea
{
    public static class DB
    {
        private static string path = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\HANGMAN.mdf;Integrated Security=True;Connect Timeout=30";

        private static SqlConnection conn = new SqlConnection(path);
        private static SqlCommand cmd;
        private static SqlDataReader reader;

        public static void NewCmd(string command)
        {
            conn.Open();

            cmd = new SqlCommand(command, conn);
        }

        public static void ExecuteCmd()
        {
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static void CancelCmd()
        {
            conn.Close();
        }

        public static SqlDataReader OpenReader(string command)
        {
            conn.Open();
            
            cmd = new SqlCommand(command, conn);

            reader = cmd.ExecuteReader();

            return reader;
        }

        public static void CloseReader(SqlDataReader readeru) 
        {
            reader.Close();
            readeru.Close();

            conn.Close();
        }
    }
}
