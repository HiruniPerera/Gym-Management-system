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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
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
        private void Update_Load(object sender, EventArgs e)
        {
            
            disp_data();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (!(txtFirstName.Text == " " || txtLastName.Text == " " || rdbmale.Text == " " || rdbfemale.Text == "" || dateTimePickerDOB.Text == "" || txtcontact.Text == " " || txtemail.Text == "" || txtaddress.Text == " " || dateTimePickerjoindate.Text == "" || comboBoxfeemode.Text == "" || dateTimePickerstart.Text == " " || dateTimePickerend.Text == "" || txtdescription.Text == "" || txtweight.Text == "" || comboBoxstatus.Text == "" || comboBoxduration.Text == " " || txtpaidfee.Text == ""))
            {
                string gender;
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lasal\Desktop\GYM\Member Form\NewMember.mdf;Integrated Security=True;Connect Timeout=30");
                if (rdbmale.Checked)
                {
                    gender = "male";
                }
                else
                {
                    gender = "female";
                }
                string query = "Update MemberInfo SET FirstName ='" + txtFirstName.Text + "', LastName ='" + txtLastName.Text + "', Gender = '" + gender + "', DateOfBirth='" + dateTimePickerDOB.Text + "', ContactNumber='" + txtcontact.Text + "',Email='" + txtemail.Text + "',Address='" + txtaddress.Text + "',Occupation='" + txtoccupation.Text + "',JoinDate='" + dateTimePickerjoindate.Text + "',FeeMode='" + comboBoxfeemode.Text + "',StartDate='" + dateTimePickerstart.Text + "',EndDate='" + dateTimePickerend.Text + "',Description='" + txtdescription.Text + "',Weight='" + txtweight.Text + "',Status='" + comboBoxstatus.Text + "',Duration='" + comboBoxduration.Text + "',PaidFee='" + txtpaidfee.Text + "' WHERE MembershipID ='" + txtmemberID.Text + "' ";
                SqlCommand cmd = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Updated Successfully");
                }
                catch (SqlException sqlex)
                {
                    MessageBox.Show("" + sqlex);
                }


                string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lasal\Desktop\GYM\Member Form\NewMember.mdf;Integrated Security=True;Connect Timeout=30";
                string qry = "SELECT * from MemberInfo";
                SqlDataAdapter da = new SqlDataAdapter(qry, conString);
                DataSet ds = new DataSet();
                da.Fill(ds, "MemberInfo");
                DGV1.DataSource = ds.Tables["MemberInfo"];
            }
            else
            {
                MessageBox.Show("Enter required fields");
            }

        }

        private void DGV1_MouseClick(object sender, MouseEventArgs e)
        {
            txtFirstName.Text = DGV1.SelectedRows[0].Cells[0].Value.ToString();
            txtLastName.Text = DGV1.SelectedRows[0].Cells[1].Value.ToString();
            txtmemberID.Text = DGV1.SelectedRows[0].Cells[2].Value.ToString();
            if (DGV1.SelectedRows[0].Cells[3].Value.ToString().Trim() == "Male")
            {
                rdbmale.Checked = true;
            }
            else
            {
                rdbfemale.Checked = true;
            }
            dateTimePickerDOB.Text = DGV1.SelectedRows[0].Cells[4].Value.ToString();
            txtcontact.Text = DGV1.SelectedRows[0].Cells[5].Value.ToString();
            txtemail.Text = DGV1.SelectedRows[0].Cells[6].Value.ToString();
            txtaddress.Text = DGV1.SelectedRows[0].Cells[7].Value.ToString();
            txtoccupation.Text = DGV1.SelectedRows[0].Cells[8].Value.ToString();
            dateTimePickerjoindate.Text = DGV1.SelectedRows[0].Cells[9].Value.ToString();
            comboBoxfeemode.Text = DGV1.SelectedRows[0].Cells[10].Value.ToString();
            dateTimePickerstart.Text = DGV1.SelectedRows[0].Cells[11].Value.ToString();
            dateTimePickerend.Text = DGV1.SelectedRows[0].Cells[12].Value.ToString();
            txtdescription.Text = DGV1.SelectedRows[0].Cells[13].Value.ToString();
            txtweight.Text = DGV1.SelectedRows[0].Cells[14].Value.ToString();
            comboBoxstatus.Text = DGV1.SelectedRows[0].Cells[15].Value.ToString();
            comboBoxduration.Text = DGV1.SelectedRows[0].Cells[16].Value.ToString();
            txtpaidfee.Text = DGV1.SelectedRows[0].Cells[17].Value.ToString();

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtmemberID.Clear();
            rdbfemale.Checked = false;
            rdbmale.Checked = false;
            dateTimePickerDOB.ResetText();
            txtcontact.Clear();
            txtemail.Clear();
            txtaddress.Clear();
            txtoccupation.Clear();
            dateTimePickerjoindate.ResetText();
            comboBoxfeemode.SelectedIndex = -1;
            dateTimePickerstart.ResetText();
            dateTimePickerend.ResetText();
            txtdescription.Clear();
            txtweight.Clear();
            comboBoxstatus.SelectedIndex = -1;
            comboBoxduration.SelectedIndex = -1;
            txtpaidfee.Clear();
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

        private void txtemail_Leave(object sender, EventArgs e)
        {
            string pattern = (@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

            if (Regex.IsMatch(txtemail.Text,pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.txtemail, "Please provide valid Mail address");
                return;
            }
        }

        private void dateTimePickerend_CloseUp(object sender, EventArgs e)
        {
            DateTime fromdate = Convert.ToDateTime(dateTimePickerstart.Text);
            DateTime todate1 = Convert.ToDateTime(dateTimePickerend.Text);
            if(fromdate <= todate1)
            {
                

                TimeSpan daycount = todate1.Subtract(fromdate);
                int dacount1 = Convert.ToInt32(daycount.Days) + 1;
                
            }
            else
            {
                MessageBox.Show("From data must be less than To date");
            }

        }

        private void comboBoxfeemode_Leave(object sender, EventArgs e)
        {
            if (comboBoxfeemode.SelectedItem == null)
            {
                errorProvider1.SetError(comboBoxfeemode, "Please select a item from combobox");
            }
            else
            {
                errorProvider1.Clear();
            }

        }

        private void comboBoxstatus_Leave(object sender, EventArgs e)
        {
            if (comboBoxstatus.SelectedItem == null)
            {
                errorProvider1.SetError(comboBoxstatus, "Please select a item from combobox");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void comboBoxduration_Leave(object sender, EventArgs e)
        {
            if (comboBoxduration.SelectedItem == null)
            {
                errorProvider1.SetError(comboBoxduration, "Please select a item from combobox");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtcontact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("A phone number cannot contain letters");
            }
        }

        private void txtweight_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter valid value");

            }
        }

        private void txtmemberID_KeyPress(object sender, KeyPressEventArgs e)
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
