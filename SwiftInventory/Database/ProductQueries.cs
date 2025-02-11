using System.Collections.Generic;
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

                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable products = new DataTable();
                    adapter.Fill(products);
                    return products;
                }
            }
        }

        public static void GetProduct(int productId, out string productName, out decimal pricePerUnit, out int quantity, out int categoryId, out int supplierId, out string image)
        {
            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                const string query = @"
                    SELECT 
                        ProductName, PricePerUnit, Quantity, CategoryID, SupplierID, Image
                    FROM Product
                    WHERE ProductID = @ProductID";
                connection.Open();
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
                        image = reader.IsDBNull(5) ? null : reader.GetString(5);
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
                connection.Open();
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

        public static void UpdateProduct(int productId, string productName, decimal pricePerUnit, int quantity, int categoryId, int supplierId, string image)
        {
            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                const string query = @"
                    UPDATE Product
                    SET 
                        ProductName = @ProductName, 
                        PricePerUnit = @PricePerUnit, 
                        Quantity = @Quantity, 
                        CategoryID = @CategoryID, 
                        SupplierID = @SupplierID,
                        Image = @Image      
                    WHERE ProductID = @ProductID";

                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductID", productId);
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

        public static void UpdateProduct(
            int productId,
            string productName = null,
            decimal? price = null,
            int? quantity = null,
            int? categoryId = null,
            int? supplierId = null)
        {
            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                List<string> updates = new List<string>();
                string query = "UPDATE Product SET ";

                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    if (!string.IsNullOrEmpty(productName))
                    {
                        updates.Add("ProductName = @ProductName");
                        command.Parameters.AddWithValue("@ProductName", productName);
                    }
                    if (price.HasValue)
                    {
                        updates.Add("Price = @Price");
                        command.Parameters.AddWithValue("@Price", price.Value);
                    }
                    if (quantity.HasValue)
                    {
                        updates.Add("Quantity = @Quantity");
                        command.Parameters.AddWithValue("@Quantity", quantity.Value);
                    }
                    if (categoryId.HasValue)
                    {
                        updates.Add("CategoryID = @CategoryID");
                        command.Parameters.AddWithValue("@CategoryID", categoryId.Value);
                    }
                    if (supplierId.HasValue)
                    {
                        updates.Add("SupplierID = @SupplierID");
                        command.Parameters.AddWithValue("@SupplierID", supplierId.Value);
                    }

                    if (updates.Count == 0)
                    {
                        return;
                    }

                    query += string.Join(", ", updates);
                    query += " WHERE ProductID = @ProductID";
                    command.Parameters.AddWithValue("@ProductID", productId);

                    command.CommandText = query;

                    command.Connection = connection;
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateProductQuantity(int productId, int delta)
        {
            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                const string query = @"
                    UPDATE Product
                    SET Quantity = Quantity + @Delta
                    WHERE ProductID = @ProductID";
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Delta", delta);
                    command.Parameters.AddWithValue("@ProductID", productId);
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
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductID", productId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static bool CheckProductQuantity(int productId, int quantity)
        {
            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                const string query = @"
                    SELECT Quantity
                    FROM Product
                    WHERE ProductID = @ProductID";
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductID", productId);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                        return reader.GetInt32(0) >= quantity;
                    }
                }
            }
        }

        public static int GetProductCount()
        {
            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                const string query = @"
                    SELECT COUNT(*)
                    FROM Product";
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    return (int)command.ExecuteScalar();
                }
            }
        }
    }
}
