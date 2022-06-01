namespace PBL3TrungTamDayThem.GUI
{
    partial class FormStaff
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
            this.cbbPosition = new System.Windows.Forms.ComboBox();
            this.lblerposition = new System.Windows.Forms.Label();
            this.lbleraddress = new System.Windows.Forms.Label();
            this.lblersalary = new System.Windows.Forms.Label();
            this.lbleremail = new System.Windows.Forms.Label();
            this.lblerphone = new System.Windows.Forms.Label();
            this.lblername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.dtpStarting = new System.Windows.Forms.DateTimePicker();
            this.lblSD = new System.Windows.Forms.Label();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.gbGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cbbPosition);
            this.panel1.Controls.Add(this.lblerposition);
            this.panel1.Controls.Add(this.lbleraddress);
            this.panel1.Controls.Add(this.lblersalary);
            this.panel1.Controls.Add(this.lbleremail);
            this.panel1.Controls.Add(this.lblerphone);
            this.panel1.Controls.Add(this.lblername);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSalary);
            this.panel1.Controls.Add(this.lblSalary);
            this.panel1.Controls.Add(this.dtpStarting);
            this.panel1.Controls.Add(this.lblSD);
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
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 798);
            this.panel1.TabIndex = 0;
            // 
            // cbbPosition
            // 
            this.cbbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPosition.FormattingEnabled = true;
            this.cbbPosition.Location = new System.Drawing.Point(281, 401);
            this.cbbPosition.Name = "cbbPosition";
            this.cbbPosition.Size = new System.Drawing.Size(275, 28);
            this.cbbPosition.TabIndex = 81;
            this.cbbPosition.SelectedIndexChanged += new System.EventHandler(this.cbbPosition_SelectedIndexChanged);
            // 
            // lblerposition
            // 
            this.lblerposition.AutoSize = true;
            this.lblerposition.ForeColor = System.Drawing.Color.Red;
            this.lblerposition.Location = new System.Drawing.Point(278, 438);
            this.lblerposition.Name = "lblerposition";
            this.lblerposition.Size = new System.Drawing.Size(105, 20);
            this.lblerposition.TabIndex = 80;
            this.lblerposition.Text = "Nhập chức vụ";
            this.lblerposition.Visible = false;
            // 
            // lbleraddress
            // 
            this.lbleraddress.AutoSize = true;
            this.lbleraddress.ForeColor = System.Drawing.Color.Red;
            this.lbleraddress.Location = new System.Drawing.Point(278, 369);
            this.lbleraddress.Name = "lbleraddress";
            this.lbleraddress.Size = new System.Drawing.Size(96, 20);
            this.lbleraddress.TabIndex = 79;
            this.lbleraddress.Text = "Nhập địa chỉ";
            this.lbleraddress.Visible = false;
            // 
            // lblersalary
            // 
            this.lblersalary.AutoSize = true;
            this.lblersalary.ForeColor = System.Drawing.Color.Red;
            this.lblersalary.Location = new System.Drawing.Point(278, 575);
            this.lblersalary.Name = "lblersalary";
            this.lblersalary.Size = new System.Drawing.Size(90, 20);
            this.lblersalary.TabIndex = 78;
            this.lblersalary.Text = "Nhập lương";
            this.lblersalary.Visible = false;
            // 
            // lbleremail
            // 
            this.lbleremail.AutoSize = true;
            this.lbleremail.ForeColor = System.Drawing.Color.Red;
            this.lbleremail.Location = new System.Drawing.Point(278, 509);
            this.lbleremail.Name = "lbleremail";
            this.lbleremail.Size = new System.Drawing.Size(90, 20);
            this.lbleremail.TabIndex = 77;
            this.lbleremail.Text = "Nhập Email";
            this.lbleremail.Visible = false;
            // 
            // lblerphone
            // 
            this.lblerphone.AutoSize = true;
            this.lblerphone.ForeColor = System.Drawing.Color.Red;
            this.lblerphone.Location = new System.Drawing.Point(278, 304);
            this.lblerphone.Name = "lblerphone";
            this.lblerphone.Size = new System.Drawing.Size(197, 20);
            this.lblerphone.TabIndex = 76;
            this.lblerphone.Text = "Số điện thoại không hợp lệ";
            this.lblerphone.Visible = false;
            // 
            // lblername
            // 
            this.lblername.AutoSize = true;
            this.lblername.ForeColor = System.Drawing.Color.Red;
            this.lblername.Location = new System.Drawing.Point(278, 159);
            this.lblername.Name = "lblername";
            this.lblername.Size = new System.Drawing.Size(146, 20);
            this.lblername.TabIndex = 49;
            this.lblername.Text = "Nhập tên nhân viên";
            this.lblername.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(276, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 32);
            this.label2.TabIndex = 75;
            this.label2.Text = "Thông Tin Nhân Viên";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(130)))));
            this.btnBack.Image = global::PBL3TrungTamDayThem.Properties.Resources._return;
            this.btnBack.Location = new System.Drawing.Point(134, 668);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(141, 56);
            this.btnBack.TabIndex = 74;
            this.btnBack.Text = "  Thoát";
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(130)))));
            this.btnSave.Image = global::PBL3TrungTamDayThem.Properties.Resources.save1;
            this.btnSave.Location = new System.Drawing.Point(556, 668);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(141, 56);
            this.btnSave.TabIndex = 73;
            this.btnSave.Text = "   Lưu";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Red;
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(130)))));
            this.btnReset.Image = global::PBL3TrungTamDayThem.Properties.Resources.reload;
            this.btnReset.Location = new System.Drawing.Point(342, 668);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(141, 56);
            this.btnReset.TabIndex = 72;
            this.btnReset.Text = "  Đặt lại";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(129, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 26);
            this.label1.TabIndex = 70;
            this.label1.Text = "Chức vụ:";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(281, 544);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(275, 26);
            this.txtSalary.TabIndex = 69;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSalary.Location = new System.Drawing.Point(129, 541);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(88, 26);
            this.lblSalary.TabIndex = 68;
            this.lblSalary.Text = "Lương:";
            // 
            // dtpStarting
            // 
            this.dtpStarting.Location = new System.Drawing.Point(281, 614);
            this.dtpStarting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpStarting.Name = "dtpStarting";
            this.dtpStarting.Size = new System.Drawing.Size(275, 26);
            this.dtpStarting.TabIndex = 67;
            // 
            // lblSD
            // 
            this.lblSD.AutoSize = true;
            this.lblSD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSD.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSD.Location = new System.Drawing.Point(129, 612);
            this.lblSD.Name = "lblSD";
            this.lblSD.Size = new System.Drawing.Size(158, 26);
            this.lblSD.TabIndex = 66;
            this.lblSD.Text = "Ngày vào làm:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(281, 478);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(275, 26);
            this.txtEmail.TabIndex = 65;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblMail.Location = new System.Drawing.Point(129, 475);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(81, 26);
            this.lblMail.TabIndex = 64;
            this.lblMail.Text = "Email:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(281, 338);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(275, 26);
            this.txtAddress.TabIndex = 63;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblAddress.Location = new System.Drawing.Point(129, 335);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(93, 26);
            this.lblAddress.TabIndex = 62;
            this.lblAddress.Text = "Địa chỉ:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(281, 263);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(275, 26);
            this.txtPhone.TabIndex = 61;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPhone.Location = new System.Drawing.Point(129, 261);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(153, 26);
            this.lblPhone.TabIndex = 60;
            this.lblPhone.Text = "Số điện thoại:";
            // 
            // dtpBirthDay
            // 
            this.dtpBirthDay.Location = new System.Drawing.Point(281, 200);
            this.dtpBirthDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpBirthDay.Name = "dtpBirthDay";
            this.dtpBirthDay.Size = new System.Drawing.Size(275, 26);
            this.dtpBirthDay.TabIndex = 59;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(281, 128);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(275, 26);
            this.txtName.TabIndex = 58;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(281, 64);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(275, 26);
            this.txtID.TabIndex = 57;
            // 
            // gbGender
            // 
            this.gbGender.Controls.Add(this.rbFemale);
            this.gbGender.Controls.Add(this.rbMale);
            this.gbGender.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGender.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbGender.Location = new System.Drawing.Point(594, 62);
            this.gbGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGender.Name = "gbGender";
            this.gbGender.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGender.Size = new System.Drawing.Size(150, 115);
            this.gbGender.TabIndex = 56;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "Giới tính";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemale.Location = new System.Drawing.Point(27, 70);
            this.rbFemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(66, 29);
            this.rbFemale.TabIndex = 1;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Nữ";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.Location = new System.Drawing.Point(27, 31);
            this.rbMale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(82, 29);
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
            this.lblBD.Location = new System.Drawing.Point(129, 200);
            this.lblBD.Name = "lblBD";
            this.lblBD.Size = new System.Drawing.Size(121, 26);
            this.lblBD.TabIndex = 55;
            this.lblBD.Text = "Ngày sinh:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblName.Location = new System.Drawing.Point(125, 128);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(164, 26);
            this.lblName.TabIndex = 54;
            this.lblName.Text = "Tên nhân viên:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblID.Location = new System.Drawing.Point(129, 64);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(160, 26);
            this.lblID.TabIndex = 53;
            this.lblID.Text = "Mã nhân viên:";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(897, 10);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 788);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(897, 10);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 778);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(887, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 778);
            this.panel5.TabIndex = 4;
            // 
            // FormStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(897, 798);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Nhân Viên";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.DateTimePicker dtpStarting;
        private System.Windows.Forms.Label lblSD;
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
        private System.Windows.Forms.Label lblername;
        private System.Windows.Forms.Label lblerphone;
        private System.Windows.Forms.Label lbleremail;
        private System.Windows.Forms.Label lblersalary;
        private System.Windows.Forms.Label lblerposition;
        private System.Windows.Forms.Label lbleraddress;
        private System.Windows.Forms.ComboBox cbbPosition;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}