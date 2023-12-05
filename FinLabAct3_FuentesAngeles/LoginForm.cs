using System;
using System.Data;
using System.Windows.Forms;
using LaboratoryDLL;

namespace FinLabAct3_FuentesAngeles
{
    public partial class LoginForm : Form
    {
        public static string loggedID, loggedFullname, loggedPassword, loggedUserType;


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

            //save public strings
            DataTable userInfo = dbHelper.GetUserInfo(userID);

            loggedID = userID;
            loggedPassword = password;
            string fname = userInfo.Rows[0]["FirstName"].ToString();
            string lname = userInfo.Rows[0]["LastName"].ToString();
            loggedFullname = fname + " " + lname;


            if (!string.IsNullOrEmpty(userType))
            {
                // Authentication successful
                if (userType == "Admin")
                {
                    // Redirect to Admin Page
                    loggedUserType = "Admin";
                    LabAdminForm adminForm = new LabAdminForm();
                    adminForm.Show();
                    this.Hide();
                    MessageBox.Show("Logged in as Administrator.");
                }
                else if (userType == "User")
                {
                    // Redirect to User page
                    loggedUserType = "User";
                    LabUserForm userForm = new LabUserForm();
                    userForm.Show();
                    this.Hide();
                    MessageBox.Show("Welcome, Logged in as " + loggedFullname);
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
