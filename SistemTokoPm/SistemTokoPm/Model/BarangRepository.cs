using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SistemTokoPm.Model
{
    internal class BarangRepository
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

        public static void InsertBarang(Barang barang)
        {
            WithConnection(conn =>
            {
                string query = "INSERT INTO Barang (Id, NamaBarang, Merek, Harga, Stok) VALUES (@id, @nama, @merek, @harga, @stok)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", barang.Id);
                cmd.Parameters.AddWithValue("@nama", barang.NamaBarang);
                cmd.Parameters.AddWithValue("@merek", barang.Merek);
                cmd.Parameters.AddWithValue("@harga", barang.Harga);
                cmd.Parameters.AddWithValue("@stok", barang.Stok);
                cmd.ExecuteNonQuery();
            });
        }

        public static void UpdateBarang(Barang barang)
        {
            WithConnection(conn =>
            {
                string query = "UPDATE Barang SET NamaBarang=@nama, Merek=@merek, Harga=@harga, Stok=@stok WHERE Id=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", barang.Id);
                cmd.Parameters.AddWithValue("@nama", barang.NamaBarang);
                cmd.Parameters.AddWithValue("@merek", barang.Merek);
                cmd.Parameters.AddWithValue("@harga", barang.Harga);
                cmd.Parameters.AddWithValue("@stok", barang.Stok);
                cmd.ExecuteNonQuery();
            });
        }

        public static void DeleteBarang(int id)
        {
            WithConnection(conn =>
            {
                string query = "DELETE FROM Barang WHERE Id=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            });
        }

        public static DataTable GetAllBarang()
        {
            return WithConnection(conn =>
            {
                string query = "SELECT * FROM Barang";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            });
        }

        public static DataTable CariBarang(string keyword)
        {
            return WithConnection(conn =>
            {
                string query = "SELECT * FROM Barang WHERE NamaBarang LIKE @keyword OR Merek LIKE @keyword";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            });
        }
    }
}
