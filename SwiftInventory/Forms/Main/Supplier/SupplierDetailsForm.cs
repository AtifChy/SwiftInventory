using SwiftInventory.Database;
using SwiftInventory.Forms.Common;
using System;
using System.Windows.Forms;

namespace SwiftInventory.Forms.Main.Supplier
{
    public partial class SupplierDetailsForm : BaseForm
    {
        public SupplierDetailsForm()
        {
            InitializeComponent();
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

            if (SupplierQueries.AddSupplier(supplierName, supplierPhone, supplierAddress))
            {
                MessageBox.Show(@"Supplier added successfully", @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OpenChildForm(Parent as Panel, new ManageSupplierForm());
            }
            else
            {
                MessageBox.Show(@"Failed to add supplier", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
