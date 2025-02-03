using System.Data;
using System.Data.SqlClient;

namespace SwiftInventory.Database
{
    internal class InventoryQueries
    {
        // Method to retrieve all inventories from the database
        public static DataTable GetAllInventories()
        {
            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                const string query = @"
                    SELECT 
                        Inventory.InventoryID AS ID,
                        Inventory.InventoryName AS 'Inventory Name',
                        Inventory.Price AS Price,
                        Inventory.Quantity AS Quantity,
                        Category.CategoryName AS Category,
                        Supplier.SupplierName AS Supplier
                    FROM Inventory
                    INNER JOIN Category ON Inventory.CategoryID = Category.CategoryID
                    INNER JOIN Supplier ON Inventory.SupplierID = Supplier.SupplierID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable inventories = new DataTable();
                    adapter.Fill(inventories);
                    return inventories;
                }
            }
        }

        // Method to add a new inventory item to the database
        public static bool AddInventory(string inventoryName, decimal price, int quantity, int categoryId, int supplierId)
        {
            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                const string query = @"
                    INSERT INTO Inventory (InventoryName, Price, Quantity, CategoryID, SupplierID)
                    VALUES (@InventoryName, @Price, @Quantity, @CategoryID, @SupplierID)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@InventoryName", inventoryName);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@CategoryID", categoryId);
                    command.Parameters.AddWithValue("@SupplierID", supplierId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            return true;
        }

        // Method to update an existing inventory item in the database
        public static bool UpdateProduct(int inventoryId, string productName, decimal price, int quantity, int categoryId, int supplierId)
        {
            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                const string query = @"
                    UPDATE Inventory
                    SET InventoryName = @InventoryName, Price = @Price, Quantity = @Quantity, CategoryID = @CategoryID, SupplierID = @SupplierID
                    WHERE InventoryID = @InventoryID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@InventoryID", inventoryId);
                    command.Parameters.AddWithValue("@InventoryName", productName);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@CategoryID", categoryId);
                    command.Parameters.AddWithValue("@SupplierID", supplierId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            return true;
        }

        // Method to delete an inventory item from the database
        public static bool DeleteProduct(int inventoryId)
        {
            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                const string query = @"
                    DELETE FROM Inventory
                    WHERE InventoryID = @InventoryID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@InventoryID", inventoryId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            return true;
        }
    }
}