﻿using PBL3TrungTamDayThem.BLL;
using PBL3TrungTamDayThem.DAL;
using PBL3TrungTamDayThem.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3TrungTamDayThem.GUI
{
    public partial class FormTeacher : Form
    {
        private string _MaGV;
        public FormTeacher(string MaGV = null)
        {
            InitializeComponent();
            this._MaGV = MaGV;
            SetGUI();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            DataProvider dataProvider = new DataProvider();
            int check = dataProvider.ExecuteScalar("Select count(*) from GIAO_VIEN where MaGV = '" + txtID.Text + "'");
            if (check == 0)
            {
                try
                {
                    string query = "Insert into GIAO_VIEN(MaGV, HoTenGV, NgaySinh, GioiTinh, DiaChi, ChuyenMon, TrinhDo, SDT, Email, Luong)" +
                                    "values ('" + txtID.Text + "',N'" + txtName.Text + "','" + dtpBD.Value + "','" + rbMale.Checked + "',N'" + txtAddress.Text +
                                    "',N'" + txtExpertise.Text + "',N'" + cbbLevel.Text + "','" + txtPhone.Text + "','" + txtMail.Text + "','" + txtSalary.Text + "')";
                    int ret = dataProvider.ExecuteNonQuery(query);
                    if (ret > 0)
                    {
                        MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    string query = "Update GIAO_VIEN set MaGV = '" + txtID.Text + "',HoTenGV = N'" + txtName.Text + "',NgaySinh = '" + dtpBD.Value +
                                    "',GioiTinh = '" + rbMale.Checked + "',DiaChi = N'" + txtAddress.Text + "',ChuyenMon = N'" + txtExpertise.Text +
                                    "',TrinhDo = N'" + cbbLevel.Text + "',SDT ='" + txtPhone.Text + "',Email ='" + txtMail.Text + "',Luong ='" + txtSalary.Text +
                                    "' Where MaGV = '" + txtID.Text + "'";
                    int ret = dataProvider.ExecuteNonQuery(query);
                    if (ret > 0)
                    {
                        MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Cập nhật thất bại thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnSave_MouseMove(object sender, MouseEventArgs e)
        {
            btnSave.BackColor = Color.MediumSeaGreen;
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.White;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            txtMail.Text = "";
            cbbLevel.Text = "";
            txtExpertise.Text = "";
            txtSalary.Text = "";
        }

        private void btnReset_MouseMove(object sender, MouseEventArgs e)
        {
            btnReset.BackColor = Color.DeepSkyBlue;
        }

        private void btnReset_MouseLeave(object sender, EventArgs e)
        {
            btnReset.BackColor = Color.White;
        }

        private void btnBack_MouseMove(object sender, MouseEventArgs e)
        {
            btnBack.BackColor = Color.Crimson;
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.BackColor = Color.White;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetGUI()
        {
            Teacher teacher = BLL_QLGV.Instance.GetGVByID(this._MaGV);
            if (teacher != null)
            {
                txtID.Text = teacher.MaGV;
                txtName.Text = teacher.HoTenGV;
                txtPhone.Text = teacher.SDT;
                txtAddress.Text = teacher.DiaChi;
                txtMail.Text = teacher.Email;
                txtSalary.Text = teacher.Luong;
                txtExpertise.Text = teacher.ChuyenMon;
                cbbLevel.Text = teacher.TrinhDo;
                dtpBD.Text = teacher.NgaySinh.ToString();
                if (teacher.GioiTinh == "Nam")
                {
                    rbMale.Checked = true;
                }
                else
                    rbFemale.Checked = true;
            }    
        }
    }
}
