namespace WelcomePage
{
    partial class Tips
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tips));
            this.HomeButton = new System.Windows.Forms.Button();
            this.labelTip1 = new System.Windows.Forms.Label();
            this.labelTip2 = new System.Windows.Forms.Label();
            this.labelTip3 = new System.Windows.Forms.Label();
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
            // labelTip1
            // 
            this.labelTip1.AutoSize = true;
            this.labelTip1.BackColor = System.Drawing.Color.Transparent;
            this.labelTip1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTip1.ForeColor = System.Drawing.Color.Silver;
            this.labelTip1.Location = new System.Drawing.Point(47, 113);
            this.labelTip1.Name = "labelTip1";
            this.labelTip1.Size = new System.Drawing.Size(18, 19);
            this.labelTip1.TabIndex = 7;
            this.labelTip1.Text = "1";
            this.labelTip1.Visible = false;
            // 
            // labelTip2
            // 
            this.labelTip2.AutoSize = true;
            this.labelTip2.BackColor = System.Drawing.Color.Transparent;
            this.labelTip2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTip2.ForeColor = System.Drawing.Color.Silver;
            this.labelTip2.Location = new System.Drawing.Point(47, 199);
            this.labelTip2.Name = "labelTip2";
            this.labelTip2.Size = new System.Drawing.Size(18, 19);
            this.labelTip2.TabIndex = 8;
            this.labelTip2.Text = "1";
            this.labelTip2.Visible = false;
            // 
            // labelTip3
            // 
            this.labelTip3.AutoSize = true;
            this.labelTip3.BackColor = System.Drawing.Color.Transparent;
            this.labelTip3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTip3.ForeColor = System.Drawing.Color.Silver;
            this.labelTip3.Location = new System.Drawing.Point(47, 300);
            this.labelTip3.Name = "labelTip3";
            this.labelTip3.Size = new System.Drawing.Size(18, 19);
            this.labelTip3.TabIndex = 9;
            this.labelTip3.Text = "1";
            this.labelTip3.Visible = false;
            // 
            // Tips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTip3);
            this.Controls.Add(this.labelTip2);
            this.Controls.Add(this.labelTip1);
            this.Controls.Add(this.HomeButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tips";
            this.Text = "Tips";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Label labelTip1;
        private System.Windows.Forms.Label labelTip2;
        private System.Windows.Forms.Label labelTip3;
    }
}