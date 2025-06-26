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
    public partial class FormLogin : Form
    {
        private AkunController controller = new AkunController();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnTambahAkun_Click(object sender, EventArgs e)
        {
            FormTambahAkun tambahAkun = new FormTambahAkun();
            tambahAkun.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string jabatanDipilih = cmbJabatan.SelectedItem?.ToString();

            string Jabatan = controller.Login(username, password, jabatanDipilih);

            if (Jabatan == "Admin")
            {
                new FormDashboardAdmin().Show();
                this.Hide();
            }
            else if (Jabatan == "Manager")
            {
                new FormDashboardManager().Show();
                this.Hide();
            }
            else if (Jabatan == "Karyawan")
            {
                new FormDashboardKaryawan().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username, password, atau jabatan salah.");
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            cmbJabatan.Items.Add("Admin");
            cmbJabatan.Items.Add("Karyawan");
            cmbJabatan.Items.Add("Manager");
        }
    }
}
