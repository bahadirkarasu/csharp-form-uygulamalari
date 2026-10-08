namespace YeniProje;

public partial class Odev21_EgitimKademesi : Form
{
    public Odev21_EgitimKademesi()
    {
        InitializeComponent();
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        // 1. Seçilen sınıfı alalım
        string secim = comboBox1.Text;

        // 2. Switch-Case Gruplama (Hocanın en sevdiği yöntem!)
        switch (secim)
        {
            case "1":
            case "2":
            case "3":
            case "4":
                MessageBox.Show("İlkokul Kademesindesiniz.");
                break;

            case "5":
            case "6":
            case "7":
            case "8":
                MessageBox.Show("Ortaokul Kademesindesiniz.");
                break;

            case "9":
            case "10":
            case "11":
            case "12":
                MessageBox.Show("Lise Kademesindesiniz.");
                break;

            default:
                MessageBox.Show("Hatalı Sınıf Seçimi!");
                break;
        }
    }
}
