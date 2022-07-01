using PBL3TrungTamDayThem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3TrungTamDayThem.DAL
{
    public class DAL_QLBL
    {
        private static DAL_QLBL _Instance;
        public static DAL_QLBL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new DAL_QLBL();
                return _Instance;
            }
            private set { }
        }
        private DAL_QLBL() { }
        public DataTable GetStudentByClass(string lophoc)
        {
            string query = "select HVTL.MaLH, HV.MaHV, HV.HoTenHV, HVTL.TinhTrang from HOC_VIEN HV inner join HOC_VIEN_TRONG_LOP HVTL " +
                "on HV.MaHV = HVTL.MaHV where HVTL.MaLH = '" + lophoc + "'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetAllStudent()
        {
            string query = "select HVTL.MaLH, HV.MaHV, HV.HoTenHV, HVTL.TinhTrang from HOC_VIEN HV inner join HOC_VIEN_TRONG_LOP HVTL " +
                "on HV.MaHV = HVTL.MaHV ";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetStudentBySearch(string name, string lophoc)
        {
            string query = "";
            if (lophoc == "All")
                query = "select HVTL.MaLH, HV.MaHV, HV.HoTenHV, HVTL.TinhTrang from HOC_VIEN HV inner join HOC_VIEN_TRONG_LOP HVTL " +
                    "on HV.MaHV = HVTL.MaHV where HV.HoTenHV like N'%" + name + "%'";
            else
                query = "select HVTL.MaLH, HV.MaHV, HV.HoTenHV, HVTL.TinhTrang from HOC_VIEN HV inner join HOC_VIEN_TRONG_LOP HVTL " +
                    "on HV.MaHV = HVTL.MaHV where HV.HoTenHV like N'%" + name + "%' and HVTL.MaLH = '" + lophoc + "'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public int AddBill(Bill bill)
        {
            string query = "Insert into BIEN_LAI values('" + bill.MaHV + "','" + bill.MaLH + "','" + bill.HocPhi +
                "','" + bill.NgayThuHP + "','" + bill.MaNV + "', '" + bill.NoiDung + "')";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public DataTable GetFee(string MaLH)
        {
            string query = "Select HocPhi from LOP_HOC where MaLH = '" + MaLH + "'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public void PayFee(string MaHV, string MaLH)
        {
            string query = "Update HOC_VIEN_TRONG_LOP set TinhTrang = N'Đã đóng học phí' from HOC_VIEN_TRONG_LOP hvtl  inner join HOC_VIEN hv " +
                "on hvtl.MaHV = hv.MaHV where hv.MaHV = '" + MaHV + "' and hvtl.MaLH = '" + MaLH + "'";
            DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetStudentByStatus(string tinhtrang, string MaLH, string search)
        {
            string query = "";
            if (MaLH == "All")
            {
                if (search == "Nhập tên tìm kiếm")
                    query = "select HVTL.MaLH, HV.MaHV, HV.HoTenHV, HVTL.TinhTrang from HOC_VIEN HV inner join HOC_VIEN_TRONG_LOP HVTL " +
                            "on HV.MaHV = HVTL.MaHV where HVTL.TinhTrang = N'" + tinhtrang + "'";
                else
                    query = "select HVTL.MaLH, HV.MaHV, HV.HoTenHV, HVTL.TinhTrang from HOC_VIEN HV inner join HOC_VIEN_TRONG_LOP HVTL " +
                    "on HV.MaHV = HVTL.MaHV where HVTL.TinhTrang = N'" + tinhtrang + "' and HV.HoTenHV like N'%" + search + "%'";
            }    
            else
            {
                if (search == "Nhập tên tìm kiếm")
                    query = "select HVTL.MaLH, HV.MaHV, HV.HoTenHV, HVTL.TinhTrang from HOC_VIEN HV inner join HOC_VIEN_TRONG_LOP HVTL " +
                            "on HV.MaHV = HVTL.MaHV where HVTL.TinhTrang = N'" + tinhtrang + "'  and HVTL.MaLH = '" + MaLH + "'";
                else
                    query = "select HVTL.MaLH, HV.MaHV, HV.HoTenHV, HVTL.TinhTrang from HOC_VIEN HV inner join HOC_VIEN_TRONG_LOP HVTL " +
                    "on HV.MaHV = HVTL.MaHV where HVTL.TinhTrang = N'" + tinhtrang + "'  and HVTL.MaLH = '" + MaLH + "' and HV.HoTenHV like N'%" + search + "%'";
            }    
          
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetHocPhi(string noidung, string malh)
        {
            string query = "Select HocPhi from BIEN_LAI where NoiDung = '" + noidung + "' and MaLH like '" + malh + "%'"; ;
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
