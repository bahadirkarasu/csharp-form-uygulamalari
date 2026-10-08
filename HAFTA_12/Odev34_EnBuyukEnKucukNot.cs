using System;
using System.Linq;
using System.Windows.Forms;

namespace YeniProje
{
    public partial class Odev34_EnBuyukEnKucukNot : Form
    {
        private int[] notlar = { 65, 85, 45, 95, 30, 70, 100, 88, 52 };

        public Odev34_EnBuyukEnKucukNot()
        {
            InitializeComponent();
        }

        private void Odev34_EnBuyukEnKucukNot_Load(object sender, EventArgs e)
        {
            lblNotlar.Text = "Sınıf Not Listesi: " + string.Join(", ", notlar);
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            // LINQ metotları (Max, Min, Average)
            int enYuksek = notlar.Max();
            int enDusuk = notlar.Min();
            double ortalama = notlar.Average();

            lblSonuc.Text = $"=== İSTATİSTİKSEL NOT RAPORU ===\r\n" +
                            $"- En Yüksek Not (Max): {enYuksek}\r\n" +
                            $"- En Düşük Not (Min): {enDusuk}\r\n" +
                            $"- Sınıf Ortalaması (Average): {ortalama:F2}";
        }
    }
}