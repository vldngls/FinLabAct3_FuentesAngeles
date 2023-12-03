using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            string username = txtUsername.Text;
            string password = textBox1.Text;

            LabHelper dbHelper = new LabHelper();
            DataTable result = dbHelper.ValidateUser(username, password);

            if (result.Rows.Count > 0)
            {
                string userType = result.Rows[0]["UserID"].ToString().ToLower();
                if (userType == "administratordb")
                {
                    MessageBox.Show("Welcome, Administrator.");
                    LabAdminForm adminForm = new LabAdminForm();
                    adminForm.Show();
                    this.Hide();
                }
                else
                {
                    LabUserForm userForm = new LabUserForm();

                    string firstName = result.Rows[0]["FirstName"].ToString();
                    string lastName = result.Rows[0]["LastName"].ToString();

                    loggedID = result.Rows[0]["UserID"].ToString();
                    loggedPassword = password;
                    loggedFullname = firstName + " " + lastName;

                    MessageBox.Show("Welcome, " + firstName + " " + lastName + ".");

                    userForm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Invalid credentials");
            }
}


    }
}
