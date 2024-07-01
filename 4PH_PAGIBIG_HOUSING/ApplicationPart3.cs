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
    public partial class ApplicationPart3 : Form
    {
        private readonly DatabaseConnection database =  DatabaseConnection.GetInstance();
        private readonly CollateralInformation collateral = new CollateralInformation();


        public ApplicationPart3()
        {
            InitializeComponent();
        }

        private void ApplicationPart3_Load(object sender, EventArgs e)
        {

        }
    }
}
