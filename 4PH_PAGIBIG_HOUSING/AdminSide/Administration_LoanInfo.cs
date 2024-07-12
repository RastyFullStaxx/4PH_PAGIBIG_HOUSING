using _4PH_PAGIBIG_HOUSING.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4PH_PAGIBIG_HOUSING
{
    public partial class Administration_LoanInfo : Form
    {
        public Administration_LoanInfo()
        {
            InitializeComponent();
        }

        private void btnPersonalInfo_Click(object sender, EventArgs e)
        {
            Administration_PersonalInfo administration_PersonalInfo = new Administration_PersonalInfo();
            administration_PersonalInfo.Show();
            this.Hide();
        }

        private void btnLoanInfo_Click(object sender, EventArgs e)
        {
            Administration_LoanInfo administration_LoanInfo = new Administration_LoanInfo();
            administration_LoanInfo.Show();
            this.Hide();
        }

        private void btnCollateralInfo_Click(object sender, EventArgs e)
        {
            Administration_CollateralInfo administration_CollateralInfo = new Administration_CollateralInfo();
            administration_CollateralInfo.Show();
            this.Hide();
        }

        private void btnEmploymentInfo_Click(object sender, EventArgs e)
        {
            Administration_EmploymentInfo administration_EmploymentInfo = new Administration_EmploymentInfo();
            administration_EmploymentInfo.Show();
            this.Hide();
        }

        private void btnBankInfo_Click(object sender, EventArgs e)
        {
            Administration_BankInfo administration_BankInfo = new Administration_BankInfo();
            administration_BankInfo.Show();
            this.Hide();
        }

        private void btnRealEstateInfo_Click(object sender, EventArgs e)
        {
            Administration_RealEstateInfo administration_RealEstateInfo = new Administration_RealEstateInfo();
            administration_RealEstateInfo.Show();
            this.Hide();
        }

        private void btnOtherLoanInfo_Click(object sender, EventArgs e)
        {
            Administration_OtherLoanInfo administration_OtherLoanInfo = new Administration_OtherLoanInfo();
            administration_OtherLoanInfo.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            A_Launch a_Launch = new A_Launch();
            a_Launch.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Administration_Dashboard administration_Dashboard = new Administration_Dashboard();
            administration_Dashboard.Show();
            this.Hide();
        }

        private void Administration_LoanInfo_Load(object sender, EventArgs e)
        {
            dgLoanInfo.RowTemplate.Height = 100; // Adjust the height as needed
            dgLoanInfo.Size = new Size(975, 682);

            CustomizeDataGridView(dgLoanInfo);

            LoadLoanInfo();
            LoadPagIBIGMIDNumbers();
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
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void LoadLoanInfo()
        {
            string? selectedMID = cbSelectMRID.SelectedValue?.ToString();

            string query;
            if (string.IsNullOrEmpty(selectedMID))
            {
                query = "SELECT * FROM 4PS_HOUSING_LOAN_INFORMATION";
            }
            else
            {
                query = $"SELECT * FROM 4PS_HOUSING_LOAN_INFORMATION WHERE PAG_IBIG_MID_Number_RTN = '{selectedMID}'";
            }

            DataSet ds = DatabaseConnection.Instance.ExecuteQuery(query);
            dgLoanInfo.DataSource = ds.Tables[0];

            CustomizeDataGridView(dgLoanInfo);
            dgLoanInfo.ClearSelection();
        }

        private void LoadPagIBIGMIDNumbers()
        {
            List<string> midNumbers = DatabaseConnection.Instance.GetPagIBIGMIDNumbers();
            midNumbers.Insert(0, string.Empty);
            cbSelectMRID.DataSource = midNumbers;
        }

        private void cbSelectMRID_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLoanInfo();
        }
    }
}
