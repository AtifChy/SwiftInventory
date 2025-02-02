using System.Data;
using System.Data.SqlClient;

namespace SwiftInventory.Database
{
    internal static class SupplierQueries
    {
        public static DataTable GetAllSuppliers()
        {
            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                const string query = @"
                    SELECT 
                        SupplierID AS ID,
                        SupplierName AS 'Name',
                        Phone,
                        Address
                    FROM Supplier";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable suppliers = new DataTable();
                    adapter.Fill(suppliers);
                    return suppliers;
                }
            }
        }

        public static bool AddSupplier(string supplierName, string phone, string address)
        {
            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                const string query = @"
                    INSERT INTO Supplier (SupplierName, Phone, Address)
                    VALUES (@SupplierName, @Phone, @Address)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SupplierName", supplierName);
                    command.Parameters.AddWithValue("@Phone", phone);
                    command.Parameters.AddWithValue("@Address", address);
                    command.ExecuteNonQuery();
                }
            }

            return true;
        }

        public static bool DeleteSupplier(int supplierId)
        {
            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                const string query = @"
                    DELETE FROM Supplier
                    WHERE SupplierID = @SupplierID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SupplierID", supplierId);
                    command.ExecuteNonQuery();
                }
            }
            return true;
        }
    }
}
