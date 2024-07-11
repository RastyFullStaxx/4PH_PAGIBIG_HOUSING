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
    }
}
