using SwiftInventory.Database;
using SwiftInventory.Forms.Common;
using System;
using System.Data;
using System.Windows.Forms;

namespace SwiftInventory.Forms.Main.Customer
{
    public partial class ManageCustomerForm : BaseForm
    {
        public ManageCustomerForm()
        {
            InitializeComponent();
        }

        private void ManageCustomerForm_Load(object sender, EventArgs e)
        {
            CustomerDataGridView.DataSource = CustomerQueries.GetCustomers();
            CustomerDataGridView.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font("Segoe UI Variable Display Semib", 9.5F, System.Drawing.FontStyle.Regular);
            CustomerDataGridView.DefaultCellStyle.Font =
                new System.Drawing.Font("Segoe UI Variable Display Semib", 9, System.Drawing.FontStyle.Regular);

            FilterComboBox.Items.Add("Name");
            FilterComboBox.Items.Add("Phone");
            FilterComboBox.Items.Add("Email");
            FilterComboBox.Items.Add("Address");
            FilterComboBox.SelectedIndex = 0;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(Parent as Panel, new CustomerDetailsForm());
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                this,
                "Are you sure you want to delete this customer?",
                "Delete Customer",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int customerId = Convert.ToInt32(CustomerDataGridView.SelectedRows[0].Cells["ID"].Value);
                CustomerQueries.DeleteCustomer(customerId);
                CustomerDataGridView.DataSource = CustomerQueries.GetCustomers();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (CustomerDataGridView.SelectedRows.Count > 0)
            {
                int customerId = Convert.ToInt32(CustomerDataGridView.SelectedRows[0].Cells["ID"].Value);
                OpenChildForm(Parent as Panel, new CustomerDetailsForm(customerId, true));
            }
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            if (CustomerDataGridView.SelectedRows.Count > 0)
            {
                int customerId = Convert.ToInt32(CustomerDataGridView.SelectedRows[0].Cells["ID"].Value);
                OpenChildForm(Parent as Panel, new CustomerDetailsForm(customerId, false));
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string filterBy = FilterComboBox.SelectedItem.ToString();
            string filter = SearchTextBox.Text.Trim();
            ((DataTable)CustomerDataGridView.DataSource).DefaultView.RowFilter = $"[{filterBy}] LIKE '%{filter}%'";
        }
    }
}
