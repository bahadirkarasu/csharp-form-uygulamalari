namespace YeniProje
{
    partial class Odev23_AralikToplami
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
            this.lblBas = new System.Windows.Forms.Label();
            this.lblBit = new System.Windows.Forms.Label();
            this.txtBas = new System.Windows.Forms.TextBox();
            this.txtBit = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBas
            // 
            this.lblBas.AutoSize = true;
            this.lblBas.Location = new System.Drawing.Point(20, 23);
            this.lblBas.Name = "lblBas";
            this.lblBas.Size = new System.Drawing.Size(116, 20);
            this.lblBas.TabIndex = 0;
            this.lblBas.Text = "Başlangıç Değeri:";
            // 
            // lblBit
            // 
            this.lblBit.AutoSize = true;
            this.lblBit.Location = new System.Drawing.Point(20, 73);
            this.lblBit.Name = "lblBit";
            this.lblBit.Size = new System.Drawing.Size(81, 20);
            this.lblBit.TabIndex = 1;
            this.lblBit.Text = "Bitiş Değeri:";
            // 
            // txtBas
            // 
            this.txtBas.Location = new System.Drawing.Point(150, 20);
            this.txtBas.Name = "txtBas";
            this.txtBas.Size = new System.Drawing.Size(120, 27);
            this.txtBas.TabIndex = 2;
            // 
            // txtBit
            // 
            this.txtBit.Location = new System.Drawing.Point(150, 70);
            this.txtBit.Name = "txtBit";
            this.txtBit.Size = new System.Drawing.Size(120, 27);
            this.txtBit.TabIndex = 3;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(20, 120);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(250, 40);
            this.btnHesapla.TabIndex = 4;
            this.btnHesapla.Text = "Toplamı Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSonuc.Location = new System.Drawing.Point(20, 180);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(340, 60);
            this.lblSonuc.TabIndex = 5;
            this.lblSonuc.Text = "Sonuç: ";
            // 
            // Odev23_AralikToplami
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 250);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtBit);
            this.Controls.Add(this.txtBas);
            this.Controls.Add(this.lblBit);
            this.Controls.Add(this.lblBas);
            this.Name = "Odev23_AralikToplami";
            this.Text = "Ödev 23 - Aralık Toplamı";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblBas;
        private System.Windows.Forms.Label lblBit;
        private System.Windows.Forms.TextBox txtBas;
        private System.Windows.Forms.TextBox txtBit;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblSonuc;
    }
}