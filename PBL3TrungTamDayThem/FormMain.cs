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
        private UserControl currentUC;
        private void OpenUC(UserControl UC)
        {
            if (currentUC != null)
            {
                currentUC.Dispose();
            }    
            currentUC = UC;
            UC.Dock = DockStyle.Fill;
            pnlCenter.Controls.Add(UC);
            pnlCenter.Tag = UC;
            UC.BringToFront();
        }
        private void GetFromButton(Button b)
        {
            lblHeader.Text = b.Text;
            ptbHeader.Image = b.Image;
            b.BackColor = Color.Teal;
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            btnHome.PerformClick();
            foreach (Control item in flpnlButton.Controls)
                item.Width = flpnlButton.Width;
        }
        private void ResetColorButton()
        {
            foreach (Button item in flpnlButton.Controls)
            {
                item.BackColor = Color.DarkGray;
            }    
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            ResetColorButton();
            GetFromButton(btnHome);
            OpenUC(new UC_Home());
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            ResetColorButton();
            GetFromButton(btnTeacher);
            OpenUC(new UC_Teacher());
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            ResetColorButton();
            GetFromButton(btnStudent);
            OpenUC(new UC_Student());
        }
        
        private void btnClass_Click(object sender, EventArgs e)
        {
            ResetColorButton();
            GetFromButton(btnClass);
            OpenUC(new UC_Class());
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            ResetColorButton();
            GetFromButton(btnStaff);
            OpenUC(new UC_Staff());
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            ResetColorButton();
            GetFromButton(btnBill);
            OpenUC(new UC_Bill());
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            ResetColorButton();
            GetFromButton(btnStatistic);
            OpenUC(new UC_Statistic()); 
        }
        private void btn_Min_Click(object sender, EventArgs e)
        {
            pnlMenu.Width = (pnlMenu.Width == this.Width / 4) ? 40 : this.Width / 4;
        }
        private void btnHelp_Click(object sender, EventArgs e)
        {
            //lblHeader.Text = "Trợ Giúp";
            //ptbHeader.Image = btnHelp.Image;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
                Application.Exit();
        }

        private void btn_Exit_MouseMove(object sender, MouseEventArgs e)
        {
            btn_Exit.BackColor = Color.Red;
        }

        private void btn_Exit_MouseLeave(object sender, EventArgs e)
        {
            btn_Exit.BackColor = Color.Wheat;
        }
        private void btn_Max_Click(object sender, EventArgs e)
        {
            this.WindowState = (this.WindowState == FormWindowState.Maximized) ? FormWindowState.Normal : FormWindowState.Maximized;
            pnlMenu.Width = this.Width / 4;
            pnlLogo.Width = pnlMenu.Width;
            pnlLogo.Height = pnlMenu.Height * 105 / 725;
            pnl_leftMenu.Height = pnlLogo.Height;
            ptbLogo.Height = pnlLogo.Height;
            ptbLogo.Width = pnlLogo.Width * 98 / 300;
            pnl_rightMenu.Height = pnlLogo.Height;
            pnl_rightMenu.Width = pnlLogo.Width * 139 / 300;
            lblName.Width = pnl_rightMenu.Width * 141 / 139;
            lblName.Height = pnl_rightMenu.Height * 48 / 105;
            lblName.Font = new Font("Times New Roman", this.Width * 10 / 800, FontStyle.Bold);
            foreach (Button b in flpnlButton.Controls)
            {
                b.Width = pnlMenu.Width;
                b.Height = pnlMenu.Height * 85 / 725;
            } 
                
        }
        private void btn_Mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            if (pnl_user.Visible == false)
            {
                pnl_user.Visible = true;
                pnl_user.BringToFront();
            }
            else
            {
                pnl_user.Visible = false;
            }    
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn đăng suất ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
                this.Close();
        }
    }
}
