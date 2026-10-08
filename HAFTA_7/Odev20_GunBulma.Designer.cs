namespace YeniProje;

partial class Odev20_GunBulma
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
        SuspendLayout();
        // 
        // button1
        // 
        button1.Location = new Point(100, 50);
        button1.Name = "button1";
        button1.Size = new Size(200, 50);
        button1.TabIndex = 0;
        button1.Text = "Hangi Gündeyiz?";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // Odev20_GunBulma
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.LightSkyBlue;
        ClientSize = new Size(400, 150);
        Controls.Add(button1);
        Name = "Odev20_GunBulma";
        Text = "Günün İsmini Bul";
        ResumeLayout(false);
    }

    private Button button1;
}
