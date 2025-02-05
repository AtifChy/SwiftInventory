using SwiftInventory.Forms.Common;

namespace SwiftInventory.Forms.Main.User
{
    public partial class UserForm : BaseForm
    {
        public UserForm()
        {
            InitializeComponent();
            OpenChildForm(ChildFormPanel, new ManageUserForm());
        }
    }
}
