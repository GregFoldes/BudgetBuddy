using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.VisualStyles;
using static System.Net.Mime.MediaTypeNames;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WelcomePage
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {
            string usernameTxt = Username.Text;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            var homeBut = new WelcomePage();
            homeBut.Show();
            this.Close();
        }

        private void SignUpSL_Click(object sender, EventArgs e)
        {
           string username = Username.Text;
            string firstName = FirstName.Text;
            string lastName = LastName.Text;
            string phoneNumber = PhoneNumber.Text;
            string email = Email.Text;
            string password = Password.Text;
            Boolean validated = false;
            dataWriting(username, firstName, lastName, phoneNumber, email, password, validated);



        }
        public void dataWriting(string username, string firstName, string lastName, string phoneNumber, string email, string password, bool validation)
        {
            try
            {
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) ||
                    string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(phoneNumber) ||
                    username == "Username" || firstName == "First Name" || lastName == "Last Name" ||
                    email == "Email" || phoneNumber == "(###) ###-####")
                {
                    warningLabel.Text = "Please make sure everything is filled out";
                }
                else
                {
                    // Use a connection string to connect to your database
                    string connectionString = AppData.connectionString;

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // Retrieve the newly generated UserID
                        int userId = GetGeneratedUserId(connection);
                        InsertUserInformation(connection, username, password, firstName, lastName, email, phoneNumber,userId);
                        // Set the user ID in AppData
                        AppData.UserId = userId;

                        var homeBut = new Home();
                        homeBut.Show();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions, such as database connection issues
                //MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void InsertUserInformation(SqlConnection connection, string username, string password, string firstName, string lastName, string email, string phoneNumber, int UserID)
        {
            using (SqlCommand cmd = connection.CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO [UserInformation] (Username, Password, FirstName, LastName, Email, PhoneNumber, UserID) VALUES (@Username, @Password, @FirstName, @LastName, @Email, @PhoneNumber, @UserID)";
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                cmd.Parameters.AddWithValue("@UserID", UserID);

                cmd.ExecuteNonQuery();
            }
        }
       
    private int GetGeneratedUserId(SqlConnection connection)
        {
            // Generate a random user ID between 1 and 999
            Random random = new Random();
            int randomUserId = random.Next(1, 1000);

            int attempts = 0;
            const int maxAttempts = 1000; // Limit the number of attempts to avoid an infinite loop

            // Check if the generated user ID is already in use
            while (IsUserIdUsed(connection, randomUserId))
            {
                // If the ID is already in use, generate a new one
                randomUserId = random.Next(1, 1000);

                attempts++;

                if (attempts >= maxAttempts)
                {
                    throw new InvalidOperationException("Unable to generate a unique non-null UserID within the specified limit.");
                }
            }

            return randomUserId;
        }


        private bool IsUserIdUsed(SqlConnection connection, int userId)
        {
            using (SqlCommand checkIdCmd = connection.CreateCommand())
            {
                checkIdCmd.CommandType = CommandType.Text;
                checkIdCmd.CommandText = "SELECT COUNT(*) FROM [UserInformation] WHERE UserID = @UserID";
                checkIdCmd.Parameters.AddWithValue("@UserID", userId);

                int count = Convert.ToInt32(checkIdCmd.ExecuteScalar());

                // If count is greater than 0, the ID is already in use
                return count > 0;
            }
        }





    }
}
