namespace YeniProje;

partial class Odev25_AlfabeSirasi
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
        comboBox1 = new ComboBox();
        button1 = new Button();
        label2 = new Label();
        label3 = new Label();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(50, 40);
        label1.Name = "label1";
        label1.Size = new Size(93, 20);
        label1.TabIndex = 0;
        label1.Text = "Harf Seçiniz:";
        // 
        // comboBox1
        // 
        comboBox1.FormattingEnabled = true;
        comboBox1.Items.AddRange(new object[] { "A", "B", "C", "Ç", "D", "E", "F", "G", "Ğ", "H", "I", "İ", "J", "K", "L", "M", "N", "O", "Ö", "P", "R", "S", "Ş", "T", "U", "Ü", "V", "Y", "Z" });
        comboBox1.Location = new Point(149, 37);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new Size(151, 28);
        comboBox1.TabIndex = 1;
        // 
        // button1
        // 
        button1.Location = new Point(149, 85);
        button1.Name = "button1";
        button1.Size = new Size(151, 35);
        button1.TabIndex = 2;
        button1.Text = "Kontrol Et";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        label2.Location = new Point(50, 150);
        label2.Name = "label2";
        label2.Size = new Size(0, 25);
        label2.TabIndex = 3;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
        label3.Location = new Point(50, 190);
        label3.Name = "label3";
        label3.Size = new Size(0, 25);
        label3.TabIndex = 4;
        // 
        // Odev25_AlfabeSirasi
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.LightSteelBlue;
        ClientSize = new Size(450, 260);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(button1);
        Controls.Add(comboBox1);
        Controls.Add(label1);
        Name = "Odev25_AlfabeSirasi";
        Text = "Harf / Alfabe Uygulaması";
        ResumeLayout(false);
        PerformLayout();
    }

    private Label label1;
    private ComboBox comboBox1;
    private Button button1;
    private Label label2;
    private Label label3;
}
