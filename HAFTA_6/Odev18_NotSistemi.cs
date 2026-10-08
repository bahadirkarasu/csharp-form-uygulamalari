namespace YeniProje;

public partial class Odev18_NotSistemi : Form
{
    public Odev18_NotSistemi()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        try
        {
            // 1. Kutudaki yazıyı tam sayıya çeviriyoruz
            int not = Convert.ToInt32(textBox1.Text);

            // 2. İç içe if yapısı ile not sınıflandırması
            if (not >= 0 && not <= 100)
            {
                if (not >= 85) // 85 ve üzeri
                {
                    MessageBox.Show("Notunuz: Takdir", "Not Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (not >= 70) // 70 - 84 arası
                {
                    MessageBox.Show("Notunuz: Teşekkür", "Not Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (not < 50) // 50 altı
                {
                    MessageBox.Show("Notunuz: Başarısız", "Not Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else // 50 - 69 arası
                {
                    MessageBox.Show("Notunuz: Geçti", "Not Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Lütfen 0-100 arasında geçerli bir not giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lütfen sadece tam sayı giriniz! Hata: " + ex.Message, "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
