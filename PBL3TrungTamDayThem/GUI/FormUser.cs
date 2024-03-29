﻿using PBL3TrungTamDayThem.BLL;
using PBL3TrungTamDayThem.DTO;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PBL3TrungTamDayThem.GUI
{
    public partial class FormUser : Form
    {
        private string _MaNV;
        private Bitmap bmp;
        private string filePath;

        public FormUser(string MaNV)
        {
            InitializeComponent();
            this._MaNV = MaNV;
            SetGUI();
        }
        public void SetGUI()
        {
            Staff staff = BLL_QLNV.Instance.GetNVByID(this._MaNV);
            User user = BLL_User.Instance.GetUserByMaNV(this._MaNV);
            txtName.Text = staff.HoTenNV;
            txtPosition.Text = staff.ChucVu;
            txt_Username.Text = user.TaiKhoan;
            txt_DisplayName.Text = user.TenHienThi;
            txt_Password.Text = user.MatKhau;
            txtnewpass.Text = "";
            txtnewpassretype.Text = "";
            this.filePath = user.Anh;
            if (user.Anh != "")
            {
                this.bmp = new Bitmap(this.filePath);
                this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                this.pictureBox1.Image = this.bmp;
            }    
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string fileName;
                    fileName = dlg.FileName;
                    this.bmp = new Bitmap(fileName);
                    this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    this.pictureBox1.Image = this.bmp;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            string fileName = this._MaNV + DateTime.Now.Second + ".jpg";
            this.filePath = "Resources\\" + fileName;
            try
            {
                MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.bmp.Save(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnsavechange_Click(object sender, EventArgs e)
        {
            User user = BLL_User.Instance.GetUserByMaNV(this._MaNV);
            user.Anh = filePath;
            user.TaiKhoan = txt_Username.Text;
            user.TenHienThi = txt_DisplayName.Text;
            if (txtnewpass.Text != "")
            {
                user.MatKhau = txtnewpass.Text;
            }
            if (txtnewpassretype.Text != txtnewpass.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không đúng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    
            BLL_User.Instance.Update(user);
            SetGUI();
        }

        private void ckbpass_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbpass.Checked == true)
            {
                txt_Password.UseSystemPasswordChar = false;
            }
            else
            {
                txt_Password.UseSystemPasswordChar = true;
            }
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void FormUser_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
