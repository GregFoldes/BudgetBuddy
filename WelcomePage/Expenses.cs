using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WelcomePage
{
    public partial class Expenses : Form
    {
        public Expenses()
        {
            InitializeComponent();
            PopulateDonutChart();
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
                                series["DoughnutRadius"] = "40"; // Adjust the inner radius of the donut (percentage)
                                connection.Close();
                            }
                            else
                            {
                                // Handle the case where the user ID is not found
                                MessageBox.Show("User ID not found in the database.");
                            }
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                // Handle exceptions, such as database connection issues
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }



        private void HomeButton_Click(object sender, EventArgs e)
        {
            var homeBut = new Home();
            homeBut.Show();
            this.Close();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
