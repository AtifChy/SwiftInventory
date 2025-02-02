using SwiftInventory.Database;
using SwiftInventory.Forms.Common;
using System;
using System.Windows.Forms;

namespace SwiftInventory.Forms.Main.Supplier
{
    public partial class SupplierDetailsForm : BaseForm
    {
        private readonly int? _supplierId;
        private bool editable;

        public SupplierDetailsForm()
        {
            InitializeComponent();
        }

        public SupplierDetailsForm(int supplierId, bool editable)
        {
            InitializeComponent();
            _supplierId = supplierId;
            this.editable = editable;
        }
        private void SupplierDetailsForm_Load(object sender, EventArgs e)
        {
            if (_supplierId.HasValue)
            {

                if (!editable)
                {
                    SupplierDetailsHeaderLabel.Text = @"Supplier Details";
                    SaveButton.Visible = false;
                    CancelButton.Text = @"Close";
                    NameTextBox.ReadOnly = true;
                    AddressTextBox.ReadOnly = true;
                    PhoneTextBox.ReadOnly = true;
                }
                else
                {
                    SupplierDetailsHeaderLabel.Text = @"Edit Supplier";
                }

                var supplier = SupplierQueries.GetSupplier(_supplierId.Value);
                if (supplier != null)
                {
                    NameTextBox.Text = supplier["Name"].ToString();
                    AddressTextBox.Text = supplier["Address"].ToString();
                    PhoneTextBox.Text = supplier["Phone"].ToString();
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(Parent as Panel, new ManageSupplierForm());
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var supplierName = NameTextBox.Text;
            var supplierAddress = AddressTextBox.Text;
            var supplierPhone = PhoneTextBox.Text;

            if (string.IsNullOrWhiteSpace(supplierName) || string.IsNullOrWhiteSpace(supplierAddress) || string.IsNullOrWhiteSpace(supplierPhone))
            {
                MessageBox.Show(@"Please fill all fields", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SaveSupplier(supplierName, supplierPhone, supplierAddress);
        }

        private void SaveSupplier(string supplierName, string supplierPhone, string supplierAddress)
        {
            bool success;
            string message;

            if (!_supplierId.HasValue)
            {
                success = SupplierQueries.AddSupplier(supplierName, supplierPhone, supplierAddress);
                message = success ? @"Supplier added successfully" : @"Failed to add supplier";
            }
            else
            {
                success = SupplierQueries.UpdateSupplier(_supplierId.Value, supplierName, supplierPhone, supplierAddress);
                message = success ? @"Supplier updated successfully" : @"Failed to update supplier";
            }

            MessageBox.Show(message,
                success ? @"Success" : @"Error", MessageBoxButtons.OK,
                success ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            if (success)
            {
                OpenChildForm(Parent as Panel, new ManageSupplierForm());
            }
        }
    }
}
