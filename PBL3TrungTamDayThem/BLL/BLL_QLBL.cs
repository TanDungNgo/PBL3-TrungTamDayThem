using PBL3TrungTamDayThem.DAL;
using PBL3TrungTamDayThem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3TrungTamDayThem.BLL
{
    public class BLL_QLBL
    {
        private static BLL_QLBL _Instance;
        public static BLL_QLBL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_QLBL();
                return _Instance;
            }
            private set { }
        }
        private BLL_QLBL() { }
        public DataTable GetListStudent(string lophoc, string search)
        {
            DataTable data = new DataTable();
            if (search != null)
            {
                data = DAL_QLBL.Instance.GetStudentBySearch(search, lophoc);
            }
            if (search == null)
            {
                data = DAL_QLBL.Instance.GetStudentByClass(lophoc);
            }
            if (lophoc == "All")
            {
                data = DAL_QLBL.Instance.GetAllStudent();
            }
            return data;
        }
        public string GetFee(string MaLH)
        {
            string fee = "";
            DataTable data = DAL_QLBL.Instance.GetFee(MaLH);
            foreach (DataRow row in data.Rows)
            {
                fee = row["HocPhi"].ToString();
            }
            return fee;
        }
        public void WriteFile(List<string> l)
        {
            string header = "\t\t\tPhiếu Thu Tiền Trung Tâm DPT";
            string noidung = "\tLớp học:" + l[0].ToString() + "\n\tHọ tên người nộp :" + l[1].ToString() + "\n\tSố tiền thu :" + l[2].ToString() + " vnd ";
            string name = l[0].ToString() + l[1].ToString();
            string filepath = @"D:\Subjects\PBL3-TrungTamDayThem\PBL3TrungTamDayThem\File\BienLai_" + name + ".txt";
            noidung += "\n\tNgày thu: " + DateTime.Now.ToString();
            FileStream fs = new FileStream(filepath, FileMode.Create);
            StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);
            sWriter.WriteLine(header);
            sWriter.WriteLine(noidung);
            sWriter.Flush();
            fs.Close();
        }
        public void PayFee(string HotenHV, string MaLH)
        {
            DAL_QLBL.Instance.PayFee(HotenHV, MaLH);
        }
    }
}
