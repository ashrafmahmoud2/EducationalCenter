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
    public partial class ucPersoneCard : UserControl
    {
        public ucPersoneCard()
        {
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            frmAddEditPersone frrm=new frmAddEditPersone();
            frrm.ShowDialog();
        }
    }
}
