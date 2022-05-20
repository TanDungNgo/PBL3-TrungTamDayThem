using PBL3TrungTamDayThem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3TrungTamDayThem.DAL
{
    public class DAL_QLBL
    {
        private static DAL_QLBL _Instance;
        public static DAL_QLBL Instance
        {
            get
            {
                if( _Instance == null )
                    _Instance = new DAL_QLBL();
                return _Instance;
            }
            private set { }
        }
        private  DAL_QLBL() { }
        public DataTable GetStudentByClass(string lophoc)
        {
            string query = "select HV.HoTenHV, HVTL.TinhTrang from HOC_VIEN HV inner join HOC_VIEN_TRONG_LOP HVTL " +
                "on HV.MaHV = HVTL.MaHV where HVTL.MaLH = '" + lophoc + "'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetStudentBySearch(string name, string lophoc)
        {
            string query = "";
            if (lophoc == "")
                query = "select HV.HoTenHV, HVTL.TinhTrang from HOC_VIEN HV inner join HOC_VIEN_TRONG_LOP HVTL " +
                    "on HV.MaHV = HVTL.MaHV where HV.HoTenHV like N'%" + name + "%'";
            else
                query = "select HV.HoTenHV, HVTL.TinhTrang from HOC_VIEN HV inner join HOC_VIEN_TRONG_LOP HVTL " +
                    "on HV.MaHV = HVTL.MaHV where HV.HoTenHV like N'%" + name + "%' and HVTL.MaLH = '" + lophoc + "'";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetFee(string MaLH)
        {
            string query = "Select HocPhi from LOP_HOC where MaLH = '" + MaLH + "'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public void PayFee(string HotenHV, string MaLH)
        {
            string query = "Update HOC_VIEN_TRONG_LOP set TinhTrang = N'Đã đóng học phí' from HOC_VIEN_TRONG_LOP hvtl  inner join HOC_VIEN hv " +
                "on hvtl.MaHV = hv.MaHV where hv.HoTenHV = N'" + HotenHV + "' and hvtl.MaLH = '" + MaLH + "'";
            DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
