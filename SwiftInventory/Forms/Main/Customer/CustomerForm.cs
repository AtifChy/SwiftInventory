using SwiftInventory.Forms.Common;
using System;

namespace SwiftInventory.Forms.Main.Customer
{
    public partial class CustomerForm : BaseForm
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            OpenChildForm(ChildFormPanel, new ManageCustomerForm());
        }
    }
}
