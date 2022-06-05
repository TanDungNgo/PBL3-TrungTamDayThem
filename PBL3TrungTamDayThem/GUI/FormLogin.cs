using PBL3TrungTamDayThem.DAL;
using System;
using System.Data;
using System.Data.SqlClient;
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
        private void Login()
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
                try
                {
                    String cnnStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=TrungTamDayThem;Integrated Security=True";
                    SqlConnection cnn = new SqlConnection(cnnStr);
                    cnn.Open();
                    string query = "Select * from ACCOUNT where TaiKhoan = @username and MatKhau = @pass";
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    cmd.Parameters.Add("@username",SqlDbType.VarChar).Value = txt_User.Text;
                    cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = txt_Pass.Text;
                    SqlDataReader dt = cmd.ExecuteReader();
                    if (dt.Read())
                    {
                        string MaNV = DAL_User.Instance.GetMaNVByUsername(txt_User.Text);
                        FormMain frmMain = new FormMain(MaNV);
                        this.Hide();
                        frmMain.ShowDialog();
                        txt_Pass.Text = "";
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Login Failed", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    cnn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

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
    }
}
