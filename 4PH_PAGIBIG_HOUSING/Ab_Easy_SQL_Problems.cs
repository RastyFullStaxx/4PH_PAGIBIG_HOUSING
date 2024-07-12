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
    }
}
