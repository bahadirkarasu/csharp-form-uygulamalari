using System;
using System.Drawing;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            new frmOgrenci().ShowDialog();
        }

        private void btnKitapTur_Click(object sender, EventArgs e)
        {
            new frmKitapTur().ShowDialog();
        }

        private void btnKitaplar_Click(object sender, EventArgs e)
        {
            new frmKitaplar().ShowDialog();
        }

        private void btnOdunc_Click(object sender, EventArgs e)
        {
            new frmOdunc().ShowDialog();
        }
    }
}
