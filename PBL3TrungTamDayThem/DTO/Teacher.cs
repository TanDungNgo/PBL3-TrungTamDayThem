using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3TrungTamDayThem.DTO
{
    public class Teacher
    {
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
        public int Luong { get ; set ; }
    }
}
