namespace PBL3TrungTamDayThem.GUI
{
    partial class UC_Staff
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
            this.panel = new System.Windows.Forms.Panel();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.cbbPosition = new System.Windows.Forms.ComboBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
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
            this.lblHeader.Location = new System.Drawing.Point(290, 12);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(232, 26);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Thông Tin Nhân Viên";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.LightGray;
            this.panel.Controls.Add(this.dgvStaff);
            this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel.Location = new System.Drawing.Point(0, 166);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(806, 323);
            this.panel.TabIndex = 1;
            // 
            // dgvStaff
            // 
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStaff.Location = new System.Drawing.Point(0, 0);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.RowHeadersWidth = 51;
            this.dgvStaff.RowTemplate.Height = 24;
            this.dgvStaff.Size = new System.Drawing.Size(806, 323);
            this.dgvStaff.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 48);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(806, 119);
            this.panel5.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.txbName);
            this.panel3.Controls.Add(this.lblName);
            this.panel3.Controls.Add(this.cbbPosition);
            this.panel3.Controls.Add(this.lblPosition);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(320, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(486, 119);
            this.panel3.TabIndex = 2;
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
            this.panel6.Size = new System.Drawing.Size(410, 119);
            this.panel6.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::PBL3TrungTamDayThem.Properties.Resources.add_icon1;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(39, 14);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 40);
            this.btnAdd.TabIndex = 34;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.White;
            this.btnShow.Image = global::PBL3TrungTamDayThem.Properties.Resources.show_icon;
            this.btnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShow.Location = new System.Drawing.Point(175, 64);
            this.btnShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(105, 40);
            this.btnShow.TabIndex = 37;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.Image = global::PBL3TrungTamDayThem.Properties.Resources.edit_icon;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(175, 13);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(105, 40);
            this.btnEdit.TabIndex = 36;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.White;
            this.btnDel.Image = global::PBL3TrungTamDayThem.Properties.Resources.delete_icon1;
            this.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel.Location = new System.Drawing.Point(39, 64);
            this.btnDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(105, 40);
            this.btnDel.TabIndex = 35;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::PBL3TrungTamDayThem.Properties.Resources.search_icon1;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(352, 53);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 40);
            this.btnSearch.TabIndex = 47;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(106, 70);
            this.txbName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(188, 22);
            this.txbName.TabIndex = 46;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblName.Location = new System.Drawing.Point(28, 74);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 19);
            this.lblName.TabIndex = 45;
            this.lblName.Text = "Name:";
            // 
            // cbbPosition
            // 
            this.cbbPosition.FormattingEnabled = true;
            this.cbbPosition.Location = new System.Drawing.Point(106, 22);
            this.cbbPosition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbPosition.Name = "cbbPosition";
            this.cbbPosition.Size = new System.Drawing.Size(188, 24);
            this.cbbPosition.TabIndex = 44;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPosition.Location = new System.Drawing.Point(28, 27);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(72, 19);
            this.lblPosition.TabIndex = 43;
            this.lblPosition.Text = "Position:";
            // 
            // UC_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Name = "UC_Staff";
            this.Size = new System.Drawing.Size(806, 489);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cbbPosition;
        private System.Windows.Forms.Label lblPosition;
    }
}
