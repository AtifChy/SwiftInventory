using System.Data;
using System.Data.SqlClient;

namespace SwiftInventory.Database
{
    internal class ProductQueries
    {
        public static DataTable GetAllProducts()
        {
            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                const string query = @"
                    SELECT 
                        Product.ProductID AS ID,
                        Product.ProductName AS 'Product Name',
                        Product.Price AS Price,
                        Product.Quantity AS Quantity,
                        Category.CategoryName AS Category,
                        Supplier.SupplierName AS Supplier
                    FROM Product
                    INNER JOIN Category ON Product.CategoryID = Category.CategoryID
                    INNER JOIN Supplier ON Product.SupplierID = Supplier.SupplierID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable products = new DataTable();
                    adapter.Fill(products);
                    return products;
                }
            }
        }

        public static bool AddProduct(string productName, decimal price, int quantity, int categoryId, int supplierId)
        {
            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                const string query = @"
                    INSERT INTO Product (ProductName, Price, Quantity, CategoryID, SupplierID)
                    VALUES (@ProductName, @Price, @Quantity, @CategoryID, @SupplierID)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductName", productName);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@CategoryID", categoryId);
                    command.Parameters.AddWithValue("@SupplierID", supplierId);
                    command.ExecuteNonQuery();
                }
            }

            return true;
        }

        public static bool UpdateProduct(int productId, string productName, decimal price, int quantity, int categoryId, int supplierId)
        {
            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                const string query = @"
                    UPDATE Product
                    SET ProductName = @ProductName, Price = @Price, Quantity = @Quantity, CategoryID = @CategoryID, SupplierID = @SupplierID
                    WHERE ProductID = @ProductID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductID", productId);
                    command.Parameters.AddWithValue("@ProductName", productName);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@CategoryID", categoryId);
                    command.Parameters.AddWithValue("@SupplierID", supplierId);
                    command.ExecuteNonQuery();
                }
            }
            return true;
        }

        public static bool DeleteProduct(int productId)
        {
            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                const string query = @"
                    DELETE FROM Product
                    WHERE ProductID = @ProductID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductID", productId);
                    command.ExecuteNonQuery();
                }
            }
            return true;
        }
    }
}
