using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            if (ValidateLogin(username, password))
            {
                // Update the UserId in AppData
                AppData.UserId = GetUserId(username, password);

                var homeForm = new Home();
                homeForm.Show();
                this.Close();
            }
            else
            {
                label2.Visible = true;
            }
        }

        private bool ValidateLogin(string username, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(AppData.connectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = connection.CreateCommand())
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "SELECT COUNT(*) FROM [UserInformation] WHERE Username = @Username AND Password = @Password";
                        cmd.Parameters.AddWithValue("Username", username);
                        cmd.Parameters.AddWithValue("Password", password);

                        int result = (int)cmd.ExecuteScalar();

                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return false;
            }
        }

        private int GetUserId(string username, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(AppData.connectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = connection.CreateCommand())
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "SELECT UserId FROM [UserInformation] WHERE Username = @Username AND Password = @Password";
                        cmd.Parameters.AddWithValue("Username", username);
                        cmd.Parameters.AddWithValue("Password", password);

                        object result = cmd.ExecuteScalar();
                        connection.Close();
                        return result != null ? (int)result : -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return -1;
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
