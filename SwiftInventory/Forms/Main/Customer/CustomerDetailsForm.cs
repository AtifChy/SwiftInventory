using SwiftInventory.Database;
using SwiftInventory.Forms.Common;
using System;
using System.Windows.Forms;

namespace SwiftInventory.Forms.Main.Customer
{
    public partial class CustomerDetailsForm : BaseForm
    {
        private readonly int? _customerId;
        private readonly bool _editable;

        public CustomerDetailsForm()
        {
            InitializeComponent();
        }

        public CustomerDetailsForm(int customerId, bool editable)
        {
            InitializeComponent();
            _customerId = customerId;
            _editable = editable;
        }

        private void CustomerDetailsForm_Load(object sender, EventArgs e)
        {
            if (!_customerId.HasValue) return;

            if (!_editable)
            {
                CustomerDetailsHeaderLabel.Text = @"Customer Details";
                SaveButton.Visible = false;
                CancelButton.Text = @"Close";
                CustomerNameText.ReadOnly = true;
                CustomerEmailText.ReadOnly = true;
                CustomerPhoneText.ReadOnly = true;
                CustomerAddressText.ReadOnly = true;
            }
            else
            {
                CustomerDetailsHeaderLabel.Text = @"Edit Customer";
            }

            var customer = CustomerQueries.GetCustomer(_customerId.Value);
            if (customer == null) return;

            CustomerNameText.Text = customer["Name"].ToString();
            CustomerEmailText.Text = customer["Email"].ToString();
            CustomerPhoneText.Text = customer["Phone"].ToString();
            CustomerAddressText.Text = customer["Address"].ToString();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(Parent as Panel, new ManageCustomerForm());
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string name = CustomerNameText.Text;
            string email = CustomerEmailText.Text;
            string phone = CustomerPhoneText.Text;
            string address = CustomerAddressText.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(address))
            {
                MessageBox.Show(@"Please fill all fields", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CustomerQueries.AddCustomer(name, email, phone, address);
            MessageBox.Show(@"Customer added successfully", @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OpenChildForm(Parent as Panel, new ManageCustomerForm());
        }
    }
}
