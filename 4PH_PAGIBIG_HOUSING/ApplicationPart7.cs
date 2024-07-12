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
    public partial class ApplicationPart7 : Form
    {
        private readonly string _pagIBIGMIDNumberRTN, _tct;
        private readonly DatabaseConnection _database = DatabaseConnection.Instance;
        private readonly LoanInformation _loaninfo1 = new LoanInformation();
        private readonly LoanInformation _loaninfo2 = new LoanInformation();
        private readonly LoanInformation _loaninfo3 = new LoanInformation();

        public ApplicationPart7(string pagibigNumber, string tct)
        {
            InitializeComponent();
            _pagIBIGMIDNumberRTN = pagibigNumber;
            _tct = tct;
            btnRevealEntry2.Visible = true;
            btnRevealEntry3.Visible = true;
        }

        private void ApplicationPart7_Load(object sender, EventArgs e)
        {

            cbTypeofLoan1.Items.AddRange(new string[] { "Mortgage Loan", "Auto Loan", "Personal Loan" });
            cbTypeofLoan2.Items.AddRange(new string[] { "Mortgage Loan", "Auto Loan", "Personal Loan" });
            cbTypeofLoan3.Items.AddRange(new string[] { "Mortgage Loan", "Auto Loan", "Personal Loan" });


            cbSecurityType1.Items.AddRange(new string[] { "Property", "Vehicle", "Savings" });
            cbSecurityType2.Items.AddRange(new string[] { "Property", "Vehicle", "Savings" });
            cbSecurityType3.Items.AddRange(new string[] { "Property", "Vehicle", "Savings" });



            pnlEntry2.Visible = false;
            pnlEntry3.Visible = false;
            btnRevealEntry2.Visible = true;
            btnRevealEntry3.Visible = true;
            btnCancelEntry2.Visible = false;
            btnCancelEntry3.Visible = false;
        }

        private void btnRevealEntry2_Click(object sender, EventArgs e)
        {
            // Show pnlEntry2 and btnCancelEntry2, hide btnRevealEntry2
            pnlEntry2.Visible = true;
            btnCancelEntry2.Visible = true;
            btnRevealEntry2.Visible = false;
            btnRevealEntry3 .Visible = true;
        }

        private void btnCancelEntry2_Click(object sender, EventArgs e)
        {
            // Hide pnlEntry2 and btnCancelEntry2, show btnRevealEntry2
            pnlEntry2.Visible = false;
            btnCancelEntry2.Visible = false;
            btnRevealEntry2.Visible = true;
        }

        private void btnCancelEntry3_Click(object sender, EventArgs e)
        {
            // Hide pnlEntry3 and btnCancelEntry3, show btnRevealEntry3
            pnlEntry3.Visible = false;
            btnCancelEntry3.Visible = false;
            btnRevealEntry3.Visible = true;
        }
        private void btnRevealEntry3_Click(object sender, EventArgs e)
        {
            // Show pnlEntry3 and btnCancelEntry3, hide btnRevealEntry3
            pnlEntry3.Visible = true;
            btnCancelEntry3.Visible = true;
            btnRevealEntry3.Visible = false;
        }



        private void btnNext_Click(object sender, EventArgs e)
        {
            // Validate and insert data for Panel 1 if it's visible
            if (pnlEntry1.Visible && ValidatePanel1())
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
            MessageBox.Show("Loan information saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            OverlayForm overlay = new OverlayForm(this);
            overlay.Show();
            Overview overview = new Overview();
            overview.FormClosed += (s, args) => overlay.Close(); // Close overlay when overview is closed
            overview.ShowDialog();
        }


        private bool ValidatePanel1()
        {
            if (!pnlEntry1.Visible) return true;

            _loaninfo1.PAG_IBIG_MID_Number_RTN = _pagIBIGMIDNumberRTN;
            _loaninfo1.Type = cbTypeofLoan1.SelectedItem?.ToString();
            _loaninfo1.Security = cbSecurityType1.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(_loaninfo1.Type) || string.IsNullOrEmpty(_loaninfo1.Security))
            {
                MessageBox.Show("Type of Loan and Security Type are required for the first loan entry.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!DateTime.TryParse(dtMaturityDate1.Text, out DateTime maturityDate))
            {
                MessageBox.Show("Invalid Maturity Date for the first loan entry.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtBalance1.Text, out decimal amountBalance))
            {
                MessageBox.Show("Invalid Amount Balance for the first loan entry.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(txtAmortization1.Text))
            {
                MessageBox.Show("Monthly Amortization is required for the first loan entry.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            _loaninfo1.Maturity_Date = maturityDate;
            _loaninfo1.Amount_Balance = amountBalance;
            _loaninfo1.Mo_Amortization = txtAmortization1.Text.Trim();

            return true;
        }

        private bool ValidatePanel2()
        {
            if (!pnlEntry2.Visible) return true;

            _loaninfo2.PAG_IBIG_MID_Number_RTN = _pagIBIGMIDNumberRTN;
            _loaninfo2.Type = cbTypeofLoan2.SelectedItem?.ToString();
            _loaninfo2.Security = cbSecurityType2.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(_loaninfo2.Type) || string.IsNullOrEmpty(_loaninfo2.Security))
            {
                MessageBox.Show("Type of Loan and Security Type are required for the second loan entry.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!DateTime.TryParse(dtMaturityDate2.Text, out DateTime maturityDate))
            {
                MessageBox.Show("Invalid Maturity Date for the second loan entry.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtBalance2.Text, out decimal amountBalance))
            {
                MessageBox.Show("Invalid Amount Balance for the second loan entry.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(txtAmortization2.Text))
            {
                MessageBox.Show("Monthly Amortization is required for the second loan entry.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            _loaninfo2.Maturity_Date = maturityDate;
            _loaninfo2.Amount_Balance = amountBalance;
            _loaninfo2.Mo_Amortization = txtAmortization2.Text.Trim();

            return true;
        }

        private bool ValidatePanel3()
        {
            if (!pnlEntry3.Visible) return true;

            _loaninfo3.PAG_IBIG_MID_Number_RTN = _pagIBIGMIDNumberRTN;
            _loaninfo3.Type = cbTypeofLoan3.SelectedItem?.ToString();
            _loaninfo3.Security = cbSecurityType3.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(_loaninfo3.Type) || string.IsNullOrEmpty(_loaninfo3.Security))
            {
                MessageBox.Show("Type of Loan and Security Type are required for the third loan entry.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!DateTime.TryParse(dtMaturityDate3.Text, out DateTime maturityDate))
            {
                MessageBox.Show("Invalid Maturity Date for the third loan entry.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtBalance3.Text, out decimal amountBalance))
            {
                MessageBox.Show("Invalid Amount Balance for the third loan entry.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(txtAmortization3.Text))
            {
                MessageBox.Show("Monthly Amortization is required for the third loan entry.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            _loaninfo3.Maturity_Date = maturityDate;
            _loaninfo3.Amount_Balance = amountBalance;
            _loaninfo3.Mo_Amortization = txtAmortization3.Text.Trim();

            return true;
        }



        private bool Panel1Insert()
        {
            // Implementation for inserting _loaninfo1 into the database
            string query = $"INSERT INTO LOAN_INFORMATION (PAG_IBIG_MID_Number_RTN, Type, Security, Maturity_Date, Amount_Balance, Mo_Amortization) VALUES ('{_loaninfo1.PAG_IBIG_MID_Number_RTN}', '{_loaninfo1.Type}', '{_loaninfo1.Security}', '{_loaninfo1.Maturity_Date.ToString("yyyy-MM-dd")}', {_loaninfo1.Amount_Balance}, '{_loaninfo1.Mo_Amortization}')";
            return _database.ExecuteNonQuery(query);
        }

        private bool Panel2Insert()
        {
            // Implementation for inserting _loaninfo2 into the database
            string query = $"INSERT INTO LOAN_INFORMATION (PAG_IBIG_MID_Number_RTN, Type, Security, Maturity_Date, Amount_Balance, Mo_Amortization) VALUES ('{_loaninfo2.PAG_IBIG_MID_Number_RTN}', '{_loaninfo2.Type}', '{_loaninfo2.Security}', '{_loaninfo2.Maturity_Date.ToString("yyyy-MM-dd")}', {_loaninfo2.Amount_Balance}, '{_loaninfo2.Mo_Amortization}')";
            return _database.ExecuteNonQuery(query);
        }

        private bool Panel3Insert()
        {
            // Implementation for inserting _loaninfo3 into the database
            string query = $"INSERT INTO LOAN_INFORMATION (PAG_IBIG_MID_Number_RTN, Type, Security, Maturity_Date, Amount_Balance, Mo_Amortization) VALUES ('{_loaninfo3.PAG_IBIG_MID_Number_RTN}', '{_loaninfo3.Type}', '{_loaninfo3.Security}', '{_loaninfo3.Maturity_Date.ToString("yyyy-MM-dd")}', {_loaninfo3.Amount_Balance}, '{_loaninfo3.Mo_Amortization}')";
            return _database.ExecuteNonQuery(query);
        }



    }
}
