using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4PH_PAGIBIG_HOUSING.DbContext
{
    internal class BorrowersEmploymentInformation
    {
        public string EE_SSS_GSIS_ID_No { get; set; } = string.Empty;
        public string Employer_Business_Name { get; set; } = string.Empty;
        public string Employer_Business_Address { get; set; } = string.Empty;
        public string Employer_Direct_Line { get; set; } = string.Empty;
        public string Employer_Trunk_Line { get; set; } = string.Empty;
        public string Employer_Email_Address { get; set; } = string.Empty;
        public string Occupation { get; set; } = string.Empty;
        public string TIN { get; set; } = string.Empty;
        public string Position_Department { get; set; } = string.Empty;
        public int Years_in_Business_Employment { get; set; }
        public int No_of_Dependents { get; set; }
    }
}
