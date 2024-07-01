using System;
using System.Windows.Forms;

namespace _4PH_PAGIBIG_HOUSING
{
    public partial class LoadingScreenForm : Form
    {
        public LoadingScreenForm()
        {
            InitializeComponent();
        }

        private void LoadingScreenForm_Load(object sender, EventArgs e)
        {
            // Set the minimum and maximum value of the progress bar
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;

            // Set the step size for the progress bar
            progressBar1.Step = 10;

            // Start the timer when the form loads
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Update progress bar value
            progressBar1.PerformStep();

            // If progress bar reaches maximum value, stop the timer and show ApplicationPart1
            if (progressBar1.Value >= progressBar1.Maximum)
            {
                timer1.Stop();

                try
                {
                    // Show ApplicationPart1
                    ApplicationPart1 borrowerinfo = new ApplicationPart1();
                    borrowerinfo.Show();

                    // Close this loading form
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }
    }
}
