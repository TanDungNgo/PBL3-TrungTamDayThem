using PBL3TrungTamDayThem.DAL;
using PBL3TrungTamDayThem.DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3TrungTamDayThem.BLL
{
    public class BLL_User
    {
        private static BLL_User _Instance;
        public static BLL_User Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_User();
                return _Instance;
            }
            private set { }
        }
        private BLL_User()
        {

        }
        public void Update(User u)
        {
            if (DAL_User.Instance.UpdateUser(u) > 0)
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Cập nhật thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
