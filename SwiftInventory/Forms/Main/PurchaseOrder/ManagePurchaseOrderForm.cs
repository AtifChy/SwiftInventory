using SwiftInventory.Database;
using SwiftInventory.Forms.Common;
using System;
using System.Windows.Forms;

namespace SwiftInventory.Forms.Main.PurchaseOrder
{
    public partial class ManagePurchaseOrderForm : BaseForm
    {
        public ManagePurchaseOrderForm()
        {
            InitializeComponent();
        }

        private void ManageOrderForm_Load(object sender, EventArgs e)
        {
            PurchaseOrderDataGridView.DataSource = PurchaseOrderQueries.GetPurchaseOrders();
            PurchaseOrderDataGridView.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font("Segoe UI Variable Display Semib", 9.5F, System.Drawing.FontStyle.Regular);
            PurchaseOrderDataGridView.DefaultCellStyle.Font =
                new System.Drawing.Font("Segoe UI Variable Display Semib", 9, System.Drawing.FontStyle.Regular);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(Parent as Panel, new PurchaseOrderProductListForm());
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            if (PurchaseOrderDataGridView.SelectedRows.Count > 0)
            {
                int purchaseOrderId = Convert.ToInt32(PurchaseOrderDataGridView.SelectedRows[0].Cells["ID"].Value);
                OpenChildForm(Parent as Panel, new InfoPurchaseOrderForm(purchaseOrderId));
            }
            else
            {
                MessageBox.Show(this, "Please select a purchase order to view.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (PurchaseOrderDataGridView.SelectedRows.Count > 0)
            {
                int purchaseOrderId = Convert.ToInt32(PurchaseOrderDataGridView.SelectedRows[0].Cells["ID"].Value);

                if (PurchaseOrderQueries.IsPurchaseOrderPaymentStatusReceived(purchaseOrderId))
                {
                    MessageBox.Show(this, "Purchase order received.");
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
                    var purchaseOrderProducts = PurchaseOrderQueries.GetPurchaseOrderDetails(purchaseOrderId);
                    foreach (var purchaseOrderProduct in purchaseOrderProducts)
                    {
                        ProductQueries.UpdateProductQuantity(purchaseOrderProduct.ProductId,
                            -purchaseOrderProduct.Quantity);
                    }

                    PurchaseOrderQueries.DeletePurchaseOrder(purchaseOrderId);
                    PurchaseOrderDataGridView.DataSource = PurchaseOrderQueries.GetPurchaseOrders();
                }
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (PurchaseOrderDataGridView.SelectedRows.Count > 0)
            {
                int purchaseOrderId = Convert.ToInt32(PurchaseOrderDataGridView.SelectedRows[0].Cells["ID"].Value);
                OpenChildForm(Parent as Panel, new EditPurchaseOrderForm(purchaseOrderId));
            }
        }
    }
}
