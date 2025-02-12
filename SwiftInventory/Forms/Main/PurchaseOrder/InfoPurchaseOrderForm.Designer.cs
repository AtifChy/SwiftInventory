namespace SwiftInventory.Forms.Main.PurchaseOrder
{
    partial class InfoPurchaseOrderForm
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
            this.ManageSupplierLabel = new System.Windows.Forms.Label();
            this.OrderFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PaymentStatusText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalAmountText = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.SupplierNameText = new System.Windows.Forms.TextBox();
            this.SupplierNameLabel = new System.Windows.Forms.Label();
            this.FirstInfoViewControl = new SwiftInventory.CustomControls.ProductItemControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CloseButton = new SwiftInventory.CustomControls.RoundButton();
            this.panel5.SuspendLayout();
            this.OrderFlowLayoutPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.ManageSupplierLabel);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(907, 57);
            this.panel5.TabIndex = 9;
            // 
            // ManageSupplierLabel
            // 
            this.ManageSupplierLabel.AutoSize = true;
            this.ManageSupplierLabel.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageSupplierLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.ManageSupplierLabel.Location = new System.Drawing.Point(23, 11);
            this.ManageSupplierLabel.Name = "ManageSupplierLabel";
            this.ManageSupplierLabel.Size = new System.Drawing.Size(232, 32);
            this.ManageSupplierLabel.TabIndex = 1;
            this.ManageSupplierLabel.Text = "Purchase Order Info";
            // 
            // OrderFlowLayoutPanel
            // 
            this.OrderFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderFlowLayoutPanel.AutoScroll = true;
            this.OrderFlowLayoutPanel.Controls.Add(this.panel1);
            this.OrderFlowLayoutPanel.Controls.Add(this.FirstInfoViewControl);
            this.OrderFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.OrderFlowLayoutPanel.Location = new System.Drawing.Point(3, 63);
            this.OrderFlowLayoutPanel.Name = "OrderFlowLayoutPanel";
            this.OrderFlowLayoutPanel.Size = new System.Drawing.Size(901, 605);
            this.OrderFlowLayoutPanel.TabIndex = 12;
            this.OrderFlowLayoutPanel.WrapContents = false;
            this.OrderFlowLayoutPanel.SizeChanged += new System.EventHandler(this.OrderFlowLayoutPanel_SizeChanged);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.PaymentStatusText);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TotalAmountText);
            this.panel1.Controls.Add(this.totalLabel);
            this.panel1.Controls.Add(this.SupplierNameText);
            this.panel1.Controls.Add(this.SupplierNameLabel);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 72);
            this.panel1.TabIndex = 1;
            // 
            // PaymentStatusText
            // 
            this.PaymentStatusText.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold);
            this.PaymentStatusText.Location = new System.Drawing.Point(478, 35);
            this.PaymentStatusText.Name = "PaymentStatusText";
            this.PaymentStatusText.ReadOnly = true;
            this.PaymentStatusText.Size = new System.Drawing.Size(125, 34);
            this.PaymentStatusText.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(474, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "Payment Status";
            // 
            // TotalAmountText
            // 
            this.TotalAmountText.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold);
            this.TotalAmountText.Location = new System.Drawing.Point(315, 35);
            this.TotalAmountText.Name = "TotalAmountText";
            this.TotalAmountText.ReadOnly = true;
            this.TotalAmountText.Size = new System.Drawing.Size(137, 34);
            this.TotalAmountText.TabIndex = 19;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(311, 5);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(112, 22);
            this.totalLabel.TabIndex = 18;
            this.totalLabel.Text = "Total Amount";
            // 
            // SupplierNameText
            // 
            this.SupplierNameText.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold);
            this.SupplierNameText.Location = new System.Drawing.Point(7, 35);
            this.SupplierNameText.Name = "SupplierNameText";
            this.SupplierNameText.ReadOnly = true;
            this.SupplierNameText.Size = new System.Drawing.Size(284, 34);
            this.SupplierNameText.TabIndex = 17;
            // 
            // SupplierNameLabel
            // 
            this.SupplierNameLabel.AutoSize = true;
            this.SupplierNameLabel.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierNameLabel.Location = new System.Drawing.Point(3, 5);
            this.SupplierNameLabel.Name = "SupplierNameLabel";
            this.SupplierNameLabel.Size = new System.Drawing.Size(124, 22);
            this.SupplierNameLabel.TabIndex = 16;
            this.SupplierNameLabel.Text = "Supplier Name";
            // 
            // FirstInfoViewControl
            // 
            this.FirstInfoViewControl.AutoSize = true;
            this.FirstInfoViewControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FirstInfoViewControl.Location = new System.Drawing.Point(3, 82);
            this.FirstInfoViewControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FirstInfoViewControl.Name = "FirstInfoViewControl";
            this.FirstInfoViewControl.Size = new System.Drawing.Size(586, 178);
            this.FirstInfoViewControl.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.CloseButton, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 674);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(907, 58);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CloseButton.BackColor = System.Drawing.Color.PaleVioletRed;
            this.CloseButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.CloseButton.BorderRadius = 5;
            this.CloseButton.BorderSize = 0;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.Black;
            this.CloseButton.Location = new System.Drawing.Point(720, 9);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(130, 40);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // InfoPurchaseOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(62)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(907, 732);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.OrderFlowLayoutPanel);
            this.Controls.Add(this.panel5);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "InfoPurchaseOrderForm";
            this.Text = "ViewOrderForm";
            this.Load += new System.EventHandler(this.InfoOrderForm_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.OrderFlowLayoutPanel.ResumeLayout(false);
            this.OrderFlowLayoutPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label ManageSupplierLabel;
        private System.Windows.Forms.FlowLayoutPanel OrderFlowLayoutPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SupplierNameLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CustomControls.RoundButton CloseButton;
        private System.Windows.Forms.TextBox SupplierNameText;
        private CustomControls.ProductItemControl FirstInfoViewControl;
        private System.Windows.Forms.TextBox TotalAmountText;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox PaymentStatusText;
        private System.Windows.Forms.Label label1;
    }
}