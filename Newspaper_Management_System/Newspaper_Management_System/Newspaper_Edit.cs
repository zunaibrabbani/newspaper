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
    public partial class Newspaper_Edit : Form
    {
        SqlCommand cmd;
        SqlDataAdapter sda;
        SqlConnection conn = new SqlConnection(@"Data Source=ASMAR\SQLEXPRESS;Initial Catalog=npm;Integrated Security=True");
        public Newspaper_Edit()
        {
            InitializeComponent();
        }

        private void Newspaper_Edit_Load(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("select CNAME from NR", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["CNAME"].ToString());
            }
            conn.Close();
           
            this.label2.Text = "Paper Name";
            this.label3.Text = "Language";
            this.label4.Text = "Price";
            this.label5.Text = "Description";
            this.label6.Text = "Coverage";
            this.button1.Text = "Update";
            
            this.button3.Text = "Exit";
            this.button4.Text = "Back";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admin_Screen AS = new Admin_Screen();
            AS.Show();
            this.Hide();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("select * from NR where CNAME='" + comboBox1.Text + "'", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox5.Text = dr["PNAME"].ToString();
                textBox1.Text = dr["LANGUAGE"].ToString();
                textBox2.Text = dr["PRICE"].ToString();
                textBox3.Text = dr["DESCRIPTION"].ToString();
                textBox4.Text = dr["COVERAGE"].ToString();
                

            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("Update NR set PNAME=@PNAME,LANGUAGE=@LANGUAGE,PRICE=@PRICE,DESCRIPTION=@DESCRIPTION,COVERAGE=@COVERAGE where CNAME=@CNAME ", conn);

            cmd.Parameters.AddWithValue("@LANGUAGE", textBox1.Text);
            cmd.Parameters.AddWithValue("@PRICE", textBox2.Text);
            cmd.Parameters.AddWithValue("@DESCRIPTION", textBox3.Text);
            cmd.Parameters.AddWithValue("@COVERAGE", textBox4.Text);
            cmd.Parameters.AddWithValue("@CNAME",comboBox1.Text);
            cmd.Parameters.AddWithValue("@PNAME", textBox5.Text);

            

            cmd.ExecuteNonQuery();
            MessageBox.Show("Record has been updated");
            conn.Close();
        }
    }
}
