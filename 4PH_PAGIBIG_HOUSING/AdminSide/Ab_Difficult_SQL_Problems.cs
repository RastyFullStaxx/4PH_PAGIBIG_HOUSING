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
using MySql.Data.MySqlClient;


namespace _4PH_PAGIBIG_HOUSING
{
    public partial class Ab_Difficult_SQL_Problems : Form
    {
        public Ab_Difficult_SQL_Problems()
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

        private void Ab_Difficult_SQL_Problems_Load(object sender, EventArgs e)
        {
            dgDifficultProblem1.RowTemplate.Height = 40; // Adjust the height as needed
            dgDifficultProblem1.Size = new Size(1260, 243);
            dgDifficultProblem2.RowTemplate.Height = 40; // Adjust the height as needed
            dgDifficultProblem2.Size = new Size(1260, 243);
            dgDifficultProblem3.RowTemplate.Height = 40; // Adjust the height as needed
            dgDifficultProblem3.Size = new Size(1260, 243);

            CustomizeDataGridView(dgDifficultProblem1);
            CustomizeDataGridView(dgDifficultProblem2);
            CustomizeDataGridView(dgDifficultProblem3);


            LoadBorrowerLoanData();
            LoadComplexData();
            LoadEmploymentData();
        }
        private void LoadBorrowerLoanData()
        {
            string query = @"
    SELECT Borrower.*, House.* 
    FROM `4ps_housing_loan_information` AS House
    JOIN borrower_information AS Borrower 
    ON House.PAG_IBIG_MID_Number_RTN = Borrower.Pag_IBIG_MID_Number_RTN 
    WHERE Borrower.Sex = 'F' 
    AND TIMESTAMPDIFF(YEAR, Borrower.Birthdate, CURDATE()) >= 40
    ORDER BY Borrower.Birthdate";

            DataSet dataSet = DatabaseConnection.Instance.ExecuteQuery(query);

            if (dataSet != null && dataSet.Tables.Count > 0)
            {
                dgDifficultProblem1.DataSource = dataSet.Tables[0];
            }
            else
            {
                MessageBox.Show("No data returned from the query.");
            }
        }

        private void LoadComplexData()
        {
            string query = @"
    SELECT House.*, Borrow.*, Estate.*, Loan.* 
    FROM 4ps_housing_loan_information AS House, 
         borrower_information AS Borrow, 
         real_estate_information AS Estate, 
         loan_information AS Loan
    WHERE House.PAG_IBIG_MID_Number_RTN = Borrow.PAG_IBIG_MID_Number_RTN 
      AND House.PAG_IBIG_MID_Number_RTN = Estate.PAG_IBIG_MID_Number_RTN 
      AND House.PAG_IBIG_MID_Number_RTN = Loan.PAG_IBIG_MID_Number_RTN
    GROUP BY House.PAG_IBIG_MID_Number_RTN, House.TCT_OCT_CCT_NO, House.Loan_Amount, Loan_Term, Mode_of_Payment
    ORDER BY House.PAG_IBIG_MID_Number_RTN";

            DataSet dataSet = DatabaseConnection.Instance.ExecuteQuery(query);

            if (dataSet != null && dataSet.Tables.Count > 0)
            {
                dgDifficultProblem2.DataSource = dataSet.Tables[0];
            }
            else
            {
                MessageBox.Show("No data returned from the query.");
            }
        }

        private void LoadEmploymentData()
        {
            string query = @"
    SELECT Borrower.*, Employment.Years_in_Business_Employment
    FROM borrower_information AS Borrower
    JOIN borrowers_employment_information AS Employment
    ON Borrower.EE_SSS_GSIS_ID_No = Employment.EE_SSS_GSIS_ID_No
    WHERE Employment.Years_in_Business_Employment > Borrower.Years_of_Stay";

            DataSet dataSet = DatabaseConnection.Instance.ExecuteQuery(query);

            if (dataSet != null && dataSet.Tables.Count > 0)
            {
                dgDifficultProblem3.DataSource = dataSet.Tables[0];
            }
            else
            {
                MessageBox.Show("No data returned from the query.");
            }
        }



        private void CustomizeDataGridView(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
