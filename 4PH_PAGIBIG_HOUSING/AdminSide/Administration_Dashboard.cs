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
    public partial class Administration_Dashboard : Form
    {
        public Administration_Dashboard()
        {
            InitializeComponent();
        }

        private void Administration_Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnSQLProblems_Click(object sender, EventArgs e)
        {
            Ab_Easy_SQL_Problems ab_SQL_Problems = new Ab_Easy_SQL_Problems();
            ab_SQL_Problems.Show();
            this.Hide();
        }
    }
}
