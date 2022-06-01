﻿using PBL3TrungTamDayThem.DAL;
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
    public class BLL_QLNV
    {
        private static BLL_QLNV _Instance;
        public static BLL_QLNV Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_QLNV();
                return _Instance;
            }
            private set { }
        }
        private BLL_QLNV()
        {

        }
        public int Count()
        {
            int count = DAL_QLNV.Instance.GetAllStaff().Count;
            return count;
        }
        public List<string> GetListCBB()
        {
            List<string> l = new List<string>();
            foreach (DataRow i in DAL_QLNV.Instance.GetAllPosition().Rows)
            {
                l.Add(i["ChucVu"].ToString());
            }
            return l;
        }
        public List<Staff> GetListStaff(string chucvu, string search)
        {
            List<Staff> data = new List<Staff>();
            if (chucvu == "All")
            {
                if (search == "")
                    data = DAL_QLNV.Instance.GetAllStaff();
                else
                    data = DAL_QLNV.Instance.GetStaffBySearch(chucvu, search);
            }
            else
            {
                if (search == "")
                    data = DAL_QLNV.Instance.GetStaffByPosition(chucvu);
                else
                    data = DAL_QLNV.Instance.GetStaffBySearch(chucvu, search);
            }
            return data;
        }
        public Staff GetNVByID(string MaNV)
        {
            Staff staff = null;
            foreach (Staff i in DAL_QLNV.Instance.GetAllStaff())
            {
                if (i.MaNV == MaNV)
                    staff = i;
            }
            return staff;
        }

        public void ExecuteDB(Staff s)
        {
            int check = DataProvider.Instance.ExecuteScalar("Select count(*) from NHAN_VIEN where MaNV = '" + s.MaNV + "'");
            if (check == 0)
            {
                // Add
                if (DAL_QLNV.Instance.AddStaff(s) > 0)
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Edit
                if (DAL_QLNV.Instance.EditStaff(s) > 0)
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Cập nhật thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Delete(List<string> LMaNV)
        {
            int length = LMaNV.Count;
            int count = 0;
            foreach (string i in LMaNV)
            {
                if (DAL_QLNV.Instance.DeleteStaff(i) > 0)
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
        public List<Staff> SortListStaff(string s)
        {
            List<Staff> data = new List<Staff>();
            data = DAL_QLNV.Instance.SortListStaff(s);
            return data;
        }
    }
}
