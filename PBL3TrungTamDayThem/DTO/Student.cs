using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3TrungTamDayThem.DTO
{
    public class Student
    {
        private string _MaHV;
        private string _HoTenHV;
        private string _NgaySinh;
        private string _GioiTinh;
        private string _DiaChi;
        private string _SDT;
        private string _Email;
        private string _TinhTrang;
        private string _MaLH;

        public string MaHV { get => _MaHV; set => _MaHV = value; }
        public string HoTenHV { get => _HoTenHV; set => _HoTenHV = value; }
        public string NgaySinh { get => _NgaySinh; set => _NgaySinh = value; }
        public string GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public string SDT { get => _SDT; set => _SDT = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string TinhTrang { get => _TinhTrang; set => _TinhTrang = value; }
        public string MaLH { get => _MaLH; set => _MaLH = value; }
    }
}
