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

    }
}
