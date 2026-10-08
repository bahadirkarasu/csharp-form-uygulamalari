namespace YeniProje;

partial class Odev10_DortIslem
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
        label2 = new Label();
        txtSayi1 = new TextBox();
        txtSayi2 = new TextBox();
        btnTopla = new Button();
        btnCikar = new Button();
        btnCarp = new Button();
        btnBol = new Button();
        lblSonuc = new Label();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(32, 29);
        label1.Name = "label1";
        label1.Size = new Size(55, 20);
        label1.TabIndex = 0;
        label1.Text = "Sayı 1:";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(32, 70);
        label2.Name = "label2";
        label2.Size = new Size(55, 20);
        label2.TabIndex = 1;
        label2.Text = "Sayı 2:";
        // 
        // txtSayi1
        // 
        txtSayi1.Location = new Point(93, 26);
        txtSayi1.Name = "txtSayi1";
        txtSayi1.Size = new Size(125, 27);
        txtSayi1.TabIndex = 2;
        // 
        // txtSayi2
        // 
        txtSayi2.Location = new Point(93, 67);
        txtSayi2.Name = "txtSayi2";
        txtSayi2.Size = new Size(125, 27);
        txtSayi2.TabIndex = 3;
        // 
        // btnTopla
        // 
        btnTopla.Location = new Point(32, 115);
        btnTopla.Name = "btnTopla";
        btnTopla.Size = new Size(94, 29);
        btnTopla.TabIndex = 4;
        btnTopla.Text = "Topla (+)";
        btnTopla.UseVisualStyleBackColor = true;
        btnTopla.Click += btnTopla_Click;
        // 
        // btnCikar
        // 
        btnCikar.Location = new Point(132, 115);
        btnCikar.Name = "btnCikar";
        btnCikar.Size = new Size(94, 29);
        btnCikar.TabIndex = 5;
        btnCikar.Text = "Çıkar (-)";
        btnCikar.UseVisualStyleBackColor = true;
        btnCikar.Click += btnCikar_Click;
        // 
        // btnCarp
        // 
        btnCarp.Location = new Point(32, 150);
        btnCarp.Name = "btnCarp";
        btnCarp.Size = new Size(94, 29);
        btnCarp.TabIndex = 6;
        btnCarp.Text = "Çarp (*)";
        btnCarp.UseVisualStyleBackColor = true;
        btnCarp.Click += btnCarp_Click;
        // 
        // btnBol
        // 
        btnBol.Location = new Point(132, 150);
        btnBol.Name = "btnBol";
        btnBol.Size = new Size(94, 29);
        btnBol.TabIndex = 7;
        btnBol.Text = "Böl (/)";
        btnBol.UseVisualStyleBackColor = true;
        btnBol.Click += btnBol_Click;
        // 
        // lblSonuc
        // 
        lblSonuc.AutoSize = true;
        lblSonuc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
        lblSonuc.Location = new Point(32, 211);
        lblSonuc.Name = "lblSonuc";
        lblSonuc.Size = new Size(82, 28);
        lblSonuc.TabIndex = 8;
        lblSonuc.Text = "Sonuç: ";
        // 
        // Odev10_DortIslem
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(279, 283);
        Controls.Add(lblSonuc);
        Controls.Add(btnBol);
        Controls.Add(btnCarp);
        Controls.Add(btnCikar);
        Controls.Add(btnTopla);
        Controls.Add(txtSayi2);
        Controls.Add(txtSayi1);
        Controls.Add(label2);
        Controls.Add(label1);
        Name = "Odev10_DortIslem";
        Text = "Dört İşlem";
        ResumeLayout(false);
        PerformLayout();
    }

    private Label label1;
    private Label label2;
    private TextBox txtSayi1;
    private TextBox txtSayi2;
    private Button btnTopla;
    private Button btnCikar;
    private Button btnCarp;
    private Button btnBol;
    private Label lblSonuc;
}
