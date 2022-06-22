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
            if (cbbClass != null)
            {
                cbbClass.Items.Clear();
            }
            cbbClass.Items.AddRange(BLL_QLHV.Instance.GetListCBB().ToArray());
            if (cbbMaLH != null)
            {
                cbbMaLH.Items.Clear();
            }
            cbbMaLH.Items.AddRange(BLL_QLHV.Instance.GetListCBB().ToArray());
        }
        public void SetGUI()
        {
            SetCBB();
            cbbSubject.Text = "All";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormClass frm = new FormClass();
            frm.d += new FormClass.MyDel(ShowDGV);
            frm.ShowDialog();
        }
        public void ShowDGV()
        {
            dgv_Class.DataSource = BLL_QLLH.Instance.GetListClass(cbbSubject.Text, cbbClass.Text);
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            ShowDGV();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgv_Class.SelectedRows.Count == 1)
            {
                DataGridViewSelectedRowCollection data = dgv_Class.SelectedRows;
                string MaLH = data[0].Cells["MaLH"].Value.ToString();
                FormClass frm = new FormClass(MaLH);
                frm.d += new FormClass.MyDel(ShowDGV);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Chưa chọn lớp học muốn edit", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    ShowDGV();
                }
            }
        }
        public void SizeMax()
        {
            dgv_Class.Height = 120;
            pnlBottom.Height = 300;
            cbbClass.Width = 200;
            cbbSubject.Width = 200;
        }
        public void SizeMin()
        {
            dgv_Class.Height = 74;
            pnlBottom.Height = 132;
            cbbClass.Width = 101;
            cbbSubject.Width = 101;
        }

        private void btnShow2_Click(object sender, EventArgs e)
        {
            dgv_Student.DataSource = BLL_QLLH.Instance.GetHVByClass(cbbClass.Text);
        }

        private void btnAddtoclass_Click(object sender, EventArgs e)
        {
            if (txtMaHV.Text == "")
            {
                MessageBox.Show("Chưa nhập Mã học viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cbbMaLH.Text == "")
            {
                MessageBox.Show("Chưa nhập Mã lớp học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                BLL_QLLH.Instance.AddToClass(txtMaHV.Text, cbbMaLH.Text);
                ShowDGV();
                dgv_Student.DataSource = BLL_QLLH.Instance.GetHVByClass(cbbMaLH.Text);
            }    
        }

        internal static bool isMark(string m)
        {
            if (int.Parse(m) <= 10 && int.Parse(m) >= 0)
                return true;
            return false;
        }
        internal static bool isDigit(string v)
        {
            var isNumeric = !string.IsNullOrEmpty(v) && v.All(Char.IsDigit);
            return isNumeric;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgv_Student.SelectedRows.Count > 0)
            {
                DataGridViewSelectedRowCollection data = dgv_Student.SelectedRows;
                try
                {
                    string MaHV = data[0].Cells["MaHV"].Value.ToString();
                    string MaLH = data[0].Cells["MaLH"].Value.ToString();
                    if (MaHV == null)
                    {
                        MessageBox.Show("Chưa chọn học viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (txtKQH.Text == "")
                    {
                        MessageBox.Show("Chưa nhập điểm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else if (isDigit(txtKQH.Text) == false || isMark(txtKQH.Text) == false)
                    {
                        MessageBox.Show("Điểm chỉ từ 0 đến 10", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        BLL_QLLH.Instance.UpdateKQH(txtKQH.Text, MaHV, MaLH);
                        dgv_Student.DataSource = BLL_QLLH.Instance.GetHVByClass(cbbClass.Text);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Chưa chọn học viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
             }
            else
            {
                MessageBox.Show("Chưa chọn học viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgv_Student.SelectedRows.Count > 0)
            {
                DataGridViewSelectedRowCollection data = dgv_Student.SelectedRows;
                try
                {
                    string MaHV = data[0].Cells["MaHV"].Value.ToString();
                    string MaLH = data[0].Cells["MaLH"].Value.ToString();
                    if (MaHV == null)
                    {
                        MessageBox.Show("Chưa chọn học viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        BLL_QLLH.Instance.RemoveFromClass(MaHV, MaLH);
                        dgv_Student.DataSource = BLL_QLLH.Instance.GetHVByClass(cbbClass.Text);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Chưa chọn học viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn học viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            dgv_Student.DataSource = BLL_QLLH.Instance.SortListStudent(cbbClass.Text);
        }
    }
}
