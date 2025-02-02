namespace SwiftInventory.Forms.Main
{
    partial class CategoryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DeleteButton = new SwiftInventory.CustomControls.RoundButton();
            this.EditButton = new SwiftInventory.CustomControls.RoundButton();
            this.CategoryDataGridView = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.SearchTextBox = new SwiftInventory.CustomControls.PlaceholderTextBox();
            this.ManageCategoryLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CancelButton = new SwiftInventory.CustomControls.RoundButton();
            this.AddNewCategoryLabel = new System.Windows.Forms.Label();
            this.AddCategoryButton = new SwiftInventory.CustomControls.RoundButton();
            this.AddCategoryText = new SwiftInventory.CustomControls.PlaceholderTextBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryDataGridView)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20);
            this.panel1.Size = new System.Drawing.Size(846, 703);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(62)))), ((int)(((byte)(101)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(20, 204);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(806, 479);
            this.panel4.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.tableLayoutPanel1);
            this.panel7.Controls.Add(this.CategoryDataGridView);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 56);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(804, 421);
            this.panel7.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.DeleteButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.EditButton, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 363);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(804, 58);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeleteButton.BackColor = System.Drawing.Color.PaleVioletRed;
            this.DeleteButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.DeleteButton.BorderRadius = 5;
            this.DeleteButton.BorderSize = 0;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.Color.Black;
            this.DeleteButton.Location = new System.Drawing.Point(631, 9);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(130, 40);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
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
            this.EditButton.Location = new System.Drawing.Point(43, 9);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(130, 40);
            this.EditButton.TabIndex = 0;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // CategoryDataGridView
            // 
            this.CategoryDataGridView.AllowUserToAddRows = false;
            this.CategoryDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CategoryDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CategoryDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CategoryDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(62)))), ((int)(((byte)(101)))));
            this.CategoryDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CategoryDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CategoryDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CategoryDataGridView.ColumnHeadersHeight = 40;
            this.CategoryDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.CategoryDataGridView.Location = new System.Drawing.Point(0, 0);
            this.CategoryDataGridView.Name = "CategoryDataGridView";
            this.CategoryDataGridView.ReadOnly = true;
            this.CategoryDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CategoryDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.CategoryDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.CategoryDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.CategoryDataGridView.RowTemplate.Height = 35;
            this.CategoryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CategoryDataGridView.Size = new System.Drawing.Size(804, 357);
            this.CategoryDataGridView.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.SearchTextBox);
            this.panel5.Controls.Add(this.ManageCategoryLabel);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(804, 56);
            this.panel5.TabIndex = 1;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTextBox.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.ForeColor = System.Drawing.Color.Gray;
            this.SearchTextBox.Location = new System.Drawing.Point(555, 11);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.PlaceholderText = "Type to search...";
            this.SearchTextBox.Size = new System.Drawing.Size(226, 34);
            this.SearchTextBox.TabIndex = 2;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // ManageCategoryLabel
            // 
            this.ManageCategoryLabel.AutoSize = true;
            this.ManageCategoryLabel.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageCategoryLabel.Location = new System.Drawing.Point(23, 11);
            this.ManageCategoryLabel.Name = "ManageCategoryLabel";
            this.ManageCategoryLabel.Size = new System.Drawing.Size(208, 32);
            this.ManageCategoryLabel.TabIndex = 1;
            this.ManageCategoryLabel.Text = "Manage Category";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(20, 184);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(806, 20);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(62)))), ((int)(((byte)(101)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.CancelButton);
            this.panel3.Controls.Add(this.AddNewCategoryLabel);
            this.panel3.Controls.Add(this.AddCategoryButton);
            this.panel3.Controls.Add(this.AddCategoryText);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(20, 20);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(20);
            this.panel3.Size = new System.Drawing.Size(806, 164);
            this.panel3.TabIndex = 2;
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.PaleVioletRed;
            this.CancelButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.CancelButton.BorderRadius = 5;
            this.CancelButton.BorderSize = 0;
            this.CancelButton.FlatAppearance.BorderSize = 0;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.ForeColor = System.Drawing.Color.Black;
            this.CancelButton.Location = new System.Drawing.Point(165, 100);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(130, 40);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Visible = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddNewCategoryLabel
            // 
            this.AddNewCategoryLabel.AutoSize = true;
            this.AddNewCategoryLabel.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewCategoryLabel.Location = new System.Drawing.Point(23, 11);
            this.AddNewCategoryLabel.Name = "AddNewCategoryLabel";
            this.AddNewCategoryLabel.Size = new System.Drawing.Size(220, 32);
            this.AddNewCategoryLabel.TabIndex = 0;
            this.AddNewCategoryLabel.Text = "Add New Category";
            // 
            // AddCategoryButton
            // 
            this.AddCategoryButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AddCategoryButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.AddCategoryButton.BorderRadius = 5;
            this.AddCategoryButton.BorderSize = 0;
            this.AddCategoryButton.FlatAppearance.BorderSize = 0;
            this.AddCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCategoryButton.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCategoryButton.ForeColor = System.Drawing.Color.Black;
            this.AddCategoryButton.Location = new System.Drawing.Point(23, 100);
            this.AddCategoryButton.Name = "AddCategoryButton";
            this.AddCategoryButton.Size = new System.Drawing.Size(130, 40);
            this.AddCategoryButton.TabIndex = 2;
            this.AddCategoryButton.Text = "Add";
            this.AddCategoryButton.UseVisualStyleBackColor = false;
            this.AddCategoryButton.Click += new System.EventHandler(this.AddCategoryButton_Click);
            // 
            // AddCategoryText
            // 
            this.AddCategoryText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddCategoryText.BackColor = System.Drawing.SystemColors.Control;
            this.AddCategoryText.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCategoryText.ForeColor = System.Drawing.Color.Gray;
            this.AddCategoryText.Location = new System.Drawing.Point(23, 55);
            this.AddCategoryText.Name = "AddCategoryText";
            this.AddCategoryText.PlaceholderText = "Enter Category...";
            this.AddCategoryText.Size = new System.Drawing.Size(758, 38);
            this.AddCategoryText.TabIndex = 1;
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(62)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(846, 703);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CategoryForm";
            this.Text = "Category";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CategoryDataGridView)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label AddNewCategoryLabel;
        private CustomControls.RoundButton AddCategoryButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView CategoryDataGridView;
        private System.Windows.Forms.Label ManageCategoryLabel;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private CustomControls.PlaceholderTextBox AddCategoryText;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CustomControls.RoundButton DeleteButton;
        private CustomControls.RoundButton EditButton;
        private CustomControls.RoundButton CancelButton;
        private CustomControls.PlaceholderTextBox SearchTextBox;
    }
}