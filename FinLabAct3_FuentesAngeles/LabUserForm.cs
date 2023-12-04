using FLA3_FA;
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
            LoginForm loginuser = new LoginForm();
            loginuser.Show();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrowReturnModule brm = new BorrowReturnModule();
            brm.MdiParent = this;
            brm.Show();
        }

        private void viewTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserTransaction userTransaction = new UserTransaction();
            userTransaction.MdiParent = this;
            userTransaction.Show();
        }
    }
}
