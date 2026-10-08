using System;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            // XAMPP bağlantısını başlangıçta test edelim
            if (DatabaseHelper.TestConnection())
            {
                Application.Run(new frmAnaSayfa());
            }
        }
    }
}