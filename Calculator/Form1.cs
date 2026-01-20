using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double s = 0;
        double b = 0;
        int pct = 0;
        double deci = 0.1;
        int createNr = 0;
        int error = 0;

        int lastOp = 1;

        //0 egal
        //1 adunare
        //2 scadere
        //3 inmultire
        //4 impartire
        public Form1()
        {
            InitializeComponent();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            input.Text = "0";

            lastOp = 1;

            s = 0;
            b = 0;
            pct = 0;
            deci = 0.1;
            createNr = 0;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (createNr == 0 || input.Text == "0")
            {
                createNr = 1;
                input.Text = "1";
                b = 1;
            }
            else
            {
                input.Text += "1";
                if (pct == 0)
                {
                    b *= 10;
                    b += 1;
                }
                else
                {
                    b += (1 * deci);
                    deci /= 10;
                }
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (createNr == 0 || input.Text == "0")
            {
                createNr = 1;
                input.Text = "2";
                b = 2;
            }
            else
            {
                input.Text += "2";
                if (pct == 0)
                {
                    b *= 10;
                    b += 2;
                }
                else
                {
                    b += (2 * deci);
                    deci /= 10;
                }
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (createNr == 0 || input.Text == "0")
            {
                createNr = 1;
                input.Text = "3";
                b = 3;
            }
            else
            {
                input.Text += "3";
                if (pct == 0)
                {
                    b *= 10;
                    b += 3;
                }
                else
                {
                    b += (3 * deci);
                    deci /= 10;
                }
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (createNr == 0 || input.Text == "0")
            {
                createNr = 1;
                input.Text = "4";
                b = 4;
            }
            else
            {
                input.Text += "4";
                if (pct == 0)
                {
                    b *= 10;
                    b += 4;
                }
                else
                {
                    b += (4 * deci);
                    deci /= 10;
                }
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (createNr == 0 || input.Text == "0")
            {
                createNr = 1;
                input.Text = "5";
                b = 5;
            }
            else
            {
                input.Text += "5";
                if (pct == 0)
                {
                    b *= 10;
                    b += 5;
                }
                else
                {
                    b += (5 * deci);
                    deci /= 10;
                }
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (createNr == 0 || input.Text == "0")
            {
                createNr = 1;
                input.Text = "6";
                b = 6;
            }
            else
            {
                input.Text += "6";
                if (pct == 0)
                {
                    b *= 10;
                    b += 6;
                }
                else
                {
                    b += (6 * deci);
                    deci /= 10;
                }
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (createNr == 0 || input.Text == "0")
            {
                createNr = 1;
                input.Text = "7";
                b = 7;
            }
            else
            {
                input.Text += "7";
                if (pct == 0)
                {
                    b *= 10;
                    b += 7;
                }
                else
                {
                    b += (7 * deci);
                    deci /= 10;
                }
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (createNr == 0 || input.Text == "0")
            {
                createNr = 1;
                input.Text = "8";
                b = 8;
            }
            else
            {
                input.Text += "8";
                if (pct == 0)
                {
                    b *= 10;
                    b += 8;
                }
                else
                {
                    b += (8 * deci);
                    deci /= 10;
                }
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (createNr == 0 || input.Text == "0")
            {
                createNr = 1;
                input.Text = "9";
                b = 9;
            }
            else
            {
                input.Text += "9";
                if (pct == 0)
                {
                    b *= 10;
                    b += 9;
                }
                else
                {
                    b += (9 * deci);
                    deci /= 10;
                }
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (createNr == 0 || input.Text == "0")
            {
                createNr = 1;
                input.Text = "0";
            }
            else
            {
                input.Text += "0";

                if (pct == 1)
                {
                    deci /= 10;
                }
                else
                {
                    b *= 10;
                }
            }
        }

        private void btnPct_Click(object sender, EventArgs e)
        {
            if (createNr == 0)
            {
                createNr = 1;
                input.Text += ",";
                lastOp = 1;
                pct = 1;
                deci = 0.1;
            }
            else
            {
                if (pct == 0)
                {
                    input.Text += ",";
                    pct = 1;
                    deci = 0.1;
                }
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (lastOp == 1)
            {
                s += b;
            }
            if(lastOp == 2)
            {
                s -= b;
            }
            if(lastOp == 3)
            {
                s *= b;
            }
            if(lastOp == 4)
            {
                if (b != 0)
                    s /= b;
                else
                {
                    input.Text = "Error";
                    error = 1;
                    s = 0;
                }
            }

            b = 0;
            pct = 0;
            deci = 0.1;
            lastOp = 1;
            createNr = 0;

            if (error == 0)
                input.Text = Convert.ToString(s);
            else
                lastOp = 1;
            error = 0;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {

            if (lastOp == 1)
            {
                s += b;
            }
            if (lastOp == 2)
            {
                s -= b;
            }
            if (lastOp == 3)
            {
                s *= b;
            }
            if (lastOp == 4)
            {
                if (b != 0)
                    s /= b;
                else
                {
                    input.Text = "Error";
                    error = 1;
                    s = 0;
                }
            }

            b = 0;
            pct = 0;
            deci = 0.1;
            lastOp = 2;
            createNr = 0;

            if (error == 0)
                input.Text = Convert.ToString(s);
            else
                lastOp = 1;
            error = 0;
        }

        private void btnOri_Click(object sender, EventArgs e)
        {
            if (lastOp == 1)
            {
                s += b;
            }
            if (lastOp == 2)
            {
                s -= b;
            }
            if (lastOp == 3)
            {
                s *= b;
            }
            if (lastOp == 4)
            {
                if (b != 0)
                    s /= b;
                else
                {
                    input.Text = "Error";
                    error = 1;
                    s = 0;
                }
            }

            b = 0;
            pct = 0;
            deci = 0.1;
            lastOp = 3;
            createNr = 0;

            if (error == 0)
                input.Text = Convert.ToString(s);
            else
                lastOp = 1;
            error = 0;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (lastOp == 1)
            {
                s += b;
            }
            if (lastOp == 2)
            {
                s -= b;
            }
            if (lastOp == 3)
            {
                s *= b;
            }
            if (lastOp == 4)
            {
                if (b != 0)
                    s /= b;
                else
                {
                    input.Text = "Error";
                    error = 1;
                    s = 0;
                }
            }

            b = 0;
            pct = 0;
            deci = 0.1;
            lastOp = 4;
            createNr = 0;

            if (error == 0)
                input.Text = Convert.ToString(s);
            else
                lastOp = 1;
            error = 0;
        }

        private void btnEgal_Click(object sender, EventArgs e)
        {
            if (lastOp == 1)
            {
                s += b;
            }
            if (lastOp == 2)
            {
                s -= b;
            }
            if (lastOp == 3)
            {
                s *= b;
            }
            if (lastOp == 4)
            {
                if (b != 0)
                    s /= b;
                else
                {
                    input.Text = "Error";
                    error = 1;
                    s = 0;
                }
            }

            b = 0;
            pct = 0;
            deci = 0.1;
            lastOp = 0;
            createNr = 0;

            if(error == 0)
                input.Text = Convert.ToString(s);
            else
                lastOp = 1;
            error = 0;
        }
    }
}
