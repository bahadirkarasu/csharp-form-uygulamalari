namespace YeniProje
{
    partial class Odev24_DonanimAyirici
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
            this.lstKarisik = new System.Windows.Forms.ListBox();
            this.lstIc = new System.Windows.Forms.ListBox();
            this.lstDis = new System.Windows.Forms.ListBox();
            this.btnAyir = new System.Windows.Forms.Button();
            this.lblKarisik = new System.Windows.Forms.Label();
            this.lblIc = new System.Windows.Forms.Label();
            this.lblDis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstKarisik
            // 
            this.lstKarisik.FormattingEnabled = true;
            this.lstKarisik.ItemHeight = 20;
            this.lstKarisik.Location = new System.Drawing.Point(20, 40);
            this.lstKarisik.Name = "lstKarisik";
            this.lstKarisik.Size = new System.Drawing.Size(150, 204);
            this.lstKarisik.TabIndex = 0;
            // 
            // lstIc
            // 
            this.lstIc.FormattingEnabled = true;
            this.lstIc.ItemHeight = 20;
            this.lstIc.Location = new System.Drawing.Point(360, 40);
            this.lstIc.Name = "lstIc";
            this.lstIc.Size = new System.Drawing.Size(150, 204);
            this.lstIc.TabIndex = 1;
            // 
            // lstDis
            // 
            this.lstDis.FormattingEnabled = true;
            this.lstDis.ItemHeight = 20;
            this.lstDis.Location = new System.Drawing.Point(530, 40);
            this.lstDis.Name = "lstDis";
            this.lstDis.Size = new System.Drawing.Size(150, 204);
            this.lstDis.TabIndex = 2;
            // 
            // btnAyir
            // 
            this.btnAyir.Location = new System.Drawing.Point(190, 110);
            this.btnAyir.Name = "btnAyir";
            this.btnAyir.Size = new System.Drawing.Size(150, 50);
            this.btnAyir.TabIndex = 3;
            this.btnAyir.Text = "Donanımları Ayır =>";
            this.btnAyir.UseVisualStyleBackColor = true;
            this.btnAyir.Click += new System.EventHandler(this.btnAyir_Click);
            // 
            // lblKarisik
            // 
            this.lblKarisik.AutoSize = true;
            this.lblKarisik.Location = new System.Drawing.Point(20, 15);
            this.lblKarisik.Name = "lblKarisik";
            this.lblKarisik.Size = new System.Drawing.Size(107, 20);
            this.lblKarisik.TabIndex = 4;
            this.lblKarisik.Text = "Karışık Parçalar";
            // 
            // lblIc
            // 
            this.lblIc.AutoSize = true;
            this.lblIc.Location = new System.Drawing.Point(360, 15);
            this.lblIc.Name = "lblIc";
            this.lblIc.Size = new System.Drawing.Size(91, 20);
            this.lblIc.TabIndex = 5;
            this.lblIc.Text = "İç Donanımlar";
            // 
            // lblDis
            // 
            this.lblDis.AutoSize = true;
            this.lblDis.Location = new System.Drawing.Point(530, 15);
            this.lblDis.Name = "lblDis";
            this.lblDis.Size = new System.Drawing.Size(102, 20);
            this.lblDis.TabIndex = 6;
            this.lblDis.Text = "Dış Donanımlar";
            // 
            // Odev24_DonanimAyirici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 270);
            this.Controls.Add(this.lblDis);
            this.Controls.Add(this.lblIc);
            this.Controls.Add(this.lblKarisik);
            this.Controls.Add(this.btnAyir);
            this.Controls.Add(this.lstDis);
            this.Controls.Add(this.lstIc);
            this.Controls.Add(this.lstKarisik);
            this.Name = "Odev24_DonanimAyirici";
            this.Text = "Ödev 24 - Donanım Ayırıcı";
            this.Load += new System.EventHandler(this.Odev24_DonanimAyirici_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox lstKarisik;
        private System.Windows.Forms.ListBox lstIc;
        private System.Windows.Forms.ListBox lstDis;
        private System.Windows.Forms.Button btnAyir;
        private System.Windows.Forms.Label lblKarisik;
        private System.Windows.Forms.Label lblIc;
        private System.Windows.Forms.Label lblDis;
    }
}