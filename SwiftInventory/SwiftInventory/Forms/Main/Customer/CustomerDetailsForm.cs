using SwiftInventory.Database;
using SwiftInventory.Forms.Common;
using System;
using System.Windows.Forms;

namespace SwiftInventory.Forms.Main.Customer
{
    public partial class CustomerDetailsForm : BaseForm
    {
        private readonly int? _customerId;
        private bool editable;

        public CustomerDetailsForm()
        {
            InitializeComponent();
        }

        public CustomerDetailsForm(int customerId, bool editable)
        {
            InitializeComponent();
            _customerId = customerId;
            this.editable = editable;
        }

        private void CustomerDetailsForm_Load(object sender, EventArgs e)
        {
            if (_customerId.HasValue)
            {
                if (!editable)
                {
                    CustomerDetailsHeaderLabel.Text = @"Customer Details";
                    SaveButton.Visible = false;
                    btnCancel.Text = @"Close";
                    NameTextBox.ReadOnly = true;
                    AddressTextBox.ReadOnly = true;
                    PhoneTextBox.ReadOnly = true;
                    EmailTextBox.ReadOnly = true;
                }
                else
                {
                    CustomerDetailsHeaderLabel.Text = @"Edit Customer";
                }

                var customer = CustomerQueries.GetCustomer(_customerId.Value);
                if (customer != null)
                {
                    NameTextBox.Text = customer["Name"].ToString();
                    AddressTextBox.Text = customer["Address"].ToString();
                    PhoneTextBox.Text = customer["Phone"].ToString();
                    EmailTextBox.Text = customer["Email"].ToString();  // Added Email field
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            OpenChildForm(Parent as Panel, new ManageCustomerForm());
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var customerName = NameTextBox.Text;
            var customerAddress = AddressTextBox.Text;
            var customerPhone = PhoneTextBox.Text;
            var customerEmail = EmailTextBox.Text;

            if (string.IsNullOrWhiteSpace(customerName) || string.IsNullOrWhiteSpace(customerAddress) ||
                string.IsNullOrWhiteSpace(customerPhone) || string.IsNullOrWhiteSpace(customerEmail))
            {
                MessageBox.Show(@"Please fill all fields", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SaveCustomer(customerName, customerPhone, customerAddress, customerEmail);
        }

        private void SaveCustomer(string customerName, string customerPhone, string customerAddress, string customerEmail)
        {
            bool success;
            string message;

            if (!_customerId.HasValue)
            {
                success = CustomerQueries.AddCustomer(customerName, customerPhone, customerAddress, customerEmail);
                message = success ? @"Customer added successfully" : @"Failed to add customer";
            }
            else
            {
                success = CustomerQueries.UpdateCustomer(_customerId.Value, customerName, customerPhone, customerAddress, customerEmail);
                message = success ? @"Customer updated successfully" : @"Failed to update customer";
            }

            MessageBox.Show(message,
                success ? @"Success" : @"Error", MessageBoxButtons.OK,
                success ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            if (success)
            {
                OpenChildForm(Parent as Panel, new ManageCustomerForm());
            }
        }
    }
}
