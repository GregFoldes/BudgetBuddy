namespace WelcomePage
{
    partial class Budget
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Budget));
            this.HomeButton = new System.Windows.Forms.Button();
            this.oldBudgetButt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.HomeButton.Location = new System.Drawing.Point(12, 12);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(114, 34);
            this.HomeButton.TabIndex = 2;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // oldBudgetButt
            // 
            this.oldBudgetButt.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.oldBudgetButt.Location = new System.Drawing.Point(294, 247);
            this.oldBudgetButt.Name = "oldBudgetButt";
            this.oldBudgetButt.Size = new System.Drawing.Size(157, 34);
            this.oldBudgetButt.TabIndex = 4;
            this.oldBudgetButt.Text = "Load Current Budget";
            this.oldBudgetButt.UseVisualStyleBackColor = false;
            this.oldBudgetButt.Click += new System.EventHandler(this.oldBudgetButt_Click);
            // 
            // Budget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.oldBudgetButt);
            this.Controls.Add(this.HomeButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Budget";
            this.Text = "Budget";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button oldBudgetButt;
    }
}