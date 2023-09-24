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
            PopulateDonutChart();
        }
        public Home()
        {
            InitializeComponent();
            PopulateDonutChart();
        }
        private void PopulateDonutChart()
        {
            // Clear any existing data
            chart1.Series.Clear();
            Random random = new Random();

            // Create a new series
            Series series = new Series("Categories");
            series.ChartType = SeriesChartType.Doughnut;

            // Add data points
            series.Points.AddXY("Savings", random.Next(1, 100));
            series.Points.AddXY("Personal", random.Next(1, 100));
            series.Points.AddXY("Bills", random.Next(1, 100));
            series.Points.AddXY("Subscriptions", random.Next(1, 100));
            series.Points.AddXY("Other", random.Next(1, 100));

            // Add the series to the chart
            chart1.Series.Add(series);

            // Customize the appearance if needed
            series["PieLabelStyle"] = "Outside"; // Show labels outside the donut
            series["DoughnutRadius"] = "30"; // Adjust the inner radius of the donut (percentage)
        }



        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
