using SwiftInventory.Forms.Common;
using System;

namespace SwiftInventory.Forms.Main.Supplier
{
    public partial class SupplierForm : BaseForm
    {
        public SupplierForm()
        {
            InitializeComponent();
        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            OpenChildForm(ChildFormPanel, new ManageSupplierForm());
        }
    }
}
