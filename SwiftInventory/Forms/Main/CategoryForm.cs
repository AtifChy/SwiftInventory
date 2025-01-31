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

        private void AddNewCategoryLabel_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CategoryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ManageCategoryLabel_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddCategoryText_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundButton2_Click(object sender, EventArgs e)
        {

        }

        private void roundButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
