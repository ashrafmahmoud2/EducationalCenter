using My_Student_Center.People;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Student_Center.Genral.user_control
{
    public partial class ucFilter : UserControl
    {
        public ucFilter()
        {
            InitializeComponent();
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditPersone frm=new frmAddEditPersone();
            frm.ShowDialog();
        }
    }
}
