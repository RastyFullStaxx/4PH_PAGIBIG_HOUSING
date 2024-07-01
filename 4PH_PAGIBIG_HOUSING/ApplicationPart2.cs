using _4PH_PAGIBIG_HOUSING.Database;
using _4PH_PAGIBIG_HOUSING.DbContext;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace _4PH_PAGIBIG_HOUSING
{
    public partial class ApplicationPart2 : Form
    {
        private readonly string _pagIBIGMIDNumberRTN;
        private readonly DatabaseConnection database = DatabaseConnection.GetInstance();
        private readonly HousingLoanInformation loan = new HousingLoanInformation();
        private string _tct;

        public ApplicationPart2(string pagIBIGMIDNumberRTN, string tct)
        {
            InitializeComponent();
            _pagIBIGMIDNumberRTN = pagIBIGMIDNumberRTN;
            _tct = tct; // Receive TCT from ApplicationPart3

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            loan.PAG_IBIG_MID_Number_RTN = _pagIBIGMIDNumberRTN;

            loan.TCT_OCT_CCT_No = _tct; // Set TCT value

            if (cbModeOfPayment.SelectedItem == null)
            {
                MessageBox.Show("Mode of payment is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbModeOfPayment.Focus();
                return;
            }

            loan.Mode_of_Payment = cbModeOfPayment.SelectedItem?.ToString();
            Console.WriteLine($"Selected mode of payment: {loan.Mode_of_Payment}"); // Add this line for debugging

            if (!decimal.TryParse(txtLoanAmount.Text, out decimal loanAmount))
            {
                MessageBox.Show("Invalid loan amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLoanAmount.Focus();
                return;
            }

            loan.Loan_Amount = loanAmount;
            loan.Loan_Term = cbLoanTerm.Text;

            bool savedSuccessfully = SaveLoanInformation(loan);
            if (savedSuccessfully)
            {
                ApplicationPart5 BankInfo = new ApplicationPart5();
                BankInfo.Show();
                this.Hide();
                ClearLoanForm();
            }
            else
            {
                MessageBox.Show("Failed to save loan information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool SaveLoanInformation(HousingLoanInformation loan)
        {
            // Use your DatabaseConnection class to get a database connection
            using (var connection = database.GetConnection())
            {
                try
                {
                    connection.Open();
                    // Example SQL command to insert loan information into the database
                    string sql = "INSERT INTO 4PS_HOUSING_LOAN_INFORMATION (PAG_IBIG_MID_Number_RTN, TCT_OCT_CCT_No, Loan_Amount, Loan_Term, Mode_of_Payment) " +
                                 "VALUES (@MID, @TCT_OCT_CCT_No, @LoanAmount, @LoanTerm, @ModeOfPayment)";

                    using (var cmd = new MySqlCommand(sql, connection))
                    {
                        // Add parameters to the SQL command
                        cmd.Parameters.AddWithValue("@MID", loan.PAG_IBIG_MID_Number_RTN);
                        cmd.Parameters.AddWithValue("@TCT_OCT_CCT_No", loan.TCT_OCT_CCT_No); 
                        cmd.Parameters.AddWithValue("@LoanAmount", loan.Loan_Amount);
                        cmd.Parameters.AddWithValue("@LoanTerm", loan.Loan_Term);
                        cmd.Parameters.AddWithValue("@ModeOfPayment", loan.Mode_of_Payment);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving loan information: {ex.Message}");
                    return false;
                }
            }
        }


        private void ClearLoanForm()
        {
            txtLoanAmount.Text = string.Empty;
            cbLoanTerm.Text = string.Empty;
            cbModeOfPayment.SelectedIndex = -1; // Reset ComboBox selection
        }
        private void ApplicationPart2_Load(object sender, EventArgs e)
        {

        }
    }
}
