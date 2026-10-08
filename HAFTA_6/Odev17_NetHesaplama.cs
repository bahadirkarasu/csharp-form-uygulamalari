namespace YeniProje;

public partial class Odev17_NetHesaplama : Form
{
    public Odev17_NetHesaplama()
    {
        InitializeComponent();
    }

    private void btnHesapla_Click(object sender, EventArgs e)
    {
        try
        {
            // --- TÜRKÇE NET HESAPLAMA ---
            // TextBox boş bırakılırsa hata vermesin diye varsayılan olarak "0" kabul edebiliriz
            // ya da kullanıcıya her yeri doldurması için uyarı verdirebiliriz.
            // Burada basit tutmak için direkt Convert ediyoruz:
            double turkceDogru = Convert.ToDouble(txtTurkceDogru.Text);
            double turkceYanlis = Convert.ToDouble(txtTurkceYanlis.Text);
            
            // 4 yanlış 1 doğruyu götürür kuralı: Yanlış sayısının 4'te biri doğrulardan çıkarılır
            double turkceNet = turkceDogru - (turkceYanlis / 4);
            txtTurkceNet.Text = turkceNet.ToString();

            // --- MATEMATİK NET HESAPLAMA ---
            double matDogru = Convert.ToDouble(txtMatDogru.Text);
            double matYanlis = Convert.ToDouble(txtMatYanlis.Text);
            
            double matNet = matDogru - (matYanlis / 4);
            txtMatNet.Text = matNet.ToString();
        }
        catch (Exception)
        {
            MessageBox.Show("Lütfen boş kutu bırakmayın ve sadece RAKAM girin!", "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
