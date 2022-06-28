using PBL3TrungTamDayThem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3TrungTamDayThem.DAL
{
    public class DAL_QLGV
    {
        private static DAL_QLGV _Instance;
        public static DAL_QLGV Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new DAL_QLGV();
                return _Instance;
            }
            private set {  }
        }
        private DAL_QLGV()
        {

        }
        public DataTable GetAllExpertise()
        {
            string query = "Select ChuyenMon from GIAO_VIEN where KiemTra = 'true'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public List<Teacher> GetAllTeacher()
        {
            List<Teacher> data = new List<Teacher>();
            string query = "Select * from GIAO_VIEN where KiemTra = 'true'";
            foreach (DataRow i in DataProvider.Instance.ExecuteQuery(query).Rows)
            {
                data.Add(GetTeacher(i));
            }
            return data;
        }
        public List<Teacher> GetTeacherByEx(string chuyenmon)
        {
            List<Teacher> data = new List<Teacher>();
            string query = "Select * from GIAO_VIEN where ChuyenMon = N'" + chuyenmon + "' and KiemTra = 'true'";
            foreach (DataRow i in DataProvider.Instance.ExecuteQuery(query).Rows)
            {
                data.Add(GetTeacher(i));
            }
            return data;
        }
        public List<Teacher> GetTeacherBySearch(string chuyenmon, string name)
        {
            List<Teacher> data = new List<Teacher>();
            string query = "";
            if (chuyenmon == "All")
                query = "Select * from GIAO_VIEN where HoTenGV like N'%" + name + "%' and KiemTra = 'true'";
            else
                query = "Select * from GIAO_VIEN where HoTenGV like N'%" + name + "%' and ChuyenMon = N'" + chuyenmon + "' and KiemTra = 'true'";
            foreach (DataRow i in DataProvider.Instance.ExecuteQuery(query).Rows)
            {
                data.Add(GetTeacher(i));
            }
            return data;
        }
        public Teacher GetTeacher(DataRow i)
        {
            return new Teacher
            {
                MaGV = i["MaGV"].ToString(),
                HoTenGV = i["HoTenGV"].ToString(),
                NgaySinh = (DateTime)i["NgaySinh"],
                GioiTinh = ((bool)i["GioiTinh"] == true) ? "Nam" : "Nữ",
                SDT = i["SDT"].ToString(),
                DiaChi = i["DiaChi"].ToString(),
                Email = i["Email"].ToString(),
                TrinhDo = i["TrinhDo"].ToString(),
                ChuyenMon = i["ChuyenMon"].ToString(),
                Luong = i["Luong"].ToString()
            };
        }
        public int CheckTeacher(string MaGV)
        {
            string query = "Select count(*) from GIAO_VIEN where MaGV = '" + MaGV + "'";
            return DataProvider.Instance.ExecuteScalar(query);
        }
        public int AddTeacher(Teacher t)
        {
            string query = "Insert into GIAO_VIEN values ('" +t.MaGV + "',N'" + t.HoTenGV + "','" + t.NgaySinh + "','" + t.GioiTinh + "',N'" + t.DiaChi +
                                    "',N'" + t.ChuyenMon + "',N'" + t.TrinhDo + "','" + t.SDT + "','" + t.Email + "','" + t.Luong + "', 'true')";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int EditTeacher(Teacher t)
        {
            string query = "Update GIAO_VIEN set MaGV = '" + t.MaGV + "',HoTenGV = N'" + t.HoTenGV + "',NgaySinh = '" + t.NgaySinh +
                                    "',GioiTinh = '" + t.GioiTinh + "',DiaChi = N'" + t.DiaChi + "',ChuyenMon = N'" + t.ChuyenMon +
                                    "',TrinhDo = N'" + t.TrinhDo + "',SDT ='" + t.SDT + "',Email ='" + t.Email + "',Luong ='" + t.Luong +
                                    "' Where MaGV = '" + t.MaGV + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int DeleteTeacher(string MaGV)
        {
            string query = "Update GIAO_VIEN set KiemTra = 'false' where MaGV = '" + MaGV + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public List<Teacher> SortListTeacher(string s)
        {
            List<Teacher> data = new List<Teacher>();
            string query = "Select * from GIAO_VIEN where KiemTra = 'true' ORDER BY " + s;
            foreach (DataRow i in DataProvider.Instance.ExecuteQuery(query).Rows)
            {
                data.Add(GetTeacher(i));
            }
            return data;
        }
        public DataTable GetMaGV()
        {
            string query = "Select MaGV from GIAO_VIEN where KiemTra = 'true'";
            return DataProvider.Instance.ExecuteQuery(query);   
        }
        public DataTable Count()
        {
            string query = "select COUNT(*) from GIAO_VIEN";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
