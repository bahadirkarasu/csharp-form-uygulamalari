namespace YeniProje;

public partial class Odev3_GorunurlukKontrolu : Form
{
    public Odev3_GorunurlukKontrolu()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        pictureBox1.Visible = false; 
    }

    private void button2_Click(object sender, EventArgs e)
    {
        pictureBox1.Visible = true;
    }
}

