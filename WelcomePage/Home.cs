using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void Home_Load(object sender, EventArgs e)
        {
            
        }
        public Home()
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

                if (usernameIndex >= 0 && usernameIndex + 5 < budgetLines.Length)
                {
                    int personal = int.Parse(budgetLines[usernameIndex + 1]);
                    int bills = int.Parse(budgetLines[usernameIndex + 2]);
                    int savings = int.Parse(budgetLines[usernameIndex + 3]);
                    int subscriptions = int.Parse(budgetLines[usernameIndex + 4]);
                    int other = int.Parse(budgetLines[usernameIndex + 5]);

                    // Clear any existing data
                    chart1.Series.Clear();
                    chart1.BackColor = Color.Transparent;

                    // Create a new series
                    Series series = new Series("Categories");
                    series.ChartType = SeriesChartType.Doughnut;

                    // Add data points
                    series.Points.AddXY("Personal", personal);
                    series.Points.AddXY("Bills", bills);
                    series.Points.AddXY("Savings", savings);
                    series.Points.AddXY("Subscriptions", subscriptions);
                    series.Points.AddXY("Other", other);

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

    }
}
