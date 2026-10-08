namespace YeniProje
{
    partial class Odev32_DiziListeleme
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
            this.btnListele = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(20, 60);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(340, 124);
            this.listBox1.TabIndex = 0;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(20, 200);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(340, 40);
            this.btnListele.TabIndex = 1;
            this.btnListele.Text = "For Döngüsüyle Dizi Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(20, 15);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(340, 40);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "Dizideki 5 isim for döngüsü kullanılarak ListBox nesnesine aktarılır.";
            // 
            // Odev32_DiziListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 260);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.listBox1);
            this.Name = "Odev32_DiziListeleme";
            this.Text = "Ödev 32 - Dizi Listeleme";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Label lblInfo;
    }
}