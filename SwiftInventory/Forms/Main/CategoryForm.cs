using SwiftInventory.Database;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SwiftInventory.Forms.Main
{
    public partial class CategoryForm : Form
    {
        private bool _editMode;

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
                if (_editMode)
                {
                    // Update category
                    var selectedRow = CategoryDataGridView.SelectedRows[0];
                    var id = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                    CategoryQueries.UpdateCategory(id, AddCategoryText.Text);
                    MessageBox.Show(@"Category updated successfully.");
                    _editMode = false;
                }
                else
                {
                    // Add new category
                    CategoryQueries.AddCategory(AddCategoryText.Text);
                    MessageBox.Show(@"Category added successfully.");
                }

                CategoryDataGridView.DataSource = CategoryQueries.GetAllCategories();
                ResetForm();
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

        private void EditButton_Click(object sender, EventArgs e)
        {
            AddNewCategoryLabel.Text = @"Edit Category";
            AddCategoryButton.Text = @"Update";
            CancelButton.Visible = true;

            if (CategoryDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = CategoryDataGridView.SelectedRows[0];
                var id = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                AddCategoryText.Text = selectedRow.Cells["Category Name"].Value.ToString();
                _editMode = true;
            }
            else
            {
                MessageBox.Show(@"Please select a category to edit.");
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            AddCategoryText.Text = string.Empty;
            AddNewCategoryLabel.Text = @"Add New Category";
            AddCategoryButton.Text = @"Add";
            CancelButton.Visible = false;
        }
    }
}
