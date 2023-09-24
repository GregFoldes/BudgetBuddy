using System;
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
    public partial class Login : Form
    {
        string UsernameInput = "";
        string PasswordInput = "";
        public Login()
        {
            InitializeComponent();
            label2.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            var homeBut = new WelcomePage();
            homeBut.Show();
            this.Close();
        }

        private void LoginSL_Click(object sender, EventArgs e)
        {
            if (UsernameInput == "admin" && PasswordInput == "nimda")
            {
                var homeBut = new Home();
                homeBut.Show();
                this.Close();
            }
            else
            {
                label2.Visible = true;
            }
        }

        public void Username_TextChanged(object sender, EventArgs e)
        {
            UsernameInput = Username.Text;

        }

        public void Password_TextChanged(object sender, EventArgs e)
        {
            Password.PasswordChar = '*';
            if (Password.Text == "")
            {
                LoginSL.Enabled = false;
            }
            else
            {
                PasswordInput = Password.Text;
                LoginSL.Enabled = true;
            }
            
        }
    }
}
