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
    public partial class AdminAccountsForm : Form
    {
        public AdminAccountsForm()
        {
            InitializeComponent();
        }

        private void AdminAccountsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'laboratoryDBDataSet.UserDB' table. You can move, or remove it, as needed.
            this.userDBTableAdapter.Fill(this.laboratoryDBDataSet.UserDB);

        }
    }
}
