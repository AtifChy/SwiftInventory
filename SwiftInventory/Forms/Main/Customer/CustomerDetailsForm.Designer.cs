namespace SwiftInventory.Forms.Main.Customer
{
    partial class CustomerDetailsForm
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.CustomerDetailsHeaderLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SaveButton = new SwiftInventory.CustomControls.RoundButton();
            this.CancelButton = new SwiftInventory.CustomControls.RoundButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.CustomerAddressText = new SwiftInventory.CustomControls.PlaceholderTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CustomerPhoneText = new SwiftInventory.CustomControls.PlaceholderTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerEmailText = new SwiftInventory.CustomControls.PlaceholderTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CustomerNameText = new SwiftInventory.CustomControls.PlaceholderTextBox();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.CustomerDetailsHeaderLabel);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(876, 57);
            this.panel5.TabIndex = 3;
            // 
            // CustomerDetailsHeaderLabel
            // 
            this.CustomerDetailsHeaderLabel.AutoSize = true;
            this.CustomerDetailsHeaderLabel.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerDetailsHeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.CustomerDetailsHeaderLabel.Location = new System.Drawing.Point(23, 11);
            this.CustomerDetailsHeaderLabel.Name = "CustomerDetailsHeaderLabel";
            this.CustomerDetailsHeaderLabel.Size = new System.Drawing.Size(172, 32);
            this.CustomerDetailsHeaderLabel.TabIndex = 1;
            this.CustomerDetailsHeaderLabel.Text = "Add Customer";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.SaveButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CancelButton, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 631);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(876, 58);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SaveButton.BackColor = System.Drawing.Color.CadetBlue;
            this.SaveButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.SaveButton.BorderRadius = 5;
            this.SaveButton.BorderSize = 0;
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.Black;
            this.SaveButton.Location = new System.Drawing.Point(52, 9);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(130, 40);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CancelButton.BackColor = System.Drawing.Color.PaleVioletRed;
            this.CancelButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.CancelButton.BorderRadius = 5;
            this.CancelButton.BorderSize = 0;
            this.CancelButton.FlatAppearance.BorderSize = 0;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.ForeColor = System.Drawing.Color.Black;
            this.CancelButton.Location = new System.Drawing.Point(694, 9);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(130, 40);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.CustomerAddressText);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CustomerPhoneText);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CustomerEmailText);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CustomerNameText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 574);
            this.panel1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(259, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Address";
            // 
            // CustomerAddressText
            // 
            this.CustomerAddressText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CustomerAddressText.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerAddressText.ForeColor = System.Drawing.Color.Gray;
            this.CustomerAddressText.Location = new System.Drawing.Point(263, 299);
            this.CustomerAddressText.Multiline = true;
            this.CustomerAddressText.Name = "CustomerAddressText";
            this.CustomerAddressText.PlaceholderText = "Enter Address...";
            this.CustomerAddressText.Size = new System.Drawing.Size(346, 163);
            this.CustomerAddressText.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(259, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Phone";
            // 
            // CustomerPhoneText
            // 
            this.CustomerPhoneText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CustomerPhoneText.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerPhoneText.ForeColor = System.Drawing.Color.Gray;
            this.CustomerPhoneText.Location = new System.Drawing.Point(263, 221);
            this.CustomerPhoneText.Name = "CustomerPhoneText";
            this.CustomerPhoneText.PlaceholderText = "Enter Phone Number...";
            this.CustomerPhoneText.Size = new System.Drawing.Size(346, 34);
            this.CustomerPhoneText.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Email";
            // 
            // CustomerEmailText
            // 
            this.CustomerEmailText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CustomerEmailText.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerEmailText.ForeColor = System.Drawing.Color.Gray;
            this.CustomerEmailText.Location = new System.Drawing.Point(263, 143);
            this.CustomerEmailText.Name = "CustomerEmailText";
            this.CustomerEmailText.PlaceholderText = "Enter Email...";
            this.CustomerEmailText.Size = new System.Drawing.Size(346, 34);
            this.CustomerEmailText.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Name";
            // 
            // CustomerNameText
            // 
            this.CustomerNameText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CustomerNameText.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameText.ForeColor = System.Drawing.Color.Gray;
            this.CustomerNameText.Location = new System.Drawing.Point(263, 68);
            this.CustomerNameText.Name = "CustomerNameText";
            this.CustomerNameText.PlaceholderText = "Enter Name...";
            this.CustomerNameText.Size = new System.Drawing.Size(346, 34);
            this.CustomerNameText.TabIndex = 0;
            // 
            // CustomerDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(62)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(876, 689);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel5);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CustomerDetailsForm";
            this.Text = "CustomerDetailsForm";
            this.Load += new System.EventHandler(this.CustomerDetailsForm_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label CustomerDetailsHeaderLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CustomControls.RoundButton SaveButton;
        private CustomControls.RoundButton CancelButton;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.PlaceholderTextBox CustomerNameText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private CustomControls.PlaceholderTextBox CustomerAddressText;
        private System.Windows.Forms.Label label3;
        private CustomControls.PlaceholderTextBox CustomerPhoneText;
        private System.Windows.Forms.Label label1;
        private CustomControls.PlaceholderTextBox CustomerEmailText;
    }
}