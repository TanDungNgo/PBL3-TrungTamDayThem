﻿using PBL3TrungTamDayThem.BLL;
using PBL3TrungTamDayThem.DAL;
using PBL3TrungTamDayThem.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PBL3TrungTamDayThem.GUI
{
    public partial class UC_Bill : UserControl
    {
        public string MaNV { get; set; }
        public UC_Bill()
        {
            InitializeComponent();
            SetGUI();
        }
        public void SetGUI()
        {
            SetCBB();
            cbbClass.Text = "All";
            cbbStatus.Text = "All";
        }
        public void SetCBB()
        {
            if (cbbClass != null)
            {
                cbbClass.Items.Clear();
            }
            cbbClass.Items.Add("All");
            cbbClass.Items.AddRange(BLL_QLHV.Instance.GetListCBB().ToArray());
            if (cbbContent != null)
            {
                cbbContent.Items.Clear();
            }
            cbbContent.Items.Add("T1 - T3");
            cbbContent.Items.Add("T4 - T6");
            cbbContent.Items.Add("T7 - T9");
            cbbContent.Items.Add("T10 - T12");
            if (cbbStatus != null)
            {
                cbbStatus.Items.Clear();
            }
            cbbStatus.Items.Add("Đã đóng học phí");
            cbbStatus.Items.Add("Chưa đóng học phí");
            cbbStatus.Items.Add("All");
        }
        void ShowDGV()
        {
            dgvStudent.DataSource = BLL_QLBL.Instance.GetListStudent(cbbClass.Text, null, "All");
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            ShowDGV();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {   
            dgvStudent.DataSource = BLL_QLBL.Instance.GetListStudent(cbbClass.Text, txtName.Text, cbbStatus.Text);
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvStudent.SelectedRows.Count == 1)
            {
                if(cbbContent.Text == "")
                {
                    MessageBox.Show("Chưa có nội dung", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }    
                DataGridViewSelectedRowCollection data = dgvStudent.SelectedRows;
                txbFee.Text = BLL_QLBL.Instance.GetFee(data[0].Cells["MaLH"].Value.ToString());
                Bill bill = new Bill
                {
                    MaHV = data[0].Cells["MaHV"].Value.ToString(),
                    MaLH = data[0].Cells["MaLH"].Value.ToString(),
                    MaNV = MaNV,
                    HocPhi = int.Parse(txbFee.Text),
                    NgayThuHP = DateTime.Now,
                    NoiDung = cbbContent.Text,
                    HoTenHV = data[0].Cells["HoTenHV"].Value.ToString()
                };
                BLL_QLBL.Instance.WriteFile(bill);
            }
            else if (dgvStudent.SelectedRows.Count > 1)
            {
                MessageBox.Show("Chọn 1 học viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
            else
            {
                MessageBox.Show("Chưa chọn học viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void cbbClass_TextChanged(object sender, EventArgs e)
        {
            if (cbbClass.Text != "All")
            {
                txbFee.Text = BLL_QLBL.Instance.GetFee(cbbClass.Text);
            }
        }

        private void btnPayFee_Click(object sender, EventArgs e)
        {
            if (dgvStudent.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Nhấn OK để hoàn thành trả phí", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
                {
                    if (cbbContent.Text == "")
                    {
                        MessageBox.Show("Chưa có nội dung", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    DataGridViewSelectedRowCollection data = dgvStudent.SelectedRows;
                    txbFee.Text = BLL_QLBL.Instance.GetFee(data[0].Cells["MaLH"].Value.ToString());
                    Bill bill = new Bill
                    {
                        MaHV = data[0].Cells["MaHV"].Value.ToString(),
                        MaLH = data[0].Cells["MaLH"].Value.ToString(),
                        MaNV = MaNV,
                        HocPhi = int.Parse(txbFee.Text),
                        NgayThuHP = DateTime.Now,
                        NoiDung = cbbContent.Text,
                    };
                    BLL_QLBL.Instance.PayFee(bill);
                }
                ShowDGV();
            }
            else
            {
                MessageBox.Show("Chưa chọn học viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void SizeMax()
        {
            pnlRight.Width = 550;
            pnlBotton.Height = 300;
        }
        public void SizeMin()
        {
            pnlRight.Width = 510;
            pnlBotton.Height = 175;
        }

        private void dgvStudent_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewSelectedRowCollection data = dgvStudent.SelectedRows;
            txbFee.Text = BLL_QLBL.Instance.GetFee(data[0].Cells["MaLH"].Value.ToString());
        }
        private void txtName_Enter(object sender, EventArgs e)
        {
            if (txtName.Text == "Nhập tên tìm kiếm")
            {
                txtName.Text = null;
            }
            txtName.ForeColor = Color.Black;
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if(txtName.Text == "")
            {
                txtName.Text = "Nhập tên tìm kiếm";
                txtName.ForeColor = Color.DarkGray;
            }
        }
    }
}
