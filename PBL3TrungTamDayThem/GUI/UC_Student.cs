using PBL3TrungTamDayThem.BLL;
using System;
using System.Collections.Generic;
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
            frm.d += new FormStudent.MyDel(ShowDGV);
            frm.ShowDialog();
            SetGUI();
        }
        private void ShowDGV()
        {
            dgvStudent.DataSource = BLL_QLHV.Instance.GetListStudent(cbbClass.Text, null);
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            ShowDGV();
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
            if (dgvStudent.SelectedRows.Count == 1)
            {
                DataGridViewSelectedRowCollection data = dgvStudent.SelectedRows;
                string MaHV = data[0].Cells["MaHV"].Value.ToString();
                FormStudent frm = new FormStudent(MaHV);
                frm.d += new FormStudent.MyDel(ShowDGV);
                frm.ShowDialog();
                SetGUI();
            }
            else
            {
                MessageBox.Show("Chưa chọn học viên muốn edit", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    ShowDGV();
                    SetGUI();
                }
            }
            else
                MessageBox.Show("Chưa chọn học viên muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (cbbSort.Text == "")
                MessageBox.Show("Chọn cách sắp xếp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                dgvStudent.DataSource = BLL_QLHV.Instance.SortListStudent(cbbSort.Text,cbbClass.Text);
        }
        public void SizeDGVMax()
        {
            pnlBottom.Height = 460;
        }
        public void SizeDGVMin()
        {
            pnlBottom.Height = 261;
        }
    }
}
