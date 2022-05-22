using PBL3TrungTamDayThem.BLL;
using PBL3TrungTamDayThem.DAL;
using PBL3TrungTamDayThem.DTO;
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
    public partial class UC_Teacher : UserControl
    {
        public UC_Teacher()
        {
            InitializeComponent();
            SetGUI();
        }
        private Teacher teacher = new Teacher();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormTeacher frm = new FormTeacher();
            frm.ShowDialog();
            SetGUI();
        }
        void SetGUI()
        {
            SetCBB();
            cbbExpertise.Text = "All";
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
        void DGVShow()
        {
            dgvTeacher.DataSource = BLL_QLGV.Instance.GetListTeacher(cbbExpertise.Text, null);
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            DGVShow();
        }

        private void btnDel_Click(object sender, EventArgs e)
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
                    DGVShow();
                    BLL_QLGV.Instance.DeleteTeacher(LMaGV);
                    SetGUI();
                    DGVShow();
                }
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvTeacher.SelectedRows.Count > 0)
            {
                DataGridViewSelectedRowCollection data = dgvTeacher.SelectedRows;
                string MaGV = data[0].Cells["MaGV"].Value.ToString();
                FormTeacher f = new FormTeacher(MaGV);
                f.ShowDialog();
                SetGUI();
                DGVShow();
            }
            else
                MessageBox.Show("Chưa chọn giáo viên muốn edit", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvTeacher.DataSource = BLL_QLGV.Instance.GetListTeacher(cbbExpertise.Text, txtName.Text);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            dgvTeacher.DataSource = BLL_QLGV.Instance.SortListTeacher(cbbSort.Text);
        }
    }
}
