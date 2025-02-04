using System;
using System.Windows.Forms;

namespace SwiftInventory.CustomControls
{
    public partial class OrderControl : UserControl
    {
        public ComboBox ProductComboBox => productComboBox;
        public NumericUpDown QuantityNumericUpDown => quantityNumericUpDown;
        public RoundButton RemoveButton => removeButton;

        public new event EventHandler ControlRemoved;

        public OrderControl()
        {
            InitializeComponent();
        }

        private void removeButton1_Click(object sender, System.EventArgs e)
        {
            if (Parent is Control parent)
            {
                parent.Controls.Remove(this);
                OnControlRemoved(EventArgs.Empty);
            }
        }

        protected virtual void OnControlRemoved(EventArgs e)
        {
            ControlRemoved?.Invoke(this, e);
        }
    }
}
