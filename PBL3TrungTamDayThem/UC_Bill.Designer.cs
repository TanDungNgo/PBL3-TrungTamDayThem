namespace PBL3TrungTamDayThem
{
    partial class UC_Bill
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.grbDSSV = new System.Windows.Forms.GroupBox();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.txbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.cbbClass = new System.Windows.Forms.ComboBox();
            this.lblFee = new System.Windows.Forms.Label();
            this.txbFee = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.grbDSSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.SystemColors.Control;
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1159, 48);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(501, 11);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(100, 26);
            this.lblHeader.TabIndex = 33;
            this.lblHeader.Text = "Biên Lai";
            // 
            // grbDSSV
            // 
            this.grbDSSV.Controls.Add(this.dgvStudent);
            this.grbDSSV.Dock = System.Windows.Forms.DockStyle.Right;
            this.grbDSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDSSV.ForeColor = System.Drawing.SystemColors.Control;
            this.grbDSSV.Location = new System.Drawing.Point(329, 48);
            this.grbDSSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbDSSV.Name = "grbDSSV";
            this.grbDSSV.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbDSSV.Size = new System.Drawing.Size(830, 924);
            this.grbDSSV.TabIndex = 1;
            this.grbDSSV.TabStop = false;
            this.grbDSSV.Text = "Danh Sách Học Viên";
            // 
            // dgvStudent
            // 
            this.dgvStudent.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvStudent.Location = new System.Drawing.Point(3, 37);
            this.dgvStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowHeadersWidth = 62;
            this.dgvStudent.RowTemplate.Height = 28;
            this.dgvStudent.Size = new System.Drawing.Size(824, 885);
            this.dgvStudent.TabIndex = 0;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(86, 137);
            this.txbName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(220, 22);
            this.txbName.TabIndex = 25;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblName.Location = new System.Drawing.Point(26, 140);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 22);
            this.lblName.TabIndex = 24;
            this.lblName.Text = "Name:";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.ForeColor = System.Drawing.SystemColors.Control;
            this.lblClass.Location = new System.Drawing.Point(26, 96);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(60, 22);
            this.lblClass.TabIndex = 27;
            this.lblClass.Text = "Class:";
            // 
            // cbbClass
            // 
            this.cbbClass.FormattingEnabled = true;
            this.cbbClass.Location = new System.Drawing.Point(86, 94);
            this.cbbClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbClass.Name = "cbbClass";
            this.cbbClass.Size = new System.Drawing.Size(220, 24);
            this.cbbClass.TabIndex = 1;
            // 
            // lblFee
            // 
            this.lblFee.AutoSize = true;
            this.lblFee.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFee.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFee.Location = new System.Drawing.Point(26, 267);
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(45, 22);
            this.lblFee.TabIndex = 28;
            this.lblFee.Text = "Fee:";
            // 
            // txbFee
            // 
            this.txbFee.Enabled = false;
            this.txbFee.Location = new System.Drawing.Point(86, 267);
            this.txbFee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbFee.Name = "txbFee";
            this.txbFee.Size = new System.Drawing.Size(220, 22);
            this.txbFee.TabIndex = 29;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.White;
            this.btnPrint.Image = global::PBL3TrungTamDayThem.Properties.Resources.Printer_icon;
            this.btnPrint.Location = new System.Drawing.Point(205, 321);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(101, 50);
            this.btnPrint.TabIndex = 30;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::PBL3TrungTamDayThem.Properties.Resources.search_icon1;
            this.btnSearch.Location = new System.Drawing.Point(205, 176);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 50);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // UC_Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txbFee);
            this.Controls.Add(this.lblFee);
            this.Controls.Add(this.cbbClass);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.grbDSSV);
            this.Controls.Add(this.pnlHeader);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_Bill";
            this.Size = new System.Drawing.Size(1159, 972);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.grbDSSV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox grbDSSV;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cbbClass;
        private System.Windows.Forms.Label lblFee;
        private System.Windows.Forms.TextBox txbFee;
        private System.Windows.Forms.Button btnPrint;
    }
}
