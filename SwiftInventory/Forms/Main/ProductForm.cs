using SwiftInventory.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwiftInventory
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void ProductDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddNewCategoryLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(AddProductTextBox.Text))
            {
                CategoryQueries.AddCategory(AddProductTextBox.Text);
                ProductDataGridView.DataSource = CategoryQueries.GetAllCategories();
                AddProductTextBox.Text = string.Empty;
                MessageBox.Show(@"Product added successfully.");
            }
            else
            {
                MessageBox.Show(@"Product name cannot be empty.");
            }
        }

        private void AddproductText_TextChanged(object sender, EventArgs e)
        {

        }

        private void ManageProductLabel_Click(object sender, EventArgs e)
        {

        }

        private void roundButton1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CategoryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
