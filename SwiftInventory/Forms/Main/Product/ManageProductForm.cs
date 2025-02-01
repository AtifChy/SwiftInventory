using SwiftInventory.Database;
using SwiftInventory.Forms.Common;
using System;
using System.Windows.Forms;

namespace SwiftInventory.Forms.Main.Product
{
    public partial class ManageProductForm : BaseForm
    {
        public ManageProductForm()
        {
            InitializeComponent();
        }

        private void ManageProductForm_Load(object sender, EventArgs e)
        {
            ProductDataGridView.DataSource = ProductQueries.GetAllProducts();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(Parent as Panel, new AddProductForm());
        }
    }
}
