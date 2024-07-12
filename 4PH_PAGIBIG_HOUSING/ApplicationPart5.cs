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
        private readonly BankingInformation _bank1 = new BankingInformation();
        private readonly BankingInformation _bank2 = new BankingInformation();
        private readonly BankingInformation _bank3 = new BankingInformation();


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
            // Validate each panel first
            bool panel1Valid = ValidatePanel1();
            bool panel2Valid = ValidatePanel2();
            bool panel3Valid = ValidatePanel3();

            // Proceed only if all panels are valid
            if (panel1Valid && panel2Valid && panel3Valid)
            {
                // Insert data for each panel
                bool panel1Inserted = Panel1Insert();
                bool panel2Inserted = Panel2Insert();
                bool panel3Inserted = Panel3Insert();

                // Check if all insertions were successful
                if (panel1Inserted && panel2Inserted && panel3Inserted)
                {
                    // Navigate to the next form
                    ApplicationPart6 realestate = new ApplicationPart6(_pagIBIGMIDNumberRTN, _tct);
                    realestate.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Failed to save some of the banking information. Please check your entries.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill out all required fields correctly in all panels before proceeding.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private bool ValidatePanel1()
        {
            if (!pnlEntry1.Visible) return true; // No need to validate if pnlEntry1 is not visible

            _bank1.PAG_IBIG_MID_Number_RTN = _pagIBIGMIDNumberRTN;
            _bank1.Account_No = txtAccountNumber1.Text.Trim();
            _bank1.Type_of_Account = cbTypeOfAccount1.SelectedItem?.ToString();
            _bank1.Branch_Address = txtBranchAddress1.Text.Trim();
            _bank1.Issuer_Name = txtIssuerName1.Text.Trim();
            _bank1.Bank = txtBankOfTheAccount1.Text.Trim();

            // Validate required fields
            if (string.IsNullOrEmpty(_bank1.Account_No) || string.IsNullOrEmpty(_bank1.Type_of_Account))
            {
                MessageBox.Show("Account Number and Type of Account are required for the first bank account.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Try parsing average balance
            if (!decimal.TryParse(txtAverageBalance1.Text, out decimal aveBalance))
            {
                MessageBox.Show("Invalid Average Balance for the first bank account.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            _bank1.Ave_Balance = aveBalance;
            _bank1.Date_Opened = dtDateOpened1.Value;

            return true;
        }

        private bool ValidatePanel2()
        {
            if (!pnlEntry2.Visible) return true; // No need to validate if pnlEntry2 is not visible

            _bank2.PAG_IBIG_MID_Number_RTN = _pagIBIGMIDNumberRTN;
            _bank2.Account_No = txtAccountNumber2.Text.Trim();
            _bank2.Type_of_Account = cbTypeOfAccount2.SelectedItem?.ToString();
            _bank2.Branch_Address = txtBranchAddress2.Text.Trim();
            _bank2.Issuer_Name = txtIssuerName2.Text.Trim();
            _bank2.Bank = txtBankOfTheAccount2.Text.Trim();

            // Validate required fields
            if (string.IsNullOrEmpty(_bank2.Account_No) || string.IsNullOrEmpty(_bank2.Type_of_Account))
            {
                MessageBox.Show("Account Number and Type of Account are required for the second bank account.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Try parsing average balance
            if (!decimal.TryParse(txtAverageBalance2.Text, out decimal aveBalance))
            {
                MessageBox.Show("Invalid Average Balance for the second bank account.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            _bank2.Ave_Balance = aveBalance;
            _bank2.Date_Opened = dtDateOpened2.Value;

            return true;
        }

        private bool ValidatePanel3()
        {
            if (!pnlEntry3.Visible) return true; // No need to validate if pnlEntry3 is not visible

            _bank3.PAG_IBIG_MID_Number_RTN = _pagIBIGMIDNumberRTN;
            _bank3.Account_No = txtAccountNumber3.Text.Trim();
            _bank3.Type_of_Account = cbTypeOfAccount3.SelectedItem?.ToString();
            _bank3.Branch_Address = txtBranchAddress3.Text.Trim();
            _bank3.Issuer_Name = txtIssuerName3.Text.Trim();
            _bank3.Bank = txtBankOfTheAccount3.Text.Trim();

            // Validate required fields
            if (string.IsNullOrEmpty(_bank3.Account_No) || string.IsNullOrEmpty(_bank3.Type_of_Account))
            {
                MessageBox.Show("Account Number and Type of Account are required for the third bank account.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Try parsing average balance
            if (!decimal.TryParse(txtAverageBalance3.Text, out decimal aveBalance))
            {
                MessageBox.Show("Invalid Average Balance for the third bank account.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            _bank3.Ave_Balance = aveBalance;
            _bank3.Date_Opened = dtDateOpened3.Value;

            return true;
        }

        private bool Panel1Insert()
        {
            try
            {
                using (MySqlConnection conn = _database.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO banking_information(PAG_IBIG_MID_Number_RTN, Account_No, Type_of_Account, Branch_Address, Issuer_Name, Bank, Ave_Balance, Date_Opened) VALUES (@PAG_IBIG_MID_Number_RTN, @Account_No, @Type_of_Account, @Branch_Address, @Issuer_Name, @Bank, @Ave_Balance, @Date_Opened)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PAG_IBIG_MID_Number_RTN", _bank1.PAG_IBIG_MID_Number_RTN);
                        cmd.Parameters.AddWithValue("@Account_No", _bank1.Account_No);
                        cmd.Parameters.AddWithValue("@Type_of_Account", _bank1.Type_of_Account);
                        cmd.Parameters.AddWithValue("@Branch_Address", _bank1.Branch_Address);
                        cmd.Parameters.AddWithValue("@Issuer_Name", _bank1.Issuer_Name);
                        cmd.Parameters.AddWithValue("@Bank", _bank1.Bank);
                        cmd.Parameters.AddWithValue("@Ave_Balance", _bank1.Ave_Balance);
                        cmd.Parameters.AddWithValue("@Date_Opened", _bank1.Date_Opened);

                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving the first bank account: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool Panel2Insert()
        {
            try
            {
                using (MySqlConnection conn = _database.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO banking_information(PAG_IBIG_MID_Number_RTN, Account_No, Type_of_Account, Branch_Address, Issuer_Name, Bank, Ave_Balance, Date_Opened) VALUES (@PAG_IBIG_MID_Number_RTN, @Account_No, @Type_of_Account, @Branch_Address, @Issuer_Name, @Bank, @Ave_Balance, @Date_Opened)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PAG_IBIG_MID_Number_RTN", _bank2.PAG_IBIG_MID_Number_RTN);
                        cmd.Parameters.AddWithValue("@Account_No", _bank2.Account_No);
                        cmd.Parameters.AddWithValue("@Type_of_Account", _bank2.Type_of_Account);
                        cmd.Parameters.AddWithValue("@Branch_Address", _bank2.Branch_Address);
                        cmd.Parameters.AddWithValue("@Issuer_Name", _bank2.Issuer_Name);
                        cmd.Parameters.AddWithValue("@Bank", _bank2.Bank);
                        cmd.Parameters.AddWithValue("@Ave_Balance", _bank2.Ave_Balance);
                        cmd.Parameters.AddWithValue("@Date_Opened", _bank2.Date_Opened);

                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving the second bank account: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool Panel3Insert()
        {
            try
            {
                using (MySqlConnection conn = _database.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO banking_information(PAG_IBIG_MID_Number_RTN, Account_No, Type_of_Account, Branch_Address, Issuer_Name, Bank, Ave_Balance, Date_Opened) VALUES (@PAG_IBIG_MID_Number_RTN, @Account_No, @Type_of_Account, @Branch_Address, @Issuer_Name, @Bank, @Ave_Balance, @Date_Opened)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PAG_IBIG_MID_Number_RTN", _bank3.PAG_IBIG_MID_Number_RTN);
                        cmd.Parameters.AddWithValue("@Account_No", _bank3.Account_No);
                        cmd.Parameters.AddWithValue("@Type_of_Account", _bank3.Type_of_Account);
                        cmd.Parameters.AddWithValue("@Branch_Address", _bank3.Branch_Address);
                        cmd.Parameters.AddWithValue("@Issuer_Name", _bank3.Issuer_Name);
                        cmd.Parameters.AddWithValue("@Bank", _bank3.Bank);
                        cmd.Parameters.AddWithValue("@Ave_Balance", _bank3.Ave_Balance);
                        cmd.Parameters.AddWithValue("@Date_Opened", _bank3.Date_Opened);

                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving the third bank account: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
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

