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
    public partial class FormTeacher : Form
    {
        public FormTeacher()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string cnnSTR = @"Data Source=DELL\SQLEXPRESS;Initial Catalog=TrungTamDayThem;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(cnnSTR);
            cnn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string query = "Insert into GIAO_VIEN(MaGV, HoTenGV, NgaySinh, GioiTinh, DiaChi, ChuyenMon, TrinhDo, SDT, Email, Luong)" +
                    "values (@magv, @hotengv, @ngaysinh, @gioitinh, @diachi, @chuyenmon, @trinhdo, @sdt, @email, @luong)";
                cmd.CommandText = query;
                cmd.Connection = cnn;
                cmd.Parameters.Add("@magv", SqlDbType.VarChar).Value = txbID.Text;
                cmd.Parameters.Add("@hotengv", SqlDbType.NVarChar).Value = txbName.Text;
                cmd.Parameters.Add("@ngaysinh", SqlDbType.Date).Value = dtpBD.Text;
                cmd.Parameters.Add("@gioitinh", SqlDbType.Bit).Value = rbFemale.Checked;
                cmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = txbAddress.Text;
                cmd.Parameters.Add("@chuyenmon", SqlDbType.NVarChar).Value = txbExpertise.Text;
                cmd.Parameters.Add("@trinhdo", SqlDbType.NVarChar).Value = cbbLevel.Text;
                cmd.Parameters.Add("@sdt", SqlDbType.VarChar).Value = txtSalary.Text;
                cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = txtMail.Text;
                cmd.Parameters.Add("@luong", SqlDbType.Float).Value = txtSalary.Text;

                int ret = cmd.ExecuteNonQuery();
                if (ret > 0)
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }    
                else
                   MessageBox.Show("Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cnn.Close();
        }

        private void btnSave_MouseMove(object sender, MouseEventArgs e)
        {
            btnSave.BackColor = Color.MediumSeaGreen;
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.White;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txbID.Text = "";
            txbName.Text = "";
      
            txbPhone.Text = "";
            txbAddress.Text = "";
            txtMail.Text = "";
            cbbLevel.Text = "";
            txbExpertise.Text = "";
            txtSalary.Text = "";
        }

        private void btnReset_MouseMove(object sender, MouseEventArgs e)
        {
            btnReset.BackColor = Color.DeepSkyBlue;
        }

        private void btnReset_MouseLeave(object sender, EventArgs e)
        {
            btnReset.BackColor = Color.White;
        }

        private void btnBack_MouseMove(object sender, MouseEventArgs e)
        {
            btnBack.BackColor = Color.Crimson;
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.BackColor = Color.White;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
