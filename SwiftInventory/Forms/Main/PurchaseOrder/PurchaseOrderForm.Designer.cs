namespace SwiftInventory.Forms.Main.Order
{
    partial class PurchaseOrderForm
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
            this.ChildFormPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ChildFormPanel
            // 
            this.ChildFormPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(62)))), ((int)(((byte)(101)))));
            this.ChildFormPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChildFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildFormPanel.Location = new System.Drawing.Point(20, 20);
            this.ChildFormPanel.Name = "ChildFormPanel";
            this.ChildFormPanel.Size = new System.Drawing.Size(866, 650);
            this.ChildFormPanel.TabIndex = 0;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(62)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(906, 690);
            this.Controls.Add(this.ChildFormPanel);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OrderForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ChildFormPanel;
    }
}