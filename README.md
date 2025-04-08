IDE AWAL APLIKASI DESKTOP "JUAL TIKET MASUK BANDARA"

Nama Aplikasi: JualTiket  Masuk Bandara

Tujuan: Membuat aplikasi desktop sederhana untuk membantu petugas bandara dalam mengelola data penjualan tiket masuk. Aplikasi ini akan menyimpan informasi tiket secara terstruktur dan memungkinkan pengelolaan data secara efisien menggunakan antarmuka pengguna yang mudah dipahami.

Permasalahan: Petugas bandara sering kali mencatat tiket masuk secara manual, yang rawan kesalahan dan sulit dikelola jika jumlah data banyak. Dibutuhkan aplikasi sederhana yang dapat membantu mencatat, menampilkan, memperbarui, dan menghapus data tiket dengan cepat dan akurat.

Solusi: Membuat aplikasi berbasis Windows Forms yang menyediakan fitur CRUD (Create, Read, Update, Delete) untuk data tiket masuk. Aplikasi akan terhubung dengan database SQL Server untuk penyimpanan data secara terpusat dan aman.

Fitur yang Direncanakan:
1. Input Data Tiket
NO (Nomer tiket)
DATE (Tanggal Keberangkatan)
FROM (Asal Penerbangan)
DESTINATION (Tujuan Penerbangan)
2. Tampilkan Data Tiket
Menggunakan DataGridView untuk melihat semua data tiket yang tersimpan di database.
3. Update Data Tiket
Mengubah informasi tiket yang sudah tersimpan.
4. Hapus Data Tiket
Menghapus data tiket berdasarkan nomor tiket.
5. Koneksi Database SQL Server
Nama database: BandaraDB
Server: DESKTOP-HAIN24I\TIKET
Menggunakan Integrated Security (tanpa username/password).
6. Antarmuka Sederhana
TextBox untuk input teks
DateTimePicker untuk tanggal
DataGridView untuk tampilan data
MessageBox untuk notifikasi/konfirmasi tindakan
