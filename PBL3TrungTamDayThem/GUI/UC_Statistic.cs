using PBL3TrungTamDayThem.BLL;
using PBL3TrungTamDayThem.DAL;
using PBL3TrungTamDayThem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
            chart1.Series.Add("Doanh Thu");
            chart1.Titles.Clear();
            chart1.Titles.Add("Doanh thu của trung tâm năm " + comboBox1.Text);
            chart1.Titles[0].Font = new Font("Times New Roman", 20, FontStyle.Bold);
            List<string> list = new List<string>();
            list.Add("T1 - T3");
            list.Add("T4 - T6");
            list.Add("T7 - T9");
            list.Add("T10 - T12");
            int i = 0;
            foreach (string noidung in list.Distinct().ToList())
            {
                int sum = BLL_QLBL.Instance.GetHocPhi(noidung, malh.ToString());
                chart1.Series["Doanh Thu"].Points.Add(sum);
                chart1.Series["Doanh Thu"].Points[i].Label = sum.ToString("##,#") + "VNĐ";
                chart1.Series["Doanh Thu"].Points[i].AxisLabel = noidung;
                i = i + 1;
            }
            chart1.Legends[0].Enabled = true;
            chart1.Series[0].BackGradientStyle = GradientStyle.LeftRight;
            chart1.Series[0].BackSecondaryColor = Color.FromArgb(192,255,255);
            chart1.Series[0].BorderColor = Color.FromArgb(255, 255, 128);
            chart1.Series[0].ChartType = SeriesChartType.SplineArea;
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
            chart1.Titles[0].Font = new Font("Times New Roman", 20, FontStyle.Bold);
            List<string> listMH = new List<string>();
            listMH.AddRange(BLL_QLLH.Instance.GetSubjectInClass(malh.ToString()).Distinct().ToArray());
            foreach (string monhoc in listMH.Distinct().ToList())
            {
                int sum = BLL_QLLH.Instance.SoLuongHV(monhoc, malh.ToString());
                chart1.Series["SoLuong"].Points.AddXY(monhoc, sum);
            }
            //Chuyển kiểu biểu đồ hình tròn
            chart1.Legends[0].Enabled = true;
            chart1.Series[0].ChartType = SeriesChartType.Doughnut;
            chart1.Series[0].BorderWidth = 4;
            chart1.Series[0].BorderColor = Color.White;
            chart1.Series[0].LabelForeColor = Color.White;
        }

        private void btn_TKGV_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Chọn năm muốn thống kê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int malh = int.Parse(comboBox1.Text.Substring(2));
            chart1.Series.Clear();
            chart1.Series.Add("Lớp");
            chart1.Titles.Clear();
            chart1.Titles.Add("Số lớp của từng giáo viên trong năm " + comboBox1.Text);
            chart1.Titles[0].Font = new Font("Times New Roman", 20, FontStyle.Bold);
            List<Teacher> list = BLL_QLGV.Instance.GetAllTeacher();
            int i = 0;
            Random r = new Random();
            foreach (Teacher t in list.Distinct().ToList())
            {
                int sum = BLL_QLBL.Instance.GetCountClass(t.MaGV, malh.ToString());
                chart1.Series["Lớp"].Points.Add(sum);
                chart1.Series["Lớp"].Points[i].Label = sum.ToString();
                chart1.Series["Lớp"].Points[i].AxisLabel = t.HoTenGV;
                //if (i % 2 == 0)
                //    chart1.Series["Lớp"].Points[i].Color = Color.RoyalBlue;
                //else
                //    chart1.Series["Lớp"].Points[i].Color = Color.DodgerBlue;
                chart1.Series["Lớp"].Points[i].Color = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256)); ;
                i = i + 1;
            }
            chart1.Legends[0].Enabled = false;
        }
    }
}
