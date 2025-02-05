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

            RoleComboBox.Items.Add("Admin");
            RoleComboBox.Items.Add("Manager");
            RoleComboBox.Items.Add("Salesman");
        }

        private void ProfileForm_Load(object sender, System.EventArgs e)
        {
            var user = UserQueries.GetUser(UserSession.UserName);
            UsernameTextBox.Text = user["Username"].ToString();
            EmailTextBox.Text = user["Email"].ToString();
            RoleComboBox.SelectedItem = user["Role"].ToString();
        }

        private void SignUpButton_Click(object sender, System.EventArgs e)
        {
            if (PasswordTextBox.Text == ConfirmPasswordTextBox.Text)
            {
                UserQueries.UpdateUser(UserSession.UserId, userName: UsernameTextBox.Text, email: EmailTextBox.Text, password: PasswordTextBox.Text, role: RoleComboBox.Text);
                MessageBox.Show(this, "Profile updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(this, "Passwords do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
