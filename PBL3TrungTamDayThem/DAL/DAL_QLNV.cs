using PBL3TrungTamDayThem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private DAL_QLNV() { }
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
            };
        }
        public List<Staff> GetAllStaff()
        {
            List<Staff> data = new List<Staff>();
            string query = "Select * from NHAN_VIEN";
            foreach (DataRow i in DataProvider.Instance.ExecuteQuery(query).Rows)
            {
                data.Add(GetStaff(i));
            }
            return data;
        }
    }
}
