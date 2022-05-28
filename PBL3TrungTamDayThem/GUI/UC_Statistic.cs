using PBL3TrungTamDayThem.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PBL3TrungTamDayThem.GUI
{
    public partial class UC_Statistic : UserControl
    {
        public UC_Statistic()
        {
            InitializeComponent();
            SetCBB();
        }
        public void SetCBB()
        {
            if (comboBox1 != null)
                comboBox1.Items.Clear();
            comboBox1.Items.Add("2022");
            comboBox1.Items.Add("2021");
        }
        private void btnTKDT_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Chọn năm muốn thống kê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }    
            int ma = int.Parse(comboBox1.Text.Substring(2)) - 2;
            chart1.Series.Clear(); 
            chart1.Series.Add("DoanhThu");
            chart1.Titles.Clear();
            chart1.Titles.Add("Doanh thu của trung tâm năm " + comboBox1.Text);
            string query = "Select NoiDung from BIEN_LAI where MaLH like '" + ma + "%'";
            List<string> list = new List<string>();
            foreach (DataRow i in DataProvider.Instance.ExecuteQuery(query).Rows)
            {
               list.Add(i["NoiDung"].ToString());
            }
            foreach (string i in list.Distinct().ToList())
            {
               string query2 = "Select HocPhi from BIEN_LAI where NoiDung = '" + i + "' and MaLH like '" + ma + "%'";
               int sum = 0;
               foreach (DataRow row in DataProvider.Instance.ExecuteQuery(query2).Rows)
               {
                  sum += int.Parse(row["HocPhi"].ToString());
               }
               chart1.Series["DoanhThu"].Points.AddXY(i, sum);
            }
        }
        private void btnTKMH_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Chọn năm muốn thống kê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int ma = int.Parse(comboBox1.Text.Substring(2)) - 2;
            chart1.Series.Clear();
            chart1.Series.Add("SoLuong");
            chart1.Titles.Clear();
            chart1.Titles.Add("Thống kê số lượng học viên của từng môn học năm " + comboBox1.Text);
            string query = "Select TenMon from MON_HOC";
            List<string> list = new List<string>();
            foreach (DataRow i in DataProvider.Instance.ExecuteQuery(query).Rows)
            {
                list.Add(i["TenMon"].ToString());
            }
            foreach (string i in list.Distinct().ToList())
            {
                string query2 = "select SoLuongHV from LOP_HOC lh inner join MON_HOC mh on lh.MaMH = mh.MaMH where mh.TenMon = N'" + i + "' and MaLH like '" + ma + "%'";
                int sum = 0;
                foreach (DataRow row in DataProvider.Instance.ExecuteQuery(query2).Rows)
                {
                    sum += int.Parse(row["SoLuongHV"].ToString());
                }
                chart1.Series["SoLuong"].Points.AddXY(i, sum);
            }
            ////Chuyển kiểu biểu đồ hình tròn
            chart1.Series[0].ChartType = SeriesChartType.Pie;
        }
    }
}
