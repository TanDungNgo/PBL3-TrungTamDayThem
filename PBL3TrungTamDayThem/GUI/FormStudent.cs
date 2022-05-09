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
        public FormStudent()
        {
            InitializeComponent();
        }
        private Student _student = new Student();
        public FormStudent(Student student)
        {
            InitializeComponent();
            this._student = student;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormStudent_Load(object sender, EventArgs e)
        {
            txtID.Text = this._student.MaHV;
            txtName.Text = this._student.HoTenHV;
            //dtpBirthDay.Text = this._student.NgaySinh.ToString();
            txtAddress.Text = this._student.DiaChi;
            txtPhone.Text = this._student.SDT;
            txtMail.Text = this._student.Email;
            txtStatus.Text = this._student.TinhTrang;
            txtIDClass.Text = this._student.MaLH;
            if (this._student.GioiTinh == "Nam")
            {
                rbMale.Checked = true;
            }   
            else
                rbFemale.Checked = true;
        }
    }
}
