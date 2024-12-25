using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KayakRental
{
    public partial class AdminForm : Form
    {
        private Dictionary<int, int> stock;
        private Dictionary<int, decimal> prices;

        public AdminForm(Dictionary<int, int> stock, Dictionary<int, decimal> prices)
        {
            InitializeComponent();
            this.stock = stock;
            this.prices = prices;
            UpdateStockList();
        }

        private void UpdateStockList()
        {
            stockListBox.Items.Clear();
            foreach (var item in stock)
            {
                stockListBox.Items.Add($"Ayakkabı Numarası: {item.Key}, Stok: {item.Value}");
            }
        }

        private void addStockButton_Click(object sender, EventArgs e)
        {
            var shoeSize = int.Parse(shoeSizeTextBox.Text);
            var quantity = int.Parse(quantityTextBox.Text);

            if (stock.ContainsKey(shoeSize))
            {
                stock[shoeSize] += quantity;
            }
            else
            {
                stock[shoeSize] = quantity;
            }

            UpdateStockList();
        }

        private void setPriceButton_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(priceTextBox.Text, out decimal price))
            {
                foreach (var shoeSize in stock.Keys)
                {
                    if (prices.ContainsKey(shoeSize))
                    {
                        prices[shoeSize] = price;
                    }
                    else
                    {
                        prices.Add(shoeSize, price);
                    }
                }

                MessageBox.Show($"Tüm ayakkabı numaraları için fiyat {price:C} olarak ayarlandı.");
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir fiyat girin.");
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            UpdateStockList();
        }
    }
}