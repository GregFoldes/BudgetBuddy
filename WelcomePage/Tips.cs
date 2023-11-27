using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WelcomePage
{ 
    public partial class Tips : Form
    {
        private Timer timer;
        public Tips()
        {
            InitializeComponent();
            Load += Tips_Load;
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            var homeBut = new Home();
            homeBut.Show();
            this.Close();
        }
        private void Tips_Load(object sender, EventArgs e)
        {
            DisplayRandomFinancialTips();

            // Initialize and start the timer
            timer = new Timer();
            timer.Interval = 5000; // 5000 milliseconds = 5 seconds
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Change tips every 5 seconds
            DisplayRandomFinancialTips();
        }
        private void DisplayRandomFinancialTips()
        {
            List<string> financialTips = new List<string>
            {
        "Tip 1: Save at least 20% of your income.",
        "Tip 2: Create a monthly budget to track your expenses.",
        "Tip 3: Consider investing for long-term financial goals.",
        "Tip 4: Pay off high-interest debts first.",
        "Tip 5: Diversify your investments to manage risk.",
        "Tip 6: Emergency fund should cover 3-6 months of expenses.",
        "Tip 7: Review your financial goals regularly.",
        "Tip 8: Take advantage of employer-sponsored retirement plans.",
        "Tip 9: Avoid unnecessary debt and live below your means.",
        "Tip 10: Plan for major expenses to avoid financial stress.",
        "Tip 11: Track your spending to identify saving opportunities.",
        "Tip 12: Save for retirement as early as possible.",
        "Tip 13: Automate your savings to ensure consistency.",
        "Tip 14: Understand the difference between wants and needs.",
        "Tip 15: Use cash or debit cards to avoid credit card debt.",
        "Tip 16: Be cautious with impulse purchases; sleep on it.",
        "Tip 17: Negotiate bills and shop around for better deals.",
        "Tip 18: Learn basic investment principles to make informed decisions.",
        "Tip 19: Build multiple streams of income for financial security.",
        "Tip 20: Educate yourself about personal finance regularly.",
        // Add more tips as needed
            };
            // Debugging output
            Console.WriteLine($"Number of tips available: {financialTips.Count}");
            // Ensure we have enough tips
            if (financialTips.Count >= 3)
            {
                Random random = new Random();

                // Shuffle the tips to ensure randomness
                List<string> shuffledTips = financialTips.OrderBy(x => random.Next()).ToList();

                // Debugging output
                Console.WriteLine($"Shuffled Tips: {string.Join(", ", shuffledTips)}");
                labelTip1.Visible = true;
                labelTip2.Visible = true;
                labelTip3.Visible = true;

                // Display tips on labels
                labelTip1.Text = shuffledTips[0];
                labelTip2.Text = shuffledTips[1];
                labelTip3.Text = shuffledTips[2];
            }
            else
            {
                // Handle case where there are not enough tips
                MessageBox.Show("Insufficient financial tips available.");
            }
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            timer.Stop();
            timer.Dispose();
        }
    }
}
