using System;
using System.Windows.Forms;

namespace YeniProje
{
    public partial class Odev2_OlaylarPaneli : Form
    {
        public Odev2_OlaylarPaneli()
        {
            InitializeComponent();
        }

        private void OlayTetiklendi(string kontrol, string olayIsmi)
        {
            txtLog.AppendText($"[{DateTime.Now.ToString("HH:mm:ss")}] {kontrol} -> {olayIsmi} Tetiklendi\r\n");
        }

        private void btnTest_Click(object sender, EventArgs e) => OlayTetiklendi("Button", "Click");
        private void btnTest_MouseEnter(object sender, EventArgs e) => OlayTetiklendi("Button", "MouseEnter");
        private void btnTest_MouseLeave(object sender, EventArgs e) => OlayTetiklendi("Button", "MouseLeave");
        private void btnTest_Enter(object sender, EventArgs e) => OlayTetiklendi("Button", "Enter (Odaklandı)");
        private void btnTest_Leave(object sender, EventArgs e) => OlayTetiklendi("Button", "Leave (Odaktan Çıktı)");

        private void txtTest_TextChanged(object sender, EventArgs e) => OlayTetiklendi("TextBox", "TextChanged");
        private void txtTest_MouseEnter(object sender, EventArgs e) => OlayTetiklendi("TextBox", "MouseEnter");
        private void txtTest_MouseLeave(object sender, EventArgs e) => OlayTetiklendi("TextBox", "MouseLeave");
        private void txtTest_Enter(object sender, EventArgs e) => OlayTetiklendi("TextBox", "Enter (Odaklandı)");
        private void txtTest_Leave(object sender, EventArgs e) => OlayTetiklendi("TextBox", "Leave (Odaktan Çıktı)");
    }
}