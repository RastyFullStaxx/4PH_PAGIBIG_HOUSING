using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4PH_PAGIBIG_HOUSING.DbContext
{
    internal class LoanInformation
    {
        public string? PAG_IBIG_MID_Number_RTN { get; set; }
        public string? Loan_Availment_Key { get; set; }
        public string? Security { get; set; }
        public string? Type { get; set; }
        public DateTime Maturity_Date { get; set; }
        public decimal Amount_Balance { get; set; }
        public string? Mo_Amortization { get; set; }
    }
}
