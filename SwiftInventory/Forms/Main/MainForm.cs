using SwiftInventory.Common;
using SwiftInventory.Forms.Auth;
using SwiftInventory.Forms.Common;
using SwiftInventory.Forms.Main.Customer;
using SwiftInventory.Forms.Main.Order;
using SwiftInventory.Forms.Main.Product;
using SwiftInventory.Forms.Main.PurchaseOrder;
using SwiftInventory.Forms.Main.Supplier;
using SwiftInventory.Forms.Main.User;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SwiftInventory.Forms.Main
{
    public partial class MainForm : BaseForm
    {
        private Button _activeButton;

        public MainForm()
        {
            InitializeComponent();

            if (string.Equals(UserSession.Role, "Manager", StringComparison.OrdinalIgnoreCase))
            {
                SystemUsersButton.Visible = false;
            }
            else if (string.Equals(UserSession.Role, "Salesman", StringComparison.OrdinalIgnoreCase))
            {
                SystemUsersButton.Visible = false;
                SupplierButton.Visible = false;
                CategoryButton.Visible = false;
                ProductButton.Visible = false;
                PurchaseOrderButton.Visible = false;
            }
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            UserNameLabel.Text = UserSession.UserName;
            UserRoleLabel.Text = $@"({UserSession.Role})";

            CenterUsernameAndRole();

            HighlightButton(DashboardButton);
            OpenChildForm(ChildFormPanel, new DashboardForm());
        }

        private void CenterUsernameAndRole()
        {
            foreach (Control ctrl in UserStatusPanel.Controls)
            {
                ctrl.Width = UserStatusPanel.ClientSize.Width - 20;

                int horizontalMargin = (UserStatusPanel.ClientSize.Width - ctrl.Width) / 2;
                if (horizontalMargin < 0)
                {
                    horizontalMargin = 0;
                }

                ctrl.Margin = new Padding(horizontalMargin, 0, horizontalMargin, 0);
            }
        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            HighlightButton(DashboardButton);
            HeaderLabel.Text = @"Dashboard";
            OpenChildForm(ChildFormPanel, new DashboardForm());
        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            HighlightButton(CategoryButton);
            HeaderLabel.Text = @"Category";
            OpenChildForm(ChildFormPanel, new CategoryForm());
        }

        private void ProductButton_Click(object sender, EventArgs e)
        {
            HighlightButton(ProductButton);
            HeaderLabel.Text = @"Product";
            OpenChildForm(ChildFormPanel, new ProductForm());
        }

        private void CustomerButton_Click(object sender, EventArgs e)
        {
            HighlightButton(CustomerButton);
            HeaderLabel.Text = @"Customer";
            OpenChildForm(ChildFormPanel, new CustomerForm());
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
            OpenChildForm(ChildFormPanel, new OrderForm());
        }

        private void PurchaseOrderButton_Click(object sender, EventArgs e)
        {
            HighlightButton(PurchaseOrderButton);
            HeaderLabel.Text = @"Purchase Order";
            OpenChildForm(ChildFormPanel, new PurchaseOrderForm());
        }

        private void SystemUsersButton_Click(object sender, EventArgs e)
        {
            HighlightButton(SystemUsersButton);
            HeaderLabel.Text = @"System Users";
            OpenChildForm(ChildFormPanel, new UserForm());
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
            DialogResult result = MessageBox.Show(this, @"Are you sure you want to log out?", @"Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Hide();
                var loginForm = new LoginForm();
                loginForm.Show();
                loginForm.Closed += (s, args) => Close();
            }
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
