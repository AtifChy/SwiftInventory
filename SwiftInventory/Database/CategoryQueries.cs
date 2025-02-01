using System.Data;
using System.Data.SqlClient;

namespace SwiftInventory.Database
{
    internal static class CategoryQueries
    {
        public static DataTable GetAllCategories()
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
