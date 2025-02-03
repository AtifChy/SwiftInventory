using SwiftInventory.Database;
using System.Data;
using System.Data.SqlClient;

namespace SwiftUser.Database
{
    internal class UserQueries
    {
        // Method to retrieve all users from the database
        public static DataTable GetAllUsers()
        {
            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                const string query = @"
                    SELECT 
                        UserID AS ID,
                        UserName AS 'User Name',
                        Password AS Password,
                        Email AS Email,
                        Role AS Role
                    FROM [User]";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable users = new DataTable();
                    adapter.Fill(users);
                    return users;
                }
            }
        }

        // Method to add a new user to the database
        public static bool AddUser(string userName, string password, string email, string role)
        {
            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                const string query = @"
                    INSERT INTO [User] (UserName, Password, Email, Role)
                    VALUES (@UserName, @Password, @Email, @Role)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserName", userName);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Role", role);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            return true;
        }

        // Method to update an existing user in the database
        public static bool UpdateUser(int userId, string userName, string password, string email, string role)
        {
            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                const string query = @"
                    UPDATE [User]
                    SET UserName = @UserName, 
                        Password = @Password, 
                        Email = @Email, 
                        Role = @Role
                    WHERE UserID = @UserID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userId);
                    command.Parameters.AddWithValue("@UserName", userName);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Role", role);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            return true;
        }

        // Method to delete a user from the database
        public static bool DeleteUser(int userId)
        {
            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                const string query = @"
                    DELETE FROM [User]
                    WHERE UserID = @UserID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            return true;
        }
    }
}