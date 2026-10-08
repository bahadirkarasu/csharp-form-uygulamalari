namespace YeniProje;

partial class Odev6_FareOlaylari
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
        button2 = new Button();
        button3 = new Button();
        SuspendLayout();
        // 
        // button1
        // 
        button1.BackColor = Color.IndianRed;
        button1.Location = new Point(434, 117);
        button1.Name = "button1";
        button1.Size = new Size(94, 29);
        button1.TabIndex = 0;
        button1.Text = "button1";
        button1.UseVisualStyleBackColor = false;
        button1.MouseEnter += button1_MouseEnter;
        // 
        // button2
        // 
        button2.BackColor = Color.Coral;
        button2.ForeColor = SystemColors.ActiveCaptionText;
        button2.Location = new Point(558, 117);
        button2.Name = "button2";
        button2.Size = new Size(94, 29);
        button2.TabIndex = 1;
        button2.Text = "button2";
        button2.UseVisualStyleBackColor = false;
        button2.DoubleClick += button2_DoubleClick;
        // 
        // button3
        // 
        button3.BackColor = Color.Coral;
        button3.Location = new Point(485, 199);
        button3.Name = "button3";
        button3.Size = new Size(94, 29);
        button3.TabIndex = 2;
        button3.Text = "button3";
        button3.UseVisualStyleBackColor = false;
        button3.MouseLeave += button3_MouseLeave;
        // 
        // Odev6_FareOlaylari
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Orange;
        ClientSize = new Size(800, 450);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(button1);
        ForeColor = Color.Black;
        Name = "Odev6_FareOlaylari";
        Text = "Odev6_FareOlaylari";
        ResumeLayout(false);
    }

    private Button button1;
    private Button button2;
    private Button button3;
}
