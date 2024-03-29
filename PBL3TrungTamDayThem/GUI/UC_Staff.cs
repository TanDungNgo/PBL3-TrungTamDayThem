﻿using PBL3TrungTamDayThem.BLL;
using PBL3TrungTamDayThem.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PBL3TrungTamDayThem.GUI
{
    public partial class UC_Staff : UserControl
    {
        public string VaiTro { get; set; }
        public string MaNV { get; set; }
        public UC_Staff()
        {
            InitializeComponent();
            SetGUI();
        }
        private void ShowDGV()
        {
            dgvStaff.DataSource = BLL_QLNV.Instance.GetListStaff(cbbPosition.Text, null);
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            ShowDGV();
            txtName.Clear();
            txtName.Text = "Nhập tên tìm kiếm";
            txtName.ForeColor = Color.DarkGray;
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
            cbbSort.Text = "HoTenNV";
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (VaiTro == "Quản Lý")
            {
                if (dgvStaff.SelectedRows.Count > 0)
                {
                    List<string> LMaNV = new List<string>();
                    foreach (DataGridViewRow row in dgvStaff.SelectedRows)
                    {
                        if (row.Cells["MaNVien"].Value.ToString() == MaNV)
                        {
                            MessageBox.Show("Không thể xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        LMaNV.Add(row.Cells["MaNVien"].Value.ToString());
                    }
                    if (MessageBox.Show("Bạn có thật sự muốn xóa ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
                    {
                        BLL_QLNV.Instance.Delete(LMaNV);
                        SetGUI();
                        ShowDGV();
                    }
                }
                else
                    MessageBox.Show("Chưa chọn nhân viên muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bạn không có chức năng này !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (VaiTro == "Quản Lý")
            {
                FormStaff frm = new FormStaff();
                frm.d += new FormStaff.MyDel(ShowDGV);
                frm.ShowDialog();
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
                if (dgvStaff.SelectedRows.Count == 1)
                {
                    DataGridViewSelectedRowCollection data = dgvStaff.SelectedRows;
                    string MaNV = data[0].Cells["MaNVien"].Value.ToString();
                    FormStaff frm = new FormStaff(MaNV);
                    frm.d += new FormStaff.MyDel(ShowDGV);
                    frm.ShowDialog();
                }
                else if (dgvStaff.SelectedRows.Count > 1)
                    MessageBox.Show("Chỉ chọn 1 nhân viên muốn edit", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Chưa chọn nhân viên muốn edit", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bạn không có chức năng này !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnSort_Click(object sender, EventArgs e)
        {
            dgvStaff.DataSource = BLL_QLNV.Instance.SortListStaff(cbbSort.Text, txtName.Text, cbbPosition.Text);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "Nhập tên tìm kiếm")
            {
                return;
            }
            dgvStaff.DataSource = BLL_QLNV.Instance.GetListStaff(cbbPosition.Text, txtName.Text);
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
            cbbPosition.Width = 170;
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
            cbbPosition.Width = 153;
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
            if (txtName.Text == "Nhập tên tìm kiếm")
            {
                txtName.Text = null;
            }
            txtName.ForeColor = Color.Black;
        }
    }
}
