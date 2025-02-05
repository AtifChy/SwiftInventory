using SwiftInventory.Database;
using SwiftInventory.Forms.Common;
using System;
using System.Data;
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
            ProductDataGridView.DataSource = ProductQueries.GetProducts();
            ProductDataGridView.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI Variable Display Semib", 9.5F, FontStyle.Regular);
            ProductDataGridView.DefaultCellStyle.Font =
                new Font("Segoe UI Variable Display Semib", 9, FontStyle.Regular);

            FilterComboBox.Items.Add("Product Name");
            FilterComboBox.Items.Add("Category");
            FilterComboBox.Items.Add("Supplier");
            FilterComboBox.SelectedIndex = 0;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(Parent as Panel, new ProductDetailsForm());
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (ProductDataGridView.SelectedRows.Count > 0)
            {
                int productId = Convert.ToInt32(ProductDataGridView.SelectedRows[0].Cells["ID"].Value);
                OpenChildForm(Parent as Panel, new ProductDetailsForm(productId));
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ProductDataGridView.SelectedRows.Count <= 0) return;

            var selectedRow = ProductDataGridView.SelectedRows[0];
            var productId = Convert.ToInt32(selectedRow.Cells["ID"].Value);

            var result = MessageBox.Show(this,
                @"Are you sure you want to delete this product?",
                @"Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;

            ProductQueries.DeleteProduct(productId);
            MessageBox.Show(this,
                @"Product deleted successfully.",
                @"Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            ProductDataGridView.DataSource = ProductQueries.GetProducts();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string filterBy = FilterComboBox.SelectedItem.ToString();
            string filter = SearchTextBox.Text.Trim();
            ((DataTable)ProductDataGridView.DataSource).DefaultView.RowFilter = $"[{filterBy}] LIKE '%{filter}%'";
        }
    }
}
