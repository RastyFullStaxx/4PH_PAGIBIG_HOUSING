using _4PH_PAGIBIG_HOUSING.Database;
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
    public partial class Ab_Moderate_SQL_Problems : Form
    {
        public Ab_Moderate_SQL_Problems()
        {
            InitializeComponent();
        }

        private void btnSimple_Click(object sender, EventArgs e)
        {
            Ab_Easy_SQL_Problems ab_Easy_SQL_Problems = new Ab_Easy_SQL_Problems();
            ab_Easy_SQL_Problems.Show();
            this.Close();
        }

        private void btnModerate_Click(object sender, EventArgs e)
        {
            Ab_Moderate_SQL_Problems ab_Moderate_SQL_Problems = new Ab_Moderate_SQL_Problems();
            ab_Moderate_SQL_Problems.Show();
            this.Close();
        }

        private void btnDifficult_Click(object sender, EventArgs e)
        {
            Ab_Difficult_SQL_Problems ab_Difficult_SQL_Problems = new Ab_Difficult_SQL_Problems();
            ab_Difficult_SQL_Problems.Show();
            this.Close();
        }

        private void btnBacktoDashboard_Click(object sender, EventArgs e)
        {
            Administration_Dashboard administration_Dashboard = new Administration_Dashboard();
            administration_Dashboard.Show();
            this.Close();
        }

        private void Ab_Moderate_SQL_Problems_Load(object sender, EventArgs e)
        {
            dgModerateProblem1.RowTemplate.Height = 40; // Adjust the height as needed
            dgModerateProblem1.Size = new Size(836, 243);
            dgModerateProblem2.RowTemplate.Height = 40; // Adjust the height as needed
            dgModerateProblem2.Size = new Size(836, 243); 
            dgModerateProblem3.RowTemplate.Height = 40; // Adjust the height as needed
            dgModerateProblem3.Size = new Size(836, 243); 
            dgModerateProblem4.RowTemplate.Height = 40; // Adjust the height as needed
            dgModerateProblem4.Size = new Size(836, 243);
            CustomizeDataGridView(dgModerateProblem1);
            CustomizeDataGridView(dgModerateProblem2);
            CustomizeDataGridView(dgModerateProblem3);
            CustomizeDataGridView(dgModerateProblem4);

            LoadEmployeeCountData();
            LoadLargestBalanceData();
            LoadAverageLoanData();
            LoadLoanAmountData(); 

        }

        private void LoadEmployeeCountData()
        {
            string query = @"
                SELECT Count(*) as Employee_Count, Employer_Business_Name 
                FROM borrowers_employment_information
                WHERE No_of_Dependents > 0
                GROUP BY Employer_Business_Name";
            DataSet dataSet = DatabaseConnection.Instance.ExecuteQuery(query);

            if (dataSet != null && dataSet.Tables.Count > 0)
            {
                dgModerateProblem1.DataSource = dataSet.Tables[0];
            }
        }




        private void LoadLargestBalanceData()
        {
            string query = @"
                SELECT MAX(Ave_Balance) as Largest_Balance, Type_of_Account, Bank 
                FROM banking_information
                GROUP BY Type_of_Account, Bank
                ORDER BY MAX(Ave_Balance)";
            DataSet dataSet = DatabaseConnection.Instance.ExecuteQuery(query);

            if (dataSet != null && dataSet.Tables.Count > 0)
            {
                dgModerateProblem2.DataSource = dataSet.Tables[0];
            }
        }
        private void LoadAverageLoanData()
        {
            string query = @"
                SELECT AVG(Loan_Amount) as Average_Loan, Mode_of_Payment 
                FROM 4ps_housing_loan_information
                WHERE Loan_Term > 13
                GROUP BY Mode_of_Payment
                HAVING AVG(Loan_Amount) > 300000";
            DataSet dataSet = DatabaseConnection.Instance.ExecuteQuery(query);

            if (dataSet != null && dataSet.Tables.Count > 0)
            {
                dgModerateProblem3.DataSource = dataSet.Tables[0];
            }
        }

        private void LoadLoanAmountData()
        {
            string query = @"
                SELECT MIN(Amount_Balance) as Smallest_Loan, 
                       MAX(Amount_Balance) as Largest_Loan, 
                       SUM(Amount_Balance) as Total_Loan, 
                       PAG_IBIG_MID_Number_RTN 
                FROM loan_information
                GROUP BY PAG_IBIG_MID_Number_RTN
                HAVING COUNT(PAG_IBIG_MID_Number_RTN) > 1";
            DataSet dataSet = DatabaseConnection.Instance.ExecuteQuery(query);

            if (dataSet != null && dataSet.Tables.Count > 0)
            {
                dgModerateProblem4.DataSource = dataSet.Tables[0];
            }
        }


        private void CustomizeDataGridView(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // or another option if needed
            dgv.BorderStyle = BorderStyle.None;
            dgv.BackgroundColor = Color.White;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToOrderColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 11);
            dgv.ScrollBars = ScrollBars.Both;

            // Set header style
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            // Set alternating row colors
            dgv.RowsDefaultCellStyle.BackColor = Color.White;
            dgv.RowsDefaultCellStyle.ForeColor = Color.Black;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            // Modern appearance
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
        }
    }
}
