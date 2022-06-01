using PBL3TrungTamDayThem.BLL;
using PBL3TrungTamDayThem.DTO;
using System;
using System.Windows.Forms;

namespace PBL3TrungTamDayThem.GUI
{
    public partial class FormClass : Form
    {
        private string _MaLH;
        public delegate void MyDel();
        public MyDel d { get; set; }
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
                GetCBB();
                txtID.Text = lop.MaLH;
                txtID.Enabled = false;
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
                GetCBB();
                txtFee.Text = "3000000";
            }
        }
        public void GetCBB()
        {
            cbbIDTeacher.Items.AddRange(BLL_QLGV.Instance.GetMaGV().ToArray());
            cbbIDSubject.Items.AddRange(BLL_QLLH.Instance.GetListMaMH().ToArray());
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
            if (cbbIDSubject.Text == "")
            {
                lblerSb.Visible = true;
                check = false;
            }
            else
                lblerSb.Visible = false;
            if (txtTime.Text == "")
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
            if (Error() == true)
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
                BLL_QLLH.Instance.ExecuteDB(lop);
                d();
                this.Dispose();
            }
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            dtpEnd.Value = dtpStart.Value.Date.AddMonths(3);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cbbIDTeacher.Text = "";
            cbbIDSubject.Text = "";
            NUDSoLuong.Value = 0;
            txtTime.Text = "";
        }
    }
}
