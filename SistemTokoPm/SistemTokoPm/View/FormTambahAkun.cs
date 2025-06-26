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
using SistemTokoPm.Controller;
using SistemTokoPm.Model;

namespace SistemTokoPm
{
    public partial class FormTambahAkun : Form
    {
        private AkunController controller = new AkunController();
        public FormTambahAkun()
        {
            InitializeComponent();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txtNama.Text == "" || txtUsername.Text == "" || txtPassword.Text == "" || cmbJabatan.SelectedItem == null)
            {
                MessageBox.Show("Data belum lengkap!");
                return;
            }

            Akun akun = new Akun()
            {
                Nama = txtNama.Text,
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                Jabatan = cmbJabatan.SelectedItem.ToString()
            };

            controller.TambahAkun(akun);
            MessageBox.Show("Akun berhasil ditambahkan!");
            this.Close();

        }

        private void FormTambahAkun_Load(object sender, EventArgs e)
        {
            cmbJabatan.Items.Add("Admin");
            cmbJabatan.Items.Add("Karyawan");
            cmbJabatan.Items.Add("Manager");
        }
    }
}
