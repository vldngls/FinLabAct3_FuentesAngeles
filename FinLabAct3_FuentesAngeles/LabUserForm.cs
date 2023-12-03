using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinLabAct3_FuentesAngeles
{
    public partial class LabUserForm : Form
    {
        public LabUserForm()
        {
            InitializeComponent();
        }

        private void userInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LabUserInfoForm infoForm = new LabUserInfoForm(LoginForm.loggedID, LoginForm.loggedPassword);
            infoForm.MdiParent = this;
            infoForm.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
