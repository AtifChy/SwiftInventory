using SwiftInventory.Database;
using SwiftInventory.Forms.Common;
using System.Globalization;
using System.Windows.Forms;

namespace SwiftInventory.Forms.Main.Product
{
    public partial class ProductDetailsForm : BaseForm
    {
        private readonly int? _productId;
        private readonly string _productName;
        private readonly decimal _pricePerUnit;
        private readonly int _quantity;
        private readonly int _categoryId;
        private readonly int _supplierId;
        private readonly string _image;

        public ProductDetailsForm()
        {
            InitializeComponent();
        }

        public ProductDetailsForm(int productId)
        {
            InitializeComponent();
            _productId = productId;
            ProductQueries.GetProduct(_productId.Value, out _productName, out _pricePerUnit, out _quantity, out _categoryId, out _supplierId, out _image);
        }

        private void ProductDetailsForm_Load(object sender, System.EventArgs e)
        {
            PopulateCategoryComboBox();
            PopulateSupplierComboBox();

            if (_productId.HasValue)
            {
                ProductDetailsHeaderLabel.Text = @"Edit Product";
                SaveButton.Text = @"Update";
                NameTextBox.Text = _productName;
                CategoryComboBox.SelectedValue = _categoryId;
                SupplierComboBox.SelectedValue = _supplierId;
                QuantityTextBox.Text = _quantity.ToString();
                PriceTextBox.Text = _pricePerUnit.ToString(CultureInfo.CurrentCulture);
                ProductPictureBox.ImageLocation = _image;
            }
            else
            {
                ProductDetailsHeaderLabel.Text = @"Add Product";
                SaveButton.Text = @"Save";
            }
        }

        private void PopulateCategoryComboBox()
        {
            CategoryComboBox.DataSource = CategoryQueries.GetCategories();
            CategoryComboBox.DisplayMember = "Category Name";
            CategoryComboBox.ValueMember = "ID";
        }

        private void PopulateSupplierComboBox()
        {
            SupplierComboBox.DataSource = SupplierQueries.GetSuppliers();
            SupplierComboBox.DisplayMember = "Name";
            SupplierComboBox.ValueMember = "ID";
        }

        private void CancelButton_Click(object sender, System.EventArgs e)
        {
            OpenChildForm(Parent as Panel, new ManageProductForm());
        }

        private void UploadImageButton_Click(object sender, System.EventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                Filter = @"Image Files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png",
                Title = @"Select an image"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ProductPictureBox.ImageLocation = dialog.FileName;
            }
        }

        private void SaveButton_Click(object sender, System.EventArgs e)
        {
            string productName = NameTextBox.Text.Trim();
            string pricePerUnit = PriceTextBox.Text.Trim();
            string quantity = QuantityTextBox.Text.Trim();
            int categoryId = (int)CategoryComboBox.SelectedValue;
            int supplierId = (int)SupplierComboBox.SelectedValue;
            string image = ProductPictureBox.ImageLocation;

            if (string.IsNullOrWhiteSpace(productName) || string.IsNullOrWhiteSpace(pricePerUnit) || string.IsNullOrWhiteSpace(quantity))
            {
                MessageBox.Show(this, @"Please fill in all fields.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_productId.HasValue)
            {
                ProductQueries.AddProduct(productName, decimal.Parse(pricePerUnit), int.Parse(quantity), categoryId,
                    supplierId, image);
                MessageBox.Show(this, @"Product added successfully.", @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OpenChildForm(Parent as Panel, new ManageProductForm());
            }
            else
            {
                ProductQueries.UpdateProduct(_productId.Value, productName, decimal.Parse(pricePerUnit), int.Parse(quantity), categoryId, supplierId, image);
                MessageBox.Show(this, @"Product updated successfully.", @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OpenChildForm(Parent as Panel, new ManageProductForm());
            }
        }
    }
}
