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

        public List<CBBItem> GetListCBB()
        {
            List<CBBItem> data = new List<CBBItem>();
            foreach (Class i in DAL_QLHV.Instance.GetAllClass())
            {
                data.Add(new CBBItem { Value = i.MaLH });
            }
            return data;
        }

        public List<Student> GetListStudent(string lophoc, string search)
        {
            List < Student > data  = new List<Student>();
            if (search != null)
            {
                data = DAL_QLHV.Instance.GetStudentBySearch(search);
            }
            if (search == null && lophoc == "All")
            {
                data = DAL_QLHV.Instance.GetAllStudent();
            }
            //if (lophoc != "All")
            //{
            //    data = DAL_QLHV.Instance.GetStudentByClass(lophoc);
            //}
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
            int check = DataProvider.Instance.ExecuteScalar("Select count(*) from HOC_VIEN where MaHV = '" + s.MaHV + "'");
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
                    MessageBox.Show("Cập nhật thất bại thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Delete(string MahV)
        {
            if (DAL_QLHV.Instance.DeleteStudent(MahV) > 0)
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
