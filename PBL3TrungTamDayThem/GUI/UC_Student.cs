using PBL3TrungTamDayThem.BLL;
using PBL3TrungTamDayThem.DTO;
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
            cbbSort.Items.Add("GioiTinh");
        }
        void SetGUI()
        {
            SetCBB();
            cbbClass.Text = "All";
            dgvStudent.DataSource = new List<Student>();
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
            else if (dgvStudent.SelectedRows.Count > 1)
                MessageBox.Show("Chỉ chọn 1 học viên muốn edit", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        public void SizeMax()
        {
            pnlBottom.Height = 500;
            pnlLeft.Width = 300;
            pnlRight.Width = 350;
            //panel1.Height = 60;
            //panel2.Height = 60;
            //panel3.Height = 60;
            txtName.Width = 250;
            btnSearch.Width = 120;
            //btnSearch.Height = 60;
            btnAdd.Width = 120;
            btnEdit.Width = 120;
            btnDel.Width = 120;
            btnShow.Width = 120;
            cbbSort.Width = 130;
            cbbClass.Width = 170;
            btnSort.Width = 120;
        }
        public void SizeMin()
        {
            pnlBottom.Height = 261;
            pnlLeft.Width = 196;
            pnlRight.Width = 177;
            //panel1.Height = 47;
            //panel2.Height = 47;
            //panel3.Height = 47;
            txtName.Width = 171;
            btnSearch.Width = 90;
            btnSearch.Height = 45;
            btnAdd.Width = 97;
            //btnAdd.Height = 32;
            btnEdit.Width = 97;
            //btnEdit.Height = 32;
            btnDel.Width = 97;
            //btnDel.Height = 32;
            btnShow.Width = 97;
            //btnShow.Height = 32;
            cbbSort.Width = 117;
            cbbClass.Width = 153;
            btnSort.Width = 97;
        }
    }
}
