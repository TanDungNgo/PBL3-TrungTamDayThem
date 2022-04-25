using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3TrungTamDayThem
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
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
                    String cnnStr = @"Data Source=DELL\SQLEXPRESS;Initial Catalog=TrungTamDayThem;Integrated Security=True";
                    SqlConnection cnn = new SqlConnection(cnnStr);
                    cnn.Open();
                    string query = "select * from ACCOUNT where UserName = '" + UserName + "' and Pass = '" + Pass + "'";
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    SqlDataReader dt = cmd.ExecuteReader();
                    if (dt.Read())
                    {
                        FormMain frmMain = new FormMain();
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

        private void FormLogin_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
        }
        private void btn_Login_MouseMove(object sender, MouseEventArgs e)
        {
            btn_Login.BackColor = Color.MediumSeaGreen;
        }

        private void btn_Login_MouseLeave(object sender, EventArgs e)
        {
            btn_Login.BackColor = Color.DimGray;
        }

        private void btn_Exit_MouseMove(object sender, MouseEventArgs e)
        {
            btn_Exit.BackColor = Color.Crimson;
        }

        private void btn_Exit_MouseLeave(object sender, EventArgs e)
        {
            btn_Exit.BackColor = Color.DimGray;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
