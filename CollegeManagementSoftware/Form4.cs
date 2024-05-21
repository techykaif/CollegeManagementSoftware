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
    public partial class Form4 : Form
    {
        private ToolTip toolTip1;
        private string captchaText;
        public Form4()
        {
            InitializeComponent();
            toolTip1 = new ToolTip();
            toolTip1.SetToolTip(button1, "Click this button to Login");
            toolTip1.SetToolTip(button2, "Click this Button to Reset");
            toolTip1.SetToolTip(button3, "Click this Button to Refresh the Captcha");
            GenerateCaptcha();
            this.FormClosed += Form4_FormClosed;
        }
        private void Form4_FormClosed(object sender, FormClosedEventArgs e) {
            MessageBox.Show("Good Bye", "Alert");
            Application.Exit();
        }
        private void GenerateCaptcha()
        {
            captchaText = GenerateRandomText();
            DrawCaptchaImage(captchaText);
        }
        private string GenerateRandomText()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, 6).Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private void DrawCaptchaImage(string text)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.DrawString(text, new Font("Arial", 20), Brushes.Black, new PointF(20, 10));
            pictureBox1.Image = bmp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.Text = "";
            GenerateCaptcha();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GenerateCaptcha();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (captchaText == textBox3.Text)
            {
                if (textBox1.Text == "admin" && textBox2.Text == "admin")
                {
                    MessageBox.Show("Login Successful", "Alert");
                    Form6 f6 = new Form6();
                    f6.Show();
                    this.Hide();
                }
                else if (textBox1.Text == "admin" || textBox2.Text == "admin")
                {
                    MessageBox.Show("Either Username or Password is Incorrect", "Login Failed");
                }
                else
                {
                    MessageBox.Show("Please Enter Correct Details", "Contact Your Organization");
                }
            }
            else
            {
                MessageBox.Show("Captcha Incorrect or Blank", "Captcha Error");
            }
        }
    }
}
