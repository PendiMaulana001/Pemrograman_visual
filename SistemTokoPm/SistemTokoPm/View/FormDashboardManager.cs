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
    public partial class FormDashboardManager : Form
    {
        public FormDashboardManager()
        {
            InitializeComponent();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin Keluar = new FormLogin();
            Keluar.ShowDialog();
        }

        private void btnDaftarBarang_Click(object sender, EventArgs e)
        {
            FormDataBarang DataBarang = new FormDataBarang();
            DataBarang.ShowDialog();
        }

        private void btnDaftarHadir_Click(object sender, EventArgs e)
        {
            FormDaftarHadir DaftarHadir = new FormDaftarHadir();
            DaftarHadir.ShowDialog();
        }

        private void btnDataHadir_Click(object sender, EventArgs e)
        {
            FormDataHadir DataHadir = new FormDataHadir();
            DataHadir.ShowDialog();
        }

        private void btnDaftarGaji_Click(object sender, EventArgs e)
        {
            FormDaftarGaji DaftarGaji = new FormDaftarGaji();
            DaftarGaji.ShowDialog();
        }

        private void btnGajiKaryawan_Click(object sender, EventArgs e)
        {
            FormDataGaji DataGaji = new FormDataGaji();
            DataGaji.ShowDialog();
        }
    }
}
