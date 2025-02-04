namespace SwiftInventory.CustomControls
{
    partial class InfoOrderControl
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
            this.quantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._productNameText = new System.Windows.Forms.TextBox();
            this.productPicture = new System.Windows.Forms.PictureBox();
            this._subtotalTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // quantityNumericUpDown
            // 
            this.quantityNumericUpDown.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold);
            this.quantityNumericUpDown.Location = new System.Drawing.Point(243, 100);
            this.quantityNumericUpDown.Name = "quantityNumericUpDown";
            this.quantityNumericUpDown.ReadOnly = true;
            this.quantityNumericUpDown.Size = new System.Drawing.Size(146, 34);
            this.quantityNumericUpDown.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(239, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "Product Name";
            // 
            // _productNameText
            // 
            this._productNameText.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold);
            this._productNameText.Location = new System.Drawing.Point(243, 32);
            this._productNameText.Name = "_productNameText";
            this._productNameText.ReadOnly = true;
            this._productNameText.Size = new System.Drawing.Size(340, 34);
            this._productNameText.TabIndex = 21;
            // 
            // productPicture
            // 
            this.productPicture.Image = global::SwiftInventory.Properties.Resources.icons8_picture_80;
            this.productPicture.Location = new System.Drawing.Point(3, 3);
            this.productPicture.Name = "productPicture";
            this.productPicture.Size = new System.Drawing.Size(125, 136);
            this.productPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.productPicture.TabIndex = 0;
            this.productPicture.TabStop = false;
            // 
            // _subtotalTextBox
            // 
            this._subtotalTextBox.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold);
            this._subtotalTextBox.Location = new System.Drawing.Point(412, 100);
            this._subtotalTextBox.Name = "_subtotalTextBox";
            this._subtotalTextBox.ReadOnly = true;
            this._subtotalTextBox.Size = new System.Drawing.Size(171, 34);
            this._subtotalTextBox.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(408, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 22);
            this.label3.TabIndex = 22;
            this.label3.Text = "Subtotal";
            // 
            // InfoOrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.label3);
            this.Controls.Add(this._productNameText);
            this.Controls.Add(this._subtotalTextBox);
            this.Controls.Add(this.quantityNumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productPicture);
            this.Name = "InfoOrderControl";
            this.Size = new System.Drawing.Size(586, 142);
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox productPicture;
        private System.Windows.Forms.NumericUpDown quantityNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _productNameText;
        private System.Windows.Forms.TextBox _subtotalTextBox;
        private System.Windows.Forms.Label label3;
    }
}
