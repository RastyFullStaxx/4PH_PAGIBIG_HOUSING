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
using System.IO;
using System.Windows.Forms;


namespace _4PH_PAGIBIG_HOUSING
{
    public partial class Overview : Form
    {
        private readonly string _pagibigMIDNumber, _tct;
        private readonly DatabaseConnection _database = DatabaseConnection.Instance;

        public Overview(string pagibigMIDNumber)
        {
            InitializeComponent();
            _pagibigMIDNumber = pagibigMIDNumber;
            LoadBorrowerInformation();
        }

        private void guna2HtmlLabel38_Click(object sender, EventArgs e)
        {

        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Submission_Success submission_Success = new Submission_Success();
            submission_Success.Show();
        }



        private void LoadBorrowerInformation()
        {
            string query = $@"
                SELECT * FROM BORROWER_INFORMATION WHERE Pag_IBIG_MID_Number_RTN = '{_pagibigMIDNumber}';
                SELECT * FROM BORROWERS_EMPLOYMENT_INFORMATION WHERE EE_SSS_GSIS_ID_No IN (SELECT EE_SSS_GSIS_ID_No FROM BORROWER_INFORMATION WHERE Pag_IBIG_MID_Number_RTN = '{_pagibigMIDNumber}');
                SELECT * FROM COLLATERAL_INFORMATION WHERE Pag_IBIG_MID_Number_RTN = '{_pagibigMIDNumber}';
                SELECT * FROM 4PS_HOUSING_LOAN_INFORMATION WHERE PAG_IBIG_MID_Number_RTN = '{_pagibigMIDNumber}';
                SELECT * FROM BANKING_INFORMATION WHERE PAG_IBIG_MID_Number_RTN = '{_pagibigMIDNumber}';
                SELECT * FROM REAL_ESTATE_INFORMATION WHERE PAG_IBIG_MID_Number_RTN = '{_pagibigMIDNumber}';
                SELECT * FROM LOAN_INFORMATION WHERE PAG_IBIG_MID_Number_RTN = '{_pagibigMIDNumber}';
            ";

            DataSet dataSet = _database.ExecuteQuery(query);

            // Personal Information
            if (dataSet.Tables[0].Rows.Count > 0)
            {
                DataRow row = dataSet.Tables[0].Rows[0];
                txtPagibigMIDNumber.Text = row["Pag_IBIG_MID_Number_RTN"].ToString();
                txtFullName.Text = row["Borrower_Name"].ToString();
                txtSex.Text = row["Sex"].ToString();
                txtNationality.Text = row["Borrower_Citizenship"].ToString();
                txtBirthdate.Text = Convert.ToDateTime(row["Birthdate"]).ToString("yyyy-MM-dd");
                txtPresentAddress.Text = row["Present_Address"].ToString();
                txtPermanentAddress.Text = row["Permanent_Address"].ToString();
                txtMaritalStatus.Text = row["Marital_Status"].ToString();
                txtLandline.Text = row["Borrower_Home_Landline"].ToString();
                txtPhoneNumber.Text = row["Borrower_Cellphone"].ToString();
                txtEmailAddress.Text = row["Borrower_Email_Address"].ToString();
                txtOwnership.Text = row["Home_Ownership"].ToString();
                txtYearsofStay.Text = row["Years_of_Stay"].ToString();
            }

            // Employment Information
            if (dataSet.Tables[1].Rows.Count > 0)
            {
                DataRow row = dataSet.Tables[1].Rows[0];
                txtSSS.Text = row["EE_SSS_GSIS_ID_No"].ToString();
                txtBusinessname.Text = row["Employer_Business_Name"].ToString();
                txtBusinessAddress.Text = row["Employer_Business_Address"].ToString();
                txtDirectLine.Text = row["Employer_Direct_Line"].ToString();
                txtTrunkLine.Text = row["Employer_Trunk_Line"].ToString();
                txtEmployerEmailAddress.Text = row["Employer_Email_Address"].ToString();
                txtOccupation.Text = row["Occupation"].ToString();
                txtTin.Text = row["TIN"].ToString();
                txtPosition.Text = row["Position_Department"].ToString();
                txtYearsinBusiness.Text = row["Years_in_Business_Employment"].ToString();
                txtNumberofDependents.Text = row["No_of_Dependents"].ToString();
            }

            // Loan Information
            if (dataSet.Tables[3].Rows.Count > 0)
            {
                DataRow row = dataSet.Tables[3].Rows[0];
                txtLoanAmount.Text = row["Loan_Amount"].ToString();
                txtLoanTerm.Text = row["Loan_Term"].ToString();
                txtModePayment.Text = row["Mode_of_Payment"].ToString();
            }

            // Collateral Information
            if (dataSet.Tables[2].Rows.Count > 0)
            {
                DataRow row = dataSet.Tables[2].Rows[0];
                txtNameofProperty.Text = row["Name_of_Project"].ToString();
                txtDeclarationNumber.Text = row["Tax_Declaration"].ToString();
                txtPropertyLocation.Text = row["Property_Location"].ToString();
                txtTypeofProperty.Text = row["Type_of_Property"].ToString();
                txtUnitNumber.Text = row["Lot_Unit_No"].ToString();
                txtBldgNumber.Text = row["Block_Bldg_No"].ToString();
                txtCCTProperty.Text = row["TCT_OCT_CCT_No"].ToString();
                txtAreaMeasurement.Text = row["Land_Area"].ToString();
            }

            // Bank Information
            if (dataSet.Tables[4].Rows.Count > 0)
            {
                DataRow row = dataSet.Tables[4].Rows[0];
                txtAccountNumber1.Text = row["Account_No"].ToString();
                txtBalance1.Text = row["Ave_Balance"].ToString();
                txtTypeofAccount1.Text = row["Type_of_Account"].ToString();
                dtDateOpened1.Text = Convert.ToDateTime(row["Date_Opened"]).ToString("yyyy-MM-dd");
                txtBank1.Text = row["Bank"].ToString();
                txtBranchAddress1.Text = row["Branch_Address"].ToString();
                txtIssuerName1.Text = row["Issuer_Name"].ToString();
            }

            if (dataSet.Tables[4].Rows.Count > 1)
            {
                DataRow row = dataSet.Tables[4].Rows[1];
                txtAccountNumber2.Text = row["Account_No"].ToString();
                txtBalance2.Text = row["Ave_Balance"].ToString();
                txtTypeofAccount2.Text = row["Type_of_Account"].ToString();
                dtDateOpened2.Text = Convert.ToDateTime(row["Date_Opened"]).ToString("yyyy-MM-dd");
                txtBank2.Text = row["Bank"].ToString();
                txtBranchAddress2.Text = row["Branch_Address"].ToString();
                txtIssuerName2.Text = row["Issuer_Name"].ToString();

            }

            if (dataSet.Tables[4].Rows.Count > 2)
            {
                DataRow row = dataSet.Tables[4].Rows[2];
                txtAccountNumber3.Text = row["Account_No"].ToString();
                txtBalance3.Text = row["Ave_Balance"].ToString();
                txtTypeofAccount3.Text = row["Type_of_Account"].ToString();
                dtDateOpened3.Text = Convert.ToDateTime(row["Date_Opened"]).ToString("yyyy-MM-dd");
                txtBank3.Text = row["Bank"].ToString();
                txtBranchAddress3.Text = row["Branch_Address"].ToString();
                txtIssuerName3.Text = row["Issuer_Name"].ToString();
            }

            // Real Estate Information
            if (dataSet.Tables[5].Rows.Count > 0)
            {
                DataRow row = dataSet.Tables[5].Rows[0];
                txtEstateLocation1.Text = row["Real_Estate_Location"].ToString();
                txtTypeofProperty1.Text = row["Type_of_Property"].ToString();
                txtAcquisitionCost1.Text = row["Acquisition_Cost"].ToString();
                txtMarketValue1.Text = row["Market_Value"].ToString();
                txtMorgageBalance1.Text = row["Mortgage_Balance"].ToString();
                txtRentalIncome1.Text = row["Rental_Income"].ToString();
            }

            if (dataSet.Tables[5].Rows.Count > 1)
            {
                DataRow row = dataSet.Tables[5].Rows[1];
                txtEstateLocation2.Text = row["Real_Estate_Location"].ToString();
                txtTypeofProperty2.Text = row["Type_of_Property"].ToString();
                txtAcquisitionCost2.Text = row["Acquisition_Cost"].ToString();
                txtMarketValue2.Text = row["Market_Value"].ToString();
                txtMorgageBalance2.Text = row["Mortgage_Balance"].ToString();
                txtRentalIncome2.Text = row["Rental_Income"].ToString();
            }

            if (dataSet.Tables[5].Rows.Count > 2)
            {
                DataRow row = dataSet.Tables[5].Rows[2];
                txtEstateLocation3.Text = row["Real_Estate_Location"].ToString();
                txtTypeofProperty3.Text = row["Type_of_Property"].ToString();
                txtAcquisitionCost3.Text = row["Acquisition_Cost"].ToString();
                txtMarketValue3.Text = row["Market_Value"].ToString();
                txtMorgageBalance3.Text = row["Mortgage_Balance"].ToString();
                txtRentalIncome3.Text = row["Rental_Income"].ToString();
            }

            // Other Loan Information
            if (dataSet.Tables[6].Rows.Count > 0)
            {
                DataRow row = dataSet.Tables[6].Rows[0];
                txtTypeofLoan1.Text = row["Type"].ToString();
                txtMaturityDate1.Text = Convert.ToDateTime(row["Maturity_Date"]).ToString("yyyy-MM-dd");
                txtTypeofSecurity1.Text = row["Security"].ToString();
                txtLoanBalance1.Text = row["Amount_Balance"].ToString();
                txtAmortization1.Text = row["Mo_Amortization"].ToString();
            }

            if (dataSet.Tables[6].Rows.Count > 1)
            {
                DataRow row = dataSet.Tables[6].Rows[1];
                txtTypeofLoan2.Text = row["Type"].ToString();
                txtMaturityDate2.Text = Convert.ToDateTime(row["Maturity_Date"]).ToString("yyyy-MM-dd");
                txtTypeofSecurity2.Text = row["Security"].ToString();
                txtLoanBalance2.Text = row["Amount_Balance"].ToString();
                txtAmortization2.Text = row["Mo_Amortization"].ToString();
            }

            if (dataSet.Tables[6].Rows.Count > 2)
            {
                DataRow row = dataSet.Tables[6].Rows[2];
                txtTypeofLoan3.Text = row["Type"].ToString();
                txtMaturityDate3.Text = Convert.ToDateTime(row["Maturity_Date"]).ToString("yyyy-MM-dd");
                txtTypeofSecurity3.Text = row["Security"].ToString();
                txtLoanBalance3.Text = row["Amount_Balance"].ToString();
                txtAmortization3.Text = row["Mo_Amortization"].ToString();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPersonalInfo_Click(object sender, EventArgs e)
        {
            StringBuilder csvContent = new StringBuilder();

            // Add headers
            csvContent.AppendLine("Category,Field,Value");

            // Personal Information
            csvContent.AppendLine("Personal Information,Pag-IBIG MID Number," + txtPagibigMIDNumber.Text);
            csvContent.AppendLine("Personal Information,Full Name," + txtFullName.Text);
            csvContent.AppendLine("Personal Information,Sex," + txtSex.Text);
            csvContent.AppendLine("Personal Information,Nationality," + txtNationality.Text);
            csvContent.AppendLine("Personal Information,Birthdate," + txtBirthdate.Text);
            csvContent.AppendLine("Personal Information,Present Address," + txtPresentAddress.Text);
            csvContent.AppendLine("Personal Information,Permanent Address," + txtPermanentAddress.Text);
            csvContent.AppendLine("Personal Information,Marital Status," + txtMaritalStatus.Text);
            csvContent.AppendLine("Personal Information,Landline," + txtLandline.Text);
            csvContent.AppendLine("Personal Information,Phone Number," + txtPhoneNumber.Text);
            csvContent.AppendLine("Personal Information,Email Address," + txtEmailAddress.Text);
            csvContent.AppendLine("Personal Information,Ownership," + txtOwnership.Text);
            csvContent.AppendLine("Personal Information,Years of Stay," + txtYearsofStay.Text);

            // Employment Information
            csvContent.AppendLine("Employment Information,SSS," + txtSSS.Text);
            csvContent.AppendLine("Employment Information,Business Name," + txtBusinessname.Text);
            csvContent.AppendLine("Employment Information,Business Address," + txtBusinessAddress.Text);
            csvContent.AppendLine("Employment Information,Direct Line," + txtDirectLine.Text);
            csvContent.AppendLine("Employment Information,Trunk Line," + txtTrunkLine.Text);
            csvContent.AppendLine("Employment Information,Employer Email Address," + txtEmployerEmailAddress.Text);
            csvContent.AppendLine("Employment Information,Occupation," + txtOccupation.Text);
            csvContent.AppendLine("Employment Information,TIN," + txtTin.Text);
            csvContent.AppendLine("Employment Information,Position," + txtPosition.Text);
            csvContent.AppendLine("Employment Information,Years in Business," + txtYearsinBusiness.Text);
            csvContent.AppendLine("Employment Information,Number of Dependents," + txtNumberofDependents.Text);

            // Loan Information
            csvContent.AppendLine("Loan Information,Loan Amount," + txtLoanAmount.Text);
            csvContent.AppendLine("Loan Information,Loan Term," + txtLoanTerm.Text);
            csvContent.AppendLine("Loan Information,Mode of Payment," + txtModePayment.Text);

            // Collateral Information
            csvContent.AppendLine("Collateral Information,Name of Property," + txtNameofProperty.Text);
            csvContent.AppendLine("Collateral Information,Declaration Number," + txtDeclarationNumber.Text);
            csvContent.AppendLine("Collateral Information,Property Location," + txtPropertyLocation.Text);
            csvContent.AppendLine("Collateral Information,Type of Property," + txtTypeofProperty.Text);
            csvContent.AppendLine("Collateral Information,Unit Number," + txtUnitNumber.Text);
            csvContent.AppendLine("Collateral Information,Building Number," + txtBldgNumber.Text);
            csvContent.AppendLine("Collateral Information,CCT Property," + txtCCTProperty.Text);
            csvContent.AppendLine("Collateral Information,Area Measurement," + txtAreaMeasurement.Text);

            // Bank Information
            csvContent.AppendLine("Bank Information,Account Number 1," + txtAccountNumber1.Text);
            csvContent.AppendLine("Bank Information,Balance 1," + txtBalance1.Text);
            csvContent.AppendLine("Bank Information,Type of Account 1," + txtTypeofAccount1.Text);
            csvContent.AppendLine("Bank Information,Date Opened 1," + dtDateOpened1.Text);
            csvContent.AppendLine("Bank Information,Bank 1," + txtBank1.Text);
            csvContent.AppendLine("Bank Information,Branch Address 1," + txtBranchAddress1.Text);
            csvContent.AppendLine("Bank Information,Issuer Name 1," + txtIssuerName1.Text);

            csvContent.AppendLine("Bank Information,Account Number 2," + txtAccountNumber2.Text);
            csvContent.AppendLine("Bank Information,Balance 2," + txtBalance2.Text);
            csvContent.AppendLine("Bank Information,Type of Account 2," + txtTypeofAccount2.Text);
            csvContent.AppendLine("Bank Information,Date Opened 2," + dtDateOpened2.Text);
            csvContent.AppendLine("Bank Information,Bank 2," + txtBank2.Text);
            csvContent.AppendLine("Bank Information,Branch Address 2," + txtBranchAddress2.Text);
            csvContent.AppendLine("Bank Information,Issuer Name 2," + txtIssuerName2.Text);

            csvContent.AppendLine("Bank Information,Account Number 3," + txtAccountNumber3.Text);
            csvContent.AppendLine("Bank Information,Balance 3," + txtBalance3.Text);
            csvContent.AppendLine("Bank Information,Type of Account 3," + txtTypeofAccount3.Text);
            csvContent.AppendLine("Bank Information,Date Opened 3," + dtDateOpened3.Text);
            csvContent.AppendLine("Bank Information,Bank 3," + txtBank3.Text);
            csvContent.AppendLine("Bank Information,Branch Address 3," + txtBranchAddress3.Text);
            csvContent.AppendLine("Bank Information,Issuer Name 3," + txtIssuerName3.Text);

            // Real Estate Information
            csvContent.AppendLine("Real Estate Information,Estate Location 1," + txtEstateLocation1.Text);
            csvContent.AppendLine("Real Estate Information,Type of Property 1," + txtTypeofProperty1.Text);
            csvContent.AppendLine("Real Estate Information,Acquisition Cost 1," + txtAcquisitionCost1.Text);
            csvContent.AppendLine("Real Estate Information,Market Value 1," + txtMarketValue1.Text);
            csvContent.AppendLine("Real Estate Information,Mortgage Balance 1," + txtMorgageBalance1.Text);
            csvContent.AppendLine("Real Estate Information,Rental Income 1," + txtRentalIncome1.Text);

            csvContent.AppendLine("Real Estate Information,Estate Location 2," + txtEstateLocation2.Text);
            csvContent.AppendLine("Real Estate Information,Type of Property 2," + txtTypeofProperty2.Text);
            csvContent.AppendLine("Real Estate Information,Acquisition Cost 2," + txtAcquisitionCost2.Text);
            csvContent.AppendLine("Real Estate Information,Market Value 2," + txtMarketValue2.Text);
            csvContent.AppendLine("Real Estate Information,Mortgage Balance 2," + txtMorgageBalance2.Text);
            csvContent.AppendLine("Real Estate Information,Rental Income 2," + txtRentalIncome2.Text);

            csvContent.AppendLine("Real Estate Information,Estate Location 3," + txtEstateLocation3.Text);
            csvContent.AppendLine("Real Estate Information,Type of Property 3," + txtTypeofProperty3.Text);
            csvContent.AppendLine("Real Estate Information,Acquisition Cost 3," + txtAcquisitionCost3.Text);
            csvContent.AppendLine("Real Estate Information,Market Value 3," + txtMarketValue3.Text);
            csvContent.AppendLine("Real Estate Information,Mortgage Balance 3," + txtMorgageBalance3.Text);
            csvContent.AppendLine("Real Estate Information,Rental Income 3," + txtRentalIncome3.Text);

            // Other Loan Information
            csvContent.AppendLine("Other Loan Information,Type of Loan 1," + txtTypeofLoan1.Text);
            csvContent.AppendLine("Other Loan Information,Maturity Date 1," + txtMaturityDate1.Text);
            csvContent.AppendLine("Other Loan Information,Type of Security 1," + txtTypeofSecurity1.Text);
            csvContent.AppendLine("Other Loan Information,Loan Balance 1," + txtLoanBalance1.Text);
            csvContent.AppendLine("Other Loan Information,Amortization 1," + txtAmortization1.Text);

            csvContent.AppendLine("Other Loan Information,Type of Loan 2," + txtTypeofLoan2.Text);
            csvContent.AppendLine("Other Loan Information,Maturity Date 2," + txtMaturityDate2.Text);
            csvContent.AppendLine("Other Loan Information,Type of Security 2," + txtTypeofSecurity2.Text);
            csvContent.AppendLine("Other Loan Information,Loan Balance 2," + txtLoanBalance2.Text);
            csvContent.AppendLine("Other Loan Information,Amortization 2," + txtAmortization2.Text);

            csvContent.AppendLine("Other Loan Information,Type of Loan 3," + txtTypeofLoan3.Text);
            csvContent.AppendLine("Other Loan Information,Maturity Date 3," + txtMaturityDate3.Text);
            csvContent.AppendLine("Other Loan Information,Type of Security 3," + txtTypeofSecurity3.Text);
            csvContent.AppendLine("Other Loan Information,Loan Balance 3," + txtLoanBalance3.Text);
            csvContent.AppendLine("Other Loan Information,Amortization 3," + txtAmortization3.Text);

            // Use SaveFileDialog to allow user to choose file location
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
            saveFileDialog.Title = "Save information as CSV file";
            saveFileDialog.FileName = "BorrowerInformation.csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, csvContent.ToString());
                MessageBox.Show("Information successfully exported to CSV file.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
