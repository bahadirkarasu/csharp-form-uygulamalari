using System;
using System.Windows.Forms;

namespace YeniProje
{
    public partial class Odev23_AralikToplami : Form
    {
        public Odev23_AralikToplami()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                int bas = Convert.ToInt32(txtBas.Text);
                int bit = Convert.ToInt32(txtBit.Text);
                
                if (bas > bit)
                {
                    // Swap
                    int temp = bas;
                    bas = bit;
                    bit = temp;
                }

                int toplam = 0;
                for (int i = bas; i <= bit; i++)
                {
                    toplam += i;
                }

                lblSonuc.Text = $"Sonuç: {bas} ile {bit} arasındaki sayıların toplamı = {toplam}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen geçerli tam sayılar giriniz! Hata: " + ex.Message, "Giriş Hatası");
            }
        }
    }
}