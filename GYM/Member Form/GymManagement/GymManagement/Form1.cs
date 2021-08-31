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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void disp_data()
        {
            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lasal\Desktop\GYM\Member Form\NewMember.mdf;Integrated Security=True;Connect Timeout=30";
            string qry = "SELECT * FROM MemberInfo";
            SqlDataAdapter da = new SqlDataAdapter(qry, conString);
            DataSet ds = new DataSet();
            da.Fill(ds,"MemberInfo");
            DGV1.DataSource = ds.Tables["MemberInfo"];
        }
        private void btnsave_Click(object sender, EventArgs e)
        {

              
            if (!(txtFirstName.Text==" " || txtLastName.Text==" " || rdbmale.Text==" "|| rdbfemale.Text=="" || dateTimePickerDOB.Text=="" || txtcontact.Text==" "|| txtemail.Text=="" || txtaddress.Text==" " || dateTimePickerjoindate.Text=="" ||  comboBoxfeemode.Text == "" || dateTimePickerstart.Text==" " || dateTimePickerend.Text=="" || txtdescription.Text=="" ||  txtweight.Text=="" || comboBoxstatus.Text=="" || comboBoxduration.Text==" " || txtpaidfee.Text==""))
            {
                string Firstname = txtFirstName.Text;
                string LastName = txtLastName.Text;
                int MemberId = int.Parse(txtmemberID.Text);
                string Gender = " ";
                bool isChecked = rdbmale.Checked;
                if (isChecked)
                {
                    Gender = rdbmale.Text;
                }
                else
                {
                    Gender = rdbfemale.Text;
                }
                string DOB = dateTimePickerDOB.Text;
                int Contact = int.Parse(txtcontact.Text);
                string Email = txtemail.Text;
                string Address = txtaddress.Text;
                string Occupation = txtoccupation.Text;
                string Joindate = dateTimePickerjoindate.Text;
                string Feemode = comboBoxfeemode.Text;
                string Startdate = dateTimePickerstart.Text;
                string Enddate = dateTimePickerend.Text;
                string Description = txtdescription.Text;
                int Weight = int.Parse(txtweight.Text);
                string Status = comboBoxstatus.Text;
                int Duration = int.Parse(comboBoxduration.Text);
                float Paidfee = float.Parse(txtpaidfee.Text);
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lasal\Desktop\GYM\Member Form\NewMember.mdf;Integrated Security=True;Connect Timeout=30");
                string query = "INSERT INTO MemberInfo VALUES('" + Firstname + "','" + LastName + "','"+MemberId+"','" + Gender + "','" + DOB + "','" + Contact + "','" + Email + "','" + Address + "','" + Occupation + "','" + Joindate + "','" + Feemode + "','" + Startdate + "','" + Enddate + "','" + Description + "','" + Weight + "','" + Status + "','" + Duration + "','" + Paidfee + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                try
                {
                    con.Open();
   
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Insrted Successfully");
                    disp_data();
                }
                catch (SqlException sqlex)
                {
                    MessageBox.Show(" " + sqlex);
                }
            }
            else
            {
                MessageBox.Show("Inseret Required Fields.");
            }
            

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

        
        private void Form1_Load(object sender, EventArgs e)
        {

            disp_data();
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NewMemberHomePage hme = new NewMemberHomePage();
            hme.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtemail_Leave(object sender, EventArgs e)
        {
            string pattern = "[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?";
            if(Regex.IsMatch(txtemail.Text,pattern))
            {
                errorProvider1.Clear();

            }
            else
            {
                errorProvider1.SetError(this.txtemail, "Please provide valid email address");
                return;
            }

        }

        private void dateTimePickerend_CloseUp(object sender, EventArgs e)
        {
            DateTime fromdate = Convert.ToDateTime(dateTimePickerstart.Text);
            DateTime todate1 = Convert.ToDateTime(dateTimePickerend.Text);
            if (fromdate <= todate1)
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
            if(comboBoxfeemode.SelectedItem == null)
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
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("A phone number cannot contain letters");
            }
        }

        private void txtcontact_Leave(object sender, EventArgs e)
        {
          if(!(txtcontact.TextLength == 10))
            {
                MessageBox.Show("Phone number should be 10 digits");
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
