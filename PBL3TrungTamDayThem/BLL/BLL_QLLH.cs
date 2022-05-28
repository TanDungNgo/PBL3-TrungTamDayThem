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
    public class BLL_QLLH
    {
        private static BLL_QLLH _Instance;
        public static BLL_QLLH Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_QLLH();
                return _Instance;
            }
            private set { }
        }
        private BLL_QLLH()
        {
        }
        public List<string> GetListCBB()
        {
            List<string> l = new List<string>();
            foreach (DataRow i in DAL_QLLH.Instance.GetAllSubject().Rows)
            {
                l.Add(i["TenMon"].ToString());
            }
            return l;
        }
        public List<string> GetListMaMH()
        {
            List<string> l = new List<string>();
            foreach (DataRow i in DAL_QLLH.Instance.GetListMaMH().Rows)
            {
                l.Add(i["MaMH"].ToString());
            }
            return l;
        }
        public DataTable GetListClass(string monhoc, string lophoc)
        {
            DataTable data = new DataTable();
            if (monhoc == "All")
            {
                data = DAL_QLLH.Instance.GetAllClass();
            }
            if (monhoc != "All")
            {
                data = DAL_QLLH.Instance.GetClassBySubject(monhoc);
            }    
            return data;
        }
        public Class GetClassByMaLH(string MaLH)
        {
            Class lop = null;
            foreach (Class i in DAL_QLLH.Instance.GetClassByMaLH(MaLH))
            {
                if (i.MaLH == MaLH)
                    lop = i;
            }
            return lop;
        }
        public void ExecuteDB(Class lop)
        {
            int check = DataProvider.Instance.ExecuteScalar("Select count(*) from LOP_HOC where MaLH = '" + lop.MaLH + "'");
            if (check == 0)
            {
                // Add
                if (DAL_QLLH.Instance.AddClass(lop) > 0)
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Edit
                if (DAL_QLLH.Instance.EditClass(lop) > 0)
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Cập nhật thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Delete(List<string> LMaLH)
        {
            foreach (string i in LMaLH)
            {
                if (DAL_QLLH.Instance.DeleteClass(i) > 0)
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }
        public void UpdateKQH(string KQH, string MaHV, string MaLH)
        {
            if (DAL_QLLH.Instance.UpdateKQH(KQH, MaHV, MaLH) > 0)
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
