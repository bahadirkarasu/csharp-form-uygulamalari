namespace YeniProje;

partial class Odev12_DaireAlaniVeCevresi
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
        textBox1 = new TextBox();
        button1 = new Button();
        label1 = new Label();
        label2 = new Label();
        SuspendLayout();
        // 
        // textBox1
        // 
        textBox1.Location = new Point(606, 56);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(125, 27);
        textBox1.TabIndex = 0;
        // 
        // button1
        // 
        button1.Location = new Point(622, 89);
        button1.Name = "button1";
        button1.Size = new Size(94, 29);
        button1.TabIndex = 1;
        button1.Text = "hesapla";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(461, 59);
        label1.Name = "label1";
        label1.Size = new Size(128, 20);
        label1.TabIndex = 2;
        label1.Text = "yari cap giriniz (r):";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(640, 159);
        label2.Name = "label2";
        label2.Size = new Size(50, 20);
        label2.TabIndex = 3;
        label2.Text = "label2";
        // 
        // Odev12_DaireAlaniVeCevresi
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1222, 450);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(button1);
        Controls.Add(textBox1);
        Name = "Odev12_DaireAlaniVeCevresi";
        Text = "Beyaz Form";
        ResumeLayout(false);
        PerformLayout();
    }

    private TextBox textBox1;
    private Button button1;
    private Label label1;
    private Label label2;
}
