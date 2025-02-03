using System.Drawing;
using System.Windows.Forms;

namespace SwiftInventory.Forms.Main
{
    partial class ManagerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.MainTable = new System.Windows.Forms.TableLayoutPanel();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.LogOutButton = new FontAwesome.Sharp.IconButton();
            this.PurchaseOrderButton = new FontAwesome.Sharp.IconButton();
            this.OrderButton = new FontAwesome.Sharp.IconButton();
            this.SalesButton = new FontAwesome.Sharp.IconButton();
            this.SupplierButton = new FontAwesome.Sharp.IconButton();
            this.InventoryButton = new FontAwesome.Sharp.IconButton();
            this.CategoryButton = new FontAwesome.Sharp.IconButton();
            this.UserPicturePanel = new System.Windows.Forms.Panel();
            this.UserLabel = new System.Windows.Forms.Label();
            this.UserPictureBox = new System.Windows.Forms.PictureBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ChildFormPanel = new System.Windows.Forms.Panel();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.MenuButton = new FontAwesome.Sharp.IconButton();
            this.MainTable.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.UserPicturePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureBox)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTable
            // 
            this.MainTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(62)))), ((int)(((byte)(101)))));
            this.MainTable.ColumnCount = 2;
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTable.Controls.Add(this.MenuPanel, 0, 0);
            this.MainTable.Controls.Add(this.MainPanel, 1, 0);
            this.MainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTable.Location = new System.Drawing.Point(0, 0);
            this.MainTable.Margin = new System.Windows.Forms.Padding(0);
            this.MainTable.Name = "MainTable";
            this.MainTable.RowCount = 1;
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTable.Size = new System.Drawing.Size(1157, 801);
            this.MainTable.TabIndex = 0;
            // 
            // MenuPanel
            // 
            this.MenuPanel.AutoScroll = true;
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(63)))));
            this.MenuPanel.Controls.Add(this.LogOutButton);
            this.MenuPanel.Controls.Add(this.PurchaseOrderButton);
            this.MenuPanel.Controls.Add(this.OrderButton);
            this.MenuPanel.Controls.Add(this.SalesButton);
            this.MenuPanel.Controls.Add(this.SupplierButton);
            this.MenuPanel.Controls.Add(this.InventoryButton);
            this.MenuPanel.Controls.Add(this.CategoryButton);
            this.MenuPanel.Controls.Add(this.UserPicturePanel);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.MenuPanel.Size = new System.Drawing.Size(300, 801);
            this.MenuPanel.TabIndex = 0;
            this.MenuPanel.VisibleChanged += new System.EventHandler(this.MenuPanel_VisibleChanged);
            // 
            // LogOutButton
            // 
            this.LogOutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(63)))));
            this.LogOutButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LogOutButton.FlatAppearance.BorderSize = 0;
            this.LogOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutButton.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.LogOutButton.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.LogOutButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.LogOutButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LogOutButton.IconSize = 28;
            this.LogOutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LogOutButton.Location = new System.Drawing.Point(0, 727);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(300, 54);
            this.LogOutButton.TabIndex = 9;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogOutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LogOutButton.UseVisualStyleBackColor = false;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            this.LogOutButton.MouseEnter += new System.EventHandler(this.LogOutButton_MouseEnter);
            this.LogOutButton.MouseLeave += new System.EventHandler(this.LogOutButton_MouseLeave);
            // 
            // PurchaseOrderButton
            // 
            this.PurchaseOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(63)))));
            this.PurchaseOrderButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.PurchaseOrderButton.FlatAppearance.BorderSize = 0;
            this.PurchaseOrderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(87)))));
            this.PurchaseOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PurchaseOrderButton.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchaseOrderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.PurchaseOrderButton.IconChar = FontAwesome.Sharp.IconChar.TruckRampBox;
            this.PurchaseOrderButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.PurchaseOrderButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PurchaseOrderButton.IconSize = 28;
            this.PurchaseOrderButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PurchaseOrderButton.Location = new System.Drawing.Point(0, 446);
            this.PurchaseOrderButton.Name = "PurchaseOrderButton";
            this.PurchaseOrderButton.Size = new System.Drawing.Size(300, 54);
            this.PurchaseOrderButton.TabIndex = 8;
            this.PurchaseOrderButton.Text = "Purchase Order";
            this.PurchaseOrderButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PurchaseOrderButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PurchaseOrderButton.UseVisualStyleBackColor = false;
            this.PurchaseOrderButton.Click += new System.EventHandler(this.PurchaseOrderButton_Click);
            // 
            // OrderButton
            // 
            this.OrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(63)))));
            this.OrderButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.OrderButton.FlatAppearance.BorderSize = 0;
            this.OrderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(87)))));
            this.OrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderButton.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.OrderButton.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            this.OrderButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.OrderButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.OrderButton.IconSize = 28;
            this.OrderButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OrderButton.Location = new System.Drawing.Point(0, 392);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(300, 54);
            this.OrderButton.TabIndex = 7;
            this.OrderButton.Text = "Order";
            this.OrderButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OrderButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.OrderButton.UseVisualStyleBackColor = false;
            this.OrderButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // SalesButton
            // 
            this.SalesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(63)))));
            this.SalesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SalesButton.FlatAppearance.BorderSize = 0;
            this.SalesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(87)))));
            this.SalesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalesButton.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.SalesButton.IconChar = FontAwesome.Sharp.IconChar.ArrowTrendUp;
            this.SalesButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.SalesButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SalesButton.IconSize = 28;
            this.SalesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SalesButton.Location = new System.Drawing.Point(0, 338);
            this.SalesButton.Name = "SalesButton";
            this.SalesButton.Size = new System.Drawing.Size(300, 54);
            this.SalesButton.TabIndex = 6;
            this.SalesButton.Text = "Sales";
            this.SalesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SalesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SalesButton.UseVisualStyleBackColor = false;
            this.SalesButton.Click += new System.EventHandler(this.SalesButton_Click);
            // 
            // SupplierButton
            // 
            this.SupplierButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(63)))));
            this.SupplierButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SupplierButton.FlatAppearance.BorderSize = 0;
            this.SupplierButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(87)))));
            this.SupplierButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SupplierButton.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.SupplierButton.IconChar = FontAwesome.Sharp.IconChar.TruckFast;
            this.SupplierButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.SupplierButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SupplierButton.IconSize = 28;
            this.SupplierButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SupplierButton.Location = new System.Drawing.Point(0, 284);
            this.SupplierButton.Name = "SupplierButton";
            this.SupplierButton.Size = new System.Drawing.Size(300, 54);
            this.SupplierButton.TabIndex = 5;
            this.SupplierButton.Text = "Supplier";
            this.SupplierButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SupplierButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SupplierButton.UseVisualStyleBackColor = false;
            this.SupplierButton.Click += new System.EventHandler(this.SupplierButton_Click);
            // 
            // InventoryButton
            // 
            this.InventoryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(63)))));
            this.InventoryButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.InventoryButton.FlatAppearance.BorderSize = 0;
            this.InventoryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(87)))));
            this.InventoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InventoryButton.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.InventoryButton.IconChar = FontAwesome.Sharp.IconChar.Cubes;
            this.InventoryButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.InventoryButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.InventoryButton.IconSize = 28;
            this.InventoryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.InventoryButton.Location = new System.Drawing.Point(0, 230);
            this.InventoryButton.Name = "InventoryButton";
            this.InventoryButton.Size = new System.Drawing.Size(300, 54);
            this.InventoryButton.TabIndex = 3;
            this.InventoryButton.Text = "Inventory";
            this.InventoryButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InventoryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.InventoryButton.UseVisualStyleBackColor = false;
            this.InventoryButton.Click += new System.EventHandler(this.ProductButton_Click);
            // 
            // CategoryButton
            // 
            this.CategoryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(63)))));
            this.CategoryButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CategoryButton.FlatAppearance.BorderSize = 0;
            this.CategoryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(87)))));
            this.CategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CategoryButton.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.CategoryButton.IconChar = FontAwesome.Sharp.IconChar.ListUl;
            this.CategoryButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.CategoryButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CategoryButton.IconSize = 28;
            this.CategoryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CategoryButton.Location = new System.Drawing.Point(0, 176);
            this.CategoryButton.Name = "CategoryButton";
            this.CategoryButton.Size = new System.Drawing.Size(300, 54);
            this.CategoryButton.TabIndex = 2;
            this.CategoryButton.Text = "Category";
            this.CategoryButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CategoryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CategoryButton.UseVisualStyleBackColor = false;
            this.CategoryButton.Click += new System.EventHandler(this.CategoryButton_Click);
            // 
            // UserPicturePanel
            // 
            this.UserPicturePanel.Controls.Add(this.UserLabel);
            this.UserPicturePanel.Controls.Add(this.UserPictureBox);
            this.UserPicturePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserPicturePanel.Location = new System.Drawing.Point(0, 0);
            this.UserPicturePanel.Name = "UserPicturePanel";
            this.UserPicturePanel.Size = new System.Drawing.Size(300, 176);
            this.UserPicturePanel.TabIndex = 0;
            // 
            // UserLabel
            // 
            this.UserLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.UserLabel.Location = new System.Drawing.Point(113, 127);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(107, 31);
            this.UserLabel.TabIndex = 1;
            this.UserLabel.Text = "Manager";
            // 
            // UserPictureBox
            // 
            this.UserPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UserPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("UserPictureBox.Image")));
            this.UserPictureBox.Location = new System.Drawing.Point(89, 12);
            this.UserPictureBox.Name = "UserPictureBox";
            this.UserPictureBox.Size = new System.Drawing.Size(125, 112);
            this.UserPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserPictureBox.TabIndex = 0;
            this.UserPictureBox.TabStop = false;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.ChildFormPanel);
            this.MainPanel.Controls.Add(this.HeaderPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(300, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(857, 801);
            this.MainPanel.TabIndex = 1;
            // 
            // ChildFormPanel
            // 
            this.ChildFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildFormPanel.Location = new System.Drawing.Point(0, 65);
            this.ChildFormPanel.Name = "ChildFormPanel";
            this.ChildFormPanel.Size = new System.Drawing.Size(857, 736);
            this.ChildFormPanel.TabIndex = 1;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(87)))));
            this.HeaderPanel.Controls.Add(this.HeaderLabel);
            this.HeaderPanel.Controls.Add(this.MenuButton);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Margin = new System.Windows.Forms.Padding(0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(857, 65);
            this.HeaderPanel.TabIndex = 0;
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI Variable Display", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.HeaderLabel.Location = new System.Drawing.Point(58, 12);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(151, 37);
            this.HeaderLabel.TabIndex = 1;
            this.HeaderLabel.Text = "Dashboard";
            // 
            // MenuButton
            // 
            this.MenuButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuButton.FlatAppearance.BorderSize = 0;
            this.MenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.MenuButton.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            this.MenuButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.MenuButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuButton.IconSize = 28;
            this.MenuButton.Location = new System.Drawing.Point(0, 0);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.MenuButton.Size = new System.Drawing.Size(52, 65);
            this.MenuButton.TabIndex = 0;
            this.MenuButton.UseVisualStyleBackColor = true;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 801);
            this.Controls.Add(this.MainTable);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ManagerForm";
            this.Text = "Manager Form";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.MainTable.ResumeLayout(false);
            this.MenuPanel.ResumeLayout(false);
            this.UserPicturePanel.ResumeLayout(false);
            this.UserPicturePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureBox)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel MainTable;
        private Panel MenuPanel;
        private Panel UserPicturePanel;
        private PictureBox UserPictureBox;
        private FontAwesome.Sharp.IconButton CategoryButton;
        private Label UserLabel;
        private Panel MainPanel;
        private Panel ChildFormPanel;
        private Panel HeaderPanel;
        private Label HeaderLabel;
        private FontAwesome.Sharp.IconButton MenuButton;
        private FontAwesome.Sharp.IconButton SalesButton;
        private FontAwesome.Sharp.IconButton SupplierButton;
        private FontAwesome.Sharp.IconButton InventoryButton;
        private FontAwesome.Sharp.IconButton LogOutButton;
        private FontAwesome.Sharp.IconButton PurchaseOrderButton;
        private FontAwesome.Sharp.IconButton OrderButton;
    }
}
