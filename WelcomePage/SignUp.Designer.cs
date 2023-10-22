namespace WelcomePage
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.signUpLabel = new System.Windows.Forms.Label();
            this.SignUpSL = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.warningLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.SystemColors.MenuText;
            this.Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Username.ForeColor = System.Drawing.SystemColors.Window;
            this.Username.Location = new System.Drawing.Point(365, 320);
            this.Username.Margin = new System.Windows.Forms.Padding(4);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(341, 22);
            this.Username.TabIndex = 1;
            this.Username.Text = "Username";
            this.Username.TextChanged += new System.EventHandler(this.Username_TextChanged);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.SystemColors.MenuText;
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Password.ForeColor = System.Drawing.SystemColors.Window;
            this.Password.Location = new System.Drawing.Point(365, 350);
            this.Password.Margin = new System.Windows.Forms.Padding(4);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(341, 22);
            this.Password.TabIndex = 2;
            this.Password.Text = "Password";
            // 
            // Email
            // 
            this.Email.BackColor = System.Drawing.SystemColors.MenuText;
            this.Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Email.ForeColor = System.Drawing.SystemColors.Window;
            this.Email.Location = new System.Drawing.Point(365, 380);
            this.Email.Margin = new System.Windows.Forms.Padding(4);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(341, 22);
            this.Email.TabIndex = 3;
            this.Email.Text = "Email";
            // 
            // FirstName
            // 
            this.FirstName.BackColor = System.Drawing.SystemColors.MenuText;
            this.FirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstName.ForeColor = System.Drawing.SystemColors.Window;
            this.FirstName.Location = new System.Drawing.Point(365, 260);
            this.FirstName.Margin = new System.Windows.Forms.Padding(4);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(147, 22);
            this.FirstName.TabIndex = 4;
            this.FirstName.Text = "First Name";
            // 
            // LastName
            // 
            this.LastName.BackColor = System.Drawing.SystemColors.MenuText;
            this.LastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LastName.ForeColor = System.Drawing.SystemColors.Window;
            this.LastName.Location = new System.Drawing.Point(553, 260);
            this.LastName.Margin = new System.Windows.Forms.Padding(4);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(153, 22);
            this.LastName.TabIndex = 5;
            this.LastName.Text = "Last Name";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.BackColor = System.Drawing.SystemColors.MenuText;
            this.PhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhoneNumber.ForeColor = System.Drawing.SystemColors.Window;
            this.PhoneNumber.Location = new System.Drawing.Point(365, 290);
            this.PhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(341, 22);
            this.PhoneNumber.TabIndex = 6;
            this.PhoneNumber.Text = "(###) ###-####";
            // 
            // signUpLabel
            // 
            this.signUpLabel.AutoSize = true;
            this.signUpLabel.BackColor = System.Drawing.Color.Transparent;
            this.signUpLabel.Font = new System.Drawing.Font("Palatino Linotype", 28F, System.Drawing.FontStyle.Bold);
            this.signUpLabel.ForeColor = System.Drawing.Color.White;
            this.signUpLabel.Location = new System.Drawing.Point(312, 109);
            this.signUpLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.signUpLabel.Name = "signUpLabel";
            this.signUpLabel.Size = new System.Drawing.Size(470, 63);
            this.signUpLabel.TabIndex = 7;
            this.signUpLabel.Text = "Create New Account";
            // 
            // SignUpSL
            // 
            this.SignUpSL.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SignUpSL.Location = new System.Drawing.Point(365, 422);
            this.SignUpSL.Margin = new System.Windows.Forms.Padding(4);
            this.SignUpSL.Name = "SignUpSL";
            this.SignUpSL.Size = new System.Drawing.Size(100, 28);
            this.SignUpSL.TabIndex = 8;
            this.SignUpSL.Text = "SignUp";
            this.SignUpSL.UseVisualStyleBackColor = false;
            this.SignUpSL.Click += new System.EventHandler(this.SignUpSL_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Back.Location = new System.Drawing.Point(606, 422);
            this.Back.Margin = new System.Windows.Forms.Padding(4);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(100, 28);
            this.Back.TabIndex = 9;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.BackColor = System.Drawing.Color.Transparent;
            this.warningLabel.ForeColor = System.Drawing.Color.Brown;
            this.warningLabel.Location = new System.Drawing.Point(503, 199);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(0, 16);
            this.warningLabel.TabIndex = 11;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.SignUpSL);
            this.Controls.Add(this.signUpLabel);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox PhoneNumber;
        private System.Windows.Forms.Label signUpLabel;
        private System.Windows.Forms.Button SignUpSL;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label warningLabel;
    }
}