namespace PBL3TrungTamDayThem
{
    partial class FormMain
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
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.uC_Teacher1 = new PBL3TrungTamDayThem.UC_Teacher();
            this.uC_Student1 = new PBL3TrungTamDayThem.UC_Student();
            this.uC_Class1 = new PBL3TrungTamDayThem.UC_Class();
            this.uC_Bill1 = new PBL3TrungTamDayThem.UC_Bill();
            this.uC_Staff1 = new PBL3TrungTamDayThem.UC_Staff();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnBill = new System.Windows.Forms.Button();
            this.btnClass = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnTeacher = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlLeft);
            this.panel1.Controls.Add(this.pnlLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 502);
            this.panel1.TabIndex = 0;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.SystemColors.Control;
            this.pnlLeft.Controls.Add(this.btnStaff);
            this.pnlLeft.Controls.Add(this.btnBill);
            this.pnlLeft.Controls.Add(this.btnClass);
            this.pnlLeft.Controls.Add(this.btnStudent);
            this.pnlLeft.Controls.Add(this.btnTeacher);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeft.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlLeft.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlLeft.Location = new System.Drawing.Point(0, 80);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(222, 422);
            this.pnlLeft.TabIndex = 2;
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(81)))), ((int)(((byte)(167)))));
            this.pnlLogo.Controls.Add(this.panel2);
            this.pnlLogo.Controls.Add(this.label1);
            this.pnlLogo.Controls.Add(this.picLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(222, 80);
            this.pnlLogo.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(222, 80);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(676, 422);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(81)))), ((int)(((byte)(167)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(96, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRUNG TÂM \r\n DẠY THÊM";
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(177)))), ((int)(((byte)(215)))));
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(222, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(677, 80);
            this.pnlTop.TabIndex = 1;
            // 
            // pnlCenter
            // 
            this.pnlCenter.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlCenter.Controls.Add(this.uC_Teacher1);
            this.pnlCenter.Controls.Add(this.uC_Student1);
            this.pnlCenter.Controls.Add(this.uC_Class1);
            this.pnlCenter.Controls.Add(this.uC_Bill1);
            this.pnlCenter.Controls.Add(this.uC_Staff1);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlCenter.Location = new System.Drawing.Point(222, 80);
            this.pnlCenter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(677, 422);
            this.pnlCenter.TabIndex = 2;
            // 
            // uC_Teacher1
            // 
            this.uC_Teacher1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(81)))), ((int)(((byte)(167)))));
            this.uC_Teacher1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.uC_Teacher1.Location = new System.Drawing.Point(1, 0);
            this.uC_Teacher1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_Teacher1.Name = "uC_Teacher1";
            this.uC_Teacher1.Size = new System.Drawing.Size(676, 422);
            this.uC_Teacher1.TabIndex = 4;
            this.uC_Teacher1.Load += new System.EventHandler(this.uC_Teacher1_Load);
            // 
            // uC_Student1
            // 
            this.uC_Student1.Location = new System.Drawing.Point(0, 0);
            this.uC_Student1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_Student1.Name = "uC_Student1";
            this.uC_Student1.Size = new System.Drawing.Size(676, 422);
            this.uC_Student1.TabIndex = 3;
            // 
            // uC_Class1
            // 
            this.uC_Class1.Location = new System.Drawing.Point(0, 0);
            this.uC_Class1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_Class1.Name = "uC_Class1";
            this.uC_Class1.Size = new System.Drawing.Size(676, 422);
            this.uC_Class1.TabIndex = 2;
            // 
            // uC_Bill1
            // 
            this.uC_Bill1.Location = new System.Drawing.Point(0, -2);
            this.uC_Bill1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_Bill1.Name = "uC_Bill1";
            this.uC_Bill1.Size = new System.Drawing.Size(676, 422);
            this.uC_Bill1.TabIndex = 1;
            // 
            // uC_Staff1
            // 
            this.uC_Staff1.Location = new System.Drawing.Point(0, -2);
            this.uC_Staff1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_Staff1.Name = "uC_Staff1";
            this.uC_Staff1.Size = new System.Drawing.Size(676, 422);
            this.uC_Staff1.TabIndex = 0;
            // 
            // btnStaff
            // 
            this.btnStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(177)))), ((int)(((byte)(215)))));
            this.btnStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnStaff.Image = global::PBL3TrungTamDayThem.Properties.Resources.staff_icon;
            this.btnStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaff.Location = new System.Drawing.Point(0, 224);
            this.btnStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(222, 56);
            this.btnStaff.TabIndex = 6;
            this.btnStaff.Text = "Nhân Viên";
            this.btnStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStaff.UseVisualStyleBackColor = false;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnBill
            // 
            this.btnBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(81)))), ((int)(((byte)(167)))));
            this.btnBill.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBill.Image = global::PBL3TrungTamDayThem.Properties.Resources.bill_icon;
            this.btnBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBill.Location = new System.Drawing.Point(0, 168);
            this.btnBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(222, 56);
            this.btnBill.TabIndex = 5;
            this.btnBill.Text = "Biên Lai";
            this.btnBill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBill.UseVisualStyleBackColor = false;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnClass
            // 
            this.btnClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(177)))), ((int)(((byte)(215)))));
            this.btnClass.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnClass.Image = global::PBL3TrungTamDayThem.Properties.Resources.class_icon;
            this.btnClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClass.Location = new System.Drawing.Point(0, 112);
            this.btnClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClass.Name = "btnClass";
            this.btnClass.Size = new System.Drawing.Size(222, 56);
            this.btnClass.TabIndex = 4;
            this.btnClass.Text = "Lớp Học";
            this.btnClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClass.UseVisualStyleBackColor = false;
            this.btnClass.Click += new System.EventHandler(this.btnClass_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(81)))), ((int)(((byte)(167)))));
            this.btnStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnStudent.Image = global::PBL3TrungTamDayThem.Properties.Resources.student_icon_1_;
            this.btnStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudent.Location = new System.Drawing.Point(0, 56);
            this.btnStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(222, 56);
            this.btnStudent.TabIndex = 3;
            this.btnStudent.Text = "Học Viên";
            this.btnStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStudent.UseVisualStyleBackColor = false;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnTeacher
            // 
            this.btnTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(177)))), ((int)(((byte)(215)))));
            this.btnTeacher.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTeacher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTeacher.Image = global::PBL3TrungTamDayThem.Properties.Resources.teacher_icon;
            this.btnTeacher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeacher.Location = new System.Drawing.Point(0, 0);
            this.btnTeacher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.Size = new System.Drawing.Size(222, 56);
            this.btnTeacher.TabIndex = 2;
            this.btnTeacher.Text = "Giáo Viên";
            this.btnTeacher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeacher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTeacher.UseVisualStyleBackColor = false;
            this.btnTeacher.Click += new System.EventHandler(this.btnTeacher_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = global::PBL3TrungTamDayThem.Properties.Resources.DPT_logo;
            this.picLogo.Location = new System.Drawing.Point(0, -2);
            this.picLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(90, 80);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 3;
            this.picLogo.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 502);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Trung Tâm Dạy Thêm";
            this.panel1.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.pnlCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Button btnTeacher;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Button btnClass;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlCenter;
        private UC_Staff uC_Staff1;
        private UC_Bill uC_Bill1;
        private UC_Teacher uC_Teacher1;
        private UC_Student uC_Student1;
        private UC_Class uC_Class1;
    }
}