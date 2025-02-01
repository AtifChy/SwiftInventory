using SwiftInventory.Database;
using SwiftInventory.Forms.Common;
using System.Windows.Forms;

namespace SwiftInventory.Forms.Main.Product
{
    public partial class AddProductForm : BaseForm
    {
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void ProductDetailsForm_Load(object sender, System.EventArgs e)
        {
            PopulateCategoryComboBox();
        }

        private void PopulateCategoryComboBox()
        {
            CategoryComboBox.DataSource = CategoryQueries.GetAllCategories();
            CategoryComboBox.DisplayMember = "Category Name";
            CategoryComboBox.ValueMember = "ID";
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
    }
}
