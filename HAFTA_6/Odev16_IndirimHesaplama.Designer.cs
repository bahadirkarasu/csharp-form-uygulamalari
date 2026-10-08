namespace YeniProje;

partial class Odev16_IndirimHesaplama
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
        txtFiyat = new TextBox();
        btnIndirim10 = new Button();
        btnIndirim25 = new Button();
        btnIndirim50 = new Button();
        btnIndirim75 = new Button();
        lblSonuc = new Label();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
        label1.Location = new Point(23, 30);
        label1.Name = "label1";
        label1.Size = new Size(111, 23);
        label1.TabIndex = 0;
        label1.Text = "Etiket Fiyatı:";
        // 
        // txtFiyat
        // 
        txtFiyat.Location = new Point(135, 29);
        txtFiyat.Name = "txtFiyat";
        txtFiyat.Size = new Size(160, 27);
        txtFiyat.TabIndex = 1;
        // 
        // btnIndirim10
        // 
        btnIndirim10.BackColor = Color.Coral;
        btnIndirim10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
        btnIndirim10.Location = new Point(23, 80);
        btnIndirim10.Name = "btnIndirim10";
        btnIndirim10.Size = new Size(95, 80);
        btnIndirim10.TabIndex = 2;
        btnIndirim10.Text = "Yüzde\r\n 10\r\n İNDİRİM";
        btnIndirim10.UseVisualStyleBackColor = false;
        btnIndirim10.Click += btnIndirim10_Click;
        // 
        // btnIndirim25
        // 
        btnIndirim25.BackColor = Color.Coral;
        btnIndirim25.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
        btnIndirim25.Location = new Point(124, 80);
        btnIndirim25.Name = "btnIndirim25";
        btnIndirim25.Size = new Size(95, 80);
        btnIndirim25.TabIndex = 3;
        btnIndirim25.Text = "Yüzde\r\n 25\r\n İNDİRİM";
        btnIndirim25.UseVisualStyleBackColor = false;
        btnIndirim25.Click += btnIndirim25_Click;
        // 
        // btnIndirim50
        // 
        btnIndirim50.BackColor = Color.Coral;
        btnIndirim50.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
        btnIndirim50.Location = new Point(225, 80);
        btnIndirim50.Name = "btnIndirim50";
        btnIndirim50.Size = new Size(95, 80);
        btnIndirim50.TabIndex = 4;
        btnIndirim50.Text = "Yüzde\r\n 50\r\n İNDİRİM";
        btnIndirim50.UseVisualStyleBackColor = false;
        btnIndirim50.Click += btnIndirim50_Click;
        // 
        // btnIndirim75
        // 
        btnIndirim75.BackColor = Color.Coral;
        btnIndirim75.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
        btnIndirim75.Location = new Point(326, 80);
        btnIndirim75.Name = "btnIndirim75";
        btnIndirim75.Size = new Size(95, 80);
        btnIndirim75.TabIndex = 5;
        btnIndirim75.Text = "Yüzde\r\n 75\r\n İNDİRİM";
        btnIndirim75.UseVisualStyleBackColor = false;
        btnIndirim75.Click += btnIndirim75_Click;
        // 
        // lblSonuc
        // 
        lblSonuc.AutoSize = true;
        lblSonuc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
        lblSonuc.Location = new Point(23, 190);
        lblSonuc.Name = "lblSonuc";
        lblSonuc.Size = new Size(155, 28);
        lblSonuc.TabIndex = 6;
        lblSonuc.Text = "İndirimli Fiyat: ";
        // 
        // Odev16_IndirimHesaplama
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(450, 260);
        Controls.Add(lblSonuc);
        Controls.Add(btnIndirim75);
        Controls.Add(btnIndirim50);
        Controls.Add(btnIndirim25);
        Controls.Add(btnIndirim10);
        Controls.Add(txtFiyat);
        Controls.Add(label1);
        Name = "Odev16_IndirimHesaplama";
        Text = "İndirim Uygulaması";
        ResumeLayout(false);
        PerformLayout();
    }

    private Label label1;
    private TextBox txtFiyat;
    private Button btnIndirim10;
    private Button btnIndirim25;
    private Button btnIndirim50;
    private Button btnIndirim75;
    private Label lblSonuc;
}
