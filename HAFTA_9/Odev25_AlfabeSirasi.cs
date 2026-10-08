namespace YeniProje;

public partial class Odev25_AlfabeSirasi : Form
{
    public Odev25_AlfabeSirasi()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        // 1. Seçilen harfi alıyoruz
        string secilenHarf = comboBox1.Text.ToUpper();

        if (string.IsNullOrEmpty(secilenHarf))
        {
            MessageBox.Show("Lütfen bir harf seçiniz!");
            return;
        }

        // 2. Alfabe sırasını bulalım (Switch-Case ile)
        int sira = 0;
        switch (secilenHarf)
        {
            case "A": sira = 1; break;
            case "B": sira = 2; break;
            case "C": sira = 3; break;
            case "Ç": sira = 4; break;
            case "D": sira = 5; break;
            case "E": sira = 6; break;
            case "F": sira = 7; break;
            case "G": sira = 8; break;
            case "Ğ": sira = 9; break;
            case "H": sira = 10; break;
            case "I": sira = 11; break;
            case "İ": sira = 12; break;
            case "J": sira = 13; break;
            case "K": sira = 14; break;
            case "L": sira = 15; break;
            case "M": sira = 16; break;
            case "N": sira = 17; break;
            case "O": sira = 18; break;
            case "Ö": sira = 19; break;
            case "P": sira = 20; break;
            case "R": sira = 21; break;
            case "S": sira = 22; break;
            case "Ş": sira = 23; break;
            case "T": sira = 24; break;
            case "U": sira = 25; break;
            case "Ü": sira = 26; break;
            case "V": sira = 27; break;
            case "Y": sira = 28; break;
            case "Z": sira = 29; break;
        }

        label2.Text = $"{secilenHarf} harfi, alfabenin {sira}. harfidir.";

        // 3. Sesli mi sessiz mi? (Gruplama yaparak bulalım)
        switch (secilenHarf)
        {
            case "A": case "E": case "I": case "İ": 
            case "O": case "Ö": case "U": case "Ü":
                label3.Text = "Durum: Sesli Harf";
                break;
            default:
                label3.Text = "Durum: Sessiz Harf";
                break;
        }
    }
}
