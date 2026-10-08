namespace YeniProje
{
    partial class Odev34_EnBuyukEnKucukNot
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
            this.lblNotlar = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNotlar
            // 
            this.lblNotlar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNotlar.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNotlar.Location = new System.Drawing.Point(20, 20);
            this.lblNotlar.Name = "lblNotlar";
            this.lblNotlar.Size = new System.Drawing.Size(340, 50);
            this.lblNotlar.TabIndex = 0;
            this.lblNotlar.Text = "Sınıf Not Listesi: ";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(20, 90);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(340, 40);
            this.btnHesapla.TabIndex = 1;
            this.btnHesapla.Text = "Notları İncele (Max/Min/Average)";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSonuc.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblSonuc.Location = new System.Drawing.Point(20, 150);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(340, 100);
            this.lblSonuc.TabIndex = 2;
            this.lblSonuc.Text = "Sonuçlar: ";
            // 
            // Odev34_EnBuyukEnKucukNot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 270);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lblNotlar);
            this.Name = "Odev34_EnBuyukEnKucukNot";
            this.Text = "Ödev 34 - Not İstatistikleri";
            this.Load += new System.EventHandler(this.Odev34_EnBuyukEnKucukNot_Load);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblNotlar;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblSonuc;
    }
}