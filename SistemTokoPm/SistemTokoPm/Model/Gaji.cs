using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemTokoPm.Model
{
    internal class Gaji
    {
        public string NamaKaryawan { get; set; }
        public decimal GajiPokok { get; set; }
        public decimal Tunjangan { get; set; }
        public decimal Potongan { get; set; }
        public decimal TotalGaji
        {
            get { return GajiPokok + Tunjangan - Potongan; }
        }
    }
}
