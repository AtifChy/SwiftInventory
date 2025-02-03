using SwiftInventory.Forms.Common;
using SwiftInventory.Forms.Main.Product;
using SwiftInventory.Forms.Main.Supplier;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SwiftInventory.Forms.Main
{
    public partial class ManagerForm : BaseForm
    {
        private Button _activeButton;

        public ManagerForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            //HighlightButton(DashboardButton);
            //OpenChildForm(ChildFormPanel, new DashboardForm());
        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
           // HighlightButton(DashboardButton);
            //HeaderLabel.Text = @"Dashboard";
            //OpenChildForm(ChildFormPanel, new DashboardForm());
        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            HighlightButton(CategoryButton);
            HeaderLabel.Text = @"Category";
            OpenChildForm(ChildFormPanel, new CategoryForm());
        }

        private void ProductButton_Click(object sender, EventArgs e)
        {
            HighlightButton(InventoryButton);
            HeaderLabel.Text = @"Inventory";
            OpenChildForm(ChildFormPanel, new UserForm());
        }

        private void CustomerButton_Click(object sender, EventArgs e)
        {
            //HighlightButton(CustomerButton);
            //HeaderLabel.Text = @"Customer";
        }

        private void SupplierButton_Click(object sender, EventArgs e)
        {
            HighlightButton(SupplierButton);
            HeaderLabel.Text = @"Supplier";
            OpenChildForm(ChildFormPanel, new SupplierForm());
        }

        private void SalesButton_Click(object sender, EventArgs e)
        {
            HighlightButton(SalesButton);
            HeaderLabel.Text = @"Sales";
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            HighlightButton(OrderButton);
            HeaderLabel.Text = @"Order";
        }

        private void PurchaseOrderButton_Click(object sender, EventArgs e)
        {
            HighlightButton(PurchaseOrderButton);
            HeaderLabel.Text = @"Purchase Order";
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

        private void LogOutButton_Click(object sender, EventArgs e)
        {

        }

        private void LogOutButton_MouseEnter(object sender, EventArgs e)
        {
            LogOutButton.BackColor = Color.PaleVioletRed;
            LogOutButton.ForeColor = Color.Black;
            LogOutButton.IconColor = Color.Black;
        }

        private void LogOutButton_MouseLeave(object sender, EventArgs e)
        {
            LogOutButton.BackColor = Color.FromArgb(40, 39, 63);
            LogOutButton.ForeColor = Color.FromArgb(238, 238, 255);
            LogOutButton.IconColor = Color.FromArgb(238, 238, 255);
        }

        private void HighlightButton(Button button)
        {
            if (_activeButton != null)
            {
                _activeButton.BackColor = Color.FromArgb(40, 39, 63);
            }
            _activeButton = button;
            _activeButton.BackColor = Color.FromArgb(63, 62, 101);
        }

    }
}
