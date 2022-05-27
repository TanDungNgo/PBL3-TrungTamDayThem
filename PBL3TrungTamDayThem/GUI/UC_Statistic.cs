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
        }
        private void UC_Statistic_Load(object sender, System.EventArgs e)
        {
            string query = "select NoiDung from BIEN_LAI";
            List<string> list = new List<string>();
            foreach(DataRow i in DataProvider.Instance.ExecuteQuery(query).Rows)
            {
                list.Add(i["NoiDung"].ToString());
            }
            foreach (string i in list.Distinct().ToList())
            {
                string query2 = "select HocPhi from BIEN_LAI where NoiDung = '" + i + "'";
                int sum = 0;
                foreach (DataRow row in DataProvider.Instance.ExecuteQuery(query2).Rows)
                {
                    sum += int.Parse(row["HocPhi"].ToString());
                }
                chart1.Series["DoanhThu"].Points.AddXY(i, sum);
            }

        }
    }
}
