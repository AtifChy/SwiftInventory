using SwiftInventory.Common;
using SwiftInventory.CustomControls;
using SwiftInventory.Database;
using SwiftInventory.Forms.Common;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SwiftInventory.Forms.Main.Order
{
    public partial class EditOrderForm : BaseForm
    {
        private readonly int _orderId;
        private readonly string _customerName;
        private readonly decimal _totalAmount;
        private readonly string _paymentStatus;
        private readonly List<OrderProduct> _orderProducts;

        public EditOrderForm(int orderId)
        {
            InitializeComponent();
            _orderId = orderId;
            OrderQueries.GetOrder(orderId, out _customerName, out _totalAmount, out _paymentStatus);
            _orderProducts = OrderQueries.GetOrderDetails(orderId);
        }

        private void EditOrderForm_Load(object sender, System.EventArgs e)
        {
            CustomerNameText.Text = _customerName;
            TotalAmountText.Text = _totalAmount.ToString();
            PaymentStatusComboBox.DataSource = new[] { "Pending", "Paid" };
            PaymentStatusComboBox.SelectedItem = _paymentStatus;

            try
            {
                FirstInfoViewControl.ProductPictureBox.ImageLocation = _orderProducts[0].ProductImage;
                FirstInfoViewControl.ProductNameText.Text = _orderProducts[0].ProductName;
                FirstInfoViewControl.QuantityNumericUpDown.Value = _orderProducts[0].Quantity;
                FirstInfoViewControl.SubtotalTextBox.Text = _orderProducts[0].Subtotal.ToString();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                string message = $"No products found in this order.\nError: {ex.Message}";
                MessageBox.Show(this, message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OpenChildForm(Parent as Panel, new ManageOrderForm());
                return;
            }

            for (int i = 1; i < _orderProducts.Count; i++)
            {
                var orderControl = new InfoOrderControl
                {
                    ProductPictureBox = { ImageLocation = _orderProducts[i].ProductImage },
                    ProductNameText = { Text = _orderProducts[i].ProductName },
                    QuantityNumericUpDown = { Value = _orderProducts[i].Quantity },
                    SubtotalTextBox = { Text = _orderProducts[i].Subtotal.ToString() }
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
            OrderQueries.UpdateOrder(_orderId, paymentStatus);
        }
    }
}
