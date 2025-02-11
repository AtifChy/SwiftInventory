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
                        Address,
                        CreatedAt AS [Created At],
                        UpdatedAt AS [Updated At]       
                    FROM Customer";

                connection.Open();

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
                        Name,
                        Email,
                        Phone,
                        Address
                    FROM Customer
                    WHERE CustomerID = @CustomerID";

                connection.Open();

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

        public static void AddCustomer(string name, string email, string phone, string address)
        {
            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                const string query = @"
                    INSERT INTO Customer (Name, Email, Phone, Address)
                    VALUES (@Name, @Email, @Phone, @Address)";

                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Phone", phone);
                    command.Parameters.AddWithValue("@Address", address);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateCustomer(int customerId, string name, string email, string phone, string address)
        {
            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                const string query = @"
                    UPDATE Customer
                    SET 
                        Name = @Name, 
                        Email = @Email, 
                        Phone = @Phone, 
                        Address = @Address,
                        UpdatedAt = GETDATE()   
                    WHERE CustomerID = @CustomerID";

                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Phone", phone);
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@CustomerID", customerId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteCustomer(int customerId)
        {
            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                const string query = @"
                    DELETE FROM Customer
                    WHERE CustomerID = @CustomerID";

                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CustomerID", customerId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static int GetCustomerCount()
        {
            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                const string query = @"
                    SELECT COUNT(*) FROM Customer";
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    return (int)command.ExecuteScalar();
                }
            }
        }
    }
}
