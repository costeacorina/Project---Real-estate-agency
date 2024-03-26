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
    public partial class login : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\coste\Desktop\conturi.accdb");
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            con.Open();

            string userpass = "SELECT * FROM cont where utilizator = '"+username.Text+"' and parola = '"+parolaa.Text+"'";
            OleDbCommand cmd = new OleDbCommand(userpass, con);
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataTable ds = new DataTable();
            adapter.Fill(ds);
            if (ds.Rows.Count == 1)
            {
                pgPrincipala pg = new pgPrincipala();
                pg.Show();
            }
            else
            {
                MessageBox.Show("Utilizator sau parola incorecte.");
            }


            con.Close();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            register reg = new register();
            reg.Show();
        }

        private void parolaa_TextChanged(object sender, EventArgs e)
        {
            parolaa.UseSystemPasswordChar = true;
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
