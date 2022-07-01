using PBL3TrungTamDayThem.BLL;
using PBL3TrungTamDayThem.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PBL3TrungTamDayThem.GUI
{
    public partial class UC_Teacher : UserControl
    {
        public string VaiTro { get; set; }
        public UC_Teacher()
        {
            InitializeComponent();
            SetGUI();
        }
        private Teacher teacher = new Teacher();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (VaiTro == "Quản Lý")
            {
                FormTeacher frm = new FormTeacher();
                frm.d += new FormTeacher.MyDel(ShowDGV);
                frm.ShowDialog();
                SetGUI();
            }
            else
            {
                MessageBox.Show("Bạn không có chức năng này !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        void SetGUI()
        {
            SetCBB();
            cbbExpertise.Text = "All";
            cbbSort.Text = "HoTenGV";
        }
        void SetCBB()
        {
            if (cbbExpertise != null)
                cbbExpertise.Items.Clear();
            cbbExpertise.Items.Add("All");
            cbbExpertise.Items.AddRange(BLL_QLGV.Instance.GetListCBB().Distinct().ToArray());
            if (cbbSort != null)
                cbbSort.Items.Clear();
            cbbSort.Items.Add("Luong");
            cbbSort.Items.Add("HoTenGV");
            cbbSort.Items.Add("NgaySinh");
        }
        void ShowDGV()
        {
            dgvTeacher.DataSource = BLL_QLGV.Instance.GetListTeacher(cbbExpertise.Text, null);
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            ShowDGV();
            txtName.Clear();
            txtName.Text = "Nhập tên tìm kiếm";
            txtName.ForeColor = Color.DarkGray;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (VaiTro == "Quản Lý")
            {
                if (dgvTeacher.SelectedRows.Count > 0)
                {
                    List<string> LMaGV = new List<string>();
                    foreach (DataGridViewRow row in dgvTeacher.SelectedRows)
                    {
                        LMaGV.Add(row.Cells["MaGV"].Value.ToString());
                    }
                    if (MessageBox.Show("Bạn có thật sự muốn xóa ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
                    {
                        BLL_QLGV.Instance.DeleteTeacher(LMaGV);
                        SetGUI();
                        ShowDGV();
                    }
                }
                else
                    MessageBox.Show("Chưa chọn giáo viên muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bạn không có chức năng này !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (VaiTro == "Quản Lý")
            {
                if (dgvTeacher.SelectedRows.Count == 1)
                {
                    DataGridViewSelectedRowCollection data = dgvTeacher.SelectedRows;
                    string MaGV = data[0].Cells["MaGV"].Value.ToString();
                    FormTeacher frm = new FormTeacher(MaGV);
                    frm.d += new FormTeacher.MyDel(ShowDGV);
                    frm.ShowDialog();
                    SetGUI();
                }
                else if (dgvTeacher.SelectedRows.Count > 1)
                    MessageBox.Show("Chỉ chọn 1 giáo viên muốn edit", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Chưa chọn giáo viên muốn edit", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bạn không có chức năng này !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtName.Text == "Nhập tên tìm kiếm")
            {
                return;
            }   
            else
            {
                dgvTeacher.DataSource = BLL_QLGV.Instance.GetListTeacher(cbbExpertise.Text, txtName.Text);
            }    
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            dgvTeacher.DataSource = BLL_QLGV.Instance.SortListTeacher(cbbSort.Text, txtName.Text, cbbExpertise.Text);
        }
        public void SizeMax()
        {
            pnlBottom.Height = 500;
            pnlLeft.Width = 300;
            pnlRight.Width = 350;
            //panel3.Height = 60;
            //panel2.Height = 60;
            //panel1.Height = 60;
            txtName.Width = 250;
            btnSearch.Width = 120;
            //btnSearch.Height = 60;
            btnAdd.Width = 120;
            btnEdit.Width = 120;
            btnDel.Width = 120;
            btnShow.Width = 120;
            cbbSort.Width = 130;
            cbbExpertise.Width = 170;
            btnSort.Width = 120;

        }
        public void SizeMin()
        {
            pnlBottom.Height = 261;
            pnlLeft.Width = 196;
            pnlRight.Width = 177;
            //panel3.Height = 47;
            //panel2.Height = 47;
            //panel1.Height = 47;
            txtName.Width = 171;
            btnSearch.Width = 90;
            //btnSearch.Height = 45;
            btnAdd.Width = 97;
            //btnAdd.Height = 32;
            btnEdit.Width = 97;
            //btnEdit.Height = 32;
            btnDel.Width = 97;
            //btnDel.Height = 32;
            btnShow.Width = 97;
            //btnShow.Height = 32;
            cbbSort.Width = 117;
            cbbExpertise.Width = 120;
            btnSort.Width = 97;
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.Text = "Nhập tên tìm kiếm";
                txtName.ForeColor = Color.DarkGray;
            }
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            if(txtName.Text == "Nhập tên tìm kiếm")
            {
                txtName.Text = null;
            }
            txtName.ForeColor = Color.Black;
        }
    }
}
