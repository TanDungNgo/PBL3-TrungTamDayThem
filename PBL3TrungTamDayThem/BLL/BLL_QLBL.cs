using PBL3TrungTamDayThem.DAL;
using PBL3TrungTamDayThem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Aspose.Words;
using PBL3TrungTamDayThem.Lib;
using Aspose.Words.Tables;
using System.Data;

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
                if (search == "Nhập tên tìm kiếm" && tinhtrang == "All")
                    data = DAL_QLBL.Instance.GetAllStudent();
                if (search != "Nhập tên tìm kiếm" && tinhtrang == "All")
                    data = DAL_QLBL.Instance.GetStudentBySearch(search, lophoc);
                if (tinhtrang != "All")
                    data = DAL_QLBL.Instance.GetStudentByStatus(tinhtrang, lophoc, search);
            }   
            else
            {
                if (search == "Nhập tên tìm kiếm" && tinhtrang == "All")
                    data = DAL_QLBL.Instance.GetStudentByClass(lophoc);
                if (search != "Nhập tên tìm kiếm" && tinhtrang == "All")
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
                DateTime today = DateTime.Now;
                Document bienlai = new Document("Template\\Mau_Bien_Lai.doc");
                bienlai.MailMerge.Execute(new[] { "Ma_Lop" }, new[] { bill.MaLH });
                bienlai.MailMerge.Execute(new[] { "Ho_Ten_HV" }, new[] { bill.HoTenHV });
                bienlai.MailMerge.Execute(new[] { "Noi_Dung" }, new[] { bill.NoiDung });
                bienlai.MailMerge.Execute(new[] { "So_Tien" }, new[] { bill.HocPhi.ToString("##,#") });
                bienlai.MailMerge.Execute(new[] { "Ngay_Thu" }, new[] { string.Format("Đà Nẵng, ngày {0} tháng {1} năm {2}", today.Day, today.Month, today.Year) });
                Staff staff = BLL_QLNV.Instance.GetNVByID(bill.MaNV);
                bienlai.MailMerge.Execute(new[] { "Ho_Ten_NV" }, new[] { staff.HoTenNV });
                bienlai.SaveAndOpenFile("BienLai\\BienLai_" +bill.MaHV +"_" + bill.MaLH + ".doc");
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
