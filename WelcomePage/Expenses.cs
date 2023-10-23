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
            string budgetFilePath = "C:\\Users\\gtfol\\source\\repos\\BudgetBuddy\\WelcomePage\\TempDatabase\\budgeting.txt";
            string adminFilePath = "C:\\Users\\gtfol\\source\\repos\\BudgetBuddy\\WelcomePage\\TempDatabase\\admin.txt";

            try
            {
                using (StreamReader sra = new StreamReader(adminFilePath))
                using (StreamReader sr = new StreamReader(budgetFilePath))
                {
                    string username = sra.ReadLine();
                    int counter = 1;

                    while (sr.ReadLine() != username)
                    {
                        counter++;
                    }
                    for (int i = 1; i <= counter; i++)
                    {
                        sr.ReadLine();
                    }
                    personal = Convert.ToInt32(sr.ReadLine());
                    bills = Convert.ToInt32(sr.ReadLine());
                    savings = Convert.ToInt32(sr.ReadLine());
                    subscriptions = Convert.ToInt32(sr.ReadLine());
                    other = Convert.ToInt32(sr.ReadLine());
                    sr.Close();
                    sra.Close();

                }

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
            catch (Exception ex)
            {
                // Handle exceptions, such as file not found or format issues
                Console.WriteLine("An error occurred: " + ex.Message);
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
