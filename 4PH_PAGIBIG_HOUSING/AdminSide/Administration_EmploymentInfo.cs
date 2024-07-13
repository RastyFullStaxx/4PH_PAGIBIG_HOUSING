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
    public partial class Administration_EmploymentInfo : Form
    {
        public Administration_EmploymentInfo()
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

        private void Administration_EmploymentInfo_Load(object sender, EventArgs e)
        {
            LoadEmploymentInfo();
            LoadPagIBIGMIDNumbers();
        }

        private void LoadEmploymentInfo()
        {
            string? selectedMID = cbSelectMRID.SelectedValue?.ToString();

            // Update the query based on whether a MID is selected
            string query = string.IsNullOrEmpty(selectedMID)
                ? "SELECT * FROM BORROWERS_EMPLOYMENT_INFORMATION"
                : $"SELECT * FROM BORROWERS_EMPLOYMENT_INFORMATION WHERE EE_SSS_GSIS_ID_No IN " +
                  $"(SELECT EE_SSS_GSIS_ID_No FROM BORROWER_INFORMATION WHERE Pag_IBIG_MID_Number_RTN = '{selectedMID}')";

            DataSet ds = DatabaseConnection.Instance.ExecuteQuery(query);

            if (ds.Tables.Count > 0)
            {
                dgEmployment.DataSource = ds.Tables[0];
                CustomizeDataGridView(dgEmployment);
            }
            else
            {
                MessageBox.Show("No employment information found.");
                dgEmployment.DataSource = null; // Clear the DataGridView
            }
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

            // Set header style
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            // Set alternating row colors
            dgv.RowsDefaultCellStyle.BackColor = Color.White;
            dgv.RowsDefaultCellStyle.ForeColor = Color.Black;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            // Modern appearance
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void cbSelectMRID_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadEmploymentInfo();
        }
    }
}
