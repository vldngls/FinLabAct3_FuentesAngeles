using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FinLabAct3_FuentesAngeles;
using LaboratoryDLL;

namespace FLA3_FA
{
    public partial class BorrowReturnModule : Form
    {
        public BorrowReturnModule()
        {
            InitializeComponent();
            BorrowReturnModule_Load();
            DisplayEquipmentData();
        }

        private void DisplayEquipmentData()
        {
            LabHelper dbHelper = new LabHelper();
            DataTable equipmentData = dbHelper.GetEquipmentData(); // Adjust this method based on your implementation

            // Assuming dgvEquipments is the DataGridView control
            dgvEquipments.DataSource = equipmentData;
        }

        private void txtBorrowersName_TextChanged(object sender, EventArgs e)
        {
            LabHelper dbHelper = new LabHelper();
            string userID = txtBorrowersName.Text.Trim();

        }

        public void BorrowReturnModule_Load()
        {
            LabHelper dbHelper = new LabHelper();

            // Check the loggedUserType
            if (LoginForm.loggedUserType == "Admin")
            {
                // If Admin, show all transactions
                DataTable transactions = dbHelper.GetTransactionsByUserType("Admin");
                dgvTransactions.DataSource = transactions;
            }
            else if (LoginForm.loggedUserType == "User")
            {
                // If User, show transactions made by the user
                DataTable transactions = dbHelper.GetTransactionsByUser(LoginForm.loggedID);
                dgvTransactions.DataSource = transactions;
            }

            txtBorrowersName.Text = LoginForm.loggedID;
        }



        private void btnBorrow_Click(object sender, EventArgs e)
        {
            LabHelper dbHelper = new LabHelper();
            string datetime = dtpBorrow.Text;

            string transactionID;
            if (LoginForm.loggedUserType == "User")
            {
                transactionID = datetime + "USRBRW";
            }
            else
            {
                transactionID = datetime + "ADMBRW";
            }

            string userTransact = txtBorrowersName.Text;
            string borrowedEquipment = cmbEquipment.SelectedItem.ToString();
            int borrowQuantity = (int)numericUpDown1.Value; // Assuming numericUpDown1 is the control for quantity
            string transactionReason = txtReason.Text;

            // Deduct quantity from EquipmentDB
            dbHelper.DeductEquipmentQuantity(borrowedEquipment, borrowQuantity);

            // Insert transaction
            dbHelper.InsertTransaction(transactionID, userTransact, borrowedEquipment, borrowQuantity.ToString(), datetime, transactionReason);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            LabHelper dbHelper = new LabHelper();
            string datetime = dtpBorrow.Text;

            string transactionID;
            if (LoginForm.loggedUserType == "User")
            {
                transactionID = datetime + "USRBRW";
            }
            else
            {
                transactionID = datetime + "ADMBRW";
            }

            string userTransact = txtBorrowersName.Text;
            string borrowedEquipment = cmbEquipment.SelectedItem.ToString();
            int borrowQuantity = (int)numericUpDown1.Value; // Assuming numericUpDown1 is the control for quantity
            string transactionReason = txtReason.Text;

            dbHelper.ReturnEquipment(transactionID);

            dbHelper.InsertTransaction(transactionID, userTransact, borrowedEquipment, borrowQuantity.ToString(), datetime, transactionReason);
        }

        private void BorrowReturnModule_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'laboratoryDBDataSet6.EquipmentDB' table. You can move, or remove it, as needed.
            this.equipmentDBTableAdapter3.Fill(this.laboratoryDBDataSet6.EquipmentDB);
            // TODO: This line of code loads data into the 'laboratoryDBDataSet5.TransactionDB' table. You can move, or remove it, as needed.
            this.transactionDBTableAdapter1.Fill(this.laboratoryDBDataSet5.TransactionDB);

        }
    }
}
