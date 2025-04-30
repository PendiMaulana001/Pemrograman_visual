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

namespace TokoElektronikPM
{
    public partial class Form3 : Form
    {
        string connectionString = @"Data Source=DESKTOP-HAIN24I\TIKET;Initial Catalog=ElektronikDB;Integrated Security=True;";

        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNama.Text == "" || txtUsername.Text == "" || txtPassword.Text == "" || cmbJabatan.Text == "")
            {
                MessageBox.Show("Data belum lengkap!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Akun (Nama, Username, Password, Jabatan) VALUES (@nama, @username, @password, @jabatan)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nama", txtNama.Text);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@jabatan", cmbJabatan.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Akun berhasil ditambahkan!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            cmbJabatan.Items.Add("Admin");
            cmbJabatan.Items.Add("Kasir");
            cmbJabatan.Items.Add("Manager");
        }
    }
    }
