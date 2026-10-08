using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KutuphaneOtomasyonu
{
    public partial class frmKitapTur : Form
    {
        private int selectedId = 0;

        public frmKitapTur()
        {
            InitializeComponent();
        }

        private void frmKitapTur_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand("SELECT tur_id AS 'Tür ID', tur_adi AS 'Tür Adı' FROM kitap_turleri", conn))
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
            if (string.IsNullOrWhiteSpace(txtTurAdi.Text)) return;
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO kitap_turleri (tur_adi) VALUES (@ad)";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ad", txtTurAdi.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Tür Başarıyla Eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
                txtTurAdi.Clear();
            }
            catch (Exception ex) { MessageBox.Show("Hata: " + ex.Message); }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (selectedId == 0) return;
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM kitap_turleri WHERE tur_id=@id";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", selectedId);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Tür Silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
                txtTurAdi.Clear();
                selectedId = 0;
            }
            catch (Exception ex) { MessageBox.Show("Hata: " + ex.Message); }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (selectedId == 0 || string.IsNullOrWhiteSpace(txtTurAdi.Text)) return;
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE kitap_turleri SET tur_adi=@ad WHERE tur_id=@id";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", selectedId);
                        cmd.Parameters.AddWithValue("@ad", txtTurAdi.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Tür Güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
            catch (Exception ex) { MessageBox.Show("Hata: " + ex.Message); }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                selectedId = Convert.ToInt32(row.Cells["Tür ID"].Value);
                txtTurAdi.Text = row.Cells["Tür Adı"].Value?.ToString();
            }
        }
    }
}
