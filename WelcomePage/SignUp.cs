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
using System.Windows.Forms.VisualStyles;
using static System.Net.Mime.MediaTypeNames;

namespace WelcomePage
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {
            string usernameTxt = Username.Text;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            var homeBut = new WelcomePage();
            homeBut.Show();
            this.Close();
        }

        private void SignUpSL_Click(object sender, EventArgs e)
        {
           string newFileName = Username.Text;
            string firstName = FirstName.Text;
            string lastName = LastName.Text;
            string phoneNumber = PhoneNumber.Text;
            string email = Email.Text;
            string password = Password.Text;
            Boolean validated = false;
            dataWriting(newFileName,firstName,lastName,phoneNumber,email,password, validated);


        }
    public void dataWriting(string newFileName, string firstName, string lastName, string phoneNumber, string email, string password, Boolean validation)
    {
           
            if (string.IsNullOrEmpty(newFileName) && string.IsNullOrEmpty(firstName) && string.IsNullOrEmpty(newFileName) && string.IsNullOrEmpty(newFileName) && string.IsNullOrEmpty(newFileName) && newFileName == "Username" && firstName == "First Name"
                && lastName == "Last Name" && email == "Email" && phoneNumber == "(###) ###-####")
            {
                warningLabel.Text = "Please make sure everything is filled out";
                
            }
            else
            {
                StreamWriter sw = new StreamWriter("C:\\Users\\gtfol\\source\\repos\\BudgetBuddy\\WelcomePage\\TempDatabase\\accounts.txt",true);
                StreamWriter ss = new StreamWriter("C:\\Users\\gtfol\\source\\repos\\BudgetBuddy\\WelcomePage\\TempDatabase\\budgeting.txt", true);
                StreamWriter sa = new StreamWriter("C:\\Users\\gtfol\\source\\repos\\BudgetBuddy\\WelcomePage\\TempDatabase\\admin.txt", false);

                sw.WriteLine(newFileName);
                sw.WriteLine(password);
                sw.WriteLine(firstName);
                sw.WriteLine(lastName);
                sw.WriteLine(email);
                sw.Close();
                ss.WriteLine(newFileName);
                ss.Close();
                sa.WriteLine(newFileName);
                sa.Close();

                var homeBut = new CreateBudget();
                homeBut.Show();
                this.Close();
            }
        


    }
    }
}
