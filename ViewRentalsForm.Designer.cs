namespace KayakRental
{
    partial class ViewRentalsForm
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
            this.rentalsListBox = new System.Windows.Forms.ListBox();
            this.timer = new System.Windows.Forms.Timer();
            this.backgroundPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.BackgroundImage = System.Drawing.Image.FromFile("Resources/background.jpg");
            this.backgroundPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backgroundPanel.Controls.Add(this.rentalsListBox);
            this.backgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Size = new System.Drawing.Size(684, 441);
            this.backgroundPanel.TabIndex = 0;
            // 
            // rentalsListBox
            // 
            this.rentalsListBox.FormattingEnabled = true;
            this.rentalsListBox.ItemHeight = 15;
            this.rentalsListBox.Location = new System.Drawing.Point(12, 12);
            this.rentalsListBox.Name = "rentalsListBox";
            this.rentalsListBox.Size = new System.Drawing.Size(700, 414);
            this.rentalsListBox.TabIndex = 0;
            // 
            // timer
            // 
            this.timer.Interval = 1000; // 1 saniye
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // ViewRentalsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 441);
            this.Controls.Add(this.backgroundPanel);
            this.Icon = new System.Drawing.Icon("Resources/icon.ico");
            this.Name = "ViewRentalsForm";
            this.Text = "Kiralama Görüntüleme";
            this.backgroundPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel backgroundPanel;
        private System.Windows.Forms.ListBox rentalsListBox;
        private System.Windows.Forms.Timer timer;
    }
}