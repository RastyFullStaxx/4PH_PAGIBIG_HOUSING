using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4PH_PAGIBIG_HOUSING.DbContext
{
    internal class BorrowerInformation
    {
            public string? Pag_IBIG_MID_Number_RTN { get; set; }
            public string? Borrower_Name { get; set; }
            public string? Borrower_Nationality { get; set; }
            public DateTime Birthdate { get; set; }
            public char Sex { get; set; }
            public string? Permanent_Address { get; set; }
            public string? Present_Address { get; set; }
            public string? Marital_Status { get; set; }
            public string? Borrower_Home_Landline { get; set; }
            public string? Borrower_Cellphone { get; set; }
            public string? Borrower_Email_Address { get; set; }
            public string? Home_Ownership { get; set; }
            public int Years_of_Stay { get; set; }
            public string? EE_SSS_GSIS_ID_No { get; set; }
        // Method to convert ComboBox selection to single character
        public void SetSexFromComboBox(string selectedSex)
        {
            if (selectedSex == "Male")
                Sex = 'M';
            else if (selectedSex == "Female")
                Sex = 'F';
            else
                throw new ArgumentException("Invalid sex selection.");
        }
    }
}
