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

namespace GymManagement
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
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

        private void Search_Load(object sender, EventArgs e)
        {
            disp_data();

        }


        private void btnsearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lasal\Desktop\GYM\Member Form\NewMember.mdf;Integrated Security=True;Connect Timeout=30");
            string qry = "SELECT * from MemberInfo where MembershipID = '"+txtMembershipID.Text+"'";
    
            SqlDataAdapter da = new SqlDataAdapter(qry, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "MemberInfo");
            DGV1.DataSource = ds.Tables["MemberInfo"];
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtMembershipID.Clear();
            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lasal\Desktop\GYM\Member Form\NewMember.mdf;Integrated Security=True;Connect Timeout=30";
            string qry = "SELECT * from MemberiNFO";
            SqlDataAdapter da = new SqlDataAdapter(qry, conString);
            DataSet ds = new DataSet();
            da.Fill(ds, "MemberInfo");
            DGV1.DataSource = ds.Tables["MemberInfo"];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NewMemberHomePage hm1 = new NewMemberHomePage();
            hm1.Show();
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
