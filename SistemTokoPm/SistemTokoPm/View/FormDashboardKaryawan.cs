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
    public partial class FormDashboardKaryawan : Form
    {
        public FormDashboardKaryawan()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin Keluar = new FormLogin();
            Keluar.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormTambahBarang TambahBarang = new FormTambahBarang();
            TambahBarang.ShowDialog();
        }

        private void btnCariBarang_Click(object sender, EventArgs e)
        {
            FormCariBarang CariBarang = new FormCariBarang();
            CariBarang.ShowDialog();
        }
    }
}
