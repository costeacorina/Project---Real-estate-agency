using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Agentie_Imobiliara
{
    public partial class pgPrincipala : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\coste\Desktop\agentieimob.accdb");
        public pgPrincipala()
        {
            InitializeComponent();
            culoarebuton.Height = button4.Height;
            culoarebuton.Top = button4.Top;
            about1.BringToFront();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pgPrincipala_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            culoarebuton.Height = button1.Height;
            culoarebuton.Top = button1.Top;
            adauga1.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void oferte1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            culoarebuton.Height = button4.Height;
            culoarebuton.Top = button4.Top;
            about1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            culoarebuton.Height = button6.Height;
            culoarebuton.Top = button6.Top;
            oferte1.BringToFront();
            //con.Open();

            /*
            string cautare = "SELECT * FROM Table1";
            //OleDbCommand cmd = con.CreateCommand();
            OleDbCommand cmd = new OleDbCommand(cautare, con);
            // DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Table1");
            label1.Text = "Oras" + "\n"; label2.Text = "Judet" + "\n";
            foreach (DataRow r in ds.Tables["Table1"].Rows)
            {
                label1.Text = label1.Text + "\n" + r["Oras"] + "\n";
                label2.Text = label2.Text + "\n" + r["Judet"] + "\n";
            }


            con.Close();
            */
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            culoarebuton.Height = button2.Height;
            culoarebuton.Top = button2.Top;
            sterge1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            culoarebuton.Height = button3.Height;
            culoarebuton.Top = button3.Top;
            cauta1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            culoarebuton.Height = button5.Height;
            culoarebuton.Top = button5.Top;
            contact1.BringToFront();
        }
    }
}
