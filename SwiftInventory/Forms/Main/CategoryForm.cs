using SwiftInventory.Database;
using System;
using System.Windows.Forms;

namespace SwiftInventory.Forms.Main
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
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

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            CategoryDataGridView.DataSource = CategoryQueries.GetAllCategories();
        }
    }
}
