using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KayakRental
{
    public partial class MainForm : Form
    {
        private List<Rental> rentals = new List<Rental>();
        private List<Rental> cart = new List<Rental>();
        private Dictionary<int, int> stock = new Dictionary<int, int>
        {
            { 36, 10 },
            { 37, 10 },
            { 38, 10 },
            { 39, 10 },
            { 40, 10 },
            { 41, 10 },
            { 42, 10 },
            { 43, 10 },
            { 44, 10 },
            { 45, 10 }
        };
        private Dictionary<int, decimal> prices = new Dictionary<int, decimal>(); // Buraya ekleyin

        public MainForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var gender = genderComboBox.SelectedItem.ToString();
            var shoeSize = int.Parse(shoeSizeTextBox.Text);
            var rentalTime = int.Parse(rentalTimeTextBox.Text);

            if (rentalTime > 21)
            {
                MessageBox.Show("Kiralama süresi maksimum 21 saat olabilir.");
                return;
            }

            if (stock.ContainsKey(shoeSize) && stock[shoeSize] > 0)
            {
                var rental = new Rental
                {
                    Gender = gender,
                    ShoeSize = shoeSize,
                    RentalTime = DateTime.Now,
                    RentalDuration = rentalTime,
                    Price = prices.ContainsKey(shoeSize) ? prices[shoeSize] * rentalTime : CalculatePrice(rentalTime)
                };

                cart.Add(rental);
                stock[shoeSize]--;
                UpdateCart();
            }
            else
            {
                MessageBox.Show("Stokta yeterli ayakkabı yok.");
            }
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            var viewRentalsForm = new ViewRentalsForm(rentals);
            viewRentalsForm.Show();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            rentals.AddRange(cart);
            cart.Clear();
            UpdateCart();
            MessageBox.Show("Ürünler başarıyla kaydedildi.");
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (cartListBox.SelectedIndex != -1)
            {
                var selectedRental = cart[cartListBox.SelectedIndex];
                cart.RemoveAt(cartListBox.SelectedIndex);
                stock[selectedRental.ShoeSize]++;
                UpdateCart();
            }
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            var password = Microsoft.VisualBasic.Interaction.InputBox("Şifreyi girin:", "Admin Girişi", "", -1, -1);
            if (password == "1121")
            {
                var adminForm = new AdminForm(stock, prices);
                adminForm.Show();
            }
            else
            {
                MessageBox.Show("Yanlış şifre!");
            }
        }

        private decimal CalculatePrice(int rentalTime)
        {
            return rentalTime * 10; // Örnek fiyatlandırma: saat başı 10 birim
        }

        private void UpdateCart()
        {
            cartListBox.Items.Clear();
            decimal totalPrice = 0;
            foreach (var rental in cart)
            {
                cartListBox.Items.Add($"Cinsiyet: {rental.Gender}, Ayakkabı Numarası: {rental.ShoeSize},  Fiyat: {rental.Price:C}");
                totalPrice += rental.Price;
            }
            totalPriceValueLabel.Text = totalPrice.ToString("C");
        }
    }
}