using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FLA3_FA
{
    public partial class AddAndEdit : Form
    {
        public AddAndEdit()
        {
            InitializeComponent();
        }

        private void AddAndEdit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'laboratoryDBDataSet4.EquipmentDB' table. You can move, or remove it, as needed.
            this.equipmentDBTableAdapter.Fill(this.laboratoryDBDataSet4.EquipmentDB);

        }
    }
}
