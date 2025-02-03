using System.Data;
using System.Data.SqlClient;

namespace SwiftInventory.Database
{
    internal static class CustomerQueries
    {
        public static DataTable GetAllCustomers()
        {
            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                const string query = @"
                    SELECT 
                        CustomerID AS ID,
                        Name,
                        Phone,
                        Address,
                        Email
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

        public static DataRow GetCustomer(int customerId)
        {
            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                const string query = @"
                    SELECT 
                        CustomerID AS ID,
                        Name,
                        Phone,
                        Address,
                        Email
                    FROM Customer
                    WHERE CustomerID = @CustomerID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CustomerID", customerId);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable customer = new DataTable();
                    adapter.Fill(customer);
                    return customer.Rows.Count > 0 ? customer.Rows[0] : null;
                }
            }
        }

        public static bool AddCustomer(string name, string phone, string address, string email)
        {
            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                const string query = @"
                    INSERT INTO Customer (Name, Phone, Address, Email)
                    VALUES (@Name, @Phone, @Address, @Email)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Phone", phone);
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@Email", email);
                    command.ExecuteNonQuery();
                }
            }

            return true;
        }

        public static bool UpdateCustomer(int customerId, string name, string phone, string address, string email)
        {
            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                const string query = @"
                    UPDATE Customer
                    SET Name = @Name, Phone = @Phone, Address = @Address, Email = @Email
                    WHERE CustomerID = @CustomerID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CustomerID", customerId);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Phone", phone);
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@Email", email);
                    command.ExecuteNonQuery();
                }
            }
            return true;
        }

        public static bool DeleteCustomer(int customerId)
        {
            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                const string query = @"
                    DELETE FROM Customer
                    WHERE CustomerID = @CustomerID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CustomerID", customerId);
                    command.ExecuteNonQuery();
                }
            }
            return true;
        }
    }
}
