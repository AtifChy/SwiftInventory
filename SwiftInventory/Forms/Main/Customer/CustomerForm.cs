using SwiftInventory.Forms.Common;

namespace SwiftInventory.Forms.Main.Customer
{
    public partial class CustomerForm : BaseForm
    {
        public CustomerForm()
        {
            InitializeComponent();
            OpenChildForm(ChildFormPanel, new ManageCustomerForm());
        }
    }
}
