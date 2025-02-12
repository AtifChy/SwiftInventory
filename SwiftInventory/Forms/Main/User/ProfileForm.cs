using SwiftInventory.Common;
using SwiftInventory.Database;
using SwiftInventory.Forms.Common;
using System.Windows.Forms;

namespace SwiftInventory.Forms.Main.User
{
    public partial class ProfileForm : BaseForm
    {
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void ProfileForm_Load(object sender, System.EventArgs e)
        {
            RoleComboBox.DataSource = new[] { "Admin", "Manager", "Salesman" };

            var user = UserQueries.GetUser(UserSession.UserName);
            UsernameTextBox.Text = user["Username"].ToString();
            EmailTextBox.Text = user["Email"].ToString();
            RoleComboBox.SelectedItem = user["Role"].ToString();
        }

        private void SignUpButton_Click(object sender, System.EventArgs e)
        {
            if (PasswordTextBox.Text == ConfirmPasswordTextBox.Text)
            {
                bool approved = RoleComboBox.Text == UserSession.Role;

                if (!approved)
                {
                    var result = MessageBox.Show(
                        this,
                        "You are changing the role. Are you sure you want to continue?\nNOTE: You will need admin approval for next login.",
                        @"Change Role",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                }

                UserQueries.UpdateUser(UserSession.UserId, userName: UsernameTextBox.Text, email: EmailTextBox.Text, password: PasswordTextBox.Text, role: RoleComboBox.Text, approved: approved);
                MessageBox.Show(this, @"Profile updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(this, @"Passwords do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
