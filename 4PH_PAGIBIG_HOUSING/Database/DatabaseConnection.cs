using _4PH_PAGIBIG_HOUSING.DbContext;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4PH_PAGIBIG_HOUSING.Database
{
    internal class DatabaseConnection
    {
        private string connectionString;

        // Singleton instance
        private static DatabaseConnection? instance;

        // Private constructor to enforce singleton pattern
        private DatabaseConnection()
        {
            // Initialize connection string here
            //RASTY = connectionString = "server=localhost;database=unbroke;uid=root;pwd='180503';";
            //EJAY = connectionString = "server=localhost;database=unbroke;uid=root;pwd='';";

            connectionString = "server=localhost;port=3307;database=pagibighousing;uid=root;pwd='';";

        }

        // Public static method to get the singleton instance
        public static DatabaseConnection GetInstance()
        {
            if (instance == null)
            {
                instance = new DatabaseConnection();
            }
            return instance;
        }

        // Method to get database connection
        public MySqlConnection GetConnection()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            return connection;
        }

        // Method to test database connection
        public bool TestConnection()
        {
            using (MySqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Connection successful.");
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex.Message);
                    // Log the exception here or handle it appropriately
                    return false;
                }
            }
        }
        // Method to insert borrower information
        public bool InsertBorrowerInformation(BorrowerInformation borrower)
        {
            using (MySqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = @"INSERT INTO Borrowers 
                                    (Pag_IBIG_MID_Number_RTN, Borrower_Name, Borrower_Nationality, 
                                    Birthdate, Sex, Permanent_Address, Present_Address, 
                                    Marital_Status, Borrower_Home_Landline, Borrower_Cellphone, 
                                    Borrower_Email_Address, Home_Ownership, Years_of_Stay, EE_SSS_GSIS_ID_No) 
                                    VALUES 
                                    (@Pag_IBIG_MID_Number_RTN, @Borrower_Name, @Borrower_Nationality, 
                                    @Birthdate, @Sex, @Permanent_Address, @Present_Address, 
                                    @Marital_Status, @Borrower_Home_Landline, @Borrower_Cellphone, 
                                    @Borrower_Email_Address, @Home_Ownership, @Years_of_Stay, @EE_SSS_GSIS_ID_No)";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Pag_IBIG_MID_Number_RTN", borrower.Pag_IBIG_MID_Number_RTN);
                    command.Parameters.AddWithValue("@Borrower_Name", borrower.Borrower_Name);
                    command.Parameters.AddWithValue("@Borrower_Nationality", borrower.Borrower_Nationality);
                    command.Parameters.AddWithValue("@Birthdate", borrower.Birthdate);
                    command.Parameters.AddWithValue("@Sex", borrower.Sex);
                    command.Parameters.AddWithValue("@Permanent_Address", borrower.Permanent_Address);
                    command.Parameters.AddWithValue("@Present_Address", borrower.Present_Address);
                    command.Parameters.AddWithValue("@Marital_Status", borrower.Marital_Status);
                    command.Parameters.AddWithValue("@Borrower_Home_Landline", borrower.Borrower_Home_Landline);
                    command.Parameters.AddWithValue("@Borrower_Cellphone", borrower.Borrower_Cellphone);
                    command.Parameters.AddWithValue("@Borrower_Email_Address", borrower.Borrower_Email_Address);
                    command.Parameters.AddWithValue("@Home_Ownership", borrower.Home_Ownership);
                    command.Parameters.AddWithValue("@Years_of_Stay", borrower.Years_of_Stay);
                    command.Parameters.AddWithValue("@EE_SSS_GSIS_ID_No", borrower.EE_SSS_GSIS_ID_No);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inserting borrower information: " + ex.Message);
                    // Log the exception here or handle it appropriately
                    return false;
                }
            }
        }


    }
}
