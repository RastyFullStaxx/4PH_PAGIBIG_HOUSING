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
        private bool pnlEntry2Expanded = false;
        private bool pnlEntry3Expanded = false;

        public ApplicationPart5()
        {
            InitializeComponent();

            // Initialize the initial state of pnlEntry2
            ShowOnlyCancelEntry2();

            // Initialize the initial state of pnlEntry3
            ShowOnlyCancelEntry3();
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
            comboBox1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            btnRevealEntry2.Visible = true; // Show btnRevealEntry2 when btnCancelEntry2 is visible
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            dateTimePicker1.Visible = false;
            btnCancelEntry2.Visible = false;

            pnlEntry2Expanded = false;
        }

        private void ExpandPnlEntry2()
        {
            // Show all controls in pnlEntry2
            btnCancelEntry2.Visible = true;
            label15.Visible = true;
            comboBox1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            btnRevealEntry2.Visible = false; // Hide btnRevealEntry2 when all controls are visible
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            dateTimePicker1.Visible = true;
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
            comboBox2.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            dateTimePicker2.Visible = false;
            btnCancelEntry3.Visible = false;

            pnlEntry3Expanded = false;
        }

        private void ExpandPnlEntry3()
        {
            // Show all controls in pnlEntry3
            btnCancelEntry3.Visible = true;
            btnRevealEntry3.Visible = false; // Hide btnRevealEntry3 when all controls are visible
            label16.Visible = true;
            comboBox2.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
            textBox9.Visible = true;
            textBox10.Visible = true;
            dateTimePicker2.Visible = true;
            btnCancelEntry3.Visible = true;

            pnlEntry3Expanded = true;
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
