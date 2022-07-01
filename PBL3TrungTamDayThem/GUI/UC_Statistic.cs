using PBL3TrungTamDayThem.BLL;
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
            int malh = int.Parse(comboBox1.Text.Substring(2));
            chart1.Series.Clear();
            chart1.Series.Add("DoanhThu");
            chart1.Titles.Clear();
            chart1.Titles.Add("Doanh thu của trung tâm năm " + comboBox1.Text);
            List<string> list = new List<string>();
            list.Add("T1 - T3");
            list.Add("T4 - T6");
            list.Add("T7 - T9");
            list.Add("T10 - T12");
            int i= 0;
            foreach (string noidung in list.Distinct().ToList())
            {
                int sum = BLL_QLBL.Instance.GetHocPhi(noidung, malh.ToString());
                chart1.Series["DoanhThu"].Points.Add(sum);
                chart1.Series["DoanhThu"].Points[i].Label = sum.ToString("##,#") + "VNĐ";
                chart1.Series["DoanhThu"].Points[i].AxisLabel = noidung;
                i = i + 1;
            }
        }
        private void btnTKMH_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Chọn năm muốn thống kê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int malh = int.Parse(comboBox1.Text.Substring(2));
            chart1.Series.Clear();
            chart1.Series.Add("SoLuong");
            chart1.Titles.Clear();
            chart1.Titles.Add("Thống kê số lượng học viên của từng môn học năm " + comboBox1.Text);
            List<string> listMH = new List<string>();
            listMH.AddRange(BLL_QLLH.Instance.GetSubjectInClass(malh.ToString()).Distinct().ToArray());
            foreach (string monhoc in listMH.Distinct().ToList())
            {
                int sum = BLL_QLLH.Instance.SoLuongHV(monhoc, malh.ToString());
                chart1.Series["SoLuong"].Points.AddXY(monhoc, sum);
            }
            //Chuyển kiểu biểu đồ hình tròn
            chart1.Series[0].ChartType = SeriesChartType.Pie;
        }
    }
}
