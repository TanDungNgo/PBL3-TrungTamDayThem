using PBL3TrungTamDayThem.BLL;
using PBL3TrungTamDayThem.DAL;
using PBL3TrungTamDayThem.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3TrungTamDayThem.GUI
{
    public partial class FormStaff : Form
    {
        private string _MaNV;
        public FormStaff(string MaNV = null)
        {
            InitializeComponent();
            this._MaNV = MaNV;
            SetGUI();
        }

        public void SetGUI()
        {
            Staff staff = BLL_QLNV.Instance.GetNVByID(this._MaNV);
            if (staff != null)
            {
                txtID.Text = staff.MaNV;
                txtID.Enabled = false;
                txtName.Text = staff.HoTenNV;
                dtpBirthDay.Text = staff.NgaySinh.ToString();
                txtAddress.Text = staff.DiaChi;
                txtPhone.Text = staff.SDT;
                txtEmail.Text = staff.Email;
                txtPosition.Text = staff.ChucVu;
                txtSalary.Text = staff.Luong.ToString();
                dtpStarting.Text = staff.NgayVaoLam.ToString();
                if (staff.GioiTinh == "Nam")
                {
                    rbMale.Checked = true;
                }
                else
                    rbFemale.Checked = true;
            }
        }
   

    

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            dtpBirthDay.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtPosition.Text = "";
            txtSalary.Text = "";
            dtpStarting.Text = "";
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            Staff s = new Staff
            {
                MaNV = txtID.Text,
                HoTenNV = txtName.Text,
                NgaySinh = dtpBirthDay.Value.Date,
                DiaChi = txtAddress.Text,
                SDT = txtPhone.Text,
                Email = txtEmail.Text,
                ChucVu = txtPosition.Text,
                Luong = int.Parse(txtSalary.Text),
                NgayVaoLam = dtpStarting.Value.Date,
                GioiTinh = rbMale.Checked.ToString(),
            };
            BLL_QLNV.Instance.ExecuteDB(s);
            this.Dispose();

        }
    }
}
