namespace YeniProje
{
    partial class Odev1_OzelliklerPaneli
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
            btnTest = new Button();
            chkTest = new CheckBox();
            lblTest = new Label();
            picTest = new PictureBox();
            txtRapor = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picTest).BeginInit();
            SuspendLayout();
            // 
            // btnTest
            // 
            btnTest.Location = new Point(18, 15);
            btnTest.Margin = new Padding(3, 2, 3, 2);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(105, 22);
            btnTest.TabIndex = 0;
            btnTest.Text = "Örnek Buton";
            btnTest.UseVisualStyleBackColor = true;
            // 
            // chkTest
            // 
            chkTest.AutoSize = true;
            chkTest.Location = new Point(18, 52);
            chkTest.Margin = new Padding(3, 2, 3, 2);
            chkTest.Name = "chkTest";
            chkTest.Size = new Size(94, 19);
            chkTest.TabIndex = 1;
            chkTest.Text = "Örnek Check";
            chkTest.UseVisualStyleBackColor = true;
            // 
            // lblTest
            // 
            lblTest.AutoSize = true;
            lblTest.Location = new Point(18, 90);
            lblTest.Name = "lblTest";
            lblTest.Size = new Size(71, 15);
            lblTest.TabIndex = 2;
            lblTest.Text = "Örnek Etiket";
            // 
            // picTest
            // 
            picTest.BackColor = Color.LightGray;
            picTest.Location = new Point(12, 123);
            picTest.Margin = new Padding(3, 2, 3, 2);
            picTest.Name = "picTest";
            picTest.Size = new Size(105, 68);
            picTest.TabIndex = 3;
            picTest.TabStop = false;
            // 
            // txtRapor
            // 
            txtRapor.Location = new Point(140, 15);
            txtRapor.Margin = new Padding(3, 2, 3, 2);
            txtRapor.Multiline = true;
            txtRapor.Name = "txtRapor";
            txtRapor.ReadOnly = true;
            txtRapor.ScrollBars = ScrollBars.Vertical;
            txtRapor.Size = new Size(350, 174);
            txtRapor.TabIndex = 4;
            txtRapor.TextChanged += txtRapor_TextChanged;
            // 
            // Odev1_OzelliklerPaneli
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 202);
            Controls.Add(txtRapor);
            Controls.Add(picTest);
            Controls.Add(lblTest);
            Controls.Add(chkTest);
            Controls.Add(btnTest);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Odev1_OzelliklerPaneli";
            Text = "Ödev 1 - Özellikler Paneli";
            Load += Odev1_OzelliklerPaneli_Load;
            ((System.ComponentModel.ISupportInitialize)picTest).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.CheckBox chkTest;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.PictureBox picTest;
        private System.Windows.Forms.TextBox txtRapor;
    }
}