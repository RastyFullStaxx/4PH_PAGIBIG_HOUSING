using _4PH_PAGIBIG_HOUSING.Database;
using _4PH_PAGIBIG_HOUSING.DbContext;
using MySql.Data.MySqlClient;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace _4PH_PAGIBIG_HOUSING
{
    public partial class ApplicationPart1 : Form
    {
        private readonly DatabaseConnection database = DatabaseConnection.GetInstance();
        private readonly BorrowerInformation borrower = new BorrowerInformation();

        public ApplicationPart1()
        {
            InitializeComponent();
        }

        private void ApplicationPart1_Load(object sender, EventArgs e)
        {
            // Initialize your form or load data if needed
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Example of moving to the next part of the application
            ApplicationPart2 applicationPart2 = new ApplicationPart2(txtMRID.Text);
            applicationPart2.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (!ValidateFields())
            {
                return;
            }

            // Populate BorrowerInformation object with form data
            borrower.Pag_IBIG_MID_Number_RTN = txtMRID.Text;
            borrower.Borrower_Name = txtFullname.Text;
            borrower.Borrower_Nationality = txtNationality.Text;
            borrower.Birthdate = dtBirthdate.Value;

            if (cbSex.SelectedItem != null)
            {
                string selectedSex = cbSex.SelectedItem.ToString() ?? ""; // Provide a default value if SelectedItem is null
                borrower.SetSexFromComboBox(selectedSex);
            }

            borrower.Permanent_Address = txtPermanentAddress.Text;
            borrower.Present_Address = txtPresentAddress.Text;

            borrower.Marital_Status = cbMaritalStatus.SelectedItem?.ToString(); // Handle nullability of Marital_Status

            borrower.Borrower_Home_Landline = txtLandline.Text;
            borrower.Borrower_Cellphone = txtCellphoneNumber.Text;
            borrower.Borrower_Email_Address = txtEmailAddress.Text;

            borrower.Home_Ownership = cbHomeOwnership.SelectedItem?.ToString(); // Handle nullability of Home_Ownership

            borrower.Years_of_Stay = int.Parse(cbYearsOfStay.Text);
            borrower.EE_SSS_GSIS_ID_No = txtSSS.Text;

            // Now you can save `borrower` object to the database or perform other operations
            // For example:
            bool savedSuccessfully = SaveBorrowerInformation(borrower);
            if (savedSuccessfully)
            {
                ApplicationPart4 EmploymentInfo = new ApplicationPart4(txtMRID.Text, txtSSS.Text);
                EmploymentInfo.Show();
                this.Hide();
                Console.WriteLine("Borrower information saved successfully.");
                ClearForm();
            }
            else
            {
                Console.WriteLine("Failed to save borrower information.");
            }
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txtMRID.Text))
            {
                MessageBox.Show("MID cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMRID.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtFullname.Text) || !Regex.IsMatch(txtFullname.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Invalid or empty full name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullname.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNationality.Text) || !Regex.IsMatch(txtNationality.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Invalid or empty nationality.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNationality.Focus();
                return false;
            }

            if (cbSex.SelectedItem == null)
            {
                MessageBox.Show("Sex is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbSex.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPermanentAddress.Text))
            {
                MessageBox.Show("Permanent address cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPermanentAddress.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPresentAddress.Text))
            {
                MessageBox.Show("Present address cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPresentAddress.Focus();
                return false;
            }

            if (cbMaritalStatus.SelectedItem == null)
            {
                MessageBox.Show("Marital status is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbMaritalStatus.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLandline.Text) || !Regex.IsMatch(txtLandline.Text, @"^\d+$"))
            {
                MessageBox.Show("Invalid or empty landline number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLandline.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCellphoneNumber.Text) || !Regex.IsMatch(txtCellphoneNumber.Text, @"^\d+$"))
            {
                MessageBox.Show("Invalid or empty cellphone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCellphoneNumber.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmailAddress.Text) || !Regex.IsMatch(txtEmailAddress.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Invalid or empty email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmailAddress.Focus();
                return false;
            }

            if (cbHomeOwnership.SelectedItem == null)
            {
                MessageBox.Show("Home ownership is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbHomeOwnership.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cbYearsOfStay.Text) || !int.TryParse(cbYearsOfStay.Text, out _))
            {
                MessageBox.Show("Invalid or empty years of stay.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbYearsOfStay.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSSS.Text) || !Regex.IsMatch(txtSSS.Text, @"^\d+$"))
            {
                MessageBox.Show("Invalid or empty SSS/GSIS ID number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSSS.Focus();
                return false;
            }

            return true;
        }

        private bool SaveBorrowerInformation(BorrowerInformation borrower)
        {
            // Example method to save borrower information to the database
            // You need to implement this based on your database logic

            // Example code using your DatabaseConnection class
            using (var connection = database.GetConnection())
            {
                try
                {
                    connection.Open();
                    // Example SQL command to insert into database
                    string sql = "INSERT INTO borrower_information (Pag_IBIG_MID_Number_RTN, Borrower_Name, Borrower_Citizenship, Birthdate, Sex, Permanent_Address, " +
                                 "Present_Address, Marital_Status, Borrower_Home_Landline, Borrower_Cellphone, Borrower_Email_Address, Home_Ownership, " +
                                 "Years_of_Stay, EE_SSS_GSIS_ID_No) VALUES (@MRID, @FullName, @Nationality, @Birthdate, @Sex, @PermanentAddress, " +
                                 "@PresentAddress, @MaritalStatus, @Landline, @CellphoneNumber, @EmailAddress, @HomeOwnership, " +
                                 "@YearsOfStay, @SSS)";

                    using (var cmd = new MySqlCommand(sql, connection))
                    {
                        // Example parameters - replace with actual database column names and values
                        cmd.Parameters.AddWithValue("@MRID", borrower.Pag_IBIG_MID_Number_RTN);
                        cmd.Parameters.AddWithValue("@FullName", borrower.Borrower_Name);
                        cmd.Parameters.AddWithValue("@Nationality", borrower.Borrower_Nationality);
                        cmd.Parameters.AddWithValue("@Birthdate", borrower.Birthdate);
                        cmd.Parameters.AddWithValue("@Sex", borrower.Sex);
                        cmd.Parameters.AddWithValue("@PermanentAddress", borrower.Permanent_Address);
                        cmd.Parameters.AddWithValue("@PresentAddress", borrower.Present_Address);
                        cmd.Parameters.AddWithValue("@MaritalStatus", borrower.Marital_Status);
                        cmd.Parameters.AddWithValue("@Landline", borrower.Borrower_Home_Landline);
                        cmd.Parameters.AddWithValue("@CellphoneNumber", borrower.Borrower_Cellphone);
                        cmd.Parameters.AddWithValue("@EmailAddress", borrower.Borrower_Email_Address);
                        cmd.Parameters.AddWithValue("@HomeOwnership", borrower.Home_Ownership);
                        cmd.Parameters.AddWithValue("@YearsOfStay", borrower.Years_of_Stay);
                        cmd.Parameters.AddWithValue("@SSS", borrower.EE_SSS_GSIS_ID_No);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving borrower information: {ex.Message}");
                    return false;
                }
            }
        }

        private void ClearForm()
        {
            // Example method to clear form fields after saving
            txtMRID.Text = string.Empty;
            txtFullname.Text = string.Empty;
            txtNationality.Text = string.Empty;
            dtBirthdate.Value = DateTime.Today;
            cbSex.SelectedIndex = -1; // Reset ComboBox selection
            txtPermanentAddress.Text = string.Empty;
            txtPresentAddress.Text = string.Empty;
            cbMaritalStatus.SelectedIndex = -1; // Reset ComboBox selection
            txtLandline.Text = string.Empty;
            txtCellphoneNumber.Text = string.Empty;
            txtEmailAddress.Text = string.Empty;
            cbHomeOwnership.SelectedIndex = -1; // Reset ComboBox selection
            cbYearsOfStay.Text = string.Empty; // Reset ComboBox selection
            txtSSS.Text = string.Empty;
        }
    }
}
