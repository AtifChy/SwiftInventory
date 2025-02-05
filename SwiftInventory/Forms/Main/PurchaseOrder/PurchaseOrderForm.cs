using SwiftInventory.Forms.Common;
using SwiftInventory.Forms.Main.Order;
using System;

namespace SwiftInventory.Forms.Main.PurchaseOrder
{
    public partial class PurchaseOrderForm : BaseForm
    {
        public PurchaseOrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            OpenChildForm(ChildFormPanel, new ManagePurchaseOrderForm());
        }
    }
}
