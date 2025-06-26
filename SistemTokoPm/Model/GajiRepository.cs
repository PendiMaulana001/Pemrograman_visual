using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemTokoPm.Model;

namespace SistemTokoPm
{
    internal class GajiRepository
    {
        private static void WithConnection(Action<SqlConnection> action)
        {
            using (SqlConnection conn = koneksi.GetConnection())
            {
                conn.Open();
                action(conn);
            }
        }

        private static T WithConnection<T>(Func<SqlConnection, T> func)
        {
            using (SqlConnection conn = koneksi.GetConnection())
            {
                conn.Open();
                return func(conn);
            }
        }
        public void SimpanGaji(Gaji gaji)
        {
            WithConnection(conn =>
            {
                string query = @"INSERT INTO GajiKaryawan 
                                 (NamaKaryawan, GajiPokok, Tunjangan, Potongan, TotalGaji) 
                                 VALUES (@Nama, @GajiPokok, @Tunjangan, @Potongan, @TotalGaji)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nama", gaji.NamaKaryawan);
                    cmd.Parameters.AddWithValue("@GajiPokok", gaji.GajiPokok);
                    cmd.Parameters.AddWithValue("@Tunjangan", gaji.Tunjangan);
                    cmd.Parameters.AddWithValue("@Potongan", gaji.Potongan);
                    cmd.Parameters.AddWithValue("@TotalGaji", gaji.TotalGaji);
                    cmd.ExecuteNonQuery();
                }
            });
        }

        public DataTable AmbilSemuaGaji()
        {
            return WithConnection(conn =>
            {
                string query = "SELECT Id, NamaKaryawan, GajiPokok, Tunjangan, Potongan, TotalGaji FROM GajiKaryawan";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            });
        }

        public void UpdateGaji(int id, Gaji gaji)
        {
            WithConnection(conn =>
            {
                string query = @"UPDATE GajiKaryawan 
                                 SET NamaKaryawan=@Nama, GajiPokok=@GajiPokok, Tunjangan=@Tunjangan, 
                                     Potongan=@Potongan, TotalGaji=@TotalGaji 
                                 WHERE Id=@Id";
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
            });
        }

        public void HapusGaji(int id)
        {
            WithConnection(conn =>
            {
                string query = "DELETE FROM GajiKaryawan WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            });
        }

        public DataTable CariGajiByNama(string nama)
        {
            return WithConnection(conn =>
            {
                string query = @"SELECT Id, NamaKaryawan, GajiPokok, Tunjangan, Potongan, TotalGaji 
                                 FROM GajiKaryawan 
                                 WHERE NamaKaryawan LIKE @Nama";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nama", "%" + nama + "%");
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            });
        }
    }
}
