using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3TrungTamDayThem
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        public void ResetColorButton()
        {
            foreach (Button item in flpnlButton.Controls)
            {
                item.BackColor = Color.DarkGray;
            }    
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            ResetColorButton();
            lblHeader.Text = btnHome.Text;
            ptbHeader.Image = btnHome.Image;
            btnHome.BackColor = Color.Teal;
            uC_Home1.BringToFront();
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            ResetColorButton();
            lblHeader.Text = btnTeacher.Text;
            ptbHeader.Image = btnTeacher.Image;
            btnTeacher.BackColor = Color.Teal;
            uC_Teacher1.BringToFront();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            ResetColorButton();
            lblHeader.Text = btnStudent.Text;
            ptbHeader.Image = btnStudent.Image;
            btnStudent.BackColor = Color.Teal;
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            ResetColorButton();
            lblHeader.Text = btnClass.Text;
            ptbHeader.Image = btnClass.Image;
            btnClass.BackColor = Color.Teal;
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            ResetColorButton();
            lblHeader.Text = btnStaff.Text;
            ptbHeader.Image = btnStaff.Image;
            btnStaff.BackColor = Color.Teal;
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            ResetColorButton();
            lblHeader.Text = btnBill.Text;
            ptbHeader.Image = btnBill.Image;
            btnBill.BackColor = Color.Teal;
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            ResetColorButton();
            lblHeader.Text = btnStatistic.Text;
            ptbHeader.Image = btnStatistic.Image;
            btnStatistic.BackColor = Color.Teal;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn đăng suất ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
        }

        private void btnLogout_MouseMove(object sender, MouseEventArgs e)
        {
            btnLogout.BackColor = Color.Crimson;
        }

        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.DarkGray;
        }
        private void btn_Min_Click(object sender, EventArgs e)
        {
            pnlLeft.Width = (pnlLeft.Width == 200) ? 40 : 200;
            //if (btnHome.BackColor == Color.Teal)   
            //    uC_Home1.Width = pnlCenter.Width;
            if(btnTeacher.BackColor == Color.Teal)
                uC_Teacher1.Width = pnlCenter.Width;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            btnHome.PerformClick();
            foreach (Control item in flpnlButton.Controls)
                item.Width = flpnlButton.Width;
            uC_Home1.Width = pnlCenter.Width;
            uC_Home1.Height = pnlCenter.Height; ;
            uC_Teacher1.Width = pnlCenter.Width;
            uC_Teacher1.Height = pnlCenter.Height;

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            lblHeader.Text = "Trợ Giúp";
            ptbHeader.Image = btnHelp.Image;
        }
    }
}
