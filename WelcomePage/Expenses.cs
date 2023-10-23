using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            string adminFilePath = "C:\\Users\\gtfol\\source\\repos\\BudgetBuddy\\WelcomePage\\TempDatabase\\admin.txt";

            try
            {
                string username = File.ReadAllText(adminFilePath).Trim();

                string budgetFilePath = "C:\\Users\\gtfol\\source\\repos\\BudgetBuddy\\WelcomePage\\TempDatabase\\budgeting.txt";
                string[] budgetLines = File.ReadAllLines(budgetFilePath);

                // Find the line that matches the username
                int usernameIndex = Array.IndexOf(budgetLines, username);

                if (usernameIndex >= 0 && usernameIndex + 6 < budgetLines.Length)
                {
                    int personal = int.Parse(budgetLines[usernameIndex + 2]);
                    int bills = int.Parse(budgetLines[usernameIndex + 3]);
                    int savings = int.Parse(budgetLines[usernameIndex + 4]);
                    int subscriptions = int.Parse(budgetLines[usernameIndex + 5]);
                    int other = int.Parse(budgetLines[usernameIndex + 6]);

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
                }
                else
                {
                    // Handle the case where the username is not found or there are not enough lines of data.
                    MessageBox.Show("Invalid data format in budget file or username not found.");
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions, such as file not found or format issues
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
