using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagement
{
    public partial class NewMemberHomePage : Form
    {
        public NewMemberHomePage()
        {
            InitializeComponent();
        }

        private void NewMemberHomePage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fm1 = new Form1();
            fm1.Show();
            this.Hide();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Update up1 = new Update();
            up1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Delete del = new Delete();
            del.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Search sh1 = new Search();
            sh1.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
