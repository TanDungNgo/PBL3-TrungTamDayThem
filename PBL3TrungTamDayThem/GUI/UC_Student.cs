using PBL3TrungTamDayThem.BLL;
using PBL3TrungTamDayThem.DAL;
using PBL3TrungTamDayThem.DTO;
using PBL3TrungTamDayThem.GUI;
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
    public partial class UC_Student : UserControl
    {
        public UC_Student()
        {
            InitializeComponent();
        }
        private Student student = new Student();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormStudent frm = new FormStudent();
            frm.ShowDialog();
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            dgvStudent.DataSource = DAL_QLHV.Instance.GetAllStudent();
        }

        private void UC_Student_Load(object sender, EventArgs e)
        {
            if (cbbclass != null)
            {
                cbbclass.Items.Clear();
            }
            cbbclass.Items.Add(new CBBItem { Value = "All" });
            cbbclass.Items.AddRange(BLL_QLHV.Instance.GetListCBB().ToArray());
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (student.MaHV == null)
            {
                MessageBox.Show("Chưa chọn học viên muốn edit", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FormStudent f = new FormStudent(student);
                f.ShowDialog();
            }
        }

        private void dgvStudent_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewSelectedRowCollection data = dgvStudent.SelectedRows;
            if (data.Count == 1)
            {
                student.MaHV = data[0].Cells["MaHV"].Value.ToString();
                student.HoTenHV = data[0].Cells["HoTenHV"].Value.ToString();
                student.DiaChi = data[0].Cells["DiaChi"].Value.ToString();
                student.SDT = data[0].Cells["SDT"].Value.ToString();
                student.Email = data[0].Cells["Email"].Value.ToString();
                student.GioiTinh = data[0].Cells["GioiTinh"].Value.ToString();
                student.NgaySinh = (DateTime)data[0].Cells["NgaySinh"].Value;
                student.TinhTrang = data[0].Cells["TinhTrang"].Value.ToString();
                student.MaLH = data[0].Cells["MaLH"].Value.ToString();
            }
        }
    }
}
