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
    public partial class ApplicationPart1 : Form
    {
        public ApplicationPart1()
        {
            InitializeComponent();
        }

        private void ApplicationPart1_Load(object sender, EventArgs e)
        {
             
        }

        private void lblMID_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnPersonalInfo_Click(object sender, EventArgs e)
        {
            ApplicationPart1 applicationPart1 = new ApplicationPart1();
            applicationPart1.Show();
            this.Dispose();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ApplicationPart2 applicationPart2 = new ApplicationPart2();
            applicationPart2.Show();
            this.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
