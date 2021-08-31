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
    public partial class Delete_Staff : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lasal\Desktop\GYM\Staff window C#\StaffDB.mdf;Integrated Security=True;Connect Timeout=30");

        string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lasal\Desktop\GYM\Staff window C#\StaffDB.mdf;Integrated Security=True;Connect Timeout=30";
        public Delete_Staff()
        {
            InitializeComponent();
        }

        private void btnHome3_Click(object sender, EventArgs e)
        {

            Form1 Objhome = new Form1();
            Objhome.Show();
            this.Hide();
        }

        private void btnSDelete_Click(object sender, EventArgs e)
        {

            string del = "Delete from Staff where StaffID='" + int.Parse(txtSdelete.Text) + "'";
            SqlCommand cmd = new SqlCommand(del, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record deleted successfully");
                con.Close();
                txtSdelete.Text = "";

            }
            catch (Exception ep)
            {
                MessageBox.Show("" + ep);
            }
        }

        private void Delete_Staff_Load(object sender, EventArgs e)
        {

            string qry = "SELECT * from Staff";
            SqlDataAdapter da = new SqlDataAdapter(qry, constring);
            DataSet ds = new DataSet();
            da.Fill(ds, "Staff");
            dataGridView1.DataSource = ds.Tables["Staff"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
