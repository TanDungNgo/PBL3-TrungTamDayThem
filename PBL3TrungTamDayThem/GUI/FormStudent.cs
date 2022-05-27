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
    public partial class FormStudent : Form
    {
        private string _MaHV;
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
            if (txtEmail.Text == "")
            {
                lbleremail.Visible = true;
                check = false;
            }
            else
                lbleremail.Visible = false;
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
    }
}
