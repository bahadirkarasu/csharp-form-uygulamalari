namespace YeniProje;

public partial class Odev27_KasaUygulamasi : Form
{
    public Odev27_KasaUygulamasi()
    {
        InitializeComponent();
    }

    private void btnOdeme_Click(object sender, EventArgs e)
    {
        // 1. Toplam tutarı alalım
        double tutar = Convert.ToDouble(textBox1.Text);
        double sonFiyat = 0;

        // 2. Ödeme şekline göre ek fiyat hesaplayalım

        if (rbTek.Checked)
        {
            // Tek çekimse fiyat değişmez
            sonFiyat = tutar;
        }
        else if (rb2Taksit.Checked || rb3Taksit.Checked)
        {
            // 2 veya 3 taksit ise %5 ekle
            sonFiyat = tutar * 1.05;
        }
        else if (rb4Taksit.Checked || rb5Taksit.Checked)
        {
            // 4 veya 5 taksit ise %10 ekle
            sonFiyat = tutar * 1.10;
        }

        // 3. Sonucu gösterelim
        MessageBox.Show("Toplam Ödenecek Tutar: " + sonFiyat.ToString("C2"));
    }

    private void rbTek_CheckedChanged(object sender, EventArgs e)
    {

    }
}
