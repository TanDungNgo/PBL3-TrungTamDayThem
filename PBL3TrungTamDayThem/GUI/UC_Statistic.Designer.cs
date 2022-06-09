﻿namespace PBL3TrungTamDayThem.GUI
{
    partial class UC_Statistic
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblYear = new System.Windows.Forms.Label();
            this.btnTKMH = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnTKDT = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.SystemColors.Control;
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(907, 48);
            this.pnlHeader.TabIndex = 27;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(299, 13);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(134, 32);
            this.lblHeader.TabIndex = 19;
            this.lblHeader.Text = "Thống Kê";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(130)))));
            this.panel1.Controls.Add(this.lblYear);
            this.panel1.Controls.Add(this.btnTKMH);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.btnTKDT);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(907, 128);
            this.panel1.TabIndex = 29;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ForeColor = System.Drawing.SystemColors.Control;
            this.lblYear.Location = new System.Drawing.Point(24, 33);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(60, 25);
            this.lblYear.TabIndex = 44;
            this.lblYear.Text = "Năm:";
            // 
            // btnTKMH
            // 
            this.btnTKMH.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTKMH.Image = global::PBL3TrungTamDayThem.Properties.Resources.statistical;
            this.btnTKMH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTKMH.Location = new System.Drawing.Point(554, 33);
            this.btnTKMH.Name = "btnTKMH";
            this.btnTKMH.Size = new System.Drawing.Size(194, 75);
            this.btnTKMH.TabIndex = 2;
            this.btnTKMH.Text = "     Thống kê môn học";
            this.btnTKMH.UseVisualStyleBackColor = true;
            this.btnTKMH.Click += new System.EventHandler(this.btnTKMH_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(28, 67);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(194, 35);
            this.comboBox1.TabIndex = 1;
            // 
            // btnTKDT
            // 
            this.btnTKDT.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTKDT.Image = global::PBL3TrungTamDayThem.Properties.Resources.statistical;
            this.btnTKDT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTKDT.Location = new System.Drawing.Point(289, 35);
            this.btnTKDT.Name = "btnTKDT";
            this.btnTKDT.Size = new System.Drawing.Size(206, 75);
            this.btnTKDT.TabIndex = 0;
            this.btnTKDT.Text = "     Thống kê doanh thu";
            this.btnTKDT.UseVisualStyleBackColor = true;
            this.btnTKDT.Click += new System.EventHandler(this.btnTKDT_Click);
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(0, 176);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "DoanhThu";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(907, 433);
            this.chart1.TabIndex = 30;
            this.chart1.Text = "chart1";
            // 
            // UC_Statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlHeader);
            this.Name = "UC_Statistic";
            this.Size = new System.Drawing.Size(907, 609);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Button btnTKMH;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnTKDT;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
