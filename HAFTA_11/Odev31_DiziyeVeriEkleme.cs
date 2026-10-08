using System;
using System.Windows.Forms;

namespace YeniProje
{
    public partial class Odev31_DiziyeVeriEkleme : Form
    {
        private string[] isimler = new string[5];
        private int index = 0;

        public Odev31_DiziyeVeriEkleme()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIsim.Text))
            {
                MessageBox.Show("Lütfen boş bırakmayınız!", "Uyarı");
                return;
            }

            if (index < 5)
            {
                isimler[index] = txtIsim.Text;
                lblDurum.Text = $"{index + 1}. Eleman Eklendi: {isimler[index]}";
                index++;
                txtIsim.Clear();
                txtIsim.Focus();
                
                // Diziyi anlık olarak gösterelim
                GosterDizi();
            }
            else
            {
                MessageBox.Show("Dizi 5 elemanlıdır ve tamamen doldu!", "Dizi Dolu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void GosterDizi()
        {
            lblDizi.Text = "Dizideki Elemanlar:\r\n";
            for (int i = 0; i < 5; i++)
            {
                lblDizi.Text += $"İndeks [{i}]: {(string.IsNullOrEmpty(isimler[i]) ? "[BOÅ]" : isimler[i])}\r\n";
            }
        }

        private void Odev31_DiziyeVeriEkleme_Load(object sender, EventArgs e)
        {
            GosterDizi();
        }
    }
}