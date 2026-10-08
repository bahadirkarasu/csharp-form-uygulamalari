namespace YeniProje;

partial class Odev17_NetHesaplama
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
        lblDogru = new Label();
        lblYanlis = new Label();
        lblNet = new Label();
        lblTurkce = new Label();
        lblMatematik = new Label();
        txtTurkceDogru = new TextBox();
        txtTurkceYanlis = new TextBox();
        txtTurkceNet = new TextBox();
        txtMatDogru = new TextBox();
        txtMatYanlis = new TextBox();
        txtMatNet = new TextBox();
        btnHesapla = new Button();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.BackColor = Color.LightSalmon;
        groupBox1.Controls.Add(btnHesapla);
        groupBox1.Controls.Add(txtMatNet);
        groupBox1.Controls.Add(txtMatYanlis);
        groupBox1.Controls.Add(txtMatDogru);
        groupBox1.Controls.Add(txtTurkceNet);
        groupBox1.Controls.Add(txtTurkceYanlis);
        groupBox1.Controls.Add(txtTurkceDogru);
        groupBox1.Controls.Add(lblMatematik);
        groupBox1.Controls.Add(lblTurkce);
        groupBox1.Controls.Add(lblNet);
        groupBox1.Controls.Add(lblYanlis);
        groupBox1.Controls.Add(lblDogru);
        groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
        groupBox1.Location = new Point(12, 12);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(500, 220);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "Sınav 1.Oturum";
        // 
        // lblDogru
        // 
        lblDogru.AutoSize = true;
        lblDogru.Location = new Point(230, 30);
        lblDogru.Name = "lblDogru";
        lblDogru.Size = new Size(65, 20);
        lblDogru.TabIndex = 0;
        lblDogru.Text = "DOĞRU";
        // 
        // lblYanlis
        // 
        lblYanlis.AutoSize = true;
        lblYanlis.Location = new Point(320, 30);
        lblYanlis.Name = "lblYanlis";
        lblYanlis.Size = new Size(61, 20);
        lblYanlis.TabIndex = 1;
        lblYanlis.Text = "YANLIŞ";
        // 
        // lblNet
        // 
        lblNet.AutoSize = true;
        lblNet.Location = new Point(410, 30);
        lblNet.Name = "lblNet";
        lblNet.Size = new Size(38, 20);
        lblNet.TabIndex = 2;
        lblNet.Text = "NET";
        // 
        // lblTurkce
        // 
        lblTurkce.AutoSize = true;
        lblTurkce.Location = new Point(20, 70);
        lblTurkce.Name = "lblTurkce";
        lblTurkce.Size = new Size(135, 20);
        lblTurkce.TabIndex = 3;
        lblTurkce.Text = "TÜRKÇE (40 SORU)";
        // 
        // lblMatematik
        // 
        lblMatematik.AutoSize = true;
        lblMatematik.Location = new Point(20, 120);
        lblMatematik.Name = "lblMatematik";
        lblMatematik.Size = new Size(167, 20);
        lblMatematik.TabIndex = 4;
        lblMatematik.Text = "MATEMATİK (40 SORU)";
        // 
        // txtTurkceDogru
        // 
        txtTurkceDogru.Location = new Point(230, 67);
        txtTurkceDogru.Name = "txtTurkceDogru";
        txtTurkceDogru.Size = new Size(65, 27);
        txtTurkceDogru.TabIndex = 5;
        // 
        // txtTurkceYanlis
        // 
        txtTurkceYanlis.Location = new Point(320, 67);
        txtTurkceYanlis.Name = "txtTurkceYanlis";
        txtTurkceYanlis.Size = new Size(65, 27);
        txtTurkceYanlis.TabIndex = 6;
        // 
        // txtTurkceNet
        // 
        txtTurkceNet.Enabled = false;
        txtTurkceNet.Location = new Point(410, 67);
        txtTurkceNet.Name = "txtTurkceNet";
        txtTurkceNet.Size = new Size(65, 27);
        txtTurkceNet.TabIndex = 7;
        // 
        // txtMatDogru
        // 
        txtMatDogru.Location = new Point(230, 117);
        txtMatDogru.Name = "txtMatDogru";
        txtMatDogru.Size = new Size(65, 27);
        txtMatDogru.TabIndex = 8;
        // 
        // txtMatYanlis
        // 
        txtMatYanlis.Location = new Point(320, 117);
        txtMatYanlis.Name = "txtMatYanlis";
        txtMatYanlis.Size = new Size(65, 27);
        txtMatYanlis.TabIndex = 9;
        // 
        // txtMatNet
        // 
        txtMatNet.Enabled = false;
        txtMatNet.Location = new Point(410, 117);
        txtMatNet.Name = "txtMatNet";
        txtMatNet.Size = new Size(65, 27);
        txtMatNet.TabIndex = 10;
        // 
        // btnHesapla
        // 
        btnHesapla.BackColor = Color.LightSkyBlue;
        btnHesapla.Location = new Point(280, 165);
        btnHesapla.Name = "btnHesapla";
        btnHesapla.Size = new Size(195, 30);
        btnHesapla.TabIndex = 11;
        btnHesapla.Text = "NET HESAPLA";
        btnHesapla.UseVisualStyleBackColor = false;
        btnHesapla.Click += btnHesapla_Click;
        // 
        // Odev17_NetHesaplama
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(524, 246);
        Controls.Add(groupBox1);
        Name = "Odev17_NetHesaplama";
        Text = "Net Hesaplama";
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
    }

    private GroupBox groupBox1;
    private Label lblDogru;
    private Label lblYanlis;
    private Label lblNet;
    private Label lblTurkce;
    private Label lblMatematik;
    private TextBox txtTurkceDogru;
    private TextBox txtTurkceYanlis;
    private TextBox txtTurkceNet;
    private TextBox txtMatDogru;
    private TextBox txtMatYanlis;
    private TextBox txtMatNet;
    private Button btnHesapla;
}
