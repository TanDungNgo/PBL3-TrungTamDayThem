using PBL3TrungTamDayThem.DAL;
using PBL3TrungTamDayThem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public int Count()
        {
            int count = DAL_QLGV.Instance.GetAllTeacher().Count;
            return count;
        }
        public List<string> GetListCBB()
        {
            List<string> l = new List<string>();
            foreach (DataRow i in DAL_QLGV.Instance.GetAllExpertise().Rows)
            {
                l.Add(i["ChuyenMon"].ToString());
            } 
            return l;
        }
        public List<Teacher> GetListTeacher(string chuyenmon, string search)
        {
            List<Teacher> data = new List<Teacher>();
            if (search == null && chuyenmon == "All")
            {
                data = DAL_QLGV.Instance.GetAllTeacher();
            }
            if (chuyenmon != "All")
            {
                data = DAL_QLGV.Instance.GetTeacherByEx(chuyenmon);
            }
            if (search != null)
            {
                data = DAL_QLGV.Instance.GetTeacherBySearch(chuyenmon, search);
            }    
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
        public void ExecuteDB(Teacher t)
        {
            int check = DataProvider.Instance.ExecuteScalar("Select count(*) from GIAO_VIEN where MaGV = '" + t.MaGV + "'");
            if (check == 0)
            {
                // Add
                if (DAL_QLGV.Instance.AddTeacher(t) > 0)
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Edit
                if (DAL_QLGV.Instance.EditTeacher(t) > 0)
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Cập nhật thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DeleteTeacher(List<string> LMaGV)
        {
            foreach (string i in LMaGV)
            {
                if (DAL_QLGV.Instance.DeleteTeacher(i) > 0)
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<Teacher> SortListTeacher(string s)
        {
            List<Teacher> data = new List<Teacher>();
            data = DAL_QLGV.Instance.SortListTeacher(s);
            return data;
        }
        public List<string> GetMaGV()
        {
            List<string> list = new List<string>();
            foreach(DataRow i in DAL_QLGV.Instance.GetMaGV().Rows)
            {
                list.Add(i["MaGV"].ToString());
            }    
            return list;
        }
    }
}
