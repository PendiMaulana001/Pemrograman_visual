using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemTokoPm
{
    internal class GajiRepository
    {
        public class GajiKaryawan
        {
            public string NamaKaryawan { get; set; }
            public decimal GajiPokok { get; set; }
            public decimal Tunjangan { get; set; }
            public decimal Potongan { get; set; }
            public decimal TotalGaji
            {
                get
                {
                    return GajiPokok + Tunjangan - Potongan;
                }
            }
        }

        public void SimpanGaji(GajiKaryawan gaji)
        {
            using (SqlConnection conn = koneksi.GetConnection())
            {
                conn.Open();

                string query = "INSERT INTO GajiKaryawan (NamaKaryawan, GajiPokok, Tunjangan, Potongan, TotalGaji) " +
                               "VALUES (@Nama, @GajiPokok, @Tunjangan, @Potongan, @TotalGaji)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nama", gaji.NamaKaryawan);
                    cmd.Parameters.AddWithValue("@GajiPokok", gaji.GajiPokok);
                    cmd.Parameters.AddWithValue("@Tunjangan", gaji.Tunjangan);
                    cmd.Parameters.AddWithValue("@Potongan", gaji.Potongan);
                    cmd.Parameters.AddWithValue("@TotalGaji", gaji.TotalGaji);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public DataTable AmbilSemuaGaji()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = koneksi.GetConnection())
            {
                conn.Open();
                string query = "SELECT Id, NamaKaryawan, GajiPokok, Tunjangan, Potongan, TotalGaji FROM GajiKaryawan";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.Fill(dt);
                }
            }
            return dt;
        }
        public void UpdateGaji(int id, GajiKaryawan gaji)
        {
            using (SqlConnection conn = koneksi.GetConnection())
            {
                conn.Open();
                string query = "UPDATE GajiKaryawan SET NamaKaryawan=@Nama, GajiPokok=@GajiPokok, Tunjangan=@Tunjangan, Potongan=@Potongan, TotalGaji=@TotalGaji WHERE Id=@Id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Nama", gaji.NamaKaryawan);
                    cmd.Parameters.AddWithValue("@GajiPokok", gaji.GajiPokok);
                    cmd.Parameters.AddWithValue("@Tunjangan", gaji.Tunjangan);
                    cmd.Parameters.AddWithValue("@Potongan", gaji.Potongan);
                    cmd.Parameters.AddWithValue("@TotalGaji", gaji.TotalGaji);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void HapusGaji(int id)
        {
            using (SqlConnection conn = koneksi.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM GajiKaryawan WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public DataTable CariGajiByNama(string nama)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = koneksi.GetConnection())
            {
                conn.Open();
                string query = "SELECT Id, NamaKaryawan, GajiPokok, Tunjangan, Potongan, TotalGaji FROM GajiKaryawan WHERE NamaKaryawan LIKE @Nama";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nama", "%" + nama + "%");
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            return dt;
        }
    }
}
