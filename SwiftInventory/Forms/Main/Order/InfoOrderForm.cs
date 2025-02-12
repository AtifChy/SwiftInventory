using SwiftInventory.CustomControls;
using SwiftInventory.Database;
using SwiftInventory.Forms.Common;
using System;
using System.Collections.Generic;
using System.Globalization;
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
            if (_orderProducts == null || _orderProducts.Count == 0)
            {
                MessageBox.Show(this, @"No products found in this order.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OpenChildForm(Parent as Panel, new ManageOrderForm());
                return;
            }

            CustomerNameText.Text = _customerName;
            TotalAmountText.Text = _totalAmount.ToString(CultureInfo.CurrentCulture);
            PaymentStatusText.Text = _paymentStatus;

            FirstInfoViewControl.SetProductItemData(_orderProducts[0]);

            for (var i = 1; i < _orderProducts.Count; i++)
            {
                var infoOrderControl = new ProductItemControl();
                infoOrderControl.SetProductItemData(_orderProducts[i]);
                OrderFlowLayoutPanel.Controls.Add(infoOrderControl);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
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
                horizontalMargin = Math.Max(horizontalMargin, 0);

                // Update the control's margin. (You can preserve its existing top and bottom margins.)
                ctrl.Margin = new Padding(horizontalMargin, ctrl.Margin.Top, horizontalMargin, ctrl.Margin.Bottom);
            }
        }
    }
}
