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
    public partial class NP_Bill1 : Form
    {
        SqlCommand cmd;
        SqlDataAdapter sda;
        SqlConnection conn = new SqlConnection(@"Data Source=ASMAR\SQLEXPRESS;Initial Catalog=npm;Integrated Security=True");
        public NP_Bill1()
        {
            InitializeComponent();
        }

        private void NP_Bill1_Load(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("select CNAME from NR", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["CNAME"].ToString());
            }
            conn.Close();
            this.label1.Text = "Paper Sales Details";
            this.label2.Text = "Customer Name";
            this.label3.Text = "Paper Name";
            this.label4.Text = "Language";
            this.label5.Text = "Price";
            this.label6.Text = "Description";
            this.label7.Text = "Coverage";
            
            this.label9.Text = "Total Price";
            this.label10.Text = "Bill Number";
            
            this.button1.Text = "Save";
            this.button2.Text = "Exit";
            this.button3.Text = "Back";
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("select * from NR  where CNAME='" + comboBox1.Text + "'", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox7.Text = dr["PNAME"].ToString();
                textBox1.Text = dr["LANGUAGE"].ToString();
                textBox2.Text = dr["PRICE"].ToString();
                textBox3.Text = dr["DESCRIPTION"].ToString();
                textBox4.Text = dr["COVERAGE"].ToString();


            }
            conn.Close();

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_BindingContextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            int c;
            a = Convert.ToInt32(textBox8.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = a * b;
            textBox5.Text = c.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("insert into NB(CNAME,PNAME,LANGUAGE,PRICE,DESCRIPTION,COVERAGE,QUANTITY,TOTALPRICE,BILLNO) VALUES(@CNAME,@PNAME,@LANGUAGE,@PRICE,@DESCRIPTION,@COVERAGE,@QUANTITY,@COVERAGE,@BILLNO)", conn);
            cmd.Parameters.AddWithValue("PNAME", this.textBox7.Text);
            cmd.Parameters.AddWithValue("LANGUAGE", this.textBox1.Text);
            cmd.Parameters.AddWithValue("PRICE", this.textBox2.Text);
            cmd.Parameters.AddWithValue("DESCRIPTION", this.textBox3.Text);
            cmd.Parameters.AddWithValue("COVERAGE", this.textBox4.Text);
            cmd.Parameters.AddWithValue("CNAME", this.comboBox1.Text);
            cmd.Parameters.AddWithValue("QUANTITY", this.textBox8.Text);
            cmd.Parameters.AddWithValue("TOTALPRICE", this.textBox5.Text);
            cmd.Parameters.AddWithValue("BILLNO", this.textBox6.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("ur record has ben inserted");
            Admin_Screen ad = new Admin_Screen();
            ad.Show();
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
