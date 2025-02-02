using SwiftInventory.Forms.Common;
using SwiftInventory.Forms.Main.Product;
using SwiftInventory.Forms.Main.Supplier;
using System;

namespace SwiftInventory.Forms.Main
{
    public partial class AdminForm : BaseForm
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            OpenChildForm(ChildFormPanel, new DashboardForm());
        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            HeaderLabel.Text = @"Dashboard";
            OpenChildForm(ChildFormPanel, new DashboardForm());
        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            HeaderLabel.Text = @"Category";
            OpenChildForm(ChildFormPanel, new CategoryForm());
        }

        private void ProductButton_Click(object sender, EventArgs e)
        {
            HeaderLabel.Text = @"Product";
            OpenChildForm(ChildFormPanel, new ProductForm());
        }

        private void CustomerButton_Click(object sender, EventArgs e)
        {
            HeaderLabel.Text = @"Customer";
        }

        private void SupplierButton_Click(object sender, EventArgs e)
        {
            HeaderLabel.Text = @"Supplier";
            OpenChildForm(ChildFormPanel, new SupplierForm());
        }

        private void SalesButton_Click(object sender, EventArgs e)
        {
            HeaderLabel.Text = @"Sales";
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            MenuPanel.Visible = !MenuPanel.Visible;
        }

        private void MenuPanel_VisibleChanged(object sender, EventArgs e)
        {
            MainTable.ColumnStyles[0].Width = MenuPanel.Visible ? 300F : 0F;

            MainTable.PerformLayout();
        }
    }
}
