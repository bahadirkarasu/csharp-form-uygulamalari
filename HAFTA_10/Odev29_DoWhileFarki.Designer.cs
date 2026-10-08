namespace YeniProje
{
    partial class Odev29_DoWhileFarki
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
            this.lstWhile = new System.Windows.Forms.ListBox();
            this.lstDoWhile = new System.Windows.Forms.ListBox();
            this.btnKarsilastir = new System.Windows.Forms.Button();
            this.lblWhile = new System.Windows.Forms.Label();
            this.lblDoWhile = new System.Windows.Forms.Label();
            this.lblFark = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstWhile
            // 
            this.lstWhile.FormattingEnabled = true;
            this.lstWhile.ItemHeight = 20;
            this.lstWhile.Location = new System.Drawing.Point(20, 40);
            this.lstWhile.Name = "lstWhile";
            this.lstWhile.Size = new System.Drawing.Size(120, 204);
            this.lstWhile.TabIndex = 0;
            // 
            // lstDoWhile
            // 
            this.lstDoWhile.FormattingEnabled = true;
            this.lstDoWhile.ItemHeight = 20;
            this.lstDoWhile.Location = new System.Drawing.Point(160, 40);
            this.lstDoWhile.Name = "lstDoWhile";
            this.lstDoWhile.Size = new System.Drawing.Size(120, 204);
            this.lstDoWhile.TabIndex = 1;
            // 
            // btnKarsilastir
            // 
            this.btnKarsilastir.Location = new System.Drawing.Point(300, 40);
            this.btnKarsilastir.Name = "btnKarsilastir";
            this.btnKarsilastir.Size = new System.Drawing.Size(260, 40);
            this.btnKarsilastir.TabIndex = 2;
            this.btnKarsilastir.Text = "Döngüleri Çalıştır";
            this.btnKarsilastir.UseVisualStyleBackColor = true;
            this.btnKarsilastir.Click += new System.EventHandler(this.btnKarsilastir_Click);
            // 
            // lblWhile
            // 
            this.lblWhile.AutoSize = true;
            this.lblWhile.Location = new System.Drawing.Point(20, 15);
            this.lblWhile.Name = "lblWhile";
            this.lblWhile.Size = new System.Drawing.Size(89, 20);
            this.lblWhile.TabIndex = 3;
            this.lblWhile.Text = "While Listesi";
            // 
            // lblDoWhile
            // 
            this.lblDoWhile.AutoSize = true;
            this.lblDoWhile.Location = new System.Drawing.Point(160, 15);
            this.lblDoWhile.Name = "lblDoWhile";
            this.lblDoWhile.Size = new System.Drawing.Size(111, 20);
            this.lblDoWhile.TabIndex = 4;
            this.lblDoWhile.Text = "Do-While Listesi";
            // 
            // lblFark
            // 
            this.lblFark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFark.Location = new System.Drawing.Point(300, 95);
            this.lblFark.Name = "lblFark";
            this.lblFark.Size = new System.Drawing.Size(260, 149);
            this.lblFark.TabIndex = 5;
            this.lblFark.Text = "Analiz Raporu: ";
            // 
            // Odev29_DoWhileFarki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 270);
            this.Controls.Add(this.lblFark);
            this.Controls.Add(this.lblDoWhile);
            this.Controls.Add(this.lblWhile);
            this.Controls.Add(this.btnKarsilastir);
            this.Controls.Add(this.lstDoWhile);
            this.Controls.Add(this.lstWhile);
            this.Name = "Odev29_DoWhileFarki";
            this.Text = "Ödev 29 - Do-While Farkı";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox lstWhile;
        private System.Windows.Forms.ListBox lstDoWhile;
        private System.Windows.Forms.Button btnKarsilastir;
        private System.Windows.Forms.Label lblWhile;
        private System.Windows.Forms.Label lblDoWhile;
        private System.Windows.Forms.Label lblFark;
    }
}