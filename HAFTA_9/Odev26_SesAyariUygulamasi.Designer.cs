namespace YeniProje;

partial class Odev26_SesAyariUygulamasi
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
        trackBar1 = new TrackBar();
        label1 = new Label();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(trackBar1);
        groupBox1.Location = new Point(50, 30);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(350, 100);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "Ses Seviyesi (0-15)";
        // 
        // trackBar1
        // 
        trackBar1.Location = new Point(20, 30);
        trackBar1.Maximum = 15;
        trackBar1.Name = "trackBar1";
        trackBar1.Size = new Size(310, 56);
        trackBar1.TabIndex = 0;
        trackBar1.Scroll += trackBar1_Scroll;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        label1.Location = new Point(50, 150);
        label1.Name = "label1";
        label1.Size = new Size(116, 37);
        label1.TabIndex = 1;
        label1.Text = "Ses Yok";
        // 
        // Odev26_SesAyariUygulamasi
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(450, 250);
        Controls.Add(label1);
        Controls.Add(groupBox1);
        Name = "Odev26_SesAyariUygulamasi";
        Text = "Ses Ayarı";
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private GroupBox groupBox1;
    private TrackBar trackBar1;
    private Label label1;
}
