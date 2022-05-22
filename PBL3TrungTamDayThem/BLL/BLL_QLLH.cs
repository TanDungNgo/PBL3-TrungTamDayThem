using PBL3TrungTamDayThem.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
