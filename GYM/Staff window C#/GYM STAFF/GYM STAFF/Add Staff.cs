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
    public partial class Add_Staff : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lasal\Desktop\GYM\Staff window C#\StaffDB.mdf;Integrated Security=True;Connect Timeout=30");
        public Add_Staff()
        {
            InitializeComponent();
        }

        private void btnHome1_Click(object sender, EventArgs e)
        {
            Form1 objHome = new Form1();
            objHome.Show();
            this.Hide();
        }
        public void Retrieved()
        {
            try
            {
                string query = "Select StaffID from Staff";
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                }
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int value = int.Parse(reader[0].ToString()) + 1;
                    txtSID.Text = value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string FirstName, LastName, email, gender, Joindate, Gymtime;
            string age, ContactNo;



            FirstName = txtSFirstname.Text;
            LastName = txtSLastname.Text;
            gender = "";
            bool isChecked = radioButtonAddMale.Checked;
            if (isChecked)
            {
                gender = radioButtonAddMale.Text;
            }
            else
            {
                gender = radioButtonAddFemale.Text;
            }

            Joindate = dateTimePickerAdd.Text;
            email = txtSEmail.Text;
            age = txtSAge.Text;

            ContactNo = txtSContact.Text;
            Gymtime = comboBoxAdd.Text;



            if (txtSFirstname.Text == "")
            {
                MessageBox.Show("Fill all  fields");

            }
            else if (txtSLastname.Text == "")
            {
                MessageBox.Show("Fill all the fields");
            }
            else if (txtSEmail.Text == "")
            {
                MessageBox.Show("Fill all the fields");
            }
            else if (txtSAge.Text == "" )
            {
                MessageBox.Show("Fill all the fields");
            }
            else if (radioButtonAddFemale.Checked == false && radioButtonAddMale.Checked == false)
            {
                MessageBox.Show("Select the gender");
            }
            else if (comboBoxAdd.SelectedIndex == -1)
            {
                MessageBox.Show("Choose your working time");
            }
            else if (txtSContact.Text.Length != 10 || txtSContact.Text == "")
            {
                MessageBox.Show("Please enter a valid mobile number");
            }


            else
            {

                String qry = "Insert into Staff(FirstName,LastName,JoinedDate,Age,WorkingTime,Email,ContactNo,Gender) Values('" + FirstName + "','" + LastName + "','" + Joindate + "','" + age + "','" + Gymtime + "','" + email + "','" + ContactNo + "','" + gender + "')";
                SqlCommand cmd = new SqlCommand(qry, con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record inserted successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }

                finally
                {
                    con.Close();
                }

                txtSFirstname.Text = "";
                txtSLastname.Text = "";
                dateTimePickerAdd.Text = "";
                txtSAge.Text = "";
                comboBoxAdd.SelectedIndex = -1 ;
                txtSEmail.Text = "";
                txtSContact.Text = "";
                radioButtonAddMale.Checked = false;
                radioButtonAddFemale.Checked = false;



                try
                {
                    string query = "Select StaffID from Staff";
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();

                    }
                    SqlCommand cd = new SqlCommand(query, con);
                    SqlDataReader reader = cd.ExecuteReader();
                    while (reader.Read())
                    {
                        int value = int.Parse(reader[0].ToString()) + 1;
                        txtSID.Text = value.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
            }
        }

        private void Add_Staff_Load(object sender, EventArgs e)
        {
            Retrieved();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSFirstname.Clear();
            txtSLastname.Clear();
            dateTimePickerAdd.ResetText();
            txtSAge.Clear();
            txtSContact.Clear();
            txtSEmail.Clear();
            comboBoxAdd.SelectedIndex = -1;
            radioButtonAddMale.Checked = false;
            radioButtonAddFemale.Checked = false;

        }

        private void txtSEmail_Leave(object sender, EventArgs e)
        {
            Regex mRegxExpression;
            if (txtSEmail.Text.Trim() != string.Empty)
            {
                mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                if (!mRegxExpression.IsMatch(txtSEmail.Text.Trim()))
                {
                    MessageBox.Show("E-mail address format is not correct.", "MojoCRM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSEmail.Focus();
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

        private void txtSAge_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if(!Char.IsDigit(chr) && chr!=8)
            {
                e.Handled = true;
                MessageBox.Show("Age should be numeric");
            }
        }

        private void txtSContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Contact number should be numeric");
            }
        }
    }
}
