using PBL3TrungTamDayThem.BLL;
using PBL3TrungTamDayThem.DAL;
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
                //try
                //{
                //    String cnnStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=TrungTamDayThem;Integrated Security=True";
                //    SqlConnection cnn = new SqlConnection(cnnStr);
                //    cnn.Open();
                //    string query = "Select * from ACCOUNT ac inner join NHAN_VIEN nv on ac.MaNV = nv.MaNV where ac.TaiKhoan = @username and nv.Email = @email";
                //    SqlCommand cmd = new SqlCommand(query, cnn);
                //    cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = txt_Username.Text;
                //    cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = txt_Email.Text;
                //    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //    DataTable data = new DataTable();
                //    adapter.Fill(data);
                //    if (data.Rows.Count > 0)
                //    {
                //        BLL_User.Instance.ResetPass(txt_Username.Text);
                //        this.Close();
                //    }
                //    else
                //    {
                //        MessageBox.Show("Thay đổi thất bại! Tài khoản hoặc mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    }
                //    cnn.Close();
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);

                //}
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
    }
}
