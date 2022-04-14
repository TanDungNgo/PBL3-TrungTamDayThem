using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3TrungTamDayThem
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            uC_Teacher1.BringToFront();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            uC_Student1.BringToFront();
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            uC_Class1.BringToFront();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            uC_Bill1.BringToFront();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            uC_Staff1.BringToFront();
        }
    }
}
