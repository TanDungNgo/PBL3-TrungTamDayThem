using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3TrungTamDayThem.DTO
{
    public class Teacher
    {
        //private string _MaGV;
        //private string _HoTenGV;

        //private string _GioiTinh;
        //private string _SDT;
        //private string _DiaChi;
        //private string _Email;
        //private string _TrinhDo;
        //private string _ChuyenMon;
        //private string _Luong;

        //public string MaGV { get => _MaGV; set => _MaGV = value; }
        //public string HoTenGV { get => _HoTenGV; set => _HoTenGV = value; }
        //public string NgaySinh { get => _NgaySinh; set => _NgaySinh = value; }
        //public string GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        //public string SDT { get => _SDT; set => _SDT = value; }
        //public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        //public string Email { get => _Email; set => _Email = value; }
        //public string TrinhDo { get => _TrinhDo; set => _TrinhDo = value; }
        //public string ChuyenMon { get => _ChuyenMon; set => _ChuyenMon = value; }
        //public string Luong { get => _Luong; set => _Luong = value; }
        private DateTime _NgaySinh;
        public string MaGV { get ; set ; }
        public string HoTenGV { get ; set ; }
        public DateTime NgaySinh
        {
            get => _NgaySinh; set => _NgaySinh =  value; }
        public string GioiTinh { get; set; }
        public string SDT { get; set ; }
        public string DiaChi { get; set ; }
        public string Email { get ; set ; }
        public string TrinhDo { get ; set ; }
        public string ChuyenMon { get ; set ; }
        public string Luong { get ; set ; }
    }
}
