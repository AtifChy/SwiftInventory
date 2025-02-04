using System.Windows.Forms;

namespace SwiftInventory.CustomControls
{
    public partial class InfoOrderControl : UserControl
    {
        public PictureBox ProductPictureBox
        {
            get => productPicture;
            set => productPicture = value;
        }

        public TextBox ProductNameText
        {
            get => _productNameText;
            set => _productNameText = value;
        }

        public NumericUpDown QuantityNumericUpDown
        {
            get => quantityNumericUpDown;
            set => quantityNumericUpDown = value;
        }

        public TextBox SubtotalTextBox
        {
            get => _subtotalTextBox;
            set => _subtotalTextBox = value;
        }

        public InfoOrderControl()
        {
            InitializeComponent();
        }
    }
}
