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
            string adminFilePath = "C:\\Users\\gtfol\\source\\repos\\BudgetBuddy\\WelcomePage\\TempDatabase\\admin.txt";

            try
            {
                string username = File.ReadAllText(adminFilePath).Trim();

                string accountFilePath = "C:\\Users\\gtfol\\source\\repos\\BudgetBuddy\\WelcomePage\\TempDatabase\\accounts.txt";
                string[] accountLines = File.ReadAllLines(accountFilePath);

                // Find the line that matches the username
                int usernameIndex = Array.IndexOf(accountLines, username);

                if (usernameIndex >= 0 && usernameIndex + 5 < accountLines.Length)
                {
                    FirstLabel.Text = accountLines[usernameIndex+2];
                    LastLabel.Text = accountLines[usernameIndex+3];
                    EmailLabel.Text = accountLines[usernameIndex+4];
                    UserLabel.Text = accountLines[usernameIndex];
                    PassLabel.Text = accountLines[usernameIndex+1];
                    string phoneNumber = accountLines[usernameIndex + 5]; // Assuming it contains the raw phone number

                    if (phoneNumber.Length == 10 && long.TryParse(phoneNumber, out long numericPhoneNumber))
                    {
                        string formattedPhoneNumber = string.Format("({0:###}) {1:###}-{2:####}",
                            numericPhoneNumber / 10000000, (numericPhoneNumber / 10000) % 1000, numericPhoneNumber % 10000);

                        PhoneLabel.Text = formattedPhoneNumber;
                    }
                    else
                    {
                        // Handle the case where the phone number doesn't have the expected format or length
                        PhoneLabel.Text = "Invalid phone number";
                    }


                }
                else
                {
                    // Handle the case where the username is not found or there are not enough lines of data.
                    MessageBox.Show("Invalid data format in account file or username not found.");
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions, such as file not found or format issues
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
