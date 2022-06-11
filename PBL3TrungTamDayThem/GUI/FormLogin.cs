using PBL3TrungTamDayThem.BLL;
using PBL3TrungTamDayThem.DAL;
using PBL3TrungTamDayThem.DTO;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PBL3TrungTamDayThem.GUI
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        public void Login()
        {
            string UserName = txt_User.Text;
            string Pass = txt_Pass.Text;
            if (UserName == null || UserName.Equals(""))
            {
                MessageBox.Show("Tài khoản không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (Pass == null || Pass.Equals(""))
            {
                MessageBox.Show("Mật khẩu không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (BLL_User.Instance.Login(UserName, Pass))
                {
                    User user = BLL_User.Instance.GetUserByUsername(txt_User.Text);
                    FormMain frmMain = new FormMain(user.MaNV);
                    this.Hide();
                    frmMain.ShowDialog();
                    //txt_Pass.Text = "Nhập Password";
                    //txt_Pass.UseSystemPasswordChar = false;
                    //txt_Pass.ForeColor = Color.DarkGray;
                    txt_Pass.Text = "";
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            Login();
        }
        private void btn_Login_MouseMove(object sender, MouseEventArgs e)
        {
            btn_Login.BackColor = Color.MediumSeaGreen;
        }

        private void btn_Login_MouseLeave(object sender, EventArgs e)
        {
            btn_Login.BackColor = Color.LightGray;
        }

        private void btn_Exit_MouseMove(object sender, MouseEventArgs e)
        {
            btn_Exit.BackColor = Color.Crimson;
        }

        private void btn_Exit_MouseLeave(object sender, EventArgs e)
        {
            btn_Exit.BackColor = Color.LightGray;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ckbpass_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbpass.Checked == true && txt_Pass.Text != "Nhập Password")
            {
                txt_Pass.UseSystemPasswordChar = false;
            }
            if (ckbpass.Checked == false && txt_Pass.Text != "Nhập Password")
            {
                txt_Pass.UseSystemPasswordChar = true;
            }    
        }
        private void txt_Pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Login();
            }
        }

        private void txt_User_Enter(object sender, EventArgs e)
        {
            if (txt_User.Text == "Nhập Username")
            {
                txt_User.Text = null;
            }
            txt_User.ForeColor = Color.Black;
        }

        private void txt_User_Leave(object sender, EventArgs e)
        {
            if (txt_User.Text == "")
            {
                txt_User.Text = "Nhập Username";
                txt_User.ForeColor = Color.DarkGray;
            }
        }

        private void txt_Pass_Leave(object sender, EventArgs e)
        {
            if (txt_Pass.Text == "")
            {
                txt_Pass.Text = "Nhập Password";
                txt_Pass.UseSystemPasswordChar = false;
                txt_Pass.ForeColor = Color.DarkGray;
            }
        }

        private void txt_Pass_Enter(object sender, EventArgs e)
        {
            if (txt_Pass.Text == "Nhập Password")
            {
                txt_Pass.Text = null;
                txt_Pass.UseSystemPasswordChar = true;
            }
            txt_Pass.ForeColor = Color.Black;
        }

        private void forgotpass_Click(object sender, EventArgs e)
        {
            FormForgotPasss f = new FormForgotPasss();
            this.Hide();
            f.ShowDialog();
            this.Show();
            txt_Pass.Text = "";
        }

        private void forgotpass_MouseLeave(object sender, EventArgs e)
        {
            forgotpass.ForeColor = Color.Black;
        }

        private void forgotpass_MouseMove(object sender, MouseEventArgs e)
        {
            forgotpass.ForeColor = Color.Crimson;
        }
    }
}
