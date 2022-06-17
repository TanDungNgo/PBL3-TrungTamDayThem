using PBL3TrungTamDayThem.BLL;
using PBL3TrungTamDayThem.DTO;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PBL3TrungTamDayThem.GUI
{
    public partial class FormMain : Form
    {
        private string _MaNV;
        private Bitmap bmp;
        private string filePath;
        public FormMain(string MaNV)
        {
            InitializeComponent();
            this._MaNV = MaNV;
        }
        private UC_Teacher uC_Teacher = new UC_Teacher();
        private UC_Student uC_Student = new UC_Student();
        private UC_Staff uC_Staff = new UC_Staff();
        private UC_Class uC_Class = new UC_Class();
        private UC_Bill uC_Bill = new UC_Bill();
        private UC_Statistic uC_Statistic = new UC_Statistic();
        private void OpenUC(UserControl UC)
        {
            UC.Dock = DockStyle.Fill;
            pnlCenter.Controls.Add(UC);
            pnlCenter.Tag = UC;
            UC.BringToFront();
        }
        private void GetFromButton(Button b)
        {
            lblHeader.Text = b.Text;
            ptbHeader.Image = b.Image;
            b.BackColor = Color.FromArgb(0, 40, 90);
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            btnHome.PerformClick();
            User user = BLL_User.Instance.GetUserByMaNV(this._MaNV);
            btn_user.Text = user.TenHienThi + " ﹀";
            foreach (Control item in flpnlButton.Controls)
                item.Width = flpnlButton.Width;
            this.filePath = user.Anh;
            if (user.Anh != "")
            {
                this.bmp = new Bitmap(this.filePath);
                this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                this.pictureBox1.Image = this.bmp;
            }
        }
        private void ResetColorButton()
        {
            foreach (Button item in flpnlButton.Controls)
            {
                item.BackColor = Color.FromArgb(0, 60, 130);
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
            uC_Teacher.VaiTro = BLL_QLNV.Instance.GetNVByID(this._MaNV).ChucVu; ;
            OpenUC(uC_Teacher);
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            ResetColorButton();
            GetFromButton(btnStudent);
            OpenUC(uC_Student);
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            ResetColorButton();
            GetFromButton(btnClass);
            OpenUC(uC_Class);
        }
        private void btnStaff_Click(object sender, EventArgs e)
        {
            ResetColorButton();
            GetFromButton(btnStaff);
            uC_Staff.VaiTro = BLL_QLNV.Instance.GetNVByID(this._MaNV).ChucVu;
            uC_Staff.MaNV = BLL_QLNV.Instance.GetNVByID(this._MaNV).MaNV;
            OpenUC(uC_Staff);
        }
        private void btnBill_Click(object sender, EventArgs e)
        {
            ResetColorButton();
            GetFromButton(btnBill);
            uC_Bill.MaNV = this._MaNV;
            OpenUC(uC_Bill);
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            ResetColorButton();
            GetFromButton(btnStatistic);
            OpenUC(uC_Statistic);
        }
        private void btn_Min_Click(object sender, EventArgs e)
        {
            pnlMenu.Width = (pnlMenu.Width == this.Width / 4) ? 40 : this.Width / 4;
        }
        private void btnHelp_Click(object sender, EventArgs e)
        {
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
                this.Close();
        }

        private void btn_Exit_MouseMove(object sender, MouseEventArgs e)
        {
            btn_Exit.BackColor = Color.Red;
        }

        private void btn_Exit_MouseLeave(object sender, EventArgs e)
        {
            btn_Exit.BackColor = Color.White;
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

        private void btn_ThongTin_Click(object sender, EventArgs e)
        {
            FormUser f = new FormUser(this._MaNV);
            f.ShowDialog();
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnl_header1_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }    
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                uC_Teacher.SizeMax();
                uC_Student.SizeMax();
                uC_Staff.SizeMax();
                uC_Class.SizeMax();
                uC_Bill.SizeMax();
            }
            else
            {
                uC_Teacher.SizeMin();
                uC_Student.SizeMin();
                uC_Staff.SizeMin();
                uC_Class.SizeMin();
                uC_Bill.SizeMin();
            }
        }
    }
}
