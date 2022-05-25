using PBL3TrungTamDayThem.BLL;
using PBL3TrungTamDayThem.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3TrungTamDayThem.GUI
{
    public partial class FormClass : Form
    {
        private string _MaLH;
        public FormClass(string MaLH = null)
        {
            InitializeComponent();
            this._MaLH = MaLH;
            SetGUI();
        }
        public void SetGUI()
        {
            Class lop = BLL_QLLH.Instance.GetClassByMaLH(this._MaLH); 
            if (lop != null)
            {
                txtID.Text = lop.MaLH;
                cbbIDTeacher.Text = lop.MaGV;
                cbbIDSubject.Text = lop.MaMH;
                NUDSoLuong.Text = lop.SoLuongHV.ToString();
                txtTime.Text = lop.ThoiGianHoc;
                txtFee.Text = lop.HocPhi.ToString();
                dtpStart.Text = lop.NgayBatDau.ToString();
                dtpEnd.Text = lop.NgayKetThuc.ToString();
            }
            else
            {
                cbbIDTeacher.Items.AddRange(BLL_QLGV.Instance.GetMaGV().ToArray());
                cbbIDSubject.Items.AddRange(BLL_QLLH.Instance.GetListMaMH().ToArray());
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Class lop = new Class
            {
                MaLH = txtID.Text,
                MaGV = cbbIDTeacher.Text,
                MaMH = cbbIDSubject.Text,
                SoLuongHV = ((int)NUDSoLuong.Value),
                ThoiGianHoc = txtTime.Text,
                HocPhi = int.Parse(txtFee.Text),
                NgayBatDau = dtpStart.Value.Date,
                NgayKetThuc = dtpEnd.Value.Date,
            };
            //MessageBox.Show(lop.MaLH + "\n " + lop.MaGV + "\n " + lop.MaMH + "\n "
            //    + lop.SoLuongHV + "\n " + lop.ThoiGianHoc + "\n " + lop.NgayBatDau + "\n " + lop.NgayKetThuc + "\n ");
            BLL_QLLH.Instance.ExecuteDB(lop);
            this.Dispose();
        }
    }
}
