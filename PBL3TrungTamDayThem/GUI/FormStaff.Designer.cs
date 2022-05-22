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
            this.dtpStarting = new System.Windows.Forms.DateTimePicker();
            this.lblSD = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(316, 476);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(275, 26);
            this.txtEmail.TabIndex = 34;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMail.Location = new System.Drawing.Point(172, 476);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(74, 27);
            this.lblMail.TabIndex = 33;
            this.lblMail.Text = "Email:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(316, 336);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(275, 26);
            this.txtAddress.TabIndex = 32;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAddress.Location = new System.Drawing.Point(172, 336);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(87, 27);
            this.lblAddress.TabIndex = 31;
            this.lblAddress.Text = "Địa chỉ:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(316, 271);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(275, 26);
            this.txtPhone.TabIndex = 30;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPhone.Location = new System.Drawing.Point(172, 271);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(143, 27);
            this.lblPhone.TabIndex = 29;
            this.lblPhone.Text = "Số điện thoại:";
            // 
            // dtpBirthDay
            // 
            this.dtpBirthDay.Location = new System.Drawing.Point(316, 199);
            this.dtpBirthDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpBirthDay.Name = "dtpBirthDay";
            this.dtpBirthDay.Size = new System.Drawing.Size(275, 26);
            this.dtpBirthDay.TabIndex = 28;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(316, 126);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(275, 26);
            this.txtName.TabIndex = 27;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(316, 62);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(275, 26);
            this.txtID.TabIndex = 26;
            // 
            // gbGender
            // 
            this.gbGender.Controls.Add(this.rbFemale);
            this.gbGender.Controls.Add(this.rbMale);
            this.gbGender.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGender.ForeColor = System.Drawing.SystemColors.Control;
            this.gbGender.Location = new System.Drawing.Point(629, 61);
            this.gbGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGender.Name = "gbGender";
            this.gbGender.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGender.Size = new System.Drawing.Size(150, 115);
            this.gbGender.TabIndex = 25;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "Giới tính";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemale.Location = new System.Drawing.Point(27, 70);
            this.rbFemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(65, 29);
            this.rbFemale.TabIndex = 1;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Nữ";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.Location = new System.Drawing.Point(27, 31);
            this.rbMale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(79, 29);
            this.rbMale.TabIndex = 0;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Nam";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // lblBD
            // 
            this.lblBD.AutoSize = true;
            this.lblBD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBD.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBD.Location = new System.Drawing.Point(172, 199);
            this.lblBD.Name = "lblBD";
            this.lblBD.Size = new System.Drawing.Size(114, 27);
            this.lblBD.TabIndex = 24;
            this.lblBD.Text = "Ngày sinh:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblName.Location = new System.Drawing.Point(173, 126);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(155, 27);
            this.lblName.TabIndex = 23;
            this.lblName.Text = "Tên nhân viên:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.SystemColors.Control;
            this.lblID.Location = new System.Drawing.Point(174, 62);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(150, 27);
            this.lblID.TabIndex = 22;
            this.lblID.Text = "Mã nhân viên:";
            // 
            // dtpStarting
            // 
            this.dtpStarting.Location = new System.Drawing.Point(316, 612);
            this.dtpStarting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpStarting.Name = "dtpStarting";
            this.dtpStarting.Size = new System.Drawing.Size(275, 26);
            this.dtpStarting.TabIndex = 44;
            // 
            // lblSD
            // 
            this.lblSD.AutoSize = true;
            this.lblSD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSD.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSD.Location = new System.Drawing.Point(172, 611);
            this.lblSD.Name = "lblSD";
            this.lblSD.Size = new System.Drawing.Size(151, 27);
            this.lblSD.TabIndex = 43;
            this.lblSD.Text = "Ngày vào làm:";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(316, 542);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(275, 26);
            this.txtSalary.TabIndex = 46;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSalary.Location = new System.Drawing.Point(172, 542);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(82, 27);
            this.lblSalary.TabIndex = 45;
            this.lblSalary.Text = "Lương:";
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(316, 405);
            this.txtPosition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(275, 26);
            this.txtPosition.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(172, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 27);
            this.label1.TabIndex = 47;
            this.label1.Text = "Chức vụ:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(130)))));
            this.btnSave.Image = global::PBL3TrungTamDayThem.Properties.Resources.save1;
            this.btnSave.Location = new System.Drawing.Point(580, 688);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(141, 56);
            this.btnSave.TabIndex = 50;
            this.btnSave.Text = "   Lưu";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(130)))));
            this.btnReset.Image = global::PBL3TrungTamDayThem.Properties.Resources.reload;
            this.btnReset.Location = new System.Drawing.Point(377, 688);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(141, 56);
            this.btnReset.TabIndex = 49;
            this.btnReset.Text = "  Đặt lại";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(130)))));
            this.btnBack.Image = global::PBL3TrungTamDayThem.Properties.Resources._return;
            this.btnBack.Location = new System.Drawing.Point(179, 688);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(141, 56);
            this.btnBack.TabIndex = 51;
            this.btnBack.Text = "  Thoát";
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(897, 798);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.dtpStarting);
            this.Controls.Add(this.lblSD);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.dtpBirthDay);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.gbGender);
            this.Controls.Add(this.lblBD);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Nhân Viên";
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.DateTimePicker dtpStarting;
        private System.Windows.Forms.Label lblSD;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnBack;
    }
}