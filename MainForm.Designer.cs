namespace KayakRental
{
    partial class MainForm
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
            this.backgroundPanel = new System.Windows.Forms.Panel();
            this.genderLabel = new System.Windows.Forms.Label();
            this.shoeSizeLabel = new System.Windows.Forms.Label();
            this.rentalTimeLabel = new System.Windows.Forms.Label();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.shoeSizeTextBox = new System.Windows.Forms.TextBox();
            this.rentalTimeTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.viewButton = new System.Windows.Forms.Button();
            this.cartListBox = new System.Windows.Forms.ListBox();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.totalPriceValueLabel = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.adminButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.cartLabel = new System.Windows.Forms.Label();
            this.backgroundPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.BackgroundImage = System.Drawing.Image.FromFile("Resources/background.jpg");
            this.backgroundPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backgroundPanel.Controls.Add(this.genderLabel);
            this.backgroundPanel.Controls.Add(this.shoeSizeLabel);
            this.backgroundPanel.Controls.Add(this.rentalTimeLabel);
            this.backgroundPanel.Controls.Add(this.genderComboBox);
            this.backgroundPanel.Controls.Add(this.shoeSizeTextBox);
            this.backgroundPanel.Controls.Add(this.rentalTimeTextBox);
            this.backgroundPanel.Controls.Add(this.addButton);
            this.backgroundPanel.Controls.Add(this.viewButton);
            this.backgroundPanel.Controls.Add(this.cartListBox);
            this.backgroundPanel.Controls.Add(this.totalPriceLabel);
            this.backgroundPanel.Controls.Add(this.totalPriceValueLabel);
            this.backgroundPanel.Controls.Add(this.confirmButton);
            this.backgroundPanel.Controls.Add(this.adminButton);
            this.backgroundPanel.Controls.Add(this.removeButton);
            this.backgroundPanel.Controls.Add(this.cartLabel);
            this.backgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Size = new System.Drawing.Size(584, 361);
            this.backgroundPanel.TabIndex = 0;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.BackColor = System.Drawing.Color.Transparent;
            this.genderLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.genderLabel.ForeColor = System.Drawing.Color.Black;
            this.genderLabel.Location = new System.Drawing.Point(12, 15);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(60, 19);
            this.genderLabel.TabIndex = 0;
            this.genderLabel.Text = "Cinsiyet:";
            // 
            // shoeSizeLabel
            // 
            this.shoeSizeLabel.AutoSize = true;
            this.shoeSizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.shoeSizeLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shoeSizeLabel.ForeColor = System.Drawing.Color.Black;
            this.shoeSizeLabel.Location = new System.Drawing.Point(12, 44);
            this.shoeSizeLabel.Name = "shoeSizeLabel";
            this.shoeSizeLabel.Size = new System.Drawing.Size(124, 19);
            this.shoeSizeLabel.TabIndex = 1;
            this.shoeSizeLabel.Text = "Ayakkabı Numarası:";
            // 
            // rentalTimeLabel
            // 
            this.rentalTimeLabel.AutoSize = true;
            this.rentalTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.rentalTimeLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rentalTimeLabel.ForeColor = System.Drawing.Color.Black;
            this.rentalTimeLabel.Location = new System.Drawing.Point(12, 73);
            this.rentalTimeLabel.Name = "rentalTimeLabel";
            this.rentalTimeLabel.Size = new System.Drawing.Size(144, 19);
            this.rentalTimeLabel.TabIndex = 2;
            this.rentalTimeLabel.Text = "Kiralama Süresi (saat):";
            // 
            // genderComboBox
            // 
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.genderComboBox.Location = new System.Drawing.Point(160, 12);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(120, 23);
            this.genderComboBox.TabIndex = 3;
            // 
            // shoeSizeTextBox
            // 
            this.shoeSizeTextBox.Location = new System.Drawing.Point(160, 41);
            this.shoeSizeTextBox.Name = "shoeSizeTextBox";
            this.shoeSizeTextBox.Size = new System.Drawing.Size(120, 23);
            this.shoeSizeTextBox.TabIndex = 4;
            // 
            // rentalTimeTextBox
            // 
            this.rentalTimeTextBox.Location = new System.Drawing.Point(160, 70);
            this.rentalTimeTextBox.Name = "rentalTimeTextBox";
            this.rentalTimeTextBox.Size = new System.Drawing.Size(120, 23);
            this.rentalTimeTextBox.TabIndex = 5;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 99);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Ekle";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(205, 99);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(75, 23);
            this.viewButton.TabIndex = 7;
            this.viewButton.Text = "Görüntüle";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // cartLabel
            // 
            this.cartLabel.AutoSize = true;
            this.cartLabel.Location = new System.Drawing.Point(497, 99); // cartListBox'ın üstüne ve sağ üst köşesine yerleştir
            this.cartLabel.Name = "cartLabel";
            this.cartLabel.Size = new System.Drawing.Size(72, 15);
            this.cartLabel.TabIndex = 14;
            this.cartLabel.Text = "Sepetiniz :";
            // 
            // cartListBox
            // 
            this.cartListBox.FormattingEnabled = true;
            this.cartListBox.ItemHeight = 15;
            this.cartListBox.Location = new System.Drawing.Point(12, 128);
            this.cartListBox.Name = "cartListBox";
            this.cartListBox.Size = new System.Drawing.Size(560, 184);
            this.cartListBox.TabIndex = 8;
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalPriceLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalPriceLabel.ForeColor = System.Drawing.Color.Black;
            this.totalPriceLabel.Location = new System.Drawing.Point(12, 325);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(85, 19);
            this.totalPriceLabel.TabIndex = 9;
            this.totalPriceLabel.Text = "Toplam Fiyat:";
            // 
            // totalPriceValueLabel
            // 
            this.totalPriceValueLabel.AutoSize = true;
            this.totalPriceValueLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalPriceValueLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalPriceValueLabel.ForeColor = System.Drawing.Color.Black;
            this.totalPriceValueLabel.Location = new System.Drawing.Point(103, 325);
            this.totalPriceValueLabel.Name = "totalPriceValueLabel";
            this.totalPriceValueLabel.Size = new System.Drawing.Size(17, 19);
            this.totalPriceValueLabel.TabIndex = 10;
            this.totalPriceValueLabel.Text = "0";
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(497, 325);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 11;
            this.confirmButton.Text = "Onayla";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // adminButton
            // 
            this.adminButton.Location = new System.Drawing.Point(497, 12);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(75, 23);
            this.adminButton.TabIndex = 12;
            this.adminButton.Text = "Admin";
            this.adminButton.UseVisualStyleBackColor = true;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(100, 99);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 12;
            this.removeButton.Text = "Sil";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.cartLabel);
            this.Controls.Add(this.cartListBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.backgroundPanel);
            this.Icon = new System.Drawing.Icon("Resources/icon.ico");
            this.MaximizeBox = false; // Tam ekran özelliğini kapat
            this.Name = "MainForm";
            this.Text = "Kayak Kiralama";
            this.backgroundPanel.ResumeLayout(false);
            this.backgroundPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel backgroundPanel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label shoeSizeLabel;
        private System.Windows.Forms.Label rentalTimeLabel;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.TextBox shoeSizeTextBox;
        private System.Windows.Forms.TextBox rentalTimeTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.ListBox cartListBox;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Label totalPriceValueLabel;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button adminButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label cartLabel;
    }
}