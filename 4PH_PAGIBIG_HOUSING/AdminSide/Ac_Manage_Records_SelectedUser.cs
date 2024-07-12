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
    public partial class Ac_Manage_Records_SelectedUser : Form
    {
        private readonly string _pagibigMIDnumber;
        public Ac_Manage_Records_SelectedUser(string pagibigMIDnumber)
        {
            InitializeComponent();
            _pagibigMIDnumber = pagibigMIDnumber;
        }

        private void Ac_Manage_Records_SelectedUser_Load(object sender, EventArgs e)
        {
            // Set the height of each row
            dgPersonalInfo.RowTemplate.Height = 30; // Adjust the height as needed
            dgLoanInfo.RowTemplate.Height = 30;
            dgCollateral.RowTemplate.Height = 30;
            dgEmployment.RowTemplate.Height = 30;
            dgRealEstate.RowTemplate.Height = 30;
            dgBankInformation.RowTemplate.Height = 30;
            dgOtherLoanInformation.RowTemplate.Height = 30;


            // Customize DataGridViews with specific sizes
            dgPersonalInfo.Size = new Size(1200, 89);
            dgLoanInfo.Size = new Size(1200, 89);
            dgCollateral.Size = new Size(1200, 97);
            dgEmployment.Size = new Size(1200, 107);
            dgRealEstate.Size = new Size(1200, 373);
            dgBankInformation.Size = new Size(1200, 373);
            dgOtherLoanInformation.Size = new Size(1200, 373);

            txtMRID.Text = _pagibigMIDnumber;

            LoadPersonalInfo();
            LoadLoanInfo();
            LoadCollateralInfo();
            LoadEmploymentInfo();
            LoadRealEstateInfo();
            LoadBankInformation();
            LoadOtherLoanInformation();

            // Customize DataGridViews
            CustomizeDataGridView(dgPersonalInfo);
            CustomizeDataGridView(dgLoanInfo);
            CustomizeDataGridView(dgCollateral);
            CustomizeDataGridView(dgEmployment);
            CustomizeDataGridView(dgRealEstate);
            CustomizeDataGridView(dgBankInformation);
            CustomizeDataGridView(dgOtherLoanInformation);
        }

        private void btnBackToDashboard_Click(object sender, EventArgs e)
        {
            Administration_Dashboard dashboard = new Administration_Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void LoadPersonalInfo()
        {
            string query = $"SELECT * FROM BORROWER_INFORMATION WHERE Pag_IBIG_MID_Number_RTN = '{_pagibigMIDnumber}'";
            DataSet ds = DatabaseConnection.Instance.ExecuteQuery(query);
            dgPersonalInfo.DataSource = ds.Tables[0];
        }

        private void LoadLoanInfo()
        {
            string query = $"SELECT * FROM 4PS_HOUSING_LOAN_INFORMATION WHERE PAG_IBIG_MID_Number_RTN = '{_pagibigMIDnumber}'";
            DataSet ds = DatabaseConnection.Instance.ExecuteQuery(query);
            dgLoanInfo.DataSource = ds.Tables[0];
        }

        private void LoadCollateralInfo()
        {
            string query = $"SELECT * FROM COLLATERAL_INFORMATION WHERE Pag_IBIG_MID_Number_RTN = '{_pagibigMIDnumber}'";
            DataSet ds = DatabaseConnection.Instance.ExecuteQuery(query);
            dgCollateral.DataSource = ds.Tables[0];
        }

        private void LoadEmploymentInfo()
        {
            string query = $"SELECT * FROM BORROWERS_EMPLOYMENT_INFORMATION WHERE EE_SSS_GSIS_ID_No IN (SELECT EE_SSS_GSIS_ID_No FROM BORROWER_INFORMATION WHERE Pag_IBIG_MID_Number_RTN = '{_pagibigMIDnumber}')";
            DataSet ds = DatabaseConnection.Instance.ExecuteQuery(query);
            dgEmployment.DataSource = ds.Tables[0];
        }

        private void LoadRealEstateInfo()
        {
            string query = $"SELECT * FROM REAL_ESTATE_INFORMATION WHERE PAG_IBIG_MID_Number_RTN = '{_pagibigMIDnumber}'";
            DataSet ds = DatabaseConnection.Instance.ExecuteQuery(query);
            dgRealEstate.DataSource = ds.Tables[0];
        }

        private void LoadBankInformation()
        {
            string query = $"SELECT * FROM BANKING_INFORMATION WHERE PAG_IBIG_MID_Number_RTN = '{_pagibigMIDnumber}'";
            DataSet ds = DatabaseConnection.Instance.ExecuteQuery(query);
            dgBankInformation.DataSource = ds.Tables[0];
        }

        private void LoadOtherLoanInformation()
        {
            string query = $"SELECT * FROM LOAN_INFORMATION WHERE PAG_IBIG_MID_Number_RTN = '{_pagibigMIDnumber}'";
            DataSet ds = DatabaseConnection.Instance.ExecuteQuery(query);
            dgOtherLoanInformation.DataSource = ds.Tables[0];
        }

        private void CustomizeDataGridView(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // or another option if needed
            dgv.BorderStyle = BorderStyle.None;
            dgv.BackgroundColor = Color.White;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToOrderColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 11);
            dgv.ScrollBars = ScrollBars.Both;

            // Set header style
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
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

        private void btnUpdatePersonal_Click(object sender, EventArgs e)
        {
            if (dgPersonalInfo.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgPersonalInfo.SelectedRows[0];

                string? pagIbigMIDNumber = selectedRow.Cells["Pag_IBIG_MID_Number_RTN"].Value?.ToString();
                string borrowerName = selectedRow.Cells["Borrower_Name"].Value?.ToString() ?? string.Empty;
                string borrowerCitizenship = selectedRow.Cells["Borrower_Citizenship"].Value?.ToString() ?? string.Empty;
                DateTime birthdate = selectedRow.Cells["Birthdate"].Value != null ? Convert.ToDateTime(selectedRow.Cells["Birthdate"].Value) : DateTime.Now;
                string sex = selectedRow.Cells["Sex"].Value?.ToString() ?? "M"; // Default to 'M' if null
                string permanentAddress = selectedRow.Cells["Permanent_Address"].Value?.ToString() ?? string.Empty;
                string presentAddress = selectedRow.Cells["Present_Address"].Value?.ToString() ?? string.Empty;
                string maritalStatus = selectedRow.Cells["Marital_Status"].Value?.ToString() ?? string.Empty;
                string homeLandline = selectedRow.Cells["Borrower_Home_Landline"].Value?.ToString() ?? string.Empty;
                string cellphone = selectedRow.Cells["Borrower_Cellphone"].Value?.ToString() ?? string.Empty;
                string emailAddress = selectedRow.Cells["Borrower_Email_Address"].Value?.ToString() ?? string.Empty;
                string homeOwnership = selectedRow.Cells["Home_Ownership"].Value?.ToString() ?? string.Empty;
                int yearsOfStay = selectedRow.Cells["Years_of_Stay"].Value != null ? Convert.ToInt32(selectedRow.Cells["Years_of_Stay"].Value) : 0;
                long eessIDNo = selectedRow.Cells["EE_SSS_GSIS_ID_No"].Value != null ? Convert.ToInt64(selectedRow.Cells["EE_SSS_GSIS_ID_No"].Value) : 0;

                // Construct the update query
                string query = $@"
            UPDATE BORROWER_INFORMATION 
            SET 
                Borrower_Name = '{borrowerName}',
                Borrower_Citizenship = '{borrowerCitizenship}',
                Birthdate = '{birthdate.ToString("yyyy-MM-dd")}',
                Sex = '{sex}',
                Permanent_Address = '{permanentAddress}',
                Present_Address = '{presentAddress}',
                Marital_Status = '{maritalStatus}',
                Borrower_Home_Landline = '{homeLandline}',
                Borrower_Cellphone = '{cellphone}',
                Borrower_Email_Address = '{emailAddress}',
                Home_Ownership = '{homeOwnership}',
                Years_of_Stay = {yearsOfStay},
                EE_SSS_GSIS_ID_No = {eessIDNo}
            WHERE Pag_IBIG_MID_Number_RTN = '{pagIbigMIDNumber}'";

                // Execute the update
                if (DatabaseConnection.Instance.ExecuteNonQuery(query))
                {
                    MessageBox.Show("Record updated successfully.");
                    LoadPersonalInfo(); // Refresh the DataGridView
                }
                else
                {
                    MessageBox.Show("Failed to update the record.");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void btnUpdateLoan_Click(object sender, EventArgs e)
        {
            if (dgLoanInfo.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgLoanInfo.SelectedRows[0];

                string? pagIbigMIDNumber = selectedRow.Cells["PAG_IBIG_MID_Number_RTN"].Value?.ToString();
                string? tctOctCctNo = selectedRow.Cells["TCT_OCT_CCT_No"].Value?.ToString();
                decimal loanAmount = selectedRow.Cells["Loan_Amount"].Value != null ? Convert.ToDecimal(selectedRow.Cells["Loan_Amount"].Value) : 0;
                string loanTerm = selectedRow.Cells["Loan_Term"].Value?.ToString() ?? string.Empty;
                string modeOfPayment = selectedRow.Cells["Mode_of_Payment"].Value?.ToString() ?? string.Empty;

                // Construct the update query
                string query = $@"
            UPDATE 4PS_HOUSING_LOAN_INFORMATION
            SET 
                Loan_Amount = {loanAmount},
                Loan_Term = '{loanTerm}',
                Mode_of_Payment = '{modeOfPayment}'
            WHERE 
                PAG_IBIG_MID_Number_RTN = '{pagIbigMIDNumber}' 
                AND TCT_OCT_CCT_No = '{tctOctCctNo}'";

                // Execute the update
                if (DatabaseConnection.Instance.ExecuteNonQuery(query))
                {
                    MessageBox.Show("Loan record updated successfully.");
                    LoadLoanInfo(); // Refresh the DataGridView
                }
                else
                {
                    MessageBox.Show("Failed to update the loan record.");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void btnDeleteLoan_Click(object sender, EventArgs e)
        {
            if (dgLoanInfo.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgLoanInfo.SelectedRows[0];

                string? pagIbigMIDNumber = selectedRow.Cells["PAG_IBIG_MID_Number_RTN"].Value?.ToString();
                string? tctOctCctNo = selectedRow.Cells["TCT_OCT_CCT_No"].Value?.ToString();

                // Construct the delete query
                string query = $@"
            DELETE FROM 4PS_HOUSING_LOAN_INFORMATION
            WHERE 
                PAG_IBIG_MID_Number_RTN = '{pagIbigMIDNumber}' 
                AND TCT_OCT_CCT_No = '{tctOctCctNo}'";

                // Execute the delete
                if (DatabaseConnection.Instance.ExecuteNonQuery(query))
                {
                    MessageBox.Show("Loan record deleted successfully.");
                    LoadLoanInfo(); // Refresh the DataGridView
                }
                else
                {
                    MessageBox.Show("Failed to delete the loan record.");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void btnUpdateCollateral_Click(object sender, EventArgs e)
        {
            if (dgCollateral.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgCollateral.SelectedRows[0];

                string? pagIbigMIDNumber = selectedRow.Cells["Pag_IBIG_MID_Number_RTN"].Value?.ToString();
                int collateralId = Convert.ToInt32(selectedRow.Cells["Collateral_ID"].Value);
                string? tctOctCctNo = selectedRow.Cells["TCT_OCT_CCT_No"].Value?.ToString();
                string propertyLocation = selectedRow.Cells["Property_Location"].Value?.ToString() ?? string.Empty;
                string typeOfProperty = selectedRow.Cells["Type_of_Property"].Value?.ToString() ?? string.Empty;
                string nameOfProject = selectedRow.Cells["Name_of_Project"].Value?.ToString() ?? string.Empty;
                decimal landArea = Convert.ToDecimal(selectedRow.Cells["Land_Area"].Value);

                // Construct the update query
                string query = $@"
            UPDATE COLLATERAL_INFORMATION
            SET 
                TCT_OCT_CCT_No = '{tctOctCctNo}',
                Property_Location = '{propertyLocation}',
                Type_of_Property = '{typeOfProperty}',
                Name_of_Project = '{nameOfProject}',
                Land_Area = {landArea}
            WHERE 
                Collateral_ID = {collateralId} 
                AND Pag_IBIG_MID_Number_RTN = '{pagIbigMIDNumber}'";

                // Execute the update
                if (DatabaseConnection.Instance.ExecuteNonQuery(query))
                {
                    MessageBox.Show("Collateral record updated successfully.");
                    LoadCollateralInfo(); // Refresh the DataGridView
                }
                else
                {
                    MessageBox.Show("Failed to update the collateral record.");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void btnDeleteCollateral_Click(object sender, EventArgs e)
        {
            if (dgCollateral.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgCollateral.SelectedRows[0];
                string? collateralId = selectedRow.Cells["Collateral_ID"].Value?.ToString();
                string? pagIbigMIDNumber = selectedRow.Cells["Pag_IBIG_MID_Number_RTN"]?.Value.ToString();

                try
                {
                    // Delete related records from other tables
                    string deleteQuery = $@"
            DELETE FROM LOAN_INFORMATION WHERE PAG_IBIG_MID_Number_RTN = '{pagIbigMIDNumber}';
            DELETE FROM COLLATERAL_INFORMATION WHERE Collateral_ID = {collateralId}";

                    DatabaseConnection.Instance.ExecuteNonQuery(deleteQuery);

                    MessageBox.Show("Collateral record and related records deleted successfully.");
                    LoadCollateralInfo();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void btnUpdateEmployment_Click(object sender, EventArgs e)
        {
            if (dgEmployment.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgEmployment.SelectedRows[0];

                int eeSssGsisIdNo = Convert.ToInt32(selectedRow.Cells["EE_SSS_GSIS_ID_No"].Value);
                string? employerBusinessName = selectedRow.Cells["Employer_Business_Name"].Value?.ToString();
                string? employerBusinessAddress = selectedRow.Cells["Employer_Business_Address"].Value?.ToString();
                string? employerDirectLine = selectedRow.Cells["Employer_Direct_Line"].Value?.ToString();
                string? occupation = selectedRow.Cells["Occupation"].Value?.ToString();
                int yearsInBusinessEmployment = Convert.ToInt32(selectedRow.Cells["Years_in_Business_Employment"].Value);
                int noOfDependents = Convert.ToInt32(selectedRow.Cells["No_of_Dependents"].Value);

                // Construct the update query
                string query = $@"
            UPDATE BORROWERS_EMPLOYMENT_INFORMATION
            SET 
                Employer_Business_Name = '{employerBusinessName}',
                Employer_Business_Address = '{employerBusinessAddress}',
                Employer_Direct_Line = '{employerDirectLine}',
                Occupation = '{occupation}',
                Years_in_Business_Employment = {yearsInBusinessEmployment},
                No_of_Dependents = {noOfDependents}
            WHERE 
                EE_SSS_GSIS_ID_No = {eeSssGsisIdNo}";

                // Execute the update
                if (DatabaseConnection.Instance.ExecuteNonQuery(query))
                {
                    MessageBox.Show("Employment record updated successfully.");
                    LoadEmploymentInfo(); // Refresh the DataGridView
                }
                else
                {
                    MessageBox.Show("Failed to update the employment record.");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void btnDeleteEmployment_Click(object sender, EventArgs e)
        {
            if (dgEmployment.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgEmployment.SelectedRows[0];

                int eeSssGsisIdNo = Convert.ToInt32(selectedRow.Cells["EE_SSS_GSIS_ID_No"].Value);

                // Construct the delete query
                string query = $@"
            DELETE FROM BORROWERS_EMPLOYMENT_INFORMATION
            WHERE 
                EE_SSS_GSIS_ID_No = {eeSssGsisIdNo}";

                // Execute the delete
                if (DatabaseConnection.Instance.ExecuteNonQuery(query))
                {
                    MessageBox.Show("Employment record deleted successfully.");
                    LoadEmploymentInfo(); // Refresh the DataGridView
                }
                else
                {
                    MessageBox.Show("Failed to delete the employment record.");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void btnUpdateRealEstate_Click(object sender, EventArgs e)
        {
            if (dgRealEstate.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgRealEstate.SelectedRows[0];

                int realEstateKey = Convert.ToInt32(selectedRow.Cells["Real_Estate_Key"].Value);
                string? pagIbigMIDNumber = selectedRow.Cells["PAG_IBIG_MID_Number_RTN"].Value?.ToString();
                string? realEstateLocation = selectedRow.Cells["Real_Estate_Location"].Value?.ToString();
                string? typeOfProperty = selectedRow.Cells["Type_of_Property"].Value?.ToString();
                decimal acquisitionCost = Convert.ToDecimal(selectedRow.Cells["Acquisition_Cost"].Value);
                decimal marketValue = Convert.ToDecimal(selectedRow.Cells["Market_Value"].Value);
                decimal mortgageBalance = Convert.ToDecimal(selectedRow.Cells["Mortgage_Balance"].Value);
                decimal rentalIncome = Convert.ToDecimal(selectedRow.Cells["Rental_Income"].Value);

                // Construct the update query
                string query = $@"
            UPDATE REAL_ESTATE_INFORMATION
            SET 
                Real_Estate_Location = '{realEstateLocation}',
                Type_of_Property = '{typeOfProperty}',
                Acquisition_Cost = {acquisitionCost},
                Market_Value = {marketValue},
                Mortgage_Balance = {mortgageBalance},
                Rental_Income = {rentalIncome}
            WHERE 
                Real_Estate_Key = {realEstateKey} 
                AND PAG_IBIG_MID_Number_RTN = '{pagIbigMIDNumber}'";

                // Execute the update
                if (DatabaseConnection.Instance.ExecuteNonQuery(query))
                {
                    MessageBox.Show("Real estate record updated successfully.");
                    LoadRealEstateInfo(); // Refresh the DataGridView
                }
                else
                {
                    MessageBox.Show("Failed to update the real estate record.");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void btnDeleteRealEstate_Click(object sender, EventArgs e)
        {
            if (dgRealEstate.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgRealEstate.SelectedRows[0];
                string? realEstateKey = selectedRow.Cells["Real_Estate_Key"].Value.ToString();
                string? pagIbigMIDNumber = selectedRow.Cells["PAG_IBIG_MID_Number_RTN"].Value.ToString();

                try
                {
                    // Delete related records from other tables
                    string deleteQuery = $@"
            DELETE FROM REAL_ESTATE_INFORMATION WHERE Real_Estate_Key = {realEstateKey}";

                    DatabaseConnection.Instance.ExecuteNonQuery(deleteQuery);

                    MessageBox.Show("Real estate record deleted successfully.");
                    LoadRealEstateInfo();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void btnUpdateBank_Click(object sender, EventArgs e)
        {
            if (dgBankInformation.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgBankInformation.SelectedRows[0];

                int bankId = Convert.ToInt32(selectedRow.Cells["Bank_ID"].Value);
                string? pagIbigMIDNumber = selectedRow.Cells["PAG_IBIG_MID_Number_RTN"].Value?.ToString();
                string? accountNo = selectedRow.Cells["Account_No"].Value?.ToString();
                string? bank = selectedRow.Cells["Bank"].Value?.ToString();
                string? branchAddress = selectedRow.Cells["Branch_Address"].Value?.ToString();
                string? typeOfAccount = selectedRow.Cells["Type_of_Account"].Value?.ToString();
                DateTime dateOpened = Convert.ToDateTime(selectedRow.Cells["Date_Opened"].Value);
                decimal aveBalance = Convert.ToDecimal(selectedRow.Cells["Ave_Balance"].Value);
                string? issuerName = selectedRow.Cells["Issuer_Name"].Value?.ToString();

                // Construct the update query
                string query = $@"
            UPDATE BANKING_INFORMATION
            SET 
                Account_No = '{accountNo}',
                Bank = '{bank}',
                Branch_Address = '{branchAddress}',
                Type_of_Account = '{typeOfAccount}',
                Date_Opened = '{dateOpened.ToString("yyyy-MM-dd")}',
                Ave_Balance = {aveBalance},
                Issuer_Name = '{issuerName}'
            WHERE 
                Bank_ID = {bankId} 
                AND PAG_IBIG_MID_Number_RTN = '{pagIbigMIDNumber}'";

                // Execute the update
                if (DatabaseConnection.Instance.ExecuteNonQuery(query))
                {
                    MessageBox.Show("Bank information updated successfully.");
                    LoadBankInformation(); // Refresh the DataGridView
                }
                else
                {
                    MessageBox.Show("Failed to update the bank information.");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void btnDeleteBankInformation_Click(object sender, EventArgs e)
        {
            if (dgBankInformation.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgBankInformation.SelectedRows[0];
                int bankId = Convert.ToInt32(selectedRow.Cells["Bank_ID"].Value);

                try
                {
                    string deleteQuery = $@"
            DELETE FROM BANKING_INFORMATION WHERE Bank_ID = {bankId}";

                    DatabaseConnection.Instance.ExecuteNonQuery(deleteQuery);

                    MessageBox.Show("Bank information deleted successfully.");
                    LoadBankInformation();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void btnUpdateOtherLoan_Click(object sender, EventArgs e)
        {
            if (dgOtherLoanInformation.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgOtherLoanInformation.SelectedRows[0];

                int loanAvailmentKey = Convert.ToInt32(selectedRow.Cells["Loan_Availment_Key"].Value);
                string? pagIbigMIDNumber = selectedRow.Cells["PAG_IBIG_MID_Number_RTN"].Value?.ToString();
                string? loanType = selectedRow.Cells["Type"].Value?.ToString();
                string? security = selectedRow.Cells["Security"].Value?.ToString();
                DateTime maturityDate = Convert.ToDateTime(selectedRow.Cells["Maturity_Date"].Value);
                decimal amountBalance = Convert.ToDecimal(selectedRow.Cells["Amount_Balance"].Value);
                string? moAmortization = selectedRow.Cells["Mo_Amortization"].Value?.ToString();

                // Construct the update query
                string query = $@"
            UPDATE LOAN_INFORMATION
            SET 
                Type = '{loanType}',
                Security = '{security}',
                Maturity_Date = '{maturityDate.ToString("yyyy-MM-dd")}',
                Amount_Balance = {amountBalance},
                Mo_Amortization = '{moAmortization}'
            WHERE 
                Loan_Availment_Key = {loanAvailmentKey} 
                AND PAG_IBIG_MID_Number_RTN = '{pagIbigMIDNumber}'";

                // Execute the update
                if (DatabaseConnection.Instance.ExecuteNonQuery(query))
                {
                    MessageBox.Show("Other loan information updated successfully.");
                    LoadOtherLoanInformation(); // Refresh the DataGridView
                }
                else
                {
                    MessageBox.Show("Failed to update the other loan information.");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void btnDeleteOtherLoan_Click(object sender, EventArgs e)
        {
            if (dgOtherLoanInformation.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgOtherLoanInformation.SelectedRows[0];
                int loanAvailmentKey = Convert.ToInt32(selectedRow.Cells["Loan_Availment_Key"].Value);

                try
                {
                    string deleteQuery = $@"
            DELETE FROM LOAN_INFORMATION WHERE Loan_Availment_Key = {loanAvailmentKey}";

                    DatabaseConnection.Instance.ExecuteNonQuery(deleteQuery);

                    MessageBox.Show("Other loan information deleted successfully.");
                    LoadOtherLoanInformation();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void btnDeleteEntirely_Click(object sender, EventArgs e)
        {
            // Confirm the deletion with the user
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete all information for this Pag-IBIG MID Number? This action cannot be undone.",
                "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                string pagIbigMIDNumber = _pagibigMIDnumber;

                // Construct the delete queries for each table
                string deleteBorrowerInfo = $"DELETE FROM BORROWER_INFORMATION WHERE Pag_IBIG_MID_Number_RTN = '{pagIbigMIDNumber}'";
                string deleteEmploymentInfo = $"DELETE FROM BORROWERS_EMPLOYMENT_INFORMATION WHERE EE_SSS_GSIS_ID_No IN (SELECT EE_SSS_GSIS_ID_No FROM BORROWER_INFORMATION WHERE Pag_IBIG_MID_Number_RTN = '{pagIbigMIDNumber}')";
                string deleteCollateralInfo = $"DELETE FROM COLLATERAL_INFORMATION WHERE Pag_IBIG_MID_Number_RTN = '{pagIbigMIDNumber}'";
                string deleteLoanInfo = $"DELETE FROM 4PS_HOUSING_LOAN_INFORMATION WHERE PAG_IBIG_MID_Number_RTN = '{pagIbigMIDNumber}'";
                string deleteBankInfo = $"DELETE FROM BANKING_INFORMATION WHERE PAG_IBIG_MID_Number_RTN = '{pagIbigMIDNumber}'";
                string deleteRealEstateInfo = $"DELETE FROM REAL_ESTATE_INFORMATION WHERE PAG_IBIG_MID_Number_RTN = '{pagIbigMIDNumber}'";
                string deleteOtherLoanInfo = $"DELETE FROM LOAN_INFORMATION WHERE PAG_IBIG_MID_Number_RTN = '{pagIbigMIDNumber}'";

                // Execute delete queries
                try
                {
                    DatabaseConnection.Instance.ExecuteNonQuery(deleteEmploymentInfo);
                    DatabaseConnection.Instance.ExecuteNonQuery(deleteCollateralInfo);
                    DatabaseConnection.Instance.ExecuteNonQuery(deleteLoanInfo);
                    DatabaseConnection.Instance.ExecuteNonQuery(deleteBankInfo);
                    DatabaseConnection.Instance.ExecuteNonQuery(deleteRealEstateInfo);
                    DatabaseConnection.Instance.ExecuteNonQuery(deleteOtherLoanInfo);
                    DatabaseConnection.Instance.ExecuteNonQuery(deleteBorrowerInfo);

                    MessageBox.Show("All information related to the Pag-IBIG MID Number has been deleted successfully.");
                    // Optionally, refresh or close the form
                    Administration_Dashboard dashboard = new Administration_Dashboard();
                    dashboard.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting information: " + ex.Message);
                }
            }
        }
    }
}
