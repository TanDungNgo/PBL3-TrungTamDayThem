﻿using PBL3TrungTamDayThem.BLL;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PBL3TrungTamDayThem.GUI
{
    public partial class UC_Staff : UserControl
    {
        public string VaiTro { get; set; }
        public UC_Staff()
        {
            InitializeComponent();
            SetGUI();
        }
        private void DGVShow()
        {
            dgvStaff.DataSource = BLL_QLNV.Instance.GetListStaff(cbbPosition.Text, null);
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            DGVShow();
        }
        private void SetCBB()
        {
            if (cbbPosition != null)
                cbbPosition.Items.Clear();
            cbbPosition.Items.Add("All");
            cbbPosition.Items.AddRange(BLL_QLNV.Instance.GetListCBB().Distinct().ToArray());
            if (cbbSort != null)
                cbbSort.Items.Clear();
            cbbSort.Items.Add("Luong");
            cbbSort.Items.Add("HoTenNV");
            cbbSort.Items.Add("NgaySinh");
        }
        private void SetGUI()
        {
            SetCBB();
            cbbPosition.Text = "All";
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            MessageBox.Show(VaiTro);
            if (VaiTro == "Quản Lý")
            {
                DataGridViewSelectedRowCollection data = dgvStaff.SelectedRows;
                string MaNV = data[0].Cells["MaNV"].Value.ToString();
                if (MaNV == null)
                {
                    MessageBox.Show("Chưa chọn nhân viên muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (MessageBox.Show("Bạn có thật sự muốn xóa ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
                    {
                        BLL_QLNV.Instance.Delete(MaNV);
                        DGVShow();
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn không có chức năng này !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormStaff frm = new FormStaff();
            frm.ShowDialog();
            DGVShow();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvStaff.SelectedRows.Count > 0)
            {
                DataGridViewSelectedRowCollection data = dgvStaff.SelectedRows;
                string MaNV = data[0].Cells["MaNV"].Value.ToString();
                FormStaff f = new FormStaff(MaNV);
                f.ShowDialog();
                DGVShow();
            }
            else
                MessageBox.Show("Chưa chọn nhân viên muốn edit", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void btnSort_Click(object sender, EventArgs e)
        {
            if (cbbSort.Text == "")
                MessageBox.Show("Chọn cách sắp xếp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                dgvStaff.DataSource = BLL_QLNV.Instance.SortListStaff(cbbSort.Text);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvStaff.DataSource = BLL_QLNV.Instance.GetListStaff(cbbPosition.Text, txbName.Text);
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
