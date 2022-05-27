using PBL3TrungTamDayThem.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PBL3TrungTamDayThem.GUI
{
    public partial class UC_Class : UserControl
    {
        public UC_Class()
        {
            InitializeComponent();
            SetGUI();
        }
        public void SetCBB()
        {
            if (cbbSubject != null)
            {
                cbbSubject.Items.Clear();
            }
            cbbSubject.Items.Add("All");
            cbbSubject.Items.AddRange(BLL_QLLH.Instance.GetListCBB().Distinct().ToArray());
        }
        public void SetGUI()
        {
            SetCBB();
            cbbSubject.Text = "All";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormClass frm = new FormClass();
            frm.ShowDialog();
        }
        public void DGVShow()
        {
            dgv_Class.DataSource = BLL_QLLH.Instance.GetListClass(cbbSubject.Text, cbbClass.Text);
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            DGVShow();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection data = dgv_Class.SelectedRows;
            string MaLH = data[0].Cells["MaLH"].Value.ToString();
            if (MaLH == null)
            {
                MessageBox.Show("Chưa chọn lớp học muốn edit", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FormClass f = new FormClass(MaLH);
                f.ShowDialog();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgv_Class.SelectedRows.Count > 0)
            {
                List<string> LMaLH = new List<string>();
                foreach (DataGridViewRow row in dgv_Class.SelectedRows)
                {
                    LMaLH.Add(row.Cells["MaLH"].Value.ToString());
                }
                if (MessageBox.Show("Bạn có thật sự muốn xóa ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
                {
                    BLL_QLLH.Instance.Delete(LMaLH);
                    SetGUI();
                    DGVShow();
                }
            }
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
