using SwiftInventory.Database;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SwiftInventory.Forms.Main
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            CategoryDataGridView.DataSource = CategoryQueries.GetAllCategories();
            CategoryDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Variable Display", 9.5F, FontStyle.Regular);
        }

        private void AddCategoryButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(AddCategoryText.Text))
            {
                CategoryQueries.AddCategory(AddCategoryText.Text);
                CategoryDataGridView.DataSource = CategoryQueries.GetAllCategories();
                AddCategoryText.Text = string.Empty;
                MessageBox.Show(@"Category added successfully.");
            }
            else
            {
                MessageBox.Show(@"Category name cannot be empty.");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (CategoryDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = CategoryDataGridView.SelectedRows[0];
                var id = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                CategoryQueries.DeleteCategory(id);
                CategoryDataGridView.DataSource = CategoryQueries.GetAllCategories();
                MessageBox.Show(@"Category deleted successfully.");
            }
            else
            {
                MessageBox.Show(@"Please select a category to delete.");
            }
        }
    }
}
