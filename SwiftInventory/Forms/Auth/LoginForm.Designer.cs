namespace SwiftInventory.Forms.Auth
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EyeSlashButton = new FontAwesome.Sharp.IconButton();
            this.SignUpButton = new SwiftInventory.CustomControls.RoundButton();
            this.LogInButton = new SwiftInventory.CustomControls.RoundButton();
            this.RoleComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EyeButton = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordTextBox = new SwiftInventory.CustomControls.PlaceholderTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UsernameTextBox = new SwiftInventory.CustomControls.PlaceholderTextBox();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EyeSlashButton
            // 
            this.EyeSlashButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EyeSlashButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(62)))), ((int)(((byte)(101)))));
            this.EyeSlashButton.FlatAppearance.BorderSize = 0;
            this.EyeSlashButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(62)))), ((int)(((byte)(101)))));
            this.EyeSlashButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(62)))), ((int)(((byte)(101)))));
            this.EyeSlashButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EyeSlashButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.EyeSlashButton.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.EyeSlashButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.EyeSlashButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.EyeSlashButton.IconSize = 30;
            this.EyeSlashButton.Location = new System.Drawing.Point(457, 319);
            this.EyeSlashButton.Name = "EyeSlashButton";
            this.EyeSlashButton.Size = new System.Drawing.Size(32, 34);
            this.EyeSlashButton.TabIndex = 22;
            this.EyeSlashButton.UseVisualStyleBackColor = false;
            this.EyeSlashButton.Click += new System.EventHandler(this.EyeSlashButton_Click);
            // 
            // SignUpButton
            // 
            this.SignUpButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SignUpButton.BackColor = System.Drawing.Color.GhostWhite;
            this.SignUpButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.SignUpButton.BorderRadius = 5;
            this.SignUpButton.BorderSize = 0;
            this.SignUpButton.FlatAppearance.BorderSize = 0;
            this.SignUpButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.SignUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUpButton.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpButton.ForeColor = System.Drawing.Color.Black;
            this.SignUpButton.Location = new System.Drawing.Point(105, 497);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(130, 40);
            this.SignUpButton.TabIndex = 26;
            this.SignUpButton.Text = "Sign Up";
            this.SignUpButton.UseVisualStyleBackColor = false;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // LogInButton
            // 
            this.LogInButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LogInButton.BackColor = System.Drawing.Color.GhostWhite;
            this.LogInButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.LogInButton.BorderRadius = 5;
            this.LogInButton.BorderSize = 0;
            this.LogInButton.FlatAppearance.BorderSize = 0;
            this.LogInButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.LogInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogInButton.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInButton.ForeColor = System.Drawing.Color.Black;
            this.LogInButton.Location = new System.Drawing.Point(321, 497);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(130, 40);
            this.LogInButton.TabIndex = 25;
            this.LogInButton.Text = "Log In";
            this.LogInButton.UseVisualStyleBackColor = false;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // RoleComboBox
            // 
            this.RoleComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RoleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoleComboBox.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 13F, System.Drawing.FontStyle.Bold);
            this.RoleComboBox.FormattingEnabled = true;
            this.RoleComboBox.Location = new System.Drawing.Point(105, 405);
            this.RoleComboBox.Name = "RoleComboBox";
            this.RoleComboBox.Size = new System.Drawing.Size(346, 38);
            this.RoleComboBox.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(101, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 24);
            this.label5.TabIndex = 23;
            this.label5.Text = "Role";
            // 
            // EyeButton
            // 
            this.EyeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EyeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(62)))), ((int)(((byte)(101)))));
            this.EyeButton.FlatAppearance.BorderSize = 0;
            this.EyeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(62)))), ((int)(((byte)(101)))));
            this.EyeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(62)))), ((int)(((byte)(101)))));
            this.EyeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EyeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.EyeButton.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.EyeButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.EyeButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.EyeButton.IconSize = 28;
            this.EyeButton.Location = new System.Drawing.Point(457, 319);
            this.EyeButton.Name = "EyeButton";
            this.EyeButton.Size = new System.Drawing.Size(32, 34);
            this.EyeButton.TabIndex = 21;
            this.EyeButton.UseVisualStyleBackColor = false;
            this.EyeButton.Click += new System.EventHandler(this.EyeButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(101, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Password";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordTextBox.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 13F, System.Drawing.FontStyle.Bold);
            this.PasswordTextBox.ForeColor = System.Drawing.Color.Gray;
            this.PasswordTextBox.Location = new System.Drawing.Point(105, 319);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '•';
            this.PasswordTextBox.PlaceholderText = "Enter Password...";
            this.PasswordTextBox.Size = new System.Drawing.Size(346, 36);
            this.PasswordTextBox.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(101, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Userame";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UsernameTextBox.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 13F, System.Drawing.FontStyle.Bold);
            this.UsernameTextBox.ForeColor = System.Drawing.Color.Gray;
            this.UsernameTextBox.Location = new System.Drawing.Point(105, 235);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.PlaceholderText = "Enter Name...";
            this.UsernameTextBox.Size = new System.Drawing.Size(346, 36);
            this.UsernameTextBox.TabIndex = 17;
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.HeaderLabel.Location = new System.Drawing.Point(207, 123);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(133, 53);
            this.HeaderLabel.TabIndex = 16;
            this.HeaderLabel.Text = "Log In";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(62)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(560, 720);
            this.Controls.Add(this.EyeSlashButton);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.RoleComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EyeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.HeaderLabel);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton EyeSlashButton;
        private CustomControls.RoundButton SignUpButton;
        private CustomControls.RoundButton LogInButton;
        private System.Windows.Forms.ComboBox RoleComboBox;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton EyeButton;
        private System.Windows.Forms.Label label1;
        private CustomControls.PlaceholderTextBox PasswordTextBox;
        private System.Windows.Forms.Label label2;
        private CustomControls.PlaceholderTextBox UsernameTextBox;
        private System.Windows.Forms.Label HeaderLabel;
    }
}