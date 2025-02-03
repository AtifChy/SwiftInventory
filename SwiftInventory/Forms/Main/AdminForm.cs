using SwiftInventory.Forms.Common;
using SwiftInventory.Forms.Main.Product;
using SwiftInventory.Forms.Main.Supplier;
using SwiftInventory.Forms.Main.Customer;

using System;

namespace SwiftInventory.Forms.Main
{
    public partial class AdminForm : BaseForm
    {
        public AdminForm()
        {
            InitializeComponent();
<<<<<<< HEAD
=======
            //OpenChildForm(new DashboardForm());
>>>>>>> origin/akash-pc
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
<<<<<<< HEAD
            OpenChildForm(ChildFormPanel, new ProductForm());
=======
            OpenChildForm(new ProductForm());        
>>>>>>> origin/akash-pc
        }

        private void CustomerButton_Click(object sender, EventArgs e)
        {
            HeaderLabel.Text = @"Customer";
<<<<<<< HEAD
            OpenChildForm(ChildFormPanel, new CustomerForm());
=======
            OpenChildForm(new CustomerFrorm());
>>>>>>> origin/akash-pc
        }

        private void SupplierButton_Click(object sender, EventArgs e)
        {
            HeaderLabel.Text = @"Supplier";
<<<<<<< HEAD
            OpenChildForm(ChildFormPanel, new SupplierForm());
=======
            OpenChildForm(new SupplierForm());
>>>>>>> origin/akash-pc
        }

        private void SalesButton_Click(object sender, EventArgs e)
        {
            HeaderLabel.Text = @"Sales";
            OpenChildForm(new SalesForm());
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
