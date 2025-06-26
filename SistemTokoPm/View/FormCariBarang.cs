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

namespace SistemTokoPm
{
    public partial class FormCariBarang : Form
    {
        private BarangController controller = new BarangController();
        public FormCariBarang()
        {
            InitializeComponent();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            string keyword = txtCari.Text;
            DataTable hasil = controller.CariBarang(keyword);
            dataGridView1.DataSource = hasil;
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCariBarang_Load(object sender, EventArgs e)
        {

        }
    }
}
