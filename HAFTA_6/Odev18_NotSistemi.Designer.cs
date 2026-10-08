namespace YeniProje;

partial class Odev18_NotSistemi
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
        SuspendLayout();
        // 
        // textBox1
        // 
        textBox1.Location = new Point(239, 137);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(125, 27);
        textBox1.TabIndex = 0;
        // 
        // button1
        // 
        button1.Location = new Point(139, 113);
        button1.Name = "button1";
        button1.Size = new Size(94, 74);
        button1.TabIndex = 1;
        button1.Text = "beslik sistene cevir";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // Odev18_NotSistemi
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(500, 300);
        Controls.Add(button1);
        Controls.Add(textBox1);
        Name = "Odev18_NotSistemi";
        Text = "Not Çevirici (100'lük -> 5'lik)";
        ResumeLayout(false);
        PerformLayout();
    }

    private TextBox textBox1;
    private Button button1;
}
