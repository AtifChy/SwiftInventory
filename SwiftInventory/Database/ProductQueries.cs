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
    }
}
