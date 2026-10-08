namespace YeniProje;

partial class Odev9_FormBoyama
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
        groupBox1 = new GroupBox();
        button2 = new Button();
        button1 = new Button();
        button3 = new Button();
        button4 = new Button();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.BackColor = SystemColors.ButtonFace;
        groupBox1.Controls.Add(button4);
        groupBox1.Controls.Add(button3);
        groupBox1.Controls.Add(button2);
        groupBox1.Controls.Add(button1);
        groupBox1.Location = new Point(142, 128);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(532, 179);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "arka plan rengi";
        // 
        // button2
        // 
        button2.Location = new Point(348, 30);
        button2.Name = "button2";
        button2.Size = new Size(94, 29);
        button2.TabIndex = 1;
        button2.Text = "button2";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // button1
        // 
        button1.BackColor = SystemColors.ControlLightLight;
        button1.Location = new Point(49, 30);
        button1.Name = "button1";
        button1.Size = new Size(94, 29);
        button1.TabIndex = 0;
        button1.Text = "kirmizi";
        button1.UseVisualStyleBackColor = false;
        button1.Click += button1_Click;
        // 
        // button3
        // 
        button3.Location = new Point(49, 116);
        button3.Name = "button3";
        button3.Size = new Size(94, 29);
        button3.TabIndex = 2;
        button3.Text = "button3";
        button3.UseVisualStyleBackColor = true;
        // 
        // button4
        // 
        button4.Location = new Point(348, 116);
        button4.Name = "button4";
        button4.Size = new Size(94, 29);
        button4.TabIndex = 3;
        button4.Text = "button4";
        button4.UseVisualStyleBackColor = true;
        // 
        // Odev9_FormBoyama
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ControlDark;
        ClientSize = new Size(800, 450);
        Controls.Add(groupBox1);
        Name = "Odev9_FormBoyama";
        Text = "S";
        groupBox1.ResumeLayout(false);
        ResumeLayout(false);
    }

    private GroupBox groupBox1;
    private Button button2;
    private Button button1;
    private Button button4;
    private Button button3;
}
