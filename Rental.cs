using System;

namespace KayakRental
{
    public class Rental
    {
        public string Gender { get; set; }
        public int ShoeSize { get; set; }
        public DateTime RentalTime { get; set; }
        public int RentalDuration { get; set; } // Kiralama süresi (saat)
        public decimal Price { get; set; }
    }
}