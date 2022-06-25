namespace PBL3TrungTamDayThem.GUI
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.forgotpass = new System.Windows.Forms.Label();
            this.ckbpass = new System.Windows.Forms.CheckBox();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCenter
            // 
            this.pnlCenter.BackColor = System.Drawing.Color.Transparent;
            this.pnlCenter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCenter.Controls.Add(this.forgotpass);
            this.pnlCenter.Controls.Add(this.ckbpass);
            this.pnlCenter.Controls.Add(this.txt_Pass);
            this.pnlCenter.Controls.Add(this.pictureBox2);
            this.pnlCenter.Controls.Add(this.txt_User);
            this.pnlCenter.Controls.Add(this.pictureBox1);
            this.pnlCenter.Location = new System.Drawing.Point(321, 238);
            this.pnlCenter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(588, 179);
            this.pnlCenter.TabIndex = 0;
            // 
            // forgotpass
            // 
            this.forgotpass.AutoSize = true;
            this.forgotpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotpass.Location = new System.Drawing.Point(74, 140);
            this.forgotpass.Name = "forgotpass";
            this.forgotpass.Size = new System.Drawing.Size(146, 25);
            this.forgotpass.TabIndex = 7;
            this.forgotpass.Text = "Quên mật khẩu";
            this.forgotpass.Click += new System.EventHandler(this.forgotpass_Click);
            this.forgotpass.MouseLeave += new System.EventHandler(this.forgotpass_MouseLeave);
            this.forgotpass.MouseMove += new System.Windows.Forms.MouseEventHandler(this.forgotpass_MouseMove);
            // 
            // ckbpass
            // 
            this.ckbpass.AutoSize = true;
            this.ckbpass.Location = new System.Drawing.Point(518, 100);
            this.ckbpass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckbpass.Name = "ckbpass";
            this.ckbpass.Size = new System.Drawing.Size(22, 21);
            this.ckbpass.TabIndex = 6;
            this.ckbpass.UseVisualStyleBackColor = true;
            this.ckbpass.CheckedChanged += new System.EventHandler(this.ckbpass_CheckedChanged);
            // 
            // txt_Pass
            // 
            this.txt_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pass.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_Pass.Location = new System.Drawing.Point(152, 91);
            this.txt_Pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(347, 35);
            this.txt_Pass.TabIndex = 3;
            this.txt_Pass.Text = "Nhập Password";
            this.txt_Pass.Enter += new System.EventHandler(this.txt_Pass_Enter);
            this.txt_Pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Pass_KeyPress);
            this.txt_Pass.Leave += new System.EventHandler(this.txt_Pass_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = global::PBL3TrungTamDayThem.Properties.Resources.padlock__1_1;
            this.pictureBox2.Location = new System.Drawing.Point(78, 80);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // txt_User
            // 
            this.txt_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_User.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_User.Location = new System.Drawing.Point(152, 28);
            this.txt_User.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(347, 35);
            this.txt_User.TabIndex = 2;
            this.txt_User.Text = "Nhập Username";
            this.txt_User.Enter += new System.EventHandler(this.txt_User_Enter);
            this.txt_User.Leave += new System.EventHandler(this.txt_User_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::PBL3TrungTamDayThem.Properties.Resources.account__3_;
            this.pictureBox1.Location = new System.Drawing.Point(78, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Header.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.White;
            this.lbl_Header.Location = new System.Drawing.Point(32, 16);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(482, 55);
            this.lbl_Header.TabIndex = 1;
            this.lbl_Header.Text = "Đăng Nhập Hệ Thống \r\n";
            this.lbl_Header.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.LightGray;
            this.btn_Exit.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Image = global::PBL3TrungTamDayThem.Properties.Resources.logout__1_;
            this.btn_Exit.Location = new System.Drawing.Point(386, 455);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(208, 78);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            this.btn_Exit.MouseLeave += new System.EventHandler(this.btn_Exit_MouseLeave);
            this.btn_Exit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_Exit_MouseMove);
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.LightGray;
            this.btn_Login.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Image = global::PBL3TrungTamDayThem.Properties.Resources.enter__1_;
            this.btn_Login.Location = new System.Drawing.Point(638, 455);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(208, 78);
            this.btn_Login.TabIndex = 2;
            this.btn_Login.Text = " Đăng nhập";
            this.btn_Login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            this.btn_Login.MouseLeave += new System.EventHandler(this.btn_Login_MouseLeave);
            this.btn_Login.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_Login_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lbl_Header);
            this.panel1.Location = new System.Drawing.Point(342, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 87);
            this.panel1.TabIndex = 4;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(130)))));
            this.BackgroundImage = global::PBL3TrungTamDayThem.Properties.Resources.backgroundlogin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1215, 750);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.pnlCenter);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập Hệ Thống";
            this.pnlCenter.ResumeLayout(false);
            this.pnlCenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.CheckBox ckbpass;
        private System.Windows.Forms.Label forgotpass;
        private System.Windows.Forms.Panel panel1;
    }
}