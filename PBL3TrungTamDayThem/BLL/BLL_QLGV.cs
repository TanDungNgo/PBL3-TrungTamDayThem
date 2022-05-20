using PBL3TrungTamDayThem.DAL;
using PBL3TrungTamDayThem.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3TrungTamDayThem.BLL
{
    public class BLL_QLGV
    {
        private static BLL_QLGV _Instance;
        public static BLL_QLGV Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_QLGV();
                return _Instance;
            }
            private set { }
        }
        private BLL_QLGV()
        {

        }

        public List<CBBItem> GetListCBB()
        {
            List<CBBItem> data = new List<CBBItem>();
            foreach(Class i in DAL_QLGV.Instance.GetAllClass())
            {
                data.Add(new CBBItem { Value = i.MaLH });
            }
            return data;
        }
        public List<Teacher> GetListTeacher(string lophoc, string search)
        {
            List<Teacher> data = new List<Teacher>();
            //if (search != null)
            //{
            //    data = DAL_QLGV.Instance.GetAllTeacher();
            if (search == null && lophoc == "All")
            {
                data = DAL_QLGV.Instance.GetAllTeacher();
                }
            //if (lophoc != "All")
            //{
            //    data = DAL_QLHV.Instance.GetStudentByClass(lophoc);
            //}
            return data;
        }
        public Teacher GetGVByID(string MaGV)
        {
            Teacher teacher = null;
            foreach (Teacher i in DAL_QLGV.Instance.GetAllTeacher())
            {
                if (i.MaGV == MaGV)
                    teacher = i;
            }
            return teacher;
        }
    }
}
