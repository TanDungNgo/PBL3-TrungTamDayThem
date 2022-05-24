using PBL3TrungTamDayThem.BLL;
using PBL3TrungTamDayThem.DAL;
using PBL3TrungTamDayThem.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
      

        private void btnSave_MouseMove(object sender, MouseEventArgs e)
        {
            btnSave.BackColor = Color.MediumSeaGreen;
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.White;
        }


        private void btnReset_MouseMove(object sender, MouseEventArgs e)
        {
            btnReset.BackColor = Color.DeepSkyBlue;
        }

        private void btnReset_MouseLeave(object sender, EventArgs e)
        {
            btnReset.BackColor = Color.White;
        }

        private void btnBack_MouseMove(object sender, MouseEventArgs e)
        {
            btnBack.BackColor = Color.Crimson;
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.BackColor = Color.White;
        }

       

        private void SetGUI()
        {
            Teacher teacher = BLL_QLGV.Instance.GetGVByID(this._MaGV);
            if (teacher != null)
            {
                txtID.Text = teacher.MaGV;
                txtID.Enabled = false;
                txtName.Text = teacher.HoTenGV;
                txtPhone.Text = teacher.SDT;
                txtAddress.Text = teacher.DiaChi;
                txtMail.Text = teacher.Email;
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
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            txtMail.Text = "";
            cbbLevel.Text = "";
            txtExpertise.Text = "";
            txtSalary.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher
            {
                MaGV = txtID.Text,
                HoTenGV = txtName.Text,
                NgaySinh = dtpBD.Value.Date,
                DiaChi = txtAddress.Text,
                SDT = txtPhone.Text,
                Email = txtMail.Text,
                GioiTinh = rbMale.Checked.ToString(),
                ChuyenMon = txtExpertise.Text,
                TrinhDo = cbbLevel.Text,
                Luong = txtSalary.Text,
            };
            BLL_QLGV.Instance.ExecuteDB(teacher);
            this.Dispose();
        }

       

    }
}
