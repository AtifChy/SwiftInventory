using SwiftInventory.Forms.Common;
using System;

namespace SwiftInventory.Forms.Main.Product
{
    public partial class ProductForm : BaseForm
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            OpenChildForm(ChildFormPanel, new ManageProductForm());
        }
    }
}
