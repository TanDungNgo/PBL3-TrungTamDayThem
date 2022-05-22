using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3TrungTamDayThem.DAL
{
    public class DAL_QLLH
    {
        private static DAL_QLLH _Instance;
        public static DAL_QLLH Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new DAL_QLLH();
                return _Instance;
            }
            private set { }
        }
        private DAL_QLLH()
        {
        }
        public DataTable GetAllSubject()
        {
            string query = "Select TenMon from MON_HOC";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetAllClass()
        {
            string query = "select gv.HoTenGV, lh.MaLH, lh.SoLuongHV, lh.ThoiGianHoc, lh.NgayBatDau, lh.NgayKetThuc, lh.HocPhi " +
                "from GIAO_VIEN gv inner join LOP_HOC lh on gv.MaGV = lh.MaGV inner join MON_HOC mh on lh.MaMH = mh.MaMH";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetClassBySubject(string mh)
        {
            string query = "select gv.HoTenGV, lh.MaLH, lh.SoLuongHV, lh.ThoiGianHoc, lh.NgayBatDau, lh.NgayKetThuc, lh.HocPhi from GIAO_VIEN gv inner join LOP_HOC lh on gv.MaGV = lh.MaGV inner join MON_HOC mh on lh.MaMH = mh.MaMH where mh.TenMon = N'" + mh +"'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
