namespace YeniProje;

public partial class Odev14_SayiKarsilastirma : Form
{
    public Odev14_SayiKarsilastirma()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        int s1 = Convert.ToInt32(textBox1.Text);
        int s2 = Convert.ToInt32(textBox2.Text);
        if (s1 > s2)
        {
            MessageBox.Show("sayi bir sayi ikiden buyuktur");

        }
        else if (s1 < s2)
        {
            MessageBox.Show("sayi bir sayi ikiden kucuktur");


        }
        else 
        {
            MessageBox.Show("iki sayi birbirine esittir");
            
        }
    }


}
