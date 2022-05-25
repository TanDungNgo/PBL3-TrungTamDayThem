﻿namespace PBL3TrungTamDayThem.GUI
{
    partial class FormClass
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
            this.pnlFee = new System.Windows.Forms.Panel();
            this.txtFee = new System.Windows.Forms.TextBox();
            this.lblFee = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.NUDSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblIdSb = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.lblED = new System.Windows.Forms.Label();
            this.lblID_Tea = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.lblSD = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.cbbIDTeacher = new System.Windows.Forms.ComboBox();
            this.cbbIDSubject = new System.Windows.Forms.ComboBox();
            this.pnlFee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFee
            // 
            this.pnlFee.BackColor = System.Drawing.Color.White;
            this.pnlFee.Controls.Add(this.cbbIDSubject);
            this.pnlFee.Controls.Add(this.cbbIDTeacher);
            this.pnlFee.Controls.Add(this.txtFee);
            this.pnlFee.Controls.Add(this.lblFee);
            this.pnlFee.Controls.Add(this.txtTime);
            this.pnlFee.Controls.Add(this.lblTime);
            this.pnlFee.Controls.Add(this.NUDSoLuong);
            this.pnlFee.Controls.Add(this.label1);
            this.pnlFee.Controls.Add(this.btnExit);
            this.pnlFee.Controls.Add(this.lblIdSb);
            this.pnlFee.Controls.Add(this.btnSave);
            this.pnlFee.Controls.Add(this.btnReset);
            this.pnlFee.Controls.Add(this.dtpStart);
            this.pnlFee.Controls.Add(this.lblED);
            this.pnlFee.Controls.Add(this.lblID_Tea);
            this.pnlFee.Controls.Add(this.dtpEnd);
            this.pnlFee.Controls.Add(this.lblSD);
            this.pnlFee.Controls.Add(this.lblNumber);
            this.pnlFee.Controls.Add(this.txtID);
            this.pnlFee.Controls.Add(this.lblID);
            this.pnlFee.Location = new System.Drawing.Point(14, 15);
            this.pnlFee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlFee.Name = "pnlFee";
            this.pnlFee.Size = new System.Drawing.Size(870, 768);
            this.pnlFee.TabIndex = 0;
            // 
            // txtFee
            // 
            this.txtFee.Location = new System.Drawing.Point(373, 451);
            this.txtFee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFee.Name = "txtFee";
            this.txtFee.Size = new System.Drawing.Size(275, 26);
            this.txtFee.TabIndex = 106;
            // 
            // lblFee
            // 
            this.lblFee.AutoSize = true;
            this.lblFee.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFee.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblFee.Location = new System.Drawing.Point(207, 449);
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(101, 26);
            this.lblFee.TabIndex = 105;
            this.lblFee.Text = "Học phí:";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(373, 384);
            this.txtTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(275, 26);
            this.txtTime.TabIndex = 104;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTime.Location = new System.Drawing.Point(207, 382);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(160, 26);
            this.lblTime.TabIndex = 103;
            this.lblTime.Text = "Thời gian học:";
            // 
            // NUDSoLuong
            // 
            this.NUDSoLuong.Location = new System.Drawing.Point(413, 309);
            this.NUDSoLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NUDSoLuong.Name = "NUDSoLuong";
            this.NUDSoLuong.Size = new System.Drawing.Size(93, 26);
            this.NUDSoLuong.TabIndex = 102;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(352, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 32);
            this.label1.TabIndex = 101;
            this.label1.Text = "Thông Tin Lớp Học";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(130)))));
            this.btnExit.Image = global::PBL3TrungTamDayThem.Properties.Resources._return;
            this.btnExit.Location = new System.Drawing.Point(193, 643);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(141, 56);
            this.btnExit.TabIndex = 100;
            this.btnExit.Text = "   Thoát";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblIdSb
            // 
            this.lblIdSb.AutoSize = true;
            this.lblIdSb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdSb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblIdSb.Location = new System.Drawing.Point(207, 239);
            this.lblIdSb.Name = "lblIdSb";
            this.lblIdSb.Size = new System.Drawing.Size(105, 26);
            this.lblIdSb.TabIndex = 98;
            this.lblIdSb.Text = "Mã môn:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(130)))));
            this.btnSave.Image = global::PBL3TrungTamDayThem.Properties.Resources.save1;
            this.btnSave.Location = new System.Drawing.Point(545, 643);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(141, 56);
            this.btnSave.TabIndex = 97;
            this.btnSave.Text = "   Lưu";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Red;
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(130)))));
            this.btnReset.Image = global::PBL3TrungTamDayThem.Properties.Resources.reload;
            this.btnReset.Location = new System.Drawing.Point(369, 643);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(141, 56);
            this.btnReset.TabIndex = 96;
            this.btnReset.Text = "   Đặt lại";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(373, 512);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(275, 26);
            this.dtpStart.TabIndex = 95;
            // 
            // lblED
            // 
            this.lblED.AutoSize = true;
            this.lblED.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblED.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblED.Location = new System.Drawing.Point(207, 583);
            this.lblED.Name = "lblED";
            this.lblED.Size = new System.Drawing.Size(162, 26);
            this.lblED.TabIndex = 94;
            this.lblED.Text = "Ngày kết thúc:";
            // 
            // lblID_Tea
            // 
            this.lblID_Tea.AutoSize = true;
            this.lblID_Tea.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID_Tea.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblID_Tea.Location = new System.Drawing.Point(207, 167);
            this.lblID_Tea.Name = "lblID_Tea";
            this.lblID_Tea.Size = new System.Drawing.Size(152, 26);
            this.lblID_Tea.TabIndex = 90;
            this.lblID_Tea.Text = "Mã giáo viên:";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(375, 583);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(275, 26);
            this.dtpEnd.TabIndex = 89;
            // 
            // lblSD
            // 
            this.lblSD.AutoSize = true;
            this.lblSD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSD.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSD.Location = new System.Drawing.Point(207, 512);
            this.lblSD.Name = "lblSD";
            this.lblSD.Size = new System.Drawing.Size(156, 26);
            this.lblSD.TabIndex = 88;
            this.lblSD.Text = "Ngày bắt đầu:";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblNumber.Location = new System.Drawing.Point(207, 309);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(200, 26);
            this.lblNumber.TabIndex = 87;
            this.lblNumber.Text = "Số lượng học viên:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(371, 102);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(277, 26);
            this.txtID.TabIndex = 85;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblID.Location = new System.Drawing.Point(207, 100);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(94, 26);
            this.lblID.TabIndex = 83;
            this.lblID.Text = "Mã lớp:";
            // 
            // cbbIDTeacher
            // 
            this.cbbIDTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbIDTeacher.FormattingEnabled = true;
            this.cbbIDTeacher.Location = new System.Drawing.Point(375, 167);
            this.cbbIDTeacher.Name = "cbbIDTeacher";
            this.cbbIDTeacher.Size = new System.Drawing.Size(273, 28);
            this.cbbIDTeacher.TabIndex = 107;
            // 
            // cbbIDSubject
            // 
            this.cbbIDSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbIDSubject.FormattingEnabled = true;
            this.cbbIDSubject.Location = new System.Drawing.Point(377, 237);
            this.cbbIDSubject.Name = "cbbIDSubject";
            this.cbbIDSubject.Size = new System.Drawing.Size(273, 28);
            this.cbbIDSubject.TabIndex = 108;
            // 
            // FormClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(897, 798);
            this.Controls.Add(this.pnlFee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Lớp Học";
            this.pnlFee.ResumeLayout(false);
            this.pnlFee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDSoLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFee;
        private System.Windows.Forms.NumericUpDown NUDSoLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblIdSb;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label lblED;
        private System.Windows.Forms.Label lblID_Tea;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label lblSD;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtFee;
        private System.Windows.Forms.Label lblFee;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ComboBox cbbIDTeacher;
        private System.Windows.Forms.ComboBox cbbIDSubject;
    }
}