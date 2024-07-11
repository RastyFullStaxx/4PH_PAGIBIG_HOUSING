using _4PH_PAGIBIG_HOUSING.Database;
using _4PH_PAGIBIG_HOUSING.DbContext;
using MySql.Data.MySqlClient;
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
    public partial class ApplicationPart5 : Form
    {
        private bool pnlEntry2Expanded = false;
        private bool pnlEntry3Expanded = false;
        private readonly string _pagIBIGMIDNumberRTN, _tct;
        private readonly DatabaseConnection _database = DatabaseConnection.Instance;
        private readonly BankingInformation _bank = new BankingInformation();



        public ApplicationPart5(String pagibigMIDNumber, String tct)
        {
            InitializeComponent();

            // Initialize the initial state of pnlEntry2
            ShowOnlyCancelEntry2();

            // Initialize the initial state of pnlEntry3
            ShowOnlyCancelEntry3();
            _pagIBIGMIDNumberRTN = pagibigMIDNumber;
            _tct = tct;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Add your code for btnBack_Click here if needed
        }

        private void btnCancelEntry2_Click(object sender, EventArgs e)
        {
            if (pnlEntry2Expanded)
            {
                ShowOnlyCancelEntry2();
            }
            else
            {
                ExpandPnlEntry2();
            }
        }

        private void btnRevealEntry2_Click(object sender, EventArgs e)
        {
            ExpandPnlEntry2();
        }

        private void ShowOnlyCancelEntry2()
        {
            // Show only btnCancelEntry2 and hide other controls in pnlEntry2
            btnCancelEntry2.Visible = true;
            label15.Visible = false;
            cbTypeOfAccount2.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            btnRevealEntry2.Visible = true; // Show btnRevealEntry2 when btnCancelEntry2 is visible
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            txtAccountNumber2.Visible = false;
            txtBankOfTheAccount2.Visible = false;
            txtIssuerName2.Visible = false;
            txtAverageBalance2.Visible = false;
            txtBranchAddress2.Visible = false;
            dtDateOpened2.Visible = false;
            btnCancelEntry2.Visible = false;

            pnlEntry2Expanded = false;
        }

        private void ExpandPnlEntry2()
        {
            // Show all controls in pnlEntry2
            btnCancelEntry2.Visible = true;
            label15.Visible = true;
            cbTypeOfAccount2.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            btnRevealEntry2.Visible = false; // Hide btnRevealEntry2 when all controls are visible
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            txtAccountNumber2.Visible = true;
            txtBankOfTheAccount2.Visible = true;
            txtIssuerName2.Visible = true;
            txtAverageBalance2.Visible = true;
            txtBranchAddress2.Visible = true;
            dtDateOpened2.Visible = true;
            btnCancelEntry2.Visible = true;

            pnlEntry2Expanded = true;
        }

        private void btnCancelEntry3_Click(object sender, EventArgs e)
        {
            if (pnlEntry3Expanded)
            {
                ShowOnlyCancelEntry3();
            }
            else
            {
                ExpandPnlEntry3();
            }
        }

        private void btnRevealEntry3_Click(object sender, EventArgs e)
        {
            ExpandPnlEntry3();
        }

        private void ShowOnlyCancelEntry3()
        {
            // Show only btnCancelEntry3 and hide other controls in pnlEntry3
            btnCancelEntry3.Visible = true;
            btnRevealEntry3.Visible = true; // Show btnRevealEntry3 when btnCancelEntry3 is visible
            label16.Visible = false;
            cbTypeOfAccount3.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            txtAccountNumber3.Visible = false;
            txtBankOfTheAccount3.Visible = false;
            txtIssuerName3.Visible = false;
            txtAverageBalance3.Visible = false;
            txtBranchAddress3.Visible = false;
            dtDateOpened3.Visible = false;
            btnCancelEntry3.Visible = false;

            pnlEntry3Expanded = false;
        }

        private void ExpandPnlEntry3()
        {
            // Show all controls in pnlEntry3
            btnCancelEntry3.Visible = true;
            btnRevealEntry3.Visible = false; // Hide btnRevealEntry3 when all controls are visible
            label16.Visible = true;
            cbTypeOfAccount3.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            txtAccountNumber3.Visible = true;
            txtBankOfTheAccount3.Visible = true;
            txtIssuerName3.Visible = true;
            txtAverageBalance3.Visible = true;
            txtBranchAddress3.Visible = true;
            dtDateOpened3.Visible = true;
            btnCancelEntry3.Visible = true;

            pnlEntry3Expanded = true;
        }

        private void ApplicationPart5_Load(object sender, EventArgs e)
        {
            cbTypeOfAccount1.Items.AddRange(new string[] { "Savings", "Checking", "Current" });
            cbTypeOfAccount2.Items.AddRange(new string[] { "Savings", "Checking", "Current" });
            cbTypeOfAccount3.Items.AddRange(new string[] { "Savings", "Checking", "Current" });

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Panel1Insert();
            if (pnlEntry2.Visible) // Check if pnlEntry2 is visible
            {
                Panel2Insert();
            }
            if (pnlEntry3.Visible) // Check if pnlEntry3 is visible
            {
                Panel3Insert();
            }


            ApplicationPart6 realestate = new ApplicationPart6(_pagIBIGMIDNumberRTN, _tct);
            realestate.Show();
            this.Hide();

        }

        private void Panel1Insert()
        {
            _bank.PAG_IBIG_MID_Number_RTN = _pagIBIGMIDNumberRTN;
            _bank.Account_No = txtAccountNumber1.Text.Trim();
            _bank.Type_of_Account = cbTypeOfAccount1.SelectedItem?.ToString();
            _bank.Branch_Address = txtBranchAddress1.Text.Trim();
            _bank.Issuer_Name = txtIssuerName1.Text.Trim();
            _bank.Type_of_Account = cbTypeOfAccount1.SelectedItem?.ToString();
            _bank.Branch_Address = txtBranchAddress1.Text.Trim();
            _bank.Issuer_Name = txtIssuerName1.Text.Trim();
            _bank.Bank = txtBankOfTheAccount1.Text.Trim();

            // Validate required fields
            if (string.IsNullOrEmpty(_bank.Account_No) || string.IsNullOrEmpty(_bank.Type_of_Account))
            {
                MessageBox.Show("Account Number and Type of Account are required for the first bank account.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Try parsing average balance
            if (!decimal.TryParse(txtAverageBalance1.Text, out decimal aveBalance))
            {
                MessageBox.Show("Invalid Average Balance for the first bank account.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _bank.Ave_Balance = aveBalance;
            _bank.Date_Opened = dtDateOpened1.Value;

            // Save banking information
            if (SaveBankingInformation(_bank))
            {
                //MessageBox.Show("Banking information saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Optionally, you can proceed to the next form or take other actions
            }
            else
            {
                MessageBox.Show("Failed to save banking information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void Panel2Insert()
        {
            if (!pnlEntry2.Visible) return; // Exit if pnlEntry2 is not visible

            _bank.PAG_IBIG_MID_Number_RTN = _pagIBIGMIDNumberRTN;
            _bank.Account_No = txtAccountNumber2.Text.Trim();
            _bank.Type_of_Account = cbTypeOfAccount2.SelectedItem?.ToString();
            _bank.Branch_Address = txtBranchAddress2.Text.Trim();
            _bank.Issuer_Name = txtIssuerName2.Text.Trim();
            _bank.Bank = txtBankOfTheAccount2.Text.Trim();

            // Validate required fields only if pnlEntry2 is visible
            if (string.IsNullOrEmpty(_bank.Account_No))
            {
                MessageBox.Show("Account Number is required for the second bank account.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(_bank.Type_of_Account))
            {
                MessageBox.Show("Type of Account is required for the second bank account.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Try parsing average balance
            if (!decimal.TryParse(txtAverageBalance2.Text, out decimal aveBalance))
            {
                MessageBox.Show("Invalid Average Balance for the second bank account.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _bank.Ave_Balance = aveBalance;
            _bank.Date_Opened = dtDateOpened2.Value;

            // Save banking information
            if (SaveBankingInformation(_bank))
            {
                //MessageBox.Show("Banking information saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Optionally, you can proceed to the next form or take other actions
            }
            else
            {
                MessageBox.Show("Failed to save banking information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Panel3Insert()
        {
            if (!pnlEntry3.Visible) return; // Exit if pnlEntry3 is not visible

            _bank.PAG_IBIG_MID_Number_RTN = _pagIBIGMIDNumberRTN;
            _bank.Account_No = txtAccountNumber3.Text.Trim();
            _bank.Type_of_Account = cbTypeOfAccount3.SelectedItem?.ToString();
            _bank.Branch_Address = txtBranchAddress3.Text.Trim();
            _bank.Issuer_Name = txtIssuerName3.Text.Trim();
            _bank.Bank = txtBankOfTheAccount3.Text.Trim();

            // Validate required fields only if pnlEntry3 is visible
            if (string.IsNullOrEmpty(_bank.Account_No))
            {
                MessageBox.Show("Account Number is required for the third bank account.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(_bank.Type_of_Account))
            {
                MessageBox.Show("Type of Account is required for the third bank account.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Try parsing average balance
            if (!decimal.TryParse(txtAverageBalance3.Text, out decimal aveBalance))
            {
                MessageBox.Show("Invalid Average Balance for the third bank account.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _bank.Ave_Balance = aveBalance;
            _bank.Date_Opened = dtDateOpened3.Value;

            // Save banking information
            if (SaveBankingInformation(_bank))
            {
                //MessageBox.Show("Banking information saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Optionally, you can proceed to the next form or take other actions
            }
            else
            {
                MessageBox.Show("Failed to save banking information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    MessageBox.Show($"Error saving banking information: {ex.Message}");
                    return false;
                }
            }
        }

        private void pnlEntry2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
