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
    public partial class adauga : UserControl
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\coste\Desktop\agentieimob.accdb");
        public adauga()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        // Adaugare in baza de date
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into table1 values('"+addoras.Text+"', '"+ addjudet.Text+ "', '" + addnrcamere.Text + "', '" + addsuprafata.Text + "', '" + addpret.Text + "')";
            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Datele au fost adaugate cu succes.");

;        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
