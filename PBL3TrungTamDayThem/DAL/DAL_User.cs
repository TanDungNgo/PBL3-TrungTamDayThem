using PBL3TrungTamDayThem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3TrungTamDayThem.DAL
{
    public class DAL_User
    {
        private static DAL_User _Instance;
        public static DAL_User Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new DAL_User();
                return _Instance;
            }
            private set { }
        }
        private DAL_User()
        {
        }
        public User GetUserByMaNV(string MaNV)
        {
            string query = "Select * from ACCOUNT where MaNV = '" + MaNV + "'";
            DataRow i = DataProvider.Instance.ExecuteQuery(query).Rows[0];
            return new User
            {
                MaNV = i["MaNV"].ToString(),
                Username = i["Username"].ToString(),
                Pass = i["Pass"].ToString(),
                DisplayName = i["DisplayName"].ToString(),
                PhanQuyen = (bool)i["PhanQuyen"],
                //Anh = (byte[])i["Anh"]
            };
        }
        public int UpdateUser(User u)
        {
            string query = "Update ACCOUNT set MaNV = '" + u.MaNV + "',Username = N'" + u.Username + "',Pass = '" + u.Pass +
                                    "',DisplayName = '" + u.DisplayName + "',PhanQuyen = '" + u.PhanQuyen +
                                    "' where MaNV = '" + u.MaNV + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
