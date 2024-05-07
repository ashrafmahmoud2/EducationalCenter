using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Student_Center.People.user_control
{
    public partial class ucPersoneCardWithFilter : UserControl
    {
        public ucPersoneCardWithFilter()
        {
            InitializeComponent();
        }

        private void ucPersoneCard1_Load(object sender, EventArgs e)
        {
            frmAddEditPersone frm=new frmAddEditPersone();
            frm.ShowDialog();
        }
    }
}
