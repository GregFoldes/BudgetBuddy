namespace WelcomePage
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.LogOut = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.ExpensePage = new System.Windows.Forms.Button();
            this.BudgetButton = new System.Windows.Forms.Button();
            this.BankInfo = new System.Windows.Forms.Button();
            this.SupportButton = new System.Windows.Forms.Button();
            this.AccountButton = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // LogOut
            // 
            this.LogOut.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.LogOut.Location = new System.Drawing.Point(790, 12);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(114, 34);
            this.LogOut.TabIndex = 0;
            this.LogOut.Text = "Log Out";
            this.LogOut.UseVisualStyleBackColor = false;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.HomeButton.Enabled = false;
            this.HomeButton.Location = new System.Drawing.Point(12, 12);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(114, 34);
            this.HomeButton.TabIndex = 1;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = false;
            // 
            // ExpensePage
            // 
            this.ExpensePage.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ExpensePage.Location = new System.Drawing.Point(50, 477);
            this.ExpensePage.Name = "ExpensePage";
            this.ExpensePage.Size = new System.Drawing.Size(114, 74);
            this.ExpensePage.TabIndex = 2;
            this.ExpensePage.Text = "Expenses";
            this.ExpensePage.UseVisualStyleBackColor = false;
            this.ExpensePage.Click += new System.EventHandler(this.ExpensePage_Click);
            // 
            // BudgetButton
            // 
            this.BudgetButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BudgetButton.Location = new System.Drawing.Point(222, 477);
            this.BudgetButton.Name = "BudgetButton";
            this.BudgetButton.Size = new System.Drawing.Size(114, 74);
            this.BudgetButton.TabIndex = 3;
            this.BudgetButton.Text = "Budget";
            this.BudgetButton.UseVisualStyleBackColor = false;
            this.BudgetButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // BankInfo
            // 
            this.BankInfo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BankInfo.Enabled = false;
            this.BankInfo.Location = new System.Drawing.Point(393, 477);
            this.BankInfo.Name = "BankInfo";
            this.BankInfo.Size = new System.Drawing.Size(114, 74);
            this.BankInfo.TabIndex = 4;
            this.BankInfo.Text = "Banking";
            this.BankInfo.UseVisualStyleBackColor = false;
            this.BankInfo.Click += new System.EventHandler(this.BankInfo_Click);
            // 
            // SupportButton
            // 
            this.SupportButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.SupportButton.Location = new System.Drawing.Point(571, 477);
            this.SupportButton.Name = "SupportButton";
            this.SupportButton.Size = new System.Drawing.Size(114, 74);
            this.SupportButton.TabIndex = 5;
            this.SupportButton.Text = "Support";
            this.SupportButton.UseVisualStyleBackColor = false;
            this.SupportButton.Click += new System.EventHandler(this.SupportButton_Click);
            // 
            // AccountButton
            // 
            this.AccountButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.AccountButton.Location = new System.Drawing.Point(759, 477);
            this.AccountButton.Name = "AccountButton";
            this.AccountButton.Size = new System.Drawing.Size(114, 74);
            this.AccountButton.TabIndex = 6;
            this.AccountButton.Text = "Account";
            this.AccountButton.UseVisualStyleBackColor = false;
            this.AccountButton.Click += new System.EventHandler(this.AccountButton_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            this.chart1.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            chartArea4.BackColor = System.Drawing.Color.Transparent;
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.BackColor = System.Drawing.Color.Transparent;
            legend4.Enabled = false;
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(50, 91);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series4.BackImage = "C:\\Users\\gtfol\\Downloads\\16351392_v880-kul-16.jpg";
            series4.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series4.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Unscaled;
            series4.BackSecondaryColor = System.Drawing.Color.Transparent;
            series4.BorderColor = System.Drawing.Color.Transparent;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series4.Color = System.Drawing.Color.Transparent;
            series4.IsVisibleInLegend = false;
            series4.LabelBackColor = System.Drawing.Color.Transparent;
            series4.LabelBorderColor = System.Drawing.Color.Transparent;
            series4.LabelForeColor = System.Drawing.Color.Silver;
            series4.Legend = "Legend1";
            series4.MarkerBorderColor = System.Drawing.Color.Transparent;
            series4.Name = "Series1";
            series4.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series4.ShadowColor = System.Drawing.Color.Transparent;
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(393, 362);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(449, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 38);
            this.label1.TabIndex = 8;
            this.label1.Text = "WELCOME BACK, (USER)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
           
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(918, 606);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.AccountButton);
            this.Controls.Add(this.SupportButton);
            this.Controls.Add(this.BankInfo);
            this.Controls.Add(this.BudgetButton);
            this.Controls.Add(this.ExpensePage);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.LogOut);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button ExpensePage;
        private System.Windows.Forms.Button BudgetButton;
        private System.Windows.Forms.Button BankInfo;
        private System.Windows.Forms.Button SupportButton;
        private System.Windows.Forms.Button AccountButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}