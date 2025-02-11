using SwiftInventory.Database;
using SwiftInventory.Forms.Common;
using System;
using System.Windows.Forms;

namespace SwiftInventory.Forms.Auth
{
    public partial class SignupForm : BaseForm
    {
        public SignupForm()
        {
            InitializeComponent();

            EyeSlashButton.SendToBack();
            EyeSlashButton2.SendToBack();
        }

        private void SignupForm_Load(object sender, EventArgs e)
        {
            RoleComboBox.Items.Add("Admin");
            RoleComboBox.Items.Add("Manager");
            RoleComboBox.Items.Add("Salesman");
            RoleComboBox.SelectedIndex = 0;
        }

        private void EyeButton_Click(object sender, EventArgs e)
        {
            if (PasswordTextBox.PasswordChar == '•')
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
                PasswordTextBox.PasswordChar = '•';
            }
        }

        private void EyeButton2_Click(object sender, EventArgs e)
        {
            if (ConfirmPasswordTextBox.PasswordChar == '•')
            {
                EyeSlashButton2.BringToFront();
                ConfirmPasswordTextBox.PasswordChar = '\0';
            }
        }

        private void EyeSlashButton2_Click(object sender, EventArgs e)
        {
            if (ConfirmPasswordTextBox.PasswordChar == '\0')
            {
                EyeButton2.BringToFront();
                ConfirmPasswordTextBox.PasswordChar = '•';
            }
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UsernameTextBox.Text) || string.IsNullOrWhiteSpace(PasswordTextBox.Text) || string.IsNullOrWhiteSpace(ConfirmPasswordTextBox.Text))
            {
                MessageBox.Show(this,
                    "Please fill in all fields",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (PasswordTextBox.Text != ConfirmPasswordTextBox.Text)
            {
                MessageBox.Show(this,
                    "Passwords do not match",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (UserQueries.GetUser(UsernameTextBox.Text) != null)
            {
                MessageBox.Show(this,
                    "Username already exists",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            UserQueries.AddUser(UsernameTextBox.Text, PasswordTextBox.Text, EmailTextBox.Text, RoleComboBox.Text);
            MessageBox.Show(this,
                "User added successfully",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            OpenChildForm(Parent as Panel, new AuthForm());
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(Parent as Panel, new AuthForm());
        }
    }
}
