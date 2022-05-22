using PBL3TrungTamDayThem.BLL;
using PBL3TrungTamDayThem.DAL;
using PBL3TrungTamDayThem.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3TrungTamDayThem.GUI
{
    public partial class UC_Class : UserControl
    {
        public UC_Class()
        {
            InitializeComponent();
            SetGUI();
        }
        public void SetCBB()
        {
            if (cbbSubject != null)
            {
                cbbSubject.Items.Clear();
            }
            cbbSubject.Items.Add("All");
            cbbSubject.Items.AddRange(BLL_QLLH.Instance.GetListCBB().Distinct().ToArray());
        }
        public void SetGUI()
        {
            SetCBB();
            cbbSubject.Text = "All";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormClass frm = new FormClass();
            frm.ShowDialog();
        }
        public void ShowDGV()
        {
            dgv_Class.DataSource = BLL_QLLH.Instance.GetListClass(cbbSubject.Text, cbbClass.Text);
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            ShowDGV();
        }
    }
}
