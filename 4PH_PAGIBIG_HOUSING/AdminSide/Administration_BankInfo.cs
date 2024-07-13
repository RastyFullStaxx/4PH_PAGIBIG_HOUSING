using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _4PH_PAGIBIG_HOUSING.Database;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace _4PH_PAGIBIG_HOUSING
{
    public partial class Administration_BankInfo : Form
    {
        public Administration_BankInfo()
        {
            InitializeComponent();
        }

        private void btnPersonalInfo_Click(object sender, EventArgs e)
        {
            ShowForm(new Administration_PersonalInfo());
        }

        private void btnLoanInfo_Click(object sender, EventArgs e)
        {
            ShowForm(new Administration_LoanInfo());
        }

        private void btnCollateralInfo_Click(object sender, EventArgs e)
        {
            ShowForm(new Administration_CollateralInfo());
        }

        private void btnEmploymentInfo_Click(object sender, EventArgs e)
        {
            ShowForm(new Administration_EmploymentInfo());
        }

        private void btnBankInfo_Click(object sender, EventArgs e)
        {
            ShowForm(new Administration_BankInfo());
        }

        private void btnRealEstateInfo_Click(object sender, EventArgs e)
        {
            ShowForm(new Administration_RealEstateInfo());
        }

        private void btnOtherLoanInfo_Click(object sender, EventArgs e)
        {
            ShowForm(new Administration_OtherLoanInfo());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ShowForm(new A_Launch());
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ShowForm(new Administration_Dashboard());
        }

        private void Administration_BankInfo_Load(object sender, EventArgs e)
        {
            LoadPagIBIGMIDNumbers();
            LoadBankInformation();
        }

        private void cbSelectMRID_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBankInformation(); // Refresh data when the selected MID changes
        }

        private void LoadBankInformation()
        {
            string? selectedMID = cbSelectMRID.SelectedValue?.ToString();

            string query;
            if (string.IsNullOrEmpty(selectedMID))
            {
                query = "SELECT * FROM BANKING_INFORMATION";
            }
            else
            {
                query = $"SELECT * FROM BANKING_INFORMATION WHERE PAG_IBIG_MID_Number_RTN = '{selectedMID}'";
            }
            DataSet ds = DatabaseConnection.Instance.ExecuteQuery(query);
            dgBankInformation.DataSource = ds.Tables[0];
            CustomizeDataGridView(dgBankInformation);
        }

        private void LoadPagIBIGMIDNumbers()
        {
            List<string> midNumbers = DatabaseConnection.Instance.GetPagIBIGMIDNumbers();
            midNumbers.Insert(0, string.Empty);
            cbSelectMRID.DataSource = midNumbers;
        }

        private void CustomizeDataGridView(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BorderStyle = BorderStyle.None;
            dgv.BackgroundColor = Color.White;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToOrderColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgv.ScrollBars = ScrollBars.Both;

            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            dgv.RowsDefaultCellStyle.BackColor = Color.White;
            dgv.RowsDefaultCellStyle.ForeColor = Color.Black;
            dgv.EnableHeadersVisualStyles = false;

            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void ShowForm(Form form)
        {
            form.Show();
            this.Hide();
        }

        private void cbSelectMRID_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            LoadBankInformation();
        }
    }
}
