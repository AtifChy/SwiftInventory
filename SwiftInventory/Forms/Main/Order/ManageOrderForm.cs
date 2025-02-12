using SwiftInventory.Database;
using SwiftInventory.Forms.Common;
using System;
using System.Windows.Forms;

namespace SwiftInventory.Forms.Main.Order
{
    public partial class ManageOrderForm : BaseForm
    {
        public ManageOrderForm()
        {
            InitializeComponent();
        }

        private void ManageOrderForm_Load(object sender, EventArgs e)
        {
            OrderDataGridView.DataSource = OrderQueries.GetOrders();
            OrderDataGridView.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font("Segoe UI Variable Display Semib", 9.5F, System.Drawing.FontStyle.Regular);
            OrderDataGridView.DefaultCellStyle.Font =
                new System.Drawing.Font("Segoe UI Variable Display Semib", 9, System.Drawing.FontStyle.Regular);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(Parent as Panel, new OrderProductListForm());
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            if (OrderDataGridView.SelectedRows.Count > 0)
            {
                int orderId = Convert.ToInt32(OrderDataGridView.SelectedRows[0].Cells["ID"].Value);
                OpenChildForm(Parent as Panel, new InfoOrderForm(orderId));
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (OrderDataGridView.SelectedRows.Count > 0)
            {
                int orderId = Convert.ToInt32(OrderDataGridView.SelectedRows[0].Cells["ID"].Value);

                if (OrderQueries.IsOrderPaymentStatusPaid(orderId))
                {
                    MessageBox.Show(
                        this,
                        "Payment completed. Can't be deleted.",
                        "Delete Order",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                DialogResult result = MessageBox.Show(
                    this,
                    "Are you sure you want to delete this order?",
                    "Delete Order",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var orderProducts = OrderQueries.GetOrderDetails(orderId);
                    foreach (var orderProduct in orderProducts)
                    {
                        ProductQueries.UpdateProductQuantity(orderProduct.ProductId, +orderProduct.Quantity);
                    }

                    OrderQueries.DeleteOrder(orderId);
                    OrderDataGridView.DataSource = OrderQueries.GetOrders();
                }
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (OrderDataGridView.SelectedRows.Count > 0)
            {
                int orderId = Convert.ToInt32(OrderDataGridView.SelectedRows[0].Cells["ID"].Value);
                OpenChildForm(Parent as Panel, new EditOrderForm(orderId));
            }
        }
    }
}
