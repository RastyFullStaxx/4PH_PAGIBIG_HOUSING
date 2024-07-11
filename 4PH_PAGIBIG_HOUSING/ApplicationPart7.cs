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
    public partial class ApplicationPart7 : Form
    {
        public ApplicationPart7()
        {
            InitializeComponent();
        }

        private void ApplicationPart7_Load(object sender, EventArgs e)
        {
            // Initially hide pnlEntry2 and btnCancelEntry2
            pnlEntry2.Visible = false;
            pnlEntry3.Visible = false;
            btnCancelEntry3.Visible = false;
            btnCancelEntry2.Visible = false;
        }

        private void btnRevealEntry2_Click(object sender, EventArgs e)
        {
            // Show pnlEntry2 and btnCancelEntry2, hide btnRevealEntry2
            pnlEntry2.Visible = true;
            btnCancelEntry2.Visible = true;
            btnRevealEntry2.Visible = false;
        }

        private void btnRevealEntry3_Click(object sender, EventArgs e)
        {
            // Show pnlEntry2 and btnCancelEntry2, hide btnRevealEntry2
            pnlEntry3.Visible = true;
            btnCancelEntry3.Visible = true;
            btnRevealEntry3.Visible = false;
        }

        private void btnCancelEntry2_Click(object sender, EventArgs e)
        {
            // Hide pnlEntry2 and btnCancelEntry2, show btnRevealEntry2
            pnlEntry2.Visible = false;
            btnCancelEntry2.Visible = false;
            btnRevealEntry2.Visible = true;
        }

        private void btnCancelEntry3_Click(object sender, EventArgs e)
        {
            // Hide pnlEntry2 and btnCancelEntry2, show btnRevealEntry2
            pnlEntry3.Visible = false;
            btnCancelEntry3.Visible = false;
            btnRevealEntry3.Visible = true;
        }
    }
}
