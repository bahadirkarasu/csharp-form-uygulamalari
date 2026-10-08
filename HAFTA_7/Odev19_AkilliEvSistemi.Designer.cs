namespace YeniProje;

partial class Odev19_AkilliEvSistemi
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
        groupBox2 = new GroupBox();
        checkBox1 = new CheckBox();
        checkBox2 = new CheckBox();
        button1 = new Button();
        listBox1 = new ListBox();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(listBox1);
        groupBox1.Location = new Point(315, 12);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(250, 326);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "sistem raporu";
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(button1);
        groupBox2.Controls.Add(checkBox2);
        groupBox2.Controls.Add(checkBox1);
        groupBox2.Location = new Point(12, 12);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(250, 326);
        groupBox2.TabIndex = 1;
        groupBox2.TabStop = false;
        groupBox2.Text = "kontrol paneli";
        groupBox2.Enter += groupBox2_Enter;
        // 
        // checkBox1
        // 
        checkBox1.AutoSize = true;
        checkBox1.Location = new Point(27, 50);
        checkBox1.Name = "checkBox1";
        checkBox1.Size = new Size(130, 24);
        checkBox1.TabIndex = 0;
        checkBox1.Text = "lamba ac/kapa";
        checkBox1.UseVisualStyleBackColor = true;
        // 
        // checkBox2
        // 
        checkBox2.AutoSize = true;
        checkBox2.Location = new Point(27, 94);
        checkBox2.Name = "checkBox2";
        checkBox2.Size = new Size(130, 24);
        checkBox2.TabIndex = 1;
        checkBox2.Text = "kombi ac/kapa";
        checkBox2.UseVisualStyleBackColor = true;
        // 
        // button1
        // 
        button1.Location = new Point(63, 190);
        button1.Name = "button1";
        button1.Size = new Size(94, 98);
        button1.TabIndex = 2;
        button1.Text = "sistemi kontrol et";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // listBox1
        // 
        listBox1.FormattingEnabled = true;
        listBox1.Location = new Point(6, 18);
        listBox1.Name = "listBox1";
        listBox1.Size = new Size(242, 304);
        listBox1.TabIndex = 0;
        listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        // 
        // Odev19_AkilliEvSistemi
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(600, 350);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        Name = "Odev19_AkilliEvSistemi";
        Text = "Akıllı Ev Kontrol Paneli";
        groupBox1.ResumeLayout(false);
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        ResumeLayout(false);
    }

    private GroupBox groupBox1;
    private GroupBox groupBox2;
    private ListBox listBox1;
    private Button button1;
    private CheckBox checkBox2;
    private CheckBox checkBox1;
}
