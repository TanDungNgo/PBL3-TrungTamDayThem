namespace PBL3TrungTamDayThem
{
    partial class FormTeacher
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBD = new System.Windows.Forms.Label();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.txbID = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txbPhone = new System.Windows.Forms.TextBox();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblExpertise = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.cbbLevel = new System.Windows.Forms.ComboBox();
            this.cbbExpertise = new System.Windows.Forms.ComboBox();
            this.txbSalary = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(36, 33);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(43, 27);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(36, 98);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(75, 27);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // lblBD
            // 
            this.lblBD.AutoSize = true;
            this.lblBD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBD.Location = new System.Drawing.Point(36, 175);
            this.lblBD.Name = "lblBD";
            this.lblBD.Size = new System.Drawing.Size(107, 27);
            this.lblBD.TabIndex = 2;
            this.lblBD.Text = "BirthDay:";
            // 
            // gbGender
            // 
            this.gbGender.Controls.Add(this.rbFemale);
            this.gbGender.Controls.Add(this.rbMale);
            this.gbGender.Location = new System.Drawing.Point(470, 33);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(264, 110);
            this.gbGender.TabIndex = 3;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "Gender";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(35, 76);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(87, 24);
            this.rbFemale.TabIndex = 1;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(35, 37);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(68, 24);
            this.rbMale.TabIndex = 0;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(159, 35);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(226, 26);
            this.txbID.TabIndex = 4;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(159, 98);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(226, 26);
            this.txbName.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(159, 175);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(275, 26);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(36, 245);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(79, 27);
            this.lblPhone.TabIndex = 7;
            this.lblPhone.Text = "Phone:";
            // 
            // txbPhone
            // 
            this.txbPhone.Location = new System.Drawing.Point(159, 247);
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.Size = new System.Drawing.Size(226, 26);
            this.txbPhone.TabIndex = 8;
            // 
            // txbAddress
            // 
            this.txbAddress.Location = new System.Drawing.Point(159, 322);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(226, 26);
            this.txbAddress.TabIndex = 10;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(36, 320);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(96, 27);
            this.lblAddress.TabIndex = 9;
            this.lblAddress.Text = "Address:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(159, 394);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 26);
            this.textBox1.TabIndex = 12;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(36, 392);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(62, 27);
            this.lblMail.TabIndex = 11;
            this.lblMail.Text = "Mail:";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(465, 174);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(73, 27);
            this.lblLevel.TabIndex = 13;
            this.lblLevel.Text = "Level:";
            // 
            // lblExpertise
            // 
            this.lblExpertise.AutoSize = true;
            this.lblExpertise.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpertise.Location = new System.Drawing.Point(465, 245);
            this.lblExpertise.Name = "lblExpertise";
            this.lblExpertise.Size = new System.Drawing.Size(109, 27);
            this.lblExpertise.TabIndex = 14;
            this.lblExpertise.Text = "Expertise:";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(465, 320);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(78, 27);
            this.lblSalary.TabIndex = 15;
            this.lblSalary.Text = "Salary:";
            // 
            // cbbLevel
            // 
            this.cbbLevel.FormattingEnabled = true;
            this.cbbLevel.Location = new System.Drawing.Point(580, 177);
            this.cbbLevel.Name = "cbbLevel";
            this.cbbLevel.Size = new System.Drawing.Size(195, 28);
            this.cbbLevel.TabIndex = 17;
            // 
            // cbbExpertise
            // 
            this.cbbExpertise.FormattingEnabled = true;
            this.cbbExpertise.Location = new System.Drawing.Point(580, 244);
            this.cbbExpertise.Name = "cbbExpertise";
            this.cbbExpertise.Size = new System.Drawing.Size(195, 28);
            this.cbbExpertise.TabIndex = 18;
            // 
            // txbSalary
            // 
            this.txbSalary.Location = new System.Drawing.Point(549, 322);
            this.txbSalary.Name = "txbSalary";
            this.txbSalary.Size = new System.Drawing.Size(226, 26);
            this.txbSalary.TabIndex = 19;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(549, 376);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(88, 43);
            this.btnReset.TabIndex = 20;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(687, 376);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 43);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // FormTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txbSalary);
            this.Controls.Add(this.cbbExpertise);
            this.Controls.Add(this.cbbLevel);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblExpertise);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.txbAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txbPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.gbGender);
            this.Controls.Add(this.lblBD);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Name = "FormTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Giáo Viên";
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBD;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txbPhone;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblExpertise;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.ComboBox cbbLevel;
        private System.Windows.Forms.ComboBox cbbExpertise;
        private System.Windows.Forms.TextBox txbSalary;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
    }
}