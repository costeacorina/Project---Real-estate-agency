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
    public partial class register : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\coste\Desktop\conturi.accdb");
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\coste\Desktop\conturi.accdb");
        public register()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            con.Open();

            string userpass = "SELECT * FROM cont where utilizator = '"+userregister.Text+"' and parola = '"+passregister.Text+"'";
            OleDbCommand cmd = new OleDbCommand(userpass, con);
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataTable ds = new DataTable();
            adapter.Fill(ds);
            if (ds.Rows.Count == 1)
            {
                MessageBox.Show("Contul exista deja.");
            }
            else
            {
                if (string.Equals(passregister.Text, pass2register.Text))
                {

                    //parola
                    if (passregister.Text.Length <= 4)
                    {
                        MessageBox.Show("Parola este prea scurta.");

                    }
                    else if (passregister.Text.Length >= 10)
                    {
                        MessageBox.Show("Parola este prea lunga.");
                    }
                    else
                    {
                        conn.Open();

                        OleDbCommand cmdd = conn.CreateCommand();
                        cmdd.CommandType = CommandType.Text;
                        cmdd.CommandText = "insert into cont values('" + userregister.Text + "', '" + passregister.Text + "')";
                        cmdd.ExecuteNonQuery();

                        conn.Close();


                        MessageBox.Show("Contul a fost creat cu succes. Acum te poti conecta");
                    }
            }
            else
            {
                MessageBox.Show("Parolele nu se potrives.");
            }
            }


            con.Close();

        }

        private void userregister_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
