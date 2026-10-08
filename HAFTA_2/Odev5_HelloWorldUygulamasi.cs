namespace YeniProje;

public partial class Odev5_HelloWorldUygulamasi : Form
{
    public Odev5_HelloWorldUygulamasi()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        textBox1.Text = "Hello World";
    }
}
