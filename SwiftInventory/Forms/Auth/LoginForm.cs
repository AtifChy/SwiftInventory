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
        public LoginForm()
        {
            InitializeComponent();
            EyeSlashButton.SendToBack();
            RoleComboBox.Items.Add("Admin");
            RoleComboBox.Items.Add("Manager");
            RoleComboBox.Items.Add("Salesman");
            RoleComboBox.SelectedIndex = 0;
        }

        private void EyeButton_Click(object sender, System.EventArgs e)
        {
            if (PasswordTextBox.PasswordChar == '•')
            {
                EyeSlashButton.BringToFront();
                PasswordTextBox.PasswordChar = '\0';
            }
        }

        private void EyeSlashButton_Click(object sender, System.EventArgs e)
        {
            if (PasswordTextBox.PasswordChar == '\0')
            {
                EyeButton.BringToFront();
                PasswordTextBox.PasswordChar = '•';
            }
        }

        private void LogInButton_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UsernameTextBox.Text) || string.IsNullOrWhiteSpace(PasswordTextBox.Text))
            {
                MessageBox.Show(this,
                    "Please fill in all fields",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            var user = UserQueries.GetUser(UsernameTextBox.Text);
            if (user != null)
            {
                if (user["Password"].ToString() == PasswordTextBox.Text &&
                    string.Equals(RoleComboBox.Text, user["Role"].ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    if (user["Approved"].ToString() == "False")
                    {
                        MessageBox.Show(this,
                            "Your account is not approved by an admin yet.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }

                    UserSession.UserId = (int)user["Id"];
                    UserSession.Role = user["Role"].ToString();
                    UserSession.UserName = user["UserName"].ToString();

                    Hide();
                    var mainForm = new MainForm();
                    mainForm.Show();
                    mainForm.Closed += (s, args) => Close();
                }
                else
                {
                    MessageBox.Show(this,
                        "Invalid credentials",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void SignUpButton_Click(object sender, System.EventArgs e)
        {
            OpenChildForm(MainPanel, new SignupForm());
        }

        private void LoginForm_Load(object sender, System.EventArgs e)
        {
            ActiveControl = HeaderLabel;
        }
    }
}
