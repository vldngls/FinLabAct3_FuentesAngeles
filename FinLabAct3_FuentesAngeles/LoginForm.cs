﻿using System;
using System.Windows.Forms;
using LaboratoryDLL;

namespace FinLabAct3_FuentesAngeles
{
    public partial class LoginForm : Form
    {
        public static string loggedID, loggedFullname, loggedPassword;


        public LoginForm()
        {
            InitializeComponent();

            // Initialize DatabaseOperations with your connection string
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LabHelper dbHelper = new LabHelper();
            string userID = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string userType = dbHelper.AuthenticateUser(userID, password);

            if (!string.IsNullOrEmpty(userType))
            {
                // Authentication successful
                if (userType == "Admin")
                {
                    // Redirect to Admin Page
                    LabAdminForm adminForm = new LabAdminForm();
                    adminForm.Show();
                    this.Hide();
                    MessageBox.Show("Logged in as Admin");
                }
                else if (userType == "User")
                {
                    // Redirect to User page
                    LabUserForm userForm = new LabUserForm();
                    userForm.Show();
                    this.Hide();
                    MessageBox.Show("Logged in as User");
                }
            }
            else
            {
                // Authentication failed
                MessageBox.Show("Invalid credentials. Please try again.");
            }
        }
    }
}
