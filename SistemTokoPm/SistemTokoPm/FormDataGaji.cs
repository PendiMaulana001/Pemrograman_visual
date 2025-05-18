using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemTokoPm
{
    public partial class FormDataGaji : Form
    {
        GajiRepository repo = new GajiRepository();
        public FormDataGaji()
        {
            InitializeComponent();
            this.Load += FormDataGaji_Load;
            dataGridViewGaji.CellEndEdit += DataGridViewGaji_CellEndEdit;
            dataGridViewGaji.KeyDown += DataGridViewGaji_KeyDown;
            btnCari.Click += btnCari_Click;
            bntHapus.Click += bntHapus_Click;
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            GajiRepository repo = new GajiRepository();
            dataGridViewGaji.DataSource = repo.AmbilSemuaGaji();
        }

        private void bntHapus_Click(object sender, EventArgs e)
        {
            if (dataGridViewGaji.SelectedRows.Count > 0)
            {
                try
                {
                    int id = Convert.ToInt32(dataGridViewGaji.SelectedRows[0].Cells["Id"].Value);
                    repo.HapusGaji(id);
                    LoadData();
                    MessageBox.Show("Data berhasil dihapus.", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
  
                    MessageBox.Show("Gagal hapus: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Pilih data yang ingin dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void FormDataGaji_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                dataGridViewGaji.DataSource = repo.AmbilSemuaGaji();
                dataGridViewGaji.Columns["Id"].ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message);
            }
        }
        private void DataGridViewGaji_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var row = dataGridViewGaji.Rows[e.RowIndex];
                int id = Convert.ToInt32(row.Cells["Id"].Value);
                string nama = row.Cells["NamaKaryawan"].Value.ToString();
                decimal gajiPokok = Convert.ToDecimal(row.Cells["GajiPokok"].Value);
                decimal tunjangan = Convert.ToDecimal(row.Cells["Tunjangan"].Value);
                decimal potongan = Convert.ToDecimal(row.Cells["Potongan"].Value);
                decimal total = gajiPokok + tunjangan - potongan;

                GajiRepository.GajiKaryawan gaji = new GajiRepository.GajiKaryawan
                {
                    NamaKaryawan = nama,
                    GajiPokok = gajiPokok,
                    Tunjangan = tunjangan,
                    Potongan = potongan
                };

                repo.UpdateGaji(id, gaji);
                LoadData();
                MessageBox.Show("Data berhasil diperbarui.", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal update: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridViewGaji_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dataGridViewGaji.SelectedRows.Count > 0)
            {
                try
                {
                    int id = Convert.ToInt32(dataGridViewGaji.SelectedRows[0].Cells["Id"].Value);
                    repo.HapusGaji(id);
                    LoadData();
                    MessageBox.Show("Data berhasil dihapus.", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal hapus: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            string nama = txtCari.Text.Trim();
            if (string.IsNullOrEmpty(nama))
            {
                LoadData();
                return;
            }

            try
            {
                dataGridViewGaji.DataSource = repo.CariGajiByNama(nama);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal cari data: " + ex.Message);
            }

        }
    }
}
