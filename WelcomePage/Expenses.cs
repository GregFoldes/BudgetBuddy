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
        private Timer timer;
        private int currentPointIndex;

        public int userID { get; set; }

        public Expenses()
        {
            InitializeComponent();
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            // Initialization logic for components
            PopulateDonutChart();

            // Initialize and configure the timer
            timer = new Timer();
            timer.Interval = 105; // 5000 milliseconds = 5 seconds
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Expenses_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Dispose of resources
            DisposeResources();
        }

        private void DisposeResources()
        {
            // Dispose of the chart
            if (chart1 != null)
            {
                chart1.Dispose();
            }

            // Dispose of the timer
            if (timer != null)
            {
                timer.Stop();
                timer.Dispose();
            }
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
                    UpdateDoughnutRadius(series,
                                         currentRadius);
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
                            if (reader != null && reader.Read())
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

                                // Stop the timer if it is already running
                                if (timer != null && timer.Enabled)
                                {
                                    timer.Stop();
                                    timer.Dispose();
                                }

                                // Initialize and configure the timer
                                timer = new Timer();
                                timer.Interval = 115; // 5000 milliseconds = 5 seconds
                                timer.Tick += Timer_Tick;

                                // Start the timer to gradually increase the doughnut radius
                                currentPointIndex = 0;
                                timer.Start();
                            }
                            else
                            {
                                MessageBox.Show("No data found for the user ID.");
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
            // Handle chart click event
        }
    }
}
