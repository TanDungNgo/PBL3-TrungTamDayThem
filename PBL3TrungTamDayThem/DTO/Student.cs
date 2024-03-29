﻿using System;
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
        private DateTime _NgaySinh;
        private string _GioiTinh;
        private string _DiaChi;
        private string _SDT;
        private string _Email;
        public Student()
        {
            this._NgaySinh = DateTime.Now;
        }
        public string MaHV { get => _MaHV; set => _MaHV = value; }
        public string HoTenHV { get => _HoTenHV; set => _HoTenHV = value; }
        public DateTime NgaySinh { get => _NgaySinh; set => _NgaySinh = value; }
        public string GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public string SDT { get => _SDT; set => _SDT = value; }
        public string Email { get => _Email; set => _Email = value; }
    }
}
