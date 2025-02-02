using SwiftInventory.Database;
using SwiftInventory.Forms.Common;
using System.Windows.Forms;

namespace SwiftInventory.Forms.Main.Product
{
    public partial class ProductDetailsForm : BaseForm
    {
        private readonly int? _productId;

        public ProductDetailsForm()
        {
            InitializeComponent();
        }

        public ProductDetailsForm(int? productId)
        {
            _productId = productId;
            InitializeComponent();
        }

        private void ProductDetailsForm_Load(object sender, System.EventArgs e)
        {
            if (_productId.HasValue)
            {
                Text = @"Edit Product";
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
                Text = @"Add Product";
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

        }
    }
}
