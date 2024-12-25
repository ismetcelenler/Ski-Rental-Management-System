using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KayakRental
{
    public partial class ViewRentalsForm : Form
    {
        private List<Rental> rentals;

        public ViewRentalsForm(List<Rental> rentals)
        {
            InitializeComponent();
            this.rentals = rentals;
            UpdateRentalsList();
            timer.Start();
        }

        private void UpdateRentalsList()
        {
            rentalsListBox.Items.Clear();
            foreach (var rental in rentals)
            {
                var remainingTime = rental.RentalTime.AddHours(rental.RentalDuration) - DateTime.Now;
                if (remainingTime.TotalSeconds < 0)
                {
                    remainingTime = TimeSpan.Zero;
                }
                var hours = remainingTime.Hours;
                var minutes = remainingTime.Minutes;
                var seconds = remainingTime.Seconds;
                rentalsListBox.Items.Add($"Cinsiyet: {rental.Gender}, Ayakkabı Numarası: {rental.ShoeSize}, Kiralandığı Tarih: {rental.RentalTime:dd.MM.yyyy HH:mm}, Kalan Süre: {hours} saat {minutes} dakika {seconds} saniye, Fiyat: {rental.Price:C}");
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            UpdateRentalsList();
        }
    }
}