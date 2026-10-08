namespace YeniProje;

partial class Odev11_KaresiniAlma
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
        txtSayi = new TextBox();
        btnHesapla = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(41, 41);
        label1.Name = "label1";
        label1.Size = new Size(130, 20);
        label1.TabIndex = 0;
        label1.Text = "Bir sayı giriniz:";
        // 
        // txtSayi
        // 
        txtSayi.Location = new Point(177, 38);
        txtSayi.Name = "txtSayi";
        txtSayi.Size = new Size(125, 27);
        txtSayi.TabIndex = 1;
        // 
        // btnHesapla
        // 
        btnHesapla.Location = new Point(177, 85);
        btnHesapla.Name = "btnHesapla";
        btnHesapla.Size = new Size(125, 40);
        btnHesapla.TabIndex = 2;
        btnHesapla.Text = "Karesini Al";
        btnHesapla.UseVisualStyleBackColor = true;
        btnHesapla.Click += btnHesapla_Click;
        // 
        // Odev11_KaresiniAlma
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(365, 178);
        Controls.Add(btnHesapla);
        Controls.Add(txtSayi);
        Controls.Add(label1);
        Name = "Odev11_KaresiniAlma";
        Text = "Karesi Alma İşlemi";
        ResumeLayout(false);
        PerformLayout();
    }

    private Label label1;
    private TextBox txtSayi;
    private Button btnHesapla;
}
