namespace YeniProje
{
    partial class Odev28_GelismisDongu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(20, 80);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(340, 45);
            this.btnHesapla.TabIndex = 0;
            this.btnHesapla.Text = "While Döngüsünü Çalıştır";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSonuc.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblSonuc.Location = new System.Drawing.Point(20, 140);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(340, 100);
            this.lblSonuc.TabIndex = 1;
            this.lblSonuc.Text = "Sonuç: ";
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(20, 15);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(340, 60);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "Görev: 0'dan başlayarak sayıları toplayan ve toplam 1000'i geçtiğinde döngünün kaç kez çalıştığını bulan While programı.";
            // 
            // Odev28_GelismisDongu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 260);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnHesapla);
            this.Name = "Odev28_GelismisDongu";
            this.Text = "Ödev 28 - Gelişmiş Döngü";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Label lblInfo;
    }
}