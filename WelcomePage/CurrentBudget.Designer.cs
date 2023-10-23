namespace WelcomePage
{
    partial class CurrentBudget
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrentBudget));
            this.HomeButton = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.TILabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.OSpendLabel = new System.Windows.Forms.Label();
            this.SubSpendLabel = new System.Windows.Forms.Label();
            this.SSpendLabel = new System.Windows.Forms.Label();
            this.BSpendLabel = new System.Windows.Forms.Label();
            this.PSpendLabel = new System.Windows.Forms.Label();
            this.OPercentLabel = new System.Windows.Forms.Label();
            this.SubPercentLabel = new System.Windows.Forms.Label();
            this.SPercentLabel = new System.Windows.Forms.Label();
            this.BPercentLabel = new System.Windows.Forms.Label();
            this.PPercentLabel = new System.Windows.Forms.Label();
            this.DOSpendLabel = new System.Windows.Forms.Label();
            this.DSubSpendLabel = new System.Windows.Forms.Label();
            this.DSSpendLabel = new System.Windows.Forms.Label();
            this.DBSpendLabel = new System.Windows.Forms.Label();
            this.DPSpendLabel = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.DSubPercentLabel = new System.Windows.Forms.Label();
            this.DSPercentLabel = new System.Windows.Forms.Label();
            this.DBPercentLabel = new System.Windows.Forms.Label();
            this.DPPercentLabel = new System.Windows.Forms.Label();
            this.ODiffLabel = new System.Windows.Forms.Label();
            this.SubDiffLabel = new System.Windows.Forms.Label();
            this.SDiffLabel = new System.Windows.Forms.Label();
            this.BDiffLabel = new System.Windows.Forms.Label();
            this.PDiffLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.HomeButton.Enabled = false;
            this.HomeButton.Location = new System.Drawing.Point(12, 12);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(114, 34);
            this.HomeButton.TabIndex = 2;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            this.chart1.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(35, 96);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.BackImage = "C:\\Users\\gtfol\\Downloads\\16351392_v880-kul-16.jpg";
            series1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series1.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Unscaled;
            series1.BackSecondaryColor = System.Drawing.Color.Transparent;
            series1.BorderColor = System.Drawing.Color.Transparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Color = System.Drawing.Color.Transparent;
            series1.IsVisibleInLegend = false;
            series1.LabelBackColor = System.Drawing.Color.Transparent;
            series1.LabelBorderColor = System.Drawing.Color.Transparent;
            series1.LabelForeColor = System.Drawing.Color.Silver;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.Transparent;
            series1.Name = "Series1";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ShadowColor = System.Drawing.Color.Transparent;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(393, 362);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.Transparent;
            this.chart2.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.chart2.BorderlineColor = System.Drawing.Color.Transparent;
            this.chart2.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(482, 96);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.BackImage = "C:\\Users\\gtfol\\Downloads\\16351392_v880-kul-16.jpg";
            series2.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series2.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Unscaled;
            series2.BackSecondaryColor = System.Drawing.Color.Transparent;
            series2.BorderColor = System.Drawing.Color.Transparent;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Color = System.Drawing.Color.Transparent;
            series2.IsVisibleInLegend = false;
            series2.LabelBackColor = System.Drawing.Color.Transparent;
            series2.LabelBorderColor = System.Drawing.Color.Transparent;
            series2.LabelForeColor = System.Drawing.Color.Silver;
            series2.Legend = "Legend1";
            series2.MarkerBorderColor = System.Drawing.Color.Transparent;
            series2.Name = "Series1";
            series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ShadowColor = System.Drawing.Color.Transparent;
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(393, 362);
            this.chart2.TabIndex = 9;
            this.chart2.Text = "chart2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(311, 483);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Total Income: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TILabel
            // 
            this.TILabel.AutoSize = true;
            this.TILabel.BackColor = System.Drawing.Color.Transparent;
            this.TILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TILabel.ForeColor = System.Drawing.SystemColors.Control;
            this.TILabel.Location = new System.Drawing.Point(446, 483);
            this.TILabel.Name = "TILabel";
            this.TILabel.Size = new System.Drawing.Size(0, 20);
            this.TILabel.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 532);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Personal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(12, 587);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Bills";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(12, 636);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Savings";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(12, 691);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Subscriptions";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(12, 743);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Other";
            // 
            // OSpendLabel
            // 
            this.OSpendLabel.AutoSize = true;
            this.OSpendLabel.BackColor = System.Drawing.Color.Transparent;
            this.OSpendLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OSpendLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.OSpendLabel.Location = new System.Drawing.Point(169, 743);
            this.OSpendLabel.Name = "OSpendLabel";
            this.OSpendLabel.Size = new System.Drawing.Size(19, 20);
            this.OSpendLabel.TabIndex = 21;
            this.OSpendLabel.Text = "1";
            // 
            // SubSpendLabel
            // 
            this.SubSpendLabel.AutoSize = true;
            this.SubSpendLabel.BackColor = System.Drawing.Color.Transparent;
            this.SubSpendLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubSpendLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.SubSpendLabel.Location = new System.Drawing.Point(169, 691);
            this.SubSpendLabel.Name = "SubSpendLabel";
            this.SubSpendLabel.Size = new System.Drawing.Size(19, 20);
            this.SubSpendLabel.TabIndex = 20;
            this.SubSpendLabel.Text = "1";
            // 
            // SSpendLabel
            // 
            this.SSpendLabel.AutoSize = true;
            this.SSpendLabel.BackColor = System.Drawing.Color.Transparent;
            this.SSpendLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SSpendLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.SSpendLabel.Location = new System.Drawing.Point(169, 636);
            this.SSpendLabel.Name = "SSpendLabel";
            this.SSpendLabel.Size = new System.Drawing.Size(19, 20);
            this.SSpendLabel.TabIndex = 19;
            this.SSpendLabel.Text = "1";
            // 
            // BSpendLabel
            // 
            this.BSpendLabel.AutoSize = true;
            this.BSpendLabel.BackColor = System.Drawing.Color.Transparent;
            this.BSpendLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSpendLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.BSpendLabel.Location = new System.Drawing.Point(169, 587);
            this.BSpendLabel.Name = "BSpendLabel";
            this.BSpendLabel.Size = new System.Drawing.Size(19, 20);
            this.BSpendLabel.TabIndex = 18;
            this.BSpendLabel.Text = "1";
            // 
            // PSpendLabel
            // 
            this.PSpendLabel.AutoSize = true;
            this.PSpendLabel.BackColor = System.Drawing.Color.Transparent;
            this.PSpendLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PSpendLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.PSpendLabel.Location = new System.Drawing.Point(169, 532);
            this.PSpendLabel.Name = "PSpendLabel";
            this.PSpendLabel.Size = new System.Drawing.Size(19, 20);
            this.PSpendLabel.TabIndex = 17;
            this.PSpendLabel.Text = "1";
            // 
            // OPercentLabel
            // 
            this.OPercentLabel.AutoSize = true;
            this.OPercentLabel.BackColor = System.Drawing.Color.Transparent;
            this.OPercentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OPercentLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.OPercentLabel.Location = new System.Drawing.Point(285, 743);
            this.OPercentLabel.Name = "OPercentLabel";
            this.OPercentLabel.Size = new System.Drawing.Size(19, 20);
            this.OPercentLabel.TabIndex = 26;
            this.OPercentLabel.Text = "1";
            // 
            // SubPercentLabel
            // 
            this.SubPercentLabel.AutoSize = true;
            this.SubPercentLabel.BackColor = System.Drawing.Color.Transparent;
            this.SubPercentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubPercentLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.SubPercentLabel.Location = new System.Drawing.Point(285, 691);
            this.SubPercentLabel.Name = "SubPercentLabel";
            this.SubPercentLabel.Size = new System.Drawing.Size(19, 20);
            this.SubPercentLabel.TabIndex = 25;
            this.SubPercentLabel.Text = "1";
            // 
            // SPercentLabel
            // 
            this.SPercentLabel.AutoSize = true;
            this.SPercentLabel.BackColor = System.Drawing.Color.Transparent;
            this.SPercentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SPercentLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.SPercentLabel.Location = new System.Drawing.Point(285, 636);
            this.SPercentLabel.Name = "SPercentLabel";
            this.SPercentLabel.Size = new System.Drawing.Size(19, 20);
            this.SPercentLabel.TabIndex = 24;
            this.SPercentLabel.Text = "1";
            // 
            // BPercentLabel
            // 
            this.BPercentLabel.AutoSize = true;
            this.BPercentLabel.BackColor = System.Drawing.Color.Transparent;
            this.BPercentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BPercentLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.BPercentLabel.Location = new System.Drawing.Point(285, 587);
            this.BPercentLabel.Name = "BPercentLabel";
            this.BPercentLabel.Size = new System.Drawing.Size(19, 20);
            this.BPercentLabel.TabIndex = 23;
            this.BPercentLabel.Text = "1";
            // 
            // PPercentLabel
            // 
            this.PPercentLabel.AutoSize = true;
            this.PPercentLabel.BackColor = System.Drawing.Color.Transparent;
            this.PPercentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PPercentLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.PPercentLabel.Location = new System.Drawing.Point(285, 532);
            this.PPercentLabel.Name = "PPercentLabel";
            this.PPercentLabel.Size = new System.Drawing.Size(19, 20);
            this.PPercentLabel.TabIndex = 22;
            this.PPercentLabel.Text = "1";
            // 
            // DOSpendLabel
            // 
            this.DOSpendLabel.AutoSize = true;
            this.DOSpendLabel.BackColor = System.Drawing.Color.Transparent;
            this.DOSpendLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOSpendLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.DOSpendLabel.Location = new System.Drawing.Point(607, 743);
            this.DOSpendLabel.Name = "DOSpendLabel";
            this.DOSpendLabel.Size = new System.Drawing.Size(19, 20);
            this.DOSpendLabel.TabIndex = 31;
            this.DOSpendLabel.Text = "1";
            // 
            // DSubSpendLabel
            // 
            this.DSubSpendLabel.AutoSize = true;
            this.DSubSpendLabel.BackColor = System.Drawing.Color.Transparent;
            this.DSubSpendLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DSubSpendLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.DSubSpendLabel.Location = new System.Drawing.Point(607, 691);
            this.DSubSpendLabel.Name = "DSubSpendLabel";
            this.DSubSpendLabel.Size = new System.Drawing.Size(19, 20);
            this.DSubSpendLabel.TabIndex = 30;
            this.DSubSpendLabel.Text = "1";
            // 
            // DSSpendLabel
            // 
            this.DSSpendLabel.AutoSize = true;
            this.DSSpendLabel.BackColor = System.Drawing.Color.Transparent;
            this.DSSpendLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DSSpendLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.DSSpendLabel.Location = new System.Drawing.Point(607, 636);
            this.DSSpendLabel.Name = "DSSpendLabel";
            this.DSSpendLabel.Size = new System.Drawing.Size(19, 20);
            this.DSSpendLabel.TabIndex = 29;
            this.DSSpendLabel.Text = "1";
            // 
            // DBSpendLabel
            // 
            this.DBSpendLabel.AutoSize = true;
            this.DBSpendLabel.BackColor = System.Drawing.Color.Transparent;
            this.DBSpendLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DBSpendLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.DBSpendLabel.Location = new System.Drawing.Point(607, 587);
            this.DBSpendLabel.Name = "DBSpendLabel";
            this.DBSpendLabel.Size = new System.Drawing.Size(19, 20);
            this.DBSpendLabel.TabIndex = 28;
            this.DBSpendLabel.Text = "1";
            // 
            // DPSpendLabel
            // 
            this.DPSpendLabel.AutoSize = true;
            this.DPSpendLabel.BackColor = System.Drawing.Color.Transparent;
            this.DPSpendLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DPSpendLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.DPSpendLabel.Location = new System.Drawing.Point(607, 532);
            this.DPSpendLabel.Name = "DPSpendLabel";
            this.DPSpendLabel.Size = new System.Drawing.Size(19, 20);
            this.DPSpendLabel.TabIndex = 27;
            this.DPSpendLabel.Text = "1";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.Control;
            this.label22.Location = new System.Drawing.Point(727, 743);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(19, 20);
            this.label22.TabIndex = 36;
            this.label22.Text = "1";
            // 
            // DSubPercentLabel
            // 
            this.DSubPercentLabel.AutoSize = true;
            this.DSubPercentLabel.BackColor = System.Drawing.Color.Transparent;
            this.DSubPercentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DSubPercentLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.DSubPercentLabel.Location = new System.Drawing.Point(727, 691);
            this.DSubPercentLabel.Name = "DSubPercentLabel";
            this.DSubPercentLabel.Size = new System.Drawing.Size(19, 20);
            this.DSubPercentLabel.TabIndex = 35;
            this.DSubPercentLabel.Text = "1";
            // 
            // DSPercentLabel
            // 
            this.DSPercentLabel.AutoSize = true;
            this.DSPercentLabel.BackColor = System.Drawing.Color.Transparent;
            this.DSPercentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DSPercentLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.DSPercentLabel.Location = new System.Drawing.Point(727, 636);
            this.DSPercentLabel.Name = "DSPercentLabel";
            this.DSPercentLabel.Size = new System.Drawing.Size(19, 20);
            this.DSPercentLabel.TabIndex = 34;
            this.DSPercentLabel.Text = "1";
            // 
            // DBPercentLabel
            // 
            this.DBPercentLabel.AutoSize = true;
            this.DBPercentLabel.BackColor = System.Drawing.Color.Transparent;
            this.DBPercentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DBPercentLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.DBPercentLabel.Location = new System.Drawing.Point(727, 587);
            this.DBPercentLabel.Name = "DBPercentLabel";
            this.DBPercentLabel.Size = new System.Drawing.Size(19, 20);
            this.DBPercentLabel.TabIndex = 33;
            this.DBPercentLabel.Text = "1";
            // 
            // DPPercentLabel
            // 
            this.DPPercentLabel.AutoSize = true;
            this.DPPercentLabel.BackColor = System.Drawing.Color.Transparent;
            this.DPPercentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DPPercentLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.DPPercentLabel.Location = new System.Drawing.Point(727, 532);
            this.DPPercentLabel.Name = "DPPercentLabel";
            this.DPPercentLabel.Size = new System.Drawing.Size(19, 20);
            this.DPPercentLabel.TabIndex = 32;
            this.DPPercentLabel.Text = "1";
            // 
            // ODiffLabel
            // 
            this.ODiffLabel.AutoSize = true;
            this.ODiffLabel.BackColor = System.Drawing.Color.Transparent;
            this.ODiffLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ODiffLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.ODiffLabel.Location = new System.Drawing.Point(427, 743);
            this.ODiffLabel.Name = "ODiffLabel";
            this.ODiffLabel.Size = new System.Drawing.Size(19, 20);
            this.ODiffLabel.TabIndex = 41;
            this.ODiffLabel.Text = "1";
            // 
            // SubDiffLabel
            // 
            this.SubDiffLabel.AutoSize = true;
            this.SubDiffLabel.BackColor = System.Drawing.Color.Transparent;
            this.SubDiffLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubDiffLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.SubDiffLabel.Location = new System.Drawing.Point(427, 691);
            this.SubDiffLabel.Name = "SubDiffLabel";
            this.SubDiffLabel.Size = new System.Drawing.Size(19, 20);
            this.SubDiffLabel.TabIndex = 40;
            this.SubDiffLabel.Text = "1";
            // 
            // SDiffLabel
            // 
            this.SDiffLabel.AutoSize = true;
            this.SDiffLabel.BackColor = System.Drawing.Color.Transparent;
            this.SDiffLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SDiffLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.SDiffLabel.Location = new System.Drawing.Point(427, 636);
            this.SDiffLabel.Name = "SDiffLabel";
            this.SDiffLabel.Size = new System.Drawing.Size(19, 20);
            this.SDiffLabel.TabIndex = 39;
            this.SDiffLabel.Text = "1";
            // 
            // BDiffLabel
            // 
            this.BDiffLabel.AutoSize = true;
            this.BDiffLabel.BackColor = System.Drawing.Color.Transparent;
            this.BDiffLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BDiffLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.BDiffLabel.Location = new System.Drawing.Point(427, 587);
            this.BDiffLabel.Name = "BDiffLabel";
            this.BDiffLabel.Size = new System.Drawing.Size(19, 20);
            this.BDiffLabel.TabIndex = 38;
            this.BDiffLabel.Text = "1";
            // 
            // PDiffLabel
            // 
            this.PDiffLabel.AutoSize = true;
            this.PDiffLabel.BackColor = System.Drawing.Color.Transparent;
            this.PDiffLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PDiffLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.PDiffLabel.Location = new System.Drawing.Point(427, 532);
            this.PDiffLabel.Name = "PDiffLabel";
            this.PDiffLabel.Size = new System.Drawing.Size(19, 20);
            this.PDiffLabel.TabIndex = 37;
            this.PDiffLabel.Text = "1";
            // 
            // CurrentBudget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WelcomePage.Properties.Resources._16351392_v880_kul_16;
            this.ClientSize = new System.Drawing.Size(906, 805);
            this.Controls.Add(this.ODiffLabel);
            this.Controls.Add(this.SubDiffLabel);
            this.Controls.Add(this.SDiffLabel);
            this.Controls.Add(this.BDiffLabel);
            this.Controls.Add(this.PDiffLabel);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.DSubPercentLabel);
            this.Controls.Add(this.DSPercentLabel);
            this.Controls.Add(this.DBPercentLabel);
            this.Controls.Add(this.DPPercentLabel);
            this.Controls.Add(this.DOSpendLabel);
            this.Controls.Add(this.DSubSpendLabel);
            this.Controls.Add(this.DSSpendLabel);
            this.Controls.Add(this.DBSpendLabel);
            this.Controls.Add(this.DPSpendLabel);
            this.Controls.Add(this.OPercentLabel);
            this.Controls.Add(this.SubPercentLabel);
            this.Controls.Add(this.SPercentLabel);
            this.Controls.Add(this.BPercentLabel);
            this.Controls.Add(this.PPercentLabel);
            this.Controls.Add(this.OSpendLabel);
            this.Controls.Add(this.SubSpendLabel);
            this.Controls.Add(this.SSpendLabel);
            this.Controls.Add(this.BSpendLabel);
            this.Controls.Add(this.PSpendLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TILabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.HomeButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CurrentBudget";
            this.Text = "CurrentBudget";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TILabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label OSpendLabel;
        private System.Windows.Forms.Label SubSpendLabel;
        private System.Windows.Forms.Label SSpendLabel;
        private System.Windows.Forms.Label BSpendLabel;
        private System.Windows.Forms.Label PSpendLabel;
        private System.Windows.Forms.Label OPercentLabel;
        private System.Windows.Forms.Label SubPercentLabel;
        private System.Windows.Forms.Label SPercentLabel;
        private System.Windows.Forms.Label BPercentLabel;
        private System.Windows.Forms.Label PPercentLabel;
        private System.Windows.Forms.Label DOSpendLabel;
        private System.Windows.Forms.Label DSubSpendLabel;
        private System.Windows.Forms.Label DSSpendLabel;
        private System.Windows.Forms.Label DBSpendLabel;
        private System.Windows.Forms.Label DPSpendLabel;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label DSubPercentLabel;
        private System.Windows.Forms.Label DSPercentLabel;
        private System.Windows.Forms.Label DBPercentLabel;
        private System.Windows.Forms.Label DPPercentLabel;
        private System.Windows.Forms.Label ODiffLabel;
        private System.Windows.Forms.Label SubDiffLabel;
        private System.Windows.Forms.Label SDiffLabel;
        private System.Windows.Forms.Label BDiffLabel;
        private System.Windows.Forms.Label PDiffLabel;
    }
}