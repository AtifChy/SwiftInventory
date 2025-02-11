using SwiftInventory.CustomControls;
using SwiftInventory.Database;
using SwiftInventory.Forms.Common;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SwiftInventory.Forms.Main.Order
{
    public partial class InfoOrderForm : BaseForm
    {
        private readonly string _customerName;
        private readonly decimal _totalAmount;
        private readonly string _paymentStatus;
        private readonly List<SwiftInventory.Common.Product> _orderProducts;


        public InfoOrderForm(int orderId)
        {
            InitializeComponent();
            OrderQueries.GetOrder(orderId, out _customerName, out _totalAmount, out _paymentStatus);
            _orderProducts = OrderQueries.GetOrderDetails(orderId);
        }

        private void InfoOrderForm_Load(object sender, EventArgs e)
        {
            CustomerNameText.Text = _customerName;
            TotalAmountText.Text = _totalAmount.ToString();
            PaymentStatusText.Text = _paymentStatus;

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
                var infoOrderControl = new InfoOrderControl();
                infoOrderControl.ProductPictureBox.ImageLocation = _orderProducts[i].ProductImage;
                infoOrderControl.ProductNameText.Text = _orderProducts[i].ProductName;
                infoOrderControl.QuantityNumericUpDown.Value = _orderProducts[i].Quantity;
                infoOrderControl.SubtotalTextBox.Text = _orderProducts[i].Subtotal.ToString();

                OrderFlowLayoutPanel.Controls.Add(infoOrderControl);
            }
        }

        private void OrderFlowLayoutPanel_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control ctrl in OrderFlowLayoutPanel.Controls)
            {
                // Set the control's width to the width of the FlowLayoutPanel minus some padding.
                ctrl.Width = OrderFlowLayoutPanel.ClientSize.Width - 20;

                // Calculate the left (and right) margin needed to center the control.
                int horizontalMargin = (OrderFlowLayoutPanel.ClientSize.Width - ctrl.Width) / 2;
                horizontalMargin = Math.Max(horizontalMargin, 0);

                // Update the control's margin. (You can preserve its existing top and bottom margins.)
                ctrl.Margin = new Padding(horizontalMargin, ctrl.Margin.Top, horizontalMargin, ctrl.Margin.Bottom);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(Parent as Panel, new ManageOrderForm());
        }
    }
}
