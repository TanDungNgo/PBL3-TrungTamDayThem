using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3TrungTamDayThem.DAO
{
    public  class DataProvider
    {
        private string cnnSTR = @"Data Source=.\SQLEXPRESS;Initial Catalog=TrungTamDayThem;Integrated Security=True";

        public DataTable ExecuteQuery(string query)
        {
            SqlConnection cnn = new SqlConnection(cnnSTR);
            cnn.Open();
            SqlCommand cmd = new SqlCommand(query, cnn);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(data);
            cnn.Close();
            return data;
        }
        public int ExecuteNonQuery(string query)
        {
            SqlConnection cnn = new SqlConnection(cnnSTR);
            cnn.Open();
            SqlCommand cmd = new SqlCommand(query, cnn);
            int ret = cmd.ExecuteNonQuery();
            cnn.Close();
            return ret;
        }
        public int ExecuteScalar(string query)
        {
            SqlConnection cnn = new SqlConnection(cnnSTR);
            cnn.Open();
            SqlCommand cmd = new SqlCommand(query, cnn);
            int check = (int)cmd.ExecuteScalar();
            cnn.Close();
            return check;
        }
    }
}
