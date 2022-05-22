using PBL3TrungTamDayThem.BLL;
using PBL3TrungTamDayThem.DAL;
using PBL3TrungTamDayThem.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3TrungTamDayThem.GUI
{
    public partial class FormUser : Form
    {
        private string _MaNV;
        public FormUser(string MaNV)
        {
            InitializeComponent();
            this._MaNV = MaNV;
            SetGUI();
        }
        public void SetGUI()
        {
            User user = DAL_User.Instance.GetUserByMaNV(_MaNV);
            txt_Username.Text = user.Username;
            txt_DisplayName.Text = user.DisplayName;
            string query = "Select * from ACCOUNT where MaNV = '" + _MaNV + "'";
            dataGridView1.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Chọn ảnh";
            openFile.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFile.FileName;
                pictureBox1.ImageLocation = openFile.FileName;
            }
        }

        private void btnsavechange_Click(object sender, EventArgs e)
        {
            User user = DAL_User.Instance.GetUserByMaNV(_MaNV);
            user.Anh = BLL_User.Instance.ImangeToByteArray(pictureBox1);
            //MessageBox.Show(" MaNV: " + user.MaNV + "\n Username :" + user.Username + "\n DisplayName: " + user.DisplayName + "\n Pass: " + user.Pass +
            //    "\n Phan quyen: " + user.PhanQuyen + "\n Anh:" + BLL_User.Instance.ImangeToByteArray(pictureBox1).ToString());
            //BLL_User.Instance.Update(user);
            string query = "Update ACCOUNT set MaNV = @MaNV, Username = @Username, Pass = @Pass, DisplayName = @DisplayName, PhanQuyen = @PhanQuyen, Anh = @Anh " +
                "where MaNV = @MaNV ";
            try
            {
                DataProvider.Instance.Command(user, query);
                MessageBox.Show("Thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show("That bai" + ex.Message);
            }
        }
    }
}
