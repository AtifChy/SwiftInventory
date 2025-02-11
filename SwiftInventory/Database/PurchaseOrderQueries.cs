using SwiftInventory.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace SwiftInventory.Database
{
    internal static class PurchaseOrderQueries
    {
        public static DataTable GetPurchaseOrders()
        {
            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                connection.Open();

                const string query = @"
                    SELECT 
                        PurchaseOrder.PurchaseOrderID AS ID,
                        Supplier.SupplierName AS [Supplier Name],
                        PurchaseOrder.TotalAmount AS [Total Amount],
                        [User].UserName AS [Accepted By],
                        PurchaseOrder.PaymentStatus AS [Payment Status],
                        PurchaseOrder.PurchaseOrderDate AS [Created At]
                    FROM PurchaseOrder
                    INNER JOIN Supplier ON PurchaseOrder.SupplierID = Supplier.SupplierID
                    INNER JOIN [User] ON PurchaseOrder.UserID = [User].UserID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable purchaseOrders = new DataTable();
                    adapter.Fill(purchaseOrders);
                    return purchaseOrders;
                }
            }
        }

        public static void GetPurchaseOrder(int purchaseOrderId, out string supplierName, out decimal totalAmount,
            out string paymentStatus)
        {
            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                connection.Open();

                const string query = @"
                    SELECT 
                        Supplier.SupplierName, PurchaseOrder.TotalAmount, PurchaseOrder.PaymentStatus
                    FROM PurchaseOrder
                    INNER JOIN Supplier ON PurchaseOrder.SupplierID = Supplier.SupplierID
                    WHERE PurchaseOrder.PurchaseOrderID = @PurchaseOrderID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PurchaseOrderID", purchaseOrderId);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                        supplierName = reader.GetString(0);
                        totalAmount = reader.GetDecimal(1);
                        paymentStatus = reader.GetString(2);
                    }
                }
            }
        }

        public static List<Product> GetPurchaseOrderDetails(int purchaseOrderId)
        {
            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                connection.Open();

                const string query = @"
                    SELECT 
                        Product.ProductID AS ID,
                        Product.ProductName AS [Product Name],
                        PurchaseOrderDetails.Quantity,
                        PurchaseOrderDetails.Subtotal,
                        Product.Image
                    FROM PurchaseOrderDetails
                    INNER JOIN Product ON PurchaseOrderDetails.ProductID = Product.ProductID
                    WHERE PurchaseOrderDetails.PurchaseOrderID = @PurchaseOrderID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PurchaseOrderID", purchaseOrderId);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable purchaseOrderDetails = new DataTable();
                    adapter.Fill(purchaseOrderDetails);
                    return purchaseOrderDetails.AsEnumerable().Select(row => new Product
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

        public static void UpdatePurchaseOrder(int purchaseOrderId, string paymentStatus)
        {
            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                connection.Open();

                const string query = @"
                    UPDATE PurchaseOrder
                    SET PaymentStatus = @PaymentStatus
                    WHERE PurchaseOrderID = @PurchaseOrderID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PaymentStatus", paymentStatus);
                    command.Parameters.AddWithValue("@PurchaseOrderID", purchaseOrderId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void DeletePurchaseOrder(int purchaseOrderId)
        {
            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                connection.Open();
                const string query = @"
                    DELETE FROM PurchaseOrder
                    WHERE PurchaseOrderID = @PurchaseOrderID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PurchaseOrderID", purchaseOrderId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void AddPurchaseOrder(int supplierId, List<Product> productDetails)
        {
            int userId = UserSession.UserId;

            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        int purchaseOrderId =
                            InsertPurchaseOrder(connection, transaction, supplierId, userId, productDetails);
                        InsertPurchaseOrderDetails(connection, transaction, purchaseOrderId, productDetails);
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw;
                    }
                }
            }
        }

        private static int InsertPurchaseOrder(SqlConnection connection, SqlTransaction transaction, int supplierId, int userId, List<Product> productDetails)
        {
            decimal totalAmount = productDetails.Sum(product => product.Quantity * product.PricePerUnit);

            const string query = @"
                INSERT INTO PurchaseOrder (SupplierID, UserID, TotalAmount, PaymentStatus)
                VALUES (@SupplierID, @UserID, @TotalAmount, 'Pending');
                SELECT SCOPE_IDENTITY()";

            using (SqlCommand command = new SqlCommand(query, connection, transaction))
            {
                command.Parameters.AddWithValue("@SupplierID", supplierId);
                command.Parameters.AddWithValue("@UserID", userId);
                command.Parameters.AddWithValue("@TotalAmount", totalAmount);
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

        private static void InsertPurchaseOrderDetails(SqlConnection connection, SqlTransaction transaction, int purchaseOrderId, List<Product> productDetails)
        {
            const string query = @"
                INSERT INTO PurchaseOrderDetails (PurchaseOrderID, ProductID, Quantity, Subtotal)
                VALUES (@PurchaseOrderID, @ProductID, @Quantity, @Subtotal)";
            foreach (var product in productDetails)
            {
                using (SqlCommand command = new SqlCommand(query, connection, transaction))
                {
                    command.Parameters.AddWithValue("@PurchaseOrderID", purchaseOrderId);
                    command.Parameters.AddWithValue("@ProductID", product.ProductId);
                    command.Parameters.AddWithValue("@Quantity", product.Quantity);
                    command.Parameters.AddWithValue("@Subtotal", product.Quantity * product.PricePerUnit);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static bool IsPurchaseOrderPaymentStatusReceived(int purchaseOrderId)
        {
            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                const string query = @"
                    SELECT PaymentStatus 
                    FROM [PurchaseOrder]
                    WHERE PurchaseOrderID = @PurchaseOrderID
                    AND PaymentStatus = 'Received'";
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PurchaseOrderID", purchaseOrderId);
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public static int GetPurchaseOrderCount()
        {
            using (SqlConnection connection = DatabaseConfig.GetConnection())
            {
                const string query = @"
                    SELECT COUNT(PurchaseOrderID) FROM PurchaseOrder";
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    return (int)command.ExecuteScalar();
                }
            }
        }
    }
}
