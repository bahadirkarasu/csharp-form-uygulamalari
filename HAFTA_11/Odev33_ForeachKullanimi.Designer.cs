namespace YeniProje
{
    partial class Odev33_ForeachKullanimi
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnCalistir = new System.Windows.Forms.Button();
            this.lblFark = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(20, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(180, 224);
            this.listBox1.TabIndex = 0;
            // 
            // btnCalistir
            // 
            this.btnCalistir.Location = new System.Drawing.Point(220, 20);
            this.btnCalistir.Name = "btnCalistir";
            this.btnCalistir.Size = new System.Drawing.Size(340, 40);
            this.btnCalistir.TabIndex = 1;
            this.btnCalistir.Text = "Foreach Döngüsünü Çalıştır";
            this.btnCalistir.UseVisualStyleBackColor = true;
            this.btnCalistir.Click += new System.EventHandler(this.btnCalistir_Click);
            // 
            // lblFark
            // 
            this.lblFark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFark.Location = new System.Drawing.Point(220, 75);
            this.lblFark.Name = "lblFark";
            this.lblFark.Size = new System.Drawing.Size(340, 169);
            this.lblFark.TabIndex = 2;
            this.lblFark.Text = "Döngü Fark Raporu: ";
            // 
            // Odev33_ForeachKullanimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 260);
            this.Controls.Add(this.lblFark);
            this.Controls.Add(this.btnCalistir);
            this.Controls.Add(this.listBox1);
            this.Name = "Odev33_ForeachKullanimi";
            this.Text = "Ödev 33 - Foreach Kullanımı";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnCalistir;
        private System.Windows.Forms.Label lblFark;
    }
}