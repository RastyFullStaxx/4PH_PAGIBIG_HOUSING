using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4PH_PAGIBIG_HOUSING
{
    public partial class ApplicationBriefing : Form
    {
        // P/Invoke declaration to import CreateRoundRectRgn
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public ApplicationBriefing()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;

            // Apply rounded corners on load
            Load += ApplicationBriefing_Load;

            // Apply rounded corners when resizing
            Resize += ApplicationBriefing_Resize;
        }
        private void ApplicationBriefing_Load(object sender, EventArgs e)
        {
            ApplyRoundCorners(20);
        }

        // Event handler for resizing
        private void ApplicationBriefing_Resize(object sender, EventArgs e)
        {
            ApplyRoundCorners(20);
        }

        private void ApplyRoundCorners(int radius)
        {
            IntPtr regionHandle = CreateRoundRectRgn(0, 0, Width, Height, radius, radius);
            Region = Region.FromHrgn(regionHandle);
            Marshal.FreeHGlobal(regionHandle);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            ApplicationPart1 applicationPart1 = new ApplicationPart1();
            applicationPart1.Show();
            this.Hide();
        }
    }
}
