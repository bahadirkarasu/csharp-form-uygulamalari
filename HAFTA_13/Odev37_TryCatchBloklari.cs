using System;
using System.Windows.Forms;

namespace YeniProje
{
    public partial class Odev37_TryCatchBloklari : Form
    {
        public Odev37_TryCatchBloklari()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                // Sayıların girilip girilmediği ve tipleri kontrol ediliyor
                int sayi1 = Convert.ToInt32(txtSayi1.Text);
                int sayi2 = Convert.ToInt32(txtSayi2.Text);

                // Bölme işlemi yapılıyor
                int sonuc = sayi1 / sayi2;
                lblSonuc.Text = $"Bölüm Sonucu: {sonuc}";
            }
            catch (FormatException)
            {
                // Sayı yerine harf girildiğinde tetiklenir
                MessageBox.Show("HATA: Lütfen kutucuklara harf veya özel karakter yerine sadece tam sayı giriniz!", 
                                "Giriş Format Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DivideByZeroException)
            {
                // Sıfıra bölme durumunda tetiklenir
                MessageBox.Show("HATA: Bir sayı sıfıra (0) bölünemez! Payda değeri sıfırdan farklı olmalıdır.", 
                                "Sıfıra Bölme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Diğer tüm genel hatalarda tetiklenir
                MessageBox.Show($"Beklenmedik bir hata oluştu: {ex.Message}", 
                                "Genel Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Try-catch blokları tamamlansa da hata oluşsa da her zaman çalışacak kısım
                txtSayi1.Focus();
            }
        }
    }
}