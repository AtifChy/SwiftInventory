﻿using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SwiftInventory.Database
{
    internal static class DatabaseConfig
    {
        private static readonly string ConnectionString;

        static DatabaseConfig()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["SwiftInventoryDB"].ConnectionString;
        }

        public static SqlConnection GetConnection()
        {
            try
            {
                return new SqlConnection(ConnectionString);
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
                    connection.Open();
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
