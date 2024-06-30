using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4PH_PAGIBIG_HOUSING.DbContext
{
    internal class BankingInformation
    {
        public string? PAG_IBIG_MID_Number_RTN { get; set; }
        public string? Account_No { get; set; }
        public string? Bank { get; set; }
        public string? Branch_Address { get; set; }
        public string? Type_of_Account { get; set; }
        public DateTime Date_Opened { get; set; }
        public decimal Ave_Balance { get; set; }
        public string? Issuer_Name { get; set; }
    }
}
