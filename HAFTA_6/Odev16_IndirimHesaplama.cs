namespace YeniProje;

public partial class Odev16_IndirimHesaplama : Form
{
    public Odev16_IndirimHesaplama()
    {
        InitializeComponent();
    }

    private void btnIndirim10_Click(object sender, EventArgs e)
    {
        try
        {
            double fiyat = Convert.ToDouble(txtFiyat.Text);
            double indirimMiktari = (fiyat * 10) / 100;
            double sonuc = fiyat - indirimMiktari;
            lblSonuc.Text = "Indirimli Fiyat: " + sonuc.ToString();
        }
        catch (Exception)
        {
            MessageBox.Show("Hatali giris!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnIndirim25_Click(object sender, EventArgs e)
    {
        try
        {
            double fiyat = Convert.ToDouble(txtFiyat.Text);
            double indirimMiktari = (fiyat * 25) / 100;
            double sonuc = fiyat - indirimMiktari;
            lblSonuc.Text = "Indirimli Fiyat: " + sonuc.ToString();
        }
        catch (Exception)
        {
            MessageBox.Show("Hatali giris!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnIndirim50_Click(object sender, EventArgs e)
    {
        try
        {
            double fiyat = Convert.ToDouble(txtFiyat.Text);
            double indirimMiktari = (fiyat * 50) / 100;
            double sonuc = fiyat - indirimMiktari;
            lblSonuc.Text = "Indirimli Fiyat: " + sonuc.ToString();
        }
        catch (Exception)
        {
            MessageBox.Show("Hatali giris!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnIndirim75_Click(object sender, EventArgs e)
    {
        try
        {
            double fiyat = Convert.ToDouble(txtFiyat.Text);
            double indirimMiktari = (fiyat * 75) / 100;
            double sonuc = fiyat - indirimMiktari;
            lblSonuc.Text = "Indirimli Fiyat: " + sonuc.ToString();
        }
        catch (Exception)
        {
            MessageBox.Show("Hatali giris!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
