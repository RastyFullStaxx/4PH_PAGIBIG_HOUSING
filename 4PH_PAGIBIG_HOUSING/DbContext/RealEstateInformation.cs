using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4PH_PAGIBIG_HOUSING.DbContext
{
    public class RealEstateInformation
    {
        public string? PAG_IBIG_MID_Number_RTN { get; set; }
        public int Real_Estate_Key { get; set; }
        public string? Real_Estate_Location { get; set; }
        public string? Type_of_Property { get; set; }
        public decimal Acquisition_Cost { get; set; }
        public decimal Market_Value { get; set; }
        public decimal Mortgage_Balance { get; set; }
        public decimal Rental_Income { get; set; }
    }
}
