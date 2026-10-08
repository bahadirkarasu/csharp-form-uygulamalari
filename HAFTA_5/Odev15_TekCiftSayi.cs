namespace YeniProje;

public partial class Odev15_TekCiftSayi : Form
{
    public Odev15_TekCiftSayi()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        int sayi = Convert.ToInt32(textBox1.Text);
        if (sayi % 2 == 0)
        {
            MessageBox.Show("girdiginiz sayi cift");
        }
        else
        {
            MessageBox.Show("girdiginiz sayi tek");
        }
    }
}
