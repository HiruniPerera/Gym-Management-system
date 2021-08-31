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

namespace GYM_STAFF
{
    public partial class Update_Staff : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lasal\Desktop\GYM\Staff window C#\StaffDB.mdf;Integrated Security=True;Connect Timeout=30");
        string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lasal\Desktop\GYM\Staff window C#\StaffDB.mdf;Integrated Security=True;Connect Timeout=30";
        public Update_Staff()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 objHome = new Form1();
            objHome.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
          
            string Fname, LName, EMail, GEnder, joindate, time;
            string Sage, mobile, id;


            Fname = txtSFirstnameUp.Text;
            LName = txtSLastnameUp.Text;
            GEnder = "";
            bool isChecked = radioButtonUpdateMale.Checked;
            if (isChecked)
            {
                GEnder = radioButtonUpdateMale.Text;
            }
            else
            {
                GEnder = radioButtonUpdateFemale.Text;
            }

            joindate = dateTimePickerUpdate.Text;
            EMail = txtSEmailUp.Text;
            Sage = txtSAgeUp.Text;
            id = txtSIDUp.Text;

            mobile = txtSContactUp.Text;
            time = comboBoxUpdate.Text;

            if (comboBoxUpdate.SelectedIndex == -1)
            {
                MessageBox.Show("Choose your working time");
            }










            else
            {


                String upd = "Update Staff SET FirstName='" + Fname + "',LastName='" + LName + "',JoinedDate='" + joindate + "',Age='" + Sage + "',WorkingTime='" + time + "',Email='" + EMail + "',ContactNo='" + mobile + "',Gender='" + GEnder + "' where StaffID='" + id + "'";
                SqlCommand cmd = new SqlCommand(upd, con);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Updated Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }

                finally
                {
                    con.Close();
                }
                txtSIDUp.Text = "";
                txtSFirstnameUp.Text = "";
                txtSLastnameUp.Text = "";
                dateTimePickerUpdate.Text = "";
                txtSAgeUp.Text = "";
                comboBoxUpdate.SelectedIndex = -1 ;
                txtSEmailUp.Text = "";
                txtSContactUp.Text = "";
                radioButtonUpdateMale.Checked = false;
                radioButtonUpdateFemale.Checked = false;


            }
        }

        private void txtSIDUp_TextChanged(object sender, EventArgs e)
        {
            con.Open();

            if (txtSIDUp.Text != "")
            {

                SqlCommand cmd = new SqlCommand("Select FirstName,LastName,JoinedDate,Age,WorkingTime,Email,ContactNo,Gender from Staff where StaffID=@StaffID", con);
                cmd.Parameters.AddWithValue("@StaffID", int.Parse(txtSIDUp.Text));
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    txtSFirstnameUp.Text = da.GetValue(0).ToString();
                    txtSLastnameUp.Text = da.GetValue(1).ToString();
                    dateTimePickerUpdate.Text = da.GetValue(2).ToString();
                    txtSAgeUp.Text = da.GetValue(3).ToString();
                    comboBoxUpdate.Text = da.GetValue(4).ToString();
                    txtSEmailUp.Text = da.GetValue(5).ToString();
                    txtSContactUp.Text = da.GetValue(6).ToString();
                  


                }

            }
            con.Close();
        }

        private void btnClearUP_Click(object sender, EventArgs e)
        {
            txtSFirstnameUp.Clear();
            txtSLastnameUp.Clear();
            dateTimePickerUpdate.ResetText();
            txtSAgeUp.Clear();
            txtSContactUp.Clear();
            txtSEmailUp.Clear();
            comboBoxUpdate.SelectedIndex = -1;
            radioButtonUpdateMale.Checked = false;
            radioButtonUpdateFemale.Checked = false;
        }

        private void Update_Staff_Load(object sender, EventArgs e)
        {

            string qry = "SELECT * from Staff";
            SqlDataAdapter da = new SqlDataAdapter(qry, constring);
            DataSet ds = new DataSet();
            da.Fill(ds, "Staff");
            dataGridView3.DataSource = ds.Tables["Staff"];
        }

        private void txtSEmailUp_Leave(object sender, EventArgs e)
        {
            Regex mRegxExpression;
            if (txtSEmailUp.Text.Trim() != string.Empty)
            {
                mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                if (!mRegxExpression.IsMatch(txtSEmailUp.Text.Trim()))
                {
                    MessageBox.Show("E-mail address format is not correct.", "MojoCRM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSEmailUp.Focus();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtSAgeUp_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Age should be numeric");
            }
        }

        private void txtSContactUp_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Contact number should be numeric");
            }
        }

        private void txtSFirstnameUp_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtSFirstnameUp_Validated(object sender, EventArgs e)
        {

        }
    }
}
