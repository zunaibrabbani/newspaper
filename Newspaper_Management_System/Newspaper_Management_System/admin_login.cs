using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Newspaper_Management_System
{
    public partial class admin_login : Form
    {
        SqlCommand cmd;
        SqlDataAdapter sda;
        SqlConnection conn = new SqlConnection(@"Data Source=ASMAR\SQLEXPRESS;Initial Catalog=npm;Integrated Security=True");
        public admin_login()
        {
            InitializeComponent();
        }

        private void admin_login_Load(object sender, EventArgs e)
        {
            
            
            this.label1.Text = "Admin Login";
            this.label2.Text = "User Name";
            this.label3.Text = "Passwrd";
            this.button1.Text = "Reset";
            this.button2.Text = "login";
            this.button3.Text = "Back";
            
        }

      

        private void button3_Click(object sender, EventArgs e)
        {
            Login_Form lf = new Login_Form();
            lf.Show();
            this.Hide();
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            this.textBox1.Text = "";
            this.textBox2.Text = "";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from user_n where name='" + textBox1.Text + "' and password='" + textBox2.Text + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Admin_Screen Ads = new Admin_Screen();
                Ads.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("invalid user or password");

            }
        }
    }
}
