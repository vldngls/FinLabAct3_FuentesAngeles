using LaboratoryDLL;
using System.Windows.Forms;

namespace FinLabAct3_FuentesAngeles
{
    public partial class AdminAccountsForm : Form
    {
        private LabHelper labHelper;

        public AdminAccountsForm()
        {
            InitializeComponent();
            labHelper = new LabHelper();
            LoadUserData();
        }

        private void LoadUserData()
        {
            dataGridView1.DataSource = labHelper.GetAllUsers();
        }
    }
}
