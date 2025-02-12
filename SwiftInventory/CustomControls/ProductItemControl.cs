using SwiftInventory.Common;
using System.Globalization;
using System.Windows.Forms;

namespace SwiftInventory.CustomControls
{
    public partial class ProductItemControl : UserControl
    {
        public PictureBox ProductPictureBox { get; set; }

        public TextBox ProductNameText { get; set; }

        public NumericUpDown QuantityNumericUpDown { get; set; }

        public TextBox SubtotalTextBox { get; set; }

        public ProductItemControl()
        {
            InitializeComponent();
        }

        public void SetProductItemData(Product product)
        {
            ProductPictureBox.ImageLocation = product.ProductImage;
            ProductNameText.Text = product.ProductName;
            QuantityNumericUpDown.Value = product.Quantity;
            SubtotalTextBox.Text = product.Subtotal.ToString(CultureInfo.CurrentCulture);
        }
    }
}
