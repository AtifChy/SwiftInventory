using SwiftInventory.CustomControls;
using SwiftInventory.Database;
using SwiftInventory.Forms.Common;
using SwiftInventory.Forms.Main.Order;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SwiftInventory.Forms.Main.PurchaseOrder
{
    public partial class EditPurchaseOrderForm : BaseForm
    {
        private readonly int _purchaseOrderId;
        private readonly string _supplierName;
        private readonly decimal _totalAmount;
        private readonly string _paymentStatus;
        private readonly List<SwiftInventory.Common.Product> _purchaseOrderProducts;

        public EditPurchaseOrderForm(int purchaseOrderId)
        {
            InitializeComponent();
            _purchaseOrderId = purchaseOrderId;
            PurchaseOrderQueries.GetPurchaseOrder(purchaseOrderId, out _supplierName, out _totalAmount, out _paymentStatus);
            _purchaseOrderProducts = PurchaseOrderQueries.GetPurchaseOrderDetails(purchaseOrderId);
        }

        private void EditPurchaseOrderForm_Load(object sender, System.EventArgs e)
        {
            CustomerNameText.Text = _supplierName;
            TotalAmountText.Text = _totalAmount.ToString();
            PaymentStatusComboBox.DataSource = new[] { "Pending", "Received" };
            PaymentStatusComboBox.SelectedItem = _paymentStatus;

            try
            {
                FirstInfoViewControl.ProductPictureBox.ImageLocation = _purchaseOrderProducts[0].ProductImage;
                FirstInfoViewControl.ProductNameText.Text = _purchaseOrderProducts[0].ProductName;
                FirstInfoViewControl.QuantityNumericUpDown.Value = _purchaseOrderProducts[0].Quantity;
                FirstInfoViewControl.SubtotalTextBox.Text = _purchaseOrderProducts[0].Subtotal.ToString();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                string message = $"No products found in this order.\nError: {ex.Message}";
                MessageBox.Show(this, message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OpenChildForm(Parent as Panel, new ManagePurchaseOrderForm());
                return;
            }

            for (int i = 1; i < _purchaseOrderProducts.Count; i++)
            {
                var orderControl = new InfoOrderControl
                {
                    ProductPictureBox = { ImageLocation = _purchaseOrderProducts[i].ProductImage },
                    ProductNameText = { Text = _purchaseOrderProducts[i].ProductName },
                    QuantityNumericUpDown = { Value = _purchaseOrderProducts[i].Quantity },
                    SubtotalTextBox = { Text = _purchaseOrderProducts[i].Subtotal.ToString() }
                };
                OrderFlowLayoutPanel.Controls.Add(orderControl);
            }
        }

        private void CloseButton_Click(object sender, System.EventArgs e)
        {
            OpenChildForm(Parent as Panel, new ManageOrderForm());
        }

        private void OrderFlowLayoutPanel_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control ctrl in OrderFlowLayoutPanel.Controls)
            {
                // Set the control's width to the width of the FlowLayoutPanel minus some padding.
                ctrl.Width = OrderFlowLayoutPanel.ClientSize.Width - 20;

                // Calculate the left (and right) margin needed to center the control.
                int horizontalMargin = (OrderFlowLayoutPanel.ClientSize.Width - ctrl.Width) / 2;
                if (horizontalMargin < 0)
                    horizontalMargin = 0;

                // Update the control's margin. (You can preserve its existing top and bottom margins.)
                ctrl.Margin = new Padding(horizontalMargin, ctrl.Margin.Top, horizontalMargin, ctrl.Margin.Bottom);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string paymentStatus = PaymentStatusComboBox.SelectedItem.ToString();
            PurchaseOrderQueries.UpdatePurchaseOrder(_purchaseOrderId, paymentStatus);
            MessageBox.Show(this, @"Purchase order updated successfully.", @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OpenChildForm(Parent as Panel, new ManagePurchaseOrderForm());
        }
    }
}
