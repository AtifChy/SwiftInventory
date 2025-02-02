using SwiftInventory.Database;
using SwiftInventory.Forms.Common;
using System;
using System.Drawing;
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
            ProductDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Variable Display", 9.5F, FontStyle.Regular);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(Parent as Panel, new ProductDetailsForm());
        }
    }
}
