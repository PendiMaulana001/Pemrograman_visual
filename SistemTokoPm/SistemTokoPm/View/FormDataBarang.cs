using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemTokoPm.Controller;
using SistemTokoPm.Model;

namespace SistemTokoPm
{
    public partial class FormDataBarang : Form
    {
        private BarangController controller = new BarangController();
        public FormDataBarang()
        {
            InitializeComponent();
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            dataGridView1.KeyDown += dataGridView1_KeyDown;
        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                try
                {
                    controller.HapusBarang(id);
                    LoadData();
                    MessageBox.Show("Data berhasil dihapus.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal hapus: " + ex.Message);
                }
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    int row = dataGridView1.SelectedRows[0].Index;
                    int id = Convert.ToInt32(dataGridView1.Rows[row].Cells["Id"].Value);
                    string namaBarang = dataGridView1.Rows[row].Cells["NamaBarang"].Value.ToString();
                    string merek = dataGridView1.Rows[row].Cells["Merek"].Value.ToString();
                    decimal harga = Convert.ToDecimal(dataGridView1.Rows[row].Cells["Harga"].Value);
                    int stok = Convert.ToInt32(dataGridView1.Rows[row].Cells["Stok"].Value);

                    Barang barang = new Barang { Id = id, NamaBarang = namaBarang, Merek = merek, Harga = harga, Stok = stok };
                    controller.UpdateBarang(barang);
                    LoadData();
                    MessageBox.Show("Data berhasil diperbarui.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal update: " + ex.Message);
                }
            }

        }

        private void FormDataBarang_Load(object sender, EventArgs e)
        {
            LoadData();
            if (dataGridView1.Columns.Contains("Id"))
            {
                dataGridView1.Columns["Id"].ReadOnly = true;
            }
        }
        private void LoadData()
        {
            try
            {
                dataGridView1.AutoGenerateColumns = true; // otomatis tampilkan semua kolom
                dataGridView1.DataSource = BarangRepository.GetAllBarang();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
                string namaBarang = dataGridView1.Rows[e.RowIndex].Cells["NamaBarang"].Value.ToString();
                string merek = dataGridView1.Rows[e.RowIndex].Cells["Merek"].Value.ToString();
                decimal harga = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["Harga"].Value);
                int stok = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Stok"].Value);

                Barang barang = new Barang { Id = id, NamaBarang = namaBarang, Merek = merek, Harga = harga, Stok = stok };
                controller.UpdateBarang(barang);
                MessageBox.Show("Data berhasil diperbarui.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal update: " + ex.Message);
            }
        }

        // Event: tekan tombol delete
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Hapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                        controller.HapusBarang(id);
                        LoadData();
                        MessageBox.Show("Data berhasil dihapus.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Gagal hapus: " + ex.Message);
                    }
                }
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            string keyword = txtCari.Text;
            DataTable hasil = BarangRepository.CariBarang(keyword);
            dataGridView1.DataSource = hasil;
        }
    }

}
