namespace YeniProje;

public partial class Odev6_FareOlaylari : Form
{
    public Odev6_FareOlaylari()
    {
        InitializeComponent();
    }

    private void button1_MouseEnter(object sender, EventArgs e)
    {
        MessageBox.Show("Mouse benim üzerimdedir.");
    }

    private void button2_DoubleClick(object sender, EventArgs e)
    {
        MessageBox.Show("Mouse iki kere tıklandı.");
    }

    private void button3_MouseLeave(object sender, EventArgs e)
    {
        MessageBox.Show("Mouse üzerinde değil.");
    }
}
