namespace YeniProje;

partial class Odev13_EhliyetBasvuru
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
        textBox1 = new TextBox();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Location = new Point(175, 81);
        button1.Name = "button1";
        button1.Size = new Size(94, 29);
        button1.TabIndex = 0;
        button1.Text = "button1";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // textBox1
        // 
        textBox1.Location = new Point(160, 137);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(125, 27);
        textBox1.TabIndex = 1;
        // 
        // Odev13_EhliyetBasvuru
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(500, 300);
        Controls.Add(textBox1);
        Controls.Add(button1);
        Name = "Odev13_EhliyetBasvuru";
        Text = "Ehliyet Sorgulama";
        ResumeLayout(false);
        PerformLayout();
    }

    private Button button1;
    private TextBox textBox1;
}
