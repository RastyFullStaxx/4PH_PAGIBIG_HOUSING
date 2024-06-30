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
    public partial class ApplicationPart2 : Form
    {
        public ApplicationPart2()
        {
            InitializeComponent();
        }

        private void btnPersonalInfo_Click(object sender, EventArgs e)
        {
            ApplicationPart1 applicationPart1 = new ApplicationPart1();
            applicationPart1.Show();
            this.Dispose();
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            ApplicationPart2 applicationPart2 = new ApplicationPart2();
            applicationPart2.Show();
            this.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
