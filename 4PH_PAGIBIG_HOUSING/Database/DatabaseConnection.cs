using _4PH_PAGIBIG_HOUSING.DbContext;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4PH_PAGIBIG_HOUSING.Database
{
    internal class DatabaseConnection
    {
        private string connectionString;

        // Singleton instance

        // Singleton instance using Lazy<T>
        private static readonly Lazy<DatabaseConnection> instance =
            new Lazy<DatabaseConnection>(() => new DatabaseConnection());

        // Private constructor to enforce singleton pattern
        private DatabaseConnection()
        {
            // Initialize connection string here
            //RASTY = connectionString = "server=localhost;database=unbroke;uid=root;pwd='180503';";
            // Rasty = connectionString = "server=localhost;port=3307;database=pagibighousing;uid=root;pwd='';";


            //EJAY = connectionString = "server=localhost;database=unbroke;uid=root;pwd='';";

            connectionString = "server=localhost;port=3307;database=pagibighousing;uid=root;pwd='';";

        }

        // Public static method to get the singleton instance
        public static DatabaseConnection Instance => instance.Value;


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

        public bool ExecuteNonQuery(string query)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    // Handle exception
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }
        }

        public DataSet ExecuteQuery(string query)
        {
            DataSet dataSet = new DataSet();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    adapter.Fill(dataSet);
                }
                catch (Exception ex)
                {
                    // Handle exception
                    Console.WriteLine(ex.Message);
                }
            }
            return dataSet;
        }
        public List<string> GetPagIBIGMIDNumbers()
        {
            List<string> pagIBIGMIDNumbers = new List<string>();

            string query = "SELECT Pag_IBIG_MID_Number_RTN FROM BORROWER_INFORMATION";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        pagIBIGMIDNumbers.Add(reader.GetString(0));
                    }
                }
                catch (Exception ex)
                {
                    // Handle exception
                    Console.WriteLine(ex.Message);
                }
            }
            return pagIBIGMIDNumbers;
        }

        public void ExecuteNonQuery(string query, MySqlTransaction transaction)
        {
            using (MySqlConnection conn = GetConnection())
            {
                using (var command = new MySqlCommand(query, conn, transaction))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public MySqlTransaction BeginTransaction()
        {
            MySqlConnection conn = GetConnection();
            conn.Open();
            return conn.BeginTransaction();
        }
    }
}
