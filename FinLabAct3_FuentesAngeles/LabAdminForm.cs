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
    public partial class LabAdminForm : Form
    {
        public LabAdminForm()
        {
            InitializeComponent();
        }

        private void accountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminAccountsForm accForm = new AdminAccountsForm();
            accForm.ShowDialog();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterAsUser regForm = new RegisterAsUser();
            regForm.ShowDialog();
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

        private void addEquipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAndEdit addedForm = new AddAndEdit();
            addedForm.ShowDialog();
        }

        private void newTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrowReturnModule brmForm = new BorrowReturnModule();
            brmForm.ShowDialog();
        }

        private void editEquipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminViewTransactions adTransForm = new AdminViewTransactions();
            adTransForm.ShowDialog();
        }
    }
}
