namespace KutuphaneOtomasyonu
{
    partial class frmAnaSayfa
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnOgrenci;
        private System.Windows.Forms.Button btnKitapTur;
        private System.Windows.Forms.Button btnKitaplar;
        private System.Windows.Forms.Button btnOdunc;
        private System.Windows.Forms.Label lblBaslik;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnOgrenci = new System.Windows.Forms.Button();
            this.btnKitapTur = new System.Windows.Forms.Button();
            this.btnKitaplar = new System.Windows.Forms.Button();
            this.btnOdunc = new System.Windows.Forms.Button();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBaslik.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblBaslik.Location = new System.Drawing.Point(50, 30);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(434, 45);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Kütüphane Otomasyonu";
            // 
            // btnOgrenci
            // 
            this.btnOgrenci.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnOgrenci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOgrenci.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOgrenci.Location = new System.Drawing.Point(58, 120);
            this.btnOgrenci.Name = "btnOgrenci";
            this.btnOgrenci.Size = new System.Drawing.Size(180, 100);
            this.btnOgrenci.TabIndex = 1;
            this.btnOgrenci.Text = "Öğrenci İşlemleri";
            this.btnOgrenci.UseVisualStyleBackColor = false;
            this.btnOgrenci.Click += new System.EventHandler(this.btnOgrenci_Click);
            // 
            // btnKitapTur
            // 
            this.btnKitapTur.BackColor = System.Drawing.Color.LightGreen;
            this.btnKitapTur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKitapTur.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKitapTur.Location = new System.Drawing.Point(268, 120);
            this.btnKitapTur.Name = "btnKitapTur";
            this.btnKitapTur.Size = new System.Drawing.Size(180, 100);
            this.btnKitapTur.TabIndex = 2;
            this.btnKitapTur.Text = "Kitap Türleri";
            this.btnKitapTur.UseVisualStyleBackColor = false;
            this.btnKitapTur.Click += new System.EventHandler(this.btnKitapTur_Click);
            // 
            // btnKitaplar
            // 
            this.btnKitaplar.BackColor = System.Drawing.Color.LightCoral;
            this.btnKitaplar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKitaplar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKitaplar.Location = new System.Drawing.Point(58, 250);
            this.btnKitaplar.Name = "btnKitaplar";
            this.btnKitaplar.Size = new System.Drawing.Size(180, 100);
            this.btnKitaplar.TabIndex = 3;
            this.btnKitaplar.Text = "Kitap İşlemleri";
            this.btnKitaplar.UseVisualStyleBackColor = false;
            this.btnKitaplar.Click += new System.EventHandler(this.btnKitaplar_Click);
            // 
            // btnOdunc
            // 
            this.btnOdunc.BackColor = System.Drawing.Color.Khaki;
            this.btnOdunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdunc.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOdunc.Location = new System.Drawing.Point(268, 250);
            this.btnOdunc.Name = "btnOdunc";
            this.btnOdunc.Size = new System.Drawing.Size(180, 100);
            this.btnOdunc.TabIndex = 4;
            this.btnOdunc.Text = "Ödünç İşlemleri";
            this.btnOdunc.UseVisualStyleBackColor = false;
            this.btnOdunc.Click += new System.EventHandler(this.btnOdunc_Click);
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(514, 401);
            this.Controls.Add(this.btnOdunc);
            this.Controls.Add(this.btnKitaplar);
            this.Controls.Add(this.btnKitapTur);
            this.Controls.Add(this.btnOgrenci);
            this.Controls.Add(this.lblBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa - Kütüphane Otomasyonu";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
