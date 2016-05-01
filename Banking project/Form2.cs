using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking_project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Form2 = new insert();
            Form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Form2 = new login();
            Form2.Show();
        }
    }
}
