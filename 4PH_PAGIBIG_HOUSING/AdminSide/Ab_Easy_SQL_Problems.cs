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
    public partial class Ab_Easy_SQL_Problems : Form
    {
        public Ab_Easy_SQL_Problems()
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

        private void Ab_Easy_SQL_Problems_Load(object sender, EventArgs e)
        {
            dgEasyProblem1.RowTemplate.Height = 40; // Adjust the height as needed
            dgEasyProblem1.Size = new Size(836, 243);
            dgEasyProblem2.RowTemplate.Height = 40; // Adjust the height as needed
            dgEasyProblem2.Size = new Size(836, 243);
            dgEasyProblem3.RowTemplate.Height = 40; // Adjust the height as needed
            dgEasyProblem3.Size = new Size(836, 243);


            LoadLoanData();
            LoadBorrowerData();
            LoadCollateralData();
            CustomizeDataGridView(dgEasyProblem1);
            CustomizeDataGridView(dgEasyProblem2);
            CustomizeDataGridView(dgEasyProblem3);


        }
        private void LoadLoanData()
        {
            string query = "SELECT * FROM 4ps_housing_loan_information WHERE Loan_Amount > 300000";
            DataSet dataSet = DatabaseConnection.Instance.ExecuteQuery(query);

            if (dataSet != null && dataSet.Tables.Count > 0)
            {
                dgEasyProblem1.DataSource = dataSet.Tables[0];
            }
        }

        private void LoadBorrowerData()
        {
            string query = @"
                SELECT * FROM borrower_information
                WHERE Permanent_Address LIKE '%Manila%'
                ORDER BY Years_of_Stay";
            DataSet dataSet = DatabaseConnection.Instance.ExecuteQuery(query);

            if (dataSet != null && dataSet.Tables.Count > 0)
            {
                dgEasyProblem2.DataSource = dataSet.Tables[0];
            }
        }

        private void LoadCollateralData()
        {
            string query = "SELECT * FROM collateral_information ORDER BY Land_Area DESC";
            DataSet dataSet = DatabaseConnection.Instance.ExecuteQuery(query);

            if (dataSet != null && dataSet.Tables.Count > 0)
            {
                dgEasyProblem3.DataSource = dataSet.Tables[0];
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
