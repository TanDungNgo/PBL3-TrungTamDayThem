using PBL3TrungTamDayThem.BLL;
using PBL3TrungTamDayThem.DAL;
using PBL3TrungTamDayThem.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PBL3TrungTamDayThem.GUI
{
    public partial class UC_Bill : UserControl
    {
        private string _MaNV;
        public UC_Bill(string MaNV)
        {
            InitializeComponent();
            this._MaNV = MaNV;
            SetGUI();
        }
        void SetGUI()
        {
            SetCBB();
            cbbClass.Text = "All";
        }
        void SetCBB()
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
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            dgvStudent.DataSource = BLL_QLBL.Instance.GetListStudent(cbbClass.Text, null);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvStudent.DataSource = BLL_QLBL.Instance.GetListStudent(cbbClass.Text, txbName.Text);
        }
        public bool Error()
        {
            bool check = true;
            if (cbbContent.Text == "")
            {
                lblercontent.Visible = true;
                check = false;
            }
            else
                lblercontent.Visible = false;

            return check;
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvStudent.SelectedRows.Count > 0)
            {
                DataGridViewSelectedRowCollection data = dgvStudent.SelectedRows;
                txbFee.Text = BLL_QLBL.Instance.GetFee(data[0].Cells["MaLH"].Value.ToString());
                Bill bill = new Bill
                {
                    MaHV = data[0].Cells["MaHV"].Value.ToString(),
                    MaLH = data[0].Cells["MaLH"].Value.ToString(),
                    MaNV = this._MaNV,
                    HocPhi = int.Parse(txbFee.Text),
                    NgayThuHP = DateTime.Now,
                    NoiDung = cbbContent.Text,
                    HoTenHV = data[0].Cells["HoTenHV"].Value.ToString()
                };
                BLL_QLBL.Instance.WriteFile(bill);
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
                DataGridViewSelectedRowCollection data = dgvStudent.SelectedRows;
                Bill bill = new Bill
                {
                    MaHV = data[0].Cells["MaHV"].Value.ToString(),
                    MaLH = data[0].Cells["MaLH"].Value.ToString(),
                };
                BLL_QLBL.Instance.PayFee(bill);
                dgvStudent.DataSource = BLL_QLBL.Instance.GetListStudent(cbbClass.Text, txbName.Text);
            }
            else
            {
                MessageBox.Show("Chưa chọn học viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
