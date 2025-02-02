using SwiftInventory.Database;
using SwiftInventory.Forms.Common;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SwiftInventory.Forms.Main.Supplier
{
    public partial class ManageSupplierForm : BaseForm
    {
        public ManageSupplierForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(Parent as Panel, new SupplierDetailsForm());
        }

        private void ManageSupplierForm_Load(object sender, EventArgs e)
        {
            SupplierDataGridView.DataSource = SupplierQueries.GetAllSuppliers();
            SupplierDataGridView.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI Variable Display Semib", 9.5F, FontStyle.Regular);
            SupplierDataGridView.DefaultCellStyle.Font =
                new Font("Segoe UI Variable Display Semib", 9, FontStyle.Regular);

            FilterComboBox.Items.Add("Name");
            FilterComboBox.Items.Add("Phone");
            FilterComboBox.Items.Add("Address");
            FilterComboBox.SelectedIndex = 0;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var selectedRow = SupplierDataGridView.SelectedRows[0];
            var id = Convert.ToInt32(selectedRow.Cells["ID"].Value);
            if (SupplierQueries.DeleteSupplier(id))
            {
                MessageBox.Show(@"Supplier deleted successfully.");
                SupplierDataGridView.DataSource = SupplierQueries.GetAllSuppliers();
            }
            else
            {
                MessageBox.Show(@"Failed to delete supplier.");
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string filterBy = FilterComboBox.SelectedItem.ToString();
            string filter = SearchTextBox.Text.Trim();
            ((DataTable)SupplierDataGridView.DataSource).DefaultView.RowFilter = $"{filterBy} LIKE '%{filter}%'";
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (SupplierDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = SupplierDataGridView.SelectedRows[0];
                var id = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                OpenChildForm(Parent as Panel, new SupplierDetailsForm(id, true));
            }
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            if (SupplierDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = SupplierDataGridView.SelectedRows[0];
                var id = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                OpenChildForm(Parent as Panel, new SupplierDetailsForm(id, false));
            }
        }
    }
}
