using System;
using System.Windows.Forms;

namespace YeniProje
{
    public partial class Odev32_DiziListeleme : Form
    {
        private string[] isimler = { "Hasan", "Balcı", "Visual", "Studio", "C# WinForms" };

        public Odev32_DiziListeleme()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            
            // Dizi elemanları for döngüsü ile ListBox'a aktarılıyor
            for (int i = 0; i < isimler.Length; i++)
            {
                listBox1.Items.Add($"Index [{i}] => {isimler[i]}");
            }
        }
    }
}