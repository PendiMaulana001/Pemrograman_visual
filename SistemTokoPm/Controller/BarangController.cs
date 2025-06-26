using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemTokoPm.Model;
using System.Data;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace SistemTokoPm.Controller
{
    internal class BarangController
    {
        public void TambahBarang(Barang barang)
        {
            BarangRepository.InsertBarang(barang);
        }

        public void UpdateBarang(Barang barang)
        {
            BarangRepository.UpdateBarang(barang);
        }

        public void HapusBarang(int id)
        {
            BarangRepository.DeleteBarang(id);
        }

        public DataTable TampilkanSemua()
        {
            return BarangRepository.GetAllBarang();
        }

        public DataTable CariBarang(string keyword)
        {
            return BarangRepository.CariBarang(keyword);
        }
        public List<Barang> AmbilSemuaBarang()
        {
            return BarangRepository.GetAllBarangList(); 
        }
        public void CetakDataBarangKePdf()
        {
            List<Barang> list = BarangRepository.GetAllBarangList();

            string html = "<h1>Data Barang</h1>";
            html += "<table border='1' cellpadding='5' cellspacing='0'>";
            html += "<tr>" +
                        "<th>Kode</th>" +
                        "<th>Nama Barang</th>" +
                        "<th>Merek</th>" +
                        "<th>Harga</th>" +
                        "<th>Stok</th>" +
                    "</tr>";

            foreach (var b in list)
            {
                html += "<tr>";
                html += $"<td>{b.Id}</td>";
                html += $"<td>{b.NamaBarang}</td>";
                html += $"<td>{b.Merek}</td>";
                html += $"<td>{b.Harga.ToString("N2", new CultureInfo("id-ID"))}</td>";
                html += $"<td>{b.Stok}</td>";
                html += "</tr>";
            }

            html += "</table>";

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF File|*.pdf";
            sfd.Title = "Simpan Laporan Barang";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(sfd.FileName, FileMode.Create))
                {
                    using (Document doc = new Document())
                    {
                        PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                        doc.Open();
                        using (StringReader sr = new StringReader(html))
                        {
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, doc, sr);
                        }
                        doc.Close();
                    }
                }

                MessageBox.Show("Laporan PDF berhasil disimpan!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
