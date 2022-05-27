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
    public partial class UC_Staff : UserControl
    {


        public UC_Staff()
        {
            InitializeComponent();
            setGUI();
        }
        private void DGVShow()
        {
            dgvStaff.DataSource = BLL_QLNV.Instance.GetListStaff(cbbPosition.Text, null);
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            DGVShow();
        }
        private void setGUI()
        {
            if (cbbPosition != null)
                cbbPosition.Items.Clear();
            cbbPosition.Items.Add("All");
            cbbPosition.Items.AddRange(BLL_QLNV.Instance.GetListCBB().Distinct().ToArray());
            cbbPosition.Text = "All";
            if (cbbSort != null)
                cbbSort.Items.Clear();
            cbbSort.Items.Add("Luong");
            cbbSort.Items.Add("HoTenNV");
            cbbSort.Items.Add("NgaySinh");
        }
        private void btnDel_Click(object sender, EventArgs e)
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormStaff frm = new FormStaff();
            frm.ShowDialog();
            DGVShow();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection data = dgvStaff.SelectedRows;
            string MaNV = data[0].Cells["MaNV"].Value.ToString();
            if (MaNV == null)
            {
                MessageBox.Show("Chưa chọn nhân viên muốn edit", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FormStaff f = new FormStaff(MaNV);
                f.ShowDialog();
                DGVShow();
            }

        }
        private void btnSort_Click(object sender, EventArgs e)
        {
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
