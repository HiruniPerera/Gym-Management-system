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

namespace GYM_STAFF
{
    public partial class View_Staff : Form
    {
        string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lasal\Desktop\GYM\Staff window C#\StaffDB.mdf;Integrated Security=True;Connect Timeout=30";
        public View_Staff()
        {
            InitializeComponent();
        }

        private void btnHome2_Click(object sender, EventArgs e)
        {
            Form1 objHOME = new Form1();
            objHOME.Show();
            this.Hide();
        }

        private void btnSSearch_Click(object sender, EventArgs e)
        {
            string go = "SELECT * FROM Staff where StaffID='" + int.Parse(TxtSIDView.Text) + "'";
            SqlDataAdapter da = new SqlDataAdapter(go, constring);
            DataSet ds = new DataSet();
            da.Fill(ds, "Staff");
            dataGridView1.DataSource = ds.Tables["Staff"];
        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            string qry = "SELECT * from Staff";
            SqlDataAdapter da = new SqlDataAdapter(qry, constring);
            DataSet ds = new DataSet();
            da.Fill(ds, "Staff");
            dataGridView1.DataSource = ds.Tables["Staff"];
        }

        private void View_Staff_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
