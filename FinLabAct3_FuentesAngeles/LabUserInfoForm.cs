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
    public partial class LabUserInfoForm : Form
    {
        public LabUserInfoForm(string loggedID, string loggedPassword)
        {
            InitializeComponent();
            string userID = loggedID;
            string userPassword = loggedPassword;
            LabHelper labHelper = new LabHelper();

            DataTable userInfo = labHelper.ValidateUser(loggedID, loggedPassword);

            lblUserID.Text = userInfo.Rows[0]["UserID"].ToString();
            lblFirstName.Text = userInfo.Rows[0]["FirstName"].ToString();
            lblLastName.Text = userInfo.Rows[0]["LastName"].ToString();
            lblGender.Text = userInfo.Rows[0]["Gender"].ToString();
            lblCourse.Text = userInfo.Rows[0]["Course"].ToString();
        }
    }
}
