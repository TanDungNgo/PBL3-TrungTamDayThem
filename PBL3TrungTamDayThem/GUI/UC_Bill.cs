using PBL3TrungTamDayThem.BLL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PBL3TrungTamDayThem.GUI
{
    public partial class UC_Bill : UserControl
    {
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
                DataGridViewSelectedRowCollection data = dgvStudent.SelectedRows;
                string HoTenHV = data[0].Cells["HoTenHV"].Value.ToString();
                List<string> list = new List<string>();
                list.Add(cbbClass.Text);
                list.Add(HoTenHV);
                list.Add(txbFee.Text);
                BLL_QLBL.Instance.WriteFile(list);
            }
            else
            {
                MessageBox.Show("Chưa chọn học viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void cbbClass_TextChanged(object sender, EventArgs e)
        {
            if (cbbClass.Text != null)
            {
                txbFee.Text = BLL_QLBL.Instance.GetFee(cbbClass.Text);
            }
        }

        private void btnPayFee_Click(object sender, EventArgs e)
        {
            if (dgvStudent.SelectedRows.Count > 0)
            {
                DataGridViewSelectedRowCollection data = dgvStudent.SelectedRows;
                string HoTenHV = data[0].Cells["HoTenHV"].Value.ToString();
                BLL_QLBL.Instance.PayFee(HoTenHV, cbbClass.Text);
                dgvStudent.DataSource = BLL_QLBL.Instance.GetListStudent(cbbClass.Text, txbName.Text);
            }
            else
            {
                MessageBox.Show("Chưa chọn học viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
