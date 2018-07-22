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
    public partial class SignUPcs : Form
    {
        SqlCommand cmd;
        SqlDataAdapter sda;
        SqlConnection conn = new SqlConnection(@"Data Source=ASMAR\SQLEXPRESS;Initial Catalog=npm;Integrated Security=True");
        public SignUPcs()
        {
            InitializeComponent();
        }

        private void SignUPcs_Load(object sender, EventArgs e)
        {
            this.label1.Text = "SignUp";
            this.label2.Text = "User Name";
            this.label3.Text = "Passwrd";
            this.button1.Text = "Reset";
            this.button2.Text = "login";
            this.button3.Text = "Back";
            
                
        }

     

      

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("insert into user_n(name,password) VALUES(@name,@password)", conn);
            cmd.Parameters.AddWithValue("name", this.textBox1.Text);
            cmd.Parameters.AddWithValue("password", this.textBox2.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("ur record has ben inserted");
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login_Form lf = new Login_Form();
            lf.Show();
            this.Hide();
        
        }
    }
}
