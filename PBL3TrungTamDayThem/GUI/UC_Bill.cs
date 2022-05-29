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
        public string MaNV { get; set; }
        public UC_Bill()
        {
            InitializeComponent();
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
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvStudent.SelectedRows.Count > 0)
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
                dgvStudent.DataSource = BLL_QLBL.Instance.GetListStudent(cbbClass.Text, txbName.Text);
            }
            else
            {
                MessageBox.Show("Chưa chọn học viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void SizeDGVMax()
        {
            pnlRight.Width = 550;
        }
        public void SizeDGVMin()
        {
            pnlRight.Width = 510;
        }
    }
}
