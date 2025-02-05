using SwiftInventory.Forms.Main.Supplier;
using SwiftInventory.Forms.Main;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SwiftInventory.Forms.Auth
{
    public partial class LoginForm : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\SwiftInventoryUpdated 1\SwiftInventory\SwiftInventory\SwiftInventoryDB.mdf;Integrated Security=True";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Populate User Role ComboBox
            RoleComboBox.Items.AddRange(new string[] { "Admin", "Manager", "Salesman" });
            RoleComboBox.SelectedIndex = 0; // Default selection
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar = !ShowPasswordCheckBox.Checked;
        }

        private void ClearFieldsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UsernameTextBox.Clear();
            PasswordTextBox.Clear();
            RoleComboBox.SelectedIndex = 0;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;
            string role = RoleComboBox.SelectedItem.ToString();

            // Authenticate user based on role
            if (AuthenticateUser(username, password, role))
            {
                // Navigate to the respective form based on the selected role
                switch (role)
                {
                    case "Admin":
                        AdminForm adminForm = new AdminForm();
                        adminForm.Show();
                        break;
                    case "Manager":
                        ManagerForm managerForm = new ManagerForm();
                        managerForm.Show();
                        break;
                    case "Salesman":  // Correcting the role name from Supplier to Salesman
                        SalesmanForm salesmanForm = new SalesmanForm();
                        salesmanForm.Show();
                        break;


                    default:
                        MessageBox.Show("Invalid role selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

                this.Hide(); // Hide LoginForm after successful login
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UsernameTextBox.Clear();
                PasswordTextBox.Clear();
                RoleComboBox.SelectedIndex = 0; // Reset the role selection to default
            }
        }

        private bool AuthenticateUser(string username, string password, string role)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password AND Role = @Role";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Role", role);

                    int userCount = (int)command.ExecuteScalar();
                    return userCount > 0; // Returns true if a user is found
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while authenticating: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            // Open the SignUpForm
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
            this.Hide(); // Optionally hide LoginForm
        }
    }
}
