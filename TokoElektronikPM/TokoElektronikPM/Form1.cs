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
            if (string.IsNullOrWhiteSpace(txtNama.Text) ||
                string.IsNullOrWhiteSpace(txtMerek.Text) ||
                string.IsNullOrWhiteSpace(txtHarga.Text) ||
                string.IsNullOrWhiteSpace(txtStok.Text))
            {
                MessageBox.Show("Semua field harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


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
            if (string.IsNullOrWhiteSpace(txtNama.Text))
            {
                MessageBox.Show("Pilih data yang ingin diubah dari tabel!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal harga;
            int stok;

            if (!decimal.TryParse(txtHarga.Text, out harga))
            {
                MessageBox.Show("Harga tidak valid. Pastikan hanya angka yang dimasukkan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtStok.Text, out stok))
            {
                MessageBox.Show("Stok tidak valid. Pastikan hanya angka yang dimasukkan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Barang SET Merek=@Merek, Harga=@Harga, Stok=@Stok WHERE NamaBarang=@NamaBarang", con);
                cmd.Parameters.AddWithValue("@NamaBarang", txtNama.Text);
                cmd.Parameters.AddWithValue("@Merek", txtMerek.Text);
                cmd.Parameters.AddWithValue("@Harga", harga);   
                cmd.Parameters.AddWithValue("@Stok", stok);    
                cmd.ExecuteNonQuery();
                con.Close();
                TampilData();
                MessageBox.Show("Data berhasil diubah");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }



        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNama.Text))
            {
                MessageBox.Show("Pilih data yang ingin dihapus dari tabel!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Barang WHERE NamaBarang=@NamaBarang", con);
                cmd.Parameters.AddWithValue("@NamaBarang", txtNama.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                TampilData();
                MessageBox.Show("Data berhasil dihapus");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtNama.Text = row.Cells["NamaBarang"].Value.ToString();
                txtMerek.Text = row.Cells["Merek"].Value.ToString();
                txtHarga.Text = row.Cells["Harga"].Value.ToString();
                txtStok.Text = row.Cells["Stok"].Value.ToString();
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtNama.Text = row.Cells[1].Value.ToString();   
                txtMerek.Text = row.Cells[2].Value.ToString();  
                txtHarga.Text = row.Cells[3].Value.ToString(); 
                txtStok.Text = row.Cells[4].Value.ToString();   
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Barang WHERE NamaBarang LIKE @cari", con);
            cmd.Parameters.AddWithValue("@cari", "%" + txtCari.Text + "%");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
