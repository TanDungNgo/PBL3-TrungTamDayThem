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
        }

    

        private void label1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            dtpBirthDay.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            
        }
    }
}
