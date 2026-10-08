namespace YeniProje;

partial class Odev21_EgitimKademesi
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
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.ForeColor = Color.White;
        label1.Location = new Point(50, 50);
        label1.Name = "label1";
        label1.Size = new Size(61, 20);
        label1.TabIndex = 0;
        label1.Text = "Sınıfınız:";
        // 
        // comboBox1
        // 
        comboBox1.FormattingEnabled = true;
        comboBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
        comboBox1.Location = new Point(130, 47);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new Size(151, 28);
        comboBox1.TabIndex = 1;
        comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        // 
        // Odev21_EgitimKademesi
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Maroon;
        ClientSize = new Size(400, 150);
        Controls.Add(comboBox1);
        Controls.Add(label1);
        Name = "Odev21_EgitimKademesi";
        Text = "Kademeler";
        ResumeLayout(false);
        PerformLayout();
    }

    private Label label1;
    private ComboBox comboBox1;
}
