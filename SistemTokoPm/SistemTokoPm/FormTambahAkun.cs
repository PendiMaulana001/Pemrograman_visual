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

namespace SistemTokoPm
{
    public partial class FormTambahAkun : Form
    {
        public FormTambahAkun()
        {
            InitializeComponent();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = koneksi.GetConnection())
            {
                if (txtNama.Text == "" || txtUsername.Text == "" || txtPassword.Text == "" || cmbJabatan.SelectedItem == null)
                {
                    MessageBox.Show("Data belum lengkap!");
                    return;
                }

                AkunService.InsertAkun(txtNama.Text, txtUsername.Text, txtPassword.Text, cmbJabatan.SelectedItem.ToString());
                this.Close();
            }

        }

        private void FormTambahAkun_Load(object sender, EventArgs e)
        {
            cmbJabatan.Items.Add("Admin");
            cmbJabatan.Items.Add("Karyawan");
            cmbJabatan.Items.Add("Manager");
        }
    }
}
