using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGB
{
    public static class Error
    {
        public static bool okNume(string nume)
        {
            if(!nume.All(char.IsLetter) || nume.Length <= 0)
            {
                return false;
            }

            return true;
        }

        public static bool okPrenume(string prenume)
        {
            if (!prenume.All(char.IsLetter) || prenume.Length <= 0)
            {
                return false;
            }

            return true;
        }

        public static bool okEmail(string email)
        {
            int arond = 0;
            int dot = 0;

            foreach(char c in email)
            {
                if(c=='.')
                {
                    dot ++;
                }

                if(c == '@')
                {
                    arond++;
                }
            }

            if(arond != 1 || dot != 1)
            {
                return false;
            }

            if(DB.existUser(email))
            {
                return false;
            }

            if(email.Length < 5)
            {
                return false;
            }

            return true;
        }

        public static bool okParola(string parola, string rparola)
        {
            if(parola != rparola || parola.Length <= 0)
            {
                return false;
            }

            return true;
        }

        public static bool okUser(string nume, string prenume, string email, string parola, string rparola)
        {
            return okNume(nume) && okPrenume(prenume) && okEmail(email) && okParola(parola, rparola);
        }
    }
}
