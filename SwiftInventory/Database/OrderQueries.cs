using SwiftInventory.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows;

namespace SwiftInventory.Database
{
    internal static class OrderQueries
    {
        public static DataTable GetOrders()
        {
            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                const string query = @"
                    SELECT 
                        [Order].OrderID AS ID,
                        Customer.Name AS [Customer Name],
                        [Order].TotalAmount AS [Total Amount],
                        [User].UserName AS [Accepted By],
                        [Order].PaymentStatus AS [Payment Status],
                        [Order].OrderDate AS [Created At]
                    FROM [Order]
                    INNER JOIN Customer ON [Order].CustomerID = Customer.CustomerID
                    INNER JOIN [User] ON [Order].UserID = [User].UserID";
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable orders = new DataTable();
                    adapter.Fill(orders);
                    return orders;
                }
            }
        }

        public static void GetOrder(int orderId, out string customerName, out decimal totalAmount, out string paymentStatus)
        {
            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                const string query = @"
                    SELECT 
                        Customer.Name, [Order].TotalAmount, [Order].PaymentStatus
                    FROM [Order]
                    INNER JOIN Customer ON [Order].CustomerID = Customer.CustomerID
                    WHERE [Order].OrderID = @OrderID";
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@OrderID", orderId);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                        customerName = reader.GetString(0);
                        totalAmount = reader.GetDecimal(1);
                        paymentStatus = reader.GetString(2);
                    }
                }
            }
        }

        public static List<Product> GetOrderDetails(int orderId)
        {
            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                const string query = @"
                    SELECT 
                        Product.ProductID AS ID,
                        Product.ProductName AS [Product Name],
                        OrderDetails.Quantity,
                        OrderDetails.Subtotal,
                        Product.Image
                    FROM OrderDetails
                    INNER JOIN Product ON OrderDetails.ProductID = Product.ProductID
                    WHERE OrderDetails.OrderID = @OrderID";
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@OrderID", orderId);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable orderDetails = new DataTable();
                    adapter.Fill(orderDetails);
                    return orderDetails.AsEnumerable().Select(row => new Product
                    {
                        ProductId = row.Field<int>("ID"),
                        ProductName = row.Field<string>("Product Name"),
                        Quantity = row.Field<int>("Quantity"),
                        Subtotal = row.Field<decimal>("Subtotal"),
                        ProductImage = row.Field<string>("Image")
                    }).ToList();
                }
            }
        }

        public static void AddOrder(int customerId, List<Product> productDetails)
        {
            int userId = UserSession.UserId;

            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        int orderId = InsertOrder(connection, transaction, customerId, userId, productDetails);
                        InsertOrderDetails(connection, transaction, orderId, productDetails);
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        throw;
                    }
                }
            }
        }

        private static int InsertOrder(SqlConnection connection, SqlTransaction transaction, int customerId, int userId, List<Product> productDetails)
        {
            decimal totalAmount = productDetails.Sum(p => p.Quantity * p.PricePerUnit);

            const string orderQuery = @"
                INSERT INTO [Order] (CustomerID, UserID, TotalAmount)
                VALUES (@CustomerID, @UserID, @TotalAmount);
                SELECT SCOPE_IDENTITY()";

            using (SqlCommand cmd = new SqlCommand(orderQuery, connection, transaction))
            {
                cmd.Parameters.AddWithValue("@CustomerID", customerId);
                cmd.Parameters.AddWithValue("@UserID", userId);
                cmd.Parameters.AddWithValue("@TotalAmount", totalAmount);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        private static void InsertOrderDetails(SqlConnection connection, SqlTransaction transaction, int orderId, List<Product> productDetails)
        {
            const string orderDetailQuery = @"
                INSERT INTO OrderDetails (OrderID, ProductID, Quantity, Subtotal)
                VALUES (@OrderID, @ProductID, @Quantity, @Subtotal)";

            foreach (var product in productDetails)
            {
                using (SqlCommand cmd = new SqlCommand(orderDetailQuery, connection, transaction))
                {
                    cmd.Parameters.AddWithValue("@OrderID", orderId);
                    cmd.Parameters.AddWithValue("@ProductID", product.ProductId);
                    cmd.Parameters.AddWithValue("@Quantity", product.Quantity);
                    cmd.Parameters.AddWithValue("@Subtotal", product.Quantity * product.PricePerUnit);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateOrder(int orderId, string paymentStatus)
        {
            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                const string query = "UPDATE [Order] SET PaymentStatus = @PaymentStatus WHERE OrderID = @OrderID";
                connection.Open();
                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PaymentStatus", paymentStatus);
                        command.Parameters.AddWithValue("@OrderID", orderId);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    throw;
                }
            }
        }

        public static void DeleteOrder(int orderId)
        {
            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                const string query = "DELETE FROM [Order] WHERE OrderID = @OrderID";
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@OrderID", orderId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static bool IsOrderPaymentStatusPaid(int orderId)
        {
            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                const string query = @"
                    SELECT PaymentStatus 
                    FROM [Order]
                    WHERE OrderID = @OrderID
                    AND PaymentStatus = 'Paid'";
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@OrderID", orderId);
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public static int GetOrderCount()
        {
            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                const string query = "SELECT COUNT(OrderID) FROM [Order]";
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    return (int)command.ExecuteScalar();
                }
            }
        }
    }
}
