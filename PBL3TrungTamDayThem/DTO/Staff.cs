using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3TrungTamDayThem.DTO
{
    public class Staff
    {

        private string _MaNV;
        private string _HoTenNV;
        private DateTime _NgaySinh;
        private string _GioiTinh;
        private string _DiaChi;
        private string _SDT;
        private string _Email;
        private string _ChucVu;
        private DateTime _NgayVaoLam;
        private int _Luong;

        public Staff()
        {
            this._NgaySinh = DateTime.Now;
            this._NgayVaoLam = DateTime.Now;
        }
        public string MaNV { get => _MaNV; set => _MaNV = value; }
        public string HoTenNV { get => _HoTenNV; set => _HoTenNV = value; }
        public DateTime NgaySinh { get => _NgaySinh; set => _NgaySinh = value; }
        public string GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public string SDT { get => _SDT; set => _SDT = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string ChucVu { get => _ChucVu; set => _ChucVu = value; }
        public DateTime NgayVaoLam { get => _NgayVaoLam; set => _NgayVaoLam = value; }
        public int Luong { get => _Luong; set => _Luong = value; }


    }
}
