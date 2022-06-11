using PBL3TrungTamDayThem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3TrungTamDayThem.DAL
{
    public class DAL_QLNV
    {
        private static DAL_QLNV _Instance;
        public static DAL_QLNV Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new DAL_QLNV();
                return _Instance;
            }
            private set { }
        }
        private DAL_QLNV()
        {

        }
        public DataTable GetAllPosition()
        {
            string query = "Select ChucVu from NHAN_VIEN ";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public List<Staff> GetAllStaff()
        {
            List<Staff> data = new List<Staff>();
            string query = "Select * from NHAN_VIEN where KiemTra = 'true'";
            foreach (DataRow i in DataProvider.Instance.ExecuteQuery(query).Rows)
            {
                data.Add(GetStaff(i));
            }
            return data;
        }
        public List<Staff> GetStaffByPosition(string chucvu)
        {
            List<Staff> data = new List<Staff>();
            string query = "Select * from NHAN_VIEN where ChucVu = N'" + chucvu + "' and KiemTra = 'true'";
            foreach (DataRow i in DataProvider.Instance.ExecuteQuery(query).Rows)
            {
                data.Add(GetStaff(i));
            }
            return data;
        }
        public List<Staff> GetStaffBySearch(string chucvu, string name)
        {
            List<Staff> data = new List<Staff>();
            string query = "";
            if (chucvu == "All")
                query = "Select * from NHAN_VIEN where HoTenNV like N'%" + name + "%' and KiemTra = 'true'";
            else
                query = "Select * from NHAN_VIEN where HoTenNV like N'%" + name + "%' and ChucVu = N'" + chucvu + "' and KiemTra = 'true'";
            foreach (DataRow i in DataProvider.Instance.ExecuteQuery(query).Rows)
            {
                data.Add(GetStaff(i));
            }
            return data;
        }
        public Staff GetStaff(DataRow i)
        {
            return new Staff
            {
                MaNV = i["MaNV"].ToString(),
                HoTenNV = i["HoTenNV"].ToString(),
                NgaySinh = (DateTime)i["NgaySinh"],
                GioiTinh = ((bool)i["GioiTinh"] == true) ? "Nam" : "Nữ",
                SDT = i["SDT"].ToString(),
                DiaChi = i["DiaChi"].ToString(),
                Email = i["Email"].ToString(),
                ChucVu = i["ChucVu"].ToString(),
                NgayVaoLam = (DateTime)i["NgayVaoLam"],
                Luong = int.Parse(i["Luong"].ToString())
            };
        }
        public int CheckStaff(string MaNV)
        {
            string query = "Select count(*) from NHAN_VIEN where MaNV = '" + MaNV + "'";
            return DataProvider.Instance.ExecuteScalar(query);
        }
        public int AddStaff(Staff s)
        {
            DAL_User.Instance.AddUser(s);
            string query = "Insert into NHAN_VIEN values ('" + s.MaNV + "', N'" + s.HoTenNV + "','" + s.NgaySinh +
                    "', '" + s.GioiTinh + "',N'" + s.DiaChi + "','" + s.SDT + "','" + s.Email + "'," +
                    "N'" + s.ChucVu + "', '" + s.NgayVaoLam + "', '" + s.Luong + "')";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int EditStaff(Staff s)
        {
            string query = "Update NHAN_VIEN set MaNV = '" + s.MaNV + "',HoTenNV = N'" + s.HoTenNV + "',NgaySinh = '" + s.NgaySinh +
                                    "',GioiTinh = '" + s.GioiTinh + "',DiaChi = N'" + s.DiaChi + "',SDT ='" + s.SDT + "',Email ='" + s.Email +
                                    "',ChucVu = N'" + s.ChucVu + "', NgayVaoLam = '" + s.NgayVaoLam + "', Luong = '" + s.Luong +
                                    "' Where MaNV = '" + s.MaNV + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int DeleteStaff(string MaNV)
        {
            string query = "Update NHAN_VIEN set KiemTra = 'false' where MaNV = '" + MaNV + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public List<Staff> SortListStaff(string s)
        {
            List<Staff> data = new List<Staff>();
            string query = "Select * from NHAN_VIEN where KiemTra = 'true' ORDER BY " + s;
            foreach (DataRow i in DataProvider.Instance.ExecuteQuery(query).Rows)
            {
                data.Add(GetStaff(i));
            }
            return data;
        }
    }
}
