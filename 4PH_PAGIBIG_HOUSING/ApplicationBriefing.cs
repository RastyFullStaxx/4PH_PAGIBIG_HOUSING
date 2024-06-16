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
    public partial class ApplicationBriefing : Form
    {
        public ApplicationBriefing()
        {
            InitializeComponent();
        }

        private void ApplicationBriefing_Load(object sender, EventArgs e)
        {

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            ApplicationPart1 applicationPart1 = new ApplicationPart1();
            applicationPart1.Show();
            this.Hide();
        }
    }
}
