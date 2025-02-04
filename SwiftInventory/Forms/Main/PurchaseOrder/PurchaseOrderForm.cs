using SwiftInventory.Forms.Common;
using System;

namespace SwiftInventory.Forms.Main.Order
{
    public partial class PurchaseOrderForm : BaseForm
    {
        public PurchaseOrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            OpenChildForm(ChildFormPanel, new ManageOrderForm());
        }
    }
}
