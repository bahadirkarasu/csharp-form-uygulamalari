namespace YeniProje;

partial class Odev14_SayiKarsilastirma
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
        textBox1 = new TextBox();
        textBox2 = new TextBox();
        button1 = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(145, 50);
        label1.Name = "label1";
        label1.Size = new Size(109, 20);
        label1.TabIndex = 0;
        label1.Text = "ilk sayiyi giriniz";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(145, 126);
        label2.Name = "label2";
        label2.Size = new Size(128, 20);
        label2.TabIndex = 1;
        label2.Text = "ikinci sayiyi giriniz";
        // 
        // textBox1
        // 
        textBox1.Location = new Point(327, 50);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(125, 27);
        textBox1.TabIndex = 2;
        // 
        // textBox2
        // 
        textBox2.Location = new Point(327, 126);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(125, 27);
        textBox2.TabIndex = 3;
        // 
        // button1
        // 
        button1.Location = new Point(260, 191);
        button1.Name = "button1";
        button1.Size = new Size(106, 29);
        button1.TabIndex = 4;
        button1.Text = "KARSILASTIR";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // Odev14_SayiKarsilastirma
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Red;
        ClientSize = new Size(500, 300);
        Controls.Add(button1);
        Controls.Add(textBox2);
        Controls.Add(textBox1);
        Controls.Add(label2);
        Controls.Add(label1);
        Name = "Odev14_SayiKarsilastirma";
        Text = "Karşılaştırma";
        ResumeLayout(false);
        PerformLayout();
    }

    private Label label1;
    private Label label2;
    private TextBox textBox1;
    private TextBox textBox2;
    private Button button1;
}
