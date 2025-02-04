using SwiftInventory.Database;
using SwiftInventory.Forms.Common;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SwiftInventory.Forms.Main.Customer
{
    public partial class ManageCustomerForm : BaseForm
    {
        public ManageCustomerForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(Parent as Panel, new CustomerDetailsForm());
        }

        private void ManageCustomerForm_Load(object sender, EventArgs e)
        {
            CustomerDataGridView.DataSource = CustomerQueries.GetAllCustomers();
            CustomerDataGridView.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI Variable Display", 9.5F, FontStyle.Regular);
            CustomerDataGridView.DefaultCellStyle.Font =
                new Font("Segoe UI Variable Display", 9, FontStyle.Regular);

            FilterComboBox.Items.Add("Name");
            FilterComboBox.Items.Add("Phone");
            FilterComboBox.Items.Add("Address");
            FilterComboBox.Items.Add("Email"); // Added email filter
            FilterComboBox.SelectedIndex = 0;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (CustomerDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = CustomerDataGridView.SelectedRows[0];
                var id = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                if (CustomerQueries.DeleteCustomer(id))
                {
                    MessageBox.Show(@"Customer deleted successfully.");
                    CustomerDataGridView.DataSource = CustomerQueries.GetAllCustomers();
                }
                else
                {
                    MessageBox.Show(@"Failed to delete customer.");
                }
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string filterBy = FilterComboBox.SelectedItem.ToString();
            string filter = SearchTextBox.Text.Trim();
            ((DataTable)CustomerDataGridView.DataSource).DefaultView.RowFilter = $"{filterBy} LIKE '%{filter}%'";
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (CustomerDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = CustomerDataGridView.SelectedRows[0];
                var id = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                OpenChildForm(Parent as Panel, new CustomerDetailsForm(id, true));
            }
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            if (CustomerDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = CustomerDataGridView.SelectedRows[0];
                var id = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                OpenChildForm(Parent as Panel, new CustomerDetailsForm(id, false));
            }
        }

        private void ManageCustomerLabel_Click(object sender, EventArgs e)
        {

        }

        private void roundButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
