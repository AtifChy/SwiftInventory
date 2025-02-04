using SwiftInventory.Forms.Common;
using System;

namespace SwiftInventory.Forms.Main.Order
{
    public partial class OrderForm : BaseForm
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            OpenChildForm(ChildFormPanel, new ManageOrderForm());
        }
    }
}
