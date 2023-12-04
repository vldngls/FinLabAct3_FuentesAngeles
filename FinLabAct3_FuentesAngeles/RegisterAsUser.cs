using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LaboratoryDLL;

namespace FLA3_FA
{
    public partial class RegisterAsUser : Form
    {
        public RegisterAsUser()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            // Get user input
            string userID = txtStudentID.Text;
            string firstName = txtFName.Text;
            string lastName = txtLName.Text;
            string gender = cmbGender.SelectedItem?.ToString(); // Use SelectedItem instead of SelectedText for ComboBox
            string course = txtCourse.Text;
            string userPassword = txtPassword.Text;
            string userType = "User";

            // Perform validation
            if (string.IsNullOrWhiteSpace(userID) || string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(gender) || string.IsNullOrWhiteSpace(course) || string.IsNullOrWhiteSpace(userPassword))
            {
                MessageBox.Show("Please fill in all the required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if validation fails
            }

            // Additional validation checks can be added, such as password strength, format checks, etc.

            // If validation passes, proceed with data insertion
            LabHelper labHelper = new LabHelper();
            labHelper.InsertUser(userID, firstName, lastName, gender, course, userPassword, userType);

            // Optionally, you can show a success message or perform other actions after successful insertion
            MessageBox.Show("User registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

    }
}
