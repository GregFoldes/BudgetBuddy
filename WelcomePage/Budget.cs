﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WelcomePage
{
    public partial class Budget : Form
    {
        public Budget()
        {
            InitializeComponent();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            var homeBut = new Home();
            homeBut.Show();
            this.Close();
        }


        private void oldBudgetButt_Click(object sender, EventArgs e)
        {
            var oldBudgetButt = new Home();
            oldBudgetButt.Show();
            this.Close();
        }
    }
}
