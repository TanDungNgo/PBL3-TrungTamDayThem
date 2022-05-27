namespace PBL3TrungTamDayThem.GUI
{
    partial class FormStudent
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.dtpBirthDay = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.lblBD = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblername = new System.Windows.Forms.Label();
            this.lbleraddress = new System.Windows.Forms.Label();
            this.lbleremail = new System.Windows.Forms.Label();
            this.lblerphone = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gbGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblerphone);
            this.panel1.Controls.Add(this.lbleremail);
            this.panel1.Controls.Add(this.lbleraddress);
            this.panel1.Controls.Add(this.lblername);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.lblMail);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.lblAddress);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.lblPhone);
            this.panel1.Controls.Add(this.dtpBirthDay);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.gbGender);
            this.panel1.Controls.Add(this.lblBD);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 614);
            this.panel1.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(130)))));
            this.btnBack.Image = global::PBL3TrungTamDayThem.Properties.Resources._return;
            this.btnBack.Location = new System.Drawing.Point(108, 496);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(125, 45);
            this.btnBack.TabIndex = 70;
            this.btnBack.Text = " Thoát";
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(130)))));
            this.btnSave.Image = global::PBL3TrungTamDayThem.Properties.Resources.save1;
            this.btnSave.Location = new System.Drawing.Point(476, 496);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 45);
            this.btnSave.TabIndex = 69;
            this.btnSave.Text = "  Lưu";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Red;
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(130)))));
            this.btnReset.Image = global::PBL3TrungTamDayThem.Properties.Resources.reload;
            this.btnReset.Location = new System.Drawing.Point(292, 496);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(135, 45);
            this.btnReset.TabIndex = 68;
            this.btnReset.Text = " Đặt lại";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(253, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 25);
            this.label1.TabIndex = 67;
            this.label1.Text = "Thông Tin Học Viên";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(253, 396);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(245, 22);
            this.txtEmail.TabIndex = 63;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblMail.Location = new System.Drawing.Point(111, 396);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(65, 23);
            this.lblMail.TabIndex = 62;
            this.lblMail.Text = "Email:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(253, 278);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(245, 22);
            this.txtAddress.TabIndex = 61;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblAddress.Location = new System.Drawing.Point(111, 277);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(75, 23);
            this.lblAddress.TabIndex = 60;
            this.lblAddress.Text = "Địa chỉ:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(253, 336);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(245, 22);
            this.txtPhone.TabIndex = 59;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPhone.Location = new System.Drawing.Point(111, 333);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(125, 23);
            this.lblPhone.TabIndex = 58;
            this.lblPhone.Text = "Số điện thoại:";
            // 
            // dtpBirthDay
            // 
            this.dtpBirthDay.Location = new System.Drawing.Point(253, 224);
            this.dtpBirthDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpBirthDay.Name = "dtpBirthDay";
            this.dtpBirthDay.Size = new System.Drawing.Size(245, 22);
            this.dtpBirthDay.TabIndex = 57;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(253, 168);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(245, 22);
            this.txtName.TabIndex = 56;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(253, 111);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(245, 22);
            this.txtID.TabIndex = 55;
            // 
            // gbGender
            // 
            this.gbGender.Controls.Add(this.rbFemale);
            this.gbGender.Controls.Add(this.rbMale);
            this.gbGender.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGender.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbGender.Location = new System.Drawing.Point(531, 110);
            this.gbGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGender.Name = "gbGender";
            this.gbGender.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGender.Size = new System.Drawing.Size(138, 95);
            this.gbGender.TabIndex = 54;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "Giới Tính";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(26, 58);
            this.rbFemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(57, 27);
            this.rbFemale.TabIndex = 1;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Nữ";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.Location = new System.Drawing.Point(26, 27);
            this.rbMale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(70, 27);
            this.rbMale.TabIndex = 0;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Nam";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // lblBD
            // 
            this.lblBD.AutoSize = true;
            this.lblBD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBD.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblBD.Location = new System.Drawing.Point(111, 224);
            this.lblBD.Name = "lblBD";
            this.lblBD.Size = new System.Drawing.Size(99, 23);
            this.lblBD.TabIndex = 53;
            this.lblBD.Text = "Ngày sinh:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblName.Location = new System.Drawing.Point(111, 168);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(122, 23);
            this.lblName.TabIndex = 52;
            this.lblName.Text = "Tên học viên:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblID.Location = new System.Drawing.Point(111, 110);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(118, 23);
            this.lblID.TabIndex = 51;
            this.lblID.Text = "Mã học viên:";
            // 
            // lblername
            // 
            this.lblername.AutoSize = true;
            this.lblername.ForeColor = System.Drawing.Color.Red;
            this.lblername.Location = new System.Drawing.Point(251, 193);
            this.lblername.Name = "lblername";
            this.lblername.Size = new System.Drawing.Size(114, 16);
            this.lblername.TabIndex = 49;
            this.lblername.Text = "Nhập tên học viên";
            this.lblername.Visible = false;
            // 
            // lbleraddress
            // 
            this.lbleraddress.AutoSize = true;
            this.lbleraddress.ForeColor = System.Drawing.Color.Red;
            this.lbleraddress.Location = new System.Drawing.Point(250, 303);
            this.lbleraddress.Name = "lbleraddress";
            this.lbleraddress.Size = new System.Drawing.Size(82, 16);
            this.lbleraddress.TabIndex = 71;
            this.lbleraddress.Text = "Nhập địa chỉ";
            this.lbleraddress.Visible = false;
            // 
            // lbleremail
            // 
            this.lbleremail.AutoSize = true;
            this.lbleremail.ForeColor = System.Drawing.Color.Red;
            this.lbleremail.Location = new System.Drawing.Point(250, 421);
            this.lbleremail.Name = "lbleremail";
            this.lbleremail.Size = new System.Drawing.Size(77, 16);
            this.lbleremail.TabIndex = 72;
            this.lbleremail.Text = "Nhập Email";
            this.lbleremail.Visible = false;
            // 
            // lblerphone
            // 
            this.lblerphone.AutoSize = true;
            this.lblerphone.ForeColor = System.Drawing.Color.Red;
            this.lblerphone.Location = new System.Drawing.Point(250, 361);
            this.lblerphone.Name = "lblerphone";
            this.lblerphone.Size = new System.Drawing.Size(165, 16);
            this.lblerphone.TabIndex = 73;
            this.lblerphone.Text = "Số điện thoại không hợp lệ";
            this.lblerphone.Visible = false;
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(797, 638);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Học Viên";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.DateTimePicker dtpBirthDay;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label lblBD;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblername;
        private System.Windows.Forms.Label lbleraddress;
        private System.Windows.Forms.Label lbleremail;
        private System.Windows.Forms.Label lblerphone;
    }
}