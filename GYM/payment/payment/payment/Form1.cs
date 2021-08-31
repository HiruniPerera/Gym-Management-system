using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace payment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(!(textBox4.Text=="" || textBox3.Text==""))
            {
                double price, total;
                string name, memberpackage;
                double memberperiod;
                //name = (textBox1.Text);
                memberpackage = (comboBox1.Text);
                price = double.Parse(textBox4.Text);
                memberperiod = double.Parse(textBox3.Text);
                total = memberperiod * price;
                textBox5.Text = "" + total;
            }

            else
            {
                MessageBox.Show("Enter required fields");
            }
          


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(!(textBox5.Text==""))
            {
                
                double discount;
               
                {


                    discount = double.Parse(textBox5.Text) * 0.03;
                    textBox6.Text = "" + discount;
                }
                
            }

            else
            {
                MessageBox.Show("Please Enter the Total Value");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(!(textBox5.Text=="" || textBox6.Text==""))
            {
                double payment;
                payment = double.Parse(textBox5.Text) - double.Parse(textBox6.Text);
                textBox7.Text = "" + payment;
            }
            else
            {
                MessageBox.Show("Please Fill the Total and the Discount Fields");
            }
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            {
                textBox1.Text = "";
                comboBox1.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                txtresult.Text = "";
            }
           

        }

        private void button6_Click(object sender, EventArgs e)
        {
           
            {
                txtresult.Clear();

                txtresult.Text += "***********GYM FITNESS*********\n";
                txtresult.Text += "\n\n";
                txtresult.Text += "Date:" + DateTime.Now + "\n\n";
                txtresult.Text += "Member Name: " + textBox1.Text + "\n\n";
                txtresult.Text += "Membership Package: " + comboBox1.Text + "\n\n";
                txtresult.Text += "Membership Period: " + textBox3.Text + "\n\n";
                txtresult.Text += "Price: " + textBox4.Text + "\n\n";
                txtresult.Text += "Total: " + textBox5.Text + "\n\n";
                txtresult.Text += "Discount: " + textBox6.Text + "\n\n";
                txtresult.Text += "Payment: " + textBox7.Text + "\n\n";
                txtresult.Text += "Member Signature: ";

            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
            {
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
           
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtresult.Text, new Font("Microsoft Sans Seriff", 18, FontStyle.Bold), Brushes.Black, new Point(10, 10));
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox1_keypress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("please enter a valid value");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
