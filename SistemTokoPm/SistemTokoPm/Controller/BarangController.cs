using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemTokoPm.Model;
using System.Data;

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
    }
}
