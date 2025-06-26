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
    public partial class FormDashboardAdmin : Form
    {
        public FormDashboardAdmin()
        {
            InitializeComponent();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin Keluar = new FormLogin();
            Keluar.ShowDialog();
        }

        private void btnTambahBarang_Click(object sender, EventArgs e)
        {
            FormTambahBarang TambahBarang = new FormTambahBarang();
            TambahBarang.ShowDialog();
        }

        private void btnDataBarang_Click(object sender, EventArgs e)
        {
            FormDataBarang DataBarang = new FormDataBarang();
            DataBarang.ShowDialog();
        }

        private void btnDaftarHadir_Click(object sender, EventArgs e)
        {
            FormDaftarHadir DaftarHadir = new FormDaftarHadir();
            DaftarHadir.ShowDialog();
        }
    }
}
