using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KutuphaneOtomasyonu
{
    public partial class frmKitaplar : Form
    {
        private int selectedId = 0;

        public frmKitaplar()
        {
            InitializeComponent();
        }

        private void frmKitaplar_Load(object sender, EventArgs e)
        {
            TurleriDoldur();
            Listele();
        }

        private void TurleriDoldur()
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand("SELECT tur_id, tur_adi FROM kitap_turleri", conn))
                    {
                        using (var adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            cmbTur.DisplayMember = "tur_adi";
                            cmbTur.ValueMember = "tur_id";
                            cmbTur.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Türleri Yükleme Hatası: " + ex.Message); }
        }

        private void Listele()
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT k.kitap_id AS 'Kitap ID', k.kitap_adi AS 'Kitap Adı', k.kitap_yazari AS 'Yazarı', k.yayin_evi AS 'Yayınevi', t.tur_adi AS 'Türü', k.tur_id FROM kitaplar k LEFT JOIN kitap_turleri t ON k.tur_id = t.tur_id";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        using (var adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;
                            if(dataGridView1.Columns["tur_id"] != null)
                                dataGridView1.Columns["tur_id"].Visible = false;
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Listeleme Hatası: " + ex.Message); }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cmbTur.SelectedValue == null) return;
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO kitaplar (kitap_adi, kitap_yazari, yayin_evi, tur_id) VALUES (@ad, @yazar, @yayin, @tur)";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ad", txtKitapAdi.Text);
                        cmd.Parameters.AddWithValue("@yazar", txtYazar.Text);
                        cmd.Parameters.AddWithValue("@yayin", txtYayinevi.Text);
                        cmd.Parameters.AddWithValue("@tur", cmbTur.SelectedValue);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Kitap Kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
            catch (Exception ex) { MessageBox.Show("Kayıt Hatası: " + ex.Message); }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (selectedId == 0) return;
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM kitaplar WHERE kitap_id=@id";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", selectedId);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Kitap Silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
                selectedId = 0;
            }
            catch (Exception ex) { MessageBox.Show("Silme Hatası: " + ex.Message); }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (selectedId == 0 || cmbTur.SelectedValue == null) return;
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE kitaplar SET kitap_adi=@ad, kitap_yazari=@yazar, yayin_evi=@yayin, tur_id=@tur WHERE kitap_id=@id";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", selectedId);
                        cmd.Parameters.AddWithValue("@ad", txtKitapAdi.Text);
                        cmd.Parameters.AddWithValue("@yazar", txtYazar.Text);
                        cmd.Parameters.AddWithValue("@yayin", txtYayinevi.Text);
                        cmd.Parameters.AddWithValue("@tur", cmbTur.SelectedValue);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Kitap Güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
            catch (Exception ex) { MessageBox.Show("Güncelleme Hatası: " + ex.Message); }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                selectedId = Convert.ToInt32(row.Cells["Kitap ID"].Value);
                txtKitapAdi.Text = row.Cells["Kitap Adı"].Value?.ToString();
                txtYazar.Text = row.Cells["Yazarı"].Value?.ToString();
                txtYayinevi.Text = row.Cells["Yayınevi"].Value?.ToString();
                if (row.Cells["tur_id"].Value != DBNull.Value)
                {
                    cmbTur.SelectedValue = row.Cells["tur_id"].Value;
                }
            }
        }
    }
}
