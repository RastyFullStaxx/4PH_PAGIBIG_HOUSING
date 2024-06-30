using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4PH_PAGIBIG_HOUSING.DbContext
{
    internal class HousingLoanInformation
    {
        public string? PAG_IBIG_MID_Number_RTN { get; set; }
        public string? TCT_OCT_CCT_No { get; set; }
        public decimal Loan_Amount { get; set; }
        public string? Loan_Term { get; set; }
        public string? Mode_of_Payment { get; set; }
    
    }
}
