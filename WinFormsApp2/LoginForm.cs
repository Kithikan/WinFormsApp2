using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "admin" && password == "1234")
            {
                MessageBox.Show("Login Successful!");
                MessageBox.Show("Invalid Username or Password!");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Simple placeholder behavior for Register button
            MessageBox.Show("Register is not implemented.\nUse username 'admin' and password '1234' to login.");
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            // Simple placeholder behavior for Forgot Password button
            MessageBox.Show("Password recovery is not available in this demo.");
        }

    }
}
