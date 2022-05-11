using PBL3TrungTamDayThem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3TrungTamDayThem.DAL
{
    public class DAL_QLHV
    {
        private static DAL_QLHV _Instance;
        public static DAL_QLHV Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new DAL_QLHV();
                return _Instance;
            }
            private set { }
        }
        private DAL_QLHV()
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
        public List<Student> GetAllStudent()
        {
            List<Student> data = new List<Student>();
            string query = "Select * from HOC_VIEN";
            foreach (DataRow i in DataProvider.Instance.ExecuteQuery(query).Rows)
            {
                data.Add(GetStudent(i));
            }
            return data;
        }
        public Student GetStudent(DataRow i)
        {
            return new Student
            {
                MaHV = i["MaHV"].ToString(),
                HoTenHV = i["HoTenHV"].ToString(),
                NgaySinh = (DateTime)i["NgaySinh"],
                GioiTinh = ((bool)i["GioiTinh"] == true) ? "Nam" : "Nữ",
                SDT = i["SDT"].ToString(),
                DiaChi = i["DiaChi"].ToString(),
                Email = i["Email"].ToString(),
                TinhTrang = i["TinhTrang"].ToString(),
                MaLH = i["MaLH"].ToString(),
            };
        }
    }
}
