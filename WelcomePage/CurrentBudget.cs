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

                if (usernameIndex >= 0 && usernameIndex + 11 < budgetLines.Length)
                {
                    int personal = int.Parse(budgetLines[usernameIndex + 2]);
                    int bills = int.Parse(budgetLines[usernameIndex + 3]);
                    int savings = int.Parse(budgetLines[usernameIndex + 4]);
                    int subscriptions = int.Parse(budgetLines[usernameIndex + 5]);
                    int other = int.Parse(budgetLines[usernameIndex + 6]);
                    int dpersonal = int.Parse(budgetLines[usernameIndex + 7]);
                    int dbills = int.Parse(budgetLines[usernameIndex + 8]);
                    int dsavings = int.Parse(budgetLines[usernameIndex + 9]);
                    int dsubscriptions = int.Parse(budgetLines[usernameIndex + 10]);
                    int dother = int.Parse(budgetLines[usernameIndex + 11]);

                    // Clear any existing data
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
                    series.Points.AddXY("", personal);
                    series.Points.AddXY("", bills);
                    series.Points.AddXY("", savings);
                    series.Points.AddXY("", subscriptions);
                    series.Points.AddXY("", other);
                    series1.Points.AddXY("", dpersonal);
                    series1.Points.AddXY("", dbills);
                    series1.Points.AddXY("", dsavings);
                    series1.Points.AddXY("", dsubscriptions);
                    series1.Points.AddXY("", dother);

                    // Add the series to the chart
                    chart1.Series.Add(series);
                    chart2.Series.Add(series1);

                    // Customize the appearance if needed
                    series["PieLabelStyle"] = "Outside"; // Show labels outside the donut
                    series["DoughnutRadius"] = "40"; // Adjust the inner radius of the donut (percentage)
                    series1["PieLabelStyle"] = "Outside"; // Show labels outside the donut
                    series1["DoughnutRadius"] = "40";
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
        public void LabelStrings()
        {
            string adminFilePath = "C:\\Users\\gtfol\\source\\repos\\BudgetBuddy\\WelcomePage\\TempDatabase\\admin.txt";

            try
            {
                string username = File.ReadAllText(adminFilePath).Trim();

                string budgetFilePath = "C:\\Users\\gtfol\\source\\repos\\BudgetBuddy\\WelcomePage\\TempDatabase\\budgeting.txt";
                string[] budgetLines = File.ReadAllLines(budgetFilePath);

                // Find the line that matches the username
                int usernameIndex = Array.IndexOf(budgetLines, username);

                if (usernameIndex >= 0 && usernameIndex + 11 < budgetLines.Length)
                {
                    int total = int.Parse(budgetLines[usernameIndex + 1]);
                    int personal = int.Parse(budgetLines[usernameIndex + 2]);
                    int bills = int.Parse(budgetLines[usernameIndex + 3]);
                    int savings = int.Parse(budgetLines[usernameIndex + 4]);
                    int subscriptions = int.Parse(budgetLines[usernameIndex + 5]);
                    int other = int.Parse(budgetLines[usernameIndex + 6]);
                    int dpersonal = int.Parse(budgetLines[usernameIndex + 7]);
                    int dbills = int.Parse(budgetLines[usernameIndex + 8]);
                    int dsavings = int.Parse(budgetLines[usernameIndex + 9]);
                    int dsubscriptions = int.Parse(budgetLines[usernameIndex + 10]);
                    int dother = int.Parse(budgetLines[usernameIndex + 11]);

                    TILabel.Text = "$" + total;

                    PSpendLabel.Text = "$" + personal;
                    BSpendLabel.Text = "$" + bills;
                    SSpendLabel.Text = "$" + savings;
                    SubSpendLabel.Text = "$" + subscriptions;
                    OSpendLabel.Text = "$" + other;

                    PPercentLabel.Text = PercentCalc(personal, total) + "%";
                    BPercentLabel.Text = PercentCalc(bills, total) + "%";
                    SPercentLabel.Text = PercentCalc(savings, total) + "%";
                    SubPercentLabel.Text = PercentCalc(subscriptions, total) + "%";
                    OPercentLabel.Text = PercentCalc(other, total) + "%";

                    DPSpendLabel.Text = "$" + DesiredAmountCalc(dpersonal,total);
                    DBSpendLabel.Text = "$" + DesiredAmountCalc(dbills,total);
                    DSSpendLabel.Text = "$" + DesiredAmountCalc(dsavings, total);
                    DSubSpendLabel.Text = "$" + DesiredAmountCalc(dsubscriptions, total);
                    DOSpendLabel.Text = "$" + DesiredAmountCalc(dother, total);

                    DPPercentLabel.Text = dpersonal + "%";
                    DBPercentLabel.Text = dbills + "%";
                    DSPercentLabel.Text = dsavings + "%";
                    DSubPercentLabel.Text = dsubscriptions + "%";
                    DOPercentLabel.Text = dsavings + "%";


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
        public double PercentCalc(int amount, int total)
        {
            double percent = ((double)amount / total) * 100.0;
            double Rpercent = Math.Round(percent, 2);
            return Rpercent;
        }
        public double DesiredAmountCalc(int percent, int total)
        {
            double ammount = (((double)percent)/100.00) * (double)total;
            double Rammount = Math.Round(ammount, 2);
            return Rammount;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
