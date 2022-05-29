using PBL3TrungTamDayThem.BLL;
using PBL3TrungTamDayThem.DTO;
using System;
using System.Linq;
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
        public void SetCBB()
        {
            if(cbbPosition != null)
                cbbPosition.Items.Clear();
            cbbPosition.Items.Add("Nhân Viên");
            cbbPosition.Items.Add("Quản Lý");
        }
        public void SetGUI()
        {
            SetCBB();
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
                cbbPosition.Text = staff.ChucVu;
                txtSalary.Text = staff.Luong.ToString();
                dtpStarting.Text = staff.NgayVaoLam.ToString();
                if (staff.GioiTinh == "Nam")
                {
                    rbMale.Checked = true;
                }
                else
                    rbFemale.Checked = true;
            }
            else
            {
                int count = BLL_QLNV.Instance.Count() + 1;
                if (count < 10)
                {
                    txtID.Text = "NV00" + count.ToString();
                }
                else if (count < 100)
                {
                    txtID.Text = "NV0" + count.ToString();
                }
                else
                    txtID.Text = "NV" + count.ToString();
                txtSalary.Enabled = false;
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            dtpBirthDay.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            cbbPosition.Text = "";
            txtSalary.Text = "";
            dtpStarting.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public bool Error()
        {
            bool check = true;
            if (txtName.Text == "")
            {
                lblername.Visible = true;
                check = false;
            }
            else
                lblername.Visible = false;
            if (txtAddress.Text == "")
            {
                lbleraddress.Visible = true;
                check = false;
            }
            else
                lbleraddress.Visible = false;
            if (cbbPosition.Text == "")
            {
                lblerposition.Visible = true;
                check = false;
            }
            else
                lblerposition.Visible = false;
            if (txtEmail.Text == "")
            {
                lbleremail.Visible = true;
                check = false;
            }
            else
                lbleremail.Visible = false;
            if (txtSalary.Text == "")
            {
                lblersalary.Visible = true;
                check = false;
            }
            else
                lblersalary.Visible = false;
            if (isDigit(txtPhone.Text) == false && txtPhone.Text.Length < 11)
            {
                lblerphone.Visible = true;
                check = false;
            }
            else
                lblerphone.Visible = false;

            return check;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Error() == true)
            {
                Staff s = new Staff
                {
                    MaNV = txtID.Text,
                    HoTenNV = txtName.Text,
                    NgaySinh = dtpBirthDay.Value.Date,
                    DiaChi = txtAddress.Text,
                    SDT = txtPhone.Text,
                    Email = txtEmail.Text,
                    ChucVu = cbbPosition.Text,
                    Luong = int.Parse(txtSalary.Text),
                    NgayVaoLam = dtpStarting.Value.Date,
                    GioiTinh = rbMale.Checked.ToString(),
                };
                BLL_QLNV.Instance.ExecuteDB(s);
                this.Dispose();
            }
        }
        internal static bool isDigit(string v)
        {
            var isNumeric = !string.IsNullOrEmpty(v) && v.All(Char.IsDigit);
            return isNumeric;
        }

        private void cbbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbPosition.Text == "Quản Lý")
                txtSalary.Text = "5000000";
            if (cbbPosition.Text == "Nhân Viên")
                txtSalary.Text = "3000000";
        }
    }
}
