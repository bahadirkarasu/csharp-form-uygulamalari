using System;
using System.Windows.Forms;

namespace YeniProje
{
    public partial class Odev22_DonguselListe : Form
    {
        public Odev22_DonguselListe()
        {
            InitializeComponent();
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 1; i <= 7; i++)
            {
                listBox1.Items.Add($"{i}. Bilişim Teknolojileri");
            }
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int i = 1;
            while (i <= 10)
            {
                listBox1.Items.Add($"Sayı: {i}");
                i++;
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}