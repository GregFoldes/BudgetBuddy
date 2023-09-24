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

namespace WelcomePage
{
    public partial class Expenses : Form
    {
        public Expenses()
        {
            InitializeComponent();
            Random random = new Random();
            int PersonalSpend = random.Next(1, 100);
            int BillsSpend = random.Next(1, 100);
            int SavingsSpend = random.Next(1, 100);
            int SubscriptionSpend = random.Next(1, 100);
            int OtherSpend = random.Next(1, 100);
            PopulateDonutChart(PersonalSpend, BillsSpend, SavingsSpend, SubscriptionSpend, OtherSpend);
        }
        private void PopulateDonutChart(int personal, int bills, int savings, int subscriptions, int other)
        {

            // Clear any existing data
            chart1.Series.Clear();
            chart1.BackColor = Color.Transparent;


            // Create a new series
            Series series = new Series("Categories");
            series.ChartType = SeriesChartType.Doughnut;

            // Add data points
            series.Points.AddXY("Personal Spending", personal);
            series.Points.AddXY("Bill Payments", bills);
            series.Points.AddXY("Savings Investment", savings);
            series.Points.AddXY("Monthly Subscriptions", subscriptions);
            series.Points.AddXY("Other", other);


            // Add the series to the chart
            chart1.Series.Add(series);

            // Customize the appearance if needed
            series["PieLabelStyle"] = "Disabled"; // Show labels outside the donut
            series["DoughnutRadius"] = "40"; // Adjust the inner radius of the donut (percentage)
            chart1.ChartAreas[0].BackColor = Color.Transparent;
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
