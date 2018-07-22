using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Newspaper_Management_System
{
    public partial class Login_Form : Form
    {
        SqlCommand cmd;
        SqlDataAdapter sda;
        SqlConnection conn = new SqlConnection(@"Data Source=ASMAR\SQLEXPRESS;Initial Catalog=npm;Integrated Security=True");
        public Login_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin_login al = new admin_login();
            al.Show();
            this.Hide();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            this.label1.Text = "News Paper Management System";
            this.button1.Text = "LOGIN";
            
            this.button3.Text = "SIGNUP";
            
            
        }

      

        private void button3_Click(object sender, EventArgs e)
        {
           

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SignUPcs su = new SignUPcs();
            su.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            admin_login al = new admin_login();
            al.Show();
            this.Hide();
        }
    }
}
