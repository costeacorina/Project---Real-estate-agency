﻿using System;
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
    public partial class oferte : UserControl
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\coste\Desktop\agentieimob.accdb");
        public oferte()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            string cautare = "SELECT * FROM Table1";
            //OleDbCommand cmd = con.CreateCommand();
            OleDbCommand cmd = new OleDbCommand(cautare, con);
            // DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Table1");
            label1.Text = "Oras" + "\n" + "\n" + "\n";
            label2.Text = "Judet" + "\n" + "\n" + "\n";
            label3.Text = "Nr camere" + "\n" + "\n" + "\n";
            label4.Text = "Suprafata" + "\n" + "\n" + "\n";
            label5.Text = "Pret" + "\n" + "\n" + "\n";
            foreach (DataRow r in ds.Tables["Table1"].Rows)
            {
                label1.Text = label1.Text + "\n" + r["Oras"] + "\n";
                label2.Text = label2.Text + "\n" + r["Judet"] + "\n";
                label3.Text = label3.Text + "\n" + r["NrCamere"] + "\n";
                label4.Text = label4.Text + "\n" + r["Suprafata"] + "\n";
                label5.Text = label5.Text + "\n" + r["Pret"] + "\n";
            }


            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = null;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void oferte_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}