namespace YeniProje;

public partial class Odev13_EhliyetBasvuru : Form
{
    public Odev13_EhliyetBasvuru()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        int yas = Convert.ToInt32(textBox1.Text);
        if (yas > 17) {
            MessageBox.Show("ehliyet sinavina girebilirsiniz");
    }
}

}
