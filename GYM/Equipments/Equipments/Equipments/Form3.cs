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


namespace Equipments
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Form1 an = new Form1();
            an.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lasal\Documents\Equip.mdf;Integrated Security=True;Connect Timeout=30";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "Select * from Equip";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            richTextBox1.Clear();
            textBox3.Clear();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string id = textBox4.Text;
            string des = richTextBox1.Text;
            string mus = textBox2.Text;
            string cost = textBox3.Text;


            if (id =="" )
            {
                MessageBox.Show("Enter Required Feilds");
            }
            else
            {
                
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lasal\Documents\Equip.mdf;Integrated Security=True;Connect Timeout=30");

                if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && richTextBox1.Text == "")
                {

                    MessageBox.Show("Enter required data you need to Update");
                }
                else if (textBox2.Text == "" && textBox3.Text == "" && richTextBox1.Text == "" )
                {
                    string update = "UPDATE Equip SET Equipment_Name= '" + name + "' WHERE ID='" + id + "' ";
                    SqlCommand cmd = new SqlCommand(update, con);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Updated Successfully");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);
                    }
                }
                else if (textBox1.Text == "" && textBox3.Text == "" && richTextBox1.Text == "" )
                {
                    string update = "UPDATE Equip SET Muscles_Used= '" + mus + "' WHERE ID='" + id + "' ";
                    SqlCommand cmd = new SqlCommand(update, con);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Updated Successfully");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);
                    }
                }
                else if (textBox2.Text == "" && textBox1.Text == "" && richTextBox1.Text == "" )
                {
                    string update = "UPDATE Equip SET Cost= '" + cost + "' WHERE ID='" + id + "' ";
                    SqlCommand cmd = new SqlCommand(update, con);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Updated Successfully");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);
                    }
                }
                else if (textBox2.Text == "" && textBox3.Text == "" && textBox1.Text == ""  )
                {
                    string update = "UPDATE Equip SET Description= '" + des + "' WHERE ID='" + id + "' ";
                    SqlCommand cmd = new SqlCommand(update, con);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Updated Successfully");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);
                    }
                }
                else if (textBox2.Text == "" && textBox1.Text == ""  )
                {
                    string update = "UPDATE Equip SET Description= '" + des + "',Cost='"+cost+"' WHERE ID='" + id + "' ";
                    SqlCommand cmd = new SqlCommand(update, con);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Updated Successfully");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);
                    }
                }
                else if (textBox3.Text == "" && textBox1.Text == "" )
                {
                    string update = "UPDATE Equip SET Description= '" + des + "',Muscles_Used='" + mus + "' WHERE ID='" + id + "' ";
                    SqlCommand cmd = new SqlCommand(update, con);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Updated Successfully");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);
                    }
                }
                else if (richTextBox1.Text == "" && textBox1.Text == "" )
                {
                    string update = "UPDATE Equip SET Muscles_Used='" + mus + "',Cost='" + cost + "' WHERE ID='" + id + "' ";
                    SqlCommand cmd = new SqlCommand(update, con);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Updated Successfully");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);
                    }
                }
                else if (richTextBox1.Text == "" && textBox2.Text == "" )
                {
                    string update = "UPDATE Equip SET Equipment_Name= '" + name + "',Cost='" + cost + "' WHERE ID='" + id + "' ";
                    SqlCommand cmd = new SqlCommand(update, con);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Updated Successfully");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);
                    }
                }
                else if (richTextBox1.Text == "" && textBox3.Text == "" )
                {
                    string update = "UPDATE Equip SET Equipment_Name= '" + name + "',Muscles_Used='" + mus + "' WHERE ID='" + id + "' ";
                    SqlCommand cmd = new SqlCommand(update, con);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Updated Successfully");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);
                    }
                }
                else if (textBox2.Text == "" && textBox3.Text == "" )
                {
                    string update = "UPDATE Equip SET Equipment_Name= '" + name + "',Description='" + des + "' WHERE ID='" + id + "' ";
                    SqlCommand cmd = new SqlCommand(update, con);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Updated Successfully");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);
                    }
                }

                else if (textBox1.Text == "")
                {
                    string update = "UPDATE Equip SET Description= '" + des + "',Muscles_Used='" + mus + "',Cost='"+cost+ "' WHERE ID='" + id + "' ";
                    SqlCommand cmd = new SqlCommand(update, con);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Updated Successfully");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);
                    }
                }
                else if (textBox2.Text == "")
                {
                    string update = "UPDATE Equip SET Description= '" + des + "',Equipment_Name= '" + name + "',Cost='" + cost + "' WHERE ID='" + id + "' ";
                    SqlCommand cmd = new SqlCommand(update, con); 

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Updated Successfully");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);
                    }
                }
                else if (richTextBox1.Text == "")
                {
                    string update = "UPDATE Equip SET Equipment_Name= '" + name + "',Muscles_Used='" + mus + "',Cost='" + cost + "' WHERE ID='" + id + "' ";
                    SqlCommand cmd = new SqlCommand(update, con);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Updated Successfully");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);
                    }
                }
                
                else if (textBox3.Text == "")
                {
                    string update = "UPDATE Equip SET Equipment_Name= '" + name + "',Muscles_Used='" + mus + "',Description='" + des + "' WHERE ID='" + id + "' ";
                    SqlCommand cmd = new SqlCommand(update, con);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Updated Successfully");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);
                    }
                }

            }

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter a Valid Value");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
