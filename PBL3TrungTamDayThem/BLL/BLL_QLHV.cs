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
    public class BLL_QLHV
    {
        private static BLL_QLHV _Instance;
        public static BLL_QLHV Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_QLHV();
                return _Instance;
            }
            private set { }
        }
        private BLL_QLHV()
        {

        }
        public int Count()
        {
            int count = 0;
            foreach (DataRow i in DAL_QLHV.Instance.Count().Rows)
                count = int.Parse(i[0].ToString());
            return count;
        }
        public List<string> GetListCBB()
        {
            List<string> data = new List<string>();
            foreach (Class i in DAL_QLHV.Instance.GetAllClass())
            {
                data.Add(i.MaLH);
            }
            return data;
        }

        public List<Student> GetListStudent(string lophoc, string search)
        {
            List < Student > data  = new List<Student>();
            if (lophoc == "All")
            {
                if (search == "")
                    data = DAL_QLHV.Instance.GetAllStudent();
                else
                    data = DAL_QLHV.Instance.GetStudentBySearch(search, lophoc);
            }
            else
            {
                if (search == "")
                    data = DAL_QLHV.Instance.GetStudentByClass(lophoc);
                else
                    data = DAL_QLHV.Instance.GetStudentBySearch(search, lophoc);
            }    
            return data;
        }
        public Student GetHVByID(string MaHV)
        {
            Student student = null;
            foreach (Student i in DAL_QLHV.Instance.GetAllStudent())
            {
                if (i.MaHV == MaHV)
                    student = i;  
            }    
            return student;
        }

        public void ExecuteDB(Student s)
        {
            int check = DAL_QLHV.Instance.CheckStudent(s.MaHV);
            if (check == 0)
            {
                // Add
                if (DAL_QLHV.Instance.AddStudent(s) > 0)
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Edit
                if (DAL_QLHV.Instance.EditStudent(s) > 0)
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Cập nhật thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DeleteStudent(List<string> LMaHV)
        {
            int length = LMaHV.Count;
            int count = 0;
            foreach (string i in LMaHV)
            {
                if (DAL_QLHV.Instance.DeleteStudent(i) > 0)
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
        public List<Student> SortListStudent(string s, string MaLH)
        {
            List<Student> data = new List<Student>();
            if (MaLH == "All")
                data = DAL_QLHV.Instance.SortListStudent(s);
            else
                data = DAL_QLHV.Instance.SortListStudentInClass(s, MaLH);
            return data;
        }
        public bool CheckPhone(string MaHV, string Phone)
        {
            int k = 0;
            List<Student> list = DAL_QLHV.Instance.GetAllStudent();
            if (list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].SDT == Phone && list[i].MaHV != MaHV)
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
