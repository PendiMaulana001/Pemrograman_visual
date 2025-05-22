using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemTokoPm.Model;

namespace SistemTokoPm.Controller
{
    internal class AkunController
    {
        private AkunRepository repo = new AkunRepository();

        public void TambahAkun(Akun akun)
        {
            repo.InsertAkun(akun);
        }

        public string Login(string username, string password, string jabatan)
        {
            return repo.Login(username, password, jabatan);
        }
    }
}
