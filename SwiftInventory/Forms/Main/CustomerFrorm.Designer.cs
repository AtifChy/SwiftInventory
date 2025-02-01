namespace SwiftInventory
{
    partial class CustomerFrorm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerFrorm));
            this.AddNewCategoryLabel = new System.Windows.Forms.Label();
            this.AddCategoryButton = new SwiftInventory.CustomControls.RoundButton();
            this.SearchCustomerTextBox = new System.Windows.Forms.TextBox();
            this.Delete = new SwiftInventory.CustomControls.RoundButton();
            this.Edit = new SwiftInventory.CustomControls.RoundButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.AllCustomerGrid = new System.Windows.Forms.DataGridView();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ActiveCustomerGrid = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.roundButton3 = new SwiftInventory.CustomControls.RoundButton();
            this.View = new SwiftInventory.CustomControls.RoundButton();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllCustomerGrid)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActiveCustomerGrid)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddNewCategoryLabel
            // 
            this.AddNewCategoryLabel.AutoSize = true;
            this.AddNewCategoryLabel.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewCategoryLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddNewCategoryLabel.Location = new System.Drawing.Point(3, 9);
            this.AddNewCategoryLabel.Name = "AddNewCategoryLabel";
            this.AddNewCategoryLabel.Size = new System.Drawing.Size(133, 32);
            this.AddNewCategoryLabel.TabIndex = 3;
            this.AddNewCategoryLabel.Text = "Customers";
            // 
            // AddCategoryButton
            // 
            this.AddCategoryButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AddCategoryButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AddCategoryButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.AddCategoryButton.BorderRadius = 5;
            this.AddCategoryButton.BorderSize = 0;
            this.AddCategoryButton.FlatAppearance.BorderSize = 0;
            this.AddCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCategoryButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddCategoryButton.ForeColor = System.Drawing.Color.Black;
            this.AddCategoryButton.Location = new System.Drawing.Point(36, 137);
            this.AddCategoryButton.Name = "AddCategoryButton";
            this.AddCategoryButton.Size = new System.Drawing.Size(130, 40);
            this.AddCategoryButton.TabIndex = 7;
            this.AddCategoryButton.Text = "Search";
            this.AddCategoryButton.UseVisualStyleBackColor = false;
            // 
            // SearchCustomerTextBox
            // 
            this.SearchCustomerTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchCustomerTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.SearchCustomerTextBox.Font = new System.Drawing.Font("Segoe UI Variable Display", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchCustomerTextBox.Location = new System.Drawing.Point(36, 73);
            this.SearchCustomerTextBox.Name = "SearchCustomerTextBox";
            this.SearchCustomerTextBox.Size = new System.Drawing.Size(382, 43);
            this.SearchCustomerTextBox.TabIndex = 5;
            // 
            // Delete
            // 
            this.Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Delete.BackColor = System.Drawing.Color.PaleVioletRed;
            this.Delete.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Delete.BorderRadius = 5;
            this.Delete.BorderSize = 0;
            this.Delete.FlatAppearance.BorderSize = 0;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Delete.ForeColor = System.Drawing.Color.Black;
            this.Delete.Location = new System.Drawing.Point(810, 591);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(130, 40);
            this.Delete.TabIndex = 6;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.CadetBlue;
            this.Edit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Edit.BorderRadius = 5;
            this.Edit.BorderSize = 0;
            this.Edit.FlatAppearance.BorderSize = 0;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Edit.ForeColor = System.Drawing.Color.Black;
            this.Edit.Location = new System.Drawing.Point(285, 591);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(130, 40);
            this.Edit.TabIndex = 4;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(62)))), ((int)(((byte)(101)))));
            this.panel1.Controls.Add(this.AddNewCategoryLabel);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 58);
            this.panel1.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(62)))), ((int)(((byte)(101)))));
            this.panel5.Controls.Add(this.AllCustomerGrid);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Location = new System.Drawing.Point(33, 192);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(426, 364);
            this.panel5.TabIndex = 9;
            // 
            // AllCustomerGrid
            // 
            this.AllCustomerGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.AllCustomerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllCustomerGrid.Location = new System.Drawing.Point(6, 56);
            this.AllCustomerGrid.Name = "AllCustomerGrid";
            this.AllCustomerGrid.RowHeadersWidth = 51;
            this.AllCustomerGrid.RowTemplate.Height = 24;
            this.AllCustomerGrid.Size = new System.Drawing.Size(417, 305);
            this.AllCustomerGrid.TabIndex = 6;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(62)))), ((int)(((byte)(101)))));
            this.panel8.Controls.Add(this.pictureBox5);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(420, 47);
            this.panel8.TabIndex = 5;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(17, 11);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 33);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(55, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "All Customers";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(62)))), ((int)(((byte)(101)))));
            this.panel2.Controls.Add(this.ActiveCustomerGrid);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(506, 192);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(437, 364);
            this.panel2.TabIndex = 10;
            // 
            // ActiveCustomerGrid
            // 
            this.ActiveCustomerGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.ActiveCustomerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActiveCustomerGrid.Location = new System.Drawing.Point(6, 56);
            this.ActiveCustomerGrid.Name = "ActiveCustomerGrid";
            this.ActiveCustomerGrid.RowHeadersWidth = 51;
            this.ActiveCustomerGrid.RowTemplate.Height = 24;
            this.ActiveCustomerGrid.Size = new System.Drawing.Size(428, 305);
            this.ActiveCustomerGrid.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(62)))), ((int)(((byte)(101)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(431, 47);
            this.panel3.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Acive Customers";
            // 
            // roundButton3
            // 
            this.roundButton3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.roundButton3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.roundButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundButton3.BorderRadius = 5;
            this.roundButton3.BorderSize = 0;
            this.roundButton3.FlatAppearance.BorderSize = 0;
            this.roundButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.roundButton3.ForeColor = System.Drawing.Color.Black;
            this.roundButton3.Location = new System.Drawing.Point(39, 591);
            this.roundButton3.Name = "roundButton3";
            this.roundButton3.Size = new System.Drawing.Size(130, 40);
            this.roundButton3.TabIndex = 11;
            this.roundButton3.Text = "Add";
            this.roundButton3.UseVisualStyleBackColor = false;
            this.roundButton3.Click += new System.EventHandler(this.roundButton3_Click);
            // 
            // View
            // 
            this.View.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.View.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.View.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.View.BorderRadius = 5;
            this.View.BorderSize = 0;
            this.View.FlatAppearance.BorderSize = 0;
            this.View.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.View.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.View.ForeColor = System.Drawing.Color.Black;
            this.View.Location = new System.Drawing.Point(541, 591);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(130, 40);
            this.View.TabIndex = 12;
            this.View.Text = "View";
            this.View.UseVisualStyleBackColor = false;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // CustomerFrorm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(59)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(985, 688);
            this.Controls.Add(this.View);
            this.Controls.Add(this.roundButton3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AddCategoryButton);
            this.Controls.Add(this.SearchCustomerTextBox);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Edit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerFrorm";
            this.Text = "CustomerFrorm";
            this.Load += new System.EventHandler(this.CustomerFrorm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AllCustomerGrid)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ActiveCustomerGrid)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddNewCategoryLabel;
        private CustomControls.RoundButton AddCategoryButton;
        private System.Windows.Forms.TextBox SearchCustomerTextBox;
        private CustomControls.RoundButton Delete;
        private CustomControls.RoundButton Edit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView AllCustomerGrid;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView ActiveCustomerGrid;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private CustomControls.RoundButton roundButton3;
        private CustomControls.RoundButton View;
    }
}