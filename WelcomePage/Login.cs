using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
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
            string username = Username.Text;
            string password = Password.Text;
            int counter = 0;


            StreamReader sr = new StreamReader("C:\\Users\\gtfol\\source\\repos\\BudgetBuddy\\WelcomePage\\TempDatabase\\accounts.txt");
            StreamWriter swa = new StreamWriter("C:\\Users\\gtfol\\source\\repos\\BudgetBuddy\\WelcomePage\\TempDatabase\\admin.txt", false);

            swa.WriteLine(password);
            string usercheck = "";
            string passcheck = "";

            while (sr.ReadLine() != username)
            {
                counter++;
            }
            for (int i = 0; i <= counter; i++)
            {
                usercheck = sr.ReadLine();
                passcheck = sr.ReadLine();
                if (username == usercheck && password == passcheck)
                {
                    var homeButt = new Home();
                    homeButt.Show();
                    this.Close();
                }
                else
                {
                    label2.Visible = true;
                }
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
