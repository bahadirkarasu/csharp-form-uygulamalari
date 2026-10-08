using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public static class DatabaseHelper
    {
        // Standart XAMPP bağlantı dizesi
        private static string connectionString = "Server=localhost;Database=kutuphane;Uid=root;Pwd=;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public static bool TestConnection()
        {
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    return true;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantı hatası!\nLütfen XAMPP MySQL'in açık olduğundan ve 'kutuphane' veritabanını oluşturduğunuzdan emin olun.\n\nHata Detayı: " + ex.Message, "Bağlantı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
