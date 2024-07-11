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
    public partial class ApplicationPart5 : Form
    {
        private bool pnlEntry2Expanded = false;
        private bool pnlEntry3Expanded = false;

        public ApplicationPart5()
        {
            InitializeComponent();

            // Initialize the initial state of pnlEntry2
            ShowOnlyCancelEntry2();

            // Initialize the initial state of pnlEntry3
            ShowOnlyCancelEntry3();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Add your code for btnBack_Click here if needed
        }

        private void btnCancelEntry2_Click(object sender, EventArgs e)
        {
            if (pnlEntry2Expanded)
            {
                ShowOnlyCancelEntry2();
            }
            else
            {
                ExpandPnlEntry2();
            }
        }

        private void btnRevealEntry2_Click(object sender, EventArgs e)
        {
            ExpandPnlEntry2();
        }

        private void ShowOnlyCancelEntry2()
        {
            // Show only btnCancelEntry2 and hide other controls in pnlEntry2
            btnCancelEntry2.Visible = true;
            label15.Visible = false;
            comboBox1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            btnRevealEntry2.Visible = true; // Show btnRevealEntry2 when btnCancelEntry2 is visible
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            dateTimePicker1.Visible = false;
            btnCancelEntry2.Visible = false;

            pnlEntry2Expanded = false;
        }

        private void ExpandPnlEntry2()
        {
            // Show all controls in pnlEntry2
            btnCancelEntry2.Visible = true;
            label15.Visible = true;
            comboBox1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            btnRevealEntry2.Visible = false; // Hide btnRevealEntry2 when all controls are visible
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            dateTimePicker1.Visible = true;
            btnCancelEntry2.Visible = true;

            pnlEntry2Expanded = true;
        }

        private void btnCancelEntry3_Click(object sender, EventArgs e)
        {
            if (pnlEntry3Expanded)
            {
                ShowOnlyCancelEntry3();
            }
            else
            {
                ExpandPnlEntry3();
            }
        }

        private void btnRevealEntry3_Click(object sender, EventArgs e)
        {
            ExpandPnlEntry3();
        }

        private void ShowOnlyCancelEntry3()
        {
            // Show only btnCancelEntry3 and hide other controls in pnlEntry3
            btnCancelEntry3.Visible = true;
            btnRevealEntry3.Visible = true; // Show btnRevealEntry3 when btnCancelEntry3 is visible
            label16.Visible = false;
            comboBox2.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            dateTimePicker2.Visible = false;
            btnCancelEntry3.Visible = false;

            pnlEntry3Expanded = false;
        }

        private void ExpandPnlEntry3()
        {
            // Show all controls in pnlEntry3
            btnCancelEntry3.Visible = true;
            btnRevealEntry3.Visible = false; // Hide btnRevealEntry3 when all controls are visible
            label16.Visible = true;
            comboBox2.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
            textBox9.Visible = true;
            textBox10.Visible = true;
            dateTimePicker2.Visible = true;
            btnCancelEntry3.Visible = true;

            pnlEntry3Expanded = true;
        }

        private void ApplicationPart5_Load(object sender, EventArgs e)
        {

        }
    }
}
