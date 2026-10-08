namespace YeniProje;

partial class Odev30_TemaAyari
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
        rbDark = new RadioButton();
        rbLight = new RadioButton();
        btnUygula = new Button();
        SuspendLayout();
        // 
        // rbDark
        // 
        rbDark.AutoSize = true;
        rbDark.ForeColor = Color.White;
        rbDark.Location = new Point(140, 25);
        rbDark.Name = "rbDark";
        rbDark.Size = new Size(105, 24);
        rbDark.TabIndex = 0;
        rbDark.TabStop = true;
        rbDark.Text = "Dark Mode";
        rbDark.UseVisualStyleBackColor = true;
        // 
        // rbLight
        // 
        rbLight.AutoSize = true;
        rbLight.ForeColor = Color.White;
        rbLight.Location = new Point(140, 55);
        rbLight.Name = "rbLight";
        rbLight.Size = new Size(107, 24);
        rbLight.TabIndex = 1;
        rbLight.TabStop = true;
        rbLight.Text = "Light Mode";
        rbLight.UseVisualStyleBackColor = true;
        // 
        // btnUygula
        // 
        btnUygula.Location = new Point(80, 100);
        btnUygula.Name = "btnUygula";
        btnUygula.Size = new Size(200, 35);
        btnUygula.TabIndex = 2;
        btnUygula.Text = "Uygula";
        btnUygula.UseVisualStyleBackColor = true;
        btnUygula.Click += btnUygula_Click;
        // 
        // Odev30_TemaAyari
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Gray;
        ClientSize = new Size(360, 180);
        Controls.Add(btnUygula);
        Controls.Add(rbLight);
        Controls.Add(rbDark);
        Name = "Odev30_TemaAyari";
        Text = "Arka Plan Ayarları";
        ResumeLayout(false);
        PerformLayout();
    }

    private RadioButton rbDark;
    private RadioButton rbLight;
    private Button btnUygula;
}
