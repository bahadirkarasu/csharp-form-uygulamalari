using System.Windows.Forms;

namespace YeniProje;

public partial class Odev8_ManavSepeti : Form
{
    public Odev8_ManavSepeti()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        listBox1.Items.Add(textBox2.Text);
    }

    private void button2_Click(object sender, EventArgs e)
    {
        listBox1.Items.Clear();
    }
}
