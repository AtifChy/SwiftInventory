namespace SwiftInventory.Forms.Auth
{
    partial class SignUpForm
    {
        private System.ComponentModel.IContainer components = null;

        // Declare Labels as Class Members
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label companyLabel;

        private System.Windows.Forms.ComboBox roleComboBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox companyTextBox;
        private System.Windows.Forms.LinkLabel clearLinkLabel;
        private System.Windows.Forms.CheckBox showPasswordCheckBox;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.roleLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.companyLabel = new System.Windows.Forms.Label();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.companyTextBox = new System.Windows.Forms.TextBox();
            this.clearLinkLabel = new System.Windows.Forms.LinkLabel();
            this.showPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.EditButton = new SwiftInventory.CustomControls.RoundButton();
            this.ViewButton = new SwiftInventory.CustomControls.RoundButton();
            this.SuspendLayout();
            // 
            // roleLabel
            // 
            this.roleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.roleLabel.Location = new System.Drawing.Point(167, 51);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(100, 23);
            this.roleLabel.TabIndex = 0;
            this.roleLabel.Text = "Role:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.usernameLabel.Location = new System.Drawing.Point(105, 90);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(131, 23);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "User Name:";
            // 
            // emailLabel
            // 
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.emailLabel.Location = new System.Drawing.Point(156, 130);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(100, 23);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "Email:";
            this.emailLabel.Click += new System.EventHandler(this.emailLabel_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.passwordLabel.Location = new System.Drawing.Point(122, 170);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(114, 23);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password:";
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.confirmPasswordLabel.Location = new System.Drawing.Point(52, 210);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(184, 23);
            this.confirmPasswordLabel.TabIndex = 4;
            this.confirmPasswordLabel.Text = "Confirm Password:";
            // 
            // addressLabel
            // 
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addressLabel.Location = new System.Drawing.Point(136, 250);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(100, 23);
            this.addressLabel.TabIndex = 5;
            this.addressLabel.Text = "Address:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.phoneLabel.Location = new System.Drawing.Point(74, 290);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(162, 23);
            this.phoneLabel.TabIndex = 6;
            this.phoneLabel.Text = "Phone Number:";
            // 
            // companyLabel
            // 
            this.companyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.companyLabel.Location = new System.Drawing.Point(74, 330);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(180, 23);
            this.companyLabel.TabIndex = 7;
            this.companyLabel.Text = "Company Name:";
            // 
            // roleComboBox
            // 
            this.roleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleComboBox.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Salesman"});
            this.roleComboBox.Location = new System.Drawing.Point(273, 50);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(372, 24);
            this.roleComboBox.TabIndex = 8;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(273, 90);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(372, 22);
            this.usernameTextBox.TabIndex = 9;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(273, 130);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(372, 22);
            this.emailTextBox.TabIndex = 10;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(273, 170);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(372, 22);
            this.passwordTextBox.TabIndex = 11;
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(273, 210);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(372, 22);
            this.confirmPasswordTextBox.TabIndex = 12;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(273, 250);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(372, 22);
            this.addressTextBox.TabIndex = 13;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(273, 290);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(372, 22);
            this.phoneTextBox.TabIndex = 14;
            // 
            // companyTextBox
            // 
            this.companyTextBox.Location = new System.Drawing.Point(273, 330);
            this.companyTextBox.Name = "companyTextBox";
            this.companyTextBox.Size = new System.Drawing.Size(372, 22);
            this.companyTextBox.TabIndex = 15;
            // 
            // clearLinkLabel
            // 
            this.clearLinkLabel.AutoSize = true;
            this.clearLinkLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.clearLinkLabel.LinkColor = System.Drawing.Color.White;
            this.clearLinkLabel.Location = new System.Drawing.Point(566, 376);
            this.clearLinkLabel.Name = "clearLinkLabel";
            this.clearLinkLabel.Size = new System.Drawing.Size(79, 16);
            this.clearLinkLabel.TabIndex = 19;
            this.clearLinkLabel.TabStop = true;
            this.clearLinkLabel.Text = "Clear Fields";
            this.clearLinkLabel.Click += new System.EventHandler(this.ClearLinkLabel_Click);
            // 
            // showPasswordCheckBox
            // 
            this.showPasswordCheckBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.showPasswordCheckBox.Location = new System.Drawing.Point(273, 368);
            this.showPasswordCheckBox.Name = "showPasswordCheckBox";
            this.showPasswordCheckBox.Size = new System.Drawing.Size(104, 24);
            this.showPasswordCheckBox.TabIndex = 16;
            this.showPasswordCheckBox.Text = "Show Password";
            this.showPasswordCheckBox.CheckedChanged += new System.EventHandler(this.ShowPasswordCheckBox_CheckedChanged);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EditButton.BackColor = System.Drawing.Color.CadetBlue;
            this.EditButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.EditButton.BorderRadius = 5;
            this.EditButton.BorderSize = 0;
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.ForeColor = System.Drawing.Color.Black;
            this.EditButton.Location = new System.Drawing.Point(572, 443);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(130, 40);
            this.EditButton.TabIndex = 20;
            this.EditButton.Text = "Back";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // ViewButton
            // 
            this.ViewButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ViewButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ViewButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ViewButton.BorderRadius = 5;
            this.ViewButton.BorderSize = 0;
            this.ViewButton.FlatAppearance.BorderSize = 0;
            this.ViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewButton.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewButton.ForeColor = System.Drawing.Color.Black;
            this.ViewButton.Location = new System.Drawing.Point(150, 443);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(130, 40);
            this.ViewButton.TabIndex = 21;
            this.ViewButton.Text = "Sign Up";
            this.ViewButton.UseVisualStyleBackColor = false;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // SignUpForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(62)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(805, 537);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.confirmPasswordLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.companyLabel);
            this.Controls.Add(this.roleComboBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.confirmPasswordTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.companyTextBox);
            this.Controls.Add(this.showPasswordCheckBox);
            this.Controls.Add(this.clearLinkLabel);
            this.Name = "SignUpForm";
            this.Text = "Sign Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private CustomControls.RoundButton EditButton;
        private CustomControls.RoundButton ViewButton;
    }
}
