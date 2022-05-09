namespace PBL3TrungTamDayThem.GUI
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txbFee = new System.Windows.Forms.TextBox();
            this.lblFee = new System.Windows.Forms.Label();
            this.cbbClass = new System.Windows.Forms.ComboBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(806, 441);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(323, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 441);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvBill);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(4, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 435);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Học Viên";
            // 
            // dgvBill
            // 
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Location = new System.Drawing.Point(0, 24);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.RowHeadersWidth = 51;
            this.dgvBill.RowTemplate.Height = 24;
            this.dgvBill.Size = new System.Drawing.Size(475, 411);
            this.dgvBill.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.btnPrint);
            this.panel3.Controls.Add(this.txbFee);
            this.panel3.Controls.Add(this.lblFee);
            this.panel3.Controls.Add(this.cbbClass);
            this.panel3.Controls.Add(this.lblClass);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.txbName);
            this.panel3.Controls.Add(this.lblName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(325, 441);
            this.panel3.TabIndex = 1;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.White;
            this.btnPrint.Image = global::PBL3TrungTamDayThem.Properties.Resources.Printer_icon;
            this.btnPrint.Location = new System.Drawing.Point(201, 276);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(101, 50);
            this.btnPrint.TabIndex = 38;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // txbFee
            // 
            this.txbFee.Enabled = false;
            this.txbFee.Location = new System.Drawing.Point(82, 222);
            this.txbFee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbFee.Name = "txbFee";
            this.txbFee.Size = new System.Drawing.Size(220, 22);
            this.txbFee.TabIndex = 37;
            // 
            // lblFee
            // 
            this.lblFee.AutoSize = true;
            this.lblFee.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFee.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFee.Location = new System.Drawing.Point(22, 222);
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(45, 22);
            this.lblFee.TabIndex = 36;
            this.lblFee.Text = "Fee:";
            // 
            // cbbClass
            // 
            this.cbbClass.FormattingEnabled = true;
            this.cbbClass.Location = new System.Drawing.Point(82, 49);
            this.cbbClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbClass.Name = "cbbClass";
            this.cbbClass.Size = new System.Drawing.Size(220, 24);
            this.cbbClass.TabIndex = 31;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.ForeColor = System.Drawing.SystemColors.Control;
            this.lblClass.Location = new System.Drawing.Point(22, 51);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(60, 22);
            this.lblClass.TabIndex = 35;
            this.lblClass.Text = "Class:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::PBL3TrungTamDayThem.Properties.Resources.search_icon1;
            this.btnSearch.Location = new System.Drawing.Point(201, 131);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 50);
            this.btnSearch.TabIndex = 34;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(82, 92);
            this.txbName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(220, 22);
            this.txbName.TabIndex = 33;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblName.Location = new System.Drawing.Point(22, 95);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 22);
            this.lblName.TabIndex = 32;
            this.lblName.Text = "Name:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblHeader);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(806, 48);
            this.panel4.TabIndex = 1;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(353, 11);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(100, 26);
            this.lblHeader.TabIndex = 34;
            this.lblHeader.Text = "Biên Lai";
            // 
            // UC_Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Name = "UC_Bill";
            this.Size = new System.Drawing.Size(806, 489);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txbFee;
        private System.Windows.Forms.Label lblFee;
        private System.Windows.Forms.ComboBox cbbClass;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.Label lblHeader;
    }
}
