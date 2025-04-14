using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TokoElektronikPM
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=DESKTOP-HAIN24I\TIKET;Initial Catalog=ElektronikDB;Integrated Security=True;";
        int selectedID = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void TampilData()
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Barang", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }


        private void btnTambah_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Barang (NamaBarang, Merek, Harga, Stok) VALUES (@Nama, @Merek, @Harga, @Stok)", con);
            cmd.Parameters.AddWithValue("@Nama", txtNama.Text);
            cmd.Parameters.AddWithValue("@Merek", txtMerek.Text);
            cmd.Parameters.AddWithValue("@Harga", decimal.Parse(txtHarga.Text));
            cmd.Parameters.AddWithValue("@Stok", int.Parse(txtStok.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            TampilData();
            MessageBox.Show("Data berhasil ditambahkan");


        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Barang", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Barang SET Merek=@Merek, Harga=@Harga, Stok=@Stok WHERE NamaBarang=@NamaBarang", con);
            cmd.Parameters.AddWithValue("@NamaBarang", txtNama.Text);
            cmd.Parameters.AddWithValue("@Merek", txtMerek.Text);
            cmd.Parameters.AddWithValue("@Harga", txtHarga.Text);
            cmd.Parameters.AddWithValue("@Stok", txtStok.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            TampilData();
            MessageBox.Show("Data berhasil diubah");

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Barang WHERE NamaBarang=@NamaBarang", con);
            cmd.Parameters.AddWithValue("@NamaBarang", txtNama.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            TampilData();
            MessageBox.Show("Data berhasil dihapus");



        }
    }
}
