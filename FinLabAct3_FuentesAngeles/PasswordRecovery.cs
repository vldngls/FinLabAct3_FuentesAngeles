using System;
using System.Data;
using System.Windows.Forms;
using LaboratoryDLL;

namespace FinLabAct3_FuentesAngeles
{
    public partial class PasswordRecovery : Form
    {
        private LabHelper labHelper = new LabHelper();
        private string selectedUserID;

        public PasswordRecovery()
        {
            InitializeComponent();
            LoadUserIDs();
        }

        private void LoadUserIDs()
        {
            // Load user IDs into the combo box
            cmbSearch.DataSource = labHelper.GetMatchingUserNames("");
            cmbSearch.DisplayMember = "UserID";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Retrieve user information based on selected user ID
            selectedUserID = cmbSearch.Text;
            DataTable userInfo = labHelper.GetUserInfo(selectedUserID);

            if (userInfo.Rows.Count > 0)
            {
                lblUserIDSearch.Text = userInfo.Rows[0]["UserID"].ToString();
                lblName.Text = userInfo.Rows[0]["FirstName"].ToString() + " " + userInfo.Rows[0]["LastName"].ToString();
            }
            else
            {
                MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            // Toggle visibility of the old password
            if (lblShowPassword.Text == "******************")
            {
                lblShowPassword.Text = labHelper.GetUserInfo(selectedUserID).Rows[0]["UserPassword"].ToString();
            }
            else
            {
                lblShowPassword.Text = "******************";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Change user password
            string newPassword = txtNPassword.Text.Trim();

            if (!string.IsNullOrEmpty(newPassword))
            {
                labHelper.ChangeUserPassword(selectedUserID, newPassword);
                MessageBox.Show("Password changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            else
            {
                MessageBox.Show("Please enter a new password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            // Clear form fields and reload user IDs
            cmbSearch.Text = "";
            lblUserIDSearch.Text = "placeholder";
            lblName.Text = "placeholder";
            lblShowPassword.Text = "******************";
            txtNPassword.Text = "";
            selectedUserID = "";
            LoadUserIDs();
        }
    }
}
