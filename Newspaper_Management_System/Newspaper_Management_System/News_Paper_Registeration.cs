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
    public partial class News_Paper_Registeration : Form
    {
        SqlCommand cmd;
        SqlDataAdapter sda;
        SqlConnection conn = new SqlConnection(@"Data Source=ASMAR\SQLEXPRESS;Initial Catalog=npm;Integrated Security=True");
        public News_Paper_Registeration()
        {
            InitializeComponent();
        }

        private void News_Paper_Registeration_Load(object sender, EventArgs e)
        {
            
            this.label2.Text = "News Paper";
            this.label3.Text = "Language";
            this.label4.Text = "Price";
            this.label5.Text = "Description";
            this.label6.Text = "Coverage";
            this.button1.Text = "Save";
            this.button2.Text = "Exit";
            this.button3.Text = "Back";
            }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin_Screen AS = new Admin_Screen();
            AS.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("insert into NR(CNAME,PNAME,LANGUAGE,PRICE,DESCRIPTION,COVERAGE) VALUES(@CNAME,@PNAME,@LANGUAGE,@PRICE,@DESCRIPTION,@COVERAGE)", conn);
            cmd.Parameters.AddWithValue("PNAME", this.textBox1.Text);
            cmd.Parameters.AddWithValue("LANGUAGE", this.textBox2.Text);
            cmd.Parameters.AddWithValue("PRICE", this.textBox3.Text);
            cmd.Parameters.AddWithValue("DESCRIPTION", this.textBox4.Text);
            cmd.Parameters.AddWithValue("COVERAGE", this.textBox5.Text);
            cmd.Parameters.AddWithValue("CNAME", this.textBox6.Text);
            
            cmd.ExecuteNonQuery();
            MessageBox.Show("ur record has ben inserted");
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
