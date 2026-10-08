using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KutuphaneOtomasyonu
{
    public partial class frmOdunc : Form
    {
        private int selectedOduncId = 0;

        public frmOdunc()
        {
            InitializeComponent();
        }

        private void frmOdunc_Load(object sender, EventArgs e)
        {
            OgrencileriDoldur();
            KitaplariDoldur();
            Listele();
        }

        private void OgrencileriDoldur()
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand("SELECT ogr_no, CONCAT(ogr_no, ' - ', ad, ' ', soyad) AS OgrBilgi FROM ogrenciler", conn))
                    {
                        using (var adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            cmbOgrenci.DisplayMember = "OgrBilgi";
                            cmbOgrenci.ValueMember = "ogr_no";
                            cmbOgrenci.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Öğrenci Yükleme Hatası: " + ex.Message); }
        }

        private void KitaplariDoldur()
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand("SELECT kitap_id, kitap_adi FROM kitaplar", conn))
                    {
                        using (var adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            cmbKitap.DisplayMember = "kitap_adi";
                            cmbKitap.ValueMember = "kitap_id";
                            cmbKitap.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Kitap Yükleme Hatası: " + ex.Message); }
        }

        private void Listele()
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT o.odunc_id AS 'İşlem ID', ogr.ad AS 'Öğrenci Adı', ogr.soyad AS 'Soyadı', k.kitap_adi AS 'Kitap Adı', o.verilis_tarihi AS 'Veriliş', o.teslim_tarihi AS 'Teslim' FROM odunc_kitaplar o INNER JOIN ogrenciler ogr ON o.ogr_no = ogr.ogr_no INNER JOIN kitaplar k ON o.kitap_id = k.kitap_id";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        using (var adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Listeleme Hatası: " + ex.Message); }
        }

        private void btnKitapVer_Click(object sender, EventArgs e)
        {
            if (cmbOgrenci.SelectedValue == null || cmbKitap.SelectedValue == null) return;
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO odunc_kitaplar (ogr_no, kitap_id, verilis_tarihi, teslim_tarihi) VALUES (@ogr, @kitap, @verilis, @teslim)";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ogr", cmbOgrenci.SelectedValue);
                        cmd.Parameters.AddWithValue("@kitap", cmbKitap.SelectedValue);
                        cmd.Parameters.AddWithValue("@verilis", dtVerilis.Value.Date);
                        cmd.Parameters.AddWithValue("@teslim", dtTeslim.Value.Date);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Kitap Başarıyla Öğrenciye Verildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
            catch (Exception ex) { MessageBox.Show("Kayıt Hatası: " + ex.Message); }
        }

        private void btnTeslimAl_Click(object sender, EventArgs e)
        {
            if (selectedOduncId == 0)
            {
                MessageBox.Show("Lütfen tablodan teslim edilecek kaydı seçin!");
                return;
            }
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM odunc_kitaplar WHERE odunc_id=@id";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", selectedOduncId);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Kitap Öğrenciden Başarıyla Teslim Alındı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
                selectedOduncId = 0;
            }
            catch (Exception ex) { MessageBox.Show("Teslim Alma Hatası: " + ex.Message); }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                selectedOduncId = Convert.ToInt32(row.Cells["İşlem ID"].Value);
            }
        }
    }
}
