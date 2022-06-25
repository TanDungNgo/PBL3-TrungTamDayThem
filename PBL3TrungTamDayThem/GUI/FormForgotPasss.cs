using PBL3TrungTamDayThem.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3TrungTamDayThem.GUI
{
    public partial class FormForgotPasss : Form
    {
        public FormForgotPasss()
        {
            InitializeComponent();
        }
        public void ResetPassword()
        {
            string UserName = txt_Username.Text;
            string Email = txt_Email.Text;
            if (UserName == null || UserName.Equals(""))
            {
                MessageBox.Show("Tài khoản không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (Email == null || Email.Equals(""))
            {
                MessageBox.Show("Email không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (BLL_User.Instance.CheckUsernameMail(UserName, Email))
                {
                    BLL_User.Instance.ResetPass(txt_Username.Text);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thay đổi thất bại! Tài khoản hoặc email không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetPassword();
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void FormForgotPasss_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
