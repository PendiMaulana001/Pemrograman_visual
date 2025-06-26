using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemTokoPm.Model
{
    internal class Barang
    {
        public int Id { get; set; }
        public string NamaBarang { get; set; }
        public string Merek { get; set; }
        public decimal Harga { get; set; }
        public int Stok { get; set; }
    }
}
