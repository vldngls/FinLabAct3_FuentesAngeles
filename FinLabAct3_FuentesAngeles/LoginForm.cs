using System;
using System.Data;
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
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userID = txtUsername.Text.Trim();
            string userPassword = txtPassword.Text.Trim();

            LabHelper dbHelper = new LabHelper();

            var result = dbHelper.AuthenticateUser(userID, userPassword);

            string userType = result.Item1;
            string firstName = result.Item2;

            if (userType == "User")
            {
                //User login
                DataTable userInfoTable = dbHelper.GetUserInfo(userID);
                loggedID = userID;
                loggedFullname = $"{userInfoTable.Rows[0]["FirstName"]} {userInfoTable.Rows[0]["LastName"]}";
                loggedPassword = userPassword;

                LabUserForm userForm = new LabUserForm();
                userForm.Show();
                this.Hide();    
                MessageBox.Show($"Login successful as {firstName}!");
            }
            else if (userType == "Admin")
            {
                // Admin login
                LabAdminForm adminForm = new LabAdminForm();
                adminForm.Show();
                this.Hide();
                MessageBox.Show("Login successful as an admin!");
            }
            else
            {
                // Invalid login
                MessageBox.Show("Invalid login credentials. Please try again.");
            }
        }

    }
}
