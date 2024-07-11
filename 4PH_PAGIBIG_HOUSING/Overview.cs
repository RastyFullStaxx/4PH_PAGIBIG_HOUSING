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
    public partial class Overview : Form
    {
        public Overview()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel38_Click(object sender, EventArgs e)
        {

        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Submission_Success submission_Success = new Submission_Success();
            submission_Success.Show();
        }
    }
}
