using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp33
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer_tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString("HH:mm");
            lblsecond.Text = DateTime.Now.ToString("ss");
            lbldate.Text = DateTime.Now.ToString("mm dd yyyy");
            label6.Text = DateTime.Now.ToString("dddd");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {
            timer1.Start();
        }

        private void btnequipment_Click(object sender, EventArgs e)
        {
            Equipments.Form1 vv = new Equipments.Form1();
            
            vv.Show();
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            GymManagement.NewMemberHomePage vv = new GymManagement.NewMemberHomePage();

            vv.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNewStaff_Click(object sender, EventArgs e)
        {
            GYM_STAFF.Form1 vv = new GYM_STAFF.Form1();
            vv.Show();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            payment.Form1 vv = new payment.Form1();
            vv.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lbldate_Click(object sender, EventArgs e)
        {

        }

        private void lblsecond_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gym_Management_System.Formz vv = new Gym_Management_System.Formz();
            vv.Show();
        }
    }
}
