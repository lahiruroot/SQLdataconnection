using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=DESKTOP-Q1U27DT;Initial Catalog=connection;Integrated Security=True";
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'connectionDataSet.pub' table. You can move, or remove it, as needed.
            this.pubTableAdapter.Fill(this.connectionDataSet.pub);
            //clock session
            timer1.Start();
            lbldate.Text = DateTime.Now.ToLongTimeString();
            lbltime.Text = DateTime.Now.ToLongDateString();
            // clock session end
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void lbltime_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "insert into pub(client_id,client_name,mobilenumber,email)values('"+txtid.Text.ToString()+"','"+txtname.Text.ToString()+"','"+txtmob.Text.ToString()+"','"+txtemail.Text.ToString()+"')";
                SqlCommand cmd = new SqlCommand(q,con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data add successfuly...");
            }

        }
    }
}
