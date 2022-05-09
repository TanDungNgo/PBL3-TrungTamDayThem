using PBL3TrungTamDayThem.DAL;
using PBL3TrungTamDayThem.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
