﻿using PBL3TrungTamDayThem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3TrungTamDayThem.DAL
{
    public class DAL_User
    {
        private static DAL_User _Instance;
        public static DAL_User Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new DAL_User();
                return _Instance;
            }
            private set { }
        }
        private DAL_User()
        {
        }
        public User GetUserByMaNV(string MaNV)
        {
            string query = "Select * from ACCOUNT where MaNV = '" + MaNV + "'";
            DataRow i = DataProvider.Instance.ExecuteQuery(query).Rows[0];
            return new User
            {
                MaNV = i["MaNV"].ToString(),
                TaiKhoan = i["TaiKhoan"].ToString(),
                MatKhau = i["MatKhau"].ToString(),
                TenHienThi = i["TenHienThi"].ToString(),
                Anh = i["Anh"].ToString(),
                VaiTro = i["VaiTro"].ToString()
            };
        }
        public string GetMaNVByUsername(string username)
        {
            string query = "Select MaNV from ACCOUNT where TaiKhoan = '" + username + "'";
            DataRow dr = DataProvider.Instance.ExecuteQuery(query).Rows[0];
            return dr["MaNV"].ToString();
        }
        public int UpdateUser(User u)
        {
            string query = "Update ACCOUNT set MaNV = '" + u.MaNV + "',TaiKhoan = '" + u.TaiKhoan + "',MatKhau = '" + u.MatKhau +
                                    "',TenHienThi = N'" + u.TenHienThi  + "',Anh = '" + u.Anh + "',VaiTro = '" + u.VaiTro +
                                    "' where MaNV = '" + u.MaNV + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
