﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logBookFrw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            SignIn signin = new SignIn();
            signin.ShowDialog();
              this.Close();
            this.Dispose();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            Registration regist = new Registration();
            regist.ShowDialog();
            this.Close();
            
        }
    }
}
