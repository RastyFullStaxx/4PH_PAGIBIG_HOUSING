using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;
using _4PH_PAGIBIG_HOUSING.Database;
using MySql.Data.MySqlClient;

namespace _4PH_PAGIBIG_HOUSING
{
    public partial class Ac_Manage_Record_NoSelectedUser : Form
    {
        public Ac_Manage_Record_NoSelectedUser()
        {
            InitializeComponent();
        }

        private void btnBackToDashboard_Click(object sender, EventArgs e)
        {
            Administration_Dashboard administration_Dashboard = new Administration_Dashboard();
            administration_Dashboard.Show();
            this.Close();
        }

        private void Ac_Manage_Record_NoSelectedUser_Load(object sender, EventArgs e)
        {
            LoadPersonalInfo();
            LoadLoanInfo();
            LoadCollateralInfo();
            LoadEmploymentInfo();
            LoadRealEstateInfo();
            LoadBankInformation();
            LoadOtherLoanInformation();
        }

        private void LoadPersonalInfo()
        {
            string query = "SELECT * FROM BORROWER_INFORMATION";
            DataSet ds = DatabaseConnection.Instance.ExecuteQuery(query);
            dgPersonalInfo.DataSource = ds.Tables[0];
            dgPersonalInfo.ClearSelection(); // Clear any selected rows
            CustomizeDataGridView(dgPersonalInfo);
            LoadLoanInfo();
            LoadCollateralInfo();
            LoadEmploymentInfo();
            LoadRealEstateInfo();
            LoadBankInformation();
            LoadOtherLoanInformation();
        }

        private void LoadLoanInfo()
        {
            string query = "SELECT * FROM 4PS_HOUSING_LOAN_INFORMATION";
            DataSet ds = DatabaseConnection.Instance.ExecuteQuery(query);
            dgLoanInfo.DataSource = ds.Tables[0];
            dgLoanInfo.ClearSelection(); // Clear any selected rows

            CustomizeDataGridView(dgLoanInfo);
        }

        private void LoadCollateralInfo()
        {
            string query = "SELECT * FROM COLLATERAL_INFORMATION";
            DataSet ds = DatabaseConnection.Instance.ExecuteQuery(query);
            dgCollateral.DataSource = ds.Tables[0];
            dgCollateral.ClearSelection(); // Clear any selected rows
            CustomizeDataGridView(dgCollateral);
        }

        private void LoadEmploymentInfo()
        {
            string query = "SELECT * FROM BORROWERS_EMPLOYMENT_INFORMATION";
            DataSet ds = DatabaseConnection.Instance.ExecuteQuery(query);
            dgEmployment.DataSource = ds.Tables[0];
            dgEmployment.ClearSelection(); // Clear any selected rows

            CustomizeDataGridView(dgEmployment);
        }

        private void LoadRealEstateInfo()
        {
            string query = "SELECT * FROM REAL_ESTATE_INFORMATION";
            DataSet ds = DatabaseConnection.Instance.ExecuteQuery(query);
            dgRealEstate.DataSource = ds.Tables[0];
            dgRealEstate.ClearSelection(); // Clear any selected rows
            CustomizeDataGridView(dgRealEstate);
        }

        private void LoadBankInformation()
        {
            string query = "SELECT * FROM BANKING_INFORMATION";
            DataSet ds = DatabaseConnection.Instance.ExecuteQuery(query);
            dgBankInformation.DataSource = ds.Tables[0];
            dgBankInformation.ClearSelection(); // Clear any selected rows

            CustomizeDataGridView(dgBankInformation);
        }

        private void LoadOtherLoanInformation()
        {
            string query = "SELECT * FROM LOAN_INFORMATION";
            DataSet ds = DatabaseConnection.Instance.ExecuteQuery(query);
            dgOtherLoanInformation.DataSource = ds.Tables[0];
            dgOtherLoanInformation.ClearSelection(); // Clear any selected rows
            CustomizeDataGridView(dgOtherLoanInformation);
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

        private void btnPersonalInfoUpdate_Click(object sender, EventArgs e)
        {
            if (dgPersonalInfo.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgPersonalInfo.SelectedRows[0];

                string? pagIbigMIDNumber = selectedRow.Cells["Pag_IBIG_MID_Number_RTN"].Value?.ToString();
                string borrowerName = selectedRow.Cells["Borrower_Name"].Value?.ToString() ?? string.Empty;
                string borrowerCitizenship = selectedRow.Cells["Borrower_Citizenship"].Value?.ToString() ?? string.Empty;
                DateTime birthdate = Convert.ToDateTime(selectedRow.Cells["Birthdate"].Value);
                string sex = selectedRow.Cells["Sex"].Value?.ToString() ?? "M";
                string permanentAddress = selectedRow.Cells["Permanent_Address"].Value?.ToString() ?? string.Empty;
                string presentAddress = selectedRow.Cells["Present_Address"].Value?.ToString() ?? string.Empty;
                string maritalStatus = selectedRow.Cells["Marital_Status"].Value?.ToString() ?? string.Empty;
                string homeLandline = selectedRow.Cells["Borrower_Home_Landline"].Value?.ToString() ?? string.Empty;
                string cellphone = selectedRow.Cells["Borrower_Cellphone"].Value?.ToString() ?? string.Empty;
                string emailAddress = selectedRow.Cells["Borrower_Email_Address"].Value?.ToString() ?? string.Empty;
                string homeOwnership = selectedRow.Cells["Home_Ownership"].Value?.ToString() ?? string.Empty;
                int yearsOfStay = Convert.ToInt32(selectedRow.Cells["Years_of_Stay"].Value);
                long eessIDNo = Convert.ToInt64(selectedRow.Cells["EE_SSS_GSIS_ID_No"].Value);

                // Construct the update query
                string query = $@"
        UPDATE BORROWER_INFORMATION 
        SET 
            Borrower_Name = '{borrowerName}',
            Borrower_Citizenship = '{borrowerCitizenship}',
            Birthdate = '{birthdate:yyyy-MM-dd}',
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

        private void btnDeletePersonal_Click(object sender, EventArgs e)
        {
            if (dgPersonalInfo.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgPersonalInfo.SelectedRows[0];
                string? pagIbigMIDNumber = selectedRow.Cells["Pag_IBIG_MID_Number_RTN"].Value?.ToString();

                using (var transaction = DatabaseConnection.Instance.BeginTransaction())
                {
                    try
                    {
                        // Delete from dependent tables first
                        string[] queries = new string[]
                        {
                $"DELETE FROM BORROWERS_EMPLOYMENT_INFORMATION WHERE EE_SSS_GSIS_ID_No IN (SELECT EE_SSS_GSIS_ID_No FROM BORROWER_INFORMATION WHERE Pag_IBIG_MID_Number_RTN = '{pagIbigMIDNumber}')",
                $"DELETE FROM COLLATERAL_INFORMATION WHERE Pag_IBIG_MID_Number_RTN = '{pagIbigMIDNumber}'",
                $"DELETE FROM LOAN_INFORMATION WHERE PAG_IBIG_MID_Number_RTN = '{pagIbigMIDNumber}'",
                $"DELETE FROM BANKING_INFORMATION WHERE PAG_IBIG_MID_Number_RTN = '{pagIbigMIDNumber}'",
                $"DELETE FROM REAL_ESTATE_INFORMATION WHERE PAG_IBIG_MID_Number_RTN = '{pagIbigMIDNumber}'",
                $"DELETE FROM 4PS_HOUSING_LOAN_INFORMATION WHERE PAG_IBIG_MID_Number_RTN = '{pagIbigMIDNumber}'",
                        };

                        foreach (string query in queries)
                        {
                            DatabaseConnection.Instance.ExecuteNonQuery(query);
                        }

                        // Finally, delete from the main table
                        string deleteQuery = $"DELETE FROM BORROWER_INFORMATION WHERE Pag_IBIG_MID_Number_RTN = '{pagIbigMIDNumber}'";
                        DatabaseConnection.Instance.ExecuteNonQuery(deleteQuery);

                        transaction.Commit();

                        MessageBox.Show("Record and all related records deleted successfully.");
                        LoadPersonalInfo(); // Refresh the DataGridView
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"An error occurred: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }

        }

        private void btnUpdateLoanInfo_Click(object sender, EventArgs e)
        {
            if (dgLoanInfo.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgLoanInfo.SelectedRows[0];

                string? pagIbigMIDNumber = selectedRow.Cells["PAG_IBIG_MID_Number_RTN"].Value?.ToString();
                string? tctOctCctNo = selectedRow.Cells["TCT_OCT_CCT_No"].Value?.ToString();
                decimal loanAmount = Convert.ToDecimal(selectedRow.Cells["Loan_Amount"].Value);
                string? loanTerm = selectedRow.Cells["Loan_Term"].Value?.ToString();
                string? modeOfPayment = selectedRow.Cells["Mode_of_Payment"].Value?.ToString();

                // Construct the update query
                string query = $@"
        UPDATE 4PS_HOUSING_LOAN_INFORMATION 
        SET 
            Loan_Amount = {loanAmount},
            Loan_Term = '{loanTerm}',
            Mode_of_Payment = '{modeOfPayment}'
        WHERE 
            PAG_IBIG_MID_Number_RTN = '{pagIbigMIDNumber}' AND
            TCT_OCT_CCT_No = '{tctOctCctNo}'";

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
                string? loanId = selectedRow.Cells["Loan_ID"].Value?.ToString();
                string? tctOctCctNo = selectedRow.Cells["TCT_OCT_CCT_No"].Value?.ToString();

                try
                {
                    // Delete related records from other tables
                    string deleteQuery = $@"
            DELETE FROM LOAN_INFORMATION WHERE PAG_IBIG_MID_Number_RTN = '{selectedRow.Cells["PAG_IBIG_MID_Number_RTN"].Value}';
            DELETE FROM 4PS_HOUSING_LOAN_INFORMATION WHERE Loan_ID = {loanId}";

                    DatabaseConnection.Instance.ExecuteNonQuery(deleteQuery);

                    MessageBox.Show("Loan record and related records deleted successfully.");
                    LoadLoanInfo();
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

        private void btnUpdateCollateral_Click(object sender, EventArgs e)
        {
            if (dgCollateral.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgCollateral.SelectedRows[0];

                string? collateralId = selectedRow.Cells["Collateral_ID"].Value?.ToString();
                string? pagIbigMIDNumber = selectedRow.Cells["Pag_IBIG_MID_Number_RTN"].Value?.ToString();
                string? tctOctCctNo = selectedRow.Cells["TCT_OCT_CCT_No"].Value?.ToString();
                string? propertyLocation = selectedRow.Cells["Property_Location"].Value?.ToString();
                string? typeOfProperty = selectedRow.Cells["Type_of_Property"].Value?.ToString();
                string? nameOfProject = selectedRow.Cells["Name_of_Project"].Value?.ToString();

                string query = $@"
        UPDATE COLLATERAL_INFORMATION 
        SET 
            Property_Location = '{propertyLocation}',
            Type_of_Property = '{typeOfProperty}',
            Name_of_Project = '{nameOfProject}'
        WHERE 
            Collateral_ID = {collateralId}";

                if (DatabaseConnection.Instance.ExecuteNonQuery(query))
                {
                    MessageBox.Show("Collateral record updated successfully.");
                    LoadCollateralInfo();
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

                string? eeSssGsisIdNo = selectedRow.Cells["EE_SSS_GSIS_ID_No"].Value?.ToString();
                string? employerBusinessName = selectedRow.Cells["Employer_Business_Name"].Value?.ToString();
                string? employerBusinessAddress = selectedRow.Cells["Employer_Business_Address"].Value.ToString();
                string? employerDirectLine = selectedRow.Cells["Employer_Direct_Line"].Value?.ToString();
                string? employerEmailAddress = selectedRow.Cells["Employer_Email_Address"].Value?.ToString();
                string? occupation = selectedRow.Cells["Occupation"].Value?.ToString();

                string query = $@"
        UPDATE BORROWERS_EMPLOYMENT_INFORMATION 
        SET 
            Employer_Business_Name = '{employerBusinessName}',
            Employer_Business_Address = '{employerBusinessAddress}',
            Employer_Direct_Line = '{employerDirectLine}',
            Employer_Email_Address = '{employerEmailAddress}',
            Occupation = '{occupation}'
        WHERE 
            EE_SSS_GSIS_ID_No = {eeSssGsisIdNo}";

                if (DatabaseConnection.Instance.ExecuteNonQuery(query))
                {
                    MessageBox.Show("Employment record updated successfully.");
                    LoadEmploymentInfo();
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
                string? eeSssGsisIdNo = selectedRow.Cells["EE_SSS_GSIS_ID_No"].Value?.ToString();

                try
                {
                    // Delete related records from other tables
                    string deleteQuery = $@"
            DELETE FROM BORROWERS_EMPLOYMENT_INFORMATION WHERE EE_SSS_GSIS_ID_No = {eeSssGsisIdNo}";

                    DatabaseConnection.Instance.ExecuteNonQuery(deleteQuery);

                    MessageBox.Show("Employment record deleted successfully.");
                    LoadEmploymentInfo();
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

        private void btnUpdateBankInfo_Click(object sender, EventArgs e)
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
            Bank_ID = {bankId}";

                if (DatabaseConnection.Instance.ExecuteNonQuery(query))
                {
                    MessageBox.Show("Bank information updated successfully.");
                    LoadBankInformation();
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
                string? pagIbigMIDNumber = selectedRow.Cells["PAG_IBIG_MID_Number_RTN"].Value.ToString();
                string? type = selectedRow.Cells["Type"].Value.ToString();
                string? security = selectedRow.Cells["Security"].Value.ToString();
                DateTime maturityDate = Convert.ToDateTime(selectedRow.Cells["Maturity_Date"].Value);
                decimal amountBalance = Convert.ToDecimal(selectedRow.Cells["Amount_Balance"].Value);
                string? moAmortization = selectedRow.Cells["Mo_Amortization"].Value.ToString();

                string query = $@"
        UPDATE LOAN_INFORMATION 
        SET 
            PAG_IBIG_MID_Number_RTN = '{pagIbigMIDNumber}',
            Type = '{type}',
            Security = '{security}',
            Maturity_Date = '{maturityDate.ToString("yyyy-MM-dd")}',
            Amount_Balance = {amountBalance},
            Mo_Amortization = '{moAmortization}'
        WHERE 
            Loan_Availment_Key = {loanAvailmentKey}";

                if (DatabaseConnection.Instance.ExecuteNonQuery(query))
                {
                    MessageBox.Show("Other loan information updated successfully.");
                    LoadOtherLoanInformation();
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

        private void btnUpdateRealEstate_Click(object sender, EventArgs e)
        {
            if (dgRealEstate.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgRealEstate.SelectedRows[0];

                string? realEstateKey = selectedRow.Cells["Real_Estate_Key"].Value.ToString();
                string? pagIbigMIDNumber = selectedRow.Cells["PAG_IBIG_MID_Number_RTN"].Value.ToString();
                string? realEstateLocation = selectedRow.Cells["Real_Estate_Location"].Value.ToString();
                string? typeOfProperty = selectedRow.Cells["Type_of_Property"].Value.ToString();
                decimal acquisitionCost = Convert.ToDecimal(selectedRow.Cells["Acquisition_Cost"].Value);
                decimal marketValue = Convert.ToDecimal(selectedRow.Cells["Market_Value"].Value);
                decimal mortgageBalance = Convert.ToDecimal(selectedRow.Cells["Mortgage_Balance"].Value);
                decimal rentalIncome = Convert.ToDecimal(selectedRow.Cells["Rental_Income"].Value);

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
            Real_Estate_Key = {realEstateKey}";

                if (DatabaseConnection.Instance.ExecuteNonQuery(query))
                {
                    MessageBox.Show("Real estate record updated successfully.");
                    LoadRealEstateInfo();
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

        private void dgLoanInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgEmployment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgBankInformation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
