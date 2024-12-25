namespace KayakRental
{
    partial class AdminForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.stockListBox = new System.Windows.Forms.ListBox();
            this.shoeSizeLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.shoeSizeTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.addStockButton = new System.Windows.Forms.Button();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.setPriceButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stockListBox
            // 
            this.stockListBox.FormattingEnabled = true;
            this.stockListBox.ItemHeight = 15;
            this.stockListBox.Location = new System.Drawing.Point(12, 12);
            this.stockListBox.Name = "stockListBox";
            this.stockListBox.Size = new System.Drawing.Size(460, 214);
            this.stockListBox.TabIndex = 0;
            // 
            // shoeSizeLabel
            // 
            this.shoeSizeLabel.AutoSize = true;
            this.shoeSizeLabel.Location = new System.Drawing.Point(12, 240);
            this.shoeSizeLabel.Name = "shoeSizeLabel";
            this.shoeSizeLabel.Size = new System.Drawing.Size(94, 15);
            this.shoeSizeLabel.TabIndex = 1;
            this.shoeSizeLabel.Text = "Ayakkabı Numarası:";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(12, 270);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(45, 15);
            this.quantityLabel.TabIndex = 2;
            this.quantityLabel.Text = "Miktar:";
            // 
            // shoeSizeTextBox
            // 
            this.shoeSizeTextBox.Location = new System.Drawing.Point(120, 237);
            this.shoeSizeTextBox.Name = "shoeSizeTextBox";
            this.shoeSizeTextBox.Size = new System.Drawing.Size(100, 23);
            this.shoeSizeTextBox.TabIndex = 3;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(120, 267);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 23);
            this.quantityTextBox.TabIndex = 4;
            // 
            // addStockButton
            // 
            this.addStockButton.Location = new System.Drawing.Point(237, 237);
            this.addStockButton.Name = "addStockButton";
            this.addStockButton.Size = new System.Drawing.Size(75, 23);
            this.addStockButton.TabIndex = 5;
            this.addStockButton.Text = "Stok Ekle";
            this.addStockButton.UseVisualStyleBackColor = true;
            this.addStockButton.Click += new System.EventHandler(this.addStockButton_Click);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(12, 297);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(34, 15);
            this.priceLabel.TabIndex = 6;
            this.priceLabel.Text = "Fiyat:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(120, 297);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 23);
            this.priceTextBox.TabIndex = 7;
            // 
            // setPriceButton
            // 
            this.setPriceButton.Location = new System.Drawing.Point(237, 297);
            this.setPriceButton.Name = "setPriceButton";
            this.setPriceButton.Size = new System.Drawing.Size(75, 23);
            this.setPriceButton.TabIndex = 8;
            this.setPriceButton.Text = "Fiyat Ayarla";
            this.setPriceButton.UseVisualStyleBackColor = true;
            this.setPriceButton.Click += new System.EventHandler(this.setPriceButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(320, 237);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 9;
            this.refreshButton.Text = "Yenile";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.setPriceButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.addStockButton);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.shoeSizeTextBox);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.shoeSizeLabel);
            this.Controls.Add(this.stockListBox);
            this.Name = "AdminForm";
            this.Text = "Admin Paneli";
            this.MaximizeBox = false; // Tam ekran özelliğini kapat
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ListBox stockListBox;
        private System.Windows.Forms.Label shoeSizeLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox shoeSizeTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Button addStockButton;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Button setPriceButton;
        private System.Windows.Forms.Button refreshButton;
    }
}