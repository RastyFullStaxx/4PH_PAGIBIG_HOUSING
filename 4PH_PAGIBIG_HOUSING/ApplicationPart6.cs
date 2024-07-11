using _4PH_PAGIBIG_HOUSING.Database;
using _4PH_PAGIBIG_HOUSING.DbContext;
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

        private readonly string _pagIBIGMIDNumberRTN, _tct;
        private readonly DatabaseConnection _database = DatabaseConnection.Instance;
        private readonly RealEstateInformation _estate = new RealEstateInformation();


        public ApplicationPart6(string pagibigMIDNumber, string tct)
        {
            InitializeComponent();

            // Set default state for pnlMain based on the selected radio button
            SetPanelVisibility();
            _pagIBIGMIDNumberRTN = pagibigMIDNumber;
            _tct = tct;


            // Set initial visibility for entry panels and buttons
            pnlEntry2.Visible = false;
            btnCancelEntry2.Visible = false;
            pnlEntry3.Visible = false;
            btnCancelEntry3.Visible = false;

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
