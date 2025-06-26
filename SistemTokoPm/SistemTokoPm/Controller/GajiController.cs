using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemTokoPm.Model;

namespace SistemTokoPm.Model
{
    internal class GajiController
    {
        private readonly GajiRepository _repository;

        public GajiController()
        {
            _repository = new GajiRepository();
        }

        public void Simpan(Gaji gaji)
        {
            _repository.SimpanGaji(gaji);
        }

        public DataTable TampilkanSemua()
        {
            return _repository.AmbilSemuaGaji();
        }

        public void Perbarui(int id, Gaji gaji)
        {
            _repository.UpdateGaji(id, gaji);
        }

        public void Hapus(int id)
        {
            _repository.HapusGaji(id);
        }

        public DataTable Cari(string nama)
        {
            return _repository.CariGajiByNama(nama);
        }
    }
}
