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
using _4PH_PAGIBIG_HOUSING.DbContext;
using MySql.Data.MySqlClient;

namespace _4PH_PAGIBIG_HOUSING
{
    public partial class ApplicationPart5 : Form
    {
        private readonly string _pagIBIGMIDNumberRTN, _tct;
        private readonly DatabaseConnection _database = DatabaseConnection.Instance;
        private readonly BankingInformation _bank = new BankingInformation();

        public ApplicationPart5(string pagIBIGMIDNumberRTN, string tct)
        {
            InitializeComponent();
            _pagIBIGMIDNumberRTN = pagIBIGMIDNumberRTN;
            _tct = tct;
        }

        private void btnSaveBankInfo_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                if (SaveBankingInformation(_bank))
                {
                    MessageBox.Show("Banking information saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearInputs();
                    // Optionally, you can proceed to the next form or take other actions
                    ApplicationPart6 
                }
                else
                {
                    MessageBox.Show("Failed to save banking information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateInputs()
        {
            _bank.PAG_IBIG_MID_Number_RTN = _pagIBIGMIDNumberRTN;
            _bank.Account_No = txtAccountNumber.Text.Trim();
            _bank.Type_of_Account = cbTypeOfAccount.SelectedItem?.ToString();
            _bank.Branch_Address = txtBranchAddress.Text.Trim();
            _bank.Issuer_Name = txtIssuerName.Text.Trim();
            _bank.Bank = txtBankOfTheAccount.Text.Trim();
            // Validate required fields
            if (string.IsNullOrEmpty(_bank.Account_No) || string.IsNullOrEmpty(_bank.Type_of_Account))
            {
                MessageBox.Show("Account Number and Type of Account are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validate average balance
            if (!decimal.TryParse(txtAverageBalance.Text, out decimal aveBalance))
            {
                MessageBox.Show("Invalid Average Balance.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            _bank.Ave_Balance = aveBalance;
            _bank.Date_Opened = dtDateOpened.Value;

            return true;
        }


        private bool SaveBankingInformation(BankingInformation bankingInfo)
        {
            // Use your DatabaseConnection class to get a database connection
            using (var connection = _database.GetConnection())
            {
                try
                {
                    connection.Open();
                    // Example SQL command to insert banking information into the database
                    string sql = "INSERT INTO BANKING_INFORMATION (PAG_IBIG_MID_Number_RTN, Account_No, Bank, Branch_Address, Type_of_Account, Date_Opened, Ave_Balance, Issuer_Name) " +
                                 "VALUES (@MID, @AccountNo, @Bank, @BranchAddress, @TypeOfAccount, @DateOpened, @AveBalance, @IssuerName)";

                    using (var cmd = new MySqlCommand(sql, connection))
                    {
                        // Add parameters to the SQL command
                        cmd.Parameters.AddWithValue("@MID", bankingInfo.PAG_IBIG_MID_Number_RTN);
                        cmd.Parameters.AddWithValue("@AccountNo", bankingInfo.Account_No);
                        cmd.Parameters.AddWithValue("@Bank", bankingInfo.Bank); // Ensure you set Bank in _bank instance
                        cmd.Parameters.AddWithValue("@BranchAddress", bankingInfo.Branch_Address);
                        cmd.Parameters.AddWithValue("@TypeOfAccount", bankingInfo.Type_of_Account);
                        cmd.Parameters.AddWithValue("@DateOpened", bankingInfo.Date_Opened);
                        cmd.Parameters.AddWithValue("@AveBalance", bankingInfo.Ave_Balance);
                        cmd.Parameters.AddWithValue("@IssuerName", bankingInfo.Issuer_Name);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving banking information: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private void ClearInputs()
        {
            txtAccountNumber.Text = string.Empty;
            cbTypeOfAccount.SelectedIndex = -1; // Reset combo box selection
            txtBranchAddress.Text = string.Empty;
            txtIssuerName.Text = string.Empty;
            txtAverageBalance.Text = string.Empty;
            dtDateOpened.Value = DateTime.Now;
        }

        private void ApplicationPart5_Load(object sender, EventArgs e)
        {
            cbTypeOfAccount.Items.AddRange(new string[] { "Savings", "Checking", "Current" });
        }

        private void btnAddMoreAcc_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                if (SaveBankingInformation(_bank))
                {
                    MessageBox.Show("Additional banking information saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearInputs();
                    // Optionally, you can proceed to the next form or take other actions
                }
                else
                {
                    MessageBox.Show("Failed to save additional banking information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
