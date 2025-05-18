using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemTokoPm
{
    internal class KehadiranRepository
    {
        public static void InsertKehadiran(int id, string namaKaryawan, DateTime tanggal, string statusHadir)
        {
            using (SqlConnection con = koneksi.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO KehadiranKaryawan (id, NamaKaryawan, Tanggal, StatusHadir) VALUES (@id, @NamaKaryawan, @Tanggal, @StatusHadir)",
                    con);

                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@NamaKaryawan", namaKaryawan);
                cmd.Parameters.AddWithValue("@Tanggal", tanggal.Date);
                cmd.Parameters.AddWithValue("@StatusHadir", statusHadir);

                cmd.ExecuteNonQuery();
            }
        }
        public static void UpdateKehadiran(int id, string namaKaryawan, DateTime tanggal, string statusHadir)
        {
            using (SqlConnection con = koneksi.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE KehadiranKaryawan SET NamaKaryawan = @NamaKaryawan, Tanggal = @Tanggal, StatusHadir = @StatusHadir WHERE ID = @ID",
                    con);

                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@NamaKaryawan", namaKaryawan);
                cmd.Parameters.AddWithValue("@Tanggal", tanggal.Date);
                cmd.Parameters.AddWithValue("@StatusHadir", statusHadir);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected == 0)
                    throw new Exception("Data tidak ditemukan untuk diupdate.");
            }
        }

        // DELETE
        public static void DeleteKehadiran(int id)
        {
            using (SqlConnection con = koneksi.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM KehadiranKaryawan WHERE ID = @ID",
                    con);

                cmd.Parameters.AddWithValue("@ID", id);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected == 0)
                    throw new Exception("Data dengan ID tersebut tidak ditemukan untuk dihapus.");
            }
        }
        public static DataTable CariKehadiranByNama(string namaKaryawan)
        {
            using (SqlConnection con = koneksi.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "SELECT * FROM KehadiranKaryawan WHERE NamaKaryawan LIKE @NamaKaryawan", con);

                cmd.Parameters.AddWithValue("@NamaKaryawan", "%" + namaKaryawan + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
        }
        public static DataTable GetAllKehadiran()
        {
            using (SqlConnection con = koneksi.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM KehadiranKaryawan", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}
