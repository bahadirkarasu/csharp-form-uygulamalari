namespace YeniProje;

public partial class Odev12_DaireAlaniVeCevresi : Form
{
    public Odev12_DaireAlaniVeCevresi()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        try
        {
            double r = Convert.ToDouble(textBox1.Text);
            double pi = 3.14;
            
            double alan = pi * r * r;
            double cevre = 2 * pi * r;
            
            label2.Text = "Çıkan Alan Sonucu: " + alan + "\n" +
                          "Çıkan Çevre Sonucu: " + cevre;
            
        }
        catch (Exception)
        {
             MessageBox.Show("Rakam dışında bir şey girdiniz! r = SADECE SAYI olmalı");
        }
    }
}
