using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SistemTokoPm
{
    public partial class FormDaftarHadir : Form
    {
        public FormDaftarHadir()
        {
            InitializeComponent();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                KehadiranRepository.InsertKehadiran(int.Parse(txtId.Text),txtNamaKaryawan.Text, dateTimePicker1.Value, cmbStatus.Text);
                MessageBox.Show("Record Inserted Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void FormDaftarHadir_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Hadir");
            cmbStatus.Items.Add("Izin");
            cmbStatus.Items.Add("Sakit");
            cmbStatus.Items.Add("Alfa");
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
          
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
           
        }
    }
}
