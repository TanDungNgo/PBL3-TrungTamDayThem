namespace PBL3TrungTamDayThem.GUI
{
    partial class FormUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUser));
            this.lblnewpassretype = new System.Windows.Forms.Label();
            this.lblnewpass = new System.Windows.Forms.Label();
            this.txtnewpass = new System.Windows.Forms.TextBox();
            this.txtnewpassretype = new System.Windows.Forms.TextBox();
            this.ckbpass = new System.Windows.Forms.CheckBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txt_DisplayName = new System.Windows.Forms.TextBox();
            this.lbl_DisplayName = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.grbnewpass = new System.Windows.Forms.GroupBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnsavechange = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grbnewpass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnewpassretype
            // 
            this.lblnewpassretype.AutoSize = true;
            this.lblnewpassretype.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnewpassretype.ForeColor = System.Drawing.SystemColors.Control;
            this.lblnewpassretype.Location = new System.Drawing.Point(6, 118);
            this.lblnewpassretype.Name = "lblnewpassretype";
            this.lblnewpassretype.Size = new System.Drawing.Size(237, 27);
            this.lblnewpassretype.TabIndex = 62;
            this.lblnewpassretype.Text = "Nhập lại mật khẩu mới:";
            // 
            // lblnewpass
            // 
            this.lblnewpass.AutoSize = true;
            this.lblnewpass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnewpass.ForeColor = System.Drawing.SystemColors.Control;
            this.lblnewpass.Location = new System.Drawing.Point(6, 51);
            this.lblnewpass.Name = "lblnewpass";
            this.lblnewpass.Size = new System.Drawing.Size(153, 27);
            this.lblnewpass.TabIndex = 63;
            this.lblnewpass.Text = "Mật khẩu mới:";
            // 
            // txtnewpass
            // 
            this.txtnewpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnewpass.Location = new System.Drawing.Point(241, 46);
            this.txtnewpass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnewpass.Name = "txtnewpass";
            this.txtnewpass.Size = new System.Drawing.Size(220, 30);
            this.txtnewpass.TabIndex = 64;
            // 
            // txtnewpassretype
            // 
            this.txtnewpassretype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnewpassretype.Location = new System.Drawing.Point(241, 118);
            this.txtnewpassretype.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnewpassretype.Name = "txtnewpassretype";
            this.txtnewpassretype.Size = new System.Drawing.Size(220, 30);
            this.txtnewpassretype.TabIndex = 65;
            // 
            // ckbpass
            // 
            this.ckbpass.AutoSize = true;
            this.ckbpass.Location = new System.Drawing.Point(415, 472);
            this.ckbpass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckbpass.Name = "ckbpass";
            this.ckbpass.Size = new System.Drawing.Size(22, 21);
            this.ckbpass.TabIndex = 76;
            this.ckbpass.UseVisualStyleBackColor = true;
            this.ckbpass.CheckedChanged += new System.EventHandler(this.ckbpass_CheckedChanged);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(324, 36);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(279, 32);
            this.lblHeader.TabIndex = 75;
            this.lblHeader.Text = "Thông tin người dùng";
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(189, 465);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(220, 30);
            this.txt_Password.TabIndex = 74;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Password.Location = new System.Drawing.Point(23, 469);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(110, 27);
            this.lbl_Password.TabIndex = 73;
            this.lbl_Password.Text = "Mật khẩu:";
            // 
            // txt_DisplayName
            // 
            this.txt_DisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DisplayName.Location = new System.Drawing.Point(189, 309);
            this.txt_DisplayName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_DisplayName.Name = "txt_DisplayName";
            this.txt_DisplayName.Size = new System.Drawing.Size(220, 30);
            this.txt_DisplayName.TabIndex = 72;
            // 
            // lbl_DisplayName
            // 
            this.lbl_DisplayName.AutoSize = true;
            this.lbl_DisplayName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DisplayName.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_DisplayName.Location = new System.Drawing.Point(23, 311);
            this.lbl_DisplayName.Name = "lbl_DisplayName";
            this.lbl_DisplayName.Size = new System.Drawing.Size(133, 27);
            this.lbl_DisplayName.TabIndex = 71;
            this.lbl_DisplayName.Text = "Tên hiển thị:";
            // 
            // txt_Username
            // 
            this.txt_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Username.Location = new System.Drawing.Point(189, 385);
            this.txt_Username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(220, 30);
            this.txt_Username.TabIndex = 69;
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Username.Location = new System.Drawing.Point(23, 389);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(160, 27);
            this.lbl_Username.TabIndex = 68;
            this.lbl_Username.Text = "Tên đăng nhập:";
            // 
            // grbnewpass
            // 
            this.grbnewpass.Controls.Add(this.lblnewpass);
            this.grbnewpass.Controls.Add(this.lblnewpassretype);
            this.grbnewpass.Controls.Add(this.txtnewpass);
            this.grbnewpass.Controls.Add(this.txtnewpassretype);
            this.grbnewpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbnewpass.ForeColor = System.Drawing.SystemColors.Control;
            this.grbnewpass.Location = new System.Drawing.Point(424, 97);
            this.grbnewpass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbnewpass.Name = "grbnewpass";
            this.grbnewpass.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbnewpass.Size = new System.Drawing.Size(476, 181);
            this.grbnewpass.TabIndex = 77;
            this.grbnewpass.TabStop = false;
            this.grbnewpass.Text = "Thay đổi mật khẩu";
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.SystemColors.Control;
            this.btnSelect.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(130)))));
            this.btnSelect.Image = global::PBL3TrungTamDayThem.Properties.Resources.image;
            this.btnSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelect.Location = new System.Drawing.Point(238, 216);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(146, 50);
            this.btnSelect.TabIndex = 78;
            this.btnSelect.Text = "     Chọn ảnh";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Location = new System.Drawing.Point(28, 97);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(130)))));
            this.btnCancel.Image = global::PBL3TrungTamDayThem.Properties.Resources.error__1_;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(716, 423);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(169, 72);
            this.btnCancel.TabIndex = 67;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnsavechange
            // 
            this.btnsavechange.BackColor = System.Drawing.SystemColors.Control;
            this.btnsavechange.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsavechange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(130)))));
            this.btnsavechange.Image = global::PBL3TrungTamDayThem.Properties.Resources.save1;
            this.btnsavechange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsavechange.Location = new System.Drawing.Point(498, 423);
            this.btnsavechange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsavechange.Name = "btnsavechange";
            this.btnsavechange.Size = new System.Drawing.Size(169, 72);
            this.btnsavechange.TabIndex = 66;
            this.btnsavechange.Text = "     Lưu thay đổi";
            this.btnsavechange.UseVisualStyleBackColor = false;
            this.btnsavechange.Click += new System.EventHandler(this.btnsavechange_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 586);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(930, 10);
            this.panel4.TabIndex = 79;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 10);
            this.panel1.TabIndex = 80;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 576);
            this.panel2.TabIndex = 81;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(920, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 576);
            this.panel3.TabIndex = 82;
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(930, 596);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.grbnewpass);
            this.Controls.Add(this.ckbpass);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.txt_DisplayName);
            this.Controls.Add(this.lbl_DisplayName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnsavechange);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.grbnewpass.ResumeLayout(false);
            this.grbnewpass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblnewpassretype;
        private System.Windows.Forms.Label lblnewpass;
        private System.Windows.Forms.TextBox txtnewpass;
        private System.Windows.Forms.TextBox txtnewpassretype;
        private System.Windows.Forms.Button btnsavechange;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox ckbpass;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_DisplayName;
        private System.Windows.Forms.Label lbl_DisplayName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.GroupBox grbnewpass;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}