using SwiftInventory.Forms.Common;

namespace SwiftInventory.Forms.Auth
{
    public partial class AuthForm : BaseForm
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void AuthForm_Load(object sender, System.EventArgs e)
        {
            OpenChildForm(MainPanel, new LoginForm());
        }
    }
}
