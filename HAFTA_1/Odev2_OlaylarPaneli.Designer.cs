namespace YeniProje
{
    partial class Odev2_OlaylarPaneli
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
            this.btnTest = new System.Windows.Forms.Button();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(20, 20);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(120, 30);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "Olay Butonu";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            this.btnTest.MouseEnter += new System.EventHandler(this.btnTest_MouseEnter);
            this.btnTest.MouseLeave += new System.EventHandler(this.btnTest_MouseLeave);
            this.btnTest.Enter += new System.EventHandler(this.btnTest_Enter);
            this.btnTest.Leave += new System.EventHandler(this.btnTest_Leave);
            // 
            // txtTest
            // 
            this.txtTest.Location = new System.Drawing.Point(20, 70);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(120, 27);
            this.txtTest.TabIndex = 1;
            this.txtTest.TextChanged += new System.EventHandler(this.txtTest_TextChanged);
            this.txtTest.MouseEnter += new System.EventHandler(this.txtTest_MouseEnter);
            this.txtTest.MouseLeave += new System.EventHandler(this.txtTest_MouseLeave);
            this.txtTest.Enter += new System.EventHandler(this.txtTest_Enter);
            this.txtTest.Leave += new System.EventHandler(this.txtTest_Leave);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(160, 20);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(400, 230);
            this.txtLog.TabIndex = 2;
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(20, 110);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(120, 140);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "Kutunun içine yazın, odaklanın veya nesnelerin üzerine gelin. Tetiklenen ortak olaylar sağda listelenir.";
            // 
            // Odev2_OlaylarPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 270);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.btnTest);
            this.Name = "Odev2_OlaylarPaneli";
            this.Text = "Ödev 2 - Olaylar Paneli";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label lblInfo;
    }
}