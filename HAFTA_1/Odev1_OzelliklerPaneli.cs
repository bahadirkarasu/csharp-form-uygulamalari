using System;
using System.Drawing;
using System.Windows.Forms;

namespace YeniProje
{
    public partial class Odev1_OzelliklerPaneli : Form
    {
        public Odev1_OzelliklerPaneli()
        {
            InitializeComponent();
        }

        private void Odev1_OzelliklerPaneli_Load(object sender, EventArgs e)
        {
            txtRapor.Text = "=== NESNELERİN ORTAK ÖZELLİKLERİ ===\r\n" +
                            "- Name: Her nesnenin kod tarafından erişilen benzersiz adıdır. (Örn: button1)\r\n" +
                            "- Text: Nesnenin üzerinde veya yanında görünen metindir.\r\n" +
                            "- BackColor: Nesnenin arka plan rengidir.\r\n" +
                            "- Enabled: Nesnenin aktif/pasif olma durumunu belirler.\r\n" +
                            "- Visible: Nesnenin görünüp görünmeyeceğini belirler.\r\n\r\n" +
                            "=== NESNELERİN FARKLI ÖZELLİKLERİ ===\r\n" +
                            "- Button: Click olayı tetikleyici bir kontroldür. Arka plan resmi alabilir.\r\n" +
                            "- CheckBox: Checked (seçili mi?) özelliğine sahiptir, true veya false değer alır.\r\n" +
                            "- Label: Genellikle bilgi vermek amacıyla kullanılan metin etiketidir. Otomatik boyutlandırma (AutoSize) özelliğine sahiptir.\r\n" +
                            "- PictureBox: Image (Resim) ve SizeMode (Resim yerleşim biçimi) özelliklerine sahiptir. Resim gösterimi için kullanılır.";
        }

        private void txtRapor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}