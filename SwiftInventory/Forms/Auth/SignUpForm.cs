using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SwiftInventory.Forms.Auth
{
    public partial class SignUpForm : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\SwiftInventoryUpdated 1\SwiftInventory\SwiftInventory\SwiftInventoryDB.mdf;Integrated Security=True;";

        public SignUpForm()
        {
            InitializeComponent();
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = showPasswordCheckBox.Checked;

        
            passwordTextBox.UseSystemPasswordChar = !isChecked;
            confirmPasswordTextBox.UseSystemPasswordChar = !isChecked;
        }


        private void ClearLinkLabel_Click(object sender, EventArgs e)
        {
            usernameTextBox.Clear();
            emailTextBox.Clear();
            passwordTextBox.Clear();
            confirmPasswordTextBox.Clear();
            addressTextBox.Clear();
            phoneTextBox.Clear();
            companyTextBox.Clear();
            roleComboBox.SelectedIndex = -1;
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (string.IsNullOrWhiteSpace(usernameTextBox.Text) ||
                string.IsNullOrWhiteSpace(emailTextBox.Text) ||
                string.IsNullOrWhiteSpace(passwordTextBox.Text) ||
                string.IsNullOrWhiteSpace(confirmPasswordTextBox.Text) ||
                string.IsNullOrWhiteSpace(addressTextBox.Text) ||
                string.IsNullOrWhiteSpace(phoneTextBox.Text) ||
                string.IsNullOrWhiteSpace(companyTextBox.Text) ||
                roleComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if passwords match
            if (passwordTextBox.Text != confirmPasswordTextBox.Text)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Save user to the database
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Users (Username, Email, Password, Role, Address, PhoneNumber, CompanyName) " +
                                   "VALUES (@Username, @Email, @Password, @Role, @Address, @PhoneNumber, @CompanyName)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", usernameTextBox.Text);
                        cmd.Parameters.AddWithValue("@Email", emailTextBox.Text);
                        cmd.Parameters.AddWithValue("@Password", passwordTextBox.Text);
                        cmd.Parameters.AddWithValue("@Role", roleComboBox.Text);
                        cmd.Parameters.AddWithValue("@Address", addressTextBox.Text);
                        cmd.Parameters.AddWithValue("@PhoneNumber", phoneTextBox.Text);
                        cmd.Parameters.AddWithValue("@CompanyName", companyTextBox.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("User registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Redirect to LoginForm
                        this.Hide();
                        LoginForm loginForm = new LoginForm();
                        loginForm.Show();
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) // Unique constraint error (Username already exists)
                {
                    MessageBox.Show("Username already exists. Please choose a different one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BackToLoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {

            // Validate input fields
            if (string.IsNullOrWhiteSpace(usernameTextBox.Text) ||
                string.IsNullOrWhiteSpace(emailTextBox.Text) ||
                string.IsNullOrWhiteSpace(passwordTextBox.Text) ||
                string.IsNullOrWhiteSpace(confirmPasswordTextBox.Text) ||
                string.IsNullOrWhiteSpace(addressTextBox.Text) ||
                string.IsNullOrWhiteSpace(phoneTextBox.Text) ||
                string.IsNullOrWhiteSpace(companyTextBox.Text) ||
                roleComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if passwords match
            if (passwordTextBox.Text != confirmPasswordTextBox.Text)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Save user to the database
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Users (Username, Email, Password, Role, Address, PhoneNumber, CompanyName) " +
                                   "VALUES (@Username, @Email, @Password, @Role, @Address, @PhoneNumber, @CompanyName)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", usernameTextBox.Text);
                        cmd.Parameters.AddWithValue("@Email", emailTextBox.Text);
                        cmd.Parameters.AddWithValue("@Password", passwordTextBox.Text);
                        cmd.Parameters.AddWithValue("@Role", roleComboBox.Text);
                        cmd.Parameters.AddWithValue("@Address", addressTextBox.Text);
                        cmd.Parameters.AddWithValue("@PhoneNumber", phoneTextBox.Text);
                        cmd.Parameters.AddWithValue("@CompanyName", companyTextBox.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("User registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Redirect to LoginForm
                        this.Hide();
                        LoginForm loginForm = new LoginForm();
                        loginForm.Show();
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) // Unique constraint error (Username already exists)
                {
                    MessageBox.Show("Username already exists. Please choose a different one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
