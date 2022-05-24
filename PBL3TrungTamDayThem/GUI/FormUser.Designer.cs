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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.grbnewpass = new System.Windows.Forms.GroupBox();
            this.lblnewpass = new System.Windows.Forms.Label();
            this.lblnewpassretype = new System.Windows.Forms.Label();
            this.txtnewpass = new System.Windows.Forms.TextBox();
            this.txtnewpassretype = new System.Windows.Forms.TextBox();
            this.ckbpass = new System.Windows.Forms.CheckBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txt_DisplayName = new System.Windows.Forms.TextBox();
            this.lbl_DisplayName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnsavechange = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grbnewpass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btnSelect);
            this.panel1.Controls.Add(this.grbnewpass);
            this.panel1.Controls.Add(this.ckbpass);
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Controls.Add(this.txt_Password);
            this.panel1.Controls.Add(this.lbl_Password);
            this.panel1.Controls.Add(this.txt_DisplayName);
            this.panel1.Controls.Add(this.lbl_DisplayName);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txt_Username);
            this.panel1.Controls.Add(this.lbl_Username);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnsavechange);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 453);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(374, 233);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(423, 128);
            this.dataGridView1.TabIndex = 95;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 415);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(339, 22);
            this.textBox1.TabIndex = 94;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.SystemColors.Control;
            this.btnSelect.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSelect.Image = global::PBL3TrungTamDayThem.Properties.Resources.image;
            this.btnSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelect.Location = new System.Drawing.Point(197, 160);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(130, 40);
            this.btnSelect.TabIndex = 93;
            this.btnSelect.Text = "     Chọn ảnh";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click_1);
            // 
            // grbnewpass
            // 
            this.grbnewpass.Controls.Add(this.lblnewpass);
            this.grbnewpass.Controls.Add(this.lblnewpassretype);
            this.grbnewpass.Controls.Add(this.txtnewpass);
            this.grbnewpass.Controls.Add(this.txtnewpassretype);
            this.grbnewpass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbnewpass.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.grbnewpass.Location = new System.Drawing.Point(363, 65);
            this.grbnewpass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbnewpass.Name = "grbnewpass";
            this.grbnewpass.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbnewpass.Size = new System.Drawing.Size(423, 145);
            this.grbnewpass.TabIndex = 92;
            this.grbnewpass.TabStop = false;
            this.grbnewpass.Text = "Thay đổi mật khẩu";
            // 
            // lblnewpass
            // 
            this.lblnewpass.AutoSize = true;
            this.lblnewpass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnewpass.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblnewpass.Location = new System.Drawing.Point(5, 41);
            this.lblnewpass.Name = "lblnewpass";
            this.lblnewpass.Size = new System.Drawing.Size(134, 23);
            this.lblnewpass.TabIndex = 63;
            this.lblnewpass.Text = "Mật khẩu mới:";
            // 
            // lblnewpassretype
            // 
            this.lblnewpassretype.AutoSize = true;
            this.lblnewpassretype.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnewpassretype.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblnewpassretype.Location = new System.Drawing.Point(5, 94);
            this.lblnewpassretype.Name = "lblnewpassretype";
            this.lblnewpassretype.Size = new System.Drawing.Size(205, 23);
            this.lblnewpassretype.TabIndex = 62;
            this.lblnewpassretype.Text = "Nhập lại mật khẩu mới:";
            // 
            // txtnewpass
            // 
            this.txtnewpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnewpass.Location = new System.Drawing.Point(217, 37);
            this.txtnewpass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnewpass.Name = "txtnewpass";
            this.txtnewpass.Size = new System.Drawing.Size(196, 26);
            this.txtnewpass.TabIndex = 64;
            // 
            // txtnewpassretype
            // 
            this.txtnewpassretype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnewpassretype.Location = new System.Drawing.Point(217, 94);
            this.txtnewpassretype.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnewpassretype.Name = "txtnewpassretype";
            this.txtnewpassretype.Size = new System.Drawing.Size(196, 26);
            this.txtnewpassretype.TabIndex = 65;
            // 
            // ckbpass
            // 
            this.ckbpass.AutoSize = true;
            this.ckbpass.Location = new System.Drawing.Point(355, 365);
            this.ckbpass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckbpass.Name = "ckbpass";
            this.ckbpass.Size = new System.Drawing.Size(18, 17);
            this.ckbpass.TabIndex = 91;
            this.ckbpass.UseVisualStyleBackColor = true;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHeader.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblHeader.Location = new System.Drawing.Point(274, 16);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(244, 25);
            this.lblHeader.TabIndex = 90;
            this.lblHeader.Text = "Thông Tin Người Dùng";
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(154, 359);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(196, 26);
            this.txt_Password.TabIndex = 89;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_Password.Location = new System.Drawing.Point(6, 363);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(98, 23);
            this.lbl_Password.TabIndex = 88;
            this.lbl_Password.Text = "Mật khẩu:";
            // 
            // txt_DisplayName
            // 
            this.txt_DisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DisplayName.Location = new System.Drawing.Point(154, 235);
            this.txt_DisplayName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_DisplayName.Name = "txt_DisplayName";
            this.txt_DisplayName.Size = new System.Drawing.Size(196, 26);
            this.txt_DisplayName.TabIndex = 87;
            // 
            // lbl_DisplayName
            // 
            this.lbl_DisplayName.AutoSize = true;
            this.lbl_DisplayName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DisplayName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_DisplayName.Location = new System.Drawing.Point(6, 236);
            this.lbl_DisplayName.Name = "lbl_DisplayName";
            this.lbl_DisplayName.Size = new System.Drawing.Size(116, 23);
            this.lbl_DisplayName.TabIndex = 86;
            this.lbl_DisplayName.Text = "Tên hiển thị:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Location = new System.Drawing.Point(11, 65);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 85;
            this.pictureBox1.TabStop = false;
            // 
            // txt_Username
            // 
            this.txt_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Username.Location = new System.Drawing.Point(154, 295);
            this.txt_Username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(196, 26);
            this.txt_Username.TabIndex = 84;
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_Username.Location = new System.Drawing.Point(6, 299);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(139, 23);
            this.lbl_Username.TabIndex = 83;
            this.lbl_Username.Text = "Tên đăng nhập:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(130)))));
            this.btnCancel.Image = global::PBL3TrungTamDayThem.Properties.Resources.error__1_;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(623, 397);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 40);
            this.btnCancel.TabIndex = 82;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // btnsavechange
            // 
            this.btnsavechange.BackColor = System.Drawing.Color.ForestGreen;
            this.btnsavechange.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsavechange.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnsavechange.Image = global::PBL3TrungTamDayThem.Properties.Resources.save1;
            this.btnsavechange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsavechange.Location = new System.Drawing.Point(412, 397);
            this.btnsavechange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsavechange.Name = "btnsavechange";
            this.btnsavechange.Size = new System.Drawing.Size(150, 40);
            this.btnsavechange.TabIndex = 81;
            this.btnsavechange.Text = "     Lưu thay đổi";
            this.btnsavechange.UseVisualStyleBackColor = false;
            this.btnsavechange.Click += new System.EventHandler(this.btnsavechange_Click_1);
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(827, 477);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grbnewpass.ResumeLayout(false);
            this.grbnewpass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.GroupBox grbnewpass;
        private System.Windows.Forms.Label lblnewpass;
        private System.Windows.Forms.Label lblnewpassretype;
        private System.Windows.Forms.TextBox txtnewpass;
        private System.Windows.Forms.TextBox txtnewpassretype;
        private System.Windows.Forms.CheckBox ckbpass;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_DisplayName;
        private System.Windows.Forms.Label lbl_DisplayName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnsavechange;
    }
}