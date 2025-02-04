namespace SwiftInventory.CustomControls
{
    partial class OrderControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.removeButton = new SwiftInventory.CustomControls.RoundButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.quantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.PaleVioletRed;
            this.removeButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.removeButton.BorderRadius = 5;
            this.removeButton.BorderSize = 0;
            this.removeButton.FlatAppearance.BorderSize = 0;
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold);
            this.removeButton.ForeColor = System.Drawing.Color.Black;
            this.removeButton.Location = new System.Drawing.Point(494, 23);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(110, 33);
            this.removeButton.TabIndex = 14;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(287, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Product Name";
            // 
            // productComboBox
            // 
            this.productComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productComboBox.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(3, 25);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(276, 35);
            this.productComboBox.TabIndex = 10;
            // 
            // quantityNumericUpDown
            // 
            this.quantityNumericUpDown.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold);
            this.quantityNumericUpDown.Location = new System.Drawing.Point(285, 25);
            this.quantityNumericUpDown.Name = "quantityNumericUpDown";
            this.quantityNumericUpDown.Size = new System.Drawing.Size(203, 34);
            this.quantityNumericUpDown.TabIndex = 15;
            // 
            // OrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.quantityNumericUpDown);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productComboBox);
            this.Name = "OrderControl";
            this.Size = new System.Drawing.Size(607, 63);
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundButton removeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox productComboBox;
        private System.Windows.Forms.NumericUpDown quantityNumericUpDown;
    }
}
