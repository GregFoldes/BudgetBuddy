using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WelcomePage
{
    public partial class Home : Form
    {
        private Timer timer;
        private int currentPointIndex;

        public int userID { get; set; }

        public Home()
        {
            InitializeComponent();

            // Initialization logic for components
            label1.Text = "WELCOME BACK, " + UserFirstName().ToUpper();
            chart1.Series.Add(new Series("Categories"));

            // Initialize and configure the timer
            timer = new Timer();
            timer.Interval = 115; // 5000 milliseconds = 5 seconds
            timer.Tick += Timer_Tick;
            timer.Start();

            // Populate the doughnut chart
            PopulateDonutChart();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Dispose of the timer when the form is closing
            timer.Stop();
            timer.Dispose();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (chart1 != null && chart1.IsHandleCreated && chart1.Series != null)
            {
                // Access chart properties safely
                Series series = chart1.Series.FirstOrDefault(s => s.Name == "Categories");

                if (series != null)
                {
                    // Increase the doughnut radius by a small percentage
                    int currentRadius = int.Parse(series["DoughnutRadius"]);
                    int increment = 2; // Adjust as needed
                    currentRadius += increment;

                    // Stop the timer when the radius is at the desired size
                    if (currentRadius >= 40)
                    {
                        timer.Stop();
                        timer.Dispose(); // Dispose of the timer to release resources
                        currentRadius = 40; // Ensure it's exactly the desired size
                    }

                    // Update doughnut radius in the UI thread
                    UpdateDoughnutRadius(series, currentRadius);
                }
            }
        }

        private void UpdateDoughnutRadius(Series series, int radius)
        {
            if (chart1.InvokeRequired)
            {
                // If called from a different thread, invoke on the UI thread
                chart1.Invoke(new Action(() => UpdateDoughnutRadius(series, radius)));
            }
            else
            {
                // Update doughnut radius
                series["DoughnutRadius"] = radius.ToString();
            }
        }




        private string UserFirstName()
        {
            try
            {
                int userId = AppData.UserId;

                // Use the initialized connection string from AppData
                string connectionString = AppData.connectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Use a SqlCommand to fetch the username based on the user ID
                    using (SqlCommand cmd = connection.CreateCommand())
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "SELECT FirstName FROM [UserInformation] WHERE UserID = @UserID";
                        cmd.Parameters.AddWithValue("UserID", userId);

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            connection.Close();
                            return result.ToString();
                        }
                        else
                        {
                            // Handle the case where the user ID is not found or username is null
                            return "Unknown User";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions, such as database connection issues
                //MessageBox.Show("An error occurred: " + ex.Message);
                return "Unknown User";
            }
        }


        private void PopulateDonutChart()
        {
            try
            {
                // Read the user ID from the AppData class
                int userId = AppData.UserId;

                // Use a connection string to connect to your database
                string connectionString = AppData.connectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Use a SqlCommand to fetch budget data based on the user ID
                    using (SqlCommand cmd = connection.CreateCommand())
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "SELECT Spending, Bills, Savings, Subscriptions, Other FROM [Cat] WHERE UserID = @UserID";
                        cmd.Parameters.AddWithValue("UserID", userId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int personal = reader.GetInt32(0);
                                int bills = reader.GetInt32(1);
                                int savings = reader.GetInt32(2);
                                int subscriptions = reader.GetInt32(3);
                                int other = reader.GetInt32(4);

                                // Clear any existing data
                                chart1.Series.Clear();
                                chart1.BackColor = Color.Transparent;

                                // Create a new series
                                Series series = new Series("Categories");
                                series.ChartType = SeriesChartType.Doughnut;

                                // Add data points
                                series.Points.AddXY("", personal);
                                series.Points.AddXY("", bills);
                                series.Points.AddXY("", savings);
                                series.Points.AddXY("", subscriptions);
                                series.Points.AddXY("", other);

                                // Add the series to the chart
                                chart1.Series.Add(series);

                                // Customize the appearance if needed
                                series["PieLabelStyle"] = "Outside"; // Show labels outside the donut
                                series["DoughnutRadius"] = "0"; // Start with a small inner radius

                                // Start the timer to gradually increase the doughnut radius
                                currentPointIndex = 0;
                                timer.Start();

                                connection.Close();
                            }
                            else
                            {
                                // Handle the case where the user ID is not found
                                //MessageBox.Show("User ID not found in the database.");
                            }
                        }
                    }
                } // The 'Dispose' method of 'connection' is automatically called when exiting this block
            }
            catch (Exception ex)
            {
                // Handle exceptions, such as database connection issues
                //MessageBox.Show("An error occurred: " + ex.Message);
            }
        }



        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var BudgetBut = new Budget();
            BudgetBut.Show();
            this.Close();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            var ExpenseBut = new Expenses();
            ExpenseBut.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ExpensePage_Click(object sender, EventArgs e)
        {
            var ExpenseBut = new Expenses();
            ExpenseBut.Show();
            this.Close();
        }

        private void BankInfo_Click(object sender, EventArgs e)
        {
            var BankBut = new Banking();
            BankBut.Show();
            this.Close();
        }

        private void SupportButton_Click(object sender, EventArgs e)
        {
            var TipsBut = new Tips();
            TipsBut.Show();
            this.Close();
        }

        private void AccountButton_Click(object sender, EventArgs e)
        {
            var AccountBut = new Account();
            AccountBut.Show();
            this.Close();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            var logOut = new WelcomePage();
            logOut.Show();
            this.Close();
        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }


    }
}
