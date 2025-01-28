using System;
using System.Windows.Forms;

namespace SwiftInventory.Forms.Main
{
    public partial class AdminForm : Form
    {
        private Form _activeForm = null;

        public AdminForm()
        {
            InitializeComponent();
            OpenChildForm(new DashboardForm());
        }

        private void OpenChildForm(Form childForm)
        {
            _activeForm?.Close();
            _activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            ChildFormPanel.Controls.Add(childForm);
            ChildFormPanel.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            HeaderLabel.Text = @"Dashboard";
            OpenChildForm(new DashboardForm());
        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            HeaderLabel.Text = @"Category";
            OpenChildForm(new CategoryForm());
        }

        private void ProductButton_Click(object sender, EventArgs e)
        {
            HeaderLabel.Text = @"Product";
        }

        private void CustomerButton_Click(object sender, EventArgs e)
        {
            HeaderLabel.Text = @"Customer";
        }

        private void SupplierButton_Click(object sender, EventArgs e)
        {
            HeaderLabel.Text = @"Supplier";
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
