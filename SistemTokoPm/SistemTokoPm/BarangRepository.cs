using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemTokoPm
{
    internal class BarangRepository
    {
        public static void InsertBarang(int id, string namabarang, string merek, decimal harga, int stok)
        {
            using (SqlConnection con = koneksi.GetConnection())
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO Barang (id,NamaBarang, Merek, Harga, Stok) VALUES (@id,@NamaBarang, @Merek, @Harga, @Stok)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.Parameters.AddWithValue("@NamaBarang", namabarang);
                        cmd.Parameters.AddWithValue("@Merek", merek);
                        cmd.Parameters.AddWithValue("@Harga", harga);
                        cmd.Parameters.AddWithValue("@Stok", stok);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Gagal menambahkan barang ke database.", ex);
                }
            }
        }
        public static DataTable CariBarang(string keyword)
        {
            using (SqlConnection con = koneksi.GetConnection())
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM Barang WHERE NamaBarang LIKE @cari";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@cari", "%" + keyword + "%");
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            return dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Gagal mencari barang di database.", ex);
                }
            }
        }
        public static void UpdateBarang(int id,string namaBarang, string merek, decimal harga, int stok)
        {
            using (SqlConnection con = koneksi.GetConnection())
            {
                con.Open();
                string query = "UPDATE Barang SET NamaBarang=@NamaBarang,Merek=@Merek, Harga=@Harga, Stok=@Stok WHERE id=@id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@NamaBarang", namaBarang);
                    cmd.Parameters.AddWithValue("@Merek", merek);
                    cmd.Parameters.AddWithValue("@Harga", harga);
                    cmd.Parameters.AddWithValue("@Stok", stok);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteBarang(int id)
        {
            using (SqlConnection con = koneksi.GetConnection())
            {
                con.Open();
                string query = "DELETE FROM Barang WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static DataTable GetAllBarang()
        {
            using (SqlConnection con = koneksi.GetConnection())
            {
                con.Open();
                string query = "SELECT * FROM Barang";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }


    }
}
