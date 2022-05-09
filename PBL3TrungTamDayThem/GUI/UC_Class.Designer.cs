namespace PBL3TrungTamDayThem.GUI
{
    partial class UC_Class
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvClass = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbbSubject = new System.Windows.Forms.ComboBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.cbbClass = new System.Windows.Forms.ComboBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 48);
            this.panel1.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeader.Location = new System.Drawing.Point(309, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(214, 26);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Thông Tin Lớp Học";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvClass);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 166);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(806, 323);
            this.panel2.TabIndex = 1;
            // 
            // dgvClass
            // 
            this.dgvClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClass.Location = new System.Drawing.Point(0, 0);
            this.dgvClass.Name = "dgvClass";
            this.dgvClass.RowHeadersWidth = 51;
            this.dgvClass.RowTemplate.Height = 24;
            this.dgvClass.Size = new System.Drawing.Size(806, 323);
            this.dgvClass.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(806, 119);
            this.panel3.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Teal;
            this.panel6.Controls.Add(this.btnAdd);
            this.panel6.Controls.Add(this.btnShow);
            this.panel6.Controls.Add(this.btnEdit);
            this.panel6.Controls.Add(this.btnDel);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(400, 119);
            this.panel6.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::PBL3TrungTamDayThem.Properties.Resources.add_icon1;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(59, 12);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 40);
            this.btnAdd.TabIndex = 38;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.White;
            this.btnShow.Image = global::PBL3TrungTamDayThem.Properties.Resources.show_icon;
            this.btnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShow.Location = new System.Drawing.Point(236, 62);
            this.btnShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(105, 40);
            this.btnShow.TabIndex = 41;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.Image = global::PBL3TrungTamDayThem.Properties.Resources.edit_icon;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(236, 11);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(105, 40);
            this.btnEdit.TabIndex = 40;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.White;
            this.btnDel.Image = global::PBL3TrungTamDayThem.Properties.Resources.delete_icon1;
            this.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel.Location = new System.Drawing.Point(59, 62);
            this.btnDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(105, 40);
            this.btnDel.TabIndex = 39;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Teal;
            this.panel5.Controls.Add(this.cbbSubject);
            this.panel5.Controls.Add(this.lblSubject);
            this.panel5.Controls.Add(this.cbbClass);
            this.panel5.Controls.Add(this.lblClass);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(396, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(410, 119);
            this.panel5.TabIndex = 2;
            // 
            // cbbSubject
            // 
            this.cbbSubject.FormattingEnabled = true;
            this.cbbSubject.Location = new System.Drawing.Point(107, 69);
            this.cbbSubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbSubject.Name = "cbbSubject";
            this.cbbSubject.Size = new System.Drawing.Size(247, 24);
            this.cbbSubject.TabIndex = 41;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSubject.Location = new System.Drawing.Point(35, 72);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(65, 19);
            this.lblSubject.TabIndex = 40;
            this.lblSubject.Text = "Subject:";
            // 
            // cbbClass
            // 
            this.cbbClass.FormattingEnabled = true;
            this.cbbClass.Location = new System.Drawing.Point(107, 25);
            this.cbbClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbClass.Name = "cbbClass";
            this.cbbClass.Size = new System.Drawing.Size(247, 24);
            this.cbbClass.TabIndex = 39;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.ForeColor = System.Drawing.SystemColors.Control;
            this.lblClass.Location = new System.Drawing.Point(35, 26);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(51, 19);
            this.lblClass.TabIndex = 38;
            this.lblClass.Text = "Class:";
            // 
            // UC_Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "UC_Class";
            this.Size = new System.Drawing.Size(806, 489);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvClass;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.ComboBox cbbSubject;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.ComboBox cbbClass;
        private System.Windows.Forms.Label lblClass;
    }
}
