using System.Data;
using System.Data.SqlClient;

namespace SwiftInventory.Database
{
    internal static class CategoryQueries
    {
        public static DataTable GetCategories()
        {
            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                const string query = @"
                    SELECT 
                        CategoryID AS ID,
                        CategoryName AS 'Category Name'
                    FROM Category";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable categories = new DataTable();
                    adapter.Fill(categories);
                    return categories;
                }
            }
        }

        public static DataRow GetCategory(int categoryId)
        {
            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                const string query = @"
                    SELECT 
                        CategoryID AS ID,
                        CategoryName AS 'Category Name'
                    FROM Category
                    WHERE CategoryID = @CategoryID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CategoryID", categoryId);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable category = new DataTable();
                    adapter.Fill(category);
                    return category.Rows.Count > 0 ? category.Rows[0] : null;
                }
            }
        }

        public static void AddCategory(string categoryName)
        {
            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                const string query = @"
                    INSERT INTO Category (CategoryName)
                    VALUES (@CategoryName)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CategoryName", categoryName);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateCategory(int categoryId, string categoryName)
        {
            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                const string query = @"
                    UPDATE Category
                    SET CategoryName = @CategoryName
                    WHERE CategoryID = @CategoryID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CategoryName", categoryName);
                    command.Parameters.AddWithValue("@CategoryID", categoryId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteCategory(int categoryId)
        {
            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                const string query = @"
                    DELETE FROM Category
                    WHERE CategoryID = @CategoryID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CategoryID", categoryId);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
