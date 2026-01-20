using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clicker_game
{
    public static class DB
    {
        private static string path = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\clickerGame.mdf;Integrated Security=True;Connect Timeout=30";

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

        public static SqlDataReader openReader(string command)
        {
            newCmd(command);

            reader = cmd.ExecuteReader();

            return reader;

        }

        public static void closeReader(SqlDataReader readeru)
        {
            readeru.Close();
            reader.Close();

            conn.Close();
        }

        public static int getHighscore()
        {
            reader = openReader("SELECT * FROM Scor");

            reader.Read();

            int highscore = Convert.ToInt32(reader[1].ToString());

            closeReader(reader);

            return highscore;
        }

        public static void updateHighscore(int score)
        {
            newCmd(String.Format("UPDATE Scor SET Highscore = '{0}';", score));

            executeCmd();
        }

    }
}
