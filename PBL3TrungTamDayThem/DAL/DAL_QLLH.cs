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
        public DataTable GetSubjectInClass(string malh)
        {
            string query = "select TenMon from MON_HOC mh inner join LOP_HOC lh on mh.MaMH = lh.MaMH" +
                " where lh.MaLH like '"+malh+"%'";
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
            string query = "select gv.HoTenGV, lh.MaLH, lh.SoLuongHV, lh.ThoiGianHoc, lh.NgayBatDau, lh.NgayKetThuc, lh.HocPhi " +
                "from GIAO_VIEN gv inner join LOP_HOC lh on gv.MaGV = lh.MaGV inner join MON_HOC mh on lh.MaMH = mh.MaMH where mh.TenMon = N'" + mh +"'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public List<Class> GetClassByMaLH(string MaLH)
        {
            List<Class> list = new List<Class>();   
            string query = "Select * from LOP_HOC where MaLH = '" + MaLH + "'";
            foreach (DataRow i in DataProvider.Instance.ExecuteQuery(query).Rows)
            {
                list.Add(GetClass(i));
            }
            return list;
        }
        public Class GetClass(DataRow i)
        {
            return new Class
            {
                MaLH = i["MaLH"].ToString(),
                MaGV = i["MaGV"].ToString(),
                MaMH = i["MaMH"].ToString(),
                SoLuongHV = int.Parse(i["SoLuongHV"].ToString()),
                ThoiGianHoc = i["ThoiGianHoc"].ToString(),
                NgayBatDau = (DateTime)i["NgayBatDau"],
                NgayKetThuc = (DateTime)i["NgayKetThuc"],
                HocPhi = int.Parse(i["HocPhi"].ToString())
            };
        }
        public int CheckMaLH(string MaLH)
        {
            return DataProvider.Instance.ExecuteScalar("Select count(*) from LOP_HOC where MaLH = '" + MaLH + "'");
        }
        public int AddClass(Class lop)
        {
            string query = "Insert into LOP_HOC values ('" + lop.MaLH + "', '" + lop.MaGV  + "','" + lop.MaMH +
                    "', '" + lop.SoLuongHV + "','" + lop.ThoiGianHoc + "','" + lop.NgayBatDau + "','" + lop.NgayKetThuc + "','" + lop.HocPhi + "')";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int EditClass(Class lop)
        {
            string query = "Update LOP_HOC set MaLH = '" + lop.MaLH + "', MaGV = '" + lop.MaGV + "', MaMH = '"
                + lop.MaMH + "', SoLuongHV = '" + lop.SoLuongHV + "', ThoiGianHoc = '" + lop.ThoiGianHoc +
                "', NgayBatDau = '" + lop.NgayBatDau + "', NgayKetThuc = '" + lop.NgayKetThuc + "' where MaLH = '" + lop.MaLH + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int DeleteClass(string MaLH)
        {
            string query = "Delete from  LOP_HOC where MaLH = '" + MaLH + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public DataTable GetListMaMH()
        {
            string query = "Select MaMH from MON_HOC";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetHVByClass(string MaLH)
        {
            string query = "Select hvtl.MaLH, hvtl.MaHV, hv.HoTenHV, hvtl.KetQuaHoc, hvtl.TinhTrang from HOC_VIEN_TRONG_LOP hvtl inner join HOC_VIEN hv on hvtl.MaHV = hv.MaHV" +
                " where MaLH = '" + MaLH + "'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public int UpdateKQH(string KQH, string MaHV, string MaLH)
        {
            string query = "Update HOC_VIEN_TRONG_LOP set KetQuaHoc = '" + KQH + "' where MaHV = '" + MaHV +"' and MaLH = '" + MaLH + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int CheckInClass(string MaHV, string MaLH)
        {
            string query = "select count(*)  from  HOC_VIEN_TRONG_LOP hvtl inner join LOP_HOC l on hvtl.MaLH = l.MaLH " +
                "where hvtl.MaHV = '" + MaHV + "' and l.MaLH = '" + MaLH + "'";
            return DataProvider.Instance.ExecuteScalar(query);
        }
        public int CheckTKB(string MaHV,  string MaLH)
        {
            string query = "select ThoiGianHoc, NgayBatDau from LOP_HOC where MaLH = '" + MaLH + "'";
            string ThoiGianHoc ="";
            string NgayBatDau ="";
            foreach (DataRow row in DataProvider.Instance.ExecuteQuery(query).Rows)
            {
                ThoiGianHoc = row["ThoiGianHoc"].ToString();
                NgayBatDau = row["NgayBatDau"].ToString();
            }
            string query2 = "select count(*) from  HOC_VIEN_TRONG_LOP hvtl inner join LOP_HOC l on hvtl.MaLH = l.MaLH " +
                "where hvtl.MaHV = '"+ MaHV +"' and l.ThoiGianHoc = '"+ ThoiGianHoc +"' and l.NgayBatDau = '"+ NgayBatDau +"'";
            return DataProvider.Instance.ExecuteScalar(query2);
        }
        public int AddToClass(string MaHV, string MaLH)
        {
            string query1 = "Select SoLuongHV from LOP_HOC where MaLH = '" + MaLH + "'";
            int SoLuongHV = 0;
            foreach (DataRow row in DataProvider.Instance.ExecuteQuery(query1).Rows)
            {
                SoLuongHV = int.Parse(row["SoLuongHV"].ToString());
            }
            SoLuongHV++;
            string query2 = "Update LOP_HOC set SoLuongHV = '" + SoLuongHV + "' where MaLH = '" + MaLH + "'";
            DataProvider.Instance.ExecuteQuery(query2);
            string query = "Insert into HOC_VIEN_TRONG_LOP values ('" + MaHV + "','" + MaLH + "','',N'Chưa đóng học phí')";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int RemoveFromClass(string MaHV, string MaLH)
        {
            string query1 = "Select SoLuongHV from LOP_HOC where MaLH = '" + MaLH + "'";
            int SoLuongHV = 0;
            foreach (DataRow row in DataProvider.Instance.ExecuteQuery(query1).Rows)
            {
                SoLuongHV = int.Parse(row["SoLuongHV"].ToString());
            }
            SoLuongHV--;
            string query2 = "Update LOP_HOC set SoLuongHV = '" + SoLuongHV + "' where MaLH = '" + MaLH + "'";
            DataProvider.Instance.ExecuteQuery(query2);
            string query = "Delete from HOC_VIEN_TRONG_LOP where MaHV = '" + MaHV + "' and MaLH = '" + MaLH + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public DataTable SortLisstStudentInClass(string MaLH)
        {
            string query = "Select hvtl.MaLH, hvtl.MaHV, hv.HoTenHV, hvtl.KetQuaHoc, hvtl.TinhTrang from HOC_VIEN_TRONG_LOP hvtl inner join HOC_VIEN hv on hvtl.MaHV = hv.MaHV" +
                " where MaLH = '" + MaLH + "' Order by hvtl.KetQuaHoc";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetSoLuongHV(string tenmon, string malh)
        {
            string query = "select SoLuongHV from LOP_HOC lh inner join MON_HOC mh on lh.MaMH = mh.MaMH " +
                "where mh.TenMon = N'" + tenmon + "' and MaLH like '" + malh + "%'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
