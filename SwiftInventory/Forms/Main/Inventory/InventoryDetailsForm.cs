using SwiftInventory.Database;
using SwiftInventory.Forms.Common;
using System.Windows.Forms;

namespace SwiftInventory.Forms.Main.Product
{
    public partial class InventoryDetailsForm : BaseForm
    {
        private readonly int? _inventoryId;

        public InventoryDetailsForm()
        {
            InitializeComponent();
        }

        public InventoryDetailsForm(int? inventoryId)
        {
            _inventoryId = inventoryId;
            InitializeComponent();
        }

        private void ProductDetailsForm_Load(object sender, System.EventArgs e)
        {
            if (_inventoryId.HasValue)
            {
                Text = @"Edit Inventory";
                SaveButton.Text = @"Update";
                /*ProductPictureBox.ImageLocation = ProductQueries.GetProductImage(_productId.Value);
                ProductNameTextBox.Text = ProductQueries.GetProductName(_productId.Value);
                PriceTextBox.Text = ProductQueries.GetProductPrice(_productId.Value).ToString();
                QuantityTextBox.Text = ProductQueries.GetProductQuantity(_productId.Value).ToString();
                CategoryComboBox.SelectedValue = ProductQueries.GetProductCategory(_productId.Value);
                SupplierComboBox.SelectedValue = ProductQueries.GetProductSupplier(_productId.Value);*/
            }
            else
            {
                Text = @"Add InventoryId";
                SaveButton.Text = @"Save";
            }
            PopulateCategoryComboBox();
            PopulateSupplierComboBox();
        }

        private void PopulateCategoryComboBox()
        {
            CategoryComboBox.DataSource = CategoryQueries.GetAllCategories();
            CategoryComboBox.DisplayMember = "Category Name";
            CategoryComboBox.ValueMember = "ID";
        }

        private void PopulateSupplierComboBox()
        {
            SupplierComboBox.DataSource = SupplierQueries.GetAllSuppliers();
            SupplierComboBox.DisplayMember = "Name";
            SupplierComboBox.ValueMember = "ID";
        }

        private void CancelButton_Click(object sender, System.EventArgs e)
        {
            OpenChildForm(Parent as Panel, new InventoryDetailsForm());
        }

        /*private void UploadImageButton_Click(object sender, System.EventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                Filter = @"Image Files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png",
                Title = @"Select an image"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                InventoryPictureBox.ImageLocation = dialog.FileName;
            }
        }*/

        private void SaveButton_Click(object sender, System.EventArgs e)
        {
            string inventorytName = NameTextBox.Text.Trim();
            string price = PriceTextBox.Text.Trim();
            string quantity = QuantityTextBox.Text.Trim();
            int categoryId = (int)CategoryComboBox.SelectedValue;
            int supplierId = (int)SupplierComboBox.SelectedValue;

            if (string.IsNullOrWhiteSpace(inventorytName) || string.IsNullOrWhiteSpace(price) || string.IsNullOrWhiteSpace(quantity))
            {
                MessageBox.Show(@"Inventory name cannot be empty.");
                return;
            }

            bool success = InventoryQueries.AddInventory(inventorytName, decimal.Parse(price), int.Parse(quantity), categoryId, supplierId);
            if (success)
            {
                MessageBox.Show(@"Inventory added successfully.");
                OpenChildForm(Parent as Panel, new InventoryDetailsForm());
            }
            else
            {
                MessageBox.Show(@"Failed to add Inventory.");
            }
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SupplierComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void label5_Click(object sender, System.EventArgs e)
        {

        }

        private void PriceTextBox_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void label6_Click(object sender, System.EventArgs e)
        {

        }

        private void QuantityTextBox_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void label3_Click(object sender, System.EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, System.EventArgs e)
        {

        }

        private void NameTextBox_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void label1_Click(object sender, System.EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProductDetailsHeaderLabel_Click(object sender, System.EventArgs e)
        {

        }

        private void ProductImageFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
