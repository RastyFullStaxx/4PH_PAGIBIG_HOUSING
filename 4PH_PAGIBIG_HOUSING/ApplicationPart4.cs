using _4PH_PAGIBIG_HOUSING.Database;
using _4PH_PAGIBIG_HOUSING.DbContext;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace _4PH_PAGIBIG_HOUSING
{
    public partial class ApplicationPart4 : Form
    {
        private readonly string _pagIBIGMIDNumberRTN;
        private readonly long _SSSNumber; // Changed to long for numeric SSS ID
        private readonly DatabaseConnection database = DatabaseConnection.GetInstance();
        private readonly BorrowersEmploymentInformation employmentinfo = new BorrowersEmploymentInformation();

        public ApplicationPart4(string pagIBIGMIDNumberRTN, string SSSNumber)
        {
            InitializeComponent();
            _pagIBIGMIDNumberRTN = pagIBIGMIDNumberRTN;

            // Parse SSSNumber as a long
            if (!long.TryParse(SSSNumber, out _SSSNumber))
            {
                throw new ArgumentException("Invalid SSS number format.");
            }

            txtGSIS.Text = SSSNumber; // Display SSS number in the text box
        }

        private void btnSaveEmployment_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (!ValidateInputs())
            {
                return;
            }

            // Populate employmentinfo object with form data
            employmentinfo.EE_SSS_GSIS_ID_No = _SSSNumber.ToString(); // Store as string in the object
            employmentinfo.Employer_Business_Name = txtEmployerName.Text;
            employmentinfo.Employer_Business_Address = txtEmployerAddress.Text;
            employmentinfo.Employer_Direct_Line = txtEmployerDirectLine.Text;
            employmentinfo.Employer_Trunk_Line = txtEmployerTrunkLine.Text;
            employmentinfo.Employer_Email_Address = txtEmailAddress.Text;
            employmentinfo.Occupation = txtOccupation.Text;
            employmentinfo.TIN = txtTIN.Text;
            employmentinfo.Position_Department = txtPosition.Text;

            if (!int.TryParse(cbYearsInBusiness.Text, out int yearsInEmployment))
            {
                MessageBox.Show("Invalid years in employment value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            employmentinfo.Years_in_Business_Employment = yearsInEmployment;

            if (!int.TryParse(cbDependents.Text, out int numOfDependents))
            {
                MessageBox.Show("Invalid number of dependents value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            employmentinfo.No_of_Dependents = numOfDependents;

            bool savedSuccessfully = SaveBorrowersEmploymentInformation(employmentinfo);
            if (savedSuccessfully)
            {
                MessageBox.Show("Employment information saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearEmploymentForm();
            }
            else
            {
                MessageBox.Show("Failed to save employment information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputs()
        {
            // Numeric validators
            if (!IsNumeric(txtGSIS.Text))
            {
                MessageBox.Show("GSIS/SSS number must be numeric.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!IsNumeric(cbYearsInBusiness.Text))
            {
                MessageBox.Show("Years in business must be numeric.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!IsNumeric(cbDependents.Text))
            {
                MessageBox.Show("Number of dependents must be numeric.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Text validators
            if (!IsText(txtEmployerName.Text))
            {
                MessageBox.Show("Employer name must be text.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!IsText(txtEmployerAddress.Text))
            {
                MessageBox.Show("Employer address must be text.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!IsText(txtEmployerDirectLine.Text))
            {
                MessageBox.Show("Employer direct line must be text.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!IsText(txtEmployerTrunkLine.Text))
            {
                MessageBox.Show("Employer trunk line must be text.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!IsEmail(txtEmailAddress.Text))
            {
                MessageBox.Show("Invalid email address format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!IsText(txtOccupation.Text))
            {
                MessageBox.Show("Occupation must be text.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!IsText(txtPosition.Text))
            {
                MessageBox.Show("Position must be text.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Range validators
            if (!IsInRange(cbYearsInBusiness.Text, 0, 99))
            {
                MessageBox.Show("Years in business must be between 0 and 99.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!IsInRange(cbDependents.Text, 0, 99))
            {
                MessageBox.Show("Number of dependents must be between 0 and 99.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Length validators
            if (txtTIN.Text.Length > 20)
            {
                MessageBox.Show("TIN must be at most 20 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool IsEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsNumeric(string value)
        {
            return long.TryParse(value, out _);
        }

        private bool IsText(string value)
        {
            return !string.IsNullOrWhiteSpace(value);
        }

        private bool IsInRange(string value, int minValue, int maxValue)
        {
            if (int.TryParse(value, out int number))
            {
                return number >= minValue && number <= maxValue;
            }
            return false;
        }

        private bool SaveBorrowersEmploymentInformation(BorrowersEmploymentInformation employmentInfo)
        {
            // Use your DatabaseConnection class to get a database connection
            using (var connection = database.GetConnection())
            {
                try
                {
                    connection.Open();
                    // Example SQL command to insert employment information into the database
                    string sql = "INSERT INTO BORROWERS_EMPLOYMENT_INFORMATION (EE_SSS_GSIS_ID_No, Employer_Business_Name, Employer_Business_Address, " +
                                 "Employer_Direct_Line, Employer_Trunk_Line, Employer_Email_Address, Occupation, TIN, Position_Department, " +
                                 "Years_in_Business_Employment, No_of_Dependents) " +
                                 "VALUES (@EE_SSS_GSIS_ID_No, @Employer_Business_Name, @Employer_Business_Address, @Employer_Direct_Line, " +
                                 "@Employer_Trunk_Line, @Employer_Email_Address, @Occupation, @TIN, @Position_Department, " +
                                 "@Years_in_Business_Employment, @No_of_Dependents)";

                    using (var cmd = new MySqlCommand(sql, connection))
                    {
                        // Add parameters to the SQL command
                        cmd.Parameters.AddWithValue("@EE_SSS_GSIS_ID_No", employmentInfo.EE_SSS_GSIS_ID_No);
                        cmd.Parameters.AddWithValue("@Employer_Business_Name", employmentInfo.Employer_Business_Name);
                        cmd.Parameters.AddWithValue("@Employer_Business_Address", employmentInfo.Employer_Business_Address);
                        cmd.Parameters.AddWithValue("@Employer_Direct_Line", employmentInfo.Employer_Direct_Line);
                        cmd.Parameters.AddWithValue("@Employer_Trunk_Line", employmentInfo.Employer_Trunk_Line);
                        cmd.Parameters.AddWithValue("@Employer_Email_Address", employmentInfo.Employer_Email_Address);
                        cmd.Parameters.AddWithValue("@Occupation", employmentInfo.Occupation);
                        cmd.Parameters.AddWithValue("@TIN", employmentInfo.TIN);
                        cmd.Parameters.AddWithValue("@Position_Department", employmentInfo.Position_Department);
                        cmd.Parameters.AddWithValue("@Years_in_Business_Employment", employmentInfo.Years_in_Business_Employment);
                        cmd.Parameters.AddWithValue("@No_of_Dependents", employmentInfo.No_of_Dependents);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving employment information: {ex.Message}");
                    return false;
                }
            }
        }

        private void ClearEmploymentForm()
        {
            // Clear all text boxes or fields related to employment info
            txtEmployerName.Text = string.Empty;
            txtEmployerAddress.Text = string.Empty;
            txtEmployerDirectLine.Text = string.Empty;
            txtEmployerTrunkLine.Text = string.Empty;
            txtEmailAddress.Text = string.Empty;
            txtOccupation.Text = string.Empty;
            txtTIN.Text = string.Empty;
            txtPosition.Text = string.Empty;
            cbYearsInBusiness.Text = string.Empty;
            cbDependents.Text = string.Empty;
        }

        private void ApplicationPart4_Load(object sender, EventArgs e)
        {
            // Load any initial data or perform actions when the form loads
        }
    }
}
