using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeManagementSoftware
{
    public partial class Form1 : Form
    {
        private ToolTip toolTip1;
        public Form1()
        {
            InitializeComponent();
            toolTip1 = new ToolTip();
            toolTip1.SetToolTip(button2, "This Contains the News Section");
            toolTip1.SetToolTip(button3, "This Contains the About Section");
            toolTip1.SetToolTip(button4, "This Contains the Branches Information");
            toolTip1.SetToolTip(button5, "This Contains the Student Services");
            toolTip1.SetToolTip(button6, "This Contains the Teacher Services");
            toolTip1.SetToolTip(button7, "Administer Login");
            this.FormClosed+=Form1_FormClosed;

        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HOD of All Departments: +919454821245\nPrincipal: +914871286875\nAdmin: +915482478681 and Email: college@admin.co\n\nPlease Keep it in Mind These Informations are Only Meant to Use for help,any misuse will lead to severe against the person.\nThanks","@About Us");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This section contains the newly posted informations", "@What's New?");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
            
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.Show();

        }
        private void button6_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            this.Hide();
            f4.Show();

        }
        private void button7_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            this.Hide();
            f5.Show();

        }
    }
}
