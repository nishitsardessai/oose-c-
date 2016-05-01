using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;



namespace Banking_project
{
    public partial class insert : Form
    {
        public insert()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string value = "";
            bool isChecked1 = radioButton1.Checked;
            bool isChecked2 = radioButton2.Checked;
            bool isChecked3 = radioButton3.Checked;
            bool isChecked4 = radioButton4.Checked;

            if (isChecked1)
                value = radioButton1.Text;
            else if (isChecked2)
                value = radioButton2.Text;
            else if (isChecked3)
                value = radioButton3.Text;
            else
                value = radioButton4.Text;



            string oradb = "Data Source=XE;User Id=system;Password=admin;";
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = "Insert into bank.customer values ('" + value + "','" + textBox1.Text + "' ,'" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "',0)";
           
            int rowsUpdated = cmd.ExecuteNonQuery();
            if (rowsUpdated == 0)
                MessageBox.Show("Record not inserted");
            else
                MessageBox.Show("Success!");
            conn.Dispose();







        }

        private void insert_Load(object sender, EventArgs e)
        {

        }
    }
}
