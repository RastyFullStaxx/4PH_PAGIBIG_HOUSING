using System;
using System.Drawing;
using System.Windows.Forms;

namespace _4PH_PAGIBIG_HOUSING
{
    public partial class A_Launch : Form
    {
        public A_Launch()
        {
            InitializeComponent();
        }

        private void A_Launch_Load(object sender, EventArgs e)
        {

        }
        private void btnApply_Click(object sender, EventArgs e)
        {
            // Show the loading screen
            LoadingScreenForm loadingScreen = new LoadingScreenForm();
            loadingScreen.ShowDialog();

            ApplicationBriefing applicationBriefing = new ApplicationBriefing();
            applicationBriefing.Show();
            this.Hide();
        }
    }
}
