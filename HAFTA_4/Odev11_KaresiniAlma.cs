namespace YeniProje;

public partial class Odev11_KaresiniAlma : Form
{
    public Odev11_KaresiniAlma()
    {
        InitializeComponent();
    }

    private void btnHesapla_Click(object sender, EventArgs e)
    {
        try
        {
            // TextBox'tan girilen veri alınıyor
            double sayi = Convert.ToDouble(txtSayi.Text);
            
            // Sayının karesi alınıyor
            double kare = sayi * sayi;
            
            // Sonuç mesaj olarak gösteriliyor
            MessageBox.Show("Girdiğiniz sayının karesi: " + kare, "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lütfen geçerli bir sayı giriniz! Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
