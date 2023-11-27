using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WelcomePage
{
    public partial class ForgotPass : Form
    {
        private string ConnectionString = AppData.connectionString;
        public ForgotPass()
        {
            InitializeComponent();
        }

        private void ChangeButt_Click(object sender, EventArgs e)
        {
            string username = UsernameBox.Text;
            string email = EmailBox.Text;
            string phoneNumber = PhoneNumberBox.Text;
            string newPassword = PasswordBox.Text;

            // Check if the credentials match the database
            if (CheckCredentials(username, email, phoneNumber))
            {
                // Update the password
                if (UpdatePassword(username, newPassword))
                {
                    MessageBox.Show("Password updated successfully.");
                    this.Close();

                }
                else
                {
                    //MessageBox.Show("Failed to update password. Please try again.");
                }
            }
            else
            {
                //MessageBox.Show("Invalid credentials. Please check your information.");
            }
        }

        private bool CheckCredentials(string username, string email, string phoneNumber)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "SELECT COUNT(*) FROM UserInformation WHERE Username = @Username AND Email = @Email AND PhoneNumber = @PhoneNumber";
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                    int count = (int)cmd.ExecuteScalar();

                    return count > 0;
                }
            }
        }

        private bool UpdatePassword(string username, string newPassword)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "UPDATE UserInformation SET Password = @Password WHERE Username = @Username";
                    cmd.Parameters.AddWithValue("@Password", newPassword);
                    cmd.Parameters.AddWithValue("@Username", username);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }

        private void BackButt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
