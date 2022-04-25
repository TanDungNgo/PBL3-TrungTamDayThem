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
    public partial class UC_Class : UserControl
    {
        public UC_Class()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormClass frm = new FormClass();    
            frm.ShowDialog();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {

        }
    }
}
