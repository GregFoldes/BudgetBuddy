namespace WelcomePage
{
    partial class ForgotPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPass));
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberBox = new System.Windows.Forms.TextBox();
            this.ChangeButt = new System.Windows.Forms.Button();
            this.BackButt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UsernameBox
            // 
            this.UsernameBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.UsernameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsernameBox.ForeColor = System.Drawing.SystemColors.Window;
            this.UsernameBox.Location = new System.Drawing.Point(13, 122);
            this.UsernameBox.Margin = new System.Windows.Forms.Padding(4);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(341, 22);
            this.UsernameBox.TabIndex = 1;
            this.UsernameBox.Text = "Username";
            // 
            // EmailBox
            // 
            this.EmailBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.EmailBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailBox.ForeColor = System.Drawing.SystemColors.Window;
            this.EmailBox.Location = new System.Drawing.Point(13, 152);
            this.EmailBox.Margin = new System.Windows.Forms.Padding(4);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(341, 22);
            this.EmailBox.TabIndex = 2;
            this.EmailBox.Text = "Email";
            // 
            // PhoneNumberBox
            // 
            this.PhoneNumberBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.PhoneNumberBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhoneNumberBox.ForeColor = System.Drawing.SystemColors.Window;
            this.PhoneNumberBox.Location = new System.Drawing.Point(13, 182);
            this.PhoneNumberBox.Margin = new System.Windows.Forms.Padding(4);
            this.PhoneNumberBox.Name = "PhoneNumberBox";
            this.PhoneNumberBox.Size = new System.Drawing.Size(341, 22);
            this.PhoneNumberBox.TabIndex = 3;
            this.PhoneNumberBox.Text = "PhoneNumber";
            // 
            // ChangeButt
            // 
            this.ChangeButt.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ChangeButt.Location = new System.Drawing.Point(13, 274);
            this.ChangeButt.Margin = new System.Windows.Forms.Padding(4);
            this.ChangeButt.Name = "ChangeButt";
            this.ChangeButt.Size = new System.Drawing.Size(100, 28);
            this.ChangeButt.TabIndex = 5;
            this.ChangeButt.Text = "Change";
            this.ChangeButt.UseVisualStyleBackColor = false;
            this.ChangeButt.Click += new System.EventHandler(this.ChangeButt_Click);
            // 
            // BackButt
            // 
            this.BackButt.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackButt.Location = new System.Drawing.Point(254, 274);
            this.BackButt.Margin = new System.Windows.Forms.Padding(4);
            this.BackButt.Name = "BackButt";
            this.BackButt.Size = new System.Drawing.Size(100, 28);
            this.BackButt.TabIndex = 6;
            this.BackButt.Text = "Back";
            this.BackButt.UseVisualStyleBackColor = false;
            this.BackButt.Click += new System.EventHandler(this.BackButt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 55);
            this.label1.TabIndex = 7;
            this.label1.Text = "Forgot Password";
            // 
            // PasswordBox
            // 
            this.PasswordBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.PasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordBox.ForeColor = System.Drawing.SystemColors.Window;
            this.PasswordBox.Location = new System.Drawing.Point(13, 212);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(341, 22);
            this.PasswordBox.TabIndex = 8;
            this.PasswordBox.Text = "New Password";
            // 
            // ForgotPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WelcomePage.Properties.Resources._16351392_v880_kul_16;
            this.ClientSize = new System.Drawing.Size(376, 365);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackButt);
            this.Controls.Add(this.ChangeButt);
            this.Controls.Add(this.PhoneNumberBox);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.UsernameBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ForgotPass";
            this.Text = "Forgot Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox PhoneNumberBox;
        private System.Windows.Forms.Button ChangeButt;
        private System.Windows.Forms.Button BackButt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PasswordBox;
    }
}