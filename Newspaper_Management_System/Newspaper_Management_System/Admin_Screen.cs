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
    public partial class Admin_Screen : Form
    {
        SqlCommand cmd;
        SqlDataAdapter sda;
        SqlConnection conn = new SqlConnection(@"Data Source=ASMAR\SQLEXPRESS;Initial Catalog=npm;Integrated Security=True");
        public Admin_Screen()
        {
            InitializeComponent();
        }

        private void mZ3ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void customerBill1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void customerBill1ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void Admin_Screen_Load(object sender, EventArgs e)
        {

        }

        private void newsPaperEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            News_Paper_Registeration NR = new News_Paper_Registeration();
            NR.Show();
            this.Hide();
        }

        private void newsPaperEdiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Newspaper_Edit NR = new Newspaper_Edit();
            NR.Show();
            this.Hide();
        }

        private void magaZineRegisterationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Magazine_Registeration MR = new Magazine_Registeration();
            MR.Show();
            this.Hide();
        }

        private void magaZineEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Magazine_edit ME = new Magazine_edit();
            ME.Show();
            this.Hide();
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nPBill1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NP_Bill1 B1 = new NP_Bill1();
            B1.Show();
            this.Hide();
        }

      

        private void mGBill1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MG_Bill1 M1 = new MG_Bill1();
            M1.Show();
            this.Hide();

        }

       
    }
}
