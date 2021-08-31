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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lasal\Desktop\GYM\Log in\login4\login4\netmi.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "select*from signup where username='" + textBox2.Text + "' AND password='" + textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    this.Hide();
                    WindowsFormsApp33.Form1 rr = new WindowsFormsApp33.Form1();
                    rr.Show();
                }
                else
                {
                    MessageBox.Show("Invalid entry,please retry.");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 r = new Form1();
            r.Show();

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked == true)
            {
                textBox1.UseSystemPasswordChar = false;

            }
            else
            {
                textBox1.UseSystemPasswordChar = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 vv = new Form4();
            vv.Show();
            this.Hide();
        }
    }
    }

