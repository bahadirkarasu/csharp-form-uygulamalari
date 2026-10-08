using System;
using System.Windows.Forms;

namespace YeniProje
{
    public partial class Odev29_DoWhileFarki : Form
    {
        public Odev29_DoWhileFarki()
        {
            InitializeComponent();
        }

        private void btnKarsilastir_Click(object sender, EventArgs e)
        {
            lstWhile.Items.Clear();
            lstDoWhile.Items.Clear();

            // 1. Durum: Normal 1'den 10'a kadar listeleme
            int w = 1;
            while (w <= 10)
            {
                lstWhile.Items.Add(w);
                w++;
            }

            int dw = 1;
            do
            {
                lstDoWhile.Items.Add(dw);
                dw++;
            } while (dw <= 10);

            lblFark.Text = "AÇIKLAMA: Normal şartlarda her iki döngü de 1-10 arası sayıları aynı şekilde ekler.\r\n" +
                           "FARK: Eğer başlangıç değerini 11 (koşul dışı) yapsaydık; 'While' döngüsü koşul uymadığı için HİÇ çalışmayacak, " +
                           "'Do-While' ise koşula bakılmaksızın en az 1 kez çalışıp 11 değerini ekleyecekti.";
        }
    }
}