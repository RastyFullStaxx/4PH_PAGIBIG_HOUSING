using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using _4PH_PAGIBIG_HOUSING.Database;

namespace _4PH_PAGIBIG_HOUSING
{
    public partial class Administration_Dashboard : Form
    {
        public Administration_Dashboard()
        {
            InitializeComponent();
        }

        private void Administration_Dashboard_Load(object sender, EventArgs e)
        {
            pnlAboutUs.Visible = false;
            LoadPagIBIGMIDNumbers();
        }

        private void btnSQLProblems_Click(object sender, EventArgs e)
        {
            Ab_Easy_SQL_Problems ab_SQL_Problems = new Ab_Easy_SQL_Problems();
            ab_SQL_Problems.Show();
            this.Hide();
        }

        private void btnManageRecord_Click(object sender, EventArgs e)
        {
            // Check if the ComboBox has a selected item
            if (cbSelectMRID.SelectedItem != null)
            {
                // Safely convert the selected item to string
                string? selectedMIDNumber = cbSelectMRID.SelectedItem?.ToString();

                if (!string.IsNullOrEmpty(selectedMIDNumber))
                {
                    // If a valid item is selected, pass it to Ac_Manage_Records_SelectedUser
                    Ac_Manage_Records_SelectedUser ac_Manage_Record = new Ac_Manage_Records_SelectedUser(selectedMIDNumber);
                    ac_Manage_Record.Show();
                }
                else
                {
                    // If no valid item is selected, show Ac_Manage_Record_NoSelectedUser
                    Ac_Manage_Record_NoSelectedUser ac_Manage_Record_NoSelectedUser = new Ac_Manage_Record_NoSelectedUser();
                    ac_Manage_Record_NoSelectedUser.Show();
                }
            }
            else
            {
                // If no item is selected, show Ac_Manage_Record_NoSelectedUser
                Ac_Manage_Record_NoSelectedUser ac_Manage_Record_NoSelectedUser = new Ac_Manage_Record_NoSelectedUser();
                ac_Manage_Record_NoSelectedUser.Show();
            }

            this.Hide();

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            pnlAboutUs.Visible = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlAboutUs.Visible = false;
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


        private void LoadPagIBIGMIDNumbers()
        {
            // Fetch Pag-IBIG MID Numbers from the database
            List<string> midNumbers = DatabaseConnection.Instance.GetPagIBIGMIDNumbers();

            // Insert an empty item at the beginning of the list
            midNumbers.Insert(0, string.Empty);

            // Set the ComboBox data source to the modified list
            cbSelectMRID.DataSource = midNumbers;
        }

        private void imgAboutUs_Click(object sender, EventArgs e)
        {

        }
    }
}
