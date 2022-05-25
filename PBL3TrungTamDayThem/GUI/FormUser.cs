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
            User user = DAL_User.Instance.GetUserByMaNV(_MaNV);
            txt_Username.Text = user.Username;
            txt_DisplayName.Text = user.DisplayName;
            txt_Password.Text = user.Pass;
            if (user.Anh != "")
            {
                this.bmp = new Bitmap(user.Anh);
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
        private void btnsavechange_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = this._MaNV + ".jpg";
                this.filePath = "Resources\\" + fileName;
                this.bmp.Save(filePath);
                User user = DAL_User.Instance.GetUserByMaNV(this._MaNV);
                user.Anh = filePath;
                BLL_User.Instance.Update(user);
                Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
