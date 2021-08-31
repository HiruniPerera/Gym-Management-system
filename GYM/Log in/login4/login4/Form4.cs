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

namespace login4
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'netmiDataSet.signup' table. You can move, or remove it, as needed.
            this.signupTableAdapter.Fill(this.netmiDataSet.signup);
            string Constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lasal\Desktop\GYM\Log in\login4\login4\netmi.mdf;Integrated Security=True;Connect Timeout=30";
            string query = "Select * from signup";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Constring);
            DataSet set = new DataSet();
            adapter.Fill(set, "signup");
            DGV1.DataSource = set.Tables["signup"];


        }

        private void btnview_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fm1 = new Form1();
            fm1.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 vv = new Form2();
            this.Hide();
            vv.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
