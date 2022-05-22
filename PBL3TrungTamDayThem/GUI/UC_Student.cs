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
            SetGUI();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormStudent frm = new FormStudent();
            frm.ShowDialog();
            DGVShow();
        }
        private void DGVShow()
        {
            dgvStudent.DataSource = BLL_QLHV.Instance.GetListStudent(cbbClass.Text, null);
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            DGVShow();
        }
        void SetCBB()
        {
            if (cbbClass != null)
            {
                cbbClass.Items.Clear();
            }
            cbbClass.Items.Add("All");
            cbbClass.Items.AddRange(BLL_QLHV.Instance.GetListCBB().ToArray());
            if (cbbSort != null)
            {
                cbbSort.Items.Clear();
            }
            cbbSort.Items.Add("HoTenHV");
            cbbSort.Items.Add("NgaySinh");
        }
        void SetGUI()
        {
            SetCBB();
            cbbClass.Text = "All";
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvStudent.SelectedRows.Count > 0)
            {
                DataGridViewSelectedRowCollection data = dgvStudent.SelectedRows;
                string MaHV = data[0].Cells["MaHV"].Value.ToString();
                if (MaHV == null)
                {
                    MessageBox.Show("Chưa chọn học viên muốn edit", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    FormStudent f = new FormStudent(MaHV);
                    f.ShowDialog();
                    DGVShow();
                }
            }   
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvStudent.DataSource = BLL_QLHV.Instance.GetListStudent(cbbClass.Text, txtName.Text);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvStudent.SelectedRows.Count > 0)
            {
                List<string> LMaHV = new List<string>();
                foreach (DataGridViewRow row in dgvStudent.SelectedRows)
                {
                    LMaHV.Add(row.Cells["MaHV"].Value.ToString());
                }
                if (MessageBox.Show("Bạn có thật sự muốn xóa ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
                {
                    BLL_QLHV.Instance.DeleteStudent(LMaHV);
                    DGVShow();
                }
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            dgvStudent.DataSource = BLL_QLHV.Instance.SortListStudent(cbbSort.Text);
        }
    }
}
