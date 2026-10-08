namespace YeniProje
{
    partial class Odev31_DiziyeVeriEkleme
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
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblIsim = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.lblDizi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(20, 45);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(150, 27);
            this.txtIsim.TabIndex = 0;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(20, 85);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(150, 35);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Diziye Kaydet";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblIsim
            // 
            this.lblIsim.AutoSize = true;
            this.lblIsim.Location = new System.Drawing.Point(20, 20);
            this.lblIsim.Name = "lblIsim";
            this.lblIsim.Size = new System.Drawing.Size(84, 20);
            this.lblIsim.TabIndex = 2;
            this.lblIsim.Text = "İsim Giriniz:";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDurum.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDurum.Location = new System.Drawing.Point(20, 135);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(149, 20);
            this.lblDurum.TabIndex = 3;
            this.lblDurum.Text = "Durum: Veri Bekleniyor";
            // 
            // lblDizi
            // 
            this.lblDizi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDizi.Location = new System.Drawing.Point(190, 20);
            this.lblDizi.Name = "lblDizi";
            this.lblDizi.Size = new System.Drawing.Size(260, 200);
            this.lblDizi.TabIndex = 4;
            this.lblDizi.Text = "Dizideki Elemanlar:\r\n";
            // 
            // Odev31_DiziyeVeriEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 240);
            this.Controls.Add(this.lblDizi);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.lblIsim);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtIsim);
            this.Name = "Odev31_DiziyeVeriEkleme";
            this.Text = "Ödev 31 - Diziye Veri Ekleme";
            this.Load += new System.EventHandler(this.Odev31_DiziyeVeriEkleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblIsim;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label lblDizi;
    }
}