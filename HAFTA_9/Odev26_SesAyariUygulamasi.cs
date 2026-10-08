namespace YeniProje;

public partial class Odev26_SesAyariUygulamasi : Form
{
    public Odev26_SesAyariUygulamasi()
    {
        InitializeComponent();
    }

    private void trackBar1_Scroll(object sender, EventArgs e)
    {
        // 1. TrackBar'ın o anki değerini alalım
        int sesSeviyesi = trackBar1.Value;

        // 2. Şartları kontrol edelim (Aralık olduğu için IF-ELSE en iyisidir!)
        if (sesSeviyesi == 0)
        {
            label1.Text = "Ses Yok";
            label1.ForeColor = Color.Black;
        }
        else if (sesSeviyesi >= 1 && sesSeviyesi <= 10)
        {
            label1.Text = "Normal Ses Seviyesi";
            label1.ForeColor = Color.Green;
        }
        else if (sesSeviyesi >= 11 && sesSeviyesi <= 15)
        {
            label1.Text = "Yüksek Ses Seviyesi";
            label1.ForeColor = Color.Red;
        }
    }
}
