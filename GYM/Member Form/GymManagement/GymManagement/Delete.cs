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
using System.Text.RegularExpressions;

namespace GymManagement
{
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Delete_Load(object sender, EventArgs e)
        {
            disp_data();
        }
        public void disp_data()
        {
            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lasal\Desktop\GYM\Member Form\NewMember.mdf;Integrated Security=True;Connect Timeout=30";
            string qry = "SELECT * from MemberInfo";
            SqlDataAdapter da = new SqlDataAdapter(qry, conString);
            DataSet ds = new DataSet();
            da.Fill(ds, "MemberInfo");
            DGV1.DataSource = ds.Tables["MemberInfo"];
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int MemID = int.Parse(txtMembershipID.Text);
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lasal\Desktop\GYM\Member Form\NewMember.mdf;Integrated Security=True;Connect Timeout=30");
            string del = "DELETE from MemberInfo where MembershipID = '" + MemID + "'";
            SqlCommand cmd = new SqlCommand(del, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Deleted Successfully.");

            }
            catch(SqlException sqlex)
            {
                MessageBox.Show("" + sqlex);
            }

            disp_data();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtMembershipID.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NewMemberHomePage nwm = new NewMemberHomePage();
            nwm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtMembershipID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter valid value");

            }
        }
    }
}
