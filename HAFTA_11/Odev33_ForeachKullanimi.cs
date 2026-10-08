using System;
using System.Windows.Forms;

namespace YeniProje
{
    public partial class Odev33_ForeachKullanimi : Form
    {
        private int[] sayilar = { 15, 34, 56, 78, 92, 105, 230 };

        public Odev33_ForeachKullanimi()
        {
            InitializeComponent();
        }

        private void btnCalistir_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            
            // Foreach döngüsü ile tüm elemanları dönüyoruz
            foreach (int sayi in sayilar)
            {
                listBox1.Items.Add($"Foreach Değeri: {sayi}");
            }

            lblFark.Text = "FOR DÖNGÜSÜNDEN FARKI:\r\n" +
                           "- For döngüsünde dizinin indeksiyle (sayaçla) işlem yapılır. Elemanlara erişirken dizinin boyutu kontrol edilmelidir.\r\n" +
                           "- Foreach döngüsünde ise dizinin indeksine ihtiyaç duyulmaz. Dizi elemanları otomatik olarak sırayla döner. " +
                           "Dizi sınırlarını aşma (IndexOutOfRange) hatasını tamamen engeller ve daha pratik bir okuma sağlar.";
        }
    }
}