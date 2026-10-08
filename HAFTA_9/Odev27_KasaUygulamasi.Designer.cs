namespace YeniProje;

partial class Odev27_KasaUygulamasi
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

    private void InitializeComponent()
    {
        label1 = new Label();
        textBox1 = new TextBox();
        groupBox1 = new GroupBox();
        rb5Taksit = new RadioButton();
        rb4Taksit = new RadioButton();
        rb3Taksit = new RadioButton();
        rb2Taksit = new RadioButton();
        rbTek = new RadioButton();
        btnOdeme = new Button();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(30, 30);
        label1.Name = "label1";
        label1.Size = new Size(100, 20);
        label1.TabIndex = 0;
        label1.Text = "Toplam Tutar:";
        // 
        // textBox1
        // 
        textBox1.Location = new Point(136, 27);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(100, 27);
        textBox1.TabIndex = 1;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(rb5Taksit);
        groupBox1.Controls.Add(rb4Taksit);
        groupBox1.Controls.Add(rb3Taksit);
        groupBox1.Controls.Add(rb2Taksit);
        groupBox1.Controls.Add(rbTek);
        groupBox1.Location = new Point(30, 70);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(230, 200);
        groupBox1.TabIndex = 2;
        groupBox1.TabStop = false;
        groupBox1.Text = "Ödeme Şekli";
        // 
        // rb5Taksit
        // 
        rb5Taksit.AutoSize = true;
        rb5Taksit.Location = new Point(20, 155);
        rb5Taksit.Name = "rb5Taksit";
        rb5Taksit.Size = new Size(172, 24);
        rb5Taksit.TabIndex = 4;
        rb5Taksit.TabStop = true;
        rb5Taksit.Text = "5 Taksit (%10 ek fiyat)";
        rb5Taksit.UseVisualStyleBackColor = true;
        // 
        // rb4Taksit
        // 
        rb4Taksit.AutoSize = true;
        rb4Taksit.Location = new Point(20, 125);
        rb4Taksit.Name = "rb4Taksit";
        rb4Taksit.Size = new Size(172, 24);
        rb4Taksit.TabIndex = 3;
        rb4Taksit.TabStop = true;
        rb4Taksit.Text = "4 Taksit (%10 ek fiyat)";
        rb4Taksit.UseVisualStyleBackColor = true;
        // 
        // rb3Taksit
        // 
        rb3Taksit.AutoSize = true;
        rb3Taksit.Location = new Point(20, 95);
        rb3Taksit.Name = "rb3Taksit";
        rb3Taksit.Size = new Size(164, 24);
        rb3Taksit.TabIndex = 2;
        rb3Taksit.TabStop = true;
        rb3Taksit.Text = "3 Taksit (%5 ek fiyat)";
        rb3Taksit.UseVisualStyleBackColor = true;
        // 
        // rb2Taksit
        // 
        rb2Taksit.AutoSize = true;
        rb2Taksit.Location = new Point(20, 65);
        rb2Taksit.Name = "rb2Taksit";
        rb2Taksit.Size = new Size(164, 24);
        rb2Taksit.TabIndex = 1;
        rb2Taksit.TabStop = true;
        rb2Taksit.Text = "2 Taksit (%5 ek fiyat)";
        rb2Taksit.UseVisualStyleBackColor = true;
        // 
        // rbTek
        // 
        rbTek.AutoSize = true;
        rbTek.Location = new Point(20, 35);
        rbTek.Name = "rbTek";
        rbTek.Size = new Size(97, 24);
        rbTek.TabIndex = 0;
        rbTek.TabStop = true;
        rbTek.Text = "Tek Çekim";
        rbTek.UseVisualStyleBackColor = true;
        rbTek.CheckedChanged += rbTek_CheckedChanged;
        // 
        // btnOdeme
        // 
        btnOdeme.Location = new Point(30, 280);
        btnOdeme.Name = "btnOdeme";
        btnOdeme.Size = new Size(230, 40);
        btnOdeme.TabIndex = 3;
        btnOdeme.Text = "Ödeme Yap";
        btnOdeme.UseVisualStyleBackColor = true;
        btnOdeme.Click += btnOdeme_Click;
        // 
        // Odev27_KasaUygulamasi
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ActiveCaption;
        ClientSize = new Size(300, 350);
        Controls.Add(btnOdeme);
        Controls.Add(groupBox1);
        Controls.Add(textBox1);
        Controls.Add(label1);
        Name = "Odev27_KasaUygulamasi";
        Text = "Kasa";
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label label1;
    private TextBox textBox1;
    private GroupBox groupBox1;
    private RadioButton rbTek;
    private RadioButton rb2Taksit;
    private RadioButton rb3Taksit;
    private RadioButton rb4Taksit;
    private RadioButton rb5Taksit;
    private Button btnOdeme;
}
