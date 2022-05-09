using PBL3TrungTamDayThem.DAO;
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

namespace PBL3TrungTamDayThem
{
    public partial class UC_Teacher : UserControl
    {
        public UC_Teacher()
        {
            InitializeComponent();
        }
        private Teacher teacher = new Teacher();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormTeacher frm = new FormTeacher();
            frm.ShowDialog();
            GetCBB();
        }
        public List<string> Get_Expertise()
        {
            List<string> expertise = new List<string>();
            DataTable data = new DataTable();
            string query = "SELECT ChuyenMon FROM GIAO_VIEN";
            DataProvider dataProvider = new DataProvider();
            data = dataProvider.ExecuteQuery(query);
            foreach (DataRow i in data.Rows)
            {
                expertise.Add(i["ChuyenMon"].ToString());
            }
            return expertise;
        }
        public void GetCBB()
        {
            if (cbbExpertise != null)
            {
                cbbExpertise.Items.Clear();
            }
            cbbExpertise.Items.Add("All");
            cbbExpertise.Items.AddRange(Get_Expertise().Distinct().ToArray());
        }
        public DataTable GetTeacher_ByEx()
        {
            DataProvider dataProvider = new DataProvider();
            DataTable data = new DataTable();
            if (cbbExpertise.Text == "All")
            {
                string query = "SELECT * FROM GIAO_VIEN";
                data = dataProvider.ExecuteQuery(query);
            }  
            else
            {
                string expertise = cbbExpertise.Text;
                string query = "SELECT * FROM GIAO_VIEN where ChuyenMon = N'" + expertise +"'";
                data = dataProvider.ExecuteQuery(query);
            }    
            return data;
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            dgvTeacher.DataSource = GetTeacher_ByEx();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                DataProvider dataProvider = new DataProvider();
                try
                {
                    string magv = null;
                    DataGridViewSelectedRowCollection data = dgvTeacher.SelectedRows;
                    foreach (DataGridViewRow row in data)
                    {
                        magv = data[0].Cells["MaGV"].Value.ToString();
                    }
                    string query = "Delete from GIAO_VIEN where MaGV = '" + magv + "'";
                    int ret = dataProvider.ExecuteNonQuery(query);
                    if (ret > 0)
                    {
                        dgvTeacher.DataSource = GetTeacher_ByEx();
                        GetCBB();
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }    
        }

        private void UC_Teacher_Load(object sender, EventArgs e)
        {
            GetCBB();
            cbbExpertise.Text = "All";
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (teacher.ID == null)
            {
                MessageBox.Show("Chưa chọn giáo viên muốn edit", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
            else
            {
                FormTeacher f = new FormTeacher(teacher);
                f.ShowDialog();
            }    
        }

        private void dgvTeacher_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewSelectedRowCollection data = dgvTeacher.SelectedRows;
            if (data.Count == 1)
            {
                teacher.ID = data[0].Cells["MaGV"].Value.ToString();
                teacher.Name = data[0].Cells["HoTenGV"].Value.ToString();
                teacher.Address = data[0].Cells["DiaChi"].Value.ToString();
                teacher.Phone = data[0].Cells["SDT"].Value.ToString();
                teacher.Mail = data[0].Cells["Email"].Value.ToString();
                teacher.Salary = data[0].Cells["Luong"].Value.ToString();
                teacher.Expertise = data[0].Cells["ChuyenMon"].Value.ToString();
                teacher.Level = data[0].Cells["TrinhDo"].Value.ToString();
                teacher.Gender = (bool)data[0].Cells["GioiTinh"].Value;
                teacher.BirthDay = data[0].Cells["NgaySinh"].Value.ToString();
            }
        }

    }
}
