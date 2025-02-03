namespace SwiftInventory
{
    partial class ViewDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewDetailsForm));
            this.View = new SwiftInventory.CustomControls.RoundButton();
            this.roundButton3 = new SwiftInventory.CustomControls.RoundButton();
            this.AllCustomerGrid = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddNewCategoryLabel = new System.Windows.Forms.Label();
            this.Delete = new SwiftInventory.CustomControls.RoundButton();
            this.Edit = new SwiftInventory.CustomControls.RoundButton();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AllCustomerGrid)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
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
            this.View.Location = new System.Drawing.Point(559, 587);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(130, 40);
            this.View.TabIndex = 21;
            this.View.Text = "View";
            this.View.UseVisualStyleBackColor = false;
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
            this.roundButton3.Location = new System.Drawing.Point(36, 587);
            this.roundButton3.Name = "roundButton3";
            this.roundButton3.Size = new System.Drawing.Size(130, 40);
            this.roundButton3.TabIndex = 20;
            this.roundButton3.Text = "Add";
            this.roundButton3.UseVisualStyleBackColor = false;
            // 
            // AllCustomerGrid
            // 
            this.AllCustomerGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.AllCustomerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllCustomerGrid.Location = new System.Drawing.Point(6, 56);
            this.AllCustomerGrid.Name = "AllCustomerGrid";
            this.AllCustomerGrid.RowHeadersWidth = 51;
            this.AllCustomerGrid.RowTemplate.Height = 24;
            this.AllCustomerGrid.Size = new System.Drawing.Size(892, 415);
            this.AllCustomerGrid.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(55, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Customer Details";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(62)))), ((int)(((byte)(101)))));
            this.panel8.Controls.Add(this.pictureBox5);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(895, 47);
            this.panel8.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(62)))), ((int)(((byte)(101)))));
            this.panel5.Controls.Add(this.AllCustomerGrid);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Location = new System.Drawing.Point(36, 92);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(901, 474);
            this.panel5.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(62)))), ((int)(((byte)(101)))));
            this.panel1.Controls.Add(this.AddNewCategoryLabel);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 55);
            this.panel1.TabIndex = 17;
            // 
            // AddNewCategoryLabel
            // 
            this.AddNewCategoryLabel.AutoSize = true;
            this.AddNewCategoryLabel.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewCategoryLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddNewCategoryLabel.Location = new System.Drawing.Point(3, 9);
            this.AddNewCategoryLabel.Name = "AddNewCategoryLabel";
            this.AddNewCategoryLabel.Size = new System.Drawing.Size(146, 32);
            this.AddNewCategoryLabel.TabIndex = 3;
            this.AddNewCategoryLabel.Text = "View Details";
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
            this.Delete.Location = new System.Drawing.Point(807, 587);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(130, 40);
            this.Delete.TabIndex = 15;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
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
            this.Edit.Location = new System.Drawing.Point(282, 587);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(130, 40);
            this.Edit.TabIndex = 13;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = false;
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
            // ViewDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(53)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(983, 692);
            this.Controls.Add(this.View);
            this.Controls.Add(this.roundButton3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Edit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewDetailsForm";
            this.Text = "ViewDetailsForm";
            ((System.ComponentModel.ISupportInitialize)(this.AllCustomerGrid)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox5;
        private CustomControls.RoundButton View;
        private CustomControls.RoundButton roundButton3;
        private System.Windows.Forms.DataGridView AllCustomerGrid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AddNewCategoryLabel;
        private CustomControls.RoundButton Delete;
        private CustomControls.RoundButton Edit;
    }
}