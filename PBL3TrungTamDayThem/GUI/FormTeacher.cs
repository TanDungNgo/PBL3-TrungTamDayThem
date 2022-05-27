using PBL3TrungTamDayThem.BLL;
using PBL3TrungTamDayThem.DTO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PBL3TrungTamDayThem.GUI
{
    public partial class FormTeacher : Form
    {
        private string _MaGV;
        public FormTeacher(string MaGV = null)
        {
            InitializeComponent();
            this._MaGV = MaGV;
            SetGUI();
        }
        public void SetCBB()
        {
            if(cbbLevel != null)
                cbbLevel.Items.Clear();
            cbbLevel.Items.Add("Tiến sĩ");
            cbbLevel.Items.Add("Thạc sĩ");
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Error() == true)
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
                this.Dispose();
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
            if (cbbLevel.Text == "")
            {
                lblerlevel.Visible = true;
                check = false;
            }
            else
                lblerlevel.Visible = false;
            if (txtExpertise.Text == "")
            {
                lblerexpertise.Visible = true;
                check = false;
            }
            else
                lblerexpertise.Visible = false;
            if (txtSalary.Text == "")
            {
                lblersalary.Visible = true;
                check = false;
            }
            else
                check = true;
            if (isDigit(txtPhone.Text)==false && txtPhone.Text.Length < 11)
            {
                lblerphone.Visible = true;
                check = false;
            }
            else
                lblerphone.Visible = false;

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

        private void cbbLevel_TextChanged(object sender, EventArgs e)
        {
            if (cbbLevel.Text == "Tiến sĩ")
            {

            }    
        }
    }
}
