using SwiftInventory.Common;
using SwiftInventory.Database;
using SwiftInventory.Forms.Common;
using SwiftInventory.Forms.Main;
using System;
using System.Windows.Forms;

namespace SwiftInventory.Forms.Auth
{
    public partial class LoginForm : BaseForm
    {
        private const char PasswordChar = '•';

        public LoginForm()
        {
            InitializeComponent();
            EyeSlashButton.SendToBack();
            RoleComboBox.Items.AddRange(new object[] { "Admin", "Manager", "Salesman" });
            RoleComboBox.SelectedIndex = 0;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            ActiveControl = HeaderLabel;
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(this,
                @"Do you want to sign up?",
                @"Sign Up",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                OpenChildForm(Parent as Panel, new SignupForm());
            }
        }

        private void EyeButton_Click(object sender, EventArgs e)
        {
            if (PasswordTextBox.PasswordChar == PasswordChar)
            {
                EyeSlashButton.BringToFront();
                PasswordTextBox.PasswordChar = '\0';
            }
        }

        private void EyeSlashButton_Click(object sender, EventArgs e)
        {
            if (PasswordTextBox.PasswordChar == '\0')
            {
                EyeButton.BringToFront();
                PasswordTextBox.PasswordChar = PasswordChar;
            }
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text.Trim();
            string password = PasswordTextBox.Text;
            string role = RoleComboBox.SelectedItem.ToString();

            if (string.IsNullOrEmpty(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(this,
                    @"Please fill in all fields",
                    @"Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (AuthUser(username, password, role))
            {
                UsernameTextBox.Clear();
                PasswordTextBox.Clear();
                RoleComboBox.SelectedIndex = 0;

                FormManager.AuthFormInstance.Hide();
                new MainForm().Show();
            }
        }

        private bool AuthUser(string username, string password, string role)
        {
            if (username.Contains(" "))
            {
                MessageBox.Show(this,
                    @"Username cannot contain spaces",
                    @"Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            var user = UserQueries.GetUser(username);
            if (user == null || user["Password"].ToString() != password ||
                !string.Equals(role, user["Role"].ToString(), StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show(this,
                    @"Invalid credentials",
                    @"Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            if (!(bool)user["Approved"])
            {
                MessageBox.Show(this,
                    @"Your account is not approved by an admin yet.",
                    @"Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            UserSession.UserId = (int)user["Id"];
            UserSession.Role = user["Role"].ToString();
            UserSession.UserName = user["UserName"].ToString();

            return true;
        }
    }
}
