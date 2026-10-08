namespace YeniProje;

public partial class Odev30_TemaAyari : Form
{
    public Odev30_TemaAyari()
    {
        InitializeComponent();
    }

    private void btnUygula_Click(object sender, EventArgs e)
    {
        // 1. Üstteki RadioButton (rbDark) seçiliyse (Checked == true)
        if (rbDark.Checked == true)
        {
            this.BackColor = Color.Black;
        }
        // 2. Alttaki RadioButton (rbLight) seçiliyse
        else if (rbLight.Checked == true)
        {
            this.BackColor = Color.White;
        }
    }
}
