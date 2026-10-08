using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KutuphaneOtomasyonu
{
    public partial class frmOgrenci : Form
    {
        public frmOgrenci()
        {
            InitializeComponent();
        }

        private void frmOgrenci_Load(object sender, EventArgs e)
        {
            Listele();
            cmbCinsiyet.Items.AddRange(new string[] { "Erkek", "Kadın" });
        }

        private void Listele()
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand("SELECT ogr_no AS 'Öğrenci No', ad AS 'Ad', soyad AS 'Soyad', cinsiyet AS 'Cinsiyet', telefon AS 'Telefon', adres AS 'Adres' FROM ogrenciler", conn))
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
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme Hatası: " + ex.Message);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO ogrenciler (ogr_no, ad, soyad, cinsiyet, telefon, adres) VALUES (@no, @ad, @soyad, @cinsiyet, @tel, @adres)";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@no", txtOgrNo.Text);
                        cmd.Parameters.AddWithValue("@ad", txtAd.Text);
                        cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                        cmd.Parameters.AddWithValue("@cinsiyet", cmbCinsiyet.Text);
                        cmd.Parameters.AddWithValue("@tel", txtTelefon.Text);
                        cmd.Parameters.AddWithValue("@adres", txtAdres.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Öğrenci Başarıyla Kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt Hatası: " + ex.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM ogrenciler WHERE ogr_no=@no";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@no", txtOgrNo.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Öğrenci Silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme Hatası: " + ex.Message);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE ogrenciler SET ad=@ad, soyad=@soyad, cinsiyet=@cinsiyet, telefon=@tel, adres=@adres WHERE ogr_no=@no";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@no", txtOgrNo.Text);
                        cmd.Parameters.AddWithValue("@ad", txtAd.Text);
                        cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                        cmd.Parameters.AddWithValue("@cinsiyet", cmbCinsiyet.Text);
                        cmd.Parameters.AddWithValue("@tel", txtTelefon.Text);
                        cmd.Parameters.AddWithValue("@adres", txtAdres.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Öğrenci Bilgileri Güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme Hatası: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtOgrNo.Text = row.Cells["Öğrenci No"].Value?.ToString();
                txtAd.Text = row.Cells["Ad"].Value?.ToString();
                txtSoyad.Text = row.Cells["Soyad"].Value?.ToString();
                cmbCinsiyet.Text = row.Cells["Cinsiyet"].Value?.ToString();
                txtTelefon.Text = row.Cells["Telefon"].Value?.ToString();
                txtAdres.Text = row.Cells["Adres"].Value?.ToString();
            }
        }
    }
}
