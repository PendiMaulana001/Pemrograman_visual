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
    public partial class FormTambahBarang : Form
    {
        public FormTambahBarang()
        {
            InitializeComponent();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtId.Text);
                string nama = txtNamaBarang.Text;
                string merek = txtMerek.Text;
                decimal harga = decimal.Parse(txtHarga.Text);
                int stok = int.Parse(txtStok.Text);

                BarangRepository.InsertBarang(id,nama, merek, harga, stok);

                MessageBox.Show("Data berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtId.Clear();
                txtNamaBarang.Clear();
                txtMerek.Clear();
                txtHarga.Clear();
                txtStok.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
         

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
