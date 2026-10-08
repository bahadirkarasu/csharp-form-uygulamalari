namespace YeniProje;

public partial class Odev10_DortIslem : Form
{
    public Odev10_DortIslem()
    {
        InitializeComponent();
    }

    private void btnTopla_Click(object sender, EventArgs e)
    {
        try
        {
            double sayi1 = Convert.ToDouble(txtSayi1.Text);
            double sayi2 = Convert.ToDouble(txtSayi2.Text);
            double sonuc = sayi1 + sayi2;
            lblSonuc.Text = "Sonuç: " + sonuc;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lütfen geçerli sayılar giriniz! Hata: " + ex.Message);
        }
    }

    private void btnCikar_Click(object sender, EventArgs e)
    {
        try
        {
            double sayi1 = Convert.ToDouble(txtSayi1.Text);
            double sayi2 = Convert.ToDouble(txtSayi2.Text);
            double sonuc = sayi1 - sayi2;
            lblSonuc.Text = "Sonuç: " + sonuc;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lütfen geçerli sayılar giriniz! Hata: " + ex.Message);
        }
    }

    private void btnCarp_Click(object sender, EventArgs e)
    {
        try
        {
            double sayi1 = Convert.ToDouble(txtSayi1.Text);
            double sayi2 = Convert.ToDouble(txtSayi2.Text);
            double sonuc = sayi1 * sayi2;
            lblSonuc.Text = "Sonuç: " + sonuc;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lütfen geçerli sayılar giriniz! Hata: " + ex.Message);
        }
    }

    private void btnBol_Click(object sender, EventArgs e)
    {
        try
        {
            double sayi1 = Convert.ToDouble(txtSayi1.Text);
            double sayi2 = Convert.ToDouble(txtSayi2.Text);
            
            if (sayi2 == 0)
            {
                MessageBox.Show("Bir sayı 0'a bölünemez!");
                return;
            }

            double sonuc = sayi1 / sayi2;
            lblSonuc.Text = "Sonuç: " + sonuc;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lütfen geçerli sayılar giriniz! Hata: " + ex.Message);
        }
    }
}
