using PBL3TrungTamDayThem.BLL;
using PBL3TrungTamDayThem.DTO;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PBL3TrungTamDayThem.GUI
{
    public partial class FormTeacher : Form
    {
        private string _MaGV;
        public delegate void MyDel();
        public MyDel d { get; set; }
        public FormTeacher(string MaGV = null)
        {
            InitializeComponent();
            this._MaGV = MaGV;
            SetGUI();
        }
        public void SetCBB()
        {
            if (cbbLevel != null)
                cbbLevel.Items.Clear();
            cbbLevel.Items.Add("Tiến sĩ");
            cbbLevel.Items.Add("Thạc sĩ");
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Error() == false)
            {
                Teacher teacher = new Teacher
                {
                    MaGV = txtID.Text,
                    HoTenGV = txtName.Text,
                    NgaySinh = dtpBD.Value.Date,
                    DiaChi = txtAddress.Text,
                    SDT = txtPhone.Text,
                    Email = txtEmail.Text,
                    GioiTinh = rbMale.Checked.ToString(),
                    ChuyenMon = txtExpertise.Text,
                    TrinhDo = cbbLevel.Text,
                    Luong = txtSalary.Text,
                };
                BLL_QLGV.Instance.ExecuteDB(teacher);
                d();
                this.Dispose();
            }
        }
        public bool Error()
        {
            bool check = false;
            if (txtName.Text == "")
            {
                lblername.Visible = true;
                check = true;
            }
            else
            {
                lblername.Visible = false;
                if (isName(txtName.Text) == false)
                {
                    lblername2.Visible = true;
                    check = true;
                }
                else
                    lblername2.Visible = false;
            }
            if (txtAddress.Text == "")
            {
                lbleraddress.Visible = true;
                check = true;
            }
            else
                lbleraddress.Visible = false;
            if (txtEmail.Text == "")
            {
                lbleremail.Visible = true;
                check = true;
            }
            else
            {
                lbleremail.Visible = false;
                if (isMail(txtEmail.Text) == false)
                {
                    lbleremail2.Visible = true;
                    check = true;
                }
                else
                    lbleremail2.Visible = false;
            }
            if (cbbLevel.Text == "")
            {
                lblerlevel.Visible = true;
                check = true;
            }
            else
                lblerlevel.Visible = false;
            if (txtExpertise.Text == "")
            {
                lblerexpertise.Visible = true;
                check = true;
            }
            else
                lblerexpertise.Visible = false;
            if (txtSalary.Text == "")
            {
                lblersalary.Visible = true;
                check = true;
            }
            else
            {
                lblersalary.Visible = false;
                if (isDigit(txtSalary.Text) == false || isSalary(txtSalary.Text) == false)
                {
                    lblersalary2.Visible = true;
                    check = true;
                }
                else
                    lblersalary2.Visible = false;
            }

            if (isDigit(txtPhone.Text) == false || txtPhone.Text.Length != 10)
            {
                lblerphone.Visible = true;
                check = true;
            }
            else
                lblerphone.Visible = false;
            dtpBD.MinDate = new DateTime(1962, 1, 1);
            dtpBD.MaxDate = new DateTime(2004, 12, 31);
            if (dtpBD.Value <= dtpBD.MinDate || dtpBD.Value >= dtpBD.MaxDate)
            {
                lblerBD.Visible = true;
                check = true;
            }
            else
                lblerBD.Visible = false;
            return check;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            cbbLevel.Text = "";
            txtExpertise.Text = "";
            txtSalary.Text = "";
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetGUI()
        {
            SetCBB();
            Teacher teacher = BLL_QLGV.Instance.GetGVByID(this._MaGV);
            if (teacher != null)
            {
                txtID.Text = teacher.MaGV;
                txtID.Enabled = false;
                txtName.Text = teacher.HoTenGV;
                txtPhone.Text = teacher.SDT;
                txtAddress.Text = teacher.DiaChi;
                txtEmail.Text = teacher.Email;
                txtSalary.Text = teacher.Luong;
                txtExpertise.Text = teacher.ChuyenMon;
                cbbLevel.Text = teacher.TrinhDo;
                dtpBD.Text = teacher.NgaySinh.ToString();
                if (teacher.GioiTinh == "Nam")
                {
                    rbMale.Checked = true;
                }
                else
                    rbFemale.Checked = true;
            }
            else
            {
                int count = BLL_QLGV.Instance.Count() + 1;
                if (count < 10)
                {
                    txtID.Text = "GV00" + count.ToString();
                }
                else if (count < 100)
                {
                    txtID.Text = "GV0" + count.ToString();
                }
                else
                    txtID.Text = "GV" + count.ToString();

            }
        }
        internal static bool isDigit(string v)
        {
            var isNumeric = !string.IsNullOrEmpty(v) && v.All(Char.IsDigit);
            return isNumeric;
        }
        internal static bool isSalary(string m)
        {
            if (int.Parse(m) <= 20000000 && int.Parse(m) >= 10000000)
                return true;
            return false;
        }
        internal static bool isName(string name)
        {
            bool match = Regex.IsMatch(name, "^[^0-9]+[^0-9]$");
            return match;
        }
        internal static bool isMail(string mail)
        {
            bool match = Regex.IsMatch(mail, @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
            return match;
        }
    }
}
