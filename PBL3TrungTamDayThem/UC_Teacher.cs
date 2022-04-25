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
            GetCBB();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormTeacher frm = new FormTeacher();
            frm.ShowDialog();
        }
        //public DataTable GetData(string query)
        //{
        //    string cnnSTR = @"Data Source=DELL\SQLEXPRESS;Initial Catalog=TrungTamDayThem;Integrated Security=True";
        //    SqlConnection cnn = new SqlConnection(cnnSTR);
        //    cnn.Open();
        //    SqlCommand cmd = new SqlCommand(query, cnn);
        //    DataTable data = new DataTable();
        //    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //    adapter.Fill(data);
        //    cnn.Close();
        //    return data;
        //}
        public List<string> Get_Expertise()
        {
            List<string> expertise = new List<string>();
            string cnnSTR = @"Data Source=DELL\SQLEXPRESS;Initial Catalog=TrungTamDayThem;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(cnnSTR);
            cnn.Open();
            DataTable data = new DataTable();
            string query = "SELECT ChuyenMon FROM GIAO_VIEN";
            SqlCommand cmd = new SqlCommand(query, cnn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(data);
            cnn.Close();
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
            string cnnSTR = @"Data Source=DELL\SQLEXPRESS;Initial Catalog=TrungTamDayThem;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(cnnSTR);
            cnn.Open();
            DataTable data = new DataTable();
            if (cbbExpertise.Text == "All")
            {
                string query = "SELECT * FROM GIAO_VIEN";
                SqlCommand cmd = new SqlCommand(query, cnn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
            }  
            else
            {
                string expertise = cbbExpertise.Text;
                string query = "SELECT * FROM GIAO_VIEN where ChuyenMon = N'" + expertise +"'";
                SqlCommand cmd = new SqlCommand(query, cnn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
            }    
            cnn.Close();
            return data;
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            dgvTeacher.DataSource = GetTeacher_ByEx();
        }
    }
}
