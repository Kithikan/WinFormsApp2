namespace WinFormsApp2
{
    partial class LoginForm
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
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnRegister = new Button();
            btnForgotPassword = new Button();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(11, 12);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(82, 20);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "User Name";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(146, 12);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(236, 27);
            txtUsername.TabIndex = 1;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(11, 59);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(146, 59);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(236, 27);
            txtPassword.TabIndex = 1;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(57, 122);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += this.btnRegister_Click;
            // 
            // btnForgotPassword
            // 
            btnForgotPassword.Location = new Point(204, 122);
            btnForgotPassword.Name = "btnForgotPassword";
            btnForgotPassword.Size = new Size(128, 29);
            btnForgotPassword.TabIndex = 2;
            btnForgotPassword.Text = "Forget-Password";
            btnForgotPassword.UseVisualStyleBackColor = true;
            btnForgotPassword.Click += this.btnForgotPassword_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(133, 183);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += this.btnLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 227);
            Controls.Add(btnLogin);
            Controls.Add(btnForgotPassword);
            Controls.Add(btnRegister);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnRegister;
        private Button btnForgotPassword;
        private Button btnLogin;
    }
}