using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.SqlClient;

namespace WelcomePage
{
    public partial class CreateBudget : Form
    {
        public CreateBudget()
        {
            InitializeComponent();
            label15.Visible = false;
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            var homeBut = new Home();
            homeBut.Show();
            this.Close();
        }
        private bool CreateOrUpdateBudgetData()
        {
            // Validation check
            if (string.IsNullOrEmpty(TIncome.Text) && string.IsNullOrEmpty(PersonSpend.Text) && string.IsNullOrEmpty(BillSpend.Text) && string.IsNullOrEmpty(SavingSpend.Text) && string.IsNullOrEmpty(SubcriptSpend.Text) && string.IsNullOrEmpty(OtherSpend.Text) && string.IsNullOrEmpty(PersonPercent.Text) && string.IsNullOrEmpty(BillPercent.Text) && string.IsNullOrEmpty(SavingsPercent.Text) && string.IsNullOrEmpty(SavingPercent.Text) && string.IsNullOrEmpty(OtherPercent.Text))
            {
                label15.Visible = true;
                return false;
            }

            int userId = AppData.UserId;

            // Check if the user ID exists in Total table
            if (UserIdExists(userId, "Total"))
            {
                // If user ID exists, delete the existing record
                DeleteExistingRecord(userId, "Total");
            }

            // Check if the user ID exists in Des table
            if (UserIdExists(userId, "Des"))
            {
                // If user ID exists, delete the existing record
                DeleteExistingRecord(userId, "Des");
            }

            // Check if the user ID exists in Cat table
            if (UserIdExists(userId, "Cat"))
            {
                // If user ID exists, delete the existing record
                DeleteExistingRecord(userId, "Cat");
            }

            // Now, insert the new records
            InsertNewRecords(userId);

            return true;
        }

        private bool UserIdExists(int userId, string tableName)
        {
            using (SqlConnection connection = new SqlConnection(AppData.connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = $"SELECT COUNT(*) FROM [{tableName}] WHERE UserID = @UserID";
                    cmd.Parameters.AddWithValue("@UserID", userId);

                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private void DeleteExistingRecord(int userId, string tableName)
        {
            using (SqlConnection connection = new SqlConnection(AppData.connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = $"DELETE FROM [{tableName}] WHERE UserID = @UserID";
                    cmd.Parameters.AddWithValue("@UserID", userId);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void InsertNewRecords(int userId)
        {
            // Now, insert the new records as you did in your original code
            // ...

            using (SqlConnection connection = new SqlConnection(AppData.connectionString))
            {
                connection.Open();

                // Insert into Total table
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO [dbo].[Total] (UserID, Total) VALUES (@UserID, @TIncome)";
                    cmd.Parameters.AddWithValue("@UserID", userId);
                    cmd.Parameters.AddWithValue("@TIncome", TIncome.Text);

                    cmd.ExecuteNonQuery();
                }

                // Insert into Des table
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO [dbo].[Des] (UserID, dSpending, dBills, dSavings, dSubscriptions, dOther) VALUES (@UserID, @PersonSpend, @BillSpend, @SavingSpend, @SubcriptSpend, @OtherSpend)";
                    cmd.Parameters.AddWithValue("@UserID", userId);
                    cmd.Parameters.AddWithValue("@PersonSpend", PersonPercent.Text);
                    cmd.Parameters.AddWithValue("@BillSpend", BillPercent.Text);
                    cmd.Parameters.AddWithValue("@SavingSpend", SavingsPercent.Text);
                    cmd.Parameters.AddWithValue("@SubcriptSpend", SavingPercent.Text);
                    cmd.Parameters.AddWithValue("@OtherSpend", OtherPercent.Text);

                    cmd.ExecuteNonQuery();
                }

                // Insert into Cat table
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO [dbo].[Cat] (UserID, Spending, Bills, Savings, Subscriptions, Other) VALUES (@UserID, @PersonPercent, @BillPercent, @SavingsPercent, @SavingPercent, @OtherPercent)";
                    cmd.Parameters.AddWithValue("@UserID", userId);
                    cmd.Parameters.AddWithValue("@PersonPercent", PersonSpend.Text);
                    cmd.Parameters.AddWithValue("@BillPercent", BillSpend.Text);
                    cmd.Parameters.AddWithValue("@SavingsPercent", SavingSpend.Text);
                    cmd.Parameters.AddWithValue("@SavingPercent", SavingSpend.Text);
                    cmd.Parameters.AddWithValue("@OtherPercent", OtherSpend.Text);

                    cmd.ExecuteNonQuery();
                }
            }
        


        var homeBut = new Home();
            homeBut.Show();
            this.Close();

        }


        private void PersonPercent_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
            string t = TIncome.Text;
            string p = PersonSpend.Text;
            string b = BillSpend.Text;
            string sg = SavingSpend.Text;
            string sb = SubcriptSpend.Text;
            string o = OtherSpend.Text;

            int total = Convert.ToInt32(t);
            int person = Convert.ToInt32(p);
            int bills = Convert.ToInt32(b);
            int saving = Convert.ToInt32(sg);
            int subcript = Convert.ToInt32(sb);
            int other = Convert.ToInt32(o);

            perslabel.Text = PercentCalc(person, total) + "%";
            billslabel.Text = PercentCalc(bills, total) + "%";
            savingLabel.Text = PercentCalc(saving, total) + "%";
            subscriptLabel.Text = PercentCalc(subcript, total) + "%";
            otherLabel.Text = PercentCalc(other, total) + "%";

        }
        public double PercentCalc(int amount, int total)
        {
            double percent = ((double)amount / total) * 100.0;
            double Rpercent = Math.Round(percent, 2);
            return Rpercent;
        }

        private void signUpLabel_Click(object sender, EventArgs e)
        {

        }

        private void CreateBudget_Load(object sender, EventArgs e)
        {

        }

        private void TIncome_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);

        }

        private void PersonSpend_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void BillSpend_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void SavingSpend_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void SubcriptSpend_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void OtherSpend_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }


        private void BillPercent_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void SavingsPercent_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void SavingPercent_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void OtherPercent_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void CreateBudgetButton_Click(object sender, EventArgs e)
        { 
            // Call the method to create or update budget data
    if (CreateOrUpdateBudgetData())
    {
        // Budget data creation or update was successful
        // Add any additional logic or messages here
        MessageBox.Show("Budget data created or updated successfully.");
    }
    else
    {
        // Budget data creation or update failed
        // Handle the failure or display an error message
        MessageBox.Show("Budget data creation or update failed. Please check your input.");
    }
        }
    }
    
}
