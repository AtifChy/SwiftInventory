﻿using SwiftInventory.Database;
using System;
using System.Data;
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
            CategoryDataGridView.DataSource = CategoryQueries.GetCategories();
            CategoryDataGridView.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI Variable Display Semib", 9.5F, FontStyle.Regular);
            CategoryDataGridView.DefaultCellStyle.Font =
                new Font("Segoe UI Variable Display Semib", 9, FontStyle.Regular);
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
                    MessageBox.Show(this, @"Category updated successfully.", @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _editMode = false;
                }
                else
                {
                    // Add new category
                    CategoryQueries.AddCategory(AddCategoryText.Text);
                    MessageBox.Show(this, @"Category added successfully.", @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                CategoryDataGridView.DataSource = CategoryQueries.GetCategories();
                ResetForm();
            }
            else
            {
                MessageBox.Show(this, @"Please enter a category name.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int selectedRowCount = CategoryDataGridView.SelectedRows.Count;
            if (selectedRowCount > 0)
            {
                foreach (DataGridViewRow row in CategoryDataGridView.SelectedRows)
                {
                    var id = Convert.ToInt32(row.Cells["ID"].Value);
                    CategoryQueries.DeleteCategory(id);
                }

                CategoryDataGridView.DataSource = CategoryQueries.GetCategories();
                string message = selectedRowCount > 1
                    ? @"Categories deleted successfully"
                    : @"Category deleted successfully";
                MessageBox.Show(this, message, @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(this, @"Please select a category to delete.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(this, @"Please select a category to edit.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string filter = SearchTextBox.Text.Trim();
            ((DataTable)CategoryDataGridView.DataSource).DefaultView.RowFilter = $"[Category Name] LIKE '%{filter}%'";
        }
    }
}
