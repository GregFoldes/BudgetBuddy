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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
            StreamWriter sw = new StreamWriter("C:\\Users\\gtfol\\source\\repos\\BudgetBuddy\\WelcomePage\\TempDatabase\\admin.txt", false);
            if (ValidateLogin(username, password) == true)
            {
                sw.WriteLine(username);
                sw.Close();
                var homeButt = new Home();
                homeButt.Show();
                this.Close();
            }
            else
            {
                label2.Visible = true;
            }
        }
        public Boolean ValidateLogin(string username, string password)
        {
            string filePath = "C:\\Users\\gtfol\\source\\repos\\BudgetBuddy\\WelcomePage\\TempDatabase\\accounts.txt";

            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string usercheck = line;
                    string passcheck = sr.ReadLine();

                    if (usercheck == username && passcheck == password)
                    {
                        sr.Close();
                        return true;

                    }
                }
            }

            // If no matching credentials were found, return false
            return false;
            

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
