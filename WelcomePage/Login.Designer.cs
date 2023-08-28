namespace WelcomePage
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ForgotPass = new System.Windows.Forms.LinkLabel();
            this.LoginSL = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.SystemColors.MenuText;
            this.Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Username.ForeColor = System.Drawing.SystemColors.Window;
            this.Username.Location = new System.Drawing.Point(355, 182);
            this.Username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(341, 22);
            this.Username.TabIndex = 0;
            this.Username.Text = "Username";
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.SystemColors.MenuText;
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Password.ForeColor = System.Drawing.SystemColors.Window;
            this.Password.Location = new System.Drawing.Point(355, 242);
            this.Password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(341, 22);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(441, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 63);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ForgotPass
            // 
            this.ForgotPass.AutoSize = true;
            this.ForgotPass.BackColor = System.Drawing.Color.Transparent;
            this.ForgotPass.LinkColor = System.Drawing.Color.LightSlateGray;
            this.ForgotPass.Location = new System.Drawing.Point(351, 271);
            this.ForgotPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ForgotPass.Name = "ForgotPass";
            this.ForgotPass.Size = new System.Drawing.Size(116, 16);
            this.ForgotPass.TabIndex = 3;
            this.ForgotPass.TabStop = true;
            this.ForgotPass.Text = "Forgot Password?";
            // 
            // LoginSL
            // 
            this.LoginSL.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LoginSL.Location = new System.Drawing.Point(355, 315);
            this.LoginSL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoginSL.Name = "LoginSL";
            this.LoginSL.Size = new System.Drawing.Size(100, 28);
            this.LoginSL.TabIndex = 4;
            this.LoginSL.Text = "Login";
            this.LoginSL.UseVisualStyleBackColor = false;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Back.Location = new System.Drawing.Point(596, 315);
            this.Back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(100, 28);
            this.Back.TabIndex = 5;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.LoginSL);
            this.Controls.Add(this.ForgotPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel ForgotPass;
        private System.Windows.Forms.Button LoginSL;
        private System.Windows.Forms.Button Back;
    }
}