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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.CUSTOMER' table. You can move, or remove it, as needed.
            this.cUSTOMERTableAdapter.Fill(this.dataSet1.CUSTOMER);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oradb1 = "Data Source=XE;User Id=system;Password=admin;";
            //string query2 = "update vidya.STUDENTS set NAME='" + textBox2.Text + "' WHERE STUDENT_ID=" + textBox1.Text + " ";
            OracleConnection conn1 = new OracleConnection(oradb1);
            conn1.Open();
            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = conn1;
            //OracleDataAdapter da = new OracleDataAdapter(query2, conn1);
            //DataSet d = new DataSet();
            //da.Fill(d, "STUDENTS");
            //dataGridView1.DataSource = d.Tables[0];

            cmd1.CommandText = "update vidya.STUDENTS set NAME='" + textBox2.Text + "' WHERE STUDENT_ID=" + textBox1.Text + " ";
            int rowsUpdated = cmd1.ExecuteNonQuery();
            if (rowsUpdated == 0)
                MessageBox.Show("Record not UPDATED");
            else
                MessageBox.Show("SuccessFULLY UPDATED!");
            conn1.Dispose();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string oradb1 = "Data Source=XE;User Id=system;Password=admin;";
            string query2 = "select name, pan, balance from  bank.customer  WHERE email='" + textBox1.Text + "'and password='" + textBox2.Text + "' ";
            OracleConnection conn1 = new OracleConnection(oradb1);
            conn1.Open();
            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = conn1;
            OracleDataAdapter da = new OracleDataAdapter(query2, conn1);
            DataSet d = new DataSet();
            da.Fill(d, "customer");
            dataGridView1.DataSource = d.Tables[0];


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string oradb1 = "Data Source=XE;User Id=system;Password=admin;";
            OracleConnection conn1 = new OracleConnection(oradb1);
            conn1.Open();
            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = conn1;
            cmd1.CommandText = "update bank.customer set address='" + textBox3.Text + "' WHERE email='" + textBox1.Text + "' and password='" + textBox2.Text + "' ";
            int rowsUpdated = cmd1.ExecuteNonQuery();
            if (rowsUpdated == 0)
                MessageBox.Show("Record not UPDATED");
            else
                MessageBox.Show("SuccessFULLY UPDATED!");
            conn1.Dispose();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string oradb1 = "Data Source=XE;User Id=system;Password=admin;";
            OracleConnection conn1 = new OracleConnection(oradb1);
            conn1.Open();
            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = conn1;
            cmd1.CommandText = "update bank.customer set MOBILE='" + textBox4.Text + "' WHERE email='" + textBox1.Text + "' and password='" + textBox2.Text + "' ";
            int rowsUpdated = cmd1.ExecuteNonQuery();
            if (rowsUpdated == 0)
                MessageBox.Show("Record not UPDATED");
            else
                MessageBox.Show("SuccessFULLY UPDATED!");
            conn1.Dispose();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string oradb1 = "Data Source=XE;User Id=system;Password=admin;";
            OracleConnection conn1 = new OracleConnection(oradb1);
            conn1.Open();
            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = conn1;
            cmd1.CommandText = "update bank.customer set password='" + textBox3.Text + "' WHERE email='" + textBox1.Text + "' and password='" + textBox2.Text + "' ";
            int rowsUpdated = cmd1.ExecuteNonQuery();
            if (rowsUpdated == 0)
                MessageBox.Show("Record not UPDATED");
            else
                MessageBox.Show("SuccessFULLY UPDATED!");
            conn1.Dispose();

        }

        private void button5_Click(object sender, EventArgs e)
        {

            string message = "You really want to delete your accounr?";
            string caption = "Error Detected in Input";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result=MessageBox.Show("Are you sure you want to delete your account?", caption,buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                string oradb = "Data Source=XE;User Id=system;Password=admin;";
                OracleConnection conn = new OracleConnection(oradb);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Delete from bank.customer where email='" + textBox1.Text + "' and password='" + textBox2.Text + "' ";
                int rowsUpdated = cmd.ExecuteNonQuery();
                if (rowsUpdated == 0)
                    MessageBox.Show("Record not deleted");
                else
                    MessageBox.Show("Successfully deleted!");
                conn.Dispose();
            }
        }
    }
}
