namespace SwiftInventory.Forms.Auth
{
    partial class SignupForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.UsernameTextBox = new SwiftInventory.CustomControls.PlaceholderTextBox();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordTextBox = new SwiftInventory.CustomControls.PlaceholderTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ConfirmPasswordTextBox = new SwiftInventory.CustomControls.PlaceholderTextBox();
            this.RoleComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EmailTextBox = new SwiftInventory.CustomControls.PlaceholderTextBox();
            this.SignUpButton = new SwiftInventory.CustomControls.RoundButton();
            this.CancelButton = new SwiftInventory.CustomControls.RoundButton();
            this.EyeSlashButton = new FontAwesome.Sharp.IconButton();
            this.EyeButton = new FontAwesome.Sharp.IconButton();
            this.EyeButton2 = new FontAwesome.Sharp.IconButton();
            this.EyeSlashButton2 = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(128, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Userame";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UsernameTextBox.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 13F, System.Drawing.FontStyle.Bold);
            this.UsernameTextBox.ForeColor = System.Drawing.Color.Gray;
            this.UsernameTextBox.Location = new System.Drawing.Point(132, 176);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.PlaceholderText = "Enter Name...";
            this.UsernameTextBox.Size = new System.Drawing.Size(346, 36);
            this.UsernameTextBox.TabIndex = 9;
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.HeaderLabel.Location = new System.Drawing.Point(224, 55);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(164, 53);
            this.HeaderLabel.TabIndex = 11;
            this.HeaderLabel.Text = "Sign Up";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(128, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Password";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordTextBox.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 13F, System.Drawing.FontStyle.Bold);
            this.PasswordTextBox.ForeColor = System.Drawing.Color.Gray;
            this.PasswordTextBox.Location = new System.Drawing.Point(132, 331);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '•';
            this.PasswordTextBox.PlaceholderText = "Enter Password...";
            this.PasswordTextBox.Size = new System.Drawing.Size(346, 36);
            this.PasswordTextBox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(128, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Confirm Password";
            // 
            // ConfirmPasswordTextBox
            // 
            this.ConfirmPasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConfirmPasswordTextBox.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 13F, System.Drawing.FontStyle.Bold);
            this.ConfirmPasswordTextBox.ForeColor = System.Drawing.Color.Gray;
            this.ConfirmPasswordTextBox.Location = new System.Drawing.Point(132, 412);
            this.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            this.ConfirmPasswordTextBox.PasswordChar = '•';
            this.ConfirmPasswordTextBox.PlaceholderText = "Enter Password...";
            this.ConfirmPasswordTextBox.Size = new System.Drawing.Size(346, 36);
            this.ConfirmPasswordTextBox.TabIndex = 17;
            // 
            // RoleComboBox
            // 
            this.RoleComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RoleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoleComboBox.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 13F, System.Drawing.FontStyle.Bold);
            this.RoleComboBox.FormattingEnabled = true;
            this.RoleComboBox.Location = new System.Drawing.Point(132, 497);
            this.RoleComboBox.Name = "RoleComboBox";
            this.RoleComboBox.Size = new System.Drawing.Size(346, 38);
            this.RoleComboBox.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(128, 470);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = "Role";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(128, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 24);
            this.label4.TabIndex = 24;
            this.label4.Text = "Email";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EmailTextBox.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 13F, System.Drawing.FontStyle.Bold);
            this.EmailTextBox.ForeColor = System.Drawing.Color.Gray;
            this.EmailTextBox.Location = new System.Drawing.Point(132, 252);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.PlaceholderText = "Enter Email...";
            this.EmailTextBox.Size = new System.Drawing.Size(346, 36);
            this.EmailTextBox.TabIndex = 23;
            // 
            // SignUpButton
            // 
            this.SignUpButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SignUpButton.BackColor = System.Drawing.Color.CadetBlue;
            this.SignUpButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.SignUpButton.BorderRadius = 5;
            this.SignUpButton.BorderSize = 0;
            this.SignUpButton.FlatAppearance.BorderSize = 0;
            this.SignUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUpButton.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpButton.ForeColor = System.Drawing.Color.Black;
            this.SignUpButton.Location = new System.Drawing.Point(132, 579);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(130, 40);
            this.SignUpButton.TabIndex = 25;
            this.SignUpButton.Text = "Sign Up";
            this.SignUpButton.UseVisualStyleBackColor = false;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CancelButton.BackColor = System.Drawing.Color.PaleVioletRed;
            this.CancelButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.CancelButton.BorderRadius = 5;
            this.CancelButton.BorderSize = 0;
            this.CancelButton.FlatAppearance.BorderSize = 0;
            this.CancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.ForeColor = System.Drawing.Color.Black;
            this.CancelButton.Location = new System.Drawing.Point(348, 579);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(130, 40);
            this.CancelButton.TabIndex = 26;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
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
            this.EyeSlashButton.Location = new System.Drawing.Point(484, 331);
            this.EyeSlashButton.Name = "EyeSlashButton";
            this.EyeSlashButton.Size = new System.Drawing.Size(32, 34);
            this.EyeSlashButton.TabIndex = 27;
            this.EyeSlashButton.UseVisualStyleBackColor = false;
            this.EyeSlashButton.Click += new System.EventHandler(this.EyeSlashButton_Click);
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
            this.EyeButton.IconSize = 30;
            this.EyeButton.Location = new System.Drawing.Point(484, 331);
            this.EyeButton.Name = "EyeButton";
            this.EyeButton.Size = new System.Drawing.Size(32, 34);
            this.EyeButton.TabIndex = 28;
            this.EyeButton.UseVisualStyleBackColor = false;
            this.EyeButton.Click += new System.EventHandler(this.EyeButton_Click);
            // 
            // EyeButton2
            // 
            this.EyeButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EyeButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(62)))), ((int)(((byte)(101)))));
            this.EyeButton2.FlatAppearance.BorderSize = 0;
            this.EyeButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(62)))), ((int)(((byte)(101)))));
            this.EyeButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(62)))), ((int)(((byte)(101)))));
            this.EyeButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EyeButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.EyeButton2.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.EyeButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.EyeButton2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.EyeButton2.IconSize = 30;
            this.EyeButton2.Location = new System.Drawing.Point(484, 412);
            this.EyeButton2.Name = "EyeButton2";
            this.EyeButton2.Size = new System.Drawing.Size(32, 34);
            this.EyeButton2.TabIndex = 29;
            this.EyeButton2.UseVisualStyleBackColor = false;
            this.EyeButton2.Click += new System.EventHandler(this.EyeButton2_Click);
            // 
            // EyeSlashButton2
            // 
            this.EyeSlashButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EyeSlashButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(62)))), ((int)(((byte)(101)))));
            this.EyeSlashButton2.FlatAppearance.BorderSize = 0;
            this.EyeSlashButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(62)))), ((int)(((byte)(101)))));
            this.EyeSlashButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(62)))), ((int)(((byte)(101)))));
            this.EyeSlashButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EyeSlashButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.EyeSlashButton2.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.EyeSlashButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.EyeSlashButton2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.EyeSlashButton2.IconSize = 30;
            this.EyeSlashButton2.Location = new System.Drawing.Point(484, 412);
            this.EyeSlashButton2.Name = "EyeSlashButton2";
            this.EyeSlashButton2.Size = new System.Drawing.Size(32, 34);
            this.EyeSlashButton2.TabIndex = 30;
            this.EyeSlashButton2.UseVisualStyleBackColor = false;
            this.EyeSlashButton2.Click += new System.EventHandler(this.EyeSlashButton2_Click);
            // 
            // SignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(62)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(608, 729);
            this.Controls.Add(this.EyeSlashButton2);
            this.Controls.Add(this.EyeButton2);
            this.Controls.Add(this.EyeButton);
            this.Controls.Add(this.EyeSlashButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.RoleComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ConfirmPasswordTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UsernameTextBox);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SignupForm";
            this.Text = "SignupForm";
            this.Load += new System.EventHandler(this.SignupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private CustomControls.PlaceholderTextBox UsernameTextBox;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Label label1;
        private CustomControls.PlaceholderTextBox PasswordTextBox;
        private System.Windows.Forms.Label label3;
        private CustomControls.PlaceholderTextBox ConfirmPasswordTextBox;
        private System.Windows.Forms.ComboBox RoleComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private CustomControls.PlaceholderTextBox EmailTextBox;
        private CustomControls.RoundButton SignUpButton;
        private CustomControls.RoundButton CancelButton;
        private FontAwesome.Sharp.IconButton EyeSlashButton;
        private FontAwesome.Sharp.IconButton EyeButton;
        private FontAwesome.Sharp.IconButton EyeButton2;
        private FontAwesome.Sharp.IconButton EyeSlashButton2;
    }
}