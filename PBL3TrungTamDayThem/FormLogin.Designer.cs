namespace PBL3TrungTamDayThem
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
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.lbl_Pass = new System.Windows.Forms.Label();
            this.lbl_User = new System.Windows.Forms.Label();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCenter
            // 
            this.pnlCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(177)))), ((int)(((byte)(215)))));
            this.pnlCenter.Controls.Add(this.pictureBox2);
            this.pnlCenter.Controls.Add(this.pictureBox1);
            this.pnlCenter.Controls.Add(this.txt_Pass);
            this.pnlCenter.Controls.Add(this.txt_User);
            this.pnlCenter.Controls.Add(this.lbl_Pass);
            this.pnlCenter.Controls.Add(this.lbl_User);
            this.pnlCenter.Location = new System.Drawing.Point(27, 142);
            this.pnlCenter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(484, 138);
            this.pnlCenter.TabIndex = 0;
            // 
            // txt_Pass
            // 
            this.txt_Pass.Location = new System.Drawing.Point(202, 90);
            this.txt_Pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(276, 22);
            this.txt_Pass.TabIndex = 3;
            this.txt_Pass.UseSystemPasswordChar = true;
            // 
            // txt_User
            // 
            this.txt_User.Location = new System.Drawing.Point(202, 27);
            this.txt_User.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(276, 22);
            this.txt_User.TabIndex = 2;
            // 
            // lbl_Pass
            // 
            this.lbl_Pass.AutoSize = true;
            this.lbl_Pass.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pass.Location = new System.Drawing.Point(74, 85);
            this.lbl_Pass.Name = "lbl_Pass";
            this.lbl_Pass.Size = new System.Drawing.Size(118, 26);
            this.lbl_Pass.TabIndex = 1;
            this.lbl_Pass.Text = "Password:";
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_User.Location = new System.Drawing.Point(89, 22);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(68, 26);
            this.lbl_User.TabIndex = 0;
            this.lbl_User.Text = "User:";
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Header.Location = new System.Drawing.Point(62, 23);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(415, 70);
            this.lbl_Header.TabIndex = 1;
            this.lbl_Header.Text = "        Đăng Nhập Hệ Thống \r\nQuản Lý Trung Tâm Dạy Thêm";
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(177)))), ((int)(((byte)(215)))));
            this.btn_Exit.Image = global::PBL3TrungTamDayThem.Properties.Resources.logout__1_;
            this.btn_Exit.Location = new System.Drawing.Point(65, 310);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(124, 40);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click_1);
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(177)))), ((int)(((byte)(215)))));
            this.btn_Login.Image = global::PBL3TrungTamDayThem.Properties.Resources.enter__1_;
            this.btn_Login.Location = new System.Drawing.Point(339, 309);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(124, 40);
            this.btn_Login.TabIndex = 2;
            this.btn_Login.Text = "Login";
            this.btn_Login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PBL3TrungTamDayThem.Properties.Resources.password;
            this.pictureBox2.Location = new System.Drawing.Point(24, 74);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PBL3TrungTamDayThem.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(24, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(81)))), ((int)(((byte)(167)))));
            this.ClientSize = new System.Drawing.Size(539, 360);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.lbl_Header);
            this.Controls.Add(this.pnlCenter);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập Hệ Thống";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing_1);
            this.pnlCenter.ResumeLayout(false);
            this.pnlCenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.Label lbl_Pass;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}