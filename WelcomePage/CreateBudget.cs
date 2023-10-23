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
        private void CreateBudgetData(Boolean valid)
        {
            StreamWriter ss = new StreamWriter("C:\\Users\\gtfol\\source\\repos\\BudgetBuddy\\WelcomePage\\TempDatabase\\budgeting.txt", true);

            if (string.IsNullOrEmpty(TIncome.Text) && string.IsNullOrEmpty(PersonSpend.Text) && string.IsNullOrEmpty(BillSpend.Text) && string.IsNullOrEmpty(SavingSpend.Text) && string.IsNullOrEmpty(SubcriptSpend.Text) && string.IsNullOrEmpty(OtherSpend.Text) && string.IsNullOrEmpty(PersonPercent.Text) && string.IsNullOrEmpty(BillPercent.Text) && string.IsNullOrEmpty(SavingsPercent.Text) && string.IsNullOrEmpty(SavingPercent.Text) && string.IsNullOrEmpty(OtherPercent.Text))
            {
                label15.Visible = true;
            }
            else
            {
                ss.WriteLine(TIncome.Text);
                ss.WriteLine(PersonSpend.Text);
                ss.WriteLine(BillSpend.Text);
                ss.WriteLine(SavingSpend.Text);
                ss.WriteLine(SubcriptSpend.Text);
                ss.WriteLine(OtherSpend.Text);
                ss.WriteLine(PersonPercent.Text);
                ss.WriteLine(BillPercent.Text);
                ss.WriteLine(SavingsPercent.Text);
                ss.WriteLine(SavingPercent.Text);
                ss.WriteLine(OtherPercent.Text);
                ss.Close();
                valid = true;
            }
            if (valid)
            {
                var homeBut = new Home();
                homeBut.Show();
                this.Close();
            }
            else
            {
                label15.Visible = true;
            }
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
        public int PercentCalc(int ammount, int total)
        {
            int percent;
            percent = (ammount / total) * 100;

            return percent;
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
            Boolean validation = false;
            CreateBudgetData(validation);
        }
    }
    
}
