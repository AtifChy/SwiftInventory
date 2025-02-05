using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SwiftInventory.Database
{
    internal static class UserQueries
    {
        public static DataTable GetUsers()
        {
            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                const string query = @"
                    SELECT 
                        UserID AS ID,     
                        UserName, 
                        Email, 
                        Role,
                        Approved
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

        public static DataRow GetUser(int userId)
        {
            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                const string query = @"
                    SELECT 
                        UserID AS ID,     
                        UserName, 
                        Email, 
                        Role,
                        Approved
                    FROM [User]
                    WHERE UserID = @UserID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userId);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable users = new DataTable();
                    adapter.Fill(users);
                    return users.Rows.Count > 0 ? users.Rows[0] : null;
                }
            }
        }

        public static DataRow GetUser(string userName)
        {
            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                const string query = @"
                    SELECT 
                        UserID AS ID,     
                        UserName,
                        Password,
                        Email, 
                        Role,
                        Approved
                    FROM [User]
                    WHERE UserName = @UserName";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserName", userName);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable users = new DataTable();
                    adapter.Fill(users);
                    return users.Rows.Count > 0 ? users.Rows[0] : null;
                }
            }
        }

        public static void ApproveUser(int userId)
        {
            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                const string query = @"
                    UPDATE [User]
                    SET Approved = 1
                    WHERE UserID = @UserID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void AddUser(string userName, string password, string email, string role)
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
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteUser(int userId)
        {
            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                const string query = @"
                    DELETE FROM [User]
                    WHERE UserID = @UserID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateUser(
            int userId,
            string userName = null,
            string email = null,
            string password = null,
            string role = null,
            bool? approved = null)
        {
            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                List<string> updates = new List<string>();
                string query = "UPDATE [User] SET ";

                using (SqlCommand command = new SqlCommand())
                {
                    if (!string.IsNullOrWhiteSpace(userName))
                    {
                        updates.Add("UserName = @UserName");
                        command.Parameters.AddWithValue("@UserName", userName);
                    }

                    if (!string.IsNullOrWhiteSpace(email))
                    {
                        updates.Add("Email = @Email");
                        command.Parameters.AddWithValue("@Email", email);
                    }

                    if (!string.IsNullOrWhiteSpace(password))
                    {
                        updates.Add("Password = @Password");
                        command.Parameters.AddWithValue("@Password", password);
                    }

                    if (!string.IsNullOrWhiteSpace(role))
                    {
                        updates.Add("Role = @Role");
                        command.Parameters.AddWithValue("@Role", role);
                    }

                    if (approved != null)
                    {
                        updates.Add("Approved = @Approved");
                        command.Parameters.AddWithValue("@Approved", approved);
                    }

                    if (updates.Count == 0)
                    {
                        return;
                    }

                    query += string.Join(", ", updates);
                    query += " WHERE UserID = @UserID";
                    command.Parameters.AddWithValue("@UserID", userId);

                    command.CommandText = query;

                    command.Connection = connection;
                    command.ExecuteNonQuery();
                }
            }
        }

        public static int GetUserCount()
        {
            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                const string query = @"
                    SELECT COUNT(*)
                    FROM [User]";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    return (int)command.ExecuteScalar();
                }
            }
        }
    }
}
