using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemTokoPm.Model
{
    internal class AkunRepository
    {
        private SqlConnection conn;

        public AkunRepository()
        {
            conn = koneksi.GetConnection();
        }
        public void InsertAkun(Akun akun)
        {
            conn.Open();
            string query = "INSERT INTO Akun (Nama, Username, Password, Jabatan) VALUES (@nama, @username, @password, @jabatan)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nama", akun.Nama);
            cmd.Parameters.AddWithValue("@username", akun.Username);
            cmd.Parameters.AddWithValue("@password", akun.Password);
            cmd.Parameters.AddWithValue("@jabatan", akun.Jabatan);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public string Login(string username, string password, string jabatan)
        {
            conn.Open();
            string query = "SELECT Jabatan FROM Akun WHERE Username=@username AND Password=@password AND Jabatan=@jabatan";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@jabatan", jabatan);

            SqlDataReader reader = cmd.ExecuteReader();
            string result = null;
            if (reader.Read())
            {
                result = reader["Jabatan"].ToString();
            }
            reader.Close();
            conn.Close();
            return result;
        }
    }
}
