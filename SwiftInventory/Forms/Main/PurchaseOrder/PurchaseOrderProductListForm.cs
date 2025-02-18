﻿using SwiftInventory.CustomControls;
using SwiftInventory.Database;
using SwiftInventory.Forms.Common;
using SwiftInventory.Forms.Main.Order;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SwiftInventory.Forms.Main.PurchaseOrder
{
    public partial class PurchaseOrderProductListForm : BaseForm
    {
        private readonly DataTable _productsDataTable;

        public PurchaseOrderProductListForm()
        {
            InitializeComponent();
            _productsDataTable = ProductQueries.GetProducts();
            _productsDataTable.PrimaryKey = new[] { _productsDataTable.Columns["ID"] };
        }

        private void AddButton_Click(object sender, System.EventArgs e)
        {
            var orderControl = new OrderControl();
            LoadProducts(orderControl);
            orderControl.ControlRemoved += OrderControl_ControlRemoved;
            OrderFlowLayoutPanel.Controls.Add(orderControl);
            OrderFlowLayoutPanel_SizeChanged(sender, e);
        }

        private void LoadProducts(OrderControl orderControl)
        {
            orderControl.ProductComboBox.DataSource = _productsDataTable;
            orderControl.ProductComboBox.DisplayMember = "Product Name";
            orderControl.ProductComboBox.ValueMember = "ID";
            orderControl.ProductComboBox.SelectedIndex = -1;
            orderControl.QuantityNumericUpDown.Maximum = decimal.MaxValue;
        }

        private void OrderControl_ControlRemoved(object sender, EventArgs e)
        {
            OrderFlowLayoutPanel_SizeChanged(sender, e);
        }

        internal void OrderFlowLayoutPanel_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control ctrl in OrderFlowLayoutPanel.Controls)
            {
                // Set the control's width to the width of the FlowLayoutPanel minus some padding.
                ctrl.Width = OrderFlowLayoutPanel.ClientSize.Width - 20; // Adjust as needed

                // Calculate the left (and right) margin needed to center the control.
                int horizontalMargin = (OrderFlowLayoutPanel.ClientSize.Width - ctrl.Width) / 2;
                if (horizontalMargin < 0)
                    horizontalMargin = 0;

                // Update the control's margin. (You can preserve its existing top and bottom margins.)
                ctrl.Margin = new Padding(horizontalMargin, ctrl.Margin.Top, horizontalMargin, ctrl.Margin.Bottom);
            }
        }

        private void OrderProductListForm_Load(object sender, EventArgs e)
        {
            SupplierComboBox.DataSource = SupplierQueries.GetSuppliers();
            SupplierComboBox.DisplayMember = "Name";
            SupplierComboBox.ValueMember = "ID";
            SupplierComboBox.SelectedIndex = -1;

            LoadProducts(FirstOrderControl);
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (SupplierComboBox.SelectedIndex == -1)
            {
                MessageBox.Show(this, @"Please select a customer.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var purchaseOrderProducts = GetOrderProducts();
            PurchaseOrderQueries.AddPurchaseOrder((int)SupplierComboBox.SelectedValue, purchaseOrderProducts);

            // Update product quantities
            foreach (var orderProduct in purchaseOrderProducts)
            {
                ProductQueries.UpdateProductQuantity(orderProduct.ProductId, +orderProduct.Quantity);
            }

            MessageBox.Show(this, @"Purchase order added successfully.", @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OpenChildForm(Parent as Panel, new ManagePurchaseOrderForm());
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(Parent as Panel, new ManageOrderForm());
        }

        private List<SwiftInventory.Common.Product> GetOrderProducts()
        {
            var orderProducts = new List<SwiftInventory.Common.Product>();

            foreach (Control ctrl in OrderFlowLayoutPanel.Controls)
            {
                if (!(ctrl is OrderControl orderCtrl)) continue;

                int productId = (int)orderCtrl.ProductComboBox.SelectedValue;
                int quantity = (int)orderCtrl.QuantityNumericUpDown.Value;
                decimal pricePerUnit = _productsDataTable.Rows.Find(productId).Field<decimal>("Price Per Unit");

                if (productId <= 0 || quantity <= 0)
                {
                    MessageBox.Show(@"Please select a product and quantity for each order item.");
                    return null;
                }

                orderProducts.Add(new SwiftInventory.Common.Product
                {
                    ProductId = productId,
                    Quantity = quantity,
                    PricePerUnit = pricePerUnit
                });
            }

            return orderProducts;
        }
    }
}
