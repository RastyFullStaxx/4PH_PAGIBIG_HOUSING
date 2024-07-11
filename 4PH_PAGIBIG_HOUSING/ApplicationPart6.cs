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
    public partial class ApplicationPart6 : Form
    {
        public ApplicationPart6()
        {
            InitializeComponent();

            // Set default state for pnlMain based on the selected radio button
            SetPanelVisibility();

            // Set initial visibility for entry panels and buttons
            pnlEntry2.Visible = false;
            btnCancelEntry2.Visible = false;
            pnlEntry3.Visible = false;
            btnCancelEntry3.Visible = false;

            // Ensure child controls inside pnlEntry2 and pnlEntry3 are visible initially
            // Example: pnlEntry2.Controls.Add(label1); // Add child controls as needed
        }

        private void ApplicationPart6_Load(object sender, EventArgs e)
        {
            // Set initial state for pnlMain
            SetPanelVisibility();
        }

        private void rdbtnYES_CheckedChanged(object sender, EventArgs e)
        {
            // Show pnlMain if rdbtnYES is selected
            SetPanelVisibility();
        }

        private void rdbtnNO_CheckedChanged(object sender, EventArgs e)
        {
            // Hide pnlMain if rdbtnNO is selected
            SetPanelVisibility();
        }

        private void SetPanelVisibility()
        {
            pnlMain.Visible = rdbtnYES.Checked;
        }

        private void btnRevealEntry2_Click(object sender, EventArgs e)
        {
            pnlEntry2.Visible = true;
            btnCancelEntry2.Visible = true;
            btnRevealEntry2.Visible = false;
        }

        private void btnCancelEntry2_Click(object sender, EventArgs e)
        {
            pnlEntry2.Visible = false;
            btnCancelEntry2.Visible = false;
            btnRevealEntry2.Visible = true;
        }

        private void btnRevealEntry3_Click(object sender, EventArgs e)
        {
            pnlEntry3.Visible = true;
            btnCancelEntry3.Visible = true;
            btnRevealEntry3.Visible = false;
        }

        private void btnCancelEntry3_Click(object sender, EventArgs e)
        {
            pnlEntry3.Visible = false;
            btnCancelEntry3.Visible = false;
            btnRevealEntry3.Visible = true;
        }

    }
}
