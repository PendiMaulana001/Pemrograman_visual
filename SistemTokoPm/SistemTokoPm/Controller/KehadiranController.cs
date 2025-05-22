using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemTokoPm.Model;

namespace SistemTokoPm.Controller
{
    internal class KehadiranController
    {
        public void TambahKehadiran(Kehadiran kehadiran)
        {
            KehadiranRepository.InsertKehadiran(kehadiran);
        }

        public void UpdateKehadiran(Kehadiran kehadiran)
        {
            KehadiranRepository.UpdateKehadiran(kehadiran);
        }

        public void HapusKehadiran(int id)
        {
            KehadiranRepository.DeleteKehadiran(id);
        }
    }
}
