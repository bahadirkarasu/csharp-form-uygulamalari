using System;
using System.Windows.Forms;

namespace YeniProje
{
    public partial class Odev28_GelismisDongu : Form
    {
        public Odev28_GelismisDongu()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            int sayac = 0;
            int eklenecek = 1;

            // Toplam 1000'i geçene kadar döngü çalışır
            while (toplam <= 1000)
            {
                toplam += eklenecek;
                eklenecek++;
                sayac++;
            }

            lblSonuc.Text = $"Döngü Toplam Çalışma Sayısı: {sayac} kez\r\n" +
                            $"Döngü Sonunda Elde Edilen Toplam: {toplam}\r\n" +
                            $"Döngüden Çıkarken Eklenen En Son Sayı: {eklenecek - 1}";
        }
    }
}