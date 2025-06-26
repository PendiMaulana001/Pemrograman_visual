using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemTokoPm.Model;


namespace SistemTokoPm.Model
{
    internal class KehadiranRepository
    {
        private static void WithConnection(Action<SqlConnection> action)
        {
            using (SqlConnection con = koneksi.GetConnection())
            {
                con.Open();
                action(con);
            }
        }

        private static T WithConnection<T>(Func<SqlConnection, T> func)
        {
            using (SqlConnection con = koneksi.GetConnection())
            {
                con.Open();
                return func(con);
            }
        }
        public static void InsertKehadiran(Kehadiran kehadiran)
        {
            WithConnection(con =>
            {
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO KehadiranKaryawan (Id, NamaKaryawan, Tanggal, StatusHadir) " +
                    "VALUES (@Id, @NamaKaryawan, @Tanggal, @StatusHadir)", con);

                cmd.Parameters.AddWithValue("@Id", kehadiran.Id);
                cmd.Parameters.AddWithValue("@NamaKaryawan", kehadiran.NamaKaryawan);
                cmd.Parameters.AddWithValue("@Tanggal", kehadiran.Tanggal.Date);
                cmd.Parameters.AddWithValue("@StatusHadir", kehadiran.StatusHadir);

                cmd.ExecuteNonQuery();
            });
        }

        public static void UpdateKehadiran(Kehadiran kehadiran)
        {
            WithConnection(con =>
            {
                SqlCommand cmd = new SqlCommand(
                    "UPDATE KehadiranKaryawan SET NamaKaryawan = @NamaKaryawan, Tanggal = @Tanggal, StatusHadir = @StatusHadir WHERE ID = @ID",
                    con);

                cmd.Parameters.AddWithValue("@ID", kehadiran.Id);
                cmd.Parameters.AddWithValue("@NamaKaryawan", kehadiran.NamaKaryawan);
                cmd.Parameters.AddWithValue("@Tanggal", kehadiran.Tanggal.Date);
                cmd.Parameters.AddWithValue("@StatusHadir", kehadiran.StatusHadir);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected == 0)
                    throw new Exception("Data tidak ditemukan untuk diupdate.");
            });
        }

        public static void DeleteKehadiran(int id)
        {
            WithConnection(con =>
            {
                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM KehadiranKaryawan WHERE ID = @ID", con);

                cmd.Parameters.AddWithValue("@ID", id);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected == 0)
                    throw new Exception("Data dengan ID tersebut tidak ditemukan untuk dihapus.");
            });
        }

        public static DataTable CariKehadiranByNama(string namaKaryawan)
        {
            return WithConnection(con =>
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT * FROM KehadiranKaryawan WHERE NamaKaryawan LIKE @NamaKaryawan", con);

                cmd.Parameters.AddWithValue("@NamaKaryawan", "%" + namaKaryawan + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            });
        }

        public static DataTable GetAllKehadiran()
        {
            return WithConnection(con =>
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM KehadiranKaryawan", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            });
        }
    }
}
