using _4PH_PAGIBIG_HOUSING.Database;
using _4PH_PAGIBIG_HOUSING.DbContext;
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
    public partial class ApplicationPart6 : Form
    {

        private readonly string _pagIBIGMIDNumberRTN, _tct;
        private readonly DatabaseConnection _database = DatabaseConnection.Instance;
        private readonly RealEstateInformation _estate1 = new RealEstateInformation();
        private readonly RealEstateInformation _estate2 = new RealEstateInformation();
        private readonly RealEstateInformation _estate3 = new RealEstateInformation();



        public ApplicationPart6(string pagibigMIDNumber, string tct)
        {
            InitializeComponent();

            // Set default state for pnlMain based on the selected radio button
            SetPanelVisibility();
            _pagIBIGMIDNumberRTN = pagibigMIDNumber;
            _tct = tct;


            // Set initial visibility for entry panels and buttons
            pnlEntry2.Visible = false;
            btnCancelEntry2.Visible = false;
            pnlEntry3.Visible = false;
            btnCancelEntry3.Visible = false;



        }

        private void ApplicationPart6_Load(object sender, EventArgs e)
        {
            // Set initial state for pnlMain
            SetPanelVisibility();

            cbTypeOfProperty1.Items.AddRange(new string[] { "Real Estate Property", "Commercial Property", "Residential Property" });
            cbTypeOfProperty2.Items.AddRange(new string[] { "Real Estate Property", "Commercial Property", "Residential Property" });
            cbTypeOfProperty3.Items.AddRange(new string[] { "Real Estate Property", "Commercial Property", "Residential Property" });

        }

        private void rdbtnYES_CheckedChanged(object sender, EventArgs e)
        {
            // Show pnlMain if rdbtnYES is selected
            SetPanelVisibility();
        }

        private void rdbtnNO_CheckedChanged(object sender, EventArgs e)
        {
            // Hide pnlMain if rdbtnNO is selected
            SetPanelVisibility();
        }

        private void SetPanelVisibility()
        {
            pnlMain.Visible = rdbtnYES.Checked;
        }

        private void btnRevealEntry2_Click(object sender, EventArgs e)
        {
            pnlEntry2.Visible = true;
            btnCancelEntry2.Visible = true;
            btnRevealEntry2.Visible = false;
        }

        private void btnCancelEntry2_Click(object sender, EventArgs e)
        {
            pnlEntry2.Visible = false;
            btnCancelEntry2.Visible = false;
            btnRevealEntry2.Visible = true;
        }

        private void btnRevealEntry3_Click(object sender, EventArgs e)
        {
            pnlEntry3.Visible = true;
            btnCancelEntry3.Visible = true;
            btnRevealEntry3.Visible = false;
        }

        private void btnCancelEntry3_Click(object sender, EventArgs e)
        {
            pnlEntry3.Visible = false;
            btnCancelEntry3.Visible = false;
            btnRevealEntry3.Visible = true;
        }
        private bool ValidatePanel1()
        {
            if (!pnlEntry1.Visible) return true;

            _estate1.PAG_IBIG_MID_Number_RTN = _pagIBIGMIDNumberRTN;
            _estate1.Real_Estate_Location = txtLocation1.Text.Trim();
            _estate1.Type_of_Property = cbTypeOfProperty1.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(_estate1.Real_Estate_Location) || string.IsNullOrEmpty(_estate1.Type_of_Property))
            {
                MessageBox.Show("Location and Type of Property are required for the first real estate entry.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtCost1.Text, out decimal acquisitionCost))
            {
                MessageBox.Show("Invalid Acquisition Cost for the first real estate entry.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtMarket1.Text, out decimal marketValue))
            {
                MessageBox.Show("Invalid Market Value for the first real estate entry.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtMortgage1.Text, out decimal mortgageBalance))
            {
                MessageBox.Show("Invalid Mortgage Balance for the first real estate entry.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtRental1.Text, out decimal rentalIncome))
            {
                MessageBox.Show("Invalid Rental Income for the first real estate entry.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            _estate1.Acquisition_Cost = acquisitionCost;
            _estate1.Market_Value = marketValue;
            _estate1.Mortgage_Balance = mortgageBalance;
            _estate1.Rental_Income = rentalIncome;

            return true;
        }

        private bool ValidatePanel2()
        {
            if (!pnlEntry2.Visible) return true;

            _estate2.PAG_IBIG_MID_Number_RTN = _pagIBIGMIDNumberRTN;
            _estate2.Real_Estate_Location = txtLocation2.Text.Trim();
            _estate2.Type_of_Property = cbTypeOfProperty2.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(_estate2.Real_Estate_Location) || string.IsNullOrEmpty(_estate2.Type_of_Property))
            {
                MessageBox.Show("Location and Type of Property are required for the second real estate entry.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtCost2.Text, out decimal acquisitionCost))
            {
                MessageBox.Show("Invalid Acquisition Cost for the second real estate entry.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtMarket2.Text, out decimal marketValue))
            {
                MessageBox.Show("Invalid Market Value for the second real estate entry.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtMortgage2.Text, out decimal mortgageBalance))
            {
                MessageBox.Show("Invalid Mortgage Balance for the second real estate entry.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtRental3.Text, out decimal rentalIncome))
            {
                MessageBox.Show("Invalid Rental Income for the second real estate entry.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            _estate2.Acquisition_Cost = acquisitionCost;
            _estate2.Market_Value = marketValue;
            _estate2.Mortgage_Balance = mortgageBalance;
            _estate2.Rental_Income = rentalIncome;

            return true;
        }

        private bool ValidatePanel3()
        {
            if (!pnlEntry3.Visible) return true;

            _estate3.PAG_IBIG_MID_Number_RTN = _pagIBIGMIDNumberRTN;
            _estate3.Real_Estate_Location = txtLocation3.Text.Trim();
            _estate3.Type_of_Property = cbTypeOfProperty3.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(_estate3.Real_Estate_Location) || string.IsNullOrEmpty(_estate3.Type_of_Property))
            {
                MessageBox.Show("Location and Type of Property are required for the third real estate entry.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtCost3.Text, out decimal acquisitionCost))
            {
                MessageBox.Show("Invalid Acquisition Cost for the third real estate entry.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtMarket3.Text, out decimal marketValue))
            {
                MessageBox.Show("Invalid Market Value for the third real estate entry.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtMortgage3.Text, out decimal mortgageBalance))
            {
                MessageBox.Show("Invalid Mortgage Balance for the third real estate entry.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtRental3.Text, out decimal rentalIncome))
            {
                MessageBox.Show("Invalid Rental Income for the third real estate entry.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            _estate3.Acquisition_Cost = acquisitionCost;
            _estate3.Market_Value = marketValue;
            _estate3.Mortgage_Balance = mortgageBalance;
            _estate3.Rental_Income = rentalIncome;

            return true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Validate and insert data for Panel 1 if it's visible
            if (ValidatePanel1())
            {
                Panel1Insert();
            }

            // Validate and insert data for Panel 2 if it's visible
            if (pnlEntry2.Visible && ValidatePanel2())
            {
                Panel2Insert();
            }

            // Validate and insert data for Panel 3 if it's visible
            if (pnlEntry3.Visible && ValidatePanel3())
            {
                Panel3Insert();
            }

            // Notify the user of success
            MessageBox.Show("Real estate information saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Proceed to the next part of the application
            ApplicationPart7 loaninfo = new ApplicationPart7(_pagIBIGMIDNumberRTN, _tct);
            loaninfo.Show();
            this.Hide();
        }



        private bool Panel1Insert()
        {
            // Implementation for inserting _estate1 into the database
            string query = $"INSERT INTO REAL_ESTATE_INFORMATION (PAG_IBIG_MID_Number_RTN, Real_Estate_Location, Type_of_Property, Acquisition_Cost, Market_Value, Mortgage_Balance, Rental_Income) VALUES ('{_estate1.PAG_IBIG_MID_Number_RTN}', '{_estate1.Real_Estate_Location}', '{_estate1.Type_of_Property}', {_estate1.Acquisition_Cost}, {_estate1.Market_Value}, {_estate1.Mortgage_Balance}, {_estate1.Rental_Income})";
            return _database.ExecuteNonQuery(query);
        }

        private bool Panel2Insert()
        {
            // Implementation for inserting _estate2 into the database
            string query = $"INSERT INTO REAL_ESTATE_INFORMATION (PAG_IBIG_MID_Number_RTN, Real_Estate_Location, Type_of_Property, Acquisition_Cost, Market_Value, Mortgage_Balance, Rental_Income) VALUES ('{_estate2.PAG_IBIG_MID_Number_RTN}', '{_estate2.Real_Estate_Location}', '{_estate2.Type_of_Property}', {_estate2.Acquisition_Cost}, {_estate2.Market_Value}, {_estate2.Mortgage_Balance}, {_estate2.Rental_Income})";
            return _database.ExecuteNonQuery(query);
        }

        private bool Panel3Insert()
        {
            // Implementation for inserting _estate3 into the database
            string query = $"INSERT INTO REAL_ESTATE_INFORMATION (PAG_IBIG_MID_Number_RTN, Real_Estate_Location, Type_of_Property, Acquisition_Cost, Market_Value, Mortgage_Balance, Rental_Income) VALUES ('{_estate3.PAG_IBIG_MID_Number_RTN}', '{_estate3.Real_Estate_Location}', '{_estate3.Type_of_Property}', {_estate3.Acquisition_Cost}, {_estate3.Market_Value}, {_estate3.Mortgage_Balance}, {_estate3.Rental_Income})";
            return _database.ExecuteNonQuery(query);
        }
    }
}
