namespace YeniProje;

public partial class Odev19_AkilliEvSistemi : Form
{
    public Odev19_AkilliEvSistemi()
    {
        InitializeComponent();
    }

    private void groupBox2_Enter(object sender, EventArgs e)
    {

    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        // 1. Önce eski listeyi temizliyoruz
        listBox1.Items.Clear();

        // 2. Lamba kontrolü
        if (checkBox1.Checked == true)
        {
            listBox1.Items.Add("Lambalar Acik.");
        }
        else
        {
            listBox1.Items.Add("Lambalar Kapali.");
        }

        // 3. Kombi kontrolü
        if (checkBox2.Checked == true)
        {
            listBox1.Items.Add("Kombi Acik.");
        }
        else
        {
            listBox1.Items.Add("Kombi Kapali.");
        }
    }
}
