using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemTokoPm.Model
{
    internal class Kehadiran
    {
        public int Id { get; set; }
        public string NamaKaryawan { get; set; }
        public DateTime Tanggal { get; set; }
        public string StatusHadir { get; set; }
    }
}
