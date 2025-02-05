using SwiftInventory.Database;
using SwiftInventory.Forms.Common;
using System;
using System.Windows.Forms;

namespace SwiftInventory.Forms.Main.User
{
    public partial class ManageUserForm : BaseForm
    {
        public ManageUserForm()
        {
            InitializeComponent();
        }
        private void ManageUserForm_Load(object sender, EventArgs e)
        {
            UserDataGridView.DataSource = UserQueries.GetUsers();
            UserDataGridView.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9.5F, System.Drawing.FontStyle.Regular);
            UserDataGridView.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9, System.Drawing.FontStyle.Regular);
        }

        private void ApproveButton_Click(object sender, EventArgs e)
        {
            if (UserDataGridView.SelectedRows.Count > 0)
            {
                int userId = Convert.ToInt32(UserDataGridView.SelectedRows[0].Cells["ID"].Value);
                UserQueries.ApproveUser(userId);
                UserDataGridView.DataSource = UserQueries.GetUsers();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (UserDataGridView.SelectedRows.Count > 0)
            {
                int userId = Convert.ToInt32(UserDataGridView.SelectedRows[0].Cells["ID"].Value);
                OpenChildForm(Parent as Panel, new EditUserForm(userId));
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
