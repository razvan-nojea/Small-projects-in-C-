using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guess_the_Country
{
    public partial class loadingScreen : Form
    {
        private Dictionary<int, string> pozeToate = new Dictionary<int, string>();
        private Dictionary<int, string> poze5 = new Dictionary<int, string>();
        private Dictionary<string, string> tari = new Dictionary<string, string>();
        private Dictionary<string, string> capitale = new Dictionary<string, string>();
        private Dictionary<string, bool> lista5 = new Dictionary<string, bool>();

        private Random rnd = new Random();

        private int pic_index;
        private int time = 0;
        private int c = 1;


        private string path = AppDomain.CurrentDomain.BaseDirectory + @"\images\";

        public loadingScreen()
        {
            InitializeComponent();

            pic_index = rnd.Next(1, 13);

            load();
            load5();

            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time % 15 == 0)
            {
                int a = pic_index;
                while (a == pic_index)
                {
                    pic_index = rnd.Next(1, 13);
                }

                pictureBox1.Image = Image.FromFile(path + pozeToate[pic_index]);
            }

            if (prgBar.Value == 100)
            {
                lblLoad.Text = "Press the button to continue --->";

                btnContinue.Show();
            }
            else
            {
                if (time % 10 == 0)
                {
                    int n = rnd.Next(1, 100 - prgBar.Value);

                    prgBar.Value += n;
                }

                if (time % 3 == 0)
                {

                    lblLoad.Text = "Loading";

                    if (c == 4)
                    {
                        c = 1;
                    }

                    for (int i = 1; i <= c; i++)
                    {
                        lblLoad.Text += ".";
                    }
                    c++;
                }
            }
            
            time++;

        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            game joc = new game(pozeToate, poze5, tari, capitale, 1, 0);

            timer1.Stop();

            Hide();
            joc.Show();
        }

        private void load()
        {
            string cale = AppDomain.CurrentDomain.BaseDirectory + @"\data\data.txt";

            StreamReader str = new StreamReader(cale);

            string[] line;
            
            for(int i=1; i<= 13; i++)
            {
                line = str.ReadLine().Split('#');

                pozeToate[i] = line[2];
                capitale[pozeToate[i]] = line[1];
                tari[pozeToate[i]] = line[0];

                lista5[pozeToate[i]] = false;
            }
        }

        private void load5()
        {
            int index = 1;
            int i = rnd.Next(1,13);

            while(index < 6)
            {
                if (lista5[pozeToate[i]] == false)
                {
                    lista5[pozeToate[i]] = true;
                    poze5[index] = pozeToate[i];

                    index++;
                }

                i = rnd.Next(1, 13);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
