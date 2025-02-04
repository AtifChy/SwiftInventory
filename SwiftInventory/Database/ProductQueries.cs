using System.Data;
using System.Data.SqlClient;

namespace SwiftInventory.Database
{
    internal class ProductQueries
    {
        public static DataTable GetProducts()
        {
            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                const string query = @"
                    SELECT 
                        Product.ProductID AS ID,
                        Product.ProductName AS [Product Name],
                        Product.PricePerUnit AS [Price Per Unit],
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

        public static void GetProduct(int productId, out string productName, out decimal pricePerUnit, out int quantity, out int categoryId, out int supplierId)
        {
            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                const string query = @"
                    SELECT 
                        ProductName, PricePerUnit, Quantity, CategoryID, SupplierID
                    FROM Product
                    WHERE ProductID = @ProductID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductID", productId);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                        productName = reader.GetString(0);
                        pricePerUnit = reader.GetDecimal(1);
                        quantity = reader.GetInt32(2);
                        categoryId = reader.GetInt32(3);
                        supplierId = reader.GetInt32(4);
                    }
                }
            }
        }

        public static void AddProduct(string productName, decimal pricePerUnit, int quantity, int categoryId, int supplierId, string image)
        {
            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                const string query = @"
                    INSERT INTO Product (ProductName, PricePerUnit, Quantity, CategoryID, SupplierID, Image)
                    VALUES (@ProductName, @PricePerUnit, @Quantity, @CategoryID, @SupplierID, @Image)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductName", productName);
                    command.Parameters.AddWithValue("@PricePerUnit", pricePerUnit);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@CategoryID", categoryId);
                    command.Parameters.AddWithValue("@SupplierID", supplierId);
                    command.Parameters.AddWithValue("@Image", image);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateProduct(int productId, string productName, decimal price, int quantity, int categoryId, int supplierId)
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
        }

        public static void DeleteProduct(int productId)
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
        }
    }
}
