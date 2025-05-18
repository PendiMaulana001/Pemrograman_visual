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
    public partial class FormDataHadir : Form
    {
        public FormDataHadir()
        {
            InitializeComponent();
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            dataGridView1.KeyDown += dataGridView1_KeyDown;
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            try
            {
                string namaDicari = txtCariNamaKaryawan.Text.Trim();
                DataTable hasil = KehadiranRepository.CariKehadiranByNama(namaDicari);
                dataGridView1.DataSource = hasil;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
                    string nama = dataGridView1.Rows[row].Cells["NamaKaryawan"].Value.ToString();
                    DateTime tanggal = Convert.ToDateTime(dataGridView1.Rows[row].Cells["Tanggal"].Value);
                    string status = dataGridView1.Rows[row].Cells["StatusHadir"].Value.ToString();

                    KehadiranRepository.UpdateKehadiran(id, nama, tanggal, status);
                    LoadData();
                    MessageBox.Show("Data berhasil diperbarui.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal update: " + ex.Message);
                }
            }

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                    KehadiranRepository.DeleteKehadiran(id);
                    LoadData();
                    MessageBox.Show("Data berhasil dihapus.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal hapus: " + ex.Message);
                }
            }

        }

        private void FormDataHadir_Load(object sender, EventArgs e)
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
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = KehadiranRepository.GetAllKehadiran();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message);
            }
        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
                string nama = dataGridView1.Rows[e.RowIndex].Cells["NamaKaryawan"].Value.ToString();
                DateTime tanggal = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["Tanggal"].Value);
                string status = dataGridView1.Rows[e.RowIndex].Cells["StatusHadir"].Value.ToString();

                KehadiranRepository.UpdateKehadiran(id, nama, tanggal, status);
                MessageBox.Show("Data berhasil diperbarui.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal update: " + ex.Message);
            }
        }

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
                        KehadiranRepository.DeleteKehadiran(id);
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
    }
}
