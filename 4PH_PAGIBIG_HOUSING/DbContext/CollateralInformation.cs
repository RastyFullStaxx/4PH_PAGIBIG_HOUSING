using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4PH_PAGIBIG_HOUSING.DbContext
{
    internal class CollateralInformation
    {

        public string? PAG_IBIG_MID_Number_RTN { get; set; }
        public string? TCT_OCT_CCT_No { get; set; }
        public string? Property_Location { get; set; }
        public string? Type_of_Property { get; set; }
        public string? Name_of_Project { get; set; }
        public int Tax_Declaration { get; set; }
        public int Land_Area { get; set; }
        public string? Lot_Unit_No { get; set; }
        public string?  Block_Bldg_No { get; set; }
    }
}
