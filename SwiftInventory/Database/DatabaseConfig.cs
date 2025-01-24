using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace SwiftInventory.Database
{
    internal static class DatabaseConfig
    {
        private static readonly string ConnectionString;

        static DatabaseConfig()
        {
            string dataDirectory;

#if DEBUG
            var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            dataDirectory = Path.GetFullPath(Path.Combine(baseDirectory, @"..\..\Database"));
#else
            // This part is incomplete, it's not necessary currently
            dataDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SwiftInventory");
            Directory.CreateDirectory(dataDirectory);
#endif
            AppDomain.CurrentDomain.SetData("DataDirectory", dataDirectory);

            const string databasePath = @"|DataDirectory|\SwiftInventoryDB.mdf";
            ConnectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={databasePath};Integrated Security=True";
        }

        public static SqlConnection GetConnection()
        {
            try
            {
                var connection = new SqlConnection(ConnectionString);
                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Database connection error: " + ex.Message);
                throw;
            }
        }

        public static bool IsConnected()
        {
            try
            {
                using (var connection = GetConnection())
                {
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        connection.Close();
                        return true;
                    }

                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

    }
}
