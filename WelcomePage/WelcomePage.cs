﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace WelcomePage
{
    public partial class WelcomePage : Form
    {
        public static string connectionString { get; set; }
        public WelcomePage()
        {
            InitializeComponent();
            
        }



        private void Welcome_Click(object sender, EventArgs e)
        {
            // Your Welcome button click logic
        }

        private void LoginButt_Click(object sender, EventArgs e)
        {
            var openLogin = new Login();
            openLogin.Show();
            this.Close();
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            var openSignUp = new SignUp();
            openSignUp.Show();
            this.Close();
        }
        private void WelcomePage_Load(object sender, EventArgs e)
        {
            
        }



    }
}