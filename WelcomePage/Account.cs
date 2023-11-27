using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using System.Data.SqlClient;



namespace WelcomePage
{
    public partial class Account : Form
    {

        public Account()
        {
            InitializeComponent();
            PopulateLabels();

        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            var homeBut = new Home();
            homeBut.Show();
            this.Close();
        }

        public void PopulateLabels()
        {
            try
            {
                int id = AppData.UserId;

                using (SqlConnection connection = new SqlConnection(AppData.connectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = connection.CreateCommand())
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "SELECT UserID, Username, Password, Email, FirstName, LastName, PhoneNumber FROM [UserInformation] WHERE UserID = @id";
                        cmd.Parameters.AddWithValue("id", id);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                FirstLabel.Text = reader["FirstName"].ToString();
                                LastLabel.Text = reader["LastName"].ToString();
                                EmailLabel.Text = reader["Email"].ToString();
                                UserLabel.Text = reader["Username"].ToString();

                                // Hide the password with asterisks
                                string password = reader["Password"].ToString();
                                PassLabel.Text = new string('*', password.Length);

                                string phoneNumber = reader["PhoneNumber"].ToString();
                                if (phoneNumber.Length == 10 && long.TryParse(phoneNumber, out long numericPhoneNumber))
                                {
                                    string formattedPhoneNumber = string.Format("({0:###}) {1:###}-{2:####}",
                                        numericPhoneNumber / 10000000, (numericPhoneNumber / 10000) % 1000, numericPhoneNumber % 10000);

                                    PhoneLabel.Text = formattedPhoneNumber;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions appropriately, log, or display an error message.
                Console.WriteLine("Error: " + ex.Message);
                throw; // Rethrow the exception for further investigation.
            }
        }
    }
}