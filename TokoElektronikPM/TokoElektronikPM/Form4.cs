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
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TokoElektronikPM
{
    
    public partial class Form4 : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=ElektronikDB;Integrated Security=True";
        int selectedID = 0;
        public Form4()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HAIN24I\TIKET;Initial Catalog=ElektronikDB;TrustServerCertificate=True;Integrated Security=True;");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO KehadiranKaryawan (ID,NamaKaryawan, Tanggal, StatusHadir) VALUES (@ID,@NamaKaryawan, @Tanggal, @StatusHadir)", con);
                cmd.Parameters.AddWithValue("@ID", int.Parse(ID.Text));
                cmd.Parameters.AddWithValue("@NamaKaryawan", nama.Text);
                cmd.Parameters.AddWithValue("@Tanggal",tanggal.Value.Date);
                cmd.Parameters.AddWithValue("@StatusHadir", comboBoxStatus.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Inserted Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HAIN24I\TIKET;InitialCatalog=ElektronikDB;TrustServerCertificate=True;IntegratedSecurity=True;");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE KehadiranKaryawan SET NamaKaryawan=@NamaKaryawan, Tanggal=@Tanggal, StatusHadir=@StatusHadir WHERE ID=@ID", con);
                cmd.Parameters.AddWithValue("@ID", int.Parse(ID.Text));
                cmd.Parameters.AddWithValue("@NamaKaryawan", nama.Text);
                cmd.Parameters.AddWithValue("@Tanggal", tanggal.Value.Date);
                cmd.Parameters.AddWithValue("@StatusHadir", comboBoxStatus.Text);

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Record Updated Successfully!");
                }
                else
                {
                    MessageBox.Show("No Record Found with that ID!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // pastikan kliknya bukan header
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                ID.Text = row.Cells["ID"].Value.ToString();
                nama.Text = row.Cells["NamaKaryawan"].Value.ToString();
                tanggal.Value = Convert.ToDateTime(row.Cells["Tanggal"].Value);
                comboBoxStatus.Text = row.Cells["StatusHadir"].Value.ToString();
            }

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HAIN24I\TIKET;Initial Catalog=ElektronikDB;TrustServerCertificate=True;IntegratedSecurity=True;");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM KehadiranKaryawan WHERE ID = @ID", con);
                cmd.Parameters.AddWithValue("@ID", int.Parse(ID.Text));

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Record Deleted Successfully!");
                }
                else
                {
                    MessageBox.Show("No Record Found with that ID!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            comboBoxStatus.Items.Clear(); 
            comboBoxStatus.Items.Add("Hadir");
            comboBoxStatus.Items.Add("Izin");
            comboBoxStatus.Items.Add("Sakit");
            comboBoxStatus.Items.Add("Alfa");
        }

        private void Tampilkan_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HAIN24I\TIKET;Initial Catalog=ElektronikDB;TrustServerCertificate=True;Integrated Security=True;");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM KehadiranKaryawan", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Barang WHERE NamaKaryawan LIKE @cari", con);
            cmd.Parameters.AddWithValue("@cari", "%" + textBoxCariKaryawan.Text + "%");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
