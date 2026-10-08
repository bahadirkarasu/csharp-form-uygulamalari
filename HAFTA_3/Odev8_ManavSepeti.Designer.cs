namespace YeniProje;

partial class Odev8_ManavSepeti
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
        button1 = new Button();
        listBox1 = new ListBox();
        textBox2 = new TextBox();
        button2 = new Button();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Location = new Point(424, 216);
        button1.Name = "button1";
        button1.Size = new Size(94, 29);
        button1.TabIndex = 0;
        button1.Text = "sepete ekle";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // listBox1
        // 
        listBox1.FormattingEnabled = true;
        listBox1.Location = new Point(598, 125);
        listBox1.Name = "listBox1";
        listBox1.Size = new Size(152, 224);
        listBox1.TabIndex = 2;
        // 
        // textBox2
        // 
        textBox2.Location = new Point(415, 142);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(125, 27);
        textBox2.TabIndex = 3;
        // 
        // button2
        // 
        button2.Location = new Point(424, 287);
        button2.Name = "button2";
        button2.Size = new Size(94, 29);
        button2.TabIndex = 4;
        button2.Text = "sil";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // Odev8_ManavSepeti
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(button2);
        Controls.Add(textBox2);
        Controls.Add(listBox1);
        Controls.Add(button1);
        ForeColor = Color.Black;
        Name = "Odev8_ManavSepeti";
        Text = "manav";
        ResumeLayout(false);
        PerformLayout();
    }

    private Button button1;
    private TextBox textBox1;
    private ListBox listBox1;
    private TextBox textBox2;
    private Button button2;
}
