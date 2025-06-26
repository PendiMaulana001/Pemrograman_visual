using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemTokoPm.Model;

namespace SistemTokoPm
{
    public partial class FormDaftarGaji : Form
    {
        public FormDaftarGaji()
        {
            InitializeComponent();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            try
            {
                decimal gajiPokok = decimal.Parse(txtGajiPokok.Text);
                decimal tunjangan = decimal.Parse(txtTunjangan.Text);
                decimal potongan = decimal.Parse(txtPotongan.Text);

                decimal totalGaji = gajiPokok + tunjangan - potongan;

                txtTotalGaji.Text = totalGaji.ToString("N2");
            }
            catch
            {
                MessageBox.Show("Masukkan angka yang valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                var gaji = new Gaji
                {
                    NamaKaryawan = txtNama.Text,
                    GajiPokok = decimal.Parse(txtGajiPokok.Text),
                    Tunjangan = decimal.Parse(txtTunjangan.Text),
                    Potongan = decimal.Parse(txtPotongan.Text)
                };

                // TotalGaji sudah property readonly jadi langsung baca saja
                txtTotalGaji.Text = gaji.TotalGaji.ToString("N2");

                var repo = new GajiRepository();
                repo.SimpanGaji(gaji);

                MessageBox.Show("Data berhasil disimpan.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }
    }
}
