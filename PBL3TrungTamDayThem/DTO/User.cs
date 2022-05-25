using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3TrungTamDayThem.DTO
{
    public class User
    {
        private string _MaNV;
        private string _Username;
        private string _Pass;
        private string _DisplayName;
        private bool _PhanQuyen;
        private string _Anh;

        public string MaNV { get => _MaNV; set => _MaNV = value; }
        public string Username { get => _Username; set => _Username = value; }
        public string Pass { get => _Pass; set => _Pass = value; }
        public string DisplayName { get => _DisplayName; set => _DisplayName = value; }
        public bool PhanQuyen { get => _PhanQuyen; set => _PhanQuyen = value; }
        public string Anh { get => _Anh; set => _Anh = value; }
    }
}
