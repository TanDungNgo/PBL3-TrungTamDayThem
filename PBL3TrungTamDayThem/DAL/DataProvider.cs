using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3TrungTamDayThem.DAL
{
    public  class DataProvider
    {
        private static DataProvider _Instance;
        public static DataProvider Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new DataProvider();
                return _Instance;
            }
            private set { }
        }
        private string cnnSTR = @"Data Source=.\SQLEXPRESS;Initial Catalog=TrungTamDayThem;Integrated Security=True";
        public DataTable ExecuteQuery(string query)
        {
            try
            {
                DataTable data = new DataTable();
                using (SqlConnection cnn = new SqlConnection(cnnSTR))
                {
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(data);
                    cnn.Close();
                    return data;
                }    
            }
            catch (Exception)
            {
                return null;
            }
        }
        public int ExecuteNonQuery(string query)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(cnnSTR))
                {
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    int ret = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return ret;
                }    
            }
            catch(Exception)
            {
                return -1;
            }
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
