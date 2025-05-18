using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemTokoPm
{
    internal class AkunService
    {
        public static void InsertAkun(string nama, string username, string password, string jabatan)
        {
            using (SqlConnection conn = koneksi.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Akun (Nama, Username, Password, Jabatan) VALUES (@nama, @username, @password, @Jabatan)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nama", nama);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@Jabatan", jabatan);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Akun berhasil ditambahkan!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        public static string Login(string username, string password, string jabatan)
        {
            using (SqlConnection conn = koneksi.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Jabatan FROM Akun WHERE Username=@username AND Password=@password AND Jabatan=@jabatan";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@jabatan", jabatan);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return reader["Jabatan"].ToString();
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return null;
                }
            }
        }
    }
}
