﻿using System;
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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            this.FormClosed += Form6_FormClosed;
        }
        private void Form6_FormClosed(object sender, FormClosedEventArgs e) { Application.Exit(); }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
