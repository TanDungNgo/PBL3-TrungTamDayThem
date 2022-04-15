namespace PBL3TrungTamDayThem
{
    partial class UC_Student
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
            this.cbbClass = new System.Windows.Forms.ComboBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.cbbSort = new System.Windows.Forms.ComboBox();
            this.lblSort = new System.Windows.Forms.Label();
            this.dgv_Student = new System.Windows.Forms.DataGridView();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbClass
            // 
            this.cbbClass.FormattingEnabled = true;
            this.cbbClass.Location = new System.Drawing.Point(284, 106);
            this.cbbClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbClass.Name = "cbbClass";
            this.cbbClass.Size = new System.Drawing.Size(134, 24);
            this.cbbClass.TabIndex = 17;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.ForeColor = System.Drawing.SystemColors.Control;
            this.lblClass.Location = new System.Drawing.Point(215, 110);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(51, 19);
            this.lblClass.TabIndex = 16;
            this.lblClass.Text = "Class:";
            // 
            // cbbSort
            // 
            this.cbbSort.FormattingEnabled = true;
            this.cbbSort.Location = new System.Drawing.Point(284, 64);
            this.cbbSort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbSort.Name = "cbbSort";
            this.cbbSort.Size = new System.Drawing.Size(134, 24);
            this.cbbSort.TabIndex = 14;
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSort.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSort.Location = new System.Drawing.Point(215, 66);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(43, 19);
            this.lblSort.TabIndex = 13;
            this.lblSort.Text = "Sort:";
            // 
            // dgv_Student
            // 
            this.dgv_Student.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(177)))), ((int)(((byte)(215)))));
            this.dgv_Student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Student.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_Student.Location = new System.Drawing.Point(0, 150);
            this.dgv_Student.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Student.Name = "dgv_Student";
            this.dgv_Student.RowHeadersWidth = 62;
            this.dgv_Student.RowTemplate.Height = 28;
            this.dgv_Student.Size = new System.Drawing.Size(676, 272);
            this.dgv_Student.TabIndex = 18;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(213, 12);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(219, 26);
            this.lblHeader.TabIndex = 19;
            this.lblHeader.Text = "Thông Tin Học Viên";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblName.Location = new System.Drawing.Point(440, 69);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 19);
            this.lblName.TabIndex = 21;
            this.lblName.Text = "Name:";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(500, 66);
            this.txbName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(151, 22);
            this.txbName.TabIndex = 22;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.SystemColors.Control;
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(676, 48);
            this.pnlHeader.TabIndex = 24;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::PBL3TrungTamDayThem.Properties.Resources.search_icon1;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(444, 100);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(97, 32);
            this.btnSearch.TabIndex = 46;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.Image = global::PBL3TrungTamDayThem.Properties.Resources.edit_icon;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(115, 58);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(79, 32);
            this.btnEdit.TabIndex = 44;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.White;
            this.btnShow.Image = global::PBL3TrungTamDayThem.Properties.Resources.show_icon;
            this.btnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShow.Location = new System.Drawing.Point(115, 103);
            this.btnShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(79, 32);
            this.btnShow.TabIndex = 45;
            this.btnShow.Text = "Show";
            this.btnShow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShow.UseVisualStyleBackColor = false;
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.White;
            this.btnDel.Image = global::PBL3TrungTamDayThem.Properties.Resources.delete_icon1;
            this.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel.Location = new System.Drawing.Point(20, 103);
            this.btnDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(79, 32);
            this.btnDel.TabIndex = 43;
            this.btnDel.Text = "Delete";
            this.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDel.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::PBL3TrungTamDayThem.Properties.Resources.add_icon1;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(20, 58);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(79, 32);
            this.btnAdd.TabIndex = 42;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // UC_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(81)))), ((int)(((byte)(167)))));
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.dgv_Student);
            this.Controls.Add(this.cbbClass);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.cbbSort);
            this.Controls.Add(this.lblSort);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_Student";
            this.Size = new System.Drawing.Size(676, 422);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbClass;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cbbSort;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.DataGridView dgv_Student;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
    }
}
