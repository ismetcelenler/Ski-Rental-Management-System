using System;
using System.Windows.Forms;

namespace KayakRental
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                Console.WriteLine("Uygulama başlatılıyor...");
                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                // Ana formu başlat
                Application.Run(new MainForm());
                Console.WriteLine("Uygulama kapatıldı.");
            }
            catch (Exception ex)
            {
                // Hata olursa göster
                MessageBox.Show("Bir hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Hata: " + ex.ToString());
            }
        }
    }
}
