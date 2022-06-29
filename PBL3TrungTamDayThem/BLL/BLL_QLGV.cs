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
            int count = 0;
            foreach(DataRow i in DAL_QLGV.Instance.Count().Rows)
                count = int.Parse(i[0].ToString());
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
            if (chuyenmon == "All")
            {
                    data = DAL_QLGV.Instance.GetTeacherBySearch(chuyenmon, search);
            }
            else
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
            int check = DAL_QLGV.Instance.CheckTeacher(t.MaGV);
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
            int length = LMaGV.Count;
            int count = 0;
            foreach (string i in LMaGV)
            {
                if (DAL_QLGV.Instance.DeleteTeacher(i) > 0)
                    count++;
                else
                {
                    MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }         
            }
            if (count == length)
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public List<Teacher> SortListTeacher(string sort, string search, string chuyenmon)
        {
            List<Teacher> data = new List<Teacher>();
            if (chuyenmon == "All")
            {
                if (search == "Nhập tên tìm kiếm")
                    data = DAL_QLGV.Instance.SortListAllTeacher(sort);
                else
                    data = DAL_QLGV.Instance.SortListTeacherBySearch(sort, search);
            }
            else
            {
                if (search == "Nhập tên tìm kiếm")
                    data = DAL_QLGV.Instance.SortListAllTeacher(sort);
                else
                    data = DAL_QLGV.Instance.SortListTeacher(sort, search, chuyenmon);
            }
            
            return data;
        }
        public List<CBBItem> GetHoTenGV()
        {
            List<CBBItem> list = new List<CBBItem>();
            foreach (DataRow i in DAL_QLGV.Instance.GetHoTen().Rows)
            {
                list.Add(new CBBItem
                {
                    Value = i["MaGV"].ToString(),
                    Text = i["HoTenGV"].ToString(),
                });
            }
            return list;
        }
        public bool CheckPhone(string MaGV, string Phone)
        {
            int k = 0;
            List<Teacher> list = DAL_QLGV.Instance.GetAllTeacher();
            if (list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].SDT == Phone && list[i].MaGV != MaGV)
                    {
                        k++;
                        break;
                    }    
                }
                if (k == 0)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
    }
}
