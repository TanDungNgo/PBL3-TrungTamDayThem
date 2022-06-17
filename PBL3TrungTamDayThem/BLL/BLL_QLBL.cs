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
        public DataTable GetListStudent(string lophoc, string search, string tinhtrang)
        {
            DataTable data = new DataTable();
            if (lophoc == "All")
            {
                if (search == "" && tinhtrang == "All")
                    data = DAL_QLBL.Instance.GetAllStudent();
                if (search != "" && tinhtrang == "All")
                    data = data = DAL_QLBL.Instance.GetStudentBySearch(search, lophoc);
                if (tinhtrang != "All")
                    data = DAL_QLBL.Instance.GetStudentByStatus(tinhtrang, lophoc, search);
            }   
            else
            {
                if (search == "" && tinhtrang == "All")
                    data = DAL_QLBL.Instance.GetStudentByClass(lophoc);
                if (search != "" && tinhtrang == "All")
                    data = DAL_QLBL.Instance.GetStudentBySearch(search, lophoc);
                if (tinhtrang != "All")
                    data = DAL_QLBL.Instance.GetStudentByStatus(tinhtrang, lophoc, search);
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
        public void WriteFile(Bill bill)
        {
            try
            {
                string header = "\t\t\tPhiếu Thu Tiền Trung Tâm DPT";
                string noidung = "\tLớp học:" + bill.MaLH + "\n\tHọ tên người nộp :" + bill.HoTenHV + "\n\tSố tiền thu :" + bill.HocPhi + " vnd ";
                string name = bill.MaHV.ToString() + bill.MaLH.ToString();
                string filepath = @"D:\Subjects\PBL3TrungTamDayThem\PBL3TrungTamDayThem\File\BienLai_" + name + ".txt";
                noidung += "\n\tNgày thu: " + DateTime.Now.ToString();
                FileStream fs = new FileStream(filepath, FileMode.Create);
                StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);
                sWriter.WriteLine(header);
                sWriter.WriteLine(noidung);
                sWriter.Flush();
                fs.Close();
                MessageBox.Show("In thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("In thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void PayFee(Bill bill)
        {
            if (DAL_QLBL.Instance.AddBill(bill) > 0)
            {
                MessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DAL_QLBL.Instance.PayFee(bill.MaHV, bill.MaLH);
            }
            else
                MessageBox.Show("Thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public List<string> GetNoiDung(string MaLH)
        {
            List<string> list = new List<string>();
            foreach (DataRow i in DAL_QLBL.Instance.GetNoiDung(MaLH).Rows)
            {
                list.Add(i[0].ToString());
            }
            return list;
        }
        public int GetHocPhi(string noidung, string malh)
        {
            int sum = 0;
            foreach (DataRow row in DAL_QLBL.Instance.GetHocPhi(noidung, malh).Rows)
            {
                sum += int.Parse(row["HocPhi"].ToString());
            }
            return sum;
        }
    }
}
