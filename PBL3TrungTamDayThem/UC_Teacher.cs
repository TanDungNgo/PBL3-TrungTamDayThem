using PBL3TrungTamDayThem.DAO;
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
                string cnnSTR = @"Data Source=DELL\SQLEXPRESS;Initial Catalog=TrungTamDayThem;Integrated Security=True";
                SqlConnection cnn = new SqlConnection(cnnSTR);
                cnn.Open();
                try
                {
                    string magv = null;
                    DataGridViewSelectedRowCollection data = dgvTeacher.SelectedRows;
                    foreach (DataGridViewRow row in data)
                    {
                        magv = data[0].Cells["MaGV"].Value.ToString();
                    }
                    string query = "Delete from GIAO_VIEN where MaGV = '" + magv + "'";
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    int ret = cmd.ExecuteNonQuery();
                    //dataProvider.ExecuteQuery(query);
                    //MessageBox.Show(dataProvider.ExecuteNonQuery(query).ToString());
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
                cnn.Close();
            }    
        }

        private void UC_Teacher_Load(object sender, EventArgs e)
        {
            GetCBB();
            cbbExpertise.Text = "All";
        }
        public string MaGV;
        private void btnEdit_Click(object sender, EventArgs e)
        {
            //FormTeacher f = new FormTeacher();
            //f.ShowDialog();
            MessageBox.Show(MaGV);
        }

        private void dgvTeacher_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewSelectedRowCollection data = dgvTeacher.SelectedRows;
            if (data.Count == 1)
            {
                MaGV = data[0].Cells["MaGV"].Value.ToString();
            }
        }
    }
}
