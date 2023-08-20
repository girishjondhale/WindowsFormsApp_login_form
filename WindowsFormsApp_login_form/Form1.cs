using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_login_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "admin" && txtpassword.Text == "admin123")
            {
                MessageBox.Show("Login Success");
            }
            else 
            {
                MessageBox.Show("login failed");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtpassword.Clear();
            txtusername.Clear();
        }
    }
}
