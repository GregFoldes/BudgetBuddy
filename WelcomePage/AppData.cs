using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

public static class AppData
{
    public static int UserId { get; set; }
    public static string connectionString { get; set; }

    static AppData()
    {
        // Initialize the connection string from the configuration file
        connectionString = ConfigurationManager.ConnectionStrings["WelcomePage.Properties.Settings.Database1ConnectionString"]?.ConnectionString;

        if (string.IsNullOrEmpty(connectionString))
        {
            MessageBox.Show("Database connection string not found. Please check your configuration.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Environment.Exit(1);
        }
    }
}
