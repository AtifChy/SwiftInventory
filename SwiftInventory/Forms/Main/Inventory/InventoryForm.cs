using SwiftInventory.Forms.Common;
using System;

namespace SwiftInventory.Forms.Main.Product
{
    public partial class UserForm : BaseForm
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            OpenChildForm(ChildFormPanel, new ManageUserForm());
        }
    }
}
