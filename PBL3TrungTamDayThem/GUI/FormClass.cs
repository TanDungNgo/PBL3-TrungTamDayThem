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
        public bool Error()
        {
            bool check = true;
            if (txtID.Text == "")
            {
                lblerID.Visible = true;
                check = false;
            }
            else
                lblerID.Visible = false;
            if (cbbIDTeacher.Text == "")
            {
                lblerIdGv.Visible = true;
                check = false;
            }    
            else
                lblerIdGv.Visible = false;
            if(cbbIDSubject.Text == "")
            {
                lblerSb.Visible = true;
                check = false;
            }    
            else
                lblerSb.Visible = false;
            if(NUDSoLuong.Value == 0)
            {
                lblerNumber.Visible = true;
                check = false;
            }    
            else 
                lblerNumber.Visible = false;
            if(txtTime.Text == "")
            {
                lblerTime.Visible = true;
                check = false;
            }    
            else
                lblerTime.Visible = false;
            if (txtFee.Text == "")
            {
                lblerFee.Visible = true;
                check = false;
            }
            else
                lblerFee.Visible = false;

            return check;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(Error() == true)
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
}
