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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Date.Value = DateTime.Today;

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Form1 an = new Form1();
            an.Show();
            this.Hide();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text=="" || textBox3.Text=="" || richTextBox1.Text=="" )
            {
                MessageBox.Show("Enter Required Feilds");
            }
            else
            {
                string name = textBox1.Text;
                string des = richTextBox1.Text;
                string mus = textBox2.Text;
                string cost = textBox3.Text;
                string del = Convert.ToString(Date.Value);


                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lasal\Documents\Equip.mdf;Integrated Security=True;Connect Timeout=30");
                string qry = "Insert into Equip Values('" + name + "','"+des+"','"+mus+"','"+del+"','"+cost+"')";
                SqlCommand cmd = new SqlCommand(qry, con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Inserted Successfully");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }

            }

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            richTextBox1.Clear();
            textBox3.Clear();
            Date.Value=DateTime.Now;

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter a Numeric Value");
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
