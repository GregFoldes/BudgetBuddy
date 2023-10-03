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
    public partial class Home : Form
    {

        private void Home_Load(object sender, EventArgs e)
        {
            //PopulateDonutChart();
        }
        public Home()
        {
            InitializeComponent();
            Random random = new Random();
            int PersonalSpend = random.Next(1, 100);
            int BillsSpend = random.Next(1, 100);
            int SavingsSpend = random.Next(1, 100);
            int SubscriptionSpend = random.Next(1, 100);
            int OtherSpend = random.Next(1, 100);
            PopulateDonutChart(PersonalSpend,BillsSpend,SavingsSpend,SubscriptionSpend,OtherSpend);
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
            chart1.ChartAreas[0].BackColor = Color.Transparent;
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
