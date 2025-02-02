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
                new Font("Segoe UI Variable Display", 9.5F, FontStyle.Regular);
            SupplierDataGridView.DefaultCellStyle.Font =
                new Font("Segoe UI Variable Display", 9, FontStyle.Regular);
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
            string filter = SearchTextBox.Text.Trim();
            (SupplierDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"Name LIKE '%{filter}%'";
        }
    }
}
