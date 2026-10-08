namespace YeniProje;

public partial class Odev20_GunBulma : Form
{
    public Odev20_GunBulma()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        // 1. Bilgisayarın tarihinden haftanın kaçıncı gününde olduğumuzu alalım
        // C#'ta Pazar=0, Pazartesi=1... Cumartesi=6'dır.
        int gun = (int)DateTime.Now.DayOfWeek;

        // 2. Switch-Case ile ismini bulalım (Pazar'dan başlıyor dikkat!)
        switch (gun)
        {
            case 1: MessageBox.Show("Bugün: Pazartesi"); break;
            case 2: MessageBox.Show("Bugün: Salı"); break;
            case 3: MessageBox.Show("Bugün: Çarşamba"); break;
            case 4: MessageBox.Show("Bugün: Perşembe"); break;
            case 5: MessageBox.Show("Bugün: Cuma"); break;
            case 6: MessageBox.Show("Bugün: Cumartesi"); break;
            case 0: MessageBox.Show("Bugün: Pazar"); break;
            default: MessageBox.Show("Hata!"); break;
        }
    }
}
