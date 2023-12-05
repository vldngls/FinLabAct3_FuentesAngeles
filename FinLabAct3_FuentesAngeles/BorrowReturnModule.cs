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
    public partial class BorrowReturnModule : Form
    {
        public BorrowReturnModule()
        {
            InitializeComponent();
        }

        private void txtBorrowersName_TextChanged(object sender, EventArgs e)
        {
            LabHelper dbHelper = new LabHelper();
            string userID = txtBorrowersName.Text.Trim();
           
        }

        private void BorrowReturnModule_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'laboratoryDBDataSet3.TransactionDB' table. You can move, or remove it, as needed.
            this.transactionDBTableAdapter.Fill(this.laboratoryDBDataSet3.TransactionDB);
            // TODO: This line of code loads data into the 'laboratoryDBDataSet2.EquipmentDB' table. You can move, or remove it, as needed.
            this.equipmentDBTableAdapter2.Fill(this.laboratoryDBDataSet2.EquipmentDB);
            // TODO: This line of code loads data into the 'laboratoryDBDataSet1.EquipmentDB' table. You can move, or remove it, as needed.
            this.equipmentDBTableAdapter1.Fill(this.laboratoryDBDataSet1.EquipmentDB);
            // TODO: This line of code loads data into the 'laboratoryDBDataSet.EquipmentDB' table. You can move, or remove it, as needed.
            this.equipmentDBTableAdapter.Fill(this.laboratoryDBDataSet.EquipmentDB);

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtReason_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbEquipment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
