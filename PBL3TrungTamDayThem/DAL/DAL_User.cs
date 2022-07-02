using PBL3TrungTamDayThem.DTO;
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
        public int Login(string username, string password)
        {
            string query = "Select * from ACCOUNT where TaiKhoan = @username and MatKhau = @pass and KiemTra = 'True'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] {username, password});
            return result.Rows.Count;
        }
        public int CheckUsernameMail(string username, string email)
        {
            string query = "Select * from ACCOUNT ac inner join NHAN_VIEN nv on ac.MaNV = nv.MaNV where ac.TaiKhoan = @username and nv.Email = @email and nv.KiemTra = 'True'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, email }) ;
            return result.Rows.Count;
        }
        public User GetUserByUsername(string Username)
        {
            string query = "Select * from ACCOUNT where TaiKhoan = '" + Username + "' and KiemTra = 'True'";
            DataRow i = DataProvider.Instance.ExecuteQuery(query).Rows[0];
            return new User
            {
                MaNV = i["MaNV"].ToString(),
                TaiKhoan = i["TaiKhoan"].ToString(),
                MatKhau = i["MatKhau"].ToString(),
                TenHienThi = i["TenHienThi"].ToString(),
                Anh = i["Anh"].ToString(),
            };
        }
        public User GetUserByMaNV(string MaNV)
        {
            string query = "Select * from ACCOUNT where MaNV = '" + MaNV + "' and KiemTra = 'True'";
            DataRow i = DataProvider.Instance.ExecuteQuery(query).Rows[0];
            return new User
            {
                MaNV = i["MaNV"].ToString(),
                TaiKhoan = i["TaiKhoan"].ToString(),
                MatKhau = i["MatKhau"].ToString(),
                TenHienThi = i["TenHienThi"].ToString(),
                Anh = i["Anh"].ToString(),
            };
        }
        public void AddUser(Staff s)
        {
            string query1 = "Insert into ACCOUNT values('" + s.MaNV + "', '" + s.MaNV + "', '123456', '" + s.MaNV + "', '','True')";
            DataProvider.Instance.ExecuteQuery(query1);
        }
        public int UpdateUser(User u)
        {
            string query = "Update ACCOUNT set MaNV = '" + u.MaNV + "',TaiKhoan = '" + u.TaiKhoan + "',MatKhau = '" + u.MatKhau +
                                    "',TenHienThi = N'" + u.TenHienThi  + "',Anh = '" + u.Anh + "' where MaNV = '" + u.MaNV + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int ResetPass(string username)
        {
            string query = "Update ACCOUNT set MatKhau = '123456' where TaiKhoan = '" + username + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
