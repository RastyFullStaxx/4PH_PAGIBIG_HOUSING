using _4PH_PAGIBIG_HOUSING.Database;
using _4PH_PAGIBIG_HOUSING.DbContext;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace _4PH_PAGIBIG_HOUSING
{
    public partial class ApplicationPart3 : Form
    {
        private readonly DatabaseConnection database = DatabaseConnection.GetInstance();
        private readonly CollateralInformation collateral = new CollateralInformation();
        private readonly string _pagIBIGMIDNumberRTN;

        public ApplicationPart3(string pagIBIGNumber)
        {
            InitializeComponent();
            _pagIBIGMIDNumberRTN = pagIBIGNumber;
        }

        public string GetTCT()
        {
            return txtTCT.Text; // Return TCT value
        }

        private void btnSaveCollateral_Click(object sender, EventArgs e)
        {
            string tct  = GetTCT();
            if (ValidateInputs())
            {
                // Populate collateral object with form data
                collateral.PAG_IBIG_MID_Number_RTN = _pagIBIGMIDNumberRTN;
                collateral.TCT_OCT_CCT_No = txtTCT.Text;
                collateral.Property_Location = cbPropertyLocation.Text;
                collateral.Type_of_Property = cbTypeOfProperty.Text;
                collateral.Name_of_Project = txtNameOfProperty.Text;

                if (!int.TryParse(txtTaxDeclarationNo.Text, out int taxDeclaration))
                {
                    MessageBox.Show("Tax declaration must be a numeric value with 6 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                collateral.Tax_Declaration = taxDeclaration;

                if (!int.TryParse(txtLandAreaMeasurement.Text, out int landArea))
                {
                    MessageBox.Show("Land area must be a numeric value with 5 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                collateral.Land_Area = landArea;

                collateral.Lot_Unit_No = txtLotNo.Text;
                collateral.Block_Bldg_No = txtBlockNo.Text;

                bool savedSuccessfully = SaveCollateralInformation(collateral);
                if (savedSuccessfully)
                {
                    ApplicationPart2 loanInfo = new ApplicationPart2(_pagIBIGMIDNumberRTN, tct);
                    loanInfo.Show();
                    this.Hide();
                      ClearCollateralForm();
                }
                else
                {
                    MessageBox.Show("Failed to save collateral information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateInputs()
        {
            // Text validators
            if (!IsText(txtNameOfProperty.Text))
            {
                MessageBox.Show("Name of property must be text.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!IsText(cbPropertyLocation.Text))
            {
                MessageBox.Show("Property location must be text.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!IsText(txtLotNo.Text))
            {
                MessageBox.Show("Lot/unit number must be text.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!IsText(txtBlockNo.Text))
            {
                MessageBox.Show("Block/building number must be text.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!IsNumeric(txtTaxDeclarationNo.Text) || txtTaxDeclarationNo.Text.Length != 6)
            {
                MessageBox.Show("Tax declaration must be a numeric value with 6 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!IsNumeric(txtLandAreaMeasurement.Text) || txtLandAreaMeasurement.Text.Length != 5)
            {
                MessageBox.Show("Land area must be a numeric value with 5 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool IsText(string text)
        {
            return !string.IsNullOrWhiteSpace(text);
        }

        private bool IsNumeric(string text)
        {
            return int.TryParse(text, out _);
        }

        private bool SaveCollateralInformation(CollateralInformation collateralInfo)
        {
            using (var connection = database.GetConnection())
            {
                try
                {
                    connection.Open();
                    string sql = "INSERT INTO COLLATERAL_INFORMATION (Pag_IBIG_MID_Number_RTN, TCT_OCT_CCT_No, Property_Location, Type_of_Property, " +
                                 "Name_of_Project, Tax_Declaration, Land_Area, Lot_Unit_No, Block_Bldg_No) " +
                                 "VALUES (@Pag_IBIG_MID_Number_RTN, @TCT_OCT_CCT_No, @Property_Location, @Type_of_Property, " +
                                 "@Name_of_Project, @Tax_Declaration, @Land_Area, @Lot_Unit_No, @Block_Bldg_No)";

                    using (var cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@Pag_IBIG_MID_Number_RTN", collateralInfo.PAG_IBIG_MID_Number_RTN);
                        cmd.Parameters.AddWithValue("@TCT_OCT_CCT_No", collateralInfo.TCT_OCT_CCT_No);
                        cmd.Parameters.AddWithValue("@Property_Location", collateralInfo.Property_Location);
                        cmd.Parameters.AddWithValue("@Type_of_Property", collateralInfo.Type_of_Property);
                        cmd.Parameters.AddWithValue("@Name_of_Project", collateralInfo.Name_of_Project);
                        cmd.Parameters.AddWithValue("@Tax_Declaration", collateralInfo.Tax_Declaration);
                        cmd.Parameters.AddWithValue("@Land_Area", collateralInfo.Land_Area);
                        cmd.Parameters.AddWithValue("@Lot_Unit_No", collateralInfo.Lot_Unit_No);
                        cmd.Parameters.AddWithValue("@Block_Bldg_No", collateralInfo.Block_Bldg_No);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving collateral information: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private void ClearCollateralForm()
        {
            txtNameOfProperty.Text = string.Empty;
            txtTaxDeclarationNo.Text = string.Empty;
            cbTypeOfProperty.SelectedIndex = -1;
            cbPropertyLocation.Text = string.Empty;
            txtLotNo.Text = string.Empty;
            txtBlockNo.Text = string.Empty;
            txtTCT.Text = string.Empty;
            txtLandAreaMeasurement.Text = string.Empty;
        }
        private void ApplicationPart3_Load(object sender, EventArgs e)
        {

        }
    }
}
