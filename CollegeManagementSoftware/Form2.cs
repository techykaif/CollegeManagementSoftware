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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.FormClosed+=Form2_FormClosed;
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Good Bye", "Alert");
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string description = "This is Description for M.B.A. Contents.";
            textBox1.Text = description;
        }

        private void ovalShape1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string description = "This is Description for B.C.A Contents.";
            textBox1.Text = description;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string description = "This is Description for M.C.A Contents.";
            textBox1.Text = description;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string description = "This is Description for B.B.A Contents.";
            textBox1.Text = description;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string description = "This is Description for B.Tech Contents";
            textBox1.Text = description;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
            
        }


       
    }
}
