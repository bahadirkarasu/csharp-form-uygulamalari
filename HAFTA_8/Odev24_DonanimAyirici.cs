using System;
using System.Windows.Forms;

namespace YeniProje
{
    public partial class Odev24_DonanimAyirici : Form
    {
        public Odev24_DonanimAyirici()
        {
            InitializeComponent();
        }

        private void Odev24_DonanimAyirici_Load(object sender, EventArgs e)
        {
            string[] donanimlar = { "RAM", "Klavye", "Anakart", "Mouse", "Ekran Kartı", "Monitör", "Sabit Disk", "Yazıcı", "İşlemci", "Hoparlör" };
            lstKarisik.Items.AddRange(donanimlar);
        }

        private void btnAyir_Click(object sender, EventArgs e)
        {
            lstIc.Items.Clear();
            lstDis.Items.Clear();

            foreach (var item in lstKarisik.Items)
            {
                string parca = item?.ToString() ?? "";
                
                // İç ve dış donanım sınıflandırması
                if (parca == "RAM" || parca == "Anakart" || parca == "Ekran Kartı" || parca == "Sabit Disk" || parca == "İşlemci")
                {
                    lstIc.Items.Add(parca);
                }
                else
                {
                    lstDis.Items.Add(parca);
                }
            }
        }
    }
}