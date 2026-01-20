using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datagridview
{
    public partial class Form1 : Form
    {
        

        ///                                                   ///
        ///        ----      GLOBAL VARIABLES      ----       ///
        ///                                                   ///


        private static string path = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\velociraptor.mdf;Integrated Security=True;Connect Timeout=30";

        private SqlConnection conn = new SqlConnection(path);
        private SqlCommand cmd;
        private SqlDataReader reader;

        private int id;

        private bool update = false;

        
        ///                                                   ///
        ///       ----      INITIALIZING FORM      ----       ///
        ///                                                   ///


        public Form1()
        {
            InitializeComponent();

            dataGV.ForeColor = Color.Black;

            initDataTable();
        }

        
        ///                                                   ///
        ///       ----      BTN FUNCTIONALITY      ----       ///
        ///                                                   ///


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(!errorCatcher())
            {
                executeCommand(String.Format("INSERT INTO tiranozaur ( nume, prenume, clasa) VALUES('{0}', '{1}', '{2}');", txtNume.Text, txtPrenume.Text, txtClasa.Text));
                MessageBox.Show("Succes!");
                initDataTable();

                txtID.Text = null;
                txtNume.Text = null;
                txtPrenume.Text = null;
                txtClasa.Text = null;
            }
        }
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            update = true;

            if(!errorCatcher())
            {
                executeCommand(String.Format("UPDATE tiranozaur SET nume = '{0}', prenume = '{1}', clasa = '{2}' WHERE id_elev = '{3}';", txtNume.Text, txtPrenume.Text, int.Parse(txtClasa.Text), int.Parse(txtID.Text)));
                MessageBox.Show("Succes!");
                initDataTable();
            }

            update = false;
        }


        ///                                                   ///
        ///        ----       SQL SHORTCUTS       ----        ///
        ///                                                   ///


        private void executeCommand(string command)
        {
            conn.Open();

            cmd = new SqlCommand(command, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        private void readerOpen(string command)
        {
            conn.Open();

            cmd = new SqlCommand(command, conn);
            reader = cmd.ExecuteReader();
        }

        private void readerClose()
        {
            reader.Close();

            conn.Close();
        }

        private void initDataTable()
        {
            DataTable dt = new DataTable();

            readerOpen("SELECT * FROM tiranozaur;");

            try
            {
                dt.Load(reader);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            readerClose();

            dataGV.DataSource = dt;
        }


        ///                                                   ///
        ///       ----       OTHER SHORTCUTS       ----       ///
        ///                                                   ///


        private bool isValidInt(string number)
        {
            int nr;

            if(int.TryParse(number, out nr))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        ///                                                   ///
        ///       ----        ERROR CATCHER        ----       ///
        ///                                                   ///


        private bool errorCatcher()
        {


            if (txtID.Text.Length == 0 && update)
            {
                MessageBox.Show("Nu updatezi pe nimeni!");
                return true;
            }

            if (txtNume.Text.Length == 0 || txtPrenume.Text.Length == 0 || txtClasa.Text.Length == 0)
            {
                MessageBox.Show("Completeaza toate casutele!");
                return true;
            }

            if(txtNume.Text.Any(char.IsDigit) || txtPrenume.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Nume sau prenume invalid!");
                return true;
            }

            if(!isValidInt(txtClasa.Text))
            {
                MessageBox.Show("Clasa invalida!");
                return true;
            }

            int clasa;

            clasa = int.Parse(txtClasa.Text);

            if(clasa <= 1 || clasa >= 12)
            {
                MessageBox.Show("Clasa invalida!");
                return true;
            }

            return false;
        }


        ///                                                   ///
        ///    ----    DATA GRID VIEW FUNCTIONALITY    ----   ///
        ///                                                   ///


        private void dataGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dataGV.Columns[e.ColumnIndex].Name == "sterge")
            {
                id = int.Parse(dataGV.Rows[e.RowIndex].Cells[0].Value.ToString());

                executeCommand(String.Format("DELETE FROM tiranozaur WHERE id_elev = '{0}';", id));

                initDataTable();
            }
            else
            {
                if (e.RowIndex >= 0)
                {
                    txtID.Text = dataGV.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtNume.Text = dataGV.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtPrenume.Text = dataGV.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtClasa.Text = dataGV.Rows[e.RowIndex].Cells[3].Value.ToString();
                }
            }

        }


        ///                                                   ///
        ///        ----       VISUAL DETAILS       ----       ///
        ///                                                   ///


        private void btnAdd_MouseHover(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.MediumSeaGreen;
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.DarkSlateGray;
        }

        private void btnUpdate_MouseHover(object sender, EventArgs e)
        {
            btnUpdate.BackColor = Color.MediumSeaGreen;
        }

        private void btnUpdate_MouseLeave(object sender, EventArgs e)
        {
            btnUpdate.BackColor = Color.DarkSlateGray;
        }
        private void exitToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            exitToolStripMenuItem.BackColor = Color.MediumSeaGreen;
        }

        private void exitToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            exitToolStripMenuItem.BackColor = Color.DarkSlateGray;
        }

        
        ///                                                   ///
        ///        ----        MISCELANEOUS        ----       ///
        ///                                                   ///


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

    }
}
