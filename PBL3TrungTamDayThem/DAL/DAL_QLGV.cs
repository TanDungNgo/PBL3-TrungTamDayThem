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
        public List<Class> GetAllClass()
        {
            List<Class> data = new List<Class>();
            string query = "Select * from LOP_HOC";
            foreach (DataRow i in DataProvider.Instance.ExecuteQuery(query).Rows)
            {
                data.Add(GetClass(i));
            }
            return data;
        }

        public Class GetClass(DataRow i)
        {
            return new Class
            {
                MaLH = i["MaLH"].ToString()
            };
        }
        public List<Teacher> GetAllTeacher()
        {
            List<Teacher> data = new List<Teacher>();
            string query = "Select * from GIAO_VIEN";
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
        public int AddTeacher(Teacher t)
        {
            string query = "";
            return DataProvider.Instance.ExecuteNonQuery(query);

        }
        public int EditStudent(Teacher t)
        {
            string query = "";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int DeleteStudent(string MaGV)
        {
            string query = "Delete from  GIAO_VIEN where MaGV = '" + MaGV + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
