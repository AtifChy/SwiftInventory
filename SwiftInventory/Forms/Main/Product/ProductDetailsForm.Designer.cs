namespace SwiftInventory.Forms.Main.Product
{
    partial class ProductDetailsForm
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UploadImageButton = new SwiftInventory.CustomControls.RoundButton();
            this.ProductPictureBox = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SupplierComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SaveButton = new SwiftInventory.CustomControls.RoundButton();
            this.CancelButton = new SwiftInventory.CustomControls.RoundButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ProductDetailsHeaderLabel = new System.Windows.Forms.Label();
            this.ProductImageFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.MainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPictureBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(62)))), ((int)(((byte)(101)))));
            this.MainPanel.Controls.Add(this.panel1);
            this.MainPanel.Controls.Add(this.tableLayoutPanel1);
            this.MainPanel.Controls.Add(this.panel5);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(962, 704);
            this.MainPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.UploadImageButton);
            this.panel1.Controls.Add(this.ProductPictureBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.SupplierComboBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.PriceTextBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.QuantityTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CategoryComboBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.NameTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 589);
            this.panel1.TabIndex = 7;
            // 
            // UploadImageButton
            // 
            this.UploadImageButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UploadImageButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.UploadImageButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.UploadImageButton.BorderRadius = 5;
            this.UploadImageButton.BorderSize = 0;
            this.UploadImageButton.FlatAppearance.BorderSize = 0;
            this.UploadImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UploadImageButton.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadImageButton.ForeColor = System.Drawing.Color.Black;
            this.UploadImageButton.Location = new System.Drawing.Point(170, 476);
            this.UploadImageButton.Name = "UploadImageButton";
            this.UploadImageButton.Size = new System.Drawing.Size(130, 40);
            this.UploadImageButton.TabIndex = 12;
            this.UploadImageButton.Text = "Upload";
            this.UploadImageButton.UseVisualStyleBackColor = false;
            this.UploadImageButton.Click += new System.EventHandler(this.UploadImageButton_Click);
            // 
            // ProductPictureBox
            // 
            this.ProductPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProductPictureBox.Image = global::SwiftInventory.Properties.Resources.icons8_picture_80;
            this.ProductPictureBox.Location = new System.Drawing.Point(170, 336);
            this.ProductPictureBox.Name = "ProductPictureBox";
            this.ProductPictureBox.Size = new System.Drawing.Size(130, 134);
            this.ProductPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProductPictureBox.TabIndex = 11;
            this.ProductPictureBox.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(166, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Image";
            // 
            // SupplierComboBox
            // 
            this.SupplierComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SupplierComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SupplierComboBox.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold);
            this.SupplierComboBox.FormattingEnabled = true;
            this.SupplierComboBox.Location = new System.Drawing.Point(600, 172);
            this.SupplierComboBox.Name = "SupplierComboBox";
            this.SupplierComboBox.Size = new System.Drawing.Size(195, 35);
            this.SupplierComboBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(596, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Supplier";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PriceTextBox.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold);
            this.PriceTextBox.Location = new System.Drawing.Point(600, 254);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(195, 34);
            this.PriceTextBox.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(596, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Price";
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.QuantityTextBox.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold);
            this.QuantityTextBox.Location = new System.Drawing.Point(170, 254);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(195, 34);
            this.QuantityTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(166, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantity";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryComboBox.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold);
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(170, 172);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(195, 35);
            this.CategoryComboBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Category";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameTextBox.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(170, 98);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(624, 34);
            this.NameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name";
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 646);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(962, 58);
            this.tableLayoutPanel1.TabIndex = 6;
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
            this.SaveButton.Location = new System.Drawing.Point(62, 9);
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
            this.CancelButton.Location = new System.Drawing.Point(768, 9);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(130, 40);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.ProductDetailsHeaderLabel);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(962, 57);
            this.panel5.TabIndex = 2;
            // 
            // ProductDetailsHeaderLabel
            // 
            this.ProductDetailsHeaderLabel.AutoSize = true;
            this.ProductDetailsHeaderLabel.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductDetailsHeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.ProductDetailsHeaderLabel.Location = new System.Drawing.Point(23, 11);
            this.ProductDetailsHeaderLabel.Name = "ProductDetailsHeaderLabel";
            this.ProductDetailsHeaderLabel.Size = new System.Drawing.Size(151, 32);
            this.ProductDetailsHeaderLabel.TabIndex = 1;
            this.ProductDetailsHeaderLabel.Text = "Add Product";
            // 
            // ProductImageFileDialog
            // 
            this.ProductImageFileDialog.FileName = "ProductImage";
            // 
            // ProductDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(62)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(962, 704);
            this.Controls.Add(this.MainPanel);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display", 7.8F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductDetailsForm";
            this.Text = "AddProduct";
            this.Load += new System.EventHandler(this.ProductDetailsForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPictureBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label ProductDetailsHeaderLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private new CustomControls.RoundButton CancelButton;
        private CustomControls.RoundButton SaveButton;
        private System.Windows.Forms.OpenFileDialog ProductImageFileDialog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ProductPictureBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox SupplierComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label1;
        private CustomControls.RoundButton UploadImageButton;
    }
}