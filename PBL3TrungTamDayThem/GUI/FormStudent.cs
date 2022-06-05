using PBL3TrungTamDayThem.BLL;
using PBL3TrungTamDayThem.DTO;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PBL3TrungTamDayThem.GUI
{
    public partial class FormStudent : Form
    {
        private string _MaHV;
        public delegate void MyDel();
        public MyDel d { get; set; }
        public FormStudent(string MaHV = null)
        {
            InitializeComponent();
            this._MaHV = MaHV;
            SetGUI();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void SetGUI()
        {
            Student student = BLL_QLHV.Instance.GetHVByID(this._MaHV);
            if (student != null)
            {
                txtID.Text = student.MaHV;
                txtID.Enabled = false;
                txtName.Text = student.HoTenHV;
                dtpBirthDay.Text = student.NgaySinh.ToString();
                txtAddress.Text = student.DiaChi;
                txtPhone.Text = student.SDT;
                txtEmail.Text = student.Email;
                if (student.GioiTinh == "Nam")
                {
                    rbMale.Checked = true;
                }
                else
                    rbFemale.Checked = true;
            }
            else
            {
                int count = BLL_QLHV.Instance.Count() + 1;
                if (count < 10)
                {
                    txtID.Text = "HV00" + count.ToString();
                }
                else if (count < 100)
                {
                    txtID.Text = "HV0" + count.ToString();
                }
                else
                    txtID.Text = "HV" + count.ToString();
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
            if (isDigit(txtPhone.Text) == false || txtPhone.Text.Length != 10)
            {
                lblerphone.Visible = true;
                check = true;
            }
            else
                lblerphone.Visible = false;
            dtpBirthDay.MinDate = new DateTime(1982, 1, 1);
            dtpBirthDay.MaxDate = new DateTime(2004, 12, 31);
            if (dtpBirthDay.Value <= dtpBirthDay.MinDate || dtpBirthDay.Value >= dtpBirthDay.MaxDate)
            {
                lblerBD.Visible = true;
                check = true;
            }
            else
                lblerBD.Visible = false;
            return check;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Error() == false)
            {
                Student s = new Student
                {
                    MaHV = txtID.Text,
                    HoTenHV = txtName.Text,
                    NgaySinh = dtpBirthDay.Value.Date,
                    DiaChi = txtAddress.Text,
                    SDT = txtPhone.Text,
                    Email = txtEmail.Text,
                    GioiTinh = rbMale.Checked.ToString(),
                };
                BLL_QLHV.Instance.ExecuteDB(s);
                d();
                this.Dispose();
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
        }
        internal static bool isDigit(string v)
        {
            var isNumeric = !string.IsNullOrEmpty(v) && v.All(Char.IsDigit);
            return isNumeric;
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
