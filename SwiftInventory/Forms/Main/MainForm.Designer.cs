using System.Drawing;
using System.Windows.Forms;

namespace SwiftInventory.Forms.Main
{
    partial class MainForm
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
            this.MainTable = new System.Windows.Forms.TableLayoutPanel();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.SystemUsersButton = new FontAwesome.Sharp.IconButton();
            this.LogOutButton = new FontAwesome.Sharp.IconButton();
            this.PurchaseOrderButton = new FontAwesome.Sharp.IconButton();
            this.OrderButton = new FontAwesome.Sharp.IconButton();
            this.SalesButton = new FontAwesome.Sharp.IconButton();
            this.SupplierButton = new FontAwesome.Sharp.IconButton();
            this.CustomerButton = new FontAwesome.Sharp.IconButton();
            this.ProductButton = new FontAwesome.Sharp.IconButton();
            this.CategoryButton = new FontAwesome.Sharp.IconButton();
            this.DashboardButton = new FontAwesome.Sharp.IconButton();
            this.UserPicturePanel = new System.Windows.Forms.Panel();
            this.UserRoleLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.UserPictureBox = new System.Windows.Forms.PictureBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ChildFormPanel = new System.Windows.Forms.Panel();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.MenuButton = new FontAwesome.Sharp.IconButton();
            this.UserStatusPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.MainTable.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.UserPicturePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureBox)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.UserStatusPanel.SuspendLayout();
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
            this.MainTable.Size = new System.Drawing.Size(1182, 833);
            this.MainTable.TabIndex = 0;
            // 
            // MenuPanel
            // 
            this.MenuPanel.AutoScroll = true;
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(63)))));
            this.MenuPanel.Controls.Add(this.SystemUsersButton);
            this.MenuPanel.Controls.Add(this.LogOutButton);
            this.MenuPanel.Controls.Add(this.PurchaseOrderButton);
            this.MenuPanel.Controls.Add(this.OrderButton);
            this.MenuPanel.Controls.Add(this.SalesButton);
            this.MenuPanel.Controls.Add(this.SupplierButton);
            this.MenuPanel.Controls.Add(this.CustomerButton);
            this.MenuPanel.Controls.Add(this.ProductButton);
            this.MenuPanel.Controls.Add(this.CategoryButton);
            this.MenuPanel.Controls.Add(this.DashboardButton);
            this.MenuPanel.Controls.Add(this.UserPicturePanel);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.MenuPanel.Size = new System.Drawing.Size(300, 833);
            this.MenuPanel.TabIndex = 0;
            this.MenuPanel.VisibleChanged += new System.EventHandler(this.MenuPanel_VisibleChanged);
            // 
            // SystemUsersButton
            // 
            this.SystemUsersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(63)))));
            this.SystemUsersButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SystemUsersButton.FlatAppearance.BorderSize = 0;
            this.SystemUsersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(87)))));
            this.SystemUsersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SystemUsersButton.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SystemUsersButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.SystemUsersButton.IconChar = FontAwesome.Sharp.IconChar.PeopleRoof;
            this.SystemUsersButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.SystemUsersButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SystemUsersButton.IconSize = 28;
            this.SystemUsersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SystemUsersButton.Location = new System.Drawing.Point(0, 639);
            this.SystemUsersButton.Name = "SystemUsersButton";
            this.SystemUsersButton.Size = new System.Drawing.Size(300, 54);
            this.SystemUsersButton.TabIndex = 10;
            this.SystemUsersButton.Text = "System Users";
            this.SystemUsersButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SystemUsersButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SystemUsersButton.UseVisualStyleBackColor = false;
            this.SystemUsersButton.Click += new System.EventHandler(this.SystemUsersButton_Click);
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
            this.LogOutButton.Location = new System.Drawing.Point(0, 759);
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
            this.PurchaseOrderButton.Location = new System.Drawing.Point(0, 585);
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
            this.OrderButton.Location = new System.Drawing.Point(0, 531);
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
            this.SalesButton.Location = new System.Drawing.Point(0, 477);
            this.SalesButton.Name = "SalesButton";
            this.SalesButton.Size = new System.Drawing.Size(300, 54);
            this.SalesButton.TabIndex = 6;
            this.SalesButton.Text = "Sales";
            this.SalesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SalesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SalesButton.UseVisualStyleBackColor = false;
            this.SalesButton.Visible = false;
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
            this.SupplierButton.Location = new System.Drawing.Point(0, 423);
            this.SupplierButton.Name = "SupplierButton";
            this.SupplierButton.Size = new System.Drawing.Size(300, 54);
            this.SupplierButton.TabIndex = 5;
            this.SupplierButton.Text = "Supplier";
            this.SupplierButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SupplierButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SupplierButton.UseVisualStyleBackColor = false;
            this.SupplierButton.Click += new System.EventHandler(this.SupplierButton_Click);
            // 
            // CustomerButton
            // 
            this.CustomerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(63)))));
            this.CustomerButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CustomerButton.FlatAppearance.BorderSize = 0;
            this.CustomerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(87)))));
            this.CustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomerButton.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.CustomerButton.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.CustomerButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.CustomerButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CustomerButton.IconSize = 28;
            this.CustomerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CustomerButton.Location = new System.Drawing.Point(0, 369);
            this.CustomerButton.Name = "CustomerButton";
            this.CustomerButton.Size = new System.Drawing.Size(300, 54);
            this.CustomerButton.TabIndex = 4;
            this.CustomerButton.Text = "Customer";
            this.CustomerButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CustomerButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CustomerButton.UseVisualStyleBackColor = false;
            this.CustomerButton.Click += new System.EventHandler(this.CustomerButton_Click);
            // 
            // ProductButton
            // 
            this.ProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(63)))));
            this.ProductButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProductButton.FlatAppearance.BorderSize = 0;
            this.ProductButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(87)))));
            this.ProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductButton.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.ProductButton.IconChar = FontAwesome.Sharp.IconChar.Cubes;
            this.ProductButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.ProductButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ProductButton.IconSize = 28;
            this.ProductButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ProductButton.Location = new System.Drawing.Point(0, 315);
            this.ProductButton.Name = "ProductButton";
            this.ProductButton.Size = new System.Drawing.Size(300, 54);
            this.ProductButton.TabIndex = 3;
            this.ProductButton.Text = "Product";
            this.ProductButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProductButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ProductButton.UseVisualStyleBackColor = false;
            this.ProductButton.Click += new System.EventHandler(this.ProductButton_Click);
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
            this.CategoryButton.Location = new System.Drawing.Point(0, 261);
            this.CategoryButton.Name = "CategoryButton";
            this.CategoryButton.Size = new System.Drawing.Size(300, 54);
            this.CategoryButton.TabIndex = 2;
            this.CategoryButton.Text = "Category";
            this.CategoryButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CategoryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CategoryButton.UseVisualStyleBackColor = false;
            this.CategoryButton.Click += new System.EventHandler(this.CategoryButton_Click);
            // 
            // DashboardButton
            // 
            this.DashboardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(63)))));
            this.DashboardButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.DashboardButton.FlatAppearance.BorderSize = 0;
            this.DashboardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(87)))));
            this.DashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashboardButton.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.DashboardButton.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            this.DashboardButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.DashboardButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DashboardButton.IconSize = 28;
            this.DashboardButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DashboardButton.Location = new System.Drawing.Point(0, 207);
            this.DashboardButton.Name = "DashboardButton";
            this.DashboardButton.Size = new System.Drawing.Size(300, 54);
            this.DashboardButton.TabIndex = 1;
            this.DashboardButton.Text = "Dashboard";
            this.DashboardButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashboardButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DashboardButton.UseVisualStyleBackColor = false;
            this.DashboardButton.Click += new System.EventHandler(this.DashboardButton_Click);
            // 
            // UserPicturePanel
            // 
            this.UserPicturePanel.Controls.Add(this.UserStatusPanel);
            this.UserPicturePanel.Controls.Add(this.UserPictureBox);
            this.UserPicturePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserPicturePanel.Location = new System.Drawing.Point(0, 0);
            this.UserPicturePanel.Name = "UserPicturePanel";
            this.UserPicturePanel.Size = new System.Drawing.Size(300, 207);
            this.UserPicturePanel.TabIndex = 0;
            // 
            // UserRoleLabel
            // 
            this.UserRoleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserRoleLabel.AutoSize = true;
            this.UserRoleLabel.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserRoleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.UserRoleLabel.Location = new System.Drawing.Point(5, 31);
            this.UserRoleLabel.Name = "UserRoleLabel";
            this.UserRoleLabel.Size = new System.Drawing.Size(58, 24);
            this.UserRoleLabel.TabIndex = 2;
            this.UserRoleLabel.Text = "(Role)";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.UserNameLabel.Location = new System.Drawing.Point(3, 0);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(62, 31);
            this.UserNameLabel.TabIndex = 1;
            this.UserNameLabel.Text = "User";
            // 
            // UserPictureBox
            // 
            this.UserPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UserPictureBox.Image = global::SwiftInventory.Properties.Resources.icons8_account_94;
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
            this.MainPanel.Size = new System.Drawing.Size(882, 833);
            this.MainPanel.TabIndex = 1;
            // 
            // ChildFormPanel
            // 
            this.ChildFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildFormPanel.Location = new System.Drawing.Point(0, 65);
            this.ChildFormPanel.Name = "ChildFormPanel";
            this.ChildFormPanel.Size = new System.Drawing.Size(882, 768);
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
            this.HeaderPanel.Size = new System.Drawing.Size(882, 65);
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
            // UserStatusPanel
            // 
            this.UserStatusPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.UserStatusPanel.Controls.Add(this.UserNameLabel);
            this.UserStatusPanel.Controls.Add(this.UserRoleLabel);
            this.UserStatusPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.UserStatusPanel.Location = new System.Drawing.Point(3, 129);
            this.UserStatusPanel.Name = "UserStatusPanel";
            this.UserStatusPanel.Size = new System.Drawing.Size(294, 72);
            this.UserStatusPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 833);
            this.Controls.Add(this.MainTable);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.Text = "Admin Form";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.MainTable.ResumeLayout(false);
            this.MenuPanel.ResumeLayout(false);
            this.UserPicturePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureBox)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.UserStatusPanel.ResumeLayout(false);
            this.UserStatusPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel MainTable;
        private Panel MenuPanel;
        private Panel UserPicturePanel;
        private PictureBox UserPictureBox;
        private FontAwesome.Sharp.IconButton DashboardButton;
        private FontAwesome.Sharp.IconButton CategoryButton;
        private Label UserNameLabel;
        private Panel MainPanel;
        private Panel ChildFormPanel;
        private Panel HeaderPanel;
        private Label HeaderLabel;
        private FontAwesome.Sharp.IconButton MenuButton;
        private FontAwesome.Sharp.IconButton SalesButton;
        private FontAwesome.Sharp.IconButton SupplierButton;
        private FontAwesome.Sharp.IconButton CustomerButton;
        private FontAwesome.Sharp.IconButton ProductButton;
        private FontAwesome.Sharp.IconButton OrderButton;
        private FontAwesome.Sharp.IconButton PurchaseOrderButton;
        private FontAwesome.Sharp.IconButton LogOutButton;
        private FontAwesome.Sharp.IconButton SystemUsersButton;
        private Label UserRoleLabel;
        private FlowLayoutPanel UserStatusPanel;
    }
}
