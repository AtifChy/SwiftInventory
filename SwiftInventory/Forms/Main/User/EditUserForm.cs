using SwiftInventory.Database;
using SwiftInventory.Forms.Common;
using System.Windows.Forms;

namespace SwiftInventory.Forms.Main.User
{
    public partial class EditUserForm : BaseForm
    {
        private readonly int _userId;

        public EditUserForm(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        private void EditUserForm_Load(object sender, System.EventArgs e)
        {
            RoleComboBox.Items.Add("Admin");
            RoleComboBox.Items.Add("Manager");
            RoleComboBox.Items.Add("Salesman");

            var user = UserQueries.GetUser(_userId);
            if (user != null)
            {
                UserNameText.Text = user["UserName"].ToString();
                UserEmailText.Text = user["Email"].ToString();
                RoleComboBox.Text = user["Role"].ToString();
                ApproveCheckBox.Checked = (bool)user["Approved"];
            }
        }

        private void SaveButton_Click(object sender, System.EventArgs e)
        {
            UserQueries.UpdateUser(_userId, role: RoleComboBox.Text, approved: ApproveCheckBox.Checked);
            OpenChildForm(Parent as Panel, new ManageUserForm());
        }
    }
}
