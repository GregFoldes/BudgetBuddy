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
    public partial class CurrentBudget : Form
    {
        public CurrentBudget()
        {
            InitializeComponent();
            PopulateDonutChart();
            LabelStrings();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            var homeBut = new Home();
            homeBut.Show();
            this.Close();
        }

        private int[] RetrieveSpendingData(int userId)
        {
            int personal = 0, bills = 0, savings = 0, subscriptions = 0, other = 0;

            // Use a connection string to connect to your database
            using (SqlConnection connection = new SqlConnection(AppData.connectionString))
            {
                connection.Open();

                // Use a SqlCommand to fetch user spending data from Cat table
                using (SqlCommand cmdCat = connection.CreateCommand())
                {
                    cmdCat.CommandType = CommandType.Text;
                    cmdCat.CommandText = "SELECT Spending, Bills, Savings, Subscriptions, Other FROM [Cat] WHERE UserId = @UserId";
                    cmdCat.Parameters.AddWithValue("@UserId", userId);

                    using (SqlDataReader readerCat = cmdCat.ExecuteReader())
                    {
                        if (readerCat.Read())
                        {
                            // Assign values to local variables
                            personal = readerCat.GetInt32(readerCat.GetOrdinal("Spending"));
                            bills = readerCat.GetInt32(readerCat.GetOrdinal("Bills"));
                            savings = readerCat.GetInt32(readerCat.GetOrdinal("Savings"));
                            subscriptions = readerCat.GetInt32(readerCat.GetOrdinal("Subscriptions"));
                            other = readerCat.GetInt32(readerCat.GetOrdinal("Other"));
                            readerCat.Close();
                        }
                        else
                        {
                            // Handle the case where the UserId is not found in the Cat table
                            MessageBox.Show("UserId not found in the Cat table.");
                        }
                    }
                }
            }

            return new int[] { personal, bills, savings, subscriptions, other };
        }

        private int[] RetrieveDesiredAmounts(int userId)
        {
            int dpersonal = 0, dbills = 0, dsavings = 0, dsubscriptions = 0, dother = 0;

            // Use a connection string to connect to your database
            using (SqlConnection connection = new SqlConnection(AppData.connectionString))
            {
                connection.Open();

                // Use a SqlCommand to fetch user desired amounts from Des table
                using (SqlCommand cmdDes = connection.CreateCommand())
                {
                    cmdDes.CommandType = CommandType.Text;
                    cmdDes.CommandText = "SELECT dSpending, dBills, dSavings, dSubscriptions, dOther FROM [Des] WHERE UserId = @UserId";
                    cmdDes.Parameters.AddWithValue("@UserId", userId);

                    using (SqlDataReader readerDes = cmdDes.ExecuteReader())
                    {
                        if (readerDes.Read())
                        {
                            // Assign values to local variables for desired amounts
                            dpersonal = readerDes.GetInt32(readerDes.GetOrdinal("dSpending"));
                            dbills = readerDes.GetInt32(readerDes.GetOrdinal("dBills"));
                            dsavings = readerDes.GetInt32(readerDes.GetOrdinal("dSavings"));
                            dsubscriptions = readerDes.GetInt32(readerDes.GetOrdinal("dSubscriptions"));
                            dother = readerDes.GetInt32(readerDes.GetOrdinal("dOther"));
                            readerDes.Close();
                        }
                        else
                        {
                            // Handle the case where the UserId is not found in the Des table
                            MessageBox.Show("UserId not found in the Des table.");
                        }
                    }
                }
            }

            return new int[] { dpersonal, dbills, dsavings, dsubscriptions, dother };
        }

        private void UpdateCharts(int[] spendingData, int[] desiredAmounts)
        {
            chart1.Series.Clear();
            chart2.Series.Clear();
            chart1.BackColor = Color.Transparent;
            chart2.BackColor = Color.Transparent;

            // Create a new series
            Series series = new Series("Categories");
            Series series1 = new Series("Categories");
            series.ChartType = SeriesChartType.Doughnut;
            series1.ChartType = SeriesChartType.Doughnut;

            // Add data points
            series.Points.AddXY("", spendingData[0]); // personal
            series.Points.AddXY("", spendingData[1]); // bills
            series.Points.AddXY("", spendingData[2]); // savings
            series.Points.AddXY("", spendingData[3]); // subscriptions
            series.Points.AddXY("", spendingData[4]); // other
            series1.Points.AddXY("", desiredAmounts[0]); // dpersonal
            series1.Points.AddXY("", desiredAmounts[1]); // dbills
            series1.Points.AddXY("", desiredAmounts[2]); // dsavings
            series1.Points.AddXY("", desiredAmounts[3]); // dsubscriptions
            series1.Points.AddXY("", desiredAmounts[4]); // dother

            // Add the series to the chart
            chart1.Series.Add(series);
            chart2.Series.Add(series1);

            // Customize the appearance if needed
            series["PieLabelStyle"] = "Outside"; // Show labels outside the donut
            series["DoughnutRadius"] = "40"; // Adjust the inner radius of the donut (percentage)
            series1["PieLabelStyle"] = "Outside"; // Show labels outside the donut
            series1["DoughnutRadius"] = "40";
        
        }

        private void PopulateDonutChart()
        {
            try
            {
                // Retrieve UserId from AppData
                int userId = AppData.UserId;

                // Retrieve spending data from the Cat table
                int[] spendingData = RetrieveSpendingData(userId);

                // Retrieve desired amounts from the Des table
                int[] desiredAmounts = RetrieveDesiredAmounts(userId);

                // Update the charts with the retrieved data
                UpdateCharts(spendingData, desiredAmounts);
            }
            catch (Exception ex)
            {
                // Handle exceptions, such as database connection issues
                MessageBox.Show("An error occurred: 1 " + ex.Message);
            }

        }

        private void LabelStrings()
        {
            try
            {
                // Retrieve UserId from AppData
                int userId = AppData.UserId;

                // Use a connection string to connect to your database
                using (SqlConnection connection = new SqlConnection(AppData.connectionString))
                {
                    connection.Open();

                    // Use a SqlCommand to fetch user information based on the UserId from Total table
                    using (SqlCommand cmdTotal = connection.CreateCommand())
                    {
                        cmdTotal.CommandType = CommandType.Text;
                        cmdTotal.CommandText = "SELECT Total FROM [Total] WHERE UserId = @UserId";
                        cmdTotal.Parameters.AddWithValue("@UserId", userId);

                        using (SqlDataReader readerTotal = cmdTotal.ExecuteReader())
                        {
                            if (readerTotal.Read())
                            {
                                // Assign the total value as a string
                                string totalAsString = readerTotal.GetString(readerTotal.GetOrdinal("Total"));

                                // Convert the string to an integer
                                int total = int.Parse(totalAsString);

                                // Close the first DataReader
                                readerTotal.Close();

                                // Use a SqlCommand to fetch user spending data from Cat table
                                using (SqlCommand cmdCat = connection.CreateCommand())
                                {
                                    cmdCat.CommandType = CommandType.Text;
                                    cmdCat.CommandText = "SELECT Spending, Bills, Savings, Subscriptions, Other FROM [Cat] WHERE UserId = @UserId";
                                    cmdCat.Parameters.AddWithValue("@UserId", userId);

                                    using (SqlDataReader readerCat = cmdCat.ExecuteReader())
                                    {
                                        if (readerCat.Read())
                                        {
                                            // Assign values to local variables
                                            int spending = readerCat.GetInt32(readerCat.GetOrdinal("Spending"));
                                            int bills = readerCat.GetInt32(readerCat.GetOrdinal("Bills"));
                                            int savings = readerCat.GetInt32(readerCat.GetOrdinal("Savings"));
                                            int subscriptions = readerCat.GetInt32(readerCat.GetOrdinal("Subscriptions"));
                                            int other = readerCat.GetInt32(readerCat.GetOrdinal("Other"));

                                            // Close the second DataReader
                                            readerCat.Close();

                                            // Use a SqlCommand to fetch user desired amounts from Des table
                                            using (SqlCommand cmdDes = connection.CreateCommand())
                                            {
                                                cmdDes.CommandType = CommandType.Text;
                                                cmdDes.CommandText = "SELECT dSpending, dBills, dSavings, dSubscriptions, dOther FROM [Des] WHERE UserId = @UserId";
                                                cmdDes.Parameters.AddWithValue("@UserId", userId);

                                                using (SqlDataReader readerDes = cmdDes.ExecuteReader())
                                                {
                                                    if (readerDes.Read())
                                                    {
                                                        // Assign values to local variables for desired amounts
                                                        int dpersonal = readerDes.GetInt32(readerDes.GetOrdinal("dSpending"));
                                                        int dbills = readerDes.GetInt32(readerDes.GetOrdinal("dBills"));
                                                        int dsavings = readerDes.GetInt32(readerDes.GetOrdinal("dSavings"));
                                                        int dsubscriptions = readerDes.GetInt32(readerDes.GetOrdinal("dSubscriptions"));
                                                        int dother = readerDes.GetInt32(readerDes.GetOrdinal("dOther"));

                                                        // Update the labels
                                                        UpdateLabels(total, spending, bills, savings, subscriptions, other, dpersonal, dbills, dsavings, dsubscriptions, dother);
                                                    }
                                                    else
                                                    {
                                                        // Handle the case where the UserId is not found in the Des table
                                                        MessageBox.Show("UserId not found in the Des table.");
                                                    }
                                                }
                                            }
                                        }
                                        else
                                        {
                                            // Handle the case where the UserId is not found in the Cat table
                                            MessageBox.Show("UserId not found in the Cat table.");
                                        }
                                    }
                                }
                            }
                            else
                            {
                                // Handle the case where the UserId is not found in the Total table
                                MessageBox.Show("UserId not found in the Total table.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions, such as database connection issues
                MessageBox.Show("An error occurred 2: " + ex.Message);
            }
        }



        private void UpdateLabels(int total, int spending, int bills, int savings, int subscriptions, int other, int dpersonal, int dbills, int dsavings, int dsubscriptions, int dother)
        {
            // Update the labels for actual spending
            TILabel.Text = $"${total}";

            PSpendLabel.Text = $"${spending}";
            BSpendLabel.Text = $"${bills}";
            SSpendLabel.Text = $"${savings}";
            SubSpendLabel.Text = $"${subscriptions}";
            OSpendLabel.Text = $"${other}";

            PPercentLabel.Text = $"{PercentCalc(spending, total):0.00}%";
            BPercentLabel.Text = $"{PercentCalc(bills, total):0.00}%";
            SPercentLabel.Text = $"{PercentCalc(savings, total):0.00}%";
            SubPercentLabel.Text = $"{PercentCalc(subscriptions, total):0.00}%";
            OPercentLabel.Text = $"{PercentCalc(other, total):0.00}%";

            // Update the labels for desired spending (from Des table)
            DPSpendLabel.Text = $"${dpersonal:0.00}";
            DBSpendLabel.Text = $"${dbills:0.00}";
            DSSpendLabel.Text = $"${dsavings:0.00}";
            DSubSpendLabel.Text = $"${dsubscriptions:0.00}";
            DOSpendLabel.Text = $"${dother:0.00}";

            DPPercentLabel.Text = $"{PercentCalc(dpersonal,total):0.00}%";
            DBPercentLabel.Text = $"{PercentCalc(dbills,total):0.00}%";
            DSPercentLabel.Text = $"{PercentCalc(dsavings, total):0.00}%";
            DSubPercentLabel.Text = $"{PercentCalc(dsubscriptions, total):0.00}%";
            label22.Text = $"{PercentCalc(dother, total):0.00}%";

            // Update the labels for the difference between actual and desired spending
            PDiffLabel.Text = $"{DifferenceCalc(spending, dpersonal)}";
            BDiffLabel.Text = $"{DifferenceCalc(bills, dbills)}";
            SDiffLabel.Text = $"{DifferenceCalc(savings, dsavings)}";
            SubDiffLabel.Text = $"{DifferenceCalc(subscriptions, dsubscriptions)}";
            ODiffLabel.Text = $"{DifferenceCalc(other, dother)}";
        }



        public double PercentCalc(int amount, int total)
        {
            double percent = ((double)amount / (double) total) * 100.0;
            double Rpercent = Math.Round(percent, 2);
            return Rpercent;
        }
        public double DesiredAmountCalc(int percent, int total)
        {
            double ammount = (((double)percent)/100.00) * (double)total;
            double Rammount = Math.Round(ammount, 2);
            return Rammount;
        }
        public string DifferenceCalc(int ammount, double ammount2)
        {
            double difference;
            if (((double)ammount - ammount2) < 0)
            {
                difference = ammount2 - (double)ammount;
                double rdiff = Math.Round(difference, 2);
                return "+ $" + rdiff;
            }
            else
            {
                difference = (double)ammount - ammount2;
                double rdiff = Math.Round(difference, 2);
                return "- $" + rdiff;
            }
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }
    }
}
