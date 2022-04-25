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
    public partial class UC_Staff : UserControl
    {
        public UC_Staff()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormStaff frm = new FormStaff();
            frm.ShowDialog();
        }
        public DataTable GetData(string query)
        {
            string cnnSTR = @"Data Source=DELL\SQLEXPRESS;Initial Catalog=TrungTamDayThem;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(cnnSTR);
            cnn.Open();
            SqlCommand cmd = new SqlCommand(query, cnn);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(data);
            cnn.Close();
            return data;
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM dbo.NHAN_VIEN";
            dgv_Staff.DataSource = GetData(query);
        }
    }
}
