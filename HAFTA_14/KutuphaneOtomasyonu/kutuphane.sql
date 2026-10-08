CREATE DATABASE IF NOT EXISTS kutuphane DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE kutuphane;

-- 1. kitap_turleri Tablosu
CREATE TABLE IF NOT EXISTS kitap_turleri (
    tur_id INT AUTO_INCREMENT PRIMARY KEY,
    tur_adi VARCHAR(100) NOT NULL
);

-- 2. kitaplar Tablosu
CREATE TABLE IF NOT EXISTS kitaplar (
    kitap_id INT AUTO_INCREMENT PRIMARY KEY,
    kitap_adi VARCHAR(150) NOT NULL,
    kitap_yazari VARCHAR(100) NOT NULL,
    yayin_evi VARCHAR(100) NOT NULL,
    tur_id INT,
    FOREIGN KEY (tur_id) REFERENCES kitap_turleri(tur_id) ON DELETE SET NULL
);

-- 3. ogrenciler Tablosu
CREATE TABLE IF NOT EXISTS ogrenciler (
    ogr_no INT PRIMARY KEY,
    ad VARCHAR(50) NOT NULL,
    soyad VARCHAR(50) NOT NULL,
    cinsiyet VARCHAR(10),
    telefon VARCHAR(20),
    adres VARCHAR(255)
);

-- 4. odunc_kitaplar Tablosu
CREATE TABLE IF NOT EXISTS odunc_kitaplar (
    odunc_id INT AUTO_INCREMENT PRIMARY KEY,
    ogr_no INT,
    kitap_id INT,
    verilis_tarihi DATE NOT NULL,
    teslim_tarihi DATE NOT NULL,
    FOREIGN KEY (ogr_no) REFERENCES ogrenciler(ogr_no) ON DELETE CASCADE,
    FOREIGN KEY (kitap_id) REFERENCES kitaplar(kitap_id) ON DELETE CASCADE
);

-- Örnek Veriler (Test İçin)
INSERT IGNORE INTO kitap_turleri (tur_id, tur_adi) VALUES (1, 'Roman'), (2, 'Bilim Kurgu'), (3, 'Tarih');
INSERT IGNORE INTO kitaplar (kitap_id, kitap_adi, kitap_yazari, yayin_evi, tur_id) VALUES (1, 'Suç ve Ceza', 'Dostoyevski', 'İş Bankası', 1);
INSERT IGNORE INTO ogrenciler (ogr_no, ad, soyad, cinsiyet, telefon, adres) VALUES (101, 'Ahmet', 'Yılmaz', 'Erkek', '05551234567', 'İstanbul');
