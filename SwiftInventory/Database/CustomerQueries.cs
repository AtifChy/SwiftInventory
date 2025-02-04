using System.Data;
using System.Data.SqlClient;

namespace SwiftInventory.Database
{
    internal static class CustomerQueries
    {
        public static DataTable GetCustomers()
        {
            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                const string query = @"
                    SELECT 
                        CustomerID AS ID,
                        Name,
                        Email,
                        Phone,
                        Address
                    FROM Customer";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable customers = new DataTable();
                    adapter.Fill(customers);
                    return customers;
                }
            }
        }
    }
}
